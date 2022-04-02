using CsvHelper.Configuration.Attributes;
    public class Livro
    {
        //[Name("titulo")]//Anotation
        //[Index(0)]// SEM cabeçalho no arquivo.csv
        public string Titulo { get; set; }
        //[Name("autor")]//Com cabeçalho no arquivo.csv
        //[Index(2)]
        public string Autor { get; set; }
        //[Name("preço")]
        //[Index(1)]
        //[CultureInfo("pt-BR")]
        public decimal Preco { get; set; }
        //[Name("lançamento")]
        //[Index(3)]
        //[Format("dd/mm/yyyy")]
        public DateOnly Lancamento { get; set; }  
    }
