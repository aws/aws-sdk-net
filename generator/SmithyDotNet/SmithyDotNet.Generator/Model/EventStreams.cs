using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Model;

/// <summary>
/// Queries over <c>@streaming</c> unions, the event streams.
/// </summary>
public static class EventStreams
{
    /// <summary>Targets of the members that are event streams.</summary>
    public static IEnumerable<ShapeId> In(StructureShape structure, ServiceIndex index) => structure
        .Members
        .Values
        .Select(member => member.Target)
        // Prelude targets (String, Integer...) aren't in the index; null falls out of the pattern as "not a union".
        .Where(target => index.Shapes.GetValueOrDefault(target) is UnionShape union && union.IsStreaming());

    /// <summary>Every member target except <c>@error</c> ones, which are exceptions.</summary>
    public static IEnumerable<ShapeId> EventsOf(ShapeId eventStream, ServiceIndex index) => index.Shapes[eventStream] is UnionShape union
        ? union.Members.Values.Select(member => member.Target).Where(target => !index.Shapes[target].IsError())
        : throw new GeneratorException($"Shape '{eventStream}' is not an event stream.");
}
