Parallel.For(0, 10, i =>
{
    Console.WriteLine($"Task {i} is running on thread {Task.CurrentId}");
});
Console.WriteLine("All tasks completed.");