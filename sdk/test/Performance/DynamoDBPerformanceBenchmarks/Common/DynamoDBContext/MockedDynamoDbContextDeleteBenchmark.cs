using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[MemoryDiagnoser]
public abstract class MockedDynamoDbContextDeleteBenchmark
{
    protected DynamoDbContextBenchmarkState State { get; private set; } = null!;

    [GlobalSetup]
    public void Setup()
    {
        BenchmarkContextRuntimeOptions.Configure(options =>
        {
            options.ClientFactory = MockDynamoDbClientFactory.Create;
        });

        State = new DynamoDbContextBenchmarkState(
            BenchmarkItemSize.Large,
            BenchmarkAttributeCount.Count200,
            BenchmarkExpressionStyle.None,
            BenchmarkObjectComplexity.Nested,
            BenchmarkConverterUsage.Default,
            BenchmarkAnnotationStyle.Standard);
        State.Setup();
    }

    
}
