using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Sorting
    {
        public static void FromTopToBottom(int[] array, int volume)
        {
            int[] array1 = new int[volume];
            array1 = array;
            int temp;
            Console.WriteLine("Result:");
            for (int i = 0; i < volume; i++)
            {
                for (int j = i + 1; j < volume; j++)
                    if (array1[i] < array1[j])
                    {
                        temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                    }
                Console.WriteLine(array1[i]);
            }
        }
        public static void FromBottomToTop(int[] array, int volume)
        {
            int[] array1 = new int[volume];
            array1 = array;
            int temp;
            Console.WriteLine("Result:");
            for (int i = 0; i < volume; i++)
            {
                for (int j = i + 1; j < volume; j++)
                    if (array1[i] > array1[j])
                    {
                        temp = array1[j];
                        array1[j] = array1[i];
                        array1[i] = temp;
                    }
                Console.WriteLine(array1[i]);
            }
        }
        public static void FromBottomToTopRow(int[,] array_2D, int Row, int Column)
        {
            int[,] array2D = new int[Row, Column];
            array2D = array_2D;
            int temp;
            Console.WriteLine("Result:");
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    for (int k = j + 1; k < Column; k++)
                    {
                        if (array2D[i, j] > array2D[i, k])
                        {
                            temp = array2D[i, k];
                            array2D[i, k] = array2D[i, j];
                            array2D[i, j] = temp;
                        }
                    }
                    Console.Write(array2D[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void FromTopToBottomRow(int[,] array_2D, int Row, int Column)
        {
            int[,] array2D = new int[Row, Column];
            array2D = array_2D;
            int temp;
            Console.WriteLine("Result:");
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    for (int k = j + 1; k < Column; k++)
                    {
                        if (array2D[i, j] < array2D[i, k])
                        {
                            temp = array2D[i, j];
                            array2D[i, j] = array2D[i, k];
                            array2D[i, k] = temp;
                        }
                    }
                    Console.Write(array2D[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void FromBottomToTopColumn(int[,] array_2D, int Row, int Column)
        {
            int[,] array2D = new int[Row, Column];
            array2D = array_2D;
            int temp;
            Console.WriteLine("Result:");
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    for (int k = j + 1; k < Column; k++)
                    {
                        if (array2D[i, j] > array2D[k, j])
                        {
                            temp = array2D[k, j];
                            array2D[k, j] = array2D[i, j];
                            array2D[i, j] = temp;
                        }
                    }
                    Console.Write(array2D[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void FromTopToBottomColumn(int[,] array_2D, int Row, int Column)
        {
            int[,] array2D = new int[Row, Column];
            array2D = array_2D;
            int temp;
            Console.WriteLine("Result:");
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    for (int k = i + 1; k < Row; k++)
                    {
                        if (array2D[i, j] < array2D[k, j])
                        {
                            temp = array2D[i, j];
                            array2D[i, j] = array2D[k, j];
                            array2D[k, j] = temp;
                        }
                    }
                    Console.Write(array2D[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void FindMax(int[] array)
        {
            Console.WriteLine($"Maximum number in array {array.Max()}"); 
        }
        public static void FindMin(int[] array)
        {
            Console.WriteLine($"Minimum number in array {array.Min()}");
        }
        public static void FindMax(int[,] array_2D, int Row, int Column)
        {
            int[,] array2d = new int[Row, Column];
            array2d = array_2D;
            int max = 0;
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                max = array_2D[i,j] > max ? array_2D[i,j] : max;
            }
            Console.WriteLine($"Maximum number is {max}");
        }
        public static void FindMin(int[,] array_2D, int Row, int Column)
        {
            int[,] array2d = new int[Row, Column];
            array2d = array_2D;
            int min = 0;
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                    min = array_2D[i, j] < min ? array_2D[i, j] : min;
            }
            Console.WriteLine($"Minimum number is {min}");
        }
    }
}