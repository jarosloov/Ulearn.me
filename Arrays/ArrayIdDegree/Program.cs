using System;

namespace ArrayIdDegree
{
    class Program
    {
        public static int[] GetPoweredArray(int[] arr, int power)
        {
            if (arr.Length == 0)
                return arr;
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; ++i)
            {
                if (power == 0)
                    result[i] = 1;
                result[i] = (int)(Math.Pow(arr[i], power));
            }
                
            return result;
        }
        public static void PrintArray(int[] arr)
        {
            foreach (var i in arr)
                Console.Write(i + "  ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Метод PrintArray уже написан за вас
            PrintArray(GetPoweredArray(arrayToPower, 1));

            //если вы будете менять исходный массив, то следующие два теста сработают неверно:
            PrintArray(GetPoweredArray(arrayToPower, 2));
            PrintArray(GetPoweredArray(arrayToPower, 3));

            //не забывайте про частные случаи:
            PrintArray(GetPoweredArray(new int[0], 1));
            PrintArray(GetPoweredArray(new[] { 42 }, 0));
        }

        // Код Илона Маска 
        //public static int[] GetPoweredArray(int[] arr, int power)
        //{
        //    return arr.Select(x => (int)Math.Pow(x, power)).ToArray();
        //}
    }
}
