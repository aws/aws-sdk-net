using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;

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
    private Func<Task>? _contextDeleteHashKey;
    private Func<Task>? _contextDeleteHashKeyWithOperationConfig;
    private Func<Task>? _contextDeleteHashKeyWithDeleteConfig;
    private Func<Task>? _contextDeleteHashKeyRangeKey;
    private Func<Task>? _contextDeleteHashKeyRangeKeyWithOperationConfig;
    private Func<Task>? _contextDeleteHashKeyRangeKeyWithDeleteConfig;

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

        ConfigureContextDelegates();
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

    public Task ContextDeleteHashKeyAsync() => _contextDeleteHashKey!();

    public Task ContextDeleteHashKeyWithOperationConfigAsync() => _contextDeleteHashKeyWithOperationConfig!();

    public Task ContextDeleteHashKeyWithDeleteConfigAsync() => _contextDeleteHashKeyWithDeleteConfig!();

    public Task ContextDeleteHashKeyRangeKeyAsync() => _contextDeleteHashKeyRangeKey!();

    public Task ContextDeleteHashKeyRangeKeyWithOperationConfigAsync() => _contextDeleteHashKeyRangeKeyWithOperationConfig!();

    public Task ContextDeleteHashKeyRangeKeyWithDeleteConfigAsync() => _contextDeleteHashKeyRangeKeyWithDeleteConfig!();

    public Task SeedAsync()
    {
        if (_context == null || _item == null)
        {
            throw new InvalidOperationException("State is not initialized.");
        }

        var saveConfig = new SaveConfig { OverrideTableName = TableName };
        return _context.SaveAsync(_item.GetType(), _item, saveConfig);
    }

    public Task ContextQueryAsync()
    {
        throw new NotImplementedException();
    }

    public Task ContextScanAsync()
    {
        throw new NotImplementedException();
    }

    private void ConfigureContextDelegates()
    {
        var itemType = GetItemType();
        var configureMap = new Dictionary<Type, Action>
        {
            [typeof(BenchmarkItemMinimal)] = ConfigureContextDelegates<BenchmarkItemMinimal>,
            [typeof(BenchmarkItemMinimalWithConverter)] = ConfigureContextDelegates<BenchmarkItemMinimalWithConverter>,
            [typeof(BenchmarkItemStandard)] = ConfigureContextDelegates<BenchmarkItemStandard>,
            [typeof(BenchmarkItemStandardWithConverter)] = ConfigureContextDelegates<BenchmarkItemStandardWithConverter>,
            [typeof(BenchmarkItemAdvanced)] = ConfigureContextDelegates<BenchmarkItemAdvanced>,
            [typeof(BenchmarkItemAdvancedWithConverter)] = ConfigureContextDelegates<BenchmarkItemAdvancedWithConverter>,
            [typeof(BenchmarkItemPolymorphicFlatten)] = ConfigureContextDelegates<BenchmarkItemPolymorphicFlatten>,
            [typeof(BenchmarkItemPolymorphicFlattenWithConverter)] = ConfigureContextDelegates<BenchmarkItemPolymorphicFlattenWithConverter>
        };

        if (!configureMap.TryGetValue(itemType, out var configure))
        {
            throw new InvalidOperationException($"Unsupported benchmark item type: {itemType}.");
        }

        configure();
    }

    private void ConfigureContextDelegates<T>()
    {
        var typedItem = (T)_item!;
        var operationConfig = new DynamoDBOperationConfig { OverrideTableName = TableName };
        var loadConfig = new LoadConfig { OverrideTableName = TableName };
        var saveConfig = new SaveConfig { OverrideTableName = TableName };
        var deleteConfig = new DeleteConfig { OverrideTableName = TableName };

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
        _contextDeleteHashKey = () => _context!.DeleteAsync<T>(PartitionKeyValue);
        _contextDeleteHashKeyWithOperationConfig = () => _context!.DeleteAsync<T>(PartitionKeyValue, operationConfig);
        _contextDeleteHashKeyWithDeleteConfig = () => _context!.DeleteAsync<T>(PartitionKeyValue, deleteConfig);
        _contextDeleteHashKeyRangeKey = () => _context!.DeleteAsync<T>(PartitionKeyValue, SortKeyValue);
        _contextDeleteHashKeyRangeKeyWithOperationConfig = () => _context!.DeleteAsync<T>(PartitionKeyValue, SortKeyValue, operationConfig);
        _contextDeleteHashKeyRangeKeyWithDeleteConfig = () => _context!.DeleteAsync<T>(PartitionKeyValue, SortKeyValue, deleteConfig);
    }

    private object CreateItem()
    {
        var itemType = GetItemType();
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
        var size = _itemSize == BenchmarkItemSize.Small ? 32 : 2048;
        return new string('a', size);
    }

    private static void SetProperty(object item, string name, object? value)
    {
        var property = item.GetType().GetProperty(name, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
        property?.SetValue(item, value);
    }

    private Type GetItemType()
    {
        var usesConverter = _converterUsage != BenchmarkConverterUsage.Default;
        return _annotationStyle switch
        {
            BenchmarkAnnotationStyle.Minimal => usesConverter ? typeof(BenchmarkItemMinimalWithConverter) : typeof(BenchmarkItemMinimal),
            BenchmarkAnnotationStyle.Standard => usesConverter ? typeof(BenchmarkItemStandardWithConverter) : typeof(BenchmarkItemStandard),
            BenchmarkAnnotationStyle.Advanced => usesConverter ? typeof(BenchmarkItemAdvancedWithConverter) : typeof(BenchmarkItemAdvanced),
            _ => usesConverter ? typeof(BenchmarkItemPolymorphicFlattenWithConverter) : typeof(BenchmarkItemPolymorphicFlatten)
        };
    }

}
