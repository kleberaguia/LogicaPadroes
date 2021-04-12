using Padrao_Stategy.Dominio.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao_Stategy.Dominio.repository
{
    public class ICMS: IImposto
    {
        public double Calcular(double orcamento)
        {
            var resultado = orcamento * 0.5;
            return resultado;

        }
    }
}
