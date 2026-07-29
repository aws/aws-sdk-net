using SmithyDotNet.Generator.Generation;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

public class DefaultConfigurationManifestTests
{
    private static readonly IReadOnlyList<ResolvedDefaultConfigurationMode> Modes =
        DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json");

    [Fact]
    public void LoadsAllModesInFileOrder_ExcludingLegacy()
    {
        // The runtime's DefaultConfigurationMode enum has no Legacy member, so the file's legacy
        // mode must not be loaded.
        Assert.Equal(["Standard", "InRegion", "CrossRegion", "Mobile", "Auto"], Modes.Select(m => m.Name));
    }

    [Fact]
    public void AppliesModeOverridesOnTopOfBaseValues()
    {
        // standard overrides connectTimeoutInMillis (base 1100 -> 3100); in-region has no
        // overrides and keeps the base value.
        Assert.Equal(3100, Modes.Single(m => m.Name == "Standard").ConnectTimeoutInMillis);
        Assert.Equal(1100, Modes.Single(m => m.Name == "InRegion").ConnectTimeoutInMillis);
        Assert.Equal(30000, Modes.Single(m => m.Name == "Mobile").TlsNegotiationTimeoutInMillis);
    }

    [Fact]
    public void OptionsWithoutAValueAreNull()
    {
        Assert.All(Modes, m => Assert.Null(m.TimeToFirstByteTimeoutInMillis));
        Assert.All(Modes, m => Assert.Null(m.HttpRequestTimeoutInMillis));
    }

    [Fact]
    public void EnumValuesArePascalCased()
    {
        // File values are lowercase ("standard", "regional"); the .NET enum members are PascalCase.
        Assert.All(Modes, m => Assert.Equal("Standard", m.RetryMode));
        Assert.All(Modes, m => Assert.Equal("Regional", m.S3UsEast1RegionalEndpoint));
    }

    [Fact]
    public void Load_ThrowsOnUnsupportedModifierOperation()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadInline(
            """
            {
              "base": { "retryMode": "standard", "s3UsEast1RegionalEndpoints": "regional" },
              "modes": { "standard": { "retryMode": { "multiply": 2 } } },
              "documentation": { "modes": { "standard": "doc" } }
            }
            """));
        Assert.Contains("multiply", ex.Message);
    }

    [Fact]
    public void Load_ThrowsOnMissingDocumentation()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadInline(
            """{ "base": {}, "modes": {} }"""));
        Assert.Contains("documentation.modes", ex.Message);
    }

    [Fact]
    public void Load_ThrowsOnMissingBaseValueForEnumOption()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadInline(
            """
            {
              "base": { "s3UsEast1RegionalEndpoints": "regional" },
              "modes": {},
              "documentation": { "modes": { "standard": "doc" } }
            }
            """));
        Assert.Contains("retryMode", ex.Message);
    }

    private static IReadOnlyList<ResolvedDefaultConfigurationMode> LoadInline(string json)
    {
        var path = Path.Combine(Path.GetTempPath(), $"default-config-test-{Guid.NewGuid():N}.json");
        File.WriteAllText(path, json);
        try
        {
            return DefaultConfigurationManifest.Load(path);
        }
        finally
        {
            File.Delete(path);
        }
    }
}
