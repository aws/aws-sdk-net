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

namespace AWSSDK.Benchmarks
{
    /// <summary>
    /// Background resource monitor that samples CPU usage (%) and memory usage (MB)
    /// at 100ms intervals during benchmark execution.
    /// 
    /// Collects CPU usage (%) and memory usage (MB) at every 100ms throughout the
    /// measurement period. Calculates and reports both the mean (average) and maximum
    /// (peak) values.
    /// 
    /// Usage:
    ///   var monitor = new ResourceMonitor();
    ///   monitor.Start();
    ///   // ... run benchmark ...
    ///   monitor.Stop();
    ///   Console.WriteLine(monitor.GetSummary("MyBenchmark"));
    /// </summary>
    public class ResourceMonitor
    {
        private readonly List<double> _cpuSamples = new();
        private readonly List<double> _memorySamplesMB = new();
        private readonly int _intervalMs;
        private Thread? _samplingThread;
        private volatile bool _running;

        public ResourceMonitor(int intervalMs = 100)
        {
            _intervalMs = intervalMs;
        }

        public void Start()
        {
            _cpuSamples.Clear();
            _memorySamplesMB.Clear();
            _running = true;

            _samplingThread = new Thread(SampleLoop)
            {
                IsBackground = true,
                Name = "ResourceMonitor",
                Priority = ThreadPriority.BelowNormal
            };
            _samplingThread.Start();
        }

        public void Stop()
        {
            _running = false;
            _samplingThread?.Join(timeout: TimeSpan.FromSeconds(2));
        }

        private void SampleLoop()
        {
            var process = Process.GetCurrentProcess();
            var processorCount = Environment.ProcessorCount;
            var lastCpuTime = process.TotalProcessorTime;
            var lastTimestamp = DateTime.UtcNow;

            // Wait one interval before first sample to get a valid CPU delta
            Thread.Sleep(_intervalMs);

            while (_running)
            {
                try
                {
                    process.Refresh();

                    // Memory: working set in MB
                    double memoryMB = process.WorkingSet64 / (1024.0 * 1024.0);
                    _memorySamplesMB.Add(memoryMB);

                    // CPU: percentage based on delta of TotalProcessorTime
                    var now = DateTime.UtcNow;
                    var currentCpuTime = process.TotalProcessorTime;
                    var cpuDelta = (currentCpuTime - lastCpuTime).TotalMilliseconds;
                    var timeDelta = (now - lastTimestamp).TotalMilliseconds;

                    if (timeDelta > 0)
                    {
                        // CPU% = (cpuTimeDelta / wallTimeDelta) / processorCount * 100
                        double cpuPercent = (cpuDelta / timeDelta) / processorCount * 100.0;
                        cpuPercent = Math.Min(cpuPercent, 100.0); // Cap at 100%
                        _cpuSamples.Add(cpuPercent);
                    }

                    lastCpuTime = currentCpuTime;
                    lastTimestamp = now;
                }
                catch
                {
                    // Ignore sampling errors; don't crash the benchmark
                }

                Thread.Sleep(_intervalMs);
            }
        }

        public double CpuMeanPercent => _cpuSamples.Count > 0 ? _cpuSamples.Average() : 0;
        public double CpuMaxPercent => _cpuSamples.Count > 0 ? _cpuSamples.Max() : 0;
        public double MemMeanMB => _memorySamplesMB.Count > 0 ? _memorySamplesMB.Average() : 0;
        public double MemMaxMB => _memorySamplesMB.Count > 0 ? _memorySamplesMB.Max() : 0;
        public int SampleCount => _memorySamplesMB.Count;

        /// <summary>
        /// Returns a formatted summary string for Console.WriteLine output.
        /// BenchmarkDotNet captures Console output in its log files.
        /// </summary>
        public string GetSummary(string label)
        {
            return $"[ResourceMonitor] {label}: CPU Mean={CpuMeanPercent:F1}%, CPU Max={CpuMaxPercent:F1}%, " +
                   $"Mem Mean={MemMeanMB:F0} MB, Mem Max={MemMaxMB:F0} MB ({SampleCount} samples)";
        }
    }
}
