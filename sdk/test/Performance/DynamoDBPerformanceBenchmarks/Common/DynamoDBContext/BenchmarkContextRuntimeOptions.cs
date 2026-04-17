using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

public sealed class BenchmarkContextRuntimeOptions
{
    public Func<DynamoDBResponseProvider, AmazonDynamoDBClient> ClientFactory { get; set; } = null!;
    public Func<AmazonDynamoDBClient, DynamoDBContext> ContextFactory { get; set; } = null!;
    public BenchmarkParameterOverrides? ParameterOverrides { get; set; }

    public static BenchmarkContextRuntimeOptions Current { get; private set; } = CreateDefault();

    public static void Configure(Action<BenchmarkContextRuntimeOptions> configure)
    {
        var options = CreateDefault();
        configure(options);
        Current = options;
    }

    private static BenchmarkContextRuntimeOptions CreateDefault()
    {
        return new BenchmarkContextRuntimeOptions
        {
            ClientFactory = MockDynamoDbClientFactory.Create,
            ContextFactory = client => new DynamoDBContextBuilder().
                WithDynamoDBClient(() => client).Build()
        };
    }
}
