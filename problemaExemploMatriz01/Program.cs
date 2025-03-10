using System;
using System.ComponentModel;
using System.Globalization;

namespace problemaExemploMatriz01 {
    class URI {
        static void Main(string[] args) {

            int n;
            int[,] a;

            n = int.Parse(Console.ReadLine());
            a = new int[n,n];

            //LINHA MATRIZ
            for(int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                //COLUNA MATRIZ
                for(int j = 0; j < n; j++) {
                    a[i,j] = int.Parse(vet[j]);
                }
            }

            //DIAGONAL PRINCIPAL
            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for(int i = 0; i < n; i++) {
                Console.Write(a[i,i] + " ");
            }
            Console.WriteLine();

            //VERIFICAR QUAIS OS NUMEROS NEGATIVOS DA MATRIZ

            int count = 0;
            //LINHA MATRIZ
            for(int i = 0; i < n; i++) {
                //COLUNA MATRIZ
                for(int j = 0; j < n; j++) {
                    if(a[i,j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("QUANTIDADES NEGATIVOS: " + count);
        }
        }
    }



