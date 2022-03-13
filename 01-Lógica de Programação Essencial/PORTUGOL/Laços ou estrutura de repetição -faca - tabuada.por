programa
{
	
	funcao inicio()
	{
		inteiro contador, limite, resultado,tabuada,ultimoNumero
		
		contador=0
		

		escreva("Qual tabuada vc quer que eu resolva?: ")
		leia(tabuada)

		escreva("Qual o ultimo numero que será multiplicado?: ")
		leia(ultimoNumero)

		limite = ultimoNumero
		

		faca{

			resultado = tabuada * contador
			escreva(tabuada + " X " + contador + " = " + resultado + "\n")
			contador++ //É a mesma coisa que contador = contador+1
			
		}enquanto(contador<=limite)
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 469; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */