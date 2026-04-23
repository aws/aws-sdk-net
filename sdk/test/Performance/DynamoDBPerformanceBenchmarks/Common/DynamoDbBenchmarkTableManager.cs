using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

internal static class DynamoDbBenchmarkTableManager
{
    private const string TableName = "BenchmarkTable";
    private const int MaxDescribeAttempts = 60;
    private const int TableStatePollDelayMilliseconds = 500;

    public static async Task EnsureTableExistsAsync(AmazonDynamoDBClient client, CancellationToken cancellationToken = default)
    {
        string? lastObservedStatus = null;

        for (var i = 0; i < MaxDescribeAttempts; i++)
        {
            try
            {
                var response = await client.DescribeTableAsync(TableName, cancellationToken).ConfigureAwait(false);
                lastObservedStatus = response.Table.TableStatus;

                if (string.Equals(lastObservedStatus, TableStatus.ACTIVE, StringComparison.Ordinal))
                {
                    return;
                }
            }
            catch (ResourceNotFoundException)
            {
                lastObservedStatus = null;
                try
                {
                    await client.CreateTableAsync(CreateTableRequest(), cancellationToken).ConfigureAwait(false);
                }
                catch (ResourceInUseException)
                {
                }
            }

            await Task.Delay(TableStatePollDelayMilliseconds, cancellationToken).ConfigureAwait(false);
        }

        throw new TimeoutException(
            $"Timed out waiting for DynamoDB table '{TableName}' to become ACTIVE. Last observed status: '{lastObservedStatus ?? "unknown"}'.");
    }

    private static CreateTableRequest CreateTableRequest()
    {
        return new CreateTableRequest
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
