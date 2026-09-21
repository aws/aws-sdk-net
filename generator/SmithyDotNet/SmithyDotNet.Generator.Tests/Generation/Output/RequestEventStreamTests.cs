using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Writers.EventStreams;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Output;

/// <summary>
/// Guards the request event stream marker interface (<c>I{Union}Event</c>) and its per-event
/// partials. The model shares one <c>@streaming</c> union between two request operations and an
/// output, as the restJson protocol test client does, and has a second union that is output-only
/// (the response event stream case).
/// </summary>
public class RequestEventStreamTests : IDisposable
{
    private const string ModelFileName = "request-event-stream-model.json";
    private readonly GenerationContext _context;
    private readonly string _outputDir;
    private readonly string _codeAnalysisDir;
    private readonly IReadOnlyList<string> _written;

    public RequestEventStreamTests()
    {
        _context = TestModels.Context("Codegen/EventStreams/request-event-stream-model.json");
        var defaultConfigurationModes = DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json");

        _outputDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
        _codeAnalysisDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");

        var generator = new ServiceGenerator(_context, ModelFileName, "4.0.0.0", defaultConfigurationModes);
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

    private string ReadModel(string fileName) => File.ReadAllText(Path.Combine(_outputDir, "Generated", "Model", fileName));

    [Fact]
    public void SharedUnion_ResolvesOnceWithEverySenderAndNoErrorEvents()
    {
        var stream = Assert.Single(_context.RequestEventStreams);

        Assert.Equal("IChatStreamEvent", stream.InterfaceName);
        Assert.Equal(["Talk", "TalkWithInitialRequest"], stream.Operations.Select(o => o.Name));
        Assert.Equal(["AudioEvent", "ExplicitPayloadEvent", "ImplicitPayloadEvent", "TextEvent"], stream.Events.Select(e => e.Name));
    }

    [Fact]
    public void EmitsInterfaceAndOnePartialPerPublishableEvent()
    {
        var files = _written.Select(Path.GetFileName).ToList();

        Assert.Contains("IChatStreamEvent.g.cs", files);
        Assert.Contains("AudioEvent.IChatStreamEvent.g.cs", files);
        Assert.Contains("TextEvent.IChatStreamEvent.g.cs", files);
        Assert.Contains("ImplicitPayloadEvent.IChatStreamEvent.g.cs", files);
        Assert.Contains("ExplicitPayloadEvent.IChatStreamEvent.g.cs", files);
        Assert.DoesNotContain("ChatError.IChatStreamEvent.g.cs", files);

        // ConverseStreamOutput is only ever received, so nothing publishes it.
        Assert.DoesNotContain("IConverseStreamOutputEvent.g.cs", files);
    }

    [Fact]
    public void ErrorEvent_GetsOnlyTheExceptionUnmarshaller()
    {
        var files = _written.Select(Path.GetFileName).ToList();

        // Reachable through the union, but an @error shape is an exception, so it must not also be
        // walked as a structure (which emitted a bogus marshaller/unmarshaller pair, and for a shape
        // already named *Exception collided with the exception unmarshaller's path).
        Assert.Contains("ChatErrorExceptionUnmarshaller.g.cs", files);
        Assert.DoesNotContain("ChatErrorUnmarshaller.g.cs", files);
        Assert.DoesNotContain("ChatErrorMarshaller.g.cs", files);
        Assert.Contains("ValidationExceptionUnmarshaller.g.cs", files);
    }

    [Fact]
    public void ResponseUnion_IsTheOutputStreamClass()
    {
        var files = _written.Select(Path.GetFileName).ToList();

        // Output-only, and shared with the request side: both are read via new {Union}(context.Stream).
        Assert.Contains("EnumerableEventOutputStream<", ReadModel("ConverseStreamOutput.g.cs"));
        Assert.Contains("EnumerableEventOutputStream<", ReadModel("ChatStream.g.cs"));
        Assert.Contains("ExampleEventStreamException.g.cs", files);

        // The union itself needs no structure unmarshaller.
        Assert.DoesNotContain("ConverseStreamOutputUnmarshaller.g.cs", files);
    }

    [Fact]
    public void Interface_IsEmptyAndListsSendersAndEvents()
    {
        var source = ReadModel("IChatStreamEvent.g.cs");

        Assert.Contains("namespace Amazon.Example.Model", source);
        Assert.Contains("#pragma warning disable CA1040", source);
        Assert.Contains("public interface IChatStreamEvent", source);
        Assert.Contains("#pragma warning restore CA1040", source);
        Assert.Contains("using the Talk and TalkWithInitialRequest service operations.", source);
        Assert.Contains("""<see cref="AudioEvent"/>""", source);
        Assert.Contains("""<see cref="TextEvent"/>""", source);
    }

    [Fact]
    public void Interface_SingleSenderKeepsC2JWording()
    {
        var stream = _context.RequestEventStreams[0];
        var source = new EventStreamEventInterfaceWriter(_context, ModelFileName)
            .WriteInterface(stream with { Operations = [stream.Operations[0]] }, TestContext.Current.CancellationToken);

        Assert.Contains("using the Talk service operation.", source);
    }

    [Fact]
    public void EventPartial_ImplementsInterface()
    {
        Assert.Contains("public partial class TextEvent : IChatStreamEvent", ReadModel("TextEvent.IChatStreamEvent.g.cs"));
    }
}
