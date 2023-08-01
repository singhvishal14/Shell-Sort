using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppShellSort
{
    internal class Program
    {
        public static void ShellSort(int[] arr)
        {
            int n = arr.Length;
            int gap = n / 2;
            while (gap > 0)
            {
                for(int i = gap; i < n; i++){
                    int temp = arr[i];
                    int j = i;
                    while(j >=gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }
                    arr[j]=temp;
                }
                gap /= 2;
            }
            

        }
        public static void Print(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, 4, 5, 2, 45, 78, 90, 122 };
            Console.WriteLine("Print Array Without Sort");
            Print(arr);
            Stopwatch stopwatch= new Stopwatch();   
            stopwatch.Start();
            ShellSort(arr);
            stopwatch.Stop();
            Console.WriteLine("After Shell Sort");
            Print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time Taken {stopwatch.Elapsed.TotalMilliseconds} miliseconds ");
            Console.ReadKey();
        }
    }
}
