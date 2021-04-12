using Padrao_Stategy.Dominio.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao_Stategy.Application
{
    public class CalcularImposto
    {
        public double RealizaCalculoImposto(double orcamento,IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
