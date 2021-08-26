using System;

namespace ConsoleApp5
{
    class Program
    {
        static void FromTopToBottom(int[] array, int volume)
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

        static void FromBottomToTop(int[] array, int volume)
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

       /* static void FromBottomToTop(int[,] array_2D, int Row, int Column)
        {
            int[,] array2D = new int[Row, Column];
            array2D = array_2D;
            int temp;
            Console.WriteLine("Result:");
            for (int i = 0; i < Row; i++)
            {
                for (int j = i; j < Column; j++)
                {
                    //for (int k = j + 1; )
                }
                    if (array2D[i] > array2D[j])
                    {
                        temp = array1[j];
                        array1[j] = array1[i];
                        array1[i] = temp;
                    }
                Console.WriteLine(array1[i]);
            }
        } */

        static void Choise(string method, int[] array, int volume)
        {
            switch (method)
            {
                case "1":
                    FromTopToBottom(array, volume);
                    break;
                case "2":
                    FromBottomToTop(array, volume);
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("You choose the unexisting method.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            while (true)

            {
                Console.WriteLine("\nWelcome. \nIf you want to shut down programm type 'exit' or 'e'.\n");
                Console.WriteLine("Select type of array: \n1) one-dimensional\n2) two-dimensional");
                string ArrayType = Console.ReadLine();
                if (ArrayType == "exit" || ArrayType == "e")
                    break;
                switch (ArrayType)
                {
                    case "1":
                        Console.WriteLine("Enter array volume:");
                        string StringVolume = Console.ReadLine();
                        bool TryVolume = int.TryParse(StringVolume, out int volume);
                        if (TryVolume == true)
                        {
                            Console.WriteLine("Enter array elements. \nIf you decided to enter less element then type 'break':");
                            int[] array_oneD = new int[volume];
                            for (int i = 0; i < volume; i++)
                            {
                                string StringArray = Console.ReadLine();
                                bool TryArray = int.TryParse(StringArray, out array_oneD[i]);
                                if (StringArray == "break")
                                    break;
                                if (TryArray == false)
                                {
                                    Console.WriteLine("Entered value is not an number.");
                                    i--;
                                    continue;
                                }
                            }
                            Console.WriteLine("Choose the sorting method: \n1) From biggest to smallest.\n2) From smallest to biggest.");
                            string method = Console.ReadLine();
                            Choise(method, array_oneD, volume);
                        }
                        else
                        {
                            Console.WriteLine("Enter correct number.\n");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter rows count:");
                        string StringRow = Console.ReadLine();
                        bool TryRow = int.TryParse(StringRow, out int Row);
                        Console.WriteLine("Enter columns count:");
                        string StringColumn = Console.ReadLine();
                        bool TryColumn = int.TryParse(StringRow, out int Column);
                        int[,] array_2D = new int[Row, Column];
                        Random rnd = new Random();
                        if (TryRow == true && TryColumn == true)
                        {
                            for (int i = 0; i < Row; i++)
                            {
                                for (int j = 0; j < Column; j++)
                                {
                                    array_2D[i, j] = rnd.Next(-100,100);
                                    Console.Write(array_2D[i,j]+"\t");
                                }
                                Console.WriteLine();
                            }
                            //FromBottomToTop(array_2D, Row, Column);
                        }
                        break;
                }
                   
            }
        }
    }
}
