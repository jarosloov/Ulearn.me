using System;

namespace MaxIndex
{
    class Program
    {
        static double Min(double[] array)
        {
            var min = double.MaxValue;
            foreach (var item in array)
                if (item < min) min = item;
            return min;
        }
        static int MaxIndex(double[] array)
        {
            if (array.Length == 0)
                return -1;
            var max = double.MinValue;
            int index = 0;
            for(int item = 0; item < array.Length; ++item)
            {
                if(array[item] > max && max != array[item])
                {
                    max = array[item];
                    index = item;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            double[] arrayToPower = new double[] { 0, 100, 1, 2, 100 };
            Console.WriteLine(MaxIndex(arrayToPower));
        }
    }
}
