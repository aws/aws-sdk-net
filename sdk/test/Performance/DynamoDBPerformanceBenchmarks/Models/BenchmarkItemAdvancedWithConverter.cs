using Amazon.DynamoDBv2.DataModel;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[DynamoDBTable("BenchmarkTable")]
public class BenchmarkItemAdvancedWithConverter
{
    [DynamoDBHashKey]
    [DynamoDBProperty]
    public string? PartitionKey { get; set; }

    [DynamoDBRangeKey]
    [DynamoDBProperty]
    public string? SortKey { get; set; }

    [DynamoDBProperty(typeof(UppercaseStringConverter))]
    public string? Payload { get; set; }

    [DynamoDBProperty]
    public int NumericValue { get; set; }

    [DynamoDBProperty]
    public bool Flag { get; set; }

    [DynamoDBProperty]
    public DateTime Timestamp { get; set; }

    [DynamoDBProperty("db_name")]
    public string? Renamed { get; set; }

    [DynamoDBProperty]
    public string? Optional { get; set; }

    [DynamoDBProperty("status_code")]
    public BenchmarkStatus Status { get; set; }

    [DynamoDBVersion]
    [DynamoDBProperty]
    public int? Version { get; set; }

    [DynamoDBProperty("attributes")]
    public Dictionary<string, string>? Attributes { get; set; }

    [DynamoDBProperty("nested_details")]
    public BenchmarkNestedDetails? Nested { get; set; }
}
