using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Generation.Operations;

/// <summary>
/// An error shape paired with its <see cref="ShapeId"/>. A <see cref="StructureShape"/> does
/// not carry its own ID, but writers need the error's name (e.g. to derive the
/// <c>{Name}Exception</c> class referenced in an operation's <c>&lt;exception&gt;</c> doc tags),
/// so the ID is resolved up front alongside the shape.
/// </summary>
public record OperationError(StructureShape Shape, ShapeId Id);

/// <summary>
/// An operation with its input, output, and error shapes pre-resolved so writers
/// don't need to perform lookups themselves. <see cref="RequiresHttp2"/> pins the request to
/// <c>HttpProtocolVersion.Version20</c> and excludes the operation below net8; input-only event
/// streams follow C2J and are never pinned unless the whole service is h2-required.
/// </summary>
public record Operation(
    string Name,
    OperationShape Shape,
    StructureShape Input,
    StructureShape Output,
    IReadOnlyList<OperationError> Errors,
    bool RequiresHttp2);

/// <summary>
/// Resolves the service's operations into <see cref="Operation"/> records with their input, output,
/// and error shapes looked up once, so writers never touch the shape index for them.
/// </summary>
public static class OperationResolver
{
    public static List<Operation> Resolve(ServiceIndex index, AWSProtocol protocol)
    {
        var protocolTrait = protocol switch
        {
            AWSProtocol.RestJson1 => index.Service.GetRestJson1(),
            AWSProtocol.AwsJson1_0 => index.Service.GetAwsJson1_0(),
            AWSProtocol.AwsJson1_1 => index.Service.GetAwsJson1_1(),
            _ => throw new GeneratorException($"Unsupported protocol '{protocol}'."),
        };

        var h2Support = ResolveH2Support(protocolTrait);
        var resolved = new List<Operation>(index.Operations.Count);

        foreach (var (operationId, operation) in index.Operations)
        {
            var input = ResolveStructure(index, operation.Input, "input", operationId);
            var output = ResolveStructure(index, operation.Output, "output", operationId);

            // A service's errors apply to every operation it contains, so they're folded into each
            // operation's own list here. Deduped and sorted by name.
            var errorIds = operation.Errors
                .Concat(index.Service.Errors)
                .Distinct()
                .OrderBy(id => id.Name, StringComparer.Ordinal)
                .ThenBy(id => id.Namespace, StringComparer.Ordinal)
                .ThenBy(id => id.Member, StringComparer.Ordinal);

            var errors = new List<OperationError>();
            foreach (var errorId in errorIds)
            {
                errors.Add(new OperationError(ResolveStructure(index, errorId, "error", operationId), errorId));
            }

            var requiresHttp2 = h2Support switch
            {
                H2SupportDegree.Required => true,
                H2SupportDegree.EventStream => Model.EventStreams.In(output, index).Any(),
                H2SupportDegree.Optional => Model.EventStreams.In(input, index).Any() && Model.EventStreams.In(output, index).Any(),
                _ => false,
            };

            resolved.Add(new Operation(operationId.Name, operation, input, output, errors, requiresHttp2));
        }

        return resolved;
    }

    // How strongly a service requires HTTP/2, derived from the protocol trait's http/eventStreamHttp lists.
    private enum H2SupportDegree { None, Optional, EventStream, Required }

    // Derives the degree the way the C2J models' "protocolSettings":{"h2":...} value is derived from these
    // lists: no h2 → None; h2 the only http version → Required; h2 alongside http/1.1 → Optional when event
    // streams can fall back to http/1.1, EventStream when they can't. eventStreamHttp defaults to http
    // when absent (per spec); an explicitly empty list is treated the same way, as the legacy C2J
    // conversion does.
    private static H2SupportDegree ResolveH2Support(ProtocolTrait? trait)
    {
        var http = trait?.Http ?? [];
        var eventStreamHttp = trait?.EventStreamHttp is { Count: > 0 } list ? list : http;

        if (!http.Contains("h2"))
        {
            return H2SupportDegree.None;
        }
        if (!http.Contains("http/1.1"))
        {
            return H2SupportDegree.Required;
        }
        return eventStreamHttp.Contains("http/1.1") ? H2SupportDegree.Optional : H2SupportDegree.EventStream;
    }

    private static StructureShape ResolveStructure(ServiceIndex index, ShapeId shapeId, string property, ShapeId operationId)
    {
        if (index.Shapes.TryGetValue(shapeId, out var shape) && shape is StructureShape structure)
        {
            return structure;
        }

        // smithy.api#Unit marks an operation with no input or output; treat it as an empty
        // structure so downstream writers emit the same empty request/response classes C2J does.
        if (shapeId == ShapeId.Unit)
        {
            return new StructureShape();
        }

        throw new GeneratorException($"Could not resolve {property} shape '{shapeId}' for operation '{operationId}'.");
    }
}
