namespace SimpleSortingAlgoritms.Sortings
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] sourceArray)
        {
            for(int index = 0; index < sourceArray.Length; index++)
            {
                int minElementIndex = GetMinElementIndex(sourceArray, index);
                Utils.SwapElements(sourceArray, index, minElementIndex);
            }
            return sourceArray;
        }

        private static int GetMinElementIndex(int[] sourceArray, int lowBoundValue)
        {
            int minElementIndex = lowBoundValue;

            for (int i = lowBoundValue + 1; i < sourceArray.Length; i++)
            {
                if (sourceArray[i] < sourceArray[minElementIndex])
                {
                    minElementIndex = i;
                }
            }
            return minElementIndex;
        }
    }
}