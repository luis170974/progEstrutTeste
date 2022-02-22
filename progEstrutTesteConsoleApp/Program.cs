using System;

namespace progEstrutTesteConsoleApp
{
    /*Desenvolver um algoritmo que dados 10 valores inteiros permita: //1ª parte do elefante // ok

   • Encontrar o Maior Valor da sequência // 2ª parte ok
   • Encontrar o Menor Valor da sequência //3 ª parte ok
   • Encontrar o Valor Médio da sequência //4ª parte ok
   • Encontrar os 3 maiores valores da sequência // ok
   • Encontrar os valores negativos da sequência // ok
   • Mostrar na Tela os valores da sequência // ok
   • Remover um item da sequência

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorMaior = 0, valorMenor = 0, valorNegativo = 0;
            double valorMedio = 0;

            int[] arrayNumeros = new int[10];




            // preencher vetor

            Console.WriteLine();

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º valor: ");
                arrayNumeros[i] = Convert.ToInt32(Console.ReadLine());



            }

            valorMenor = MenorValor(arrayNumeros);
            valorMaior = MaiorValor(arrayNumeros);

            Console.WriteLine();


            //mostrar vetor
            Console.WriteLine("Todos os valores: ");

            Console.WriteLine();

            TodosOsValores(arrayNumeros);

            Console.WriteLine();

            Console.WriteLine("Os tres maiores sao: ");

            int[] vetorNumerosMaiores = TresMaiores(arrayNumeros);

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(vetorNumerosMaiores[i]);
                Console.WriteLine();


            }

            Console.WriteLine("Valores Negativos: ");

            Console.WriteLine();

            ValoresNegativos(arrayNumeros);

            Console.WriteLine("Maior valor: " + valorMaior);

            Console.WriteLine("Menor valor: " + valorMenor);

            Console.WriteLine("Valor Medio: " + valorMedio);


            /*tirar um numero da sequencia

            Console.WriteLine("Digite um numero para tirar da sequencia: ");

            int numeroTirarSequencia = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (numeroTirarSequencia == arrayNumeros[i])
                {
                    Console.WriteLine();
                    arrayNumeros[i] = arrayNumeros[i] - numeroTirarSequencia;
                }



                    Console.WriteLine(arrayNumeros[i]);

            */
            Console.ReadKey();
        }

        private static int MaiorValor(int[] arrayNumeros)
        {
            int valorMaior;
            Array.Sort(arrayNumeros);
            valorMaior = arrayNumeros[9];
            
            return valorMaior;
        }

        static void MenorValor(out int valorMenor, int[] arrayNumeros)
        {
            int valorMenor;
            Array.Sort(arrayNumeros);
            valorMenor = arrayNumeros[0];
            
        }






        static void TodosOsValores(int[] arrayNumeros)
            {
                for (int j = 0; j < arrayNumeros.Length; j++)
                {

                    Console.WriteLine(arrayNumeros[j]);
                    Console.WriteLine();


                }
            }

            static void ValoresNegativos(int[] arrayNumeros)
            {
                for (int k = 0; k < arrayNumeros.Length; k++)
                {

                    if (arrayNumeros[k] < 0)
                    {

                        Console.WriteLine(arrayNumeros[k]);
                        Console.WriteLine();
                    }


                }
            }

            static int[] TresMaiores(int[] arrayNumeros)
            {



                //os tres maiores valores
                int[] arrayInteiros = new int[arrayNumeros.Length];

                Array.Sort(arrayNumeros);

                arrayInteiros[0] = arrayNumeros[arrayNumeros.Length - 1];

                arrayInteiros[1] = arrayNumeros[arrayNumeros.Length - 2];

                arrayInteiros[2] = arrayNumeros[arrayNumeros.Length - 3];

                return (arrayInteiros);



            }
        }

    }


