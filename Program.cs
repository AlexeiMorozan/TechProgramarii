using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArraysLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int menuNumber = Int32.MinValue;
            while(menuNumber != 0)
            {
                Console.WriteLine("\n1 - bubble sort\n2 - selection sort\n3 - gnome sort\n0- exit");
                while (!int.TryParse(Console.ReadLine(), out menuNumber))
                {
                    Console.WriteLine("\nВведите число!\n");
                }
                if (menuNumber == 0)
                {
                    break;
                }
                Console.WriteLine("Array length>>");
                int arrayLength;
                while (!int.TryParse(Console.ReadLine(), out arrayLength))
                {
                    Console.WriteLine("\nВведите число!\n");
                }
                int[] array = new int[arrayLength];
                int elemIn = 0;
                Console.WriteLine("Array elements>>\n1 - from keyboard\n2 - random elements");
                while (!int.TryParse(Console.ReadLine(), out elemIn))
                {
                    Console.WriteLine("\nВведите число!\n");
                }
                if(elemIn == 1)
                {
                    for (int i = 0; i<arrayLength; i++)
                    {
                        int tempNumber;
                        while(!int.TryParse(Console.ReadLine(), out tempNumber))
                        {
                            Console.WriteLine("\nВведите целое число!\n");
                        }
                        array[i] = tempNumber;
                    }
                }
                else
                {
                    Random random = new Random();
                    for (int i = 0; i<arrayLength; i++)
                    {
                        int rnd = random.Next(-101, 101);
                        if (!array.ToList().Contains(rnd))
                        {
                            array[i] = rnd;
                        }
                    }
                }
                
                Console.Clear();
                switch (menuNumber)
                {
                    case 1:
                        print(array, 300);
                        array = bubbleSort(array);
                        Console.Clear();
                        Console.WriteLine("Сортировка пузырьком\nУпорядоченный массив:");
                        print(array, 300);
                        break;
                    case 2:
                        //Selection Sort
                        print(array, 300);
                        array = SelectionSort(array);
                        Console.Clear();
                        Console.WriteLine("Сортировка выборкой\nУпорядоченный массив:");
                        print(array, 300);
                        break;
                    case 3:
                        print(array, 300);
                        array = GnomeSort(array);
                        Console.Clear();
                        Console.WriteLine("Гномья сортировка\nУпорядоченный массив:");
                        print(array, 300);
                        break;
                        //DEFAULT
                    default:
                        break;
                }
            }
        }

        static void swap(ref int e1, ref int e2)
        {
            int temp = e1;
            e1 = e2;
            e2 = temp;
        }
        
        static int[] bubbleSort(int[] array)
        {
            Console.Clear();
            for(int i = 1; i < array.Length; i++)
            {
                for(var j=0; j < array.Length - i; j++)
                {
                    //
                    //
                    for (int ii = 0; ii<array.Length; ii++)
                    {
                        if (ii == j || ii == j+1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(array[ii] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(array[ii] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }
                    Console.WriteLine();
                    for (int ii = 0; ii<array.Length; ii++)
                    {
                        if (ii == j || ii == j+1)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(array[ii] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.Write(array[ii] + " ");
                        }

                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    //
                    //
                    if (array[j] > array[j+1])
                    {
                        for (int ii = 0; ii<array.Length; ii++)
                        {
                            if (ii == j || ii == j+1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(array[ii] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(array[ii] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }
                        Console.WriteLine();
                        for (int ii = 0; ii<array.Length; ii++)
                        {
                            if (ii == j || ii == j+1)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(array[ii] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write(array[ii] + " ");
                            }

                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        //
                        //
                        swap(ref array[j], ref array[j+1]);
                        //
                        //
                        for (int ii = 0; ii<array.Length; ii++)
                        {
                            if (ii == j || ii == j+1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(array[ii] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(array[ii] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }
                        Console.WriteLine();
                        for (int ii = 0; ii<array.Length; ii++)
                        {
                            if (ii == j || ii == j+1)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(array[ii] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write(array[ii] + " ");
                            }

                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        //
                        //
                    }
                    else
                    {
                        //
                        //
                        for (int ii = 0; ii<array.Length; ii++)
                        {
                            if (ii == j || ii == j+1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(array[ii] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(array[ii] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }
                        Console.WriteLine();
                        for (int ii = 0; ii<array.Length; ii++)
                        {
                            if (ii == j || ii == j+1)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(array[ii] + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write(array[ii] + " ");
                            }

                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        //
                        //
                        
                    } 
                }
            }
            return array;
        }

        static void outputArray(int[] array, string message = "")
        {
            if(message != null)
            {
                Console.WriteLine(message);
            }
            array.ToList().ForEach(x =>
            {
                Console.Write(x+" ");
                Thread.Sleep(300);
            });
        }

        static int min(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                //
                for (int ii = 0; ii<array.Length; ii++)
                {
                    if (ii == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(array[ii] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(array[ii] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
                Console.WriteLine();
                for (int ii = 0; ii<array.Length; ii++)
                {
                    if (ii == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(array[ii] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(array[ii] + " ");
                    }

                }
                Thread.Sleep(400);
                Console.Clear();

                //
                if (array[i] < array[result])
                {
                    
                    result = i;
                }

            }
            return result;
        }

        static void print(int[] array, int x)
        {
            for (int i = 0; i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Thread.Sleep(x);
        }
        static void outputArray(int[] array,int x, int index, int currentIndex)
        {
            for (int i = 0; i<array.Length; i++)
            {
                if (i == index || i ==currentIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(array[i] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(array[i] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }
            Console.WriteLine();
            for (int i = 0; i<array.Length; i++)
            {
                if(i == index || i ==currentIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(array[i] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                } else
                {
                    Console.Write(array[i] + " ");
                }
                
            }
            Thread.Sleep(x);
        }
        static int[] SelectionSort(int[] array, int currentIndex = 0)
        {
            Console.Clear();
            var index = min(array, currentIndex);
            //
            for (int i = 0; i<array.Length; i++)
            {
                if (i == index)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(array[i] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(array[i] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            Console.WriteLine();
            for (int i = 0; i<array.Length; i++)
            {
                if (i == index)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(array[i] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write(array[i] + " ");
                }

            }
            Thread.Sleep(400);
            Console.Clear();
            //
            outputArray(array, 500, index, currentIndex);
            if (currentIndex == array.Length)
                return array;
            
            if (index != currentIndex)
            {
                swap(ref array[index], ref array[currentIndex]);
            }
            Console.Clear();
            outputArray(array, 500, index, currentIndex);
            Thread.Sleep(500);
            return SelectionSort(array, currentIndex + 1);
        }

        static int[] GnomeSort(int[] array)
        {
            var index = 1;
            var nextIndex = index + 1;

            while (index < array.Length)
            {
                Console.Clear();
                outputArray(array, 500, index, nextIndex);
                if (array[index - 1] < array[index])
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    swap(ref array[index - 1], ref array[index]);
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }

            return array;
        }
    }
}
