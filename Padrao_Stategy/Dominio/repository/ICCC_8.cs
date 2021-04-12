using Padrao_Stategy.Dominio.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao_Stategy.Dominio.repository
{
    public class ICCC_8 : IImposto, IVerificaOrcamento
    {
        public double calculaPorcentagem(double orcamento)
        {
            return orcamento * 0.8;
        }
        public double Calcular(double orcamento)
        {
            var resultado = 0.0;
            resultado = calculaPorcentagem(orcamento);
            return resultado;
        }
    }
}
