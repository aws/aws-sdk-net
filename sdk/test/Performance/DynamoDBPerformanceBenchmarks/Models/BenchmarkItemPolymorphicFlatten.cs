using Amazon.DynamoDBv2.DataModel;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[DynamoDBTable("BenchmarkTable")]
public class BenchmarkItemPolymorphicFlatten
{
    [DynamoDBHashKey]
    public string? PartitionKey { get; set; }

    [DynamoDBRangeKey]
    public string? SortKey { get; set; }

    public string? Payload { get; set; }
    public int NumericValue { get; set; }
    public bool Flag { get; set; }
    public DateTime Timestamp { get; set; }
    public string? Renamed { get; set; }
    public string? Optional { get; set; }
    public BenchmarkStatus Status { get; set; }
    public int Version { get; set; }
    public Dictionary<string, string>? Attributes { get; set; }

    [DynamoDBFlatten]
    public BenchmarkFlattenedDetails? Flattened { get; set; }

    [DynamoDBPolymorphicType("alpha", typeof(BenchmarkPolymorphicAlpha))]
    [DynamoDBPolymorphicType("beta", typeof(BenchmarkPolymorphicBeta))]
    public BenchmarkPolymorphicDetails? Polymorphic { get; set; }
}
