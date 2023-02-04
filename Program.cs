using System;

namespace _03._02._2023
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //1
            int Multip_1 = 0; int Multip_2 = 0;
            int Summ_1 = 0; int Summ_2 = 0;
            int Summ_element_AandB = 0;//сумма элиментов 2-ух массивов
            int Multip_element_AandB = 0;//произведение элиментов 2-ух массивов
            int Summ_of_even_elements_of_array_A = 0;//сумму четных элементов массива А//+
            int Summ_of_odd_columns_of_arrat_B = 0; //сумму нечетных элиментов  массива Б//+
            int[] Mass1 = new int[5];
            Console.WriteLine("Enter mass");
            for (int i =0; i<Mass1.Length; i++ )
            {
                Mass1[i] = Convert.ToInt32(Console.ReadLine());
                //Console.Write("{O,4}",Mass1[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0;i<Mass1.Length; i++)
            {
                Console.Write("{0}\t",Mass1[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i<Mass1.Length; i++)//сумму четных элементов массива А
            {
                if (Mass1[i]%2==0)
                {
                    Summ_of_even_elements_of_array_A += Mass1[i];
                }
            }
            Console.Write("Сумму четных элементов массива А = " + Summ_of_even_elements_of_array_A);
            int[,] Mass = new int[3, 4];
            Random R = new Random();
            for (int i = 0; i<Mass.GetLength(0); i++)
            {
                for (int j = 0; j<Mass.GetLength(1);j++)
                {
                    Mass[i, j] = R.Next(5, 40);
                    Console.Write("{0,4}", Mass[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    if (Mass[i,j]!%2==0)
                    {
                        Summ_of_odd_columns_of_arrat_B+=Mass[i,j];
                    }
                }
                
            }
            Console.Write("Cумму нечетных элиментов  массива Б = " + Summ_of_odd_columns_of_arrat_B);

            for (int i = 0; i < Mass1.Length; i++)
            {
                Summ_1 += Mass1[i];
            }
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    Summ_2 += Mass[i, j];
                }
                
            }
            Summ_element_AandB = Summ_1 + Summ_2;
            Console.WriteLine("Сумма масивов = "+ Summ_element_AandB);

            for (int i = 0; i<Mass1.Length; i++)
            {
                Multip_1*= Mass1[i];
            }
            for (int i= 0; i<Mass.GetLength(0); i++)
            {
                for (int j = 0; j<Mass.GetLength(1);j++ )
                {
                    Multip_2 *= Mass[i, j];
                }
            }
            Multip_element_AandB = Multip_1 * Multip_2;
            Console.WriteLine("Произведение = " + Multip_element_AandB);

            //2

            /*int[,] Mass = new int[5,5];
            Random R = new Random();
            for (int i = 0; i<Mass.GetLength(0); i++)
            {
                for (int j = 0; j<Mass.GetLength(1); j++)
                {
                    Mass[i, j] = R.Next(-100, 100);
                }
            }
            for (int i = 0; i<Mass.GetLength(0); i++)
            {
                for (int j = 0; j<Mass.GetLength(1); j++)
                {
                    Console.Write(Mass[i, j]+"\t");
                }
                Console.WriteLine();
            }
            int Summ = 0;
            int max = Mass[0, 0];
            int min = Mass[0, 0];
            int min_Index_X = 0;
            int max_Index_Y = 0;
            int max_Index_X = 0;
            int mai_Index_Y = 0;
            for (int i = 0; i<Mass.GetLength(0); i++)
            {
                for (int j = 0; j<Mass.GetLength(1); j++)
                {
                    if (Mass[i,j]>max)
                    {
                        max = Mass[i,j];
                        max_Index_X = i;
                        min_Index_X = j;

                    }
                    if (Mass[i,j]<Mass[0,0])
                    {
                        min = Mass[i, j];
                        min_Index_X = i;
                        mai_Index_Y = j;
                    }
                }
            }
            min = Mass[min_Index_X, min_Index_X];
            max = Mass[max_Index_X, max_Index_Y];
            for (int i = 0; i<Mass.GetLength(0); i++)
            {
                for (int j = 0; j<Mass.GetLength(1); j++)
                {
                    if (Mass[i,j] >= Mass[min_Index_X,mai_Index_Y] || Mass[i,j]<=Mass[max_Index_X,max_Index_Y])
                    {
                        Summ = +Mass[i, j];
                    }
                }
            }
            Console.Write("Summ = " + Summ);*/


            //4
            /*int[,] Mass = new int[2, 2] { {2,4},{5,3 } };
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    Console.Write(Mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] Mass2 = new int[2, 2] { { 3, 1 }, { 9, 4 } };
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    Console.Write(Mass2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int Multiply = 0, Summ = 0, Divion = 0;
            Console.WriteLine("Введите число на которое будет умножаться матрица");
            int Numder = int.Parse(Console.ReadLine());
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    Multiply = Numder * Mass[i, j];
                    Console.Write(Multiply+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма двух матриц");
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    Summ = Mass[i, j] + Mass2[i, j];
                    Console.Write(Summ+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Произведение двух матриц");
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    Divion = Mass[i, j] * Mass2[i, j];
                    Console.Write(Divion + "\t");
                }
                Console.WriteLine();
            }*/

        }


    }

}



    