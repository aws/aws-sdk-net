using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers;

namespace SmithyDotNet.Generator.Generation.Endpoints;

/// <summary>
/// A <c>clientContextParams</c> entry resolved to the property the client config exposes. A boolean is
/// a non-nullable <c>bool</c> here, unlike the endpoint parameters class where it is <c>bool?</c>.
/// </summary>
public record ClientContextParameter(string Name, string NativeType, string? Documentation);

/// <summary>One endpoint parameter assignment, e.g. <c>ApiType</c> from <c>"ControlPlane"</c>.</summary>
public record EndpointAssignment(string Parameter, string Expression);

/// <summary>
/// The endpoint parameter assignments one operation contributes. <see cref="RequestAssignments"/> read
/// the request object, so their presence is what makes the resolver emit the request cast.
/// </summary>
public record OperationEndpointContext(
    string OperationName,
    IReadOnlyList<EndpointAssignment> StaticAssignments,
    IReadOnlyList<EndpointAssignment> RequestAssignments);

/// <summary>
/// Resolves the four endpoint context-parameter traits into the assignments the endpoint resolver and
/// config writers emit.
/// </summary>
public static class EndpointContextResolver
{
    /// <summary>The service's <c>clientContextParams</c> as config properties, in model order.</summary>
    public static List<ClientContextParameter> ResolveClientParameters(ServiceIndex index, CustomizationsModel customizations)
    {
        var resolved = new List<ClientContextParameter>();
        var declared = index.Service.GetClientContextParams();
        var skipped = customizations.Service?.SkipClientContextParams ?? [];
        foreach (var name in skipped)
        {
            if (name is null || declared is null || !declared.ContainsKey(name))
            {
                throw new GeneratorException($"service.skipClientContextParams lists '{name}', which clientContextParams does not declare.");
            }
        }

        if (declared is null)
        {
            return resolved;
        }

        foreach (var (name, parameter) in declared)
        {
            if (skipped.Contains(name))
            {
                continue;
            }

            resolved.Add(new ClientContextParameter(name, NativeType(name, parameter.Type), parameter.Documentation));
        }

        return resolved;
    }

    /// <summary>
    /// Per-operation assignments, in operation order. Operations contributing nothing are omitted so the
    /// resolver emits no empty block for them.
    /// </summary>
    public static List<OperationEndpointContext> ResolveOperations(IReadOnlyList<Operation> operations, ServiceIndex index, CustomizationsModel customizations)
    {
        var resolved = new List<OperationEndpointContext>();

        foreach (var operation in operations)
        {
            var statics = new List<EndpointAssignment>();
            if (operation.Shape.GetStaticContextParams() is { } staticParams)
            {
                foreach (var (name, parameter) in staticParams)
                {
                    statics.Add(new EndpointAssignment(name, CodeWriter.NativeValue(parameter.Value)));
                }
            }

            var fromRequest = new List<EndpointAssignment>();
            if (operation.Shape.GetOperationContextParams() is { } pathParams)
            {
                foreach (var (name, parameter) in pathParams)
                {
                    var accessor = JmesPathCompiler.Compile(parameter.Path, operation.Input, index, customizations, $"Operation '{operation.Name}' endpoint parameter '{name}'");
                    fromRequest.Add(new EndpointAssignment(name, $"request.{accessor}"));
                }
            }

            foreach (var (memberName, member) in operation.Input.Members)
            {
                if (member.GetContextParam() is { } contextParam)
                {
                    fromRequest.Add(new EndpointAssignment(contextParam.Name, $"request.{customizations.PropertyName(operation.Input.Id.Name, memberName)}"));
                }
            }

            if (statics.Count > 0 || fromRequest.Count > 0)
            {
                resolved.Add(new OperationEndpointContext(operation.Name, statics, fromRequest));
            }
        }

        return resolved;
    }

    // The spec allows only string or boolean here, narrower than a rule-set parameter, which may also be
    // stringArray. A boolean stays non-nullable to match C2J and the hand-written S3 config
    // (AmazonS3Config.ForcePathStyle is a plain bool); the unset distinction lives on the parameters class.
    private static string NativeType(string name, string smithyType) => smithyType.ToLowerInvariant() switch
    {
        "string" => "string",
        "boolean" => "bool",
        _ => throw new GeneratorException($"Client context parameter '{name}' has type '{smithyType}'; only 'string' and 'boolean' are allowed."),
    };
}
