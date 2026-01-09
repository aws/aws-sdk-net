using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Monitors Virtual Memory Area (VMA) usage on Linux systems.
/// On Windows/macOS, provides synthetic estimates based on ArrayPool allocations.
/// </summary>
public class VmaMonitor : IDisposable
{
    private readonly bool _isLinux;
    private readonly string? _mapsPath;
    private int _peakVmaCount;
    private int _baselineVmaCount;
    private int _allocationCount;
    private readonly object _lock = new();
    private bool _disposed;

    /// <summary>
    /// Current VMA count (real on Linux, estimated on other platforms).
    /// </summary>
    public int CurrentVmaCount => _isLinux ? GetLinuxVmaCount() : EstimateVmaCount();

    /// <summary>
    /// Peak VMA count observed since monitoring started.
    /// </summary>
    public int PeakVmaCount => _peakVmaCount;

    /// <summary>
    /// Baseline VMA count captured at start of monitoring.
    /// </summary>
    public int BaselineVmaCount => _baselineVmaCount;

    /// <summary>
    /// VMA count above baseline (delta from start).
    /// </summary>
    public int VmaCountAboveBaseline => Math.Max(0, CurrentVmaCount - _baselineVmaCount);

    /// <summary>
    /// Whether real VMA tracking is available (Linux only).
    /// </summary>
    public bool IsRealVmaTrackingAvailable => _isLinux;

    /// <summary>
    /// The Linux default VMA limit.
    /// </summary>
    public const int DefaultLinuxVmaLimit = 65536;

    /// <summary>
    /// Safe VMA threshold (with headroom).
    /// </summary>
    public const int SafeVmaThreshold = 50000;

    public VmaMonitor()
    {
        _isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        
        if (_isLinux)
        {
            _mapsPath = $"/proc/{Environment.ProcessId}/maps";
            if (!File.Exists(_mapsPath))
            {
                Console.WriteLine($"Warning: {_mapsPath} not accessible. Falling back to estimation mode.");
                _isLinux = false;
            }
        }

        _baselineVmaCount = CurrentVmaCount;
        _peakVmaCount = _baselineVmaCount;
    }

    /// <summary>
    /// Records a memory allocation for estimation mode.
    /// </summary>
    public void RecordAllocation()
    {
        lock (_lock)
        {
            _allocationCount++;
            UpdatePeak();
        }
    }

    /// <summary>
    /// Records a memory deallocation for estimation mode.
    /// </summary>
    public void RecordDeallocation()
    {
        lock (_lock)
        {
            _allocationCount = Math.Max(0, _allocationCount - 1);
        }
    }

    /// <summary>
    /// Updates the peak VMA count if current exceeds it.
    /// </summary>
    public void UpdatePeak()
    {
        var current = CurrentVmaCount;
        lock (_lock)
        {
            if (current > _peakVmaCount)
            {
                _peakVmaCount = current;
            }
        }
    }

    /// <summary>
    /// Resets tracking to capture a new baseline.
    /// </summary>
    public void Reset()
    {
        lock (_lock)
        {
            _allocationCount = 0;
            _baselineVmaCount = _isLinux ? GetLinuxVmaCount() : 0;
            _peakVmaCount = _baselineVmaCount;
        }
    }

    /// <summary>
    /// Gets the actual VMA count from Linux /proc/self/maps.
    /// </summary>
    private int GetLinuxVmaCount()
    {
        try
        {
            if (_mapsPath == null) return 0;
            
            var lines = File.ReadAllLines(_mapsPath);
            return lines.Length;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Warning: Error reading VMA count: {ex.Message}");
            return EstimateVmaCount();
        }
    }

    /// <summary>
    /// Estimates VMA count based on tracked allocations.
    /// Each ArrayPool allocation typically creates one VMA.
    /// </summary>
    private int EstimateVmaCount()
    {
        lock (_lock)
        {
            // Base estimate: typical application VMAs + tracked allocations
            return _baselineVmaCount + _allocationCount;
        }
    }

    /// <summary>
    /// Gets current Linux vm.max_map_count setting.
    /// </summary>
    public static int GetLinuxVmaLimit()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            return DefaultLinuxVmaLimit;

        try
        {
            var content = File.ReadAllText("/proc/sys/vm/max_map_count").Trim();
            if (int.TryParse(content, out var limit))
                return limit;
        }
        catch
        {
            // Ignore - return default
        }

        return DefaultLinuxVmaLimit;
    }

    /// <summary>
    /// Gets detailed VMA breakdown by type (Linux only).
    /// </summary>
    public Dictionary<string, int> GetVmaBreakdown()
    {
        var breakdown = new Dictionary<string, int>
        {
            ["heap"] = 0,
            ["stack"] = 0,
            ["anon"] = 0,      // Anonymous mappings (ArrayPool allocations)
            ["shared"] = 0,    // Shared libraries
            ["file"] = 0,      // Memory-mapped files
            ["other"] = 0
        };

        if (!_isLinux || _mapsPath == null)
        {
            breakdown["estimated"] = _allocationCount;
            return breakdown;
        }

        try
        {
            var lines = File.ReadAllLines(_mapsPath);
            foreach (var line in lines)
            {
                if (line.Contains("[heap]"))
                    breakdown["heap"]++;
                else if (line.Contains("[stack]"))
                    breakdown["stack"]++;
                else if (line.EndsWith("anon") || !line.Contains('/'))
                    breakdown["anon"]++;
                else if (line.Contains(".so"))
                    breakdown["shared"]++;
                else if (line.Contains('/'))
                    breakdown["file"]++;
                else
                    breakdown["other"]++;
            }
        }
        catch
        {
            // Return partial breakdown
        }

        return breakdown;
    }

    /// <summary>
    /// Creates a snapshot of current VMA state.
    /// </summary>
    public VmaSnapshot TakeSnapshot()
    {
        UpdatePeak();
        return new VmaSnapshot
        {
            Timestamp = DateTime.UtcNow,
            CurrentVmaCount = CurrentVmaCount,
            PeakVmaCount = _peakVmaCount,
            BaselineVmaCount = _baselineVmaCount,
            VmaCountAboveBaseline = VmaCountAboveBaseline,
            IsRealTracking = _isLinux,
            Breakdown = GetVmaBreakdown()
        };
    }

    public void Dispose()
    {
        _disposed = true;
    }
}

/// <summary>
/// Snapshot of VMA state at a point in time.
/// </summary>
public record VmaSnapshot
{
    public DateTime Timestamp { get; init; }
    public int CurrentVmaCount { get; init; }
    public int PeakVmaCount { get; init; }
    public int BaselineVmaCount { get; init; }
    public int VmaCountAboveBaseline { get; init; }
    public bool IsRealTracking { get; init; }
    public Dictionary<string, int> Breakdown { get; init; } = new();

    /// <summary>
    /// Percentage of default Linux VMA limit used.
    /// </summary>
    public double VmaUsagePercent => (double)CurrentVmaCount / VmaMonitor.DefaultLinuxVmaLimit * 100;

    /// <summary>
    /// Margin remaining before hitting safe threshold.
    /// </summary>
    public int SafetyMargin => VmaMonitor.SafeVmaThreshold - CurrentVmaCount;

    /// <summary>
    /// Whether current usage is within safe limits.
    /// </summary>
    public bool IsSafe => CurrentVmaCount < VmaMonitor.SafeVmaThreshold;
}

/// <summary>
/// Provides system memory information.
/// </summary>
public static class SystemMemoryInfo
{
    /// <summary>
    /// Gets the total physical memory in bytes.
    /// </summary>
    public static long GetTotalPhysicalMemoryBytes()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return GetLinuxMemoryBytes();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return GetWindowsMemoryBytes();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            return GetMacOSMemoryBytes();
        }
        
        // Fallback: assume 8GB
        return 8L * 1024 * 1024 * 1024;
    }

    /// <summary>
    /// Gets the available physical memory in bytes.
    /// </summary>
    public static long GetAvailableMemoryBytes()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return GetLinuxAvailableMemoryBytes();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return GetWindowsAvailableMemoryBytes();
        }
        
        // Fallback: assume 50% of total
        return GetTotalPhysicalMemoryBytes() / 2;
    }

    /// <summary>
    /// Gets total memory formatted as string.
    /// </summary>
    public static string GetTotalMemoryFormatted()
    {
        return FormatBytes(GetTotalPhysicalMemoryBytes());
    }

    /// <summary>
    /// Gets available memory formatted as string.
    /// </summary>
    public static string GetAvailableMemoryFormatted()
    {
        return FormatBytes(GetAvailableMemoryBytes());
    }

    private static long GetLinuxMemoryBytes()
    {
        try
        {
            var lines = File.ReadAllLines("/proc/meminfo");
            foreach (var line in lines)
            {
                if (line.StartsWith("MemTotal:"))
                {
                    // Format: "MemTotal:       16384000 kB"
                    var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2 && long.TryParse(parts[1], out var kb))
                    {
                        return kb * 1024; // Convert KB to bytes
                    }
                }
            }
        }
        catch
        {
            // Ignore errors
        }
        
        return 8L * 1024 * 1024 * 1024; // Fallback 8GB
    }

    private static long GetLinuxAvailableMemoryBytes()
    {
        try
        {
            var lines = File.ReadAllLines("/proc/meminfo");
            foreach (var line in lines)
            {
                if (line.StartsWith("MemAvailable:"))
                {
                    var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2 && long.TryParse(parts[1], out var kb))
                    {
                        return kb * 1024;
                    }
                }
            }
        }
        catch
        {
            // Ignore errors
        }
        
        return GetLinuxMemoryBytes() / 2; // Fallback 50% of total
    }

    private static long GetWindowsMemoryBytes()
    {
        try
        {
            // Use GC to get approximate memory info
            var gcInfo = GC.GetGCMemoryInfo();
            return gcInfo.TotalAvailableMemoryBytes;
        }
        catch
        {
            return 8L * 1024 * 1024 * 1024; // Fallback 8GB
        }
    }

    private static long GetWindowsAvailableMemoryBytes()
    {
        try
        {
            var gcInfo = GC.GetGCMemoryInfo();
            return gcInfo.TotalAvailableMemoryBytes - gcInfo.MemoryLoadBytes;
        }
        catch
        {
            return 4L * 1024 * 1024 * 1024; // Fallback 4GB
        }
    }

    private static long GetMacOSMemoryBytes()
    {
        try
        {
            // Try sysctl on macOS
            var psi = new ProcessStartInfo
            {
                FileName = "sysctl",
                Arguments = "-n hw.memsize",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            
            using var process = Process.Start(psi);
            if (process != null)
            {
                var output = process.StandardOutput.ReadToEnd().Trim();
                process.WaitForExit();
                if (long.TryParse(output, out var bytes))
                {
                    return bytes;
                }
            }
        }
        catch
        {
            // Ignore errors
        }
        
        return 8L * 1024 * 1024 * 1024; // Fallback 8GB
    }

    private static string FormatBytes(long bytes)
    {
        if (bytes >= 1024L * 1024 * 1024 * 1024) return $"{bytes / 1024.0 / 1024.0 / 1024.0 / 1024.0:F1} TB";
        if (bytes >= 1024L * 1024 * 1024) return $"{bytes / 1024.0 / 1024.0 / 1024.0:F1} GB";
        if (bytes >= 1024 * 1024) return $"{bytes / 1024.0 / 1024.0:F1} MB";
        if (bytes >= 1024) return $"{bytes / 1024.0:F0} KB";
        return $"{bytes} B";
    }
}
