namespace SimpleSortingAlgoritms.Sortings
{
    public static class InsertionSort
    {
        public static int[] Sort(int[] sourceArray)
        {
            for (int i = 1; i < sourceArray.Length; i++)
            {
                if (sourceArray[i] < sourceArray[i - 1])
                {
                    Utils.SwapElements(sourceArray, i, i - 1);

                    for (int j = i - 1; j > 0; j--)
                    {
                        if (sourceArray[j] < sourceArray[j - 1])
                        {
                            Utils.SwapElements(sourceArray, j, j - 1);
                        }
                    }
                }
            }
            return sourceArray;
        }
    }
}