using Amazon.DynamoDBv2;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[MemoryDiagnoser]
public abstract class LiveDynamoDbContextBenchmark : DynamoDbContextBenchmark
{
    [GlobalSetup]
    public void Setup()
    {
        BenchmarkContextRuntimeOptions.Configure(options =>
        {
            options.ClientFactory = _ => new AmazonDynamoDBClient();
        });

        DynamoDbBenchmarkTableManager.EnsureTableExists(new AmazonDynamoDBClient());

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
