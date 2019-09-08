using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        namespace teste_estagio_ivory_2
        {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Digite um nome: ");
                string nome = Console.ReadLine();

                char[] vetorNome = nome.ToCharArray();
                int contadorNome = 0;

                int totalColunas = nome.Length + 2;
                string[,] matrizPrincipal = new string[3, totalColunas];

                int numero = 1;
                int totalCaracteres = 3 * totalColunas - vetorNome.Length;
                int valorInicialUtlimaLinha = totalCaracteres - 1;

                for (int linha = 0; linha < 3; linha++)
                {
                    for (int coluna = 0; coluna < totalColunas; coluna++)
                    {
                        //Na primeira linha incrementar valor de acordo com a coluna atual.
                        if (linha == 0)
                        {
                            matrizPrincipal[linha, coluna] = numero.ToString();
                            numero++;
                        }
                        //Na segunda linha deve ser inserido o nome
                        else if (linha == 1)
                        {
                            //Se for primeira coluna
                            if (coluna == 0)
                            {
                                matrizPrincipal[linha, coluna] = totalCaracteres.ToString();
                            }
                            //se for ultima coluna
                            else if (coluna == totalColunas - 1)
                            {
                                matrizPrincipal[linha, coluna] = (totalCaracteres / 2).ToString();
                            }
                            //se for colunas intermediarias
                            else
                            {
                                string letraNome = vetorNome[contadorNome].ToString();
                                matrizPrincipal[linha, coluna] = letraNome;
                                contadorNome++;
                            }
                        }
                        //Se for ultima linha
                        else
                        {
                            matrizPrincipal[linha, coluna] = valorInicialUtlimaLinha.ToString();
                            valorInicialUtlimaLinha--;
                        }
                    }

                }

                Imprimir(matrizPrincipal, totalColunas);
                Console.ReadKey();
            }
            /// <summary>
            /// Método utilizado para impressão de matrizes
            /// </summary>
            /// <param name="matriz">Matriz a ser impressa</param>
            /// <param name="qtdColunas">Quantidade de colunas</param>
            static void Imprimir(string[,] matriz, int qtdColunas)
            {
                for (int linha = 0; linha < 3; linha++)
                {
                    for (int coluna = 0; coluna < qtdColunas; coluna++)
                    {
                        Console.Write(matriz[linha, coluna] + "\t");
                    }
                    Console.WriteLine(string.Empty);
                }
            }
        }
    }


    

