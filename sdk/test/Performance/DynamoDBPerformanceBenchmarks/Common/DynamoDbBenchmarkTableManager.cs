using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using System;
using System.Threading;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

internal static class DynamoDbBenchmarkTableManager
{
    private const string TableName = "BenchmarkTable";

    public static void EnsureTableExists(AmazonDynamoDBClient client)
    {
        try
        {
            client.DescribeTableAsync(TableName).GetAwaiter().GetResult();
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
            ProvisionedThroughput = new ProvisionedThroughput(1, 1)
        };

        client.CreateTableAsync(request).GetAwaiter().GetResult();

        for (var i = 0; i < 10; i++)
        {
            var table = client.DescribeTableAsync(TableName).GetAwaiter().GetResult();
            if (string.Equals(table.Table.TableStatus, TableStatus.ACTIVE, StringComparison.Ordinal))
            {
                return;
            }

            Thread.Sleep(500);
        }
    }
}
