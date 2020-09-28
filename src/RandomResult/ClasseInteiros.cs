using System;
using System.Threading.Tasks;

namespace BenchTest
{
    public class ClasseInteiros
    {
        private static Random _random = new Random();
        
        public int ObterId()
        {
            return _random.Next();
        }

        private async Task<int> ObterIdAsync()
        {
            return await Task.Run(ObterId);
        }

        public Task<int> ObterAsync()
        {
            return ObterIdAsync();
        }

        public async Task<int> ObterAsyncComAwait()
        {
            return await ObterIdAsync();
        }
    }
}
