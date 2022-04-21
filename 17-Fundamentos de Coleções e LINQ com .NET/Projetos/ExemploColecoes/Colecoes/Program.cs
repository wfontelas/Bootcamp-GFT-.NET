﻿int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

var minimo = arrayNumeros.Min();
var maximo = arrayNumeros.Max();
var medio = arrayNumeros.Average();
var soma = arrayNumeros.Sum();
var arrayUnico = arrayNumeros.Distinct().ToArray();


System.Console.WriteLine($"Minimo: {minimo}");
System.Console.WriteLine($"Maximo: {maximo}");
System.Console.WriteLine($"Medio: {medio}");
System.Console.WriteLine($"Soma: {soma}");
System.Console.WriteLine($"Array original: {string.Join(",", arrayNumeros)}");
System.Console.WriteLine($"Array distinto: {string.Join(",", arrayUnico)}");




// var numerosParesQuery =
//         from num in arrayNumeros
//         where num % 2 == 0
//         orderby num 
//         select num;

//  var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList(); 

//  System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
//  System.Console.WriteLine("Números pares metodo: " + string.Join(", ", numerosParesMetodo));


// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");

// foreach (KeyValuePair<string, string> item in estados)
// {
//     // System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string valorProcurado = "SC";
// // var teste = estados["SC"];

// if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
// {
//     System.Console.WriteLine(estadoEncontrado);
// }
// else
// {
//     System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
// }
// System.Console.WriteLine($"Removendo o valor: {valorProcurado}");

// estados.Remove(valorProcurado);

// foreach (KeyValuePair<string, string> item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// System.Console.WriteLine("Valor original:");
// System.Console.WriteLine(estados[valorProcurado]);

// estados[valorProcurado] ="BA - teste atualização";

// System.Console.WriteLine("Valor atualizado:");
// System.Console.WriteLine(estados[valorProcurado]);



// Stack<string> pilhaLivros = new Stack<string>();

// pilhaLivros.Push(".NET");
// pilhaLivros.Push("DDD");
// pilhaLivros.Push("Código limpo");

// System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
// while (pilhaLivros.Count > 0)
// {
//     System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
//     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
// }

// System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");



// Queue<string> fila = new Queue<string>();

// fila.Enqueue("William");
// fila.Enqueue("Caroline");
// fila.Enqueue("Alice");

// System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

// while (fila.Count > 0)
// {
//     System.Console.WriteLine($"Vez de: {fila.Peek()} ");
//     System.Console.WriteLine($"{fila.Dequeue()} atendido");
// }

// System.Console.WriteLine($"Pessoas na fila: {fila.Count}");


// OperacoesLista opLista = new OperacoesLista();
// List<string> estados = new List<string>();
// string[] estadosArray = new string[2] {"SC", "MT"};

// estados.Add("SP");
// estados.Add("MG");
// estados.Add("BA");

// System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}\n");

// opLista.ImprimirListaString(estados);

// System.Console.WriteLine("\nElementos da Lista com acréscimo do Array: \n" );

// System.Console.WriteLine("Removendo o elemento");
// estados.Remove("MG");

// estados.AddRange(estadosArray);
// estados.Insert(1, "RJ");

// opLista.ImprimirListaString(estados);





// OperacoesArray op = new OperacoesArray();

// int[] array = new int[5] {6, 3, 8, 1, 9};
// int[] arrayCopia = new int[10];
// string[] arrayString = op.ConverterParaArrayString(array);

// // int valorProcurado = 8;

// System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

// op.RedimensionarArray(ref array, array.Length * 3);

// System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");

// int indice = op.ObterIndice(array, valorProcurado);

// if (indice > -1)
// {
//     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
// }
// else
// {
//     System.Console.WriteLine("Valor não existente no array");
// }


// int valorAchado = op.ObterValor(array, valorProcurado);

// if(valorAchado > 0)
// {
//     System.Console.WriteLine("Encontrei o valor");
// }
// else
// {
//     System.Console.WriteLine("Não encontrei o valor");
// }


// bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

// if(todosMaiorQue)
// {
//     System.Console.WriteLine("Todos os valores são maior que {0}", valorProcurado);    
// }
// else
// {
//     System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
// }


// bool existe = op.Existe(array, valorProcurado);

// if(existe)
// {
//     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
// }
// else
// {
//     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
// }

// System.Console.WriteLine("Array original:");
// op.imprimirArray(array);

// op.OrdenarBubbleSort(ref array);
// op.Ordenar(ref array);

// System.Console.WriteLine("Array ordenado:");
// op.imprimirArray(array);

// System.Console.WriteLine("Array antes da cópia:");
// op.imprimirArray(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);
// System.Console.WriteLine("Array após a cópia:");
// op.imprimirArray(arrayCopia);

// int [,] matriz = new int[4, 2]
// {
//     {8, 8},
//     {10, 20},
//     {50, 100},
//     {90, 200}
// };
// for (int i = 0; i < matriz.GetLength(0); i++)//coluna 1
// {
//     for (int j = 0; j < matriz.GetLength(1) ; j++)//coluna 2
//     {
//         System.Console.WriteLine(matriz[i, j]);
//     }
// }



// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = int.Parse("30");

// // arrayInteiros[3] = 30;

// System.Console.WriteLine("Percorrendo o array pelo For");
// for (int i = 0; i < arrayInteiros.Length; i++) //trabalha variavel de posição(index)
// {
//     System.Console.WriteLine(arrayInteiros[i]);
// }
// System.Console.WriteLine("Percorrendo o Array pelo Foreach");//joga o valor do array dentro da variavel item e percorre o array
// foreach (int item in arrayInteiros)
// {
//     System.Console.WriteLine(item);    
// }
