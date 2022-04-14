 public  class Professor : Pessoa //Professor é classe filha
    {
        public double Salario { get; set; }
          public override void Apresentar() //Polimorfismo em tempo de execução
        {
            Console.WriteLine($"Olá, Meu nome é {Nome} e sou um professor(a) e ganho R${Salario} por mês");
        }
    }