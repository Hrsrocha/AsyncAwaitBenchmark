using BenchmarkDotNet.Attributes;
using BenchTestApp;
using System.Threading.Tasks;

namespace BenchTest
{
    [RPlotExporter]
    [HtmlExporter]
    [MemoryDiagnoser]
    public class PerformanceClasseInteiros
    {
        private Application _application;

        [GlobalSetup]
        public void Setup()
        {
            _application = new Application();
        }

        [Benchmark]
        public int PerformanceSemTask()
        {
            return _application.ObterId();
        }

        [Benchmark(Baseline = true)]
        public Task<int> PerformanceSemAwait()
        {
            return _application.ObterAsync();
        }

        [Benchmark]
        public async Task<int> PerformanceComAwait()
        {
            return await _application.ObterAsyncComAwait();
        }
    }
}
