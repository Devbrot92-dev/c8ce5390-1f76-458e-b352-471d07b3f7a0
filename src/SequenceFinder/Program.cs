using SequenceFinder;

if (args.Length == 0)
{
    Console.WriteLine("Please provide a whitespace-separated sequence of integers");
    Environment.ExitCode = 1;
    return;
}

try
{
    string input = string.Join(" ", args);
    string result = IncreasingSequenceFinder.Find(input);

    Console.WriteLine(result);
}
catch (FormatException ex)
{
    Console.Error.WriteLine($"Invalid input: {ex.Message}");
    Environment.ExitCode = 1;
}