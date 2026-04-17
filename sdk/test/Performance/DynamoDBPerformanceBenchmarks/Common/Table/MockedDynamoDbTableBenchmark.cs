using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[MemoryDiagnoser]
public abstract class MockedDynamoDbTableBenchmark : DynamoDbTableBenchmark
{
    [GlobalSetup]
    public void Setup()
    {
        BenchmarkTableRuntimeOptions.Configure(options =>
        {
            options.ClientFactory = MockDynamoDbClientFactory.Create;
        });

        ApplyParameterOverrides();

        State = new DynamoDbTableBenchmarkState(
            ItemSize,
            AttributeCount,
            ExpressionStyle,
            ObjectComplexity);
        State.Setup();
    }
}
