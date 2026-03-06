using Amazon.DynamoDBv2.DocumentModel;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

public sealed class DynamoDbTableBenchmarkState : MockedDynamoDbBenchmarkStateBase
{
    private const string TableName = "BenchmarkTable";
    private const string PartitionKeyValue = "pk";
    private const string SortKeyValue = "sk";

    private readonly BenchmarkItemSize _itemSize;
    private readonly BenchmarkAttributeCount _attributeCount;
    private readonly BenchmarkExpressionStyle _expressionStyle;
    private readonly BenchmarkObjectComplexity _objectComplexity;
    private readonly BenchmarkAnnotationStyle _annotationStyle = BenchmarkAnnotationStyle.Standard;

    private Amazon.DynamoDBv2.DocumentModel.Table? _table;
    private Document? _document;
    private QueryFilter? _tableQueryFilter;
    private ScanFilter? _tableScanFilter;

    public DynamoDbTableBenchmarkState(
        BenchmarkItemSize itemSize,
        BenchmarkAttributeCount attributeCount,
        BenchmarkExpressionStyle expressionStyle,
        BenchmarkObjectComplexity objectComplexity)
    {
        _itemSize = itemSize;
        _attributeCount = attributeCount;
        _expressionStyle = expressionStyle;
        _objectComplexity = objectComplexity;
    }

    public void Setup()
    {
        var runtimeOptions = BenchmarkTableRuntimeOptions.Current;
        var client = SetupClient(_itemSize, _attributeCount, _annotationStyle, _objectComplexity, runtimeOptions.ClientFactory);

        _table = runtimeOptions.TableFactory(client, TableName);

        _document = CreateDocument();
        _tableQueryFilter = CreateTableQueryFilter();
        _tableScanFilter = CreateTableScanFilter();
    }

    public Task<Document?> TableGetItemAsync() => _table!.GetItemAsync(PartitionKeyValue, SortKeyValue);

    public Task<Document> TablePutItemAsync() => _table!.PutItemAsync(_document!);

    public Task TableDeleteItemAsync() => _table!.DeleteItemAsync(PartitionKeyValue, SortKeyValue);

    public Task<List<Document>> TableQueryAsync()
    {
        var search = _table!.Query(PartitionKeyValue, _tableQueryFilter);
        return search.GetNextSetAsync();
    }

    public Task<List<Document>> TableScanAsync()
    {
        var search = _table!.Scan(_tableScanFilter);
        return search.GetNextSetAsync();
    }

    private QueryFilter CreateTableQueryFilter()
    {
        var filter = new QueryFilter();
        if (_expressionStyle == BenchmarkExpressionStyle.None)
        {
            return filter;
        }

        filter.AddCondition("Payload", QueryOperator.Equal, "payload");
        if (_expressionStyle == BenchmarkExpressionStyle.Compound)
        {
            filter.AddCondition("NumericValue", QueryOperator.GreaterThan, 1);
        }

        return filter;
    }

    private ScanFilter CreateTableScanFilter()
    {
        var filter = new ScanFilter();
        if (_expressionStyle == BenchmarkExpressionStyle.None)
        {
            return filter;
        }

        filter.AddCondition("Payload", ScanOperator.Equal, "payload");
        if (_expressionStyle == BenchmarkExpressionStyle.Compound)
        {
            filter.AddCondition("NumericValue", ScanOperator.GreaterThan, 1);
        }

        return filter;
    }

    private Document CreateDocument()
    {
        var attributes = CreateAttributes();
        var payload = CreatePayload();
        var document = new Document
        {
            ["PartitionKey"] = PartitionKeyValue,
            ["SortKey"] = SortKeyValue,
            ["Payload"] = payload,
            ["NumericValue"] = 42,
            ["Flag"] = true,
            ["Timestamp"] = DateTime.UnixEpoch,
            ["Renamed"] = "renamed",
            ["Status"] = BenchmarkStatus.Active.ToString(),
            ["Version"] = 1,
            ["Attributes"] = CreateAttributeDocument(attributes)
        };

        document["Optional"] = "optional";

        if (_objectComplexity == BenchmarkObjectComplexity.Nested)
        {
            document["Nested"] = new Document
            {
                ["DetailOne"] = payload,
                ["DetailTwo"] = payload,
                ["DetailThree"] = payload
            };
        }

        return document;
    }

    private static Document CreateAttributeDocument(Dictionary<string, string> attributes)
    {
        var document = new Document();
        foreach (var attribute in attributes)
        {
            document[attribute.Key] = attribute.Value;
        }

        return document;
    }

    private Dictionary<string, string> CreateAttributes()
    {
        var count = (int)_attributeCount;
        var payload = CreatePayload();
        var attributes = new Dictionary<string, string>(count, StringComparer.Ordinal);
        for (var i = 0; i < count; i++)
        {
            attributes[$"attr{i:000}"] = payload;
        }

        return attributes;
    }

    private string CreatePayload()
    {
        var size = _itemSize == BenchmarkItemSize.Small ? 32 : 2048;
        return new string('a', size);
    }
}
