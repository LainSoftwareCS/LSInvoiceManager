using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSInvoiceManager.CFDI40.Utilerias
{
    public class StreamWriterCFDI : StringWriter
    {
        public StreamWriterCFDI(Encoding encoding)
            : base()
        {
            this.m_Encoding = encoding;
        }
        private readonly Encoding m_Encoding;
        public override Encoding Encoding
        {
            get
            {
                return this.m_Encoding;
            }
        }
    }
}
