using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// An operation's modeled auth schemes (from its <c>smithy.api#auth</c> override), paired with its
/// name, for the resolver's per-operation switch arms. <see cref="Schemes"/> is in declared order.
/// </summary>
public record OperationAuth(string Name, IReadOnlyList<string> Schemes);

/// <summary>
/// Resolves the modeled authentication schemes for a service and its operations: an explicit
/// <c>smithy.api#auth</c> list wins; otherwise the service's auth traits supply the default
/// (<c>sigv4</c>, then <c>sigv4a</c>, then <c>httpBearerAuth</c> in that precedence), falling back to
/// <c>noAuth</c> when the service models no auth at all.
/// </summary>
public static class ModeledAuth
{
    /// <summary>
    /// The service-level auth scheme list: the service's explicit <c>smithy.api#auth</c> trait when
    /// present, otherwise derived from its auth traits, otherwise <c>[noAuth]</c>.
    /// </summary>
    public static IReadOnlyList<string> ServiceSchemes(ServiceShape service)
    {
        if (service.GetAuthSchemes() is { } modeled)
        {
            return NormalizeEmptyToNoAuth(modeled);
        }

        var schemes = new List<string>(2);
        if (service.GetSigV4() is not null)
        {
            schemes.Add(AuthSchemeIds.SigV4);
        }

        if (service.HasSigV4A())
        {
            schemes.Add(AuthSchemeIds.SigV4A);
        }

        if (service.HasHttpBearerAuth())
        {
            schemes.Add(AuthSchemeIds.Bearer);
        }

        return schemes.Count > 0 ? schemes : [AuthSchemeIds.NoAuth];
    }

    /// <summary>
    /// The operations that model their own auth (a <c>smithy.api#auth</c> override), each paired with
    /// its scheme list, ordered by operation name so the resolver's switch is deterministic. An
    /// operation that models no override falls through to the service default (no arm).
    /// </summary>
    public static IReadOnlyList<OperationAuth> OperationOverrides(IEnumerable<Operation> operations)
    {
        var result = new List<OperationAuth>();
        foreach (var op in operations)
        {
            if (op.Shape.GetAuthSchemes() is { } schemes)
            {
                result.Add(new OperationAuth(op.Name, NormalizeEmptyToNoAuth(schemes)));
            }
        }

        return result.OrderBy(o => o.Name, StringComparer.Ordinal).ToList();
    }

    // An explicitly modeled empty auth list (smithy.api#auth: []) means "no auth", but an empty
    // resolved list makes BaseAuthResolverHandler throw at runtime; normalize it to [noAuth] (which
    // maps to DEFAULT_NOAUTH) so the empty modeled form yields a valid single-scheme default.
    private static IReadOnlyList<string> NormalizeEmptyToNoAuth(IReadOnlyList<string> schemes) =>
        schemes.Count == 0 ? [AuthSchemeIds.NoAuth] : schemes;
}
