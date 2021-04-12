using Padrao_Stategy.Dominio.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao_Stategy.Dominio.repository
{
    public class ICCC : IImposto
    {
        public double Calcular(double orcamento)
        {
            IVerificaOrcamento v = new ICCC_5();

            return v.calculaPorcentagem(orcamento);
        }
    }
}
