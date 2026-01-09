using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Runs tests in isolated processes to get accurate VMA measurements.
/// Each test runs in its own process with a clean VMA baseline.
/// </summary>
public class IsolatedTestRunner
{
    private readonly string _executablePath;
    private readonly TimeSpan _timeout;
    private readonly bool _verbose;
    private readonly double? _maxMemoryGb;
    private readonly int _vmaAbortThreshold;

    public IsolatedTestRunner(bool verbose = false, double? maxMemoryGb = null, TimeSpan? timeout = null, int? vmaAbortThreshold = null)
    {
        _verbose = verbose;
        _maxMemoryGb = maxMemoryGb;
        _timeout = timeout ?? TimeSpan.FromMinutes(10); // 10 minute default timeout
        _vmaAbortThreshold = vmaAbortThreshold ?? VmaMonitor.DefaultAbortVmaThreshold;
        
        // Get the path to the current executable
        _executablePath = GetExecutablePath();
    }

    private static string GetExecutablePath()
    {
        // Get the DLL path of the running application
        var dllPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        
        // If running as published executable, use the process path
        var processPath = Environment.ProcessPath;
        if (!string.IsNullOrEmpty(processPath) && File.Exists(processPath))
        {
            return processPath;
        }
        
        // Otherwise, we need to run via dotnet
        return dllPath;
    }

    /// <summary>
    /// Runs a list of tests, each in its own isolated process.
    /// </summary>
    public async Task<List<IsolatedTestResult>> RunTestsAsync(
        List<SimulationConfig> configs,
        Action<int, int, string>? progressCallback = null,
        CancellationToken cancellationToken = default)
    {
        var results = new List<IsolatedTestResult>();
        
        for (int i = 0; i < configs.Count; i++)
        {
            if (cancellationToken.IsCancellationRequested)
                break;

            var config = configs[i];
            progressCallback?.Invoke(i + 1, configs.Count, config.Name);
            
            var result = await RunSingleTestAsync(config, cancellationToken);
            results.Add(result);
            
            if (_verbose && result.Success)
            {
                Console.WriteLine($" Peak VMA: {result.Metrics?.PeakVmaCount:N0} {result.Metrics?.Status}");
            }
            else if (!result.Success)
            {
                Console.WriteLine($" ERROR: {result.Error}");
            }
        }
        
        return results;
    }

    /// <summary>
    /// Runs a single test in an isolated process.
    /// </summary>
    private async Task<IsolatedTestResult> RunSingleTestAsync(
        SimulationConfig config,
        CancellationToken cancellationToken)
    {
        var result = new IsolatedTestResult
        {
            Config = config,
            StartTime = DateTime.UtcNow
        };

        var stopwatch = Stopwatch.StartNew();

        try
        {
            // Serialize config to JSON and encode as base64
            var configJson = JsonSerializer.Serialize(config, IsolatedJsonContext.Default.SimulationConfig);
            var configBase64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(configJson));

            // Build the process arguments
            var args = $"_run-isolated-test {configBase64}";
            
            ProcessStartInfo psi;
            if (_executablePath.EndsWith(".dll"))
            {
                // Running via dotnet
                psi = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = $"\"{_executablePath}\" {args}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
            }
            else
            {
                // Running as native executable
                psi = new ProcessStartInfo
                {
                    FileName = _executablePath,
                    Arguments = args,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
            }

            using var process = new Process { StartInfo = psi };
            var outputBuilder = new System.Text.StringBuilder();
            var errorBuilder = new System.Text.StringBuilder();

            process.OutputDataReceived += (s, e) =>
            {
                if (e.Data != null)
                    outputBuilder.AppendLine(e.Data);
            };
            process.ErrorDataReceived += (s, e) =>
            {
                if (e.Data != null)
                    errorBuilder.AppendLine(e.Data);
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            // Wait with timeout
            var completedInTime = await WaitForExitAsync(process, _timeout, cancellationToken);
            
            stopwatch.Stop();
            result.ProcessDurationMs = stopwatch.ElapsedMilliseconds;

            if (!completedInTime)
            {
                try { process.Kill(); } catch { }
                result.Success = false;
                result.Error = $"Test timed out after {_timeout.TotalSeconds} seconds";
                return result;
            }

            var stdout = outputBuilder.ToString().Trim();
            var stderr = errorBuilder.ToString().Trim();

            if (process.ExitCode != 0)
            {
                result.Success = false;
                result.Error = $"Process exited with code {process.ExitCode}: {stderr}";
                return result;
            }

            // Parse the JSON output
            if (string.IsNullOrWhiteSpace(stdout))
            {
                result.Success = false;
                result.Error = "No output from child process";
                return result;
            }

            // Find the JSON output (look for line starting with JSON_RESULT:)
            var jsonLine = stdout.Split('\n')
                .FirstOrDefault(l => l.StartsWith("JSON_RESULT:"));
            
            if (jsonLine == null)
            {
                result.Success = false;
                result.Error = $"No JSON result found in output: {stdout.Substring(0, Math.Min(200, stdout.Length))}";
                return result;
            }

            var json = jsonLine.Substring("JSON_RESULT:".Length);
            result.Metrics = JsonSerializer.Deserialize<SimulationMetrics>(json, IsolatedJsonContext.Default.SimulationMetrics);
            
            if (result.Metrics != null)
            {
                result.Metrics.Config = config; // Re-attach config (not serialized)
            }
            
            result.Success = true;
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.Error = $"Exception: {ex.Message}";
        }

        return result;
    }

    private static async Task<bool> WaitForExitAsync(Process process, TimeSpan timeout, CancellationToken cancellationToken)
    {
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cts.CancelAfter(timeout);

        try
        {
            await process.WaitForExitAsync(cts.Token);
            return true;
        }
        catch (OperationCanceledException)
        {
            return false;
        }
    }
}

/// <summary>
/// Result from running an isolated test.
/// </summary>
public class IsolatedTestResult
{
    public SimulationConfig Config { get; set; } = new();
    public DateTime StartTime { get; set; }
    public long ProcessDurationMs { get; set; }
    public bool Success { get; set; }
    public string? Error { get; set; }
    public SimulationMetrics? Metrics { get; set; }
}

/// <summary>
/// JSON serialization context for isolated test communication.
/// Using source generators for AOT compatibility.
/// </summary>
[JsonSourceGenerationOptions(WriteIndented = false)]
[JsonSerializable(typeof(SimulationConfig))]
[JsonSerializable(typeof(SimulationMetrics))]
[JsonSerializable(typeof(VmaSnapshot))]
[JsonSerializable(typeof(Dictionary<string, int>))]
[JsonSerializable(typeof(List<VmaSnapshot>))]
public partial class IsolatedJsonContext : JsonSerializerContext
{
}
