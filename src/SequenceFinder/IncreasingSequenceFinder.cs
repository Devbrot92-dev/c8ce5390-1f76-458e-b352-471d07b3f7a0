namespace SequenceFinder;

public static class IncreasingSequenceFinder
{
    public static string Find(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return string.Empty;
        }

        int[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

       int currentStart = 0;
       int currentLength = 1;

       int bestStart = 0;
       int bestLength = 1;

       for(int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] > numbers[i-1])
            {
                currentLength++;
            }
            else
            {
                currentStart = i;
                currentLength = 1;
            }

            if(currentLength > bestLength)
            {
                bestStart = currentStart;
                bestLength = currentLength;
            }
        }

        return string.Join(" ", numbers.Skip(bestStart).Take(bestLength));
    }
}