namespace CellDistance
{
    public class LD
    {
        public int Distance(int[] arr)
        {
            int maxDistance = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        maxDistance = Math.Max(maxDistance,( j - i-1));
                    }
                }
            }

            return maxDistance;
        }
    }
}
