using Amazon.DynamoDBv2.DataModel;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[DynamoDBTable("BenchmarkTable")]
public class BenchmarkItemStandard
{
    [DynamoDBHashKey]
    [DynamoDBProperty]
    public string? PartitionKey { get; set; }

    [DynamoDBRangeKey]
    [DynamoDBProperty]
    public string? SortKey { get; set; }

    [DynamoDBProperty]
    public string? Payload { get; set; }

    [DynamoDBProperty]
    public int NumericValue { get; set; }

    [DynamoDBProperty]
    public bool Flag { get; set; }

    [DynamoDBProperty]
    public DateTime Timestamp { get; set; }

    [DynamoDBProperty]
    public string? Renamed { get; set; }

    [DynamoDBProperty]
    public string? Optional { get; set; }

    [DynamoDBProperty]
    public BenchmarkStatus Status { get; set; }

    [DynamoDBProperty]
    public int Version { get; set; }

    [DynamoDBProperty]
    public Dictionary<string, string>? Attributes { get; set; }

    [DynamoDBProperty]
    public BenchmarkNestedDetails? Nested { get; set; }
}
