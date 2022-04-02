//using System.IO; //Opicional no .net 6.0 
using static System.Console;

WriteLine("Digite o nome do arquivo:");
var nome = ReadLine();

nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory ,$"{nome}.txt");

CriarArquivo(path);

WriteLine("Digite Enter para finalizar...");
ReadLine();

static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
{
    nome = nome.Replace(@char, '-');
}
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path); //Idisposable 
        sw.WriteLine("Está é linha 1 do arquivo");
        sw.WriteLine("Está é linha 2 do arquivo");
        sw.WriteLine("Está é linha 3 do arquivo");
        //sw.Flush(); //descarrega os streams da memoria para o arquivo ou use o using 
    }
    catch 
    {
        
       WriteLine("o nome do arquivo esta inválido!");
    }     
    
}



  