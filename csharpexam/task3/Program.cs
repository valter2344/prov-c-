using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays
            string[] name = { "Alice", "John", "Mia" };
            int[] num = { 5, 57, 87, 1, 150, 32, 14 };

            //prints first array and adds Hello before every word
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($" Hello {name[i]}");