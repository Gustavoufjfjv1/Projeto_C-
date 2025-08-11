using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativaAgosto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Random r = new Random();
            int[,] mat = new int[10, 10];
            string texto = "";
            int menor = 99;
            int numeros = 0;
            double media = 0;
            string iguais = "";

            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    mat[i, j] = r.Next(100);
                    texto += mat[i, j] + " ";

                    if (mat[i, j] < menor)
                    {
                        menor = mat[i, j];
                    }
                    numeros += mat[i, j];
                    if(i == j)
                    {
                        iguais += mat[i, j] + ", ";
                    }
                }
                texto += "\n";
            }

            media = numeros / (30 * 30);

            Console.WriteLine(texto);
            Console.WriteLine("menor número da matriz: " + menor);
            Console.WriteLine("média da matriz: " + media);
            Console.WriteLine("elementos cujo 'i' e 'j' são iguais: " + iguais);
            Console.ReadKey();*/

            /*Random r = new Random();
            int[,] mat = new int[4, 6];
            string texto = "";
            int[] SOMACOLUNA = new int[6];
            string textoColuna = "";
            int colunasSomada = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    mat[i, j] = r.Next(100);
                    texto += mat[i, j] + " ";
                    SOMACOLUNA[j] += mat[i, j];
                }
                texto += "\n"; 
            }

            for(int j = 0; j < 6; j++)
            {
                textoColuna += SOMACOLUNA[j] + ", ";
                colunasSomada += SOMACOLUNA[j];
            }

            Console.WriteLine(texto);
            Console.WriteLine("Soma das colunas: " + textoColuna);
            Console.WriteLine("Soma da soma das colunas: " + colunasSomada);
            Console.ReadKey();

            Random r = new Random();
            int[,] mat = new int[3, 3];
            string texto = "";
            int[,] mat2 = new int[3, 3];
            string texto2 = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat[i, j] = r.Next(100);
                    texto += mat[i, j] + " ";
                }
                texto += "\n";
            }

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    mat2[j, i] = mat[i, j];
                    texto2 += mat2[j, i] + " ";
                }
                texto2 += "\n";
            }

            Console.WriteLine(texto);
            Console.WriteLine(texto2);
            Console.ReadKey();

            string[,] mat = new string[5, 10];
            string texto = "";


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mat[i, j] = "O";

                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(j < 5)
                    {
                        if (i + j >= 4)
                        {
                            mat[i, j] = "X";
                        }
                    }
                    else
                    {
                        if (j - i <= 5)
                        {
                            mat[i, j] = "X";
                        }

                    }
                    texto += mat[i, j] + " ";

                }
                texto += "\n";
            }

            Console.WriteLine(texto);
            Console.ReadKey();

            string[,] mat = new string[10, 10];
            string texto = "";


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mat[i, j] = "O";

                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(i <= 4)
                    {
                        if (j < 5)
                        {
                            if (i + j >= 4)
                            {
                                mat[i, j] = "X";
                            }
                        }
                        else
                        {
                            if (j - i <= 5)
                            {
                                mat[i, j] = "X";
                            }

                        }
                    }
                    else
                    {
                        if (j < 5)
                        {
                            if (i - j <= 5)
                            {
                                mat[i, j] = "X";
                            }
                        }
                        else
                        {
                            if (i + j <= 14)
                            {
                                mat[i, j] = "X";
                            }

                        }
                    }
                    texto += mat[i, j] + " ";

                }
                texto += "\n";
            }

            Console.WriteLine(texto);
            Console.ReadKey();*/

            string[,] mat = new string[10, 10];
            string texto = "";


                        for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mat[i, j] = " O ";

                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                   
                    
                   
                    if(j %2 == 0) {
                       mat[i, j] = " X ";
                   }
                   if(i == 0){
                       mat[i, j] = " X "; 
                   }
                   texto += mat[i, j]; 
                   
                }
                texto += "\n";
            }

            Console.WriteLine(texto);
            Console.ReadKey();

        }
    }
}


