﻿string textReaderText = "TextReader é uma classe base abstrata "  +
                "de StreamReader e StringReader, que lê caracteres" +
                "de streams e strings, respectivamente.\n\n"+

                "Crie uma instância de TextReader para abrir umm arquivo de texto" +
                "para ler um arquivo um intervalo especificado de caracteres" +
                "ou pasra criar um leitor baseado em um fluxo existente.\n\n" +

                "Você também pode usar uma instância de TextReader para ler " +
                "texto  de armazenamento de suporte personalizado usando as mesmas " +
                "APIs que você usaria para uma string ou um fluxo.\n\n";
              
Console.WriteLine($"Texto original: {textReaderText}");

string linha, paragrafo = null;
var sr = new StringReader(textReaderText);

while(true)
{
    linha = sr.ReadLine();
    if(linha != null)
    {
        paragrafo += linha + " "; //+=  = paragrafo = paragrafo + linha 
    }
    else
    {
        paragrafo += '\n';
        break;  
    }
}

Console.WriteLine($"Texto modificado: {paragrafo}");
int caracterLido;
char caracterConvertido;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

while (true)
{
    caracterLido =sr.Read();
    if(caracterLido == -1) break;

    caracterConvertido = Convert.ToChar(caracterLido);
    
    if (caracterConvertido == '.')
    {
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(caracterConvertido);
    }
    
}
Console.WriteLine($"Texto armazenado no StringWriter: {sw.ToString()}");
Console.WriteLine("\n\nDigite [enter] para finalizar...");
Console.ReadLine();
    


