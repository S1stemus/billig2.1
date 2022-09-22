using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using static биллиг1.solution;

namespace Bench
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmarker
    {
        private  List<int>list1 =new List<int>() { 1,2,5,13,25};
        private List<int> list2 = new List<int>() { 1, 2, 5, 13, 25,100 };
        [Benchmark]
        public void Solution1()
        {
            int res = MaxDiff1(list1);
        }
       

    }
}
