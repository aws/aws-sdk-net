using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Generation.EndpointDiscovery;

/// <summary>
/// Resolves the operation the client calls to discover endpoints (<c>aws.api#clientEndpointDiscovery</c>) and the
/// operations that use them (<c>aws.api#clientDiscoveredEndpoint</c>).
/// </summary>
public static class EndpointDiscoveryResolver
{
    public static Operation? ResolveDiscoveryOperation(IReadOnlyList<Operation> operations, ServiceIndex index)
    {
        if (index.Service.GetClientEndpointDiscovery() is not { } discovery)
        {
            return null;
        }

        var operation = operations.SingleOrDefault(o => o.Shape.Id == discovery.Operation)
            ?? throw new GeneratorException($"aws.api#clientEndpointDiscovery names operation '{discovery.Operation}', which the service does not have.");

        // TODO: pass the caller's Operation and Identifiers when the discovery input models them, as C2J does; no service does yet.
        if (operation.Input.Members.Count > 0)
        {
            throw new GeneratorException($"Endpoint discovery operation '{operation.Name}' has input members, which are not supported yet.");
        }

        // Core evicts a cached endpoint only on HTTP 421, whatever error the model names.
        if (discovery.Error is { } errorId && index.Shapes.GetValueOrDefault(errorId)?.GetHttpError() != 421)
        {
            throw new GeneratorException($"aws.api#clientEndpointDiscovery error '{errorId}' is not an HTTP 421 error, the only status Core evicts discovered endpoints on.");
        }

        return operation;
    }

    public static Dictionary<ShapeId, bool> ResolveDiscoveredOperations(IReadOnlyList<Operation> operations, Operation? discoveryOperation)
    {
        var discovered = new Dictionary<ShapeId, bool>();
        foreach (var operation in operations)
        {
            if (operation.Shape.GetClientDiscoveredEndpoint() is not { } endpoint)
            {
                continue;
            }

            // C2J would still emit the operation's marshaller; skipping it would drop a public class.
            if (discoveryOperation is null)
            {
                throw new GeneratorException($"'{operation.Name}' has aws.api#clientDiscoveredEndpoint, but the service has no aws.api#clientEndpointDiscovery.");
            }

            if (operation.Shape.Id != discoveryOperation.Shape.Id)
            {
                discovered[operation.Shape.Id] = endpoint.Required;
            }
        }

        return discovered;
    }
}
