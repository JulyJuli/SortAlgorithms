using SimpleSortingAlgoritms.Sortings;
using System;

namespace SimpleSortingAlgoritms
{
    public class TestClass
    {
        public static void Main()
        {
            int[] sourceArray = Utils.GenerateRandomArrayWithDefinedSize(10);
            Utils.PrintArray(sourceArray, "Before insertion");
            var insertionSortResult = InsertionSort.Sort(sourceArray);
            Utils.PrintArray(insertionSortResult, "After insertion");
            Console.WriteLine("----------------------");

            sourceArray = Utils.GenerateRandomArrayWithDefinedSize(20);
            Utils.PrintArray(sourceArray, "Before selection");
            var selectionSortResult = SelectionSort.Sort(sourceArray);
            Utils.PrintArray(selectionSortResult, "After selection");
            Console.WriteLine("----------------------");

            sourceArray = Utils.GenerateRandomArrayWithDefinedSize(25);
            Utils.PrintArray(sourceArray, "Before bubble");
            var bubbleSortResult = BubbleSort.Sort(sourceArray);
            Utils.PrintArray(bubbleSortResult, "After bubble");
        }
    }
}