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
            },
            BillingMode = BillingMode.PAY_PER_REQUEST
        };

        await client.CreateTableAsync(request, cancellationToken).ConfigureAwait(false);

        string? lastObservedStatus = null;
        for (var i = 0; i < 10; i++)
        {
            var table = await client.DescribeTableAsync(TableName, cancellationToken).ConfigureAwait(false);
            lastObservedStatus = table.Table.TableStatus;
            if (string.Equals(lastObservedStatus, TableStatus.ACTIVE, StringComparison.Ordinal))
            {
                return;
            }
            await Task.Delay(500, cancellationToken).ConfigureAwait(false);
        }

        throw new global::System.TimeoutException(
            $"Timed out waiting for DynamoDB table '{TableName}' to become ACTIVE. Last observed status: '{lastObservedStatus ?? "unknown"}'.");
    }

    public static async Task DeleteTableAsync(AmazonDynamoDBClient client, CancellationToken cancellationToken = default)
    {
        try
        {
            await client.DeleteTableAsync(TableName, cancellationToken).ConfigureAwait(false);
        }
        catch (ResourceInUseException)
        {
        }
        catch (ResourceNotFoundException)
        {
        }
    }
}
