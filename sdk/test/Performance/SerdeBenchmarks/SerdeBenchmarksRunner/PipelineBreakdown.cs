/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Diagnostics;
using System.Globalization;
using System.Text;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// Per-stage pipeline timing (--breakdown): [probe] H0 [probe] H1 ... [probe] HttpHandler -> MockHttpHandler.
/// Each probe stamps (timestamp, allocated bytes) on the way in and out; a handler's cost in each direction is
/// the gap between the stamps on either side of it. MockHttpHandler stamps its own entry and exit.
/// </summary>
public static class PipelineBreakdown
{
    public static bool Enabled;
    public static string? OutputCsv;

    // Mark slots, in order of occurrence within one operation.
    private const int MaxSlots = 128;
    private static readonly long[] _ts = new long[MaxSlots];
    private static readonly long[] _al = new long[MaxSlots];
    private static readonly int[] _tid = new int[MaxSlots];

    // Per-slot accumulators over the measured operations.
    private static readonly long[] _sumTicks = new long[MaxSlots];
    private static readonly long[] _sumBytes = new long[MaxSlots];
    private static long _ops;
    private static long _threadHops;
    private static long _asyncProbes;
    private static int _gen0Start, _gen1Start, _gen2Start;
    private static TimeSpan _gcPauseStart;
    private static bool _accumulate;

    // Handler names of the most recently built client; each generated case builds its client just before measuring.
    private static string[] _handlerNames = Array.Empty<string>();

    private const int SlotStart = 0;
    private const int SlotEnd = 1;
    private const int SlotMockEnter = 2;
    private const int SlotMockExit = 3;
    private const int FirstProbeSlot = 4; // probe k uses slots 4+2k (inward) and 5+2k (outward)

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static void Mark(int slot)
    {
        _ts[slot] = Stopwatch.GetTimestamp();
        _al[slot] = GC.GetAllocatedBytesForCurrentThread();
        _tid[slot] = Environment.CurrentManagedThreadId;
    }

    internal static void MarkMockEnter() { if (Enabled) Mark(SlotMockEnter); }
    internal static void MarkMockExit() { if (Enabled) Mark(SlotMockExit); }

    public static void Register()
    {
        Enabled = true;
        RuntimePipelineCustomizerRegistry.Instance.Register(new ProbeCustomizer());
    }

    /// <summary>Wraps a benchmark operation so the start/end stamps bracket the whole client call.</summary>
    public static Func<Task> Wrap(Func<Task> operation)
    {
        return async () =>
        {
            Mark(SlotStart);
            await operation().ConfigureAwait(false);
            Mark(SlotEnd);
            if (_accumulate) Accumulate();
        };
    }

    public static void BeginMeasurement()
    {
        Array.Clear(_sumTicks);
        Array.Clear(_sumBytes);
        _ops = 0;
        _threadHops = 0;
        _asyncProbes = 0;
        _gen0Start = GC.CollectionCount(0);
        _gen1Start = GC.CollectionCount(1);
        _gen2Start = GC.CollectionCount(2);
        _gcPauseStart = GC.GetTotalPauseDuration();
        _accumulate = true;
    }

    private static void Accumulate()
    {
        int last = FirstProbeSlot + 2 * _handlerNames.Length;
        long ts0 = _ts[SlotStart], al0 = _al[SlotStart];
        for (int s = 0; s < last; s++)
        {
            _sumTicks[s] += _ts[s] - ts0;
            _sumBytes[s] += _al[s] - al0;
        }
        int t0 = _tid[SlotStart];
        for (int s = 0; s < last; s++)
            if (_tid[s] != t0) { _threadHops++; break; }
        _ops++;
    }

    public record Stage(string Name, string Direction, double NsPerOp, double BytesPerOp);

    public static List<Stage> EndMeasurement(string benchmarkName, double cpuSecondsPerOp)
    {
        _accumulate = false;
        var stages = new List<Stage>();
        if (_ops == 0) return stages;

        double tickNs = 1e9 / Stopwatch.Frequency;
        double T(int slot) => _sumTicks[slot] / (double)_ops;
        double A(int slot) => _sumBytes[slot] / (double)_ops;
        int In(int probe) => FirstProbeSlot + 2 * probe;   // probe 0 = above outermost handler
        int Out(int probe) => FirstProbeSlot + 2 * probe + 1;

        int n = _handlerNames.Length;
        // Request direction.
        stages.Add(new Stage("Client.InvokeAsync (pre-pipeline)", "request", (T(In(0)) - T(SlotStart)) * tickNs, A(In(0)) - A(SlotStart)));
        for (int h = 0; h < n; h++)
        {
            int from = In(h);
            int to = h + 1 < n ? In(h + 1) : SlotMockEnter;
            stages.Add(new Stage(_handlerNames[h], "request", (T(to) - T(from)) * tickNs, A(to) - A(from)));
        }
        stages.Add(new Stage("MockHttpHandler (transport, not SDK)", "transport", (T(SlotMockExit) - T(SlotMockEnter)) * tickNs, A(SlotMockExit) - A(SlotMockEnter)));
        // Response direction, innermost first.
        for (int h = n - 1; h >= 0; h--)
        {
            int from = h + 1 < n ? Out(h + 1) : SlotMockExit;
            int to = Out(h);
            stages.Add(new Stage(_handlerNames[h], "response", (T(to) - T(from)) * tickNs, A(to) - A(from)));
        }
        stages.Add(new Stage("Client.InvokeAsync (post-pipeline)", "response", (T(SlotEnd) - T(Out(0))) * tickNs, A(SlotEnd) - A(Out(0))));

        double wallNs = (T(SlotEnd) - T(SlotStart)) * tickNs;
        double cpuNs = cpuSecondsPerOp * 1e9;
        int g0 = GC.CollectionCount(0) - _gen0Start, g1 = GC.CollectionCount(1) - _gen1Start, g2 = GC.CollectionCount(2) - _gen2Start;
        double gcPauseNs = (GC.GetTotalPauseDuration() - _gcPauseStart).TotalMilliseconds * 1e6 / _ops;

        Console.WriteLine();
        Console.WriteLine($"--- Pipeline breakdown: {benchmarkName} ({_ops} ops, thread hops {_threadHops}, async probe completions {_asyncProbes}) ---");
        Console.WriteLine($"{"Stage",-52} {"Dir",-9} {"ns/op",9} {"%",6} {"B/op",8}");
        foreach (var s in stages)
            Console.WriteLine($"{s.Name,-52} {s.Direction,-9} {s.NsPerOp,9:F0} {100 * s.NsPerOp / wallNs,6:F1} {s.BytesPerOp,8:F0}");
        Console.WriteLine($"{"Sum of stages (wall, single thread)",-52} {"",-9} {wallNs,9:F0}");
        Console.WriteLine($"{"Process CPU per op",-52} {"",-9} {cpuNs,9:F0}");
        Console.WriteLine($"{"GC pause per op",-52} {"",-9} {gcPauseNs,9:F0}   (gen0 {g0}, gen1 {g1}, gen2 {g2})");

        if (OutputCsv != null)
        {
            bool header = !File.Exists(OutputCsv);
            using var w = new StreamWriter(OutputCsv, append: true);
            if (header) w.WriteLine("benchmark,order,stage,direction,ns_per_op,bytes_per_op");
            int order = 0;
            foreach (var s in stages)
                w.WriteLine(string.Join(",", benchmarkName, (order++).ToString(CultureInfo.InvariantCulture), Csv(s.Name), s.Direction,
                    s.NsPerOp.ToString("F1", CultureInfo.InvariantCulture), s.BytesPerOp.ToString("F1", CultureInfo.InvariantCulture)));
            w.WriteLine(string.Join(",", benchmarkName, (order++).ToString(CultureInfo.InvariantCulture), "_wall_total", "total", wallNs.ToString("F1", CultureInfo.InvariantCulture), (A(SlotEnd) - A(SlotStart)).ToString("F1", CultureInfo.InvariantCulture)));
            w.WriteLine(string.Join(",", benchmarkName, (order++).ToString(CultureInfo.InvariantCulture), "_cpu_total", "total", cpuNs.ToString("F1", CultureInfo.InvariantCulture), "0"));
            w.WriteLine(string.Join(",", benchmarkName, (order++).ToString(CultureInfo.InvariantCulture), "_gc_pause", "total", gcPauseNs.ToString("F1", CultureInfo.InvariantCulture), $"{g0}/{g1}/{g2}"));
        }
        return stages;
    }

    private static string Csv(string s) => s.Contains(',') ? "\"" + s + "\"" : s;

    private sealed class ProbeCustomizer : IRuntimePipelineCustomizer
    {
        public string UniqueName => "PipelineBreakdownProbes";

        public void Customize(Type type, RuntimePipeline pipeline)
        {
            var handlers = pipeline.Handlers;
            var names = new string[handlers.Count];
            int callbackIndex = 0;
            for (int i = 0; i < handlers.Count; i++)
            {
                var h = handlers[i];
                var name = h.GetType().Name;
                int arity = name.IndexOf('`');
                if (arity > 0) name = name.Substring(0, arity); // HttpHandler`1 -> HttpHandler
                if (h is CallbackHandler cb)
                {
                    // Default pipeline order (outer -> inner): pre-marshall, post-marshall, post-unmarshall.
                    name = (callbackIndex++) switch
                    {
                        0 => "CallbackHandler (pre-marshall)",
                        1 => "CallbackHandler (post-marshall)",
                        2 => "CallbackHandler (post-unmarshall)",
                        var k => $"CallbackHandler #{k}"
                    };
                }
                names[i] = name;
            }

            // Probe below every handler (none needed below HttpHandler; the mock stamps that edge).
            for (int i = 0; i < handlers.Count - 1; i++)
            {
                var outer = handlers[i];
                var inner = handlers[i + 1];
                var probe = new ProbeHandler(i + 1) { Logger = outer.Logger, OuterHandler = outer, InnerHandler = inner };
                outer.InnerHandler = probe;
                inner.OuterHandler = probe;
            }
            // Probe above the outermost handler.
            pipeline.AddHandler(new ProbeHandler(0));
            _handlerNames = names;
        }
    }

    private sealed class ProbeHandler : PipelineHandler
    {
        private readonly int _in;
        private readonly int _out;

        public ProbeHandler(int probeIndex)
        {
            _in = FirstProbeSlot + 2 * probeIndex;
            _out = _in + 1;
        }

        public override void InvokeSync(IExecutionContext executionContext)
        {
            Mark(_in);
            try { InnerHandler.InvokeSync(executionContext); }
            finally { Mark(_out); }
        }

        public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            Mark(_in);
            var task = InnerHandler.InvokeAsync<T>(executionContext);
            if (task.IsCompleted)
            {
                Mark(_out);
                return task;
            }
            return Slow(task);
        }

        private async Task<T> Slow<T>(Task<T> task)
        {
            _asyncProbes++;
            try { return await task.ConfigureAwait(false); }
            finally { Mark(_out); }
        }
    }
}
