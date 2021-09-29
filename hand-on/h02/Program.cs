using System;

List<List<int>> JobDistributor(int server, int job)
{
    int jobIndex = 0;
    int serverIndex = 0;
    int[] Node = new int[server];
    while (job != jobIndex)
    {
        if (serverIndex == server) serverIndex = 0;
        Node[serverIndex] += 1;
        jobIndex++;
        serverIndex++;
    }

    List<List<int>> WorkLoadArray = new List<List<int>>(new List<int>[server]);
    jobIndex = 0;
    serverIndex = 0;
    foreach (var value in Node)
    {
        WorkLoadArray[serverIndex] = new List<int>();
        for (int i = 0; i < value; i++)
        {
            WorkLoadArray[serverIndex].Add(jobIndex);
            jobIndex++;
        }
        serverIndex++;
    }

    return WorkLoadArray;
}

foreach (var value in JobDistributor(0, 0))
{
    Console.WriteLine("[{0}]", string.Join(", ", value));
}
Console.WriteLine("=======================================");

foreach (var value in JobDistributor(1, 2))
{
    Console.WriteLine("[{0}]", string.Join(", ", value));
}
Console.WriteLine("=======================================");
foreach (var value in JobDistributor(2, 4))
{
    Console.WriteLine("[{0}]", string.Join(", ", value));
}
Console.WriteLine("=======================================");
foreach (var value in JobDistributor(3, 3))
{
    Console.WriteLine("[{0}]", string.Join(", ", value));
}
Console.WriteLine("=======================================");
foreach (var value in JobDistributor(5, 3))
{
    Console.WriteLine("[{0}]", string.Join(", ", value));
}
Console.WriteLine("=======================================");
foreach (var value in JobDistributor(4, 10))
{
    Console.WriteLine("[{0}]", string.Join(", ", value));
}
Console.WriteLine("=======================================");
