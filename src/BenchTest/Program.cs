using BenchmarkDotNet.Running;

namespace BenchTest
{
    class Program
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "The code bellow apply to a test only")]
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<PerformanceClasseInteiros>();
        }
    }
}
