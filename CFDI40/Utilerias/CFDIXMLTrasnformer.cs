using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace LSInvoiceManager.CFDI40.Utilerias
{
    public class CFDIXMLTrasnformer
    {
        public static string getXSLTTransform(string xml, string xslt)
        {
            XsltSettings sets = new XsltSettings(true, true);

            MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            XPathDocument xPathDocument = new XPathDocument(memoryStream);
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
            StringWriter stringWriter = new StringWriter();
            xslCompiledTransform.Load(xslt, sets, new XmlUrlResolver());
            xslCompiledTransform.Transform(xPathDocument, null, stringWriter);
            memoryStream.Close();
            return stringWriter.ToString().Replace("&amp;", "&");
        }

        public static string Serialize<T>(T x)
        {
            string str;
            if (x == null)
                return null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            XmlWriterSettings xmlWriterSetting = new XmlWriterSettings()
            {
                Encoding = new UnicodeEncoding(false, false),
                Indent = false,
                OmitXmlDeclaration = false
            };
            using (StringWriter stringWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSetting))
                {
                    xmlSerializer.Serialize(xmlWriter, x);
                }
                str = stringWriter.ToString().Replace("utf-16", "utf-8");
            }
            return str;
        }
    }
}
