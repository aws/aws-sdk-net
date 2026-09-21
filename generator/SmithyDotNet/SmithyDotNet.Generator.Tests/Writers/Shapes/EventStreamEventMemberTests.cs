using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Shapes;

public class EventStreamEventMemberTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";
    private const string Namespace = "com.example";

    private readonly GenerationContext _context;
    private readonly StructureWriter _writer;

    public EventStreamEventMemberTests()
    {
        _context = TestModels.Context("Codegen/EventStreams/event-stream-member-model.json");
        _writer = new StructureWriter(_context, ModelFileName);
    }

    private static ShapeId Id(string name) => ShapeId.Parse($"{Namespace}#{name}");

    private string Write(string shapeName) => _writer.Write(_context.Structures[Id(shapeName)], Id(shapeName), TestContext.Current.CancellationToken);

    [Fact]
    public void InputStreamEventMember_ImplementsIEventStreamEvent()
    {
        var source = Write("ChunkEvent");

        Assert.Contains("public partial class ChunkEvent : Amazon.Runtime.EventStreams.IEventStreamEvent", source);
    }

    [Fact]
    public void EventMember_ImplementsIEventStreamEvent()
    {
        var source = Write("DataEvent");

        // Fully qualified (no using) so it can't clash with a per-stream {Namespace}.Model.IEventStreamEvent.
        Assert.Contains("public partial class DataEvent : Amazon.Runtime.EventStreams.IEventStreamEvent", source);
        Assert.DoesNotContain("using Amazon.Runtime.EventStreams;", source);
    }

    [Fact]
    public void NonEventStructure_HasNoMarker()
    {
        var source = Write("PingDetail");

        Assert.DoesNotContain("IEventStreamEvent", source);
        Assert.DoesNotContain("using Amazon.Runtime.EventStreams;", source);
        Assert.Contains("public partial class PingDetail", source);
    }
}
