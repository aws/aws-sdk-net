using System;
using System.Threading;

namespace SDKDocGenerator
{
    /// <summary>
    /// A single, process-wide budget of concurrent "page-generation slots" shared by both the outer
    /// (per-service) and inner (per-namespace) parallel loops. It exists to get nested parallelism
    /// without oversubscribing the CPU: no matter how the work nests, the number of threads actively
    /// generating pages never exceeds the configured degree.
    ///
    /// Usage model:
    ///  - The outer service loop blocks to acquire one slot before generating a service (so at most
    ///    'degree' services run at once).
    ///  - The inner namespace loop only ever takes *spare* slots via <see cref="TryAcquire"/> (a
    ///    non-blocking poll). If no slot is free it processes the namespace inline on the current
    ///    thread. This guarantees forward progress (no deadlock) and means the inner fan-out only
    ///    kicks in when the outer loop has drained and cores would otherwise sit idle (e.g. the tail
    ///    of a run where one huge service like EC2 is finishing alone).
    ///
    /// When parallelism is disabled the gate is simply absent (null) and callers run serially.
    /// </summary>
    public sealed class ConcurrencyGate
    {
        private readonly SemaphoreSlim _semaphore;

        public ConcurrencyGate(int degree)
        {
            if (degree < 1)
                degree = 1;
            Degree = degree;
            _semaphore = new SemaphoreSlim(degree, degree);
        }

        /// <summary>The total number of slots in the budget.</summary>
        public int Degree { get; }

        /// <summary>Blocks until a slot is available, then takes it. Release with <see cref="Release"/>.</summary>
        public void Acquire() => _semaphore.Wait();

        /// <summary>
        /// Takes a slot only if one is immediately free; never blocks. Returns true if a slot was
        /// taken (caller must <see cref="Release"/> it), false otherwise.
        /// </summary>
        public bool TryAcquire() => _semaphore.Wait(0);

        /// <summary>Returns a previously-acquired slot to the budget.</summary>
        public void Release() => _semaphore.Release();
    }
}
