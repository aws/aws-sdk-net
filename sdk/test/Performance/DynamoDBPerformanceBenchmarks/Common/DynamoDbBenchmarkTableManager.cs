using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

internal static class DynamoDbBenchmarkTableManager
{
    private const string TableName = "BenchmarkTable";

    public static async Task EnsureTableExistsAsync(AmazonDynamoDBClient client, CancellationToken cancellationToken = default)
    {
        try
        {
            await client.DescribeTableAsync(TableName, cancellationToken).ConfigureAwait(false);
            return;
        }
        catch (ResourceNotFoundException)
        {
        }

        var request = new CreateTableRequest
        {
            TableName = TableName,
            KeySchema = new List<KeySchemaElement>
            {
                new("PartitionKey", KeyType.HASH),
                new("SortKey", KeyType.RANGE)
            },
            AttributeDefinitions = new List<AttributeDefinition>
            {
                new("PartitionKey", ScalarAttributeType.S),
                new("SortKey", ScalarAttributeType.S)
            }
        };

        await client.CreateTableAsync(request, cancellationToken).ConfigureAwait(false);

        for (var i = 0; i < 10; i++)
        {
            var table = await client.DescribeTableAsync(TableName, cancellationToken).ConfigureAwait(false);
            if (string.Equals(table.Table.TableStatus, TableStatus.ACTIVE, StringComparison.Ordinal))
            {
                return;
            }

            await Task.Delay(500, cancellationToken).ConfigureAwait(false);
        }
    }
}
