using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model;

namespace SmithyDotNet.Generator.Generation.EventStreams;

/// <summary>
/// A <c>@streaming</c> union sent to the service as an operation input, resolved once however many
/// operations share it. <see cref="Events"/> excludes <c>@error</c> members: a client never sends
/// an error event. Both lists are ordered by name. <see cref="InterfaceName"/> is the shipped
/// marker-interface name, derived from the union's generated name, not the operation (Lex V2:
/// <c>IStartConversationRequestEventStreamEvent</c>). A union named <c>EventStream</c> (the
/// protocol test client) yields <c>IEventStreamEvent</c>, the runtime's own marker, so event
/// stream writers refer to the runtime's through a <c>using RuntimeEvent = ...</c> alias.
/// </summary>
public record RequestEventStream(ShapeId Id, string InterfaceName, IReadOnlyList<Operation> Operations, IReadOnlyList<ShapeId> Events);

/// <summary>
/// A <c>@streaming</c> union received from the service as an operation output. <see cref="Events"/>
/// excludes <c>@error</c> members: those become exceptions. Ordered by name.
/// </summary>
public record ResponseEventStream(ShapeId Id, IReadOnlyList<ShapeId> Events);

/// <summary>
/// Resolves the <c>@streaming</c> unions an operation sends (<see cref="RequestEventStream"/>) or
/// receives (<see cref="ResponseEventStream"/>), one record per union however many operations share it.
/// </summary>
public static class EventStreamResolver
{
    public static List<RequestEventStream> ResolveRequestStreams(IReadOnlyList<Operation> operations, ServiceIndex index)
    {
        var unionIds = operations
            .SelectMany(operation => Model.EventStreams.In(operation.Input, index))
            .Distinct();

        var resolved = new List<RequestEventStream>();
        foreach (var unionId in unionIds)
        {
            var senders = operations
                .Where(op => Model.EventStreams.In(op.Input, index).Contains(unionId))
                .OrderBy(op => op.Name, StringComparer.Ordinal)
                .ToList();
            var events = Model.EventStreams.EventsOf(unionId, index).OrderBy(target => target.Name, StringComparer.Ordinal).ToList();
            resolved.Add(new RequestEventStream(unionId, $"I{index.ToDotNetName(unionId)}Event", senders, events));
        }

        return resolved.OrderBy(stream => stream.Id.Name, StringComparer.Ordinal).ToList();
    }

    public static List<ResponseEventStream> ResolveResponseStreams(IReadOnlyList<Operation> operations, ServiceIndex index)
    {
        var unionIds = operations
            .SelectMany(operation => Model.EventStreams.In(operation.Output, index))
            .Distinct();

        var resolved = new List<ResponseEventStream>();
        foreach (var unionId in unionIds)
        {
            var events = Model.EventStreams.EventsOf(unionId, index).OrderBy(target => target.Name, StringComparer.Ordinal).ToList();
            resolved.Add(new ResponseEventStream(unionId, events));
        }

        return resolved.OrderBy(stream => stream.Id.Name, StringComparer.Ordinal).ToList();
    }
}
