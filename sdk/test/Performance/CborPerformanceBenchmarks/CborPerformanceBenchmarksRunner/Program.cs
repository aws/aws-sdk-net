using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using CborPerformanceBenchmarksRunner.CloudWatchBenchmarks;
using CborPerformanceBenchmarksRunner.EchoBenchmarks;
using CborPerformanceBenchmarksRunner.SecretsManagerBenchmarks;

var benchmarkTypes = new Type[]
        {
            typeof(AllTypesBenchmarks),
            typeof(ComplexObjectBenchmarks),
            typeof(LongListOfStringsBenchmarks),
            typeof(ListOfComplexObjectBenchmarks),
            typeof(VeryLargeBlobBenchmarks),
            typeof(PutAndGetMetricDataBenchmarks),
            typeof(ListMetricsBenchmarks),
            typeof(PutAndGetStringBenchmarks),
            typeof(PutAndGetBinaryBenchmarks),
            typeof(DescribeSecretBenchmarks),
            typeof(ListSecretsBenchmarks),
        };

await Utils.CreateSecretsManagerResources();

try
{
    var config = ManualConfig.Create(DefaultConfig.Instance)
        .WithOptions(ConfigOptions.JoinSummary)
        .HideColumns("Method", "Type", "Arguments", "Median", "Mean", "Error", "Max", "StdDev", "RatioSD")
        .AddColumn(new ServiceColumn())
        .AddColumn(new TestCaseColumn())
        .AddColumn(new BenchmarkColumn())
        .AddColumn(StatisticColumn.P50)
        .AddColumn(StatisticColumn.P90)
        .AddColumn(StatisticColumn.Max)
        .AddJob(Job.Default
            .WithIterationCount(Utils.IterationsCount)
            .WithEnvironmentVariable("ResultsPath", Utils.ResultsPath)
            .WithEnvironmentVariable("RunStartTimestamp", Utils.RunStartTimestamp.ToString())
            .WithId("RPCv2CborProtocol")
            .WithArguments(new[] { new MsBuildArgument(@"-p:UseCbor=""true""") }))
        .AddJob(Job.Default
            .WithIterationCount(Utils.IterationsCount)
            .WithEnvironmentVariable("ResultsPath", Utils.ResultsPath)
            .WithEnvironmentVariable("RunStartTimestamp", Utils.RunStartTimestamp.ToString())
            .WithId("OldProtocol")
            .WithArguments(new[] { new MsBuildArgument(@"-p:UseCbor=""false""") })
            .AsBaseline());

#if DEBUG
    Console.WriteLine("Debug mode......");
    config = ManualConfig.Create(DebugInProcessConfigDry.Instance);
#endif

    var summaries = BenchmarkSwitcher.FromTypes(benchmarkTypes).Run(args, config);

    Utils.StoreBenchmarkSummaries(summaries);
}
finally
{
    await Utils.CleanupSecretsManagerResources();
}
