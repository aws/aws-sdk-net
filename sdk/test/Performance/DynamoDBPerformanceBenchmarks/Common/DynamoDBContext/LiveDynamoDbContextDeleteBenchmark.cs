using Amazon.DynamoDBv2;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[MemoryDiagnoser]
public abstract class LiveDynamoDbContextDeleteBenchmark
{
    protected DynamoDbContextBenchmarkState State { get; private set; } = null!;

    [GlobalSetup]
    public async Task Setup()
    {
        BenchmarkContextRuntimeOptions.Configure(options =>
        {
            options.ClientFactory = _ => new AmazonDynamoDBClient();
        });

        using var client = new AmazonDynamoDBClient();
        await DynamoDbBenchmarkTableManager.EnsureTableExistsAsync(client).ConfigureAwait(false);

        State = new DynamoDbContextBenchmarkState(
            BenchmarkItemSize.Large,
            BenchmarkAttributeCount.Count200,
            BenchmarkExpressionStyle.None,
            BenchmarkObjectComplexity.Nested,
            BenchmarkConverterUsage.Default,
            BenchmarkAnnotationStyle.Standard);
        State.Setup();
        await State.SeedAsync().ConfigureAwait(false);
    }

    [GlobalCleanup]
    public Task Cleanup()
    {
        return Task.CompletedTask;
    }

    [IterationSetup]
    public async Task IterationSetup()
    {
        await State.SeedAsync().ConfigureAwait(false);
    }
}
