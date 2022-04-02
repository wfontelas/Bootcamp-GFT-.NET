using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;


//LerCsvDynamic();
//LerCsvComClasse();
//LerCSVComDelimitador();
EscreverCsv();

static void EscreverCsv()
{
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Saida");

    var di = new DirectoryInfo(path);

    if(!di.Exists)
        di.Create();

    path = Path.Combine(path,"usuarios.csv");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "William Roberto Peres Fontelas",
            Email = "williamdevsuporte@gmail.com",
            Telefone = 1699988592,
            Nascimento = new DateOnly(year: 1982, month: 10, day: 13)
        },
        new Pessoa()
        {
            Nome = "Caroline Alcantara Perente Fontelas",
            Email = "ca@gmail.com",
            Telefone = 1699977592,
            Nascimento = new DateOnly(year: 1981, month: 01, day: 24)
        },
        new Pessoa()
        {
            Nome = "Alice Alcantara Fontelas",
            Email = "aa@gmail.com",
            Telefone = 1699722592,
            Nascimento = new DateOnly(year: 2016, month: 02, day: 02)
        },
        new Pessoa()
        {
            Nome = "Gumercinda Peres Fontelas",
            Email = "gf@gmail.com",
            Telefone = 1699123592,
            Nascimento = new DateOnly(year: 1948, month: 08, day: 19)
        },
    };

    using var sw = new StreamWriter(path);
    var csvConfig = new CsvConfiguration(CultureInfo.InstalledUICulture)
    {
        Delimiter = "|"
    };
    using var csvWriter = new CsvWriter(sw,csvConfig);
    csvWriter.WriteRecords(pessoas);

}

static void LerCSVComDelimitador()
{
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Entrada",
        "livros-preco-com-virgula.csv");

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe"); 

    using var sr =new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };
    using var csvReader = new CsvReader(sr,csvConfig);
    csvReader.Context.RegisterClassMap<LivroMap>();
    var registros = csvReader.GetRecords<Livro>().ToList(); //Atenção

    foreach (var registro in registros )
    {
        Console.WriteLine($"titulo: {registro.Titulo}");
        Console.WriteLine($"preço: {registro.Preco}");
        Console.WriteLine($"autor: {registro.Autor}");
        Console.WriteLine($"lançamento: {registro.Lancamento}");
        Console.WriteLine("---------------------");
    }
}

static void LerCsvComClasse()
{
     var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "novos-usuario.csv");

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"o arquivo {path} não existe");

    using var sr = new StreamReader(fi.FullName);    
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr,csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome:{registro.Nome}");
        Console.WriteLine($"email:{registro.Email}");
        Console.WriteLine($"telefone:{registro.Telefone}");
        Console.WriteLine($"--------------------------");
    }
}

static void LerCsvDynamic()
{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "Produtos.csv");

var fi = new FileInfo(path);

if(!fi.Exists)
    throw new FileNotFoundException($"O arquivo {path} não existe!");

using var sr = new StreamReader(fi.FullName);//using pq o sr é Idisposable
var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
using var csvReader = new CsvReader(sr,csvConfig);

var registros = csvReader.GetRecords<dynamic>();

foreach (var registro in registros)
{
    Console.WriteLine($"nome: {registro.Produto}");
    Console.WriteLine($"marca: {registro.Marca}");
    Console.WriteLine($"preço: {registro.Preco}");
    Console.WriteLine("--------------------------------");
}
}

 Console.WriteLine("\nAperte [enter] para finalizar...");
 Console.ReadLine();

