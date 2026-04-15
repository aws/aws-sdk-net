using Amazon.DynamoDBv2.DataModel;
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
    private readonly BenchmarkConverterUsage _converterUsage = BenchmarkConverterUsage.Default;
    private readonly BenchmarkAnnotationStyle _annotationStyle = BenchmarkAnnotationStyle.Standard;

    private Amazon.DynamoDBv2.DocumentModel.Table? _table;

    private Func<Task>? _tableDeleteItemAsync;
    private Func<Task>? _tableDeleteDocumentAsync;
    private Func<Task>? _tableDeleteDocumentWithOperationConfigAsync;
    private Func<Task>? _tableDeleteHashKeyRangeKeyWithOperationConfigAsync;
    private Func<Task>? _tableDeleteWithOperationRequest;
    private Func<Task>? _tableDeteleDynamoDbEntry;
    private Func<Task>? _tableDeteleDynamoDbEntryWithOperationConfigAsync;

    private Func<Task>? _tableGetItemAsync;
    private Func<Task>? _tableGetHashKeyRangeKeyWithOperationConfigAsync;
    private Func<Task>? _tableGetWithOperationRequest;
    private Func<Task>? _tableGetDynamoDbEntry;
    private Func<Task>? _tableGetDynamoDbEntryWithOperationConfigAsync;

    private Func<Task>? _tablePutItemAsync;
    private Func<Task>? _tablePutItemWithOperationConfigAsync;
    private Func<Task>? _tablePutItemWithOperationRequestAsync;

    private Func<Task>? _tableQueryAsync;
    private Func<Task>? _tableQueryWithExpressionAsync;
    private Func<Task>? _tableQueryWithFilterAsync;
    private Func<Task>? _tableQueryWithOperationConfigAsync;
    private Func<Task>? _tableQueryWithOperationRequestAsync;

    private Func<Task>? _tableScanAsync;
    private Func<Task>? _tableScanWithExpressionAsync;
    private Func<Task>? _tableScanWithOperationConfigAsync;
    private Func<Task>? _tableScanWithOperationRequestAsync;

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

        ConfigureContextDelegates(_converterUsage, _annotationStyle);
    }

    protected override void ConfigureContextDelegates<T>()
    {
        var _dictionaryKey = new Dictionary<string, DynamoDBEntry>()
        {
            ["pk"] = PartitionKeyValue,
            ["sk"] = SortKeyValue
        };
        var document = CreateDocument();
        var tableQueryFilter = CreateTableQueryFilter();
        var tableScanFilter = CreateTableScanFilter();
        var tableExpression = CreateExpression();

        var deleteConfig = new DeleteItemOperationConfig() { ReturnValues = ReturnValues.AllOldAttributes};
        var deleteRequest = new DeleteItemDocumentOperationRequest() { Key = _dictionaryKey, ReturnValues = ReturnValues.AllOldAttributes };
        var getItemConfig = new GetItemOperationConfig() { ConsistentRead = true };
        var getItemRequest = new GetItemDocumentOperationRequest() { Key = _dictionaryKey };
        var putItemConfig = new PutItemOperationConfig() { ReturnValues = ReturnValues.AllNewAttributes };
        var putItemRequest = new PutItemDocumentOperationRequest() { Document = document };
        var queryConfig = new QueryOperationConfig() { Filter = tableQueryFilter };
        var queryRequest = new QueryDocumentOperationRequest() { ProjectionExpression = tableExpression };
        var scanConfig = new ScanOperationConfig() { Filter = tableScanFilter };
        var scanRequest = new ScanDocumentOperationRequest() { ProjectionExpression = tableExpression };

        //delete
        _tableDeleteItemAsync = () => _table!.DeleteItemAsync(PartitionKeyValue, SortKeyValue);
        _tableDeleteDocumentAsync = () => _table!.DeleteItemAsync(document);
        _tableDeleteDocumentWithOperationConfigAsync = () => _table!.DeleteItemAsync(document, deleteConfig);
        _tableDeleteHashKeyRangeKeyWithOperationConfigAsync = () => _table!.DeleteItemAsync(PartitionKeyValue, SortKeyValue, deleteConfig);
        _tableDeleteWithOperationRequest = () => _table!.DeleteItemAsync(deleteRequest);
        _tableDeteleDynamoDbEntry = () => _table!.DeleteItemAsync(_dictionaryKey);
        _tableDeteleDynamoDbEntryWithOperationConfigAsync = () => _table!.DeleteItemAsync(_dictionaryKey, deleteConfig);

        //get item
        _tableGetItemAsync = () => _table!.GetItemAsync(PartitionKeyValue, SortKeyValue);
        _tableGetHashKeyRangeKeyWithOperationConfigAsync = () => _table!.GetItemAsync(PartitionKeyValue, SortKeyValue, getItemConfig);
        _tableGetWithOperationRequest = () => _table!.GetItemAsync(getItemRequest);
        _tableGetDynamoDbEntry = () => _table!.GetItemAsync(_dictionaryKey);
        _tableGetDynamoDbEntryWithOperationConfigAsync = () => _table!.GetItemAsync(_dictionaryKey, getItemConfig);

        //put item
        _tablePutItemAsync = () => _table!.PutItemAsync(document!);
        _tablePutItemWithOperationConfigAsync = () => _table!.PutItemAsync(document!, putItemConfig);
        _tablePutItemWithOperationRequestAsync = () => _table!.PutItemAsync(putItemRequest);

        //query
        _tableQueryAsync = () =>
        {
            var search = _table!.Query(PartitionKeyValue, tableQueryFilter);
            return search.GetNextSetAsync();
        };
        _tableQueryWithExpressionAsync = () =>
        {
            var search = _table!.Query(PartitionKeyValue, tableExpression);
            return search.GetNextSetAsync();
        };
        _tableQueryWithFilterAsync = () =>
        {
            var search = _table!.Query(tableQueryFilter);
            return search.GetNextSetAsync();
        };
        _tableQueryWithOperationConfigAsync = () =>
        {
            var search = _table!.Query(queryConfig);
            return search.GetNextSetAsync();
        };
        _tableQueryWithOperationRequestAsync = () =>
        {
            var search = _table!.Query(queryRequest);
            return search.GetNextSetAsync();
        };

        //scan
        _tableScanAsync = () =>
        {
            var search = _table!.Scan(tableScanFilter);
            return search.GetNextSetAsync();
        };
        _tableScanWithExpressionAsync = () =>
        {
            var search = _table!.Scan(tableExpression);
            return search.GetNextSetAsync();
        };
        _tableScanWithOperationConfigAsync = () =>
        {
            var search = _table!.Scan(scanConfig);
            return search.GetNextSetAsync();
        };
        _tableScanWithOperationRequestAsync = () =>
        {
            var search = _table!.Scan(scanRequest);
            return search.GetNextSetAsync();
        };
    }

    // Delete _tableDeleteItemAsync!();
    public Task TableDeleteItemAsync() => _tableDeleteItemAsync!();

    public Task TableDeleteDocumentAsync() => _tableDeleteDocumentAsync!();

    public Task TableDeleteDocumentWithOperationConfigAsync() => _tableDeleteDocumentWithOperationConfigAsync!();

    public Task TableDeleteHashKeyRangeKeyWithOperationConfigAsync() => _tableDeleteHashKeyRangeKeyWithOperationConfigAsync!();

    public Task TableDeleteWithOperationRequest() => _tableDeleteWithOperationRequest!();

    public Task TableDeteleDynamoDbEntry() => _tableDeteleDynamoDbEntry!();

    public Task TableDeteleDynamoDbEntryWithOperationConfigAsync() => _tableDeteleDynamoDbEntryWithOperationConfigAsync!();

    // Get item
    public Task TableGetItemAsync() => _tableGetItemAsync!();

    public Task TableGetHashKeyRangeKeyWithOperationConfigAsync() => _tableGetHashKeyRangeKeyWithOperationConfigAsync!();

    public Task TableGetWithOperationRequest() => _tableGetWithOperationRequest!();

    public Task TableGetDynamoDbEntry() => _tableGetDynamoDbEntry!();

    public Task TableGetDynamoDbEntryWithOperationConfigAsync() => _tableGetDynamoDbEntryWithOperationConfigAsync!();

    // Put item
    public Task TablePutItemAsync() => _tablePutItemAsync!();

    public Task TablePutItemWithOperationConfigAsync() => _tablePutItemWithOperationConfigAsync!();

    public Task TablePutItemWithOperationRequestAsync() => _tablePutItemWithOperationRequestAsync!();

    //Query
    public Task TableQueryAsync() => _tableQueryAsync!();
    public Task TableQueryWithExpressionAsync() => _tableQueryWithExpressionAsync!();

    public Task TableQueryWithFilterAsync() => _tableQueryWithFilterAsync!();

    public Task TableQueryWithOperationConfigAsync() => _tableQueryWithOperationConfigAsync!();

    public Task TableQueryWithOperationRequestAsync() => _tableQueryWithOperationRequestAsync!();

    //Scan
    public Task TableScanAsync() => _tableScanAsync!();

    public Task TableScanWithExpressionAsync() => _tableScanWithExpressionAsync!();

    public Task TableScanWithOperationConfigAsync() => _tableScanWithOperationConfigAsync!();
    public Task TableScanWithOperationRequestAsync() => _tableScanWithOperationRequestAsync!();

    private Expression CreateExpression()
    {
        var expression = new Expression();
        if (_expressionStyle == BenchmarkExpressionStyle.None)
        {
            return expression;
        }

        expression.ExpressionStatement = "#P0";
        expression.ExpressionAttributeNames = new Dictionary<string, string>()
        {
            {"#P0", "Payload" }
        };
        if (_expressionStyle == BenchmarkExpressionStyle.Compound)
        {
            expression.ExpressionStatement += ", #P1";
            expression.ExpressionAttributeNames.Add("#P1", "NumericValue");
        }

        return expression;
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
            ["pk"] = PartitionKeyValue,
            ["sk"] = SortKeyValue,
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
