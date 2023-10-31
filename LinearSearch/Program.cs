using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {

           


           
                runApp();
            }

            static void runApp()
            {
                int[] marks = { 55, 66, 43, 73, 99, 85, 69, 88, 90, 78 };

                Console.Write("Enter the value to search: ");
                if (int.TryParse(Console.ReadLine(), out int Value))
                {
                    int index = LinearSearch(marks, Value);

                    if (index != -1)
                    {
                        Console.WriteLine($"Element {Value} found at index {index}");
                    Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Element {Value} not found in the array");
                    Console.ReadLine();
                   
                    }
                }

            }

            static int LinearSearch(int[] arr, int target)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == target)
                    {
                        return i; // Element found, return its index
                    }
                }

                return -1; // Element not found
            
            }
       
        }

    }

