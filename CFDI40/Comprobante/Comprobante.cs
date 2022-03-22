using LSInvoiceManager.CFDI40.Utilerias;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace LSInvoiceManager.CFDI40
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/4", IsNullable = false)]

    public partial class Comprobante
    {

        private ComprobanteInformacionGlobal informacionGlobalField;

        private ComprobanteCfdiRelacionados[] cfdiRelacionadosField;

        private ComprobanteEmisor emisorField;

        private ComprobanteReceptor receptorField;

        private ComprobanteConcepto[] conceptosField;

        private ComprobanteImpuestos impuestosField;

        private ComprobanteComplemento complementoField;

        private ComprobanteAddenda addendaField;

        private string versionField;

        private string serieField;

        private string folioField;

        private System.String fechaField;

        private string selloField;

        private c_FormaPago formaPagoField;

        private bool formaPagoFieldSpecified;

        private string noCertificadoField;

        private string certificadoField;

        private string condicionesDePagoField;

        private decimal subTotalField;

        private decimal descuentoField;

        private bool descuentoFieldSpecified;

        private c_Moneda monedaField;

        private decimal tipoCambioField;

        private bool tipoCambioFieldSpecified;

        private decimal totalField;

        private c_TipoDeComprobante tipoDeComprobanteField;

        private c_Exportacion exportacionField;

        private c_MetodoPago metodoPagoField;

        private bool metodoPagoFieldSpecified;

        private string lugarExpedicionField;

        private string confirmacionField;

        public Comprobante()
        {
            this.versionField = "4.0";
        }

        private string NombreArchivo ()
        {
            return $"{Serie}{Folio}_{Emisor.Rfc}_{Receptor.Rfc}";
        }

        public static string NombreArchivo(String _serie, String _folio, String _emisor_rfc, String _receptor_rfc)
        {
            return $"{_serie}{_folio}_{_emisor_rfc}_{_receptor_rfc}";
        }

        public string NombrePDF() {
            return $"{NombreArchivo()}.PDF";
        }
        public string NombreXML()
        {
            return $"{NombreArchivo()}.XML";
        }


        public String CadenaOriginal(Comprobante comprobante, String xslt)
        {
            return CFDIXMLTrasnformer.getXSLTTransform(CFDIXMLTrasnformer.Serialize<Comprobante>(comprobante), xslt);
        }


        public void Serializa(String archivo) {
            XmlSerializer serializer = new XmlSerializer(GetType());
            using (StreamWriter sw = new StreamWriter(archivo, false, System.Text.Encoding.UTF8))
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                ns.Add("cfdi", "http://www.sat.gob.mx/cfd/4");
                ns.Add("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital");

                serializer.Serialize(sw, this, ns);


                sw.Close();
            }
        }

        //public string CadenaOriginal(String coFilePath, String comprobanteFilePath) {
        //    string cadenaOriginal = "";
        //    System.Xml.Xsl.XslCompiledTransform transformador = new System.Xml.Xsl.XslCompiledTransform(true);
        //    transformador.Load(coFilePath);

        //    using (StringWriter sw = new StringWriter())
        //    using (XmlWriter xwo = XmlWriter.Create(sw, transformador.OutputSettings))
        //    {

        //        transformador.Transform(comprobanteFilePath, xwo);
        //        cadenaOriginal = sw.ToString();
        //    }
        //    return cadenaOriginal;
        //}



        /// <remarks/>
        public ComprobanteInformacionGlobal InformacionGlobal
        {
            get
            {
                return this.informacionGlobalField;
            }
            set
            {
                this.informacionGlobalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CfdiRelacionados")]
        public ComprobanteCfdiRelacionados[] CfdiRelacionados
        {
            get
            {
                return this.cfdiRelacionadosField;
            }
            set
            {
                this.cfdiRelacionadosField = value;
            }
        }

        /// <remarks/>
        public ComprobanteEmisor Emisor
        {
            get
            {
                return this.emisorField;
            }
            set
            {
                this.emisorField = value;
            }
        }

        /// <remarks/>
        public ComprobanteReceptor Receptor
        {
            get
            {
                return this.receptorField;
            }
            set
            {
                this.receptorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Concepto", IsNullable = false)]
        public ComprobanteConcepto[] Conceptos
        {
            get
            {
                return this.conceptosField;
            }
            set
            {
                this.conceptosField = value;
            }
        }

        /// <remarks/>
        public ComprobanteImpuestos Impuestos
        {
            get
            {
                return this.impuestosField;
            }
            set
            {
                this.impuestosField = value;
            }
        }

        /// <remarks/>
        public ComprobanteComplemento Complemento
        {
            get
            {
                return this.complementoField;
            }
            set
            {
                this.complementoField = value;
            }
        }

        /// <remarks/>
        public ComprobanteAddenda Addenda
        {
            get
            {
                return this.addendaField;
            }
            set
            {
                this.addendaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                if (value.Length == 0 || value.Length > 25)
                    throw new Exception("ERROR. [Comprobante.Serie] El valor de la serie debe de ser entre 1 a 25 caracteres alfanumericos");
                this.serieField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Folio
        {
            get
            {
                return this.folioField;
            }
            set
            {
                if (value.Length == 0 || value.Length > 40)
                    throw new Exception("ERROR. [Comprobante.Folio] El valor de folio debe de ser entre 1 a 40 caracteres alfanumericos");
                this.folioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Fecha
        {
            get
            {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sello
        {
            get
            {
                return this.selloField;
            }
            set
            {
                this.selloField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_FormaPago FormaPago
        {
            get
            {
                return this.formaPagoField;
            }
            set
            {
                this.formaPagoField = value;
                formaPagoFieldSpecified = true;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormaPagoSpecified
        {
            get
            {
                return this.formaPagoFieldSpecified;
            }
            set
            {
                this.formaPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoCertificado
        {
            get
            {
                return this.noCertificadoField;
            }
            set
            {
                this.noCertificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Certificado
        {
            get
            {
                return this.certificadoField;
            }
            set
            {
                this.certificadoField = value;
            }
        }

        /// <remarks/>
        /// !! SE QUITA DEBIDO A DOCUMENTACION DE SAT PAGINA 7 
        /// http://omawww.sat.gob.mx/tramitesyservicios/Paginas/documentos/GuiallenadoCFDIglobal311221.pdf
        //[System.Xml.Serialization.XmlAttributeAttribute()]
        //public string CondicionesDePago
        //{
        //    get
        //    {
        //        return this.condicionesDePagoField;
        //    }
        //    set
        //    {
        //        this.condicionesDePagoField = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SubTotal
        {
            get
            {
                return this.subTotalField;
            }
            set
            {
                if (value < 0)
                    throw new Exception("ERROR. [Comprobante.Subtotal] El campo no puede ser negativo");
                this.subTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Descuento
        {
            get
            {
                return this.descuentoField;
            }
            set
            {

                if (value < 0)
                    throw new Exception("ERROR. [Comprobante.Descuento] El campo no puede ser negativo");
                DescuentoSpecified = true;
                this.descuentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescuentoSpecified
        {
            get
            {
                return this.descuentoFieldSpecified;
            }
            set
            {
                this.descuentoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Moneda Moneda
        {
            get
            {
                return this.monedaField;
            }
            set
            {
                this.monedaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TipoCambio
        {
            get
            {
                return this.tipoCambioField;
            }
            set
            {
                tipoCambioFieldSpecified = true;
                this.tipoCambioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCambioSpecified
        {
            get
            {
                return this.tipoCambioFieldSpecified;
            }
            set
            {
                this.tipoCambioFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {

                if (value < 0)
                    throw new Exception("ERROR. [Comprobante.Total] El campo no puede ser negativo");
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoDeComprobante TipoDeComprobante
        {
            get
            {
                return this.tipoDeComprobanteField;
            }
            set
            {
                this.tipoDeComprobanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Exportacion Exportacion
        {
            get
            {
                return this.exportacionField;
            }
            set
            {
                this.exportacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_MetodoPago MetodoPago
        {
            get
            {
                return this.metodoPagoField;
            }
            set
            {
                metodoPagoFieldSpecified = true;
                this.metodoPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MetodoPagoSpecified
        {
            get
            {
                return this.metodoPagoFieldSpecified;
            }
            set
            {
                this.metodoPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LugarExpedicion
        {
            get
            {
                return this.lugarExpedicionField;
            }
            set
            {
                this.lugarExpedicionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Confirmacion
        {
            get
            {
                return this.confirmacionField;
            }
            set
            {
                this.confirmacionField = value;
            }
        }
    }

}
