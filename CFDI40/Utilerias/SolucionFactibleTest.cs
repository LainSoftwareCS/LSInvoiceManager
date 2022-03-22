using SFTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSInvoiceManager.CFDI40.Utilerias
{
    public  class SolucionFactibleTest
    {
        public static CFDICertificacion timbrar(byte[] cfdi)
        {
            var cliente = new TimbradoPortTypeClient(TimbradoPortTypeClient.EndpointConfiguration.TimbradoHttpsSoap11Endpoint);
            var response = cliente.timbrar("testing@solucionfactible.com", "timbrado.SF.16672", cfdi, false );
            return response;
        }
    }
}
