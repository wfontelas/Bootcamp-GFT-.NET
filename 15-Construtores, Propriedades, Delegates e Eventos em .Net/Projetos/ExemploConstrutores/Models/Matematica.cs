public class Matematica
{
    public int X { get; set; }
    public int Y { get; set; }

    public Matematica(int x, int y)
    {
        X = x;
        Y = y;

        Calculadora.EventoCalculadora += EventHandler; //EventHandler é um objeto inscrito no EventoCalculadora
        // Calculadora.EventoCalculadora += EventoHandler_2; //mais um objeto inscrito
    }
    public void Somar()
    {
        Calculadora.Somar(X, Y);
    }

    public void EventHandler()
    {
        System.Console.WriteLine("Método executado");
        // System.Console.WriteLine("Sucesso");
    
    }
    // public void EventoHandler_2()
    // {
    //     System.Console.WriteLine("Mais um método executado através do mtodo event");
    // }
}
