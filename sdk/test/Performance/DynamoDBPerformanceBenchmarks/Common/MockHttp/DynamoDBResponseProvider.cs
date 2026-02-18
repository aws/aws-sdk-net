using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

public sealed class DynamoDBResponseProvider
{
    private const string TargetPrefix = "DynamoDB_20120810.";
    private const string TableName = "BenchmarkTable";
    private const string PartitionKeyValue = "pk";
    private const string SortKeyValue = "sk";
    private const string DerivedTypeAttributeName = "$type";
    private readonly string _getItemResponse;
    private readonly string _queryResponse;
    private readonly string _scanResponse;
    private readonly string _describeTableResponse;

    public DynamoDBResponseProvider(BenchmarkItemSize itemSize, BenchmarkAttributeCount attributeCount, BenchmarkAnnotationStyle annotationStyle, BenchmarkObjectComplexity complexity)
    {
        var payload = new string('a', itemSize == BenchmarkItemSize.Small ? 32 : 2048);
        var attributes = CreateAttributeMap(payload, (int)attributeCount);
        var item = CreateItemMap(payload, attributes, annotationStyle, complexity);

        _getItemResponse = JsonSerializer.Serialize(new Dictionary<string, object> { ["Item"] = item });
        _queryResponse = JsonSerializer.Serialize(new Dictionary<string, object>
        {
            ["Items"] = new[] { item },
            ["Count"] = 1,
            ["ScannedCount"] = 1
        });
        _scanResponse = JsonSerializer.Serialize(new Dictionary<string, object>
        {
            ["Items"] = new[] { item },
            ["Count"] = 1,
            ["ScannedCount"] = 1
        });
        _describeTableResponse = JsonSerializer.Serialize(new Dictionary<string, object>
        {
            ["Table"] = new Dictionary<string, object>
            {
                ["TableName"] = TableName,
                ["TableStatus"] = "ACTIVE",
                ["KeySchema"] = new[]
                {
                    new Dictionary<string, object> { ["AttributeName"] = "PartitionKey", ["KeyType"] = "HASH" },
                    new Dictionary<string, object> { ["AttributeName"] = "SortKey", ["KeyType"] = "RANGE" }
                },
                ["AttributeDefinitions"] = new[]
                {
                    new Dictionary<string, object> { ["AttributeName"] = "PartitionKey", ["AttributeType"] = "S" },
                    new Dictionary<string, object> { ["AttributeName"] = "SortKey", ["AttributeType"] = "S" }
                },
                ["ProvisionedThroughput"] = new Dictionary<string, object>
                {
                    ["ReadCapacityUnits"] = 1,
                    ["WriteCapacityUnits"] = 1,
                    ["NumberOfDecreasesToday"] = 0
                }
            }
        });
    }

    public HttpResponseMessage CreateResponse(string target)
    {
        var response = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(GetResponseBody(target), Encoding.UTF8, "application/x-amz-json-1.0")
        };

        return response;
    }

    private string GetResponseBody(string target)
    {
        if (target.EndsWith(TargetPrefix + "GetItem", StringComparison.Ordinal))
        {
            return _getItemResponse;
        }

        if (target.EndsWith(TargetPrefix + "Query", StringComparison.Ordinal))
        {
            return _queryResponse;
        }

        if (target.EndsWith(TargetPrefix + "Scan", StringComparison.Ordinal))
        {
            return _scanResponse;
        }

        if (target.EndsWith(TargetPrefix + "DescribeTable", StringComparison.Ordinal))
        {
            return _describeTableResponse;
        }

        return "{}";
    }

    private static Dictionary<string, object> CreateItemMap(string payload, Dictionary<string, object> attributes, BenchmarkAnnotationStyle annotationStyle, BenchmarkObjectComplexity complexity)
    {
        var map = new Dictionary<string, object>(StringComparer.Ordinal)
        {
            ["PartitionKey"] = CreateStringAttribute(PartitionKeyValue),
            ["SortKey"] = CreateStringAttribute(SortKeyValue),
            [GetAttributeName(annotationStyle, "Payload")] = CreateStringAttribute(payload),
            [GetAttributeName(annotationStyle, "NumericValue")] = CreateNumberAttribute("42"),
            [GetAttributeName(annotationStyle, "Flag")] = CreateBoolAttribute(true),
            [GetAttributeName(annotationStyle, "Timestamp")] = CreateStringAttribute(DateTime.UnixEpoch.ToString("O")),
            [GetAttributeName(annotationStyle, "Renamed")] = CreateStringAttribute("renamed"),
            [GetAttributeName(annotationStyle, "Optional")] = CreateStringAttribute("optional"),
            [GetAttributeName(annotationStyle, "Status")] = CreateStringAttribute(BenchmarkStatus.Active.ToString()),
            [GetAttributeName(annotationStyle, "Version")] = CreateNumberAttribute("1"),
            [GetAttributeName(annotationStyle, "Attributes")] = CreateMapAttribute(attributes)
        };

        if (annotationStyle == BenchmarkAnnotationStyle.PolymorphicFlatten)
        {
            map["FlatOne"] = CreateStringAttribute(payload);
            map["FlatTwo"] = CreateStringAttribute(payload);
            map["Polymorphic"] = CreateMapAttribute(new Dictionary<string, object>(StringComparer.Ordinal)
            {
                [DerivedTypeAttributeName] = CreateStringAttribute("alpha"),
                ["BaseDetail"] = CreateStringAttribute(payload),
                ["AlphaDetail"] = CreateStringAttribute(payload)
            });
        }

        if (complexity == BenchmarkObjectComplexity.Nested)
        {
            map[GetAttributeName(annotationStyle, "Nested")] = CreateMapAttribute(new Dictionary<string, object>
            {
                ["DetailOne"] = CreateStringAttribute(payload),
                ["DetailTwo"] = CreateStringAttribute(payload),
                ["DetailThree"] = CreateStringAttribute(payload)
            });
        }

        return map;
    }

    private static Dictionary<string, object> CreateAttributeMap(string payload, int count)
    {
        var map = new Dictionary<string, object>(count, StringComparer.Ordinal);
        for (var i = 0; i < count; i++)
        {
            map[$"attr{i:000}"] = CreateStringAttribute(payload);
        }

        return map;
    }

    private static string GetAttributeName(BenchmarkAnnotationStyle annotationStyle, string propertyName)
    {
        if (annotationStyle != BenchmarkAnnotationStyle.Advanced)
        {
            return propertyName;
        }

        return propertyName switch
        {
            "Renamed" => "db_name",
            "Status" => "status_code",
            "Attributes" => "attributes",
            "Nested" => "nested_details",
            _ => propertyName
        };
    }

    private static Dictionary<string, object> CreateStringAttribute(string value) => new() { ["S"] = value };

    private static Dictionary<string, object> CreateNumberAttribute(string value) => new() { ["N"] = value };

    private static Dictionary<string, object> CreateBoolAttribute(bool value) => new() { ["BOOL"] = value };

    private static Dictionary<string, object> CreateMapAttribute(Dictionary<string, object> value) => new() { ["M"] = value };
}
