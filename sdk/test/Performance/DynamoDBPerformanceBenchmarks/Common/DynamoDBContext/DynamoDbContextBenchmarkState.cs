using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq.Expressions;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

public sealed class DynamoDbContextBenchmarkState : MockedDynamoDbBenchmarkStateBase
{
    private const string TableName = "BenchmarkTable";
    private const string PartitionKeyValue = "pk";
    private const string SortKeyValue = "sk";

    private readonly BenchmarkItemSize _itemSize;
    private readonly BenchmarkAttributeCount _attributeCount;
    private readonly BenchmarkExpressionStyle _expressionStyle;
    private readonly BenchmarkObjectComplexity _objectComplexity;
    private readonly BenchmarkConverterUsage _converterUsage;
    private readonly BenchmarkAnnotationStyle _annotationStyle;

    private DynamoDBContext? _context;
    private object? _item;
    private Func<Task>? _contextLoad;
    private Func<Task>? _contextLoadWithOperationConfig;
    private Func<Task>? _contextLoadWithLoadConfig;
    private Func<Task>? _contextLoadKeyObject;
    private Func<Task>? _contextLoadKeyObjectWithOperationConfig;
    private Func<Task>? _contextLoadKeyObjectWithLoadConfig;
    private Func<Task>? _contextSave;
    private Func<Task>? _contextSaveWithOperationConfig;
    private Func<Task>? _contextSaveWithSaveConfig;
    private Func<Task>? _contextSaveWithType;
    private Func<Task>? _contextSaveWithTypeOperationConfig;
    private Func<Task>? _contextSaveWithTypeSaveConfig;
    private Func<Task>? _contextDelete;
    private Func<Task>? _contextDeleteWithOperationConfig;
    private Func<Task>? _contextDeleteWithDeleteConfig;
    private Func<Task>? _contextDeleteHashKeyRangeKey;
    private Func<Task>? _contextDeleteHashKeyRangeKeyWithOperationConfig;
    private Func<Task>? _contextDeleteHashKeyRangeKeyWithDeleteConfig;
    private Func<Task>? _contextQuery;
    private Func<Task>? _contextQueryWithQueryConfig;
    private Func<Task>? _contextQueryWithOperationConfig;
    private Func<Task>? _contextQueryWithQueryConditionalQueryConfig;
    private Func<Task>? _contextQueryWithQueryOperator;
    private Func<Task>? _contextQueryWithQueryOperatorQueryConfig;
    private Func<Task>? _contextQueryWithQueryOperatorOperationConfig;
    private Func<Task>? _contextScan;
    private Func<Task>? _contextScanWithScanConditionOperationConfig;
    private Func<Task>? _contextScanWithScanConditionScanConfig;
    private Func<Task>? _contextScanWithContextExpression;
    private Func<Task>? _contextScanWithContextExpressionScanConfig;

    public DynamoDbContextBenchmarkState(
        BenchmarkItemSize itemSize,
        BenchmarkAttributeCount attributeCount,
        BenchmarkExpressionStyle expressionStyle,
        BenchmarkObjectComplexity objectComplexity,
        BenchmarkConverterUsage converterUsage,
        BenchmarkAnnotationStyle annotationStyle)
    {
        _itemSize = itemSize;
        _attributeCount = attributeCount;
        _expressionStyle = expressionStyle;
        _objectComplexity = objectComplexity;
        _converterUsage = converterUsage;
        _annotationStyle = annotationStyle;
    }

    public void Setup()
    {
        var runtimeOptions = BenchmarkContextRuntimeOptions.Current;
        var client = SetupClient(_itemSize, _attributeCount, _annotationStyle, _objectComplexity, runtimeOptions.ClientFactory);

        _context = runtimeOptions.ContextFactory(client);

        _item = CreateItem();

        ConfigureContextDelegates(_converterUsage, _annotationStyle);
    }

    public Task ContextLoadAsync() => _contextLoad!();

    public Task ContextLoadWithOperationConfigAsync() => _contextLoadWithOperationConfig!();

    public Task ContextLoadWithLoadConfigAsync() => _contextLoadWithLoadConfig!();

    public Task ContextLoadKeyObjectAsync() => _contextLoadKeyObject!();

    public Task ContextLoadKeyObjectWithOperationConfigAsync() => _contextLoadKeyObjectWithOperationConfig!();

    public Task ContextLoadKeyObjectWithLoadConfigAsync() => _contextLoadKeyObjectWithLoadConfig!();

    public Task ContextSaveAsync() => _contextSave!();

    public Task ContextSaveWithOperationConfigAsync() => _contextSaveWithOperationConfig!();

    public Task ContextSaveWithSaveConfigAsync() => _contextSaveWithSaveConfig!();

    public Task ContextSaveWithTypeAsync() => _contextSaveWithType!();

    public Task ContextSaveWithTypeOperationConfigAsync() => _contextSaveWithTypeOperationConfig!();

    public Task ContextSaveWithTypeSaveConfigAsync() => _contextSaveWithTypeSaveConfig!();

    public Task ContextDeleteAsync() => _contextDelete!();

    public Task ContextDeleteWithOperationConfigAsync() => _contextDeleteWithOperationConfig!();

    public Task ContextDeleteWithDeleteConfigAsync() => _contextDeleteWithDeleteConfig!();

    public Task ContextDeleteHashKeyRangeKeyAsync() => _contextDeleteHashKeyRangeKey!();

    public Task ContextDeleteHashKeyRangeKeyWithOperationConfigAsync() => _contextDeleteHashKeyRangeKeyWithOperationConfig!();

    public Task ContextDeleteHashKeyRangeKeyWithDeleteConfigAsync() => _contextDeleteHashKeyRangeKeyWithDeleteConfig!();

    public Task ContextQueryAsync() => _contextQuery!();

    public Task ContextQueryWithQueryConfigAsync() => _contextQueryWithQueryConfig!();

    public Task ContextQueryWithOperationConfigAsync() => _contextQueryWithOperationConfig!();

    public Task ContextQueryWithQueryConditionalQueryConfigAsync() => _contextQueryWithQueryConditionalQueryConfig!();

    public Task ContextQueryWithQueryOperatorAsync() => _contextQueryWithQueryOperator!();

    public Task ContextQueryWithQueryOperatorQueryConfigAsync() => _contextQueryWithQueryOperatorQueryConfig!();

    public Task ContextQueryWithQueryOperatorOperationConfigAsync() => _contextQueryWithQueryOperatorOperationConfig!();

    public Task ContextScanAsync() => _contextScan!();

    public Task ContextScanWithScanConditionOperationConfigAsync() => _contextScanWithScanConditionOperationConfig!();

    public Task ContextScanWithScanConditionScanConfigAsync() => _contextScanWithScanConditionScanConfig!();

    public Task ContextScanWithContextExpression() => _contextScanWithContextExpression!();

    public Task ContextScanWithContextExpressionScanCondition() => _contextScanWithContextExpressionScanConfig!();

    public Task SeedAsync()
    {
        if (_context == null || _item == null)
        {
            throw new InvalidOperationException("State is not initialized.");
        }

        var saveConfig = new SaveConfig { OverrideTableName = TableName };
        return _context.SaveAsync(_item.GetType(), _item, saveConfig);
    }

    protected override void ConfigureContextDelegates<T>()
    {
        var typedItem = (T)_item!;
        var operationConfig = new DynamoDBOperationConfig { OverrideTableName = TableName };
        var loadConfig = new LoadConfig { OverrideTableName = TableName };
        var saveConfig = new SaveConfig { OverrideTableName = TableName };
        var deleteConfig = new DeleteConfig { OverrideTableName = TableName };
        var queryConfig = new QueryConfig { OverrideTableName = TableName };
        var queryConditional = QueryConditional.HashKeyEqualTo("PartitionKey", PartitionKeyValue);
        var scanConfig = new ScanConfig { OverrideTableName = TableName };
        var scanConditions = new List<ScanCondition>()
        {  new("PartitionKey", ScanOperator.Equal, ["pk"]) };
        var contextExpression  = CreateContextExpression<T>(typedItem);

        //LoadAsync
        _contextLoad = () => _context!.LoadAsync<T>(PartitionKeyValue, SortKeyValue);
        _contextLoadWithOperationConfig = () => _context!.LoadAsync<T>(PartitionKeyValue, SortKeyValue, operationConfig);
        _contextLoadWithLoadConfig = () => _context!.LoadAsync<T>(PartitionKeyValue, SortKeyValue, loadConfig);
        _contextLoadKeyObject = () => _context!.LoadAsync(typedItem);
        _contextLoadKeyObjectWithOperationConfig = () => _context!.LoadAsync(typedItem, operationConfig);
        _contextLoadKeyObjectWithLoadConfig = () => _context!.LoadAsync(typedItem, loadConfig);

        //SaveAsync
        _contextSave = () => _context!.SaveAsync(typedItem);
        _contextSaveWithOperationConfig = () => _context!.SaveAsync(typedItem, operationConfig);
        _contextSaveWithSaveConfig = () => _context!.SaveAsync(typedItem, saveConfig);
        _contextSaveWithType = () => _context!.SaveAsync(typeof(T), typedItem);
        _contextSaveWithTypeOperationConfig = () => _context!.SaveAsync(typeof(T), typedItem, operationConfig);
        _contextSaveWithTypeSaveConfig = () => _context!.SaveAsync(typeof(T), typedItem, saveConfig);

        //DeleteAsync
        _contextDelete = () => _context!.DeleteAsync(typedItem);
        _contextDeleteWithOperationConfig = () => _context!.DeleteAsync(typedItem, operationConfig);
        _contextDeleteWithDeleteConfig = () => _context!.DeleteAsync(typedItem, deleteConfig);
        _contextDeleteHashKeyRangeKey = () => _context!.DeleteAsync<T>(PartitionKeyValue, SortKeyValue);
        _contextDeleteHashKeyRangeKeyWithOperationConfig = () => _context!.DeleteAsync<T>(PartitionKeyValue, SortKeyValue, operationConfig);
        _contextDeleteHashKeyRangeKeyWithDeleteConfig = () => _context!.DeleteAsync<T>(PartitionKeyValue, SortKeyValue, deleteConfig);

        //QueryAsync
        _contextQuery = () =>
        {
            var search = _context!.QueryAsync<T>(PartitionKeyValue);
            return search.GetNextSetAsync();
        };

        _contextQueryWithQueryConfig = () =>
        {
            var search = _context!.QueryAsync<T>(PartitionKeyValue, queryConfig);
            return search.GetNextSetAsync();
        };

        _contextQueryWithOperationConfig = () =>
        {
            var search = _context!.QueryAsync<T>(PartitionKeyValue, operationConfig);
            return search.GetNextSetAsync();
        };
        _contextQueryWithQueryConditionalQueryConfig = () =>
        {
            var search = _context!.QueryAsync<T>(queryConditional, queryConfig);
            return search.GetNextSetAsync();
        };
        _contextQueryWithQueryOperator = () =>
        {
            var search = _context!.QueryAsync<T>("PartitionKey", QueryOperator.Equal, new[] { "pk" });
            return search.GetNextSetAsync();
        };
        _contextQueryWithQueryOperatorQueryConfig = () =>
        {
            var search = _context!.QueryAsync<T>("PartitionKey", QueryOperator.Equal, new[] { "pk" }, queryConfig);
            return search.GetNextSetAsync();
        };
        _contextQueryWithQueryOperatorOperationConfig = () =>
        {
            var search = _context!.QueryAsync<T>("PartitionKey", QueryOperator.Equal, new[] { "pk" }, operationConfig);
            return search.GetNextSetAsync();
        };

        //ScanAsync
        _contextScan = () =>
        {
            var search = _context!.ScanAsync<T>(scanConditions);
            return search.GetNextSetAsync();
        };

        _contextScanWithScanConditionOperationConfig = () =>
        {
            var search = _context!.ScanAsync<T>(scanConditions, operationConfig);
            return search.GetNextSetAsync();
        };

        _contextScanWithScanConditionScanConfig = () =>
        {
            var search = _context!.ScanAsync<T>(scanConditions, scanConfig);
            return search.GetNextSetAsync();
        };

        _contextScanWithContextExpression= () =>
        {
            var search = _context!.ScanAsync<T>(contextExpression);
            return search.GetNextSetAsync();
        };

        _contextScanWithContextExpressionScanConfig = () =>
        {
            var search = _context!.ScanAsync<T>(contextExpression, scanConfig);
            return search.GetNextSetAsync();
        };
    }

    private ContextExpression CreateContextExpression<T>(T typedItem)
    {
        var contextExpression = new ContextExpression();
        switch (typeof(T))
        {
            case Type t when t == typeof(BenchmarkItemMinimalWithConverter):
                {
                    contextExpression.SetFilter <BenchmarkItemMinimalWithConverter> (x => x.PartitionKey == "42");
                    return contextExpression;
                }
            case Type t when t == typeof(BenchmarkItemStandardWithConverter):
                {
                    contextExpression.SetFilter<BenchmarkItemStandardWithConverter>(x => x.PartitionKey == "42");
                    return contextExpression;
                }
            case Type t when t == typeof(BenchmarkItemAdvancedWithConverter):
                {
                    contextExpression.SetFilter<BenchmarkItemAdvancedWithConverter>(x => x.PartitionKey == "42");
                    return contextExpression;
                }
            case Type t when t == typeof(BenchmarkItemPolymorphicFlattenWithConverter):
                {
                    contextExpression.SetFilter<BenchmarkItemPolymorphicFlattenWithConverter>(x => x.PartitionKey == "42");
                    return contextExpression;
                }
            case Type t when t == typeof(BenchmarkItemMinimal):
                {
                    contextExpression.SetFilter<BenchmarkItemMinimal>(x => x.PartitionKey == "42");
                    return contextExpression;
                }
            case Type t when t == typeof(BenchmarkItemStandard):
                {
                    contextExpression.SetFilter<BenchmarkItemStandard>(x => x.PartitionKey == "42");
                    return contextExpression;
                }
            case Type t when t == typeof(BenchmarkItemAdvanced):
                {
                    contextExpression.SetFilter<BenchmarkItemAdvanced>(x => x.PartitionKey == "42");
                    return contextExpression;
                }
            case Type t when t == typeof(BenchmarkItemPolymorphicFlatten):
                {
                    contextExpression.SetFilter<BenchmarkItemPolymorphicFlatten>(x => x.PartitionKey == "42");
                    return contextExpression;
                }
            default: throw new InvalidOperationException($"Unsupported benchmark item type: {typeof(T)}."); ;
        }
    }

    private object CreateItem()
    {
        var itemType = GetItemType(_converterUsage, _annotationStyle);
        var item = Activator.CreateInstance(itemType) ?? throw new InvalidOperationException("Failed to create benchmark item.");
        var payload = CreatePayload();
        var nested = _objectComplexity == BenchmarkObjectComplexity.Nested
            ? new BenchmarkNestedDetails { DetailOne = payload, DetailTwo = payload, DetailThree = payload }
            : null;
        var flattened = _annotationStyle == BenchmarkAnnotationStyle.PolymorphicFlatten
            ? new BenchmarkFlattenedDetails { FlatOne = payload, FlatTwo = payload }
            : null;
        var polymorphic = _annotationStyle == BenchmarkAnnotationStyle.PolymorphicFlatten
            ? new BenchmarkPolymorphicAlpha { BaseDetail = payload, AlphaDetail = payload }
            : null;

        var attributes = CreateAttributes();

        SetProperty(item, "PartitionKey", PartitionKeyValue);
        SetProperty(item, "SortKey", SortKeyValue);
        SetProperty(item, "Payload", payload);
        SetProperty(item, "NumericValue", 42);
        SetProperty(item, "Flag", true);
        SetProperty(item, "Timestamp", DateTime.UnixEpoch);
        SetProperty(item, "Renamed", "renamed");
        SetProperty(item, "Optional", _annotationStyle == BenchmarkAnnotationStyle.Advanced ? null : "optional");
        SetProperty(item, "Status", BenchmarkStatus.Active);
        SetProperty(item, "Version", 1);
        SetProperty(item, "Attributes", attributes);
        SetProperty(item, "Nested", nested);
        SetProperty(item, "Flattened", flattened);
        SetProperty(item, "Polymorphic", polymorphic);

        return item;
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

    private static void SetProperty(object item, string name, object? value)
    {
        var property = item.GetType().GetProperty(name, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
        property?.SetValue(item, value);
    }

}
