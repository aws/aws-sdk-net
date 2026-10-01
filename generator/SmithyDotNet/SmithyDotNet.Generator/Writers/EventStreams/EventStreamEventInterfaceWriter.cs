using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.EventStreams;
using SmithyDotNet.Generator.Model;

namespace SmithyDotNet.Generator.Writers.EventStreams;

/// <summary>
/// Emits the empty marker interface for a request event stream (<c>I{Union}Event</c>) and the
/// <c>{Event}.I{Union}Event.g.cs</c> partial that stamps it onto each publishable event class, so
/// the publisher can accept every event of one stream through a single type.
/// </summary>
public sealed class EventStreamEventInterfaceWriter(GenerationContext context, string modelFileName)
{
    public string WriteInterface(RequestEventStream eventStream, CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            // CA1040 (avoid empty interfaces): empty is the point here.
            writer.WriteLine("#pragma warning disable CA1040");
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Interface used to distinguish the events that can be sent to the service using the {DescribeSenders(eventStream)}.");
            writer.WriteLine("/// The types that implement this interface are:");
            writer.WriteLine("""/// <list type="bullet">""");
            foreach (var eventId in eventStream.Events)
            {
                writer.WriteLine($"""///   <item><term><see cref="{context.ToDotNetName(eventId)}"/></term></item>""");
            }
            writer.WriteLine("/// </list>");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public interface {eventStream.InterfaceName}", () => { });
            writer.WriteLine("#pragma warning restore CA1040");
        });

        return writer.ToFormattedString(cancellationToken);
    }

    public string WriteEventImplementation(RequestEventStream eventStream, ShapeId eventId, CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            writer.OpenBlock($"public partial class {context.ToDotNetName(eventId)} : {eventStream.InterfaceName}", () => { });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    // C2J's wording for the one-sender case; a union shared by several operations lists them all.
    private static string DescribeSenders(RequestEventStream eventStream)
    {
        var names = eventStream.Operations.Select(o => o.Name).ToList();
        return names.Count == 1
            ? $"{names[0]} service operation"
            : $"{string.Join(", ", names[..^1])} and {names[^1]} service operations";
    }
}
