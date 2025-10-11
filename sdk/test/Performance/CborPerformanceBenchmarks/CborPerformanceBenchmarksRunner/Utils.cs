using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using Amazon.Util;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.Json;

public record BenchmarkRecord(
    string service,
    string test_case,
    string protocol,
    int dimension_value,
    string metric,
    double p50,
    double p90,
    double max);

public static class Utils
{
    private static List<string> secretsIds = new List<string>();

    private static string resultsPath;

    public static string ResultsPath
    {
        get
        {
            if (resultsPath != null)
                return resultsPath;

            resultsPath = Environment.GetEnvironmentVariable("ResultsPath");
            if (string.IsNullOrWhiteSpace(resultsPath))
            {
                resultsPath = Directory.GetCurrentDirectory();
            }

            Console.WriteLine($"Results Path: {resultsPath}");

            return resultsPath;
        }
    }


    public static int RunStartTimestamp = string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("RunStartTimestamp")) ?
        AWSSDKUtils.ConvertToUnixEpochSeconds(DateTime.Now) : int.Parse(Environment.GetEnvironmentVariable("RunStartTimestamp"));

    public static int IterationsCount = 600;

    private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };


    public static void StoreBenchmarkSummaries(IEnumerable<Summary> summaries)
    {
        var records = summaries.Select(BuildRecords).SelectMany(x => x).ToList();
        StoreBenchmarkRecords(records);
    }

    public static void StoreBenchmarkRecords(IEnumerable<BenchmarkRecord> records)
    {
        var filePath = Path.Combine(ResultsPath, $"results-{RunStartTimestamp}.json");
        Console.WriteLine($"Trying to store benchmark results at:{filePath}");

        int maxAttempts = 10;
        int baseDelayMs = 50;

        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
            try
            {
                // Ensure file exists and is a JSON array
                if (!File.Exists(filePath))
                {
                    // create empty array
                    File.WriteAllText(filePath, "[]", Encoding.UTF8);
                }

                // Read existing content
                string existingContent = File.ReadAllText(filePath, Encoding.UTF8);

                if (string.IsNullOrWhiteSpace(existingContent))
                    existingContent = "[]";

                using var doc = JsonDocument.Parse(existingContent);
                if (doc.RootElement.ValueKind != JsonValueKind.Array)
                {
                    // if file is malformed, overwrite with an array
                    existingContent = "[]";
                }

                var allRecords = JsonSerializer.Deserialize<List<BenchmarkRecord>>(existingContent, JsonOptions);
                allRecords.AddRange(records);

                allRecords = allRecords
                    .OrderBy(r => r.service)
                    .ThenBy(r => r.test_case)
                    .ThenBy(r => r.dimension_value)
                    .ThenBy(r => r.metric)
                    .ThenBy(r => r.protocol).ToList();

                var newContent = JsonSerializer.Serialize(allRecords, JsonOptions);
                File.WriteAllText(filePath, newContent, Encoding.UTF8);

                Console.WriteLine($"Stored benchmark results at:{filePath}");

                return;
            }
            catch (IOException)
            {
                // file locked, wait and retry
                var jitter = new Random().Next(0, 50);
                Thread.Sleep(baseDelayMs * attempt + jitter);
                continue;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;

            }
        }

        throw new IOException($"Failed to append record to {filePath} after {maxAttempts} attempts.");
    }

    private static List<BenchmarkRecord> BuildRecords(Summary summary)
    {
        var list = new List<BenchmarkRecord>();

        foreach (var benchmarkReport in summary.Reports)
        {
            var benchmarkObject = (BaseBenchmarks)Activator.CreateInstance(benchmarkReport.BenchmarkCase.Descriptor.Type)!;
            list.Add(ToBenchmarkRecord(benchmarkReport, benchmarkObject));
        }
        return list;
    }


    private static BenchmarkRecord ToBenchmarkRecord(BenchmarkReport report, BaseBenchmarks benchmarkObject)
    {
        var protocol = report.BenchmarkCase.Job.Id == "RPCv2CborProtocol" ? "CBOR" : "JSON";

        if (benchmarkObject.Service == "CloudWatch" && protocol == "JSON")
            protocol = "Query";

        var description = report.BenchmarkCase.Descriptor.WorkloadMethod.GetCustomAttribute<BenchmarkAttribute>().Description;
        var dimensionValue = int.Parse(report.BenchmarkCase.Parameters["DimensionValue"].ToString());

        var stats = report.ResultStatistics!; // ns

        var testCase = benchmarkObject.TestCase;

        if (report.BenchmarkCase.Descriptor.WorkloadMethod.Name.EndsWith("2") && benchmarkObject is BaseDoubleBenchmarks benchmarkObject2)
        {
            testCase = benchmarkObject2.TestCase2;
        }

        double ToMs(double ns) => ns / 1_000_000.0;

        return new BenchmarkRecord(
            service: benchmarkObject.Service,
            test_case: testCase,
            protocol: protocol,
            dimension_value: dimensionValue,
            metric: description,
            p50: ToMs(stats.Percentiles.P50),
            p90: ToMs(stats.Percentiles.P90),
            max: ToMs(stats.Max));
    }

    public static string GetParametersAsString(ParameterCollection parameterCollection)
    {
        var parameterBuilder = new StringBuilder(512);
        foreach (var kvp in GetParametersEnumerable(parameterCollection))
        {
            var value = kvp.Value;
            if (value == null)
                continue;
            parameterBuilder.Append(kvp.Key);
            parameterBuilder.Append('=');
            parameterBuilder.Append(AWSSDKUtils.UrlEncode(value, false));
            parameterBuilder.Append('&');
        }

        var length = parameterBuilder.Length;
        return length == 0 ? string.Empty : parameterBuilder.ToString(0, length - 1);
    }

    private static IEnumerable<KeyValuePair<string, string>> GetParametersEnumerable(ParameterCollection collection)
    {
        foreach (var kvp in collection)
        {
            var name = kvp.Key;
            var value = kvp.Value;

            switch (value)
            {
                case StringParameterValue stringParameterValue:
                    yield return new KeyValuePair<string, string>(name, stringParameterValue.Value);
                    break;
                case StringListParameterValue stringListParameterValue:
                    var sortedStringListParameterValue = stringListParameterValue.Value;
                    sortedStringListParameterValue.Sort(StringComparer.Ordinal);
                    foreach (var listValue in sortedStringListParameterValue)
                        yield return new KeyValuePair<string, string>(name, listValue);
                    break;
                case DoubleListParameterValue doubleListParameterValue:
                    var sortedDoubleListParameterValue = doubleListParameterValue.Value;
                    sortedDoubleListParameterValue.Sort();
                    foreach (var listValue in sortedDoubleListParameterValue)
                        yield return new KeyValuePair<string, string>(name, listValue.ToString(CultureInfo.InvariantCulture));
                    break;
                default:
                    throw new AmazonClientException("Unsupported parameter value type '" + value.GetType().FullName + "'");
            }
        }
    }

    public static async Task CreateSecretsManagerResources()
    {
        Console.WriteLine("Creating SecretsManager Resources......");
        var secretsManagerClient = new AmazonSecretsManagerClient(new AmazonSecretsManagerConfig
        {
            DisableRequestCompression = true,
            MaxErrorRetry = 0,
            RegionEndpoint = RegionEndpoint.USWest2,
        });

        // Create extra secrets to account for warmups.
        var numberOfSecrets = Utils.IterationsCount * 1.5;

        for (int i = 1; i <= numberOfSecrets; i++)
        {
            var createSecretRequest = new CreateSecretRequest
            {
                Name = $"TestSecret_{Utils.RunStartTimestamp}_{i.ToString("D3")}",
                SecretString = "A temporary secret value",
                Description = $"The testing secret for run {i.ToString("D3")}",
                Tags = new List<Tag>
            {
                new Tag
                {
                    Key = "Stage" ,
                    Value = "Production"
                },
                new Tag
                {
                    Key = "Iteration" ,
                    Value = i.ToString("D3")
                },
            }
            };

            var createSecretResponse = await secretsManagerClient.CreateSecretAsync(createSecretRequest);

            secretsIds.Add(createSecretResponse.ARN);

            var createBinarySecretRequest = new CreateSecretRequest
            {
                Name = $"TestBinarySecret_{Utils.RunStartTimestamp}_{i.ToString("D3")}",
                SecretBinary = new MemoryStream(Encoding.UTF8.GetBytes("A temporary secret value")),
                Description = $"The binary testing secret for run {i.ToString("D3")}",
                Tags = new List<Tag>
            {
                new Tag
                {
                    Key = "Stage" ,
                    Value = "Production"
                },
                new Tag
                {
                    Key = "Iteration" ,
                    Value = i.ToString("D3")
                },
            }
            };

            var createBinarySecretResponse = await secretsManagerClient.CreateSecretAsync(createBinarySecretRequest);
            secretsIds.Add(createBinarySecretResponse.ARN);
        }
    }
    public static async Task CleanupSecretsManagerResources()
    {
        Console.WriteLine("Cleaning up SecretsManager Resources......");
        var secretsManagerClient = new AmazonSecretsManagerClient(new AmazonSecretsManagerConfig
        {
            DisableRequestCompression = true,
            MaxErrorRetry = 0,
            RegionEndpoint = RegionEndpoint.USWest2,
        });

        foreach (var secretId in secretsIds)
        {
            await secretsManagerClient.DeleteSecretAsync(new DeleteSecretRequest { SecretId = secretId, ForceDeleteWithoutRecovery = true });
        }
    }
}

public class DebugInProcessConfigDry : DebugConfig
{
    public static readonly IConfig Instance = new DebugInProcessConfigDry();

    public override IEnumerable<Job> GetJobs()
        => new[]
        {
            Job.Dry
                .WithToolchain(
                    new InProcessEmitToolchain(
                        TimeSpan.FromHours(1),
                        true))
        };
}