using Padrao_Stategy.Dominio.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao_Stategy.Dominio.repository
{
    public class ICCC_5 :  IVerificaOrcamento
    {
        public double calculaPorcentagem(double orcamento)
        {
            return orcamento  * 0.5;
        }
    }
}
