using System;

namespace ConsoleApp5
{
    class Program
    {

        static void Choise(string method, int[] array, int volume)
        {
            switch (method)
            {
                
                case "1":
                    Sorting.FromTopToBottom(array, volume);
                    break;
                case "2":
                    Sorting.FromBottomToTop(array, volume);
                    break;
                case "3":
                    Sorting.FindMax(array);
                    break;
                case "4":
                    Sorting.FindMin(array);
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("You chose the unexisting method.");
                    break;
            }
        }
        
        static void Choise(string method, int[,] array_2D, int row, int column)
        {
            switch (method)
            {
                case "1":
                    Sorting.FromTopToBottomRow(array_2D, row, column);
                    break;
                case "2":
                    Sorting.FromBottomToTopRow(array_2D, row, column);
                    break;
                case "3":
                    Sorting.FromTopToBottomColumn(array_2D, row, column);
                    break;
                case "4":
                    Sorting.FromBottomToTopColumn(array_2D, row, column);
                    break;
                case "5":
                    Sorting.FindMax(array_2D, row, column);
                    break;
                case "6":
                    Sorting.FindMin(array_2D, row, column);
                    break;
                case "exit":
                    break;
                case "e":
                    break;
                default:
                    Console.WriteLine("You chose the unexisting method.");
                    break;
            }
        }

       //static void save(in int array_1D, in int array_2D, out int array_1D_duplicate, out int array_2D_duplicate)
        

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
                            int[] array_1D = new int[volume];
                            Console.WriteLine("Choose kind of array:\n1) Random;\n2) My own.");
                            string Kind = Console.ReadLine();
                            switch (Kind)
                            {
                                case "1":
                                    Console.Write("Enter the range of randomizer:\nfrom ");
                                    int from = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("to ");
                                    int to = Convert.ToInt32(Console.ReadLine());
                                    Random Random1D = new Random();
                                    for (int i = 0; i < volume; i++)
                                    {
                                        array_1D[i] = Random1D.Next(from, to);
                                        Console.Write(array_1D[i] + "\t");
                                    }
                                    Console.WriteLine();
                                    break;
                                case "2":
                                    Console.WriteLine("Enter array elements. \nIf you decided to enter less element then type 'break':");
                                    for (int i = 0; i < volume; i++)
                                    {
                                        string StringArray = Console.ReadLine();
                                        bool TryArray = int.TryParse(StringArray, out array_1D[i]);
                                        if (StringArray == "break")
                                            break;
                                        if (TryArray == false)
                                        {
                                            Console.WriteLine("Entered value is not an number.");
                                            i--;
                                            continue;
                                        }
                                    }
                                    break;
                            }
                            Console.WriteLine("What you want to do with array?\nSorting:\n1) From biggest to smallest;\n2) From smallest to biggest.\n" +
                                "Find element:\n3) Maximum value in array;\n4) Minimum value in array; ");
                            string method1D = Console.ReadLine();
                            Choise(method1D, array_1D, volume);
                        }
                        else
                        {
                            Console.WriteLine("Enter correct number.\n");
                        }
                        continue;
                    case "2":
                        Console.WriteLine("Enter rows count:");
                        string StringRow = Console.ReadLine();
                        bool TryRow = int.TryParse(StringRow, out int Row);
                        Console.WriteLine("Enter columns count:");
                        string StringColumn = Console.ReadLine();
                        bool TryColumn = int.TryParse(StringRow, out int Column);
                        int[,] array_2D = new int[Row, Column];
                        Random Random2D = new Random();
                        Console.WriteLine("Array:");
                        if (TryRow == true && TryColumn == true)
                        {
                            for (int i = 0; i < Row; i++)
                            {
                                for (int j = 0; j < Column; j++)
                                {
                                    array_2D[i, j] = Random2D.Next(-100,100);
                                    Console.Write(array_2D[i,j]+"\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine("What you want to do with array?\n Sorting: \n1) From biggest to smallest in row.\n2) From smallest to biggest in row." +
                        "\n3) From biggest to smallest in column\n4) From smallest to biggest in column \nFind element: \n5) Maximum value in array; \n6) Minimum value in array.");
                        string method2D = Console.ReadLine();
                        Choise(method2D, array_2D, Row, Column);
                        continue;
                }
                   
            }
        }
    }
}
