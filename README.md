# ivory-teste-estagio-setembro-2019
<h3><b>Exercício 1:</b></h3> 

Objetivo: Teste de análise de conhecimento para vaga de estágio, o objetivo do código é realizar um cálculo numérico usando recursividade.

Execução: 

1- Na função principal "Main", são declaradas duas variáveis do tipo Inteiro "numero" e "resultado".

2- À variável "numero" é atribuido o valor 5, e a variável "resultado" é atribuido o resultado do método "calcular".

3- O método "calcular" é um método do tipo Inteiro que  recebe um parâmetro do tipo inteiro.
Em sua execução é declarada uma variável local do tipo Inteiro chamada resultado.

4- É realizado um teste lógico para verificar se o parâmetro "numero" é menor ou igual a zero. Em caso positivo, o método retorna o valor zero, caso contrário, ele atribui à variável resultado o valor de "numero" multiplicado pelo próprio método calcular " de forma recursiva" passando como parâmetro o valor de número decrementando 1 de seu valor. Retornando assim o valor calculado através da variável resultado.

<h3><b>Processo de execução:</b></h3>

Passo 1- Função "Calcular" recebe o valor 5, realiza teste lógico e entra no cenário de negação.

Passo 2- Else: resultado = 5 * calcular(5-1);

Passo 3- Função "Calcular" recebe o valor 4, realiza teste lógico e entra no cenário de negação.

Passo 4- Else: resultado = 4 * calcular(4-1);

Passo 5- Função "Calcular" recebe o valor 4, realiza teste lógico e entra no cenário de negação.

Passo 6- Else: resultado = 3 * calcular(3-1);

Passo 7- Função "Calcular" recebe o valor 4, realiza teste lógico e entra no cenário de negação.

Passo 8- Else: resultado = 2 * calcular(2-1);

Passo 9- Função "Calcular" recebe o valor 4, realiza teste lógico e entra no cenário de negação.

Passo 10- Else: resultado = 1 * calcular(1-1);

Passo 11- Função "Calcular" recebe o valor 0, realiza teste lógico e entra no cenário positivo, onde zero é igual à zero
e retorna à função Main o valor de zero e este é impresso em tela.



<h3><b>Sugestão para redução de linhas de código:</b></h3>

Alteração do método Calcular para:

	static int Calcular(int numero)
	{
		return numero <= 0 ? 0 : numero * Calcular(numero-1);
	}

	
	<p>
	<b><h3>Exercício 2</h3></b>
	O exercício 2 trata-se do código fonte referente à este projeto.
	</p>