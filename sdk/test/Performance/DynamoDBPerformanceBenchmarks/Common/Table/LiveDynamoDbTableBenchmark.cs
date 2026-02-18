using Amazon.DynamoDBv2;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[MemoryDiagnoser]
public abstract class LiveDynamoDbTableBenchmark : DynamoDbTableBenchmark
{
    [GlobalSetup]
    public void Setup()
    {
        BenchmarkTableRuntimeOptions.Configure(options =>
        {
            options.ClientFactory = _ => new AmazonDynamoDBClient();
        });

        DynamoDbBenchmarkTableManager.EnsureTableExists(new AmazonDynamoDBClient());

        ApplyParameterOverrides();

        State = new DynamoDbTableBenchmarkState(
            ItemSize,
            AttributeCount,
            ExpressionStyle,
            ObjectComplexity);
        State.Setup();
    }
}
