using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[MemoryDiagnoser]
public abstract class MockedDynamoDbContextBenchmark: DynamoDbContextBenchmark
{
    [GlobalSetup]
    public void Setup()
    {
        BenchmarkContextRuntimeOptions.Configure(options =>
        {
            options.ClientFactory = MockDynamoDbClientFactory.Create;
        });

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
