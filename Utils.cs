using System;

namespace SimpleSortingAlgoritms
{
   public static class Utils
   {
        public static void SwapElements(int[] sourceArray, int firstIndex, int secondIndex)
        {
            int tmp = sourceArray[firstIndex];
            sourceArray[firstIndex] = sourceArray[secondIndex];
            sourceArray[secondIndex] = tmp;
        }

        public static void PrintArray(int[] sourceArray, string sortType)
        {
            Console.WriteLine("{0} sort: ", sortType);
            foreach (int i in sourceArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");
        }

        public static int[] GenerateRandomArrayWithDefinedSize(int arraySize)
        {
            int[] resultArray = new int[arraySize];
            var randomGenerator = new Random();
            for (int index = 0; index < arraySize; index++)
            {
                resultArray[index] = randomGenerator.Next(50);
            }

            return resultArray;
        }
    }
}