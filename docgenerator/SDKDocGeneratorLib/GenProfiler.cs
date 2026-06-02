using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace SDKDocGenerator
{
    /// <summary>
    /// A lightweight, opt-in sub-operation profiler used to attribute time spent *within* page
    /// generation to coarse buckets (reflection/assembly load, XML-doc parsing, doc lookups,
    /// doc-&gt;HTML transform, page string building, file I/O, ...). It exists to answer "what inside a
    /// slow service is actually slow?" without a full external profiler.
    ///
    /// Design:
    ///  - Disabled by default. When off, <see cref="Measure"/> just runs the delegate and the hot path
    ///    is a single boolean check, so there is no measurable overhead in normal runs.
    ///  - When enabled (the -profile flag), it accumulates elapsed Stopwatch ticks and a call count per
    ///    bucket using Interlocked, so it is safe under the parallel generation we now do.
    ///  - It never changes output; it only times.
    /// </summary>
    public static class GenProfiler
    {
        // Buckets we attribute time to. Keep this list short and meaningful.
        public const string Reflection = "Reflection / assembly access";
        public const string XmlDocParse = "XML doc parse (CreateNDocTable)";
        public const string DocLookup = "Doc lookup (FindDocumentation)";
        public const string DocToHtml = "Doc -> HTML transform";
        public const string PageBuild = "Page build (WriteContent)";
        public const string PageFinalize = "Page finalize (replaces)";
        public const string FileWrite = "File write";

        public static bool Enabled { get; set; }

        private sealed class Counter
        {
            public long Ticks;
            public long Calls;
        }

        private static readonly ConcurrentDictionary<string, Counter> _counters =
            new ConcurrentDictionary<string, Counter>(StringComparer.Ordinal);

        /// <summary>Times <paramref name="body"/> into the named bucket (no-op timing when disabled).</summary>
        public static void Measure(string bucket, Action body)
        {
            if (!Enabled)
            {
                body();
                return;
            }

            var start = Stopwatch.GetTimestamp();
            try
            {
                body();
            }
            finally
            {
                Record(bucket, Stopwatch.GetTimestamp() - start);
            }
        }

        /// <summary>Times a function into the named bucket (no-op timing when disabled).</summary>
        public static T Measure<T>(string bucket, Func<T> body)
        {
            if (!Enabled)
                return body();

            var start = Stopwatch.GetTimestamp();
            try
            {
                return body();
            }
            finally
            {
                Record(bucket, Stopwatch.GetTimestamp() - start);
            }
        }

        private static void Record(string bucket, long ticks)
        {
            var c = _counters.GetOrAdd(bucket, _ => new Counter());
            Interlocked.Add(ref c.Ticks, ticks);
            Interlocked.Increment(ref c.Calls);
        }

        /// <summary>
        /// Prints the accumulated per-bucket totals. Note: under parallel generation these are summed
        /// CPU-time across threads (so they can exceed wall-clock); the *ratios* between buckets are
        /// what's meaningful for spotting the dominant cost.
        /// </summary>
        public static void PrintReport()
        {
            if (!Enabled || _counters.IsEmpty)
                return;

            double ticksToMs = 1000.0 / Stopwatch.Frequency;

            Console.WriteLine();
            Console.WriteLine("Sub-operation profile (summed across threads; compare ratios, not wall-clock):");
            Console.WriteLine("  {0,-34} {1,12} {2,14} {3,12}", "Bucket", "Total (s)", "Calls", "us/call");

            foreach (var kvp in _counters)
            {
                var totalMs = kvp.Value.Ticks * ticksToMs;
                var calls = kvp.Value.Calls;
                var usPerCall = calls > 0 ? (totalMs * 1000.0 / calls) : 0.0;
                Console.WriteLine("  {0,-34} {1,12:N1} {2,14:N0} {3,12:N1}",
                    kvp.Key, totalMs / 1000.0, calls, usPerCall);
            }
            Console.WriteLine();
        }
    }
}
