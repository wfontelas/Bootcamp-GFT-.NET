using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "William";
p1.Idade = 39;
p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua General Carneiro",
    Numero = 489,
    CEP = "14405-106",
    Cidade = "Franca",
};

WriteLine("Fim");
