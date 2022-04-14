public class Aluno : Pessoa //Alunos é classe filha
    {
        public int Nota { get; set; }  
        public override void Apresentar() //Polimorfismo em tempo de execução
        {
            Console.WriteLine($"Meu nome é {Nome} e sou um aluno(a) nota {Nota}");
        }
        
    }
    