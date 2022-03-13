programa
{
	
	funcao inicio()
	{
		real janeiro,fevereiro,marco,abril,media

		escreva("janeiro: ")
		leia(janeiro)
		escreva("fevereiro: ")
		leia(fevereiro)
		escreva("março: ")
		leia(marco)
		escreva("abril: ")
		leia(abril)
		media=(janeiro+fevereiro+marco+abril)
		se (media >= 5000){
		escreva("/n"+"Parabéns!!Você ganhou um abono de 10%")	
	}
		senao{
		escreva("/n"+"Infelizmente você vai receber somente 3% de abono")
	}
}
  }
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 443; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */