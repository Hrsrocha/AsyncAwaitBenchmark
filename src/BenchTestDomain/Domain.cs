using BenchTestRepositoy;
using System.Threading.Tasks;

namespace BenchTestDomain
{
    public class Domain
    {
        private readonly Repository _repository;

        public Domain()
        {
            _repository = new Repository();
        }

        public int ObterId()
        {
            return _repository.ObterId();
        }

        public Task<int> ObterAsync()
        {
            return _repository.ObterAsync();
        }

        public async Task<int> ObterAsyncComAwait()
        {
            return await _repository.ObterAsyncComAwait();
        }
    }
}
