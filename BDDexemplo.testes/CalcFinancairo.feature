Funcionalidade: Calculo de juros compostos

Cenário: SimulacaoCalculo01 
	Dado que o valor de emprestimo foi R$ 10000,00
	E foi defenida uma taxa de 2% mensais 
	E um periodo de 12 meses
	Quando eu solicitar o valor ao final do periodo
	Então o valor total a ser pago será R$ 12682,42

Cenário: SimulacaoCalculo02 
	Dado que o valor de emprestimo foi R$ 11937,28
	E foi defenida uma taxa de 4% mensais 
	E um periodo de 24 meses
	Quando eu solicitar o valor ao final do periodo
	Então o valor total a ser pago será R$ 30598,88

Cenário: SimulacaoCalculo03 
	Dado que o valor de emprestimo foi R$ 15000,00
	E foi defenida uma taxa de 6% mensais 
	E um periodo de 36 meses
	Quando eu solicitar o valor ao final do periodo
	Então o valor total a ser pago será R$ 122208,78