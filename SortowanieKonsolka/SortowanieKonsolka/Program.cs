using System;
using System.Collections.Generic;

namespace MainProgram
{
    class Container
    {
        public int[] numbers = new int[10];

        public void SortArray(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                int maxIndex = FindMaxIndex(numbers, i);

                int temp = numbers[i];
                numbers[i] = numbers[maxIndex];
                numbers[maxIndex] = temp;
            }
        }

        private int FindMaxIndex(int[] numbers, int start)
        {
            int maxIndex = start;

            for(int i = start + 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public void FillArray(int[] numbers)
        {
            Console.WriteLine("Wczytaj 10 liczb calkowitych do tablicy");

            for (int i = 0; i < numbers.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Podaj liczbe calkowita!");
                }
            }
        }

        public void PrintArray(int[] numbers)
        {
            int j = 1;
            foreach (int i in numbers)
            {
                Console.WriteLine($"{i} element {j} tablicy");
                j++;
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Container container = new Container();
            container.FillArray(container.numbers);
            container.PrintArray(container.numbers);  
            container.SortArray(container.numbers);
            container.PrintArray(container.numbers);
        }
    }
}