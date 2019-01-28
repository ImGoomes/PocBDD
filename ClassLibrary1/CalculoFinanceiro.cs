﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDexemplo
{
    public static class CalculoFinanceiro
    {

        public static double CalcularValorComJurosComposto(double valorEmprestimo, int numMeses, double taxa)
        {
            return Math.Round(valorEmprestimo * Math.Pow((1 + taxa / 100), numMeses), 2);
        }
    }
}
