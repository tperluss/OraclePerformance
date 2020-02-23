using OraclePerformance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace OraclePerformance.Service
{
    public interface ITranslationService
    {
        Task<ReportRows> Translate(string content);
    }
    public class TranslationService : ITranslationService
    {
        public async Task<ReportRows> Translate(string content)
        {
            var a = new XmlDocument();
            a.LoadXml(content);

            var resp = new ReportRows();
            foreach (XmlNode node in a.DocumentElement.ChildNodes)
            {
                var row = new Row();
                var dict = new Dictionary<string, object>();
                for (int i = 0; i < node.ChildNodes.Count; i++)
                {
                    var col = node.ChildNodes[i];
                    dict.Add($"Column{i}", col.InnerText);
                }

                row.Columns = dict;
                resp.Rows.Add(row);
            }
            resp.Rows = resp.Rows.Take(10).ToList();
            return resp;
        }
    }
}
