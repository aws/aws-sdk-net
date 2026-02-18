using Amazon.DynamoDBv2;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[MemoryDiagnoser]
public abstract class DynamoDbContextBenchmark
{
    protected DynamoDbContextBenchmarkState State { get; set; } = null!;

    [ParamsSource(nameof(ItemSizeValues))]
    public BenchmarkItemSize ItemSize { get; set; }

    [ParamsSource(nameof(AttributeCountValues))]
    public BenchmarkAttributeCount AttributeCount { get; set; }

    [ParamsSource(nameof(ExpressionStyleValues))]
    public BenchmarkExpressionStyle ExpressionStyle { get; set; }

    [ParamsSource(nameof(ObjectComplexityValues))]
    public BenchmarkObjectComplexity ObjectComplexity { get; set; }

    [ParamsSource(nameof(ConverterUsageValues))]
    public BenchmarkConverterUsage ConverterUsage { get; set; }

    [ParamsSource(nameof(AnnotationStyleValues))]
    public BenchmarkAnnotationStyle AnnotationStyle { get; set; }

    public IEnumerable<BenchmarkItemSize> ItemSizeValues => BenchmarkParameterHelper.GetValues(
        BenchmarkContextRuntimeOptions.Current.ParameterOverrides?.ItemSize);

    public IEnumerable<BenchmarkAttributeCount> AttributeCountValues => BenchmarkParameterHelper.GetValues(
        BenchmarkContextRuntimeOptions.Current.ParameterOverrides?.AttributeCount);

    public IEnumerable<BenchmarkExpressionStyle> ExpressionStyleValues => BenchmarkParameterHelper.GetValues(
        BenchmarkContextRuntimeOptions.Current.ParameterOverrides?.ExpressionStyle);

    public IEnumerable<BenchmarkObjectComplexity> ObjectComplexityValues => BenchmarkParameterHelper.GetValues(
        BenchmarkContextRuntimeOptions.Current.ParameterOverrides?.ObjectComplexity);

    public IEnumerable<BenchmarkConverterUsage> ConverterUsageValues => BenchmarkParameterHelper.GetValues(
        BenchmarkContextRuntimeOptions.Current.ParameterOverrides?.ConverterUsage);

    public IEnumerable<BenchmarkAnnotationStyle> AnnotationStyleValues => BenchmarkParameterHelper.GetValues(
        BenchmarkContextRuntimeOptions.Current.ParameterOverrides?.AnnotationStyle);

    //[GlobalSetup]
    //public void Setup()
    //{
    //    BenchmarkContextRuntimeOptions.Configure(options =>
    //    {
    //        options.ClientFactory = _ => new AmazonDynamoDBClient();
    //    });

    //    ApplyParameterOverrides();

    //    State = new DynamoDbContextBenchmarkState(
    //        ItemSize,
    //        AttributeCount,
    //        ExpressionStyle,
    //        ObjectComplexity,
    //        ConverterUsage,
    //        AnnotationStyle);
    //    State.Setup();
    //}

    protected void ApplyParameterOverrides()
    {
        var overrides = BenchmarkContextRuntimeOptions.Current.ParameterOverrides;
        if (overrides == null)
        {
            return;
        }

        if (overrides.ItemSize.HasValue)
        {
            ItemSize = overrides.ItemSize.Value;
        }

        if (overrides.AttributeCount.HasValue)
        {
            AttributeCount = overrides.AttributeCount.Value;
        }

        if (overrides.ExpressionStyle.HasValue)
        {
            ExpressionStyle = overrides.ExpressionStyle.Value;
        }

        if (overrides.ObjectComplexity.HasValue)
        {
            ObjectComplexity = overrides.ObjectComplexity.Value;
        }

        if (overrides.ConverterUsage.HasValue)
        {
            ConverterUsage = overrides.ConverterUsage.Value;
        }

        if (overrides.AnnotationStyle.HasValue)
        {
            AnnotationStyle = overrides.AnnotationStyle.Value;
        }
    }
}
