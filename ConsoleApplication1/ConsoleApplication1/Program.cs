using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 

            Console.WriteLine("BinarySearch");
            int[] array = { 2, 4, 7, 10, 13, 15, 18, 20 };
            int key = 7;
            int index = BinarySearch.Binary_Search(array, array.Length, key);
            foreach (int element in array)
            {
                Console.Write(element + " ");

            }
            Console.WriteLine("");
            if (index != -1)
                Console.WriteLine("Key found at index: " + index);
            else
                Console.WriteLine("Key not found in the array.");

            Console.WriteLine("\nMergeSort");
            int[] array2 = { 20, 15, 10, 9, 4, 2 };
            Console.WriteLine("Array before sorting:");
            foreach (int element in array2)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");

            MergeSort.Merge_Sort(array2, 0, array2.Length - 1);

            Console.WriteLine("Array after sorting:");
            foreach (int element in array2)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine("\n\n Bài toán nhân 2 số nguyên lớn");

            long X = 123;
            long Y = 987;
            int N = 2;
            long result = Nhan2SoNguyenLon.Big_Number_Multi(X, Y, N);
            Console.WriteLine($"Kết quả của {X} * {Y} là {result}");

            Console.ReadKey(); 
        }
    }
}
