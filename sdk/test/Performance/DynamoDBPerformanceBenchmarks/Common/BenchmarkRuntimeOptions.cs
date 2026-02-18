namespace AWSSDK.Benchmarks.MockedDynamoDB;

public sealed class BenchmarkParameterOverrides
{
    public BenchmarkItemSize? ItemSize { get; set; }
    public BenchmarkAttributeCount? AttributeCount { get; set; }
    public BenchmarkExpressionStyle? ExpressionStyle { get; set; }
    public BenchmarkObjectComplexity? ObjectComplexity { get; set; }
    public BenchmarkConverterUsage? ConverterUsage { get; set; }
    public BenchmarkAnnotationStyle? AnnotationStyle { get; set; }
}
