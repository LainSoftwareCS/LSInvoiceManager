namespace LSInvoiceManager.CFDI40
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteEmisor
    {

        private string rfcField;

        private string nombreField;

        private c_RegimenFiscal regimenFiscalField;

        private string facAtrAdquirenteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FacAtrAdquirente
        {
            get
            {
                return this.facAtrAdquirenteField;
            }
            set
            {
                this.facAtrAdquirenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rfc
        {
            get
            {
                return this.rfcField;
            }
            set
            {
                if (value.Length != 12 && value.Length != 13)
                    throw new Exception("ERROR. [ComprobanteEmisor.RFC] El campo solo admite valores de 12 o 13 caracteres");
                this.rfcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_RegimenFiscal RegimenFiscal
        {
            get
            {
                return this.regimenFiscalField;
            }
            set
            {
                this.regimenFiscalField = value;
            }
        }

        /// <remarks
        /// ESTE CAMPO NO DEBE EXISTIR SEGUN EL SAT
        //[System.Xml.Serialization.XmlAttributeAttribute()]
        //public string FacAtrAdquirente
        //{
        //    get
        //    {
        //        return this.facAtrAdquirenteField;
        //    }
        //    set
        //    {
        //        this.facAtrAdquirenteField = value;
        //    }
        //}
    }

}
