using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

public sealed class BenchmarkTableRuntimeOptions
{
    public Func<DynamoDBResponseProvider, AmazonDynamoDBClient> ClientFactory { get; set; } = null!;
    public Func<AmazonDynamoDBClient, string, Amazon.DynamoDBv2.DocumentModel.Table> TableFactory { get; set; } = null!;
    public BenchmarkParameterOverrides? ParameterOverrides { get; set; }

    public static BenchmarkTableRuntimeOptions Current { get; private set; } = CreateDefault();

    public static void Configure(Action<BenchmarkTableRuntimeOptions> configure)
    {
        var options = CreateDefault();
        configure(options);
        Current = options;
    }

    private static BenchmarkTableRuntimeOptions CreateDefault()
    {
        return new BenchmarkTableRuntimeOptions
        {
            ClientFactory = MockDynamoDbClientFactory.Create,
            TableFactory = (client, tableName) => new TableBuilder(client, tableName)
                .AddHashKey("pk", DynamoDBEntryType.String)
                .AddRangeKey("sk", DynamoDBEntryType.String)
                .Build()
        };
    }
}
