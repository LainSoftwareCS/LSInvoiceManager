namespace LSInvoiceManager.CFDI40
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteReceptor
    {

        private string rfcField;

        private string nombreField;

        private string domicilioFiscalReceptorField;

        private c_Pais residenciaFiscalField;

        private bool residenciaFiscalFieldSpecified;

        private string numRegIdTribField;

        private c_RegimenFiscal regimenFiscalReceptorField;

        private c_UsoCFDI usoCFDIField;

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
        public string DomicilioFiscalReceptor
        {
            get
            {
                return this.domicilioFiscalReceptorField;
            }
            set
            {
                this.domicilioFiscalReceptorField = value;
            }
        }

        ///// <remarks/>
        ///NO DEBE DE EXISTIR SEGUN EL SAT
        //[System.Xml.Serialization.XmlAttributeAttribute()]
        //public c_Pais ResidenciaFiscal
        //{
        //    get
        //    {
        //        return this.residenciaFiscalField;
        //    }
        //    set
        //    {
        //        this.residenciaFiscalField = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalSpecified
        {
            get
            {
                return this.residenciaFiscalFieldSpecified;
            }
            set
            {
                this.residenciaFiscalFieldSpecified = value;
            }
        }

        /// <remarks/>
        /// NO DEBE DE EXISTIR SEGUN EL SAT
        //[System.Xml.Serialization.XmlAttributeAttribute()]
        //public string NumRegIdTrib
        //{
        //    get
        //    {
        //        return this.numRegIdTribField;
        //    }
        //    set
        //    {
        //        this.numRegIdTribField = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_RegimenFiscal RegimenFiscalReceptor
        {
            get
            {
                return this.regimenFiscalReceptorField;
            }
            set
            {
                this.regimenFiscalReceptorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_UsoCFDI UsoCFDI
        {
            get
            {
                return this.usoCFDIField;
            }
            set
            {
                this.usoCFDIField = value;
            }
        }
    }

}
