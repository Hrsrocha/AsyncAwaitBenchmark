using BenchTest;
using System.Threading.Tasks;

namespace BenchTestRepositoy
{
    public class Repository
    {
        private readonly ClasseInteiros _classeInteiro;

        public Repository()
        {
            _classeInteiro = new ClasseInteiros();
        }

        public int ObterId()
        {
            return _classeInteiro.ObterId();
        }

        public Task<int> ObterAsync()
        {
            return _classeInteiro.ObterAsync();
        }

        public async Task<int> ObterAsyncComAwait()
        {
            return await _classeInteiro.ObterAsyncComAwait();
        }
    }
}
