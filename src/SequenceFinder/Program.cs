using SequenceFinder;

if (args.Length == 0)
{
    Console.WriteLine("Please provide a whitespace-separated sequence of integers");
    return;
}

string input = string.Join(" ", args);

string result = IncreasingSequenceFinder.Find(input);

Console.WriteLine(result);