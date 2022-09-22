using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using static биллиг1.solution;
namespace Bench
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmarker>();
        }
    }
}
