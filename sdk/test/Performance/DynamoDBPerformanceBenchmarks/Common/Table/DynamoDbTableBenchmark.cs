using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

[MemoryDiagnoser]
public abstract class DynamoDbTableBenchmark
{
    protected DynamoDbTableBenchmarkState State { get; set; } = null!;

    [ParamsSource(nameof(ItemSizeValues))]
    public BenchmarkItemSize ItemSize { get; set; }

    [ParamsSource(nameof(AttributeCountValues))]
    public BenchmarkAttributeCount AttributeCount { get; set; }

    [ParamsSource(nameof(ExpressionStyleValues))]
    public BenchmarkExpressionStyle ExpressionStyle { get; set; }

    [ParamsSource(nameof(ObjectComplexityValues))]
    public BenchmarkObjectComplexity ObjectComplexity { get; set; }

    public IEnumerable<BenchmarkItemSize> ItemSizeValues => BenchmarkParameterHelper.GetValues(
        BenchmarkTableRuntimeOptions.Current.ParameterOverrides?.ItemSize);

    public IEnumerable<BenchmarkAttributeCount> AttributeCountValues => BenchmarkParameterHelper.GetValues(
        BenchmarkTableRuntimeOptions.Current.ParameterOverrides?.AttributeCount);

    public IEnumerable<BenchmarkExpressionStyle> ExpressionStyleValues => BenchmarkParameterHelper.GetValues(
        BenchmarkTableRuntimeOptions.Current.ParameterOverrides?.ExpressionStyle);

    public IEnumerable<BenchmarkObjectComplexity> ObjectComplexityValues => BenchmarkParameterHelper.GetValues(
        BenchmarkTableRuntimeOptions.Current.ParameterOverrides?.ObjectComplexity);

    protected void ApplyParameterOverrides()
    {
        var overrides = BenchmarkTableRuntimeOptions.Current.ParameterOverrides;
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
    }
}
