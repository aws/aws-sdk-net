using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Manifests;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Output;

/// <summary>
/// Guards the gate that decides whether a service gets an event stream exception at all. The
/// emitted source itself is pinned in <c>EventStreamExceptionWriterTests</c>.
/// </summary>
public sealed class EventStreamExceptionGeneratorTests : IDisposable
{
    private const string ModelFileName = "example-2023-01-01.normal.json";
    private static readonly string ExceptionPath = Path.Combine("Generated", "Model", "ExampleEventStreamException.g.cs");

    private readonly List<string> _tempDirs = [];

    public void Dispose()
    {
        foreach (var dir in _tempDirs.Where(Directory.Exists))
        {
            Directory.Delete(dir, recursive: true);
        }
    }

    private IReadOnlyList<string> Generate(string model)
    {
        var outputDir = TempDir();
        var generator = new ServiceGenerator(
            TestModels.Context(model),
            ModelFileName,
            "4.0.0.0",
            DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json"));

        return generator.Generate(outputDir, TempDir(), testsOutputPath: null, TestContext.Current.CancellationToken);
    }

    private string TempDir()
    {
        var dir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
        _tempDirs.Add(dir);
        return dir;
    }

    [Fact]
    public void OutputEventStream_EmitsException()
    {
        Assert.Contains(ExceptionPath, Generate("Codegen/EventStreams/event-stream-model.json"));
    }

    [Fact]
    public void InputOnlyEventStream_EmitsNoException()
    {
        Assert.DoesNotContain(ExceptionPath, Generate("Codegen/EventStreams/event-stream-input-only-model.json"));
    }

    [Fact]
    public void EventStreamExceptionMembers_EmitOneExceptionAndUnmarshallerEach()
    {
        var written = Generate("Codegen/EventStreams/event-stream-model.json");

        Assert.Contains(Path.Combine("Generated", "Model", "AccessDeniedException.g.cs"), written);
        Assert.Contains(Path.Combine(Marshalling, "AccessDeniedExceptionUnmarshaller.g.cs"), written);
        Assert.Contains(Path.Combine(Marshalling, "ThrottlingExceptionUnmarshaller.g.cs"), written);
    }

    private static readonly string Marshalling = Path.Combine("Generated", "Model", "Internal", "MarshallTransformations");
}
