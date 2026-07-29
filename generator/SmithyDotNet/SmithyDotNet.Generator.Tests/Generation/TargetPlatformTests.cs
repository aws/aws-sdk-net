using SmithyDotNet.Generator.Generation;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

public class TargetPlatformTests
{
    [Theory]
    [InlineData("net472", ".NET Framework 4.7.2")]
    [InlineData("net45", ".NET Framework 4.5")]
    [InlineData("netstandard2.0", "NetStandard 2.0")]
    [InlineData("netcoreapp3.1", ".NET Core 3.1")]
    [InlineData("net8.0", ".NET 8.0")]
    [InlineData("net9.0", ".NET 9.0")]
    [InlineData("net10.0", ".NET 10.0")]
    public void FriendlyName_DerivesLabelFromTfm(string tfm, string expectedLabel)
    {
        Assert.Equal(expectedLabel, TargetPlatforms.FriendlyName(tfm));
    }
}
