using Framework.Repository;
using System.Diagnostics;
using System.Threading;

namespace ORMS
{
    public class Benchmark<T>
    {
        public long GetBench(IRepository<T> IRepository,int Top)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            IRepository.GetAll(Top);
            sw.Stop();
            Thread.Sleep(200);
            return sw.ElapsedMilliseconds;
        }
    }
}
