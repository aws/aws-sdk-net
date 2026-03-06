using Amazon.DynamoDBv2;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

public abstract class MockedDynamoDbBenchmarkStateBase
{
    protected AmazonDynamoDBClient? Client { get; private set; }
    protected DynamoDBResponseProvider? ResponseProvider { get; private set; }

    protected AmazonDynamoDBClient SetupClient(
        BenchmarkItemSize itemSize,
        BenchmarkAttributeCount attributeCount,
        BenchmarkAnnotationStyle annotationStyle,
        BenchmarkObjectComplexity objectComplexity,
        Func<DynamoDBResponseProvider, AmazonDynamoDBClient> clientFactory)
    {
        ResponseProvider = new DynamoDBResponseProvider(itemSize, attributeCount, annotationStyle, objectComplexity);
        Client = clientFactory(ResponseProvider);
        return Client;
    }
}
