using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using BDDexemplo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BDDexemplo.testes
{
    [Binding]
    public sealed class CalcFinanceiroSteps
    {

        private double _valorEmprestimo;
        private double _taxa;
        private int _meses;
        private double _valorFinalPeriodo;

        [Given("que o valor de emprestimo foi R\\$ (.*)")]
        public void CarregarValorEmprestimo(double valorEmprestimo)
        {
            this._valorEmprestimo = valorEmprestimo;
        }

        [Given("foi defenida uma taxa de (.*)% mensais")]
        public void CarregarTaxa(double taxa)
        {
            this._taxa = taxa;
        }

        [Given("um periodo de (.*) meses")]
        public void CarregarNumMeses(int meses)
        {
            this._meses = meses;
        }


        [When("eu solicitar o valor ao final do periodo")]
        public void ProcessarCalculo()
        {
            this._valorFinalPeriodo = CalculoFinanceiro.CalcularValorComJurosComposto(this._valorEmprestimo, this._meses, this._taxa);
        }

        [Then("o valor total a ser pago será R\\$ (.*)")]
        public void VerificarResultado(double valorFinalPeriodo)
        {
            Assert.AreEqual(valorFinalPeriodo, this._valorFinalPeriodo);
        }
    }
}
