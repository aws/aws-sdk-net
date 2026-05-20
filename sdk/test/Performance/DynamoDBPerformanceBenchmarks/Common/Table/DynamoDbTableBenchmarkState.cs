using Amazon.DynamoDBv2.DocumentModel;
#pragma warning disable CS0618

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
    private Document? _document;

    private Func<Task>? _tableDeleteItemAsync;
    private Func<Task>? _tableDeleteDocumentAsync;
    private Func<Task>? _tableDeleteDocumentWithOperationConfigAsync;
    private Func<Task>? _tableDeleteHashKeyRangeKeyWithOperationConfigAsync;
    private Func<Task>? _tableDeleteWithOperationRequest;
    private Func<Task>? _tableDeleteDynamoDbEntry;
    private Func<Task>? _tableDeleteDynamoDbEntryWithOperationConfigAsync;

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
        _document = CreateDocument();

        ConfigureContextDelegates(_converterUsage, _annotationStyle);
    }

    protected override void ConfigureContextDelegates<T>()
    {
        var _dictionaryKey = new Dictionary<string, DynamoDBEntry>()
        {
            ["PartitionKey"] = PartitionKeyValue,
            ["SortKey"] = SortKeyValue
        };
        
        var tableScanFilter = CreateTableScanFilter();
        var scanFilterExpression = CreateScanFilterExpression();
        var tableQueryFilter = CreateTableQueryFilter();
        var queryKeyExpression = CreateQueryKeyExpression();
        var queryFilterExpression = CreateQueryFilterExpression();

        var deleteConfig = new DeleteItemOperationConfig() { ReturnValues = ReturnValues.AllOldAttributes};
        var deleteRequest = new DeleteItemDocumentOperationRequest() { Key = _dictionaryKey, ReturnValues = ReturnValues.AllOldAttributes };
        var getItemConfig = new GetItemOperationConfig() { ConsistentRead = true };
        var getItemRequest = new GetItemDocumentOperationRequest() { Key = _dictionaryKey };
        var putItemConfig = new PutItemOperationConfig() { ReturnValues = ReturnValues.AllNewAttributes };
        var putItemRequest = new PutItemDocumentOperationRequest() { Document = _document };
        var queryConfig = new QueryOperationConfig
        {
            KeyExpression = queryKeyExpression,
            FilterExpression = queryFilterExpression
        };
        var queryRequest = new QueryDocumentOperationRequest() 
        { 
            KeyConditionExpression = queryKeyExpression,
            FilterExpression = queryFilterExpression
        };
        var scanConfig = new ScanOperationConfig
        {
            FilterExpression = scanFilterExpression
        };
        var scanRequest = new ScanDocumentOperationRequest() { FilterExpression = scanFilterExpression };

        //delete
        _tableDeleteItemAsync = () => _table!.DeleteItemAsync(PartitionKeyValue, SortKeyValue);
        _tableDeleteDocumentAsync = () => _table!.DeleteItemAsync(_document);
        _tableDeleteDocumentWithOperationConfigAsync = () => _table!.DeleteItemAsync(_document, deleteConfig);
        _tableDeleteHashKeyRangeKeyWithOperationConfigAsync = () => _table!.DeleteItemAsync(PartitionKeyValue, SortKeyValue, deleteConfig);
        _tableDeleteWithOperationRequest = () => _table!.DeleteItemAsync(deleteRequest);
        _tableDeleteDynamoDbEntry = () => _table!.DeleteItemAsync(_dictionaryKey);
        _tableDeleteDynamoDbEntryWithOperationConfigAsync = () => _table!.DeleteItemAsync(_dictionaryKey, deleteConfig);

        //get item
        _tableGetItemAsync = () => _table!.GetItemAsync(PartitionKeyValue, SortKeyValue);
        _tableGetHashKeyRangeKeyWithOperationConfigAsync = () => _table!.GetItemAsync(PartitionKeyValue, SortKeyValue, getItemConfig);
        _tableGetWithOperationRequest = () => _table!.GetItemAsync(getItemRequest);
        _tableGetDynamoDbEntry = () => _table!.GetItemAsync(_dictionaryKey);
        _tableGetDynamoDbEntryWithOperationConfigAsync = () => _table!.GetItemAsync(_dictionaryKey, getItemConfig);

        //put item
        _tablePutItemAsync = () => _table!.PutItemAsync(_document!);
        _tablePutItemWithOperationConfigAsync = () => _table!.PutItemAsync(_document!, putItemConfig);
        _tablePutItemWithOperationRequestAsync = () => _table!.PutItemAsync(putItemRequest);

        //query
        _tableQueryAsync = () =>
        {
            var search = _table!.Query(PartitionKeyValue, tableQueryFilter);
            return search.GetNextSetAsync();
        };
        _tableQueryWithExpressionAsync = () =>
        {
            var search = _table!.Query(PartitionKeyValue, new Expression
            {
                ExpressionStatement = "NumericValue = :P0",
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                {
                    [":P0"] = 42
                }
            });
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
            var search = _table!.Scan(scanFilterExpression);
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

    // Delete item;
    public Task TableDeleteItemAsync() => _tableDeleteItemAsync!();

    public Task TableDeleteDocumentAsync() => _tableDeleteDocumentAsync!();

    public Task TableDeleteDocumentWithOperationConfigAsync() => _tableDeleteDocumentWithOperationConfigAsync!();

    public Task TableDeleteHashKeyRangeKeyWithOperationConfigAsync() => _tableDeleteHashKeyRangeKeyWithOperationConfigAsync!();

    public Task TableDeleteWithOperationRequest() => _tableDeleteWithOperationRequest!();

    public Task TableDeleteDynamoDbEntry() => _tableDeleteDynamoDbEntry!();

    public Task TableDeleteDynamoDbEntryWithOperationConfigAsync() => _tableDeleteDynamoDbEntryWithOperationConfigAsync!();

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

    public Task SeedAsync()
    {
        if (_table == null || _document == null)
        {
            throw new InvalidOperationException("State is not initialized.");
        }

        return _table.PutItemAsync(_document);
    }

    private Expression CreateScanFilterExpression()
    {
        var parts = new List<string>();
        var values = new Dictionary<string, DynamoDBEntry>();

        parts.Add("PartitionKey = :pk");
        values[":pk"] = PartitionKeyValue;

        if (_expressionStyle != BenchmarkExpressionStyle.None)
        {
            parts.Add("Renamed = :P0");
            values[":P0"] = "renamed";
        }

        if (_expressionStyle == BenchmarkExpressionStyle.Compound)
        {
            parts.Add("NumericValue > :P1");
            values[":P1"] = 1;
        }

        return new Expression
        {
            ExpressionStatement = string.Join(" AND ", parts),
            ExpressionAttributeValues = values
        };
    }

    private Expression CreateQueryKeyExpression()
    {
        var keyExpression = new Expression
        {
            ExpressionStatement = "PartitionKey = :pk",
            ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
            {
                [":pk"] = PartitionKeyValue
            }
        };
        return keyExpression;
    }

    private Expression CreateQueryFilterExpression()
    {
        var parts = new List<string>();
        var values = new Dictionary<string, DynamoDBEntry>();

        parts.Add("Flag = :P0");
        values[":P0"] = true;

        if (_expressionStyle != BenchmarkExpressionStyle.None)
        {
            parts.Add("Renamed = :P1");
            values[":P1"] = "renamed";
        }

        if (_expressionStyle == BenchmarkExpressionStyle.Compound)
        {
            parts.Add("NumericValue > :P2");
            values[":P2"] = 1;
        }

        return new Expression
        {
            ExpressionStatement = string.Join(" AND ", parts),
            ExpressionAttributeValues = values
        };
    }

    private QueryFilter CreateTableQueryFilter()
    {
        var filter = new QueryFilter("PartitionKey", QueryOperator.Equal, PartitionKeyValue);
        if (_expressionStyle == BenchmarkExpressionStyle.None)
        {
            return filter;
        }

        if (_expressionStyle != BenchmarkExpressionStyle.None)
        {
            filter.AddCondition("Renamed", QueryOperator.Equal, "renamed");
        }

        if (_expressionStyle == BenchmarkExpressionStyle.Compound)
        {
            filter.AddCondition("NumericValue", QueryOperator.GreaterThan, 1);
        }
            return filter;
    }

    private ScanFilter CreateTableScanFilter()
    {
        var filter = new ScanFilter();
        filter.AddCondition("PartitionKey", ScanOperator.Equal, PartitionKeyValue);
        if (_expressionStyle == BenchmarkExpressionStyle.None)
        {
            return filter;
        }

        if (_expressionStyle != BenchmarkExpressionStyle.None)
        {
            filter.AddCondition("Renamed", ScanOperator.Equal, "renamed");
        }

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
            ["Optional"] = _annotationStyle == BenchmarkAnnotationStyle.Advanced ? null : "optional",
            ["Status"] = BenchmarkStatus.Active.ToString(),
            ["Version"] = 1,
            ["Attributes"] = CreateAttributeDocument(attributes),
        };

        if (_objectComplexity == BenchmarkObjectComplexity.Nested)
        {
            document["Nested"] = new Document
            {
                ["DetailOne"] = payload,
                ["DetailTwo"] = payload,
                ["DetailThree"] = payload
            };
        }

        if (_annotationStyle == BenchmarkAnnotationStyle.PolymorphicFlatten)
        {
            document["Flattened"] = new Document
            {
                ["FlatOne"] = payload,
                ["FlatTwo"] = payload,
            };
            document["Polymorphic"] = new Document
            {
                ["BaseDetail"] = payload,
                ["AlphaDetail"] = payload,
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
        var size = _itemSize == BenchmarkItemSize.Small ? 32 : 1024;
        return new string('a', size);
    }
}
