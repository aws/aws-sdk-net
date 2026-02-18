using Amazon.DynamoDBv2.DataModel;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[DynamoDBTable("BenchmarkTable")]
public class BenchmarkItemMinimalWithConverter
{
    [DynamoDBHashKey]
    public string? PartitionKey { get; set; }

    [DynamoDBRangeKey]
    public string? SortKey { get; set; }

    [DynamoDBProperty(typeof(UppercaseStringConverter))]
    public string? Payload { get; set; }

    public int NumericValue { get; set; }
    public bool Flag { get; set; }
    public DateTime Timestamp { get; set; }
    public string? Renamed { get; set; }
    public string? Optional { get; set; }
    public BenchmarkStatus Status { get; set; }
    public int Version { get; set; }
    public Dictionary<string, string>? Attributes { get; set; }
    public BenchmarkNestedDetails? Nested { get; set; }
}
