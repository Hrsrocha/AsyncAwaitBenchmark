using BenchTestDomain;
using System.Threading.Tasks;

namespace BenchTestApp
{
    public class Application
    {
        private readonly Domain _domain;

        public Application()
        {
            _domain = new Domain();
        }

        public int ObterId()
        {
            return _domain.ObterId();
        }

        public Task<int> ObterAsync()
        {
            return _domain.ObterAsync();
        }

        public async Task<int> ObterAsyncComAwait()
        {
            return await _domain.ObterAsyncComAwait();
        }
    }
}
