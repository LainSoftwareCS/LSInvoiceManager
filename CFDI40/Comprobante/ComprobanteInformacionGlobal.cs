namespace LSInvoiceManager.CFDI40
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteInformacionGlobal
    {

        private c_Periodicidad periodicidadField;

        private c_Meses mesesField;

        private short añoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Periodicidad Periodicidad
        {
            get
            {
                return this.periodicidadField;
            }
            set
            {
                this.periodicidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Meses Meses
        {
            get
            {
                return this.mesesField;
            }
            set
            {
                this.mesesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public short Año
        {
            get
            {
                return this.añoField;
            }
            set
            {
                this.añoField = value;
            }
        }
    }
}
