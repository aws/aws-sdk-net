using SmithyDotNet.Generator.Generation.Manifests;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Manifests;

public class UnitTestProjectManifestTests
{
    [Theory]
    [InlineData("""{ "unittestprojects": [] }""", "must list exactly one 'unittestprojects' entry")]
    [InlineData("""{ "unittestprojects": [{}, {}] }""", "must list exactly one 'unittestprojects' entry")]
    [InlineData("""{ "unittestprojects": [{ "outputPathOverride": "bin" }] }""", "'outputPathOverride' could not be mapped")]
    [InlineData("""{ "unittestprojects": [{ "packageReferences": [{ "include": "Moq" }] }] }""", "missing required properties")]
    [InlineData("""{ "unittestprojects": [{ "packageReferences": [{ "include": "Moq", "version": "1.0", "privateAssets": "All" }] }] }""", "'privateAssets' could not be mapped")]
    public void Load_Invalid_Throws(string json, string expectedInMessage)
    {
        var directory = Directory.CreateTempSubdirectory("unittestprojects-");
        try
        {
            var path = Path.Combine(directory.FullName, "_manifest.json");
            File.WriteAllText(path, json);

            var ex = Assert.Throws<GeneratorException>(() => UnitTestProjectManifest.Load(path));
            Assert.Contains(expectedInMessage, ex.Message);
        }
        finally
        {
            directory.Delete(recursive: true);
        }
    }
}
