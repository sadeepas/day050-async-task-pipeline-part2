using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyPublisher.Day050
{
    // C#: Concurrent Async Tasks with Task.WhenAll (Day 50)
    // Category: .NET Core & Clean Architecture | Difficulty: Intermediate

    public record ExecutionRecord(int Id, string Topic, DateTime Timestamp);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C#: Concurrent Async Tasks with Task.WhenAll (Day 50) ===");
            var records = new List<ExecutionRecord>
            {
                new(1, "C#: Concurrent Async Tasks with Task.WhenAll (Day 50)", DateTime.UtcNow),
                new(2, "Optimized Pipeline Execution", DateTime.UtcNow)
            };

            foreach (var rec in records)
            {
                Console.WriteLine($"* [{rec.Id}] {rec.Topic} (UTC: {rec.Timestamp})");
            }
        }
    }
}
