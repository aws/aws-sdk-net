using Amazon.DynamoDBv2;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[MemoryDiagnoser]
public abstract class LiveDynamoDbContextBenchmark : DynamoDbContextBenchmark
{
    [GlobalSetup]
    public async Task Setup()
    {
        BenchmarkContextRuntimeOptions.Configure(options =>
        {
            options.ClientFactory = _ => new AmazonDynamoDBClient();
        });

        using var client = new AmazonDynamoDBClient();
        await DynamoDbBenchmarkTableManager.EnsureTableExistsAsync(client).ConfigureAwait(false);

        ApplyParameterOverrides();

        State = new DynamoDbContextBenchmarkState(
            ItemSize,
            AttributeCount,
            ExpressionStyle,
            ObjectComplexity,
            ConverterUsage,
            AnnotationStyle);
        State.Setup();
    }
}
