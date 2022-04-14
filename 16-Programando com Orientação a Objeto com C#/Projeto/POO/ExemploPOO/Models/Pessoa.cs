 public class Pessoa //Classe Pai
    {
        public string Nome {get; set;}

        public int Idade {get; set;}

        public string Documento { get; set; }

        public virtual void Apresentar()//metodo public void virtual para pode rfazer alterações
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");
        }

    }


    //Abstraimos do mundo real as informações necessarias para o objeto