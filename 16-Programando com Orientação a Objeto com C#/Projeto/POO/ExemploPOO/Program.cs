var caminho = "C:\\workspace\\Bootcamp GFT Start #3 .NET\\16-Programando com Orientação a Objeto com C#\\Projeto\\POO\\TrabalhandoComArquivos";
var caminhoPathCombine = Path.Combine(caminho,"Pasta Teste 1 ");
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
var NovoCaminhoArquivo = Path.Combine(caminho,"Pasta Teste 2", "arquivo-teste-stream.txt");

var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

FileHelper helper = new FileHelper();
// helper.ListarDiretorios(caminho);
// helper.ListarArquivosDiretorios(caminho);
// System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
// helper.CriarDiretorio(caminhoPathCombine);
// helper.ApagarDiretorio(caminhoPathCombine, true);
// helper.CriarArquivoTexto(caminhoArquivo, "Olá!! teste de escrita de arquivo");
// helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
// helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
// helper.LerArquivoStream(caminhoArquivo);
// helper.MoverArquivo(caminhoArquivo, NovoCaminhoArquivo,false);
// helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false );
helper.DeletarArquivo(caminhoArquivoTesteCopia);



// ICalculadora calc = new Calculadora();
// System.Console.WriteLine(calc.Somar(10, 20));

// Computador comp = new Computador();
// System.Console.WriteLine(comp.ToString()); 

// Corrente c = new Corrente();
// c.Creditar(100.50);

// c.ExibirSaldo();


// Calculadora calc = new Calculadora();
// System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
// System.Console.WriteLine("Resulrado da segunda soma: " + calc.Somar(10,10,10));

// Aluno p1 = new Aluno();
// p1.Nome = "Alice";
// p1.Idade = 6;
// p1.Documento = "123456789";
// p1.Nota = 10;

// p1.Apresentar();

// Professor p2 = new Professor();
// p2.Nome = "Caroline";
// p2.Idade = 41;
// p2.Documento = "987654321";
// p2.Salario = 3000;

// p2.Apresentar();

// //Valore Válidos
// Retangulo r = new Retangulo ();

// r.DefinirMedidas(30,30);

// System.Console.WriteLine($"Área:{r.ObterArea()} ");

// //Valores Inválidos
// Retangulo r2 = new Retangulo ();

// r.DefinirMedidas(0,0);

// System.Console.WriteLine($"Área:{r2.ObterArea()} ");




// Pessoa p1 = new Pessoa();

// p1.Nome = "William"; //Pode ser manipulado pois é um objeto
// p1.Idade = 39;

// p1.Apresentar();
