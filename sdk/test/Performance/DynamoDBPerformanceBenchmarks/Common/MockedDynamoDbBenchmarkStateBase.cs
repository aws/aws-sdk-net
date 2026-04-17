using Amazon.DynamoDBv2;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

public abstract class MockedDynamoDbBenchmarkStateBase
{
    protected AmazonDynamoDBClient? Client { get; private set; }
    protected DynamoDBResponseProvider? ResponseProvider { get; private set; }

    protected AmazonDynamoDBClient SetupClient(
        BenchmarkItemSize itemSize,
        BenchmarkAttributeCount attributeCount,
        BenchmarkAnnotationStyle annotationStyle,
        BenchmarkObjectComplexity objectComplexity,
        Func<DynamoDBResponseProvider, AmazonDynamoDBClient> clientFactory)
    {
        ResponseProvider = new DynamoDBResponseProvider(itemSize, attributeCount, annotationStyle, objectComplexity);
        Client = clientFactory(ResponseProvider);
        return Client;
    }

    protected Type GetItemType(BenchmarkConverterUsage converterUsage, BenchmarkAnnotationStyle annotationStyle)
    {
        var usesConverter = converterUsage != BenchmarkConverterUsage.Default;
        return annotationStyle switch
        {
            BenchmarkAnnotationStyle.Minimal => usesConverter ? typeof(BenchmarkItemMinimalWithConverter) : typeof(BenchmarkItemMinimal),
            BenchmarkAnnotationStyle.Standard => usesConverter ? typeof(BenchmarkItemStandardWithConverter) : typeof(BenchmarkItemStandard),
            BenchmarkAnnotationStyle.Advanced => usesConverter ? typeof(BenchmarkItemAdvancedWithConverter) : typeof(BenchmarkItemAdvanced),
            _ => usesConverter ? typeof(BenchmarkItemPolymorphicFlattenWithConverter) : typeof(BenchmarkItemPolymorphicFlatten)
        };
    }

    protected void ConfigureContextDelegates(BenchmarkConverterUsage converterUsage, BenchmarkAnnotationStyle annotationStyle)
    {
        var itemType = GetItemType(converterUsage,annotationStyle );
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

    protected abstract void ConfigureContextDelegates<T>();
}
