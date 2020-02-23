using System;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader("XMLSchema1.xsd");
                XmlSchema myschema = XmlSchema.Read(reader, ValidationCallback);
                myschema.Write(Console.Out);
                var e = myschema.Elements.GetEnumerator();

                var ett = e.MoveNext();

                var row = myschema.Items[0];

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void ValidationCallback(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                Console.Write("WARNING: ");
            else if (args.Severity == XmlSeverityType.Error)
                Console.Write("ERROR: ");

            Console.WriteLine(args.Message);
        }
    }

}
