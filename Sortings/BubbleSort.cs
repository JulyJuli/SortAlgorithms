namespace SimpleSortingAlgoritms.Sortings
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] sourceArray)
        {
            for(int indexI = 0; indexI < sourceArray.Length; indexI++)
            {
                for (int indexJ = indexI+1; indexJ < sourceArray.Length; indexJ++)
                {
                    if (sourceArray[indexI] > sourceArray[indexJ])
                    {
                        Utils.SwapElements(sourceArray, indexI, indexJ);
                    }
                }
            }
            return sourceArray;
        }
    }
}