// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");


var friends = new List<string> { "Bob", "Billy", "Sam", "Ray" };

var shortNamedFriends = friends.Where(f => f.Length < 4).ToList();

friends.Add("Sue");



foreach(var friend in shortNamedFriends)
{
    Console.WriteLine(friend);
}


//var sw = new Stopwatch();
//sw.Start();
//var numbers = NumberGenerator.GetNumbersOneToHundredAsEnumerable()
//    .Where(n => n % 2 ==0 )
//    .Select(n => n + n)
//    .Skip(5).Take(10);

//Console.WriteLine($"The total is {numbers.Sum()}");
////foreach(var num in numbers) // Ride the bike. Do it.
////{
////    Console.WriteLine(num);
    
////}
//sw.Stop();
//Console.WriteLine($"That took about {sw.ElapsedMilliseconds} milliseconds");

public static class NumberGenerator
{
    public static List<int> GetNumbersOneToOneHundred()
    {
        var numbers = new List<int>();
        for(var t = 1; t< 101; t++)
        {
            Thread.Sleep(10);
            numbers.Add(t);
        }
        return numbers;
    }

    public static IEnumerable<int> GetNumbersOneToHundredAsEnumerable()
    {
        for (var t = 1; t < 101; t++)
        {
            Thread.Sleep(10);
            yield return t;
        }
    }
}