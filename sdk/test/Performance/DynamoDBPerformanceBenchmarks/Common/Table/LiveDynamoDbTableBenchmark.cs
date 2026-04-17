using Amazon.DynamoDBv2;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[MemoryDiagnoser]
public abstract class LiveDynamoDbTableBenchmark : DynamoDbTableBenchmark
{
    [GlobalSetup]
    public async Task Setup()
    {
        BenchmarkTableRuntimeOptions.Configure(options =>
        {
            options.ClientFactory = _ => new AmazonDynamoDBClient();
        });

        using var client = new AmazonDynamoDBClient();
        await DynamoDbBenchmarkTableManager.EnsureTableExistsAsync(client).ConfigureAwait(false);

        ApplyParameterOverrides();

        State = new DynamoDbTableBenchmarkState(
            ItemSize,
            AttributeCount,
            ExpressionStyle,
            ObjectComplexity);
        State.Setup();
    }

    [GlobalCleanup]
    public async Task Cleanup()
    {
        using var client = new AmazonDynamoDBClient();
        await DynamoDbBenchmarkTableManager.DeleteTableAsync(client).ConfigureAwait(false);
    }
}
