using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OraclePerformance.Models;
using OraclePerformance.Service;
using ServiceReference1;

namespace OraclePerformance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ITranslationService _translationService;

        public ReportsController(IConfiguration config, ITranslationService svc)
        {
            _config = config;
            _translationService = svc;
        }

        [HttpPost]
        public IActionResult Test(ReportRequest request)
        {
            var client = new SAWSessionServiceSoapClient(SAWSessionServiceSoapClient.EndpointConfiguration.SAWSessionServiceSoap, _config.GetValue<string>("SessionServiceUrl"));
            //var session = client.logonAsync("oracle.admin", "Burger01!").Result;
            var session = client.logonAsync("tperluss", "7Xo34%GN1XTZ94TI4cMT").Result;

            var svc = new XmlViewServiceSoapClient(XmlViewServiceSoapClient.EndpointConfiguration.XmlViewServiceSoap, _config.GetValue<string>("XmlServiceUrl"));

            var report = new ReportRef {
                reportPath = request.ReportPath
            };

            var output = svc.executeXMLQueryAsync(report,XMLQueryOutputFormat.SAWRowsetSchemaAndData,new XMLQueryExecutionOptions(),new ReportParams(),session.sessionID).Result;
            var resp = _translationService.Translate(output.@return.rowset).Result;
            return Ok(resp);
        }

        [HttpPost]
        [Route("schema")]
        public IActionResult GetSchema(ReportRequest request)
        {
            var client = new SAWSessionServiceSoapClient(SAWSessionServiceSoapClient.EndpointConfiguration.SAWSessionServiceSoap, _config.GetValue<string>("SessionServiceUrl"));
            //var session = client.logonAsync("oracle.admin", "Burger01!").Result;
            var session = client.logonAsync("tperluss", "7Xo34%GN1XTZ94TI4cMT").Result;

            var svc = new XmlViewServiceSoapClient(XmlViewServiceSoapClient.EndpointConfiguration.XmlViewServiceSoap, _config.GetValue<string>("XmlServiceUrl"));

            request.ReportPath = HttpUtility.UrlDecode(request.ReportPath);

            var report = new ReportRef
            {
                reportPath = request.ReportPath
            };

            var output = svc.executeXMLQueryAsync(report, XMLQueryOutputFormat.SAWRowsetSchema, new XMLQueryExecutionOptions(), new ReportParams(), session.sessionID).Result;

            var schema = Deserialize<rowsetschema>(output.@return.rowset.Replace("http://www.w3.org/2001/XMLSchema", "http://www.w3.org/2001/WB"));

            var resp = new ReportSchema { Columns = new List<ColumnSchema>(), ReportPath = request.ReportPath };

            schema.schema.complexType.sequence.ToList().ForEach(a => {
                resp.Columns.Add(new ColumnSchema { 
                    ColumnId = a.columnID,
                    IsDoubleColumn = a.isDoubleColumn,
                    MaxOccurs = a.maxOccurs,
                    MinOccurs = a.minOccurs,
                    Name = a.name,
                    TableHeading = a.tableHeading,
                    ColumnHeading = a.columnHeading,
                    Type = a.type.Replace("xsd:",""),
                    SqlType = a.type1
                });
            });

            return Ok(resp);
        }

        public static T Deserialize<T>(string xmlText)
        {
            try
            {
                var stringReader = new System.IO.StringReader(xmlText);
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
            catch
            {
                throw;
            }
        }
    }
}
