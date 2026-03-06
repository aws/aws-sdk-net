namespace AWSSDK.Benchmarks.MockedDynamoDB;

public abstract class BenchmarkPolymorphicDetails
{
    public string? BaseDetail { get; set; }
}

public sealed class BenchmarkPolymorphicAlpha : BenchmarkPolymorphicDetails
{
    public string? AlphaDetail { get; set; }
}

public sealed class BenchmarkPolymorphicBeta : BenchmarkPolymorphicDetails
{
    public string? BetaDetail { get; set; }
}
