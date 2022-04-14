public class Retangulo
    {     
        private double Comprimento;
        private double Largura;
        private bool Valido;

        public void DefinirMedidas(double Comprimento, double Largura)
        {
            if(Comprimento > 0 && Largura > 0)
            {
                this.Comprimento = Comprimento;
                this .Largura = Largura;
                Valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores inválidos");
            }
           
        }
        public double ObterArea()
        {
            if (Valido)
            {
                 return Comprimento * Largura;
            }
            else
            {
                System.Console.WriteLine("Preencha valores Válidos");
                return 0;
            }
           
        }
    }

    //Fizemos o ENCAPSULAMENTO atráves do da definição das propriedades como privado e onde somente pode pode chamar a classe através do metodo publico DefinirMedidas.