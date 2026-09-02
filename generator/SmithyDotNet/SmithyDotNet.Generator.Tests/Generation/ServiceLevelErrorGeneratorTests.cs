using SmithyDotNet.Generator.Generation;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

/// <summary>
/// Guards that an error declared only on the service shape — never in an operation's <c>errors</c>
/// list — still gets an exception unmarshaller and an error branch in every operation's
/// <c>UnmarshallException</c>. Without that the exception class compiles against a missing
/// unmarshaller type, and the error deserializes to the generic service exception at runtime.
/// </summary>
public class ServiceLevelErrorGeneratorTests : IDisposable
{
    private const string ModelFileName = "example-2023-01-01.normal.json";
    private static readonly string Marshalling = Path.Combine("Generated", "Model", "Internal", "MarshallTransformations");

    private readonly string _outputDir;
    private readonly string _codeAnalysisDir;
    private readonly IReadOnlyList<string> _written;

    public ServiceLevelErrorGeneratorTests()
    {
        var context = TestModels.Context("Codegen/service-errors-model.json");
        var defaultConfigurationModes = DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json");

        _outputDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
        _codeAnalysisDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");

        var generator = new ServiceGenerator(context, ModelFileName, "4.0.0.0", defaultConfigurationModes);
        _written = generator.Generate(_outputDir, _codeAnalysisDir, testsOutputPath: null, TestContext.Current.CancellationToken);
    }

    public void Dispose()
    {
        foreach (var dir in new[] { _outputDir, _codeAnalysisDir })
        {
            if (Directory.Exists(dir))
            {
                Directory.Delete(dir, recursive: true);
            }
        }
    }

    [Fact]
    public void EmitsUnmarshallerForEveryError()
    {
        // AccessDenied and Throttling are service-level only; ResourceNotFound is operation-level
        // only; Validation is both.
        AssertWritten("AccessDeniedExceptionUnmarshaller.g.cs");
        AssertWritten("ThrottlingExceptionUnmarshaller.g.cs");
        AssertWritten("ResourceNotFoundExceptionUnmarshaller.g.cs");
        AssertWritten("ValidationExceptionUnmarshaller.g.cs");
    }

    [Fact]
    public void ResponseUnmarshallerDispatchesEveryError()
    {
        var source = File.ReadAllText(Path.Combine(_outputDir, Marshalling, "GetThingResponseUnmarshaller.g.cs"));

        foreach (var name in new[] { "AccessDenied", "ResourceNotFound", "Throttling", "Validation" })
        {
            Assert.Contains($"""errorResponse.Code.Equals("{name}Exception")""", source);
        }
    }

    private void AssertWritten(string fileName)
    {
        var relativePath = Path.Combine(Marshalling, fileName);
        Assert.True(File.Exists(Path.Combine(_outputDir, relativePath)), $"Expected file: {relativePath}");
        Assert.Contains(relativePath, _written);
    }
}
