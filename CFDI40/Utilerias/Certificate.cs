using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LSInvoiceManager.CFDI40.Utilerias
{
    public class CertificationData
    {
        public DateTime efectiveDate { get; set; }
        public DateTime expirationDate { get; set; }
        public string issuerName { get; set; }
        public string name { get; set; }
        public string nameInfo { get; set; }
        public string publicKey { get; set; }
        public string serialNumber { get; set; }
        public string rawData { get; set; }
        public string data64 { get; set; }

    }
    public class Certificate
    {
        public X509Certificate2 certification { get; set; }

        public CertificationData data { get; set; }

        public Certificate(string file, string password) {
            this.certification = new X509Certificate2(file, password);
            this.data = new CertificationData();
            this.data.issuerName = this.certification.GetIssuerName();
            this.data.name = this.certification.GetName();
            this.data.efectiveDate = DateTime.Parse(this.certification.GetEffectiveDateString());
            this.data.expirationDate = DateTime.Parse(this.certification.GetExpirationDateString());
            this.data.publicKey = this.certification.GetPublicKeyString();
            this.data.serialNumber = Convert.ToBase64String(this.certification.GetSerialNumber());
            this.data.data64 = Convert.ToBase64String(this.certification.GetRawCertData());
            string data = this.certification.GetRawCertDataString();
        }

        public void Sign(XmlDocument xmlDocument)
        {
            if (this.certification == null)
                throw new Exception("[Utilerias.Certificate] No se ha cargado ningun certificado, intente de nuevo");
            
            SignedXml signedXml = new SignedXml(xmlDocument);
            signedXml.SigningKey = this.certification.PrivateKey;
            Reference reference = new Reference();
            reference.Uri = "";
            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);
            KeyInfo keyInfo = new KeyInfo();
            keyInfo.AddClause(new KeyInfoX509Data(this.certification));
            signedXml.KeyInfo = keyInfo;
            signedXml.ComputeSignature();

        }


    }

}
