 Boolean condicao = true;
   int valor;

   do 
   {
        Console.WriteLine("Digite um valor ou 0 para Sair");
        valor = int.Parse(Console.ReadLine());
    
        if(valor == 0)
        {
           Console.WriteLine("Você saiu da aplicação");
           break;
        }
        else
        {
           Console.WriteLine("O valor informado é : " + valor);
           continue;
        }
    }
    while(condicao == true);


