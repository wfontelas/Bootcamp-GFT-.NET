﻿using System;

 class minhaClasse {
        static void Main(string[] args) {
            //continue a solucao com a insercao da variavel corretamente

            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]); 
                            
              


            if (A % B == 0 || B % A == 0 ) 
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }