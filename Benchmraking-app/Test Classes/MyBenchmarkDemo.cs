using BenchmarkDotNet.Attributes;

namespace Benchmraking_app.Test_Classes
{
    [MemoryDiagnoser]
    public class MyBenchmarkDemo
    {
        [GlobalSetup]
        public void GlobalSetup()
        {
            // Write your initialization code here
            // You might want to execute some code just once and
            // you don't want to benchmark the code


        }

        [Benchmark]
        public void MyFirstBenchmarkMethod()
        {
            //Write your code here   
        }
        [Benchmark]
        public void MySecondBenchmarkMethod()
        {
            //Write your code here
        }
    }
}
