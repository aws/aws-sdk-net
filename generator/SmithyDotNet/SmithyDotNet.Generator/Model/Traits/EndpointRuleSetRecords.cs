using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Model.Traits;

// Typed records for the smithy.rules#endpointRuleSet trait. The rule set is a small tree of
// parameters and rules; the endpoint writers walk it to emit the parameters class and the
// imperative endpoint provider. Function arguments and endpoint URLs are heterogeneous (a literal,
// a {"ref": ...}, or a nested {"fn": ...}), so they stay as raw JsonElement and are interpreted by
// the compiler rather than modeled as a type hierarchy.
//
// Constructs not yet handled fail loud at generation rather than silently emitting a wrong resolver:
// deprecated parameters throw in EndpointParametersWriter, unhandled rule functions/types throw in
// EndpointRulesCompiler, and unsupported JMESPath grammar throws in JmesPathCompiler. Model each here
// when a service needs it.
//
/// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/specification.html#smithy-rules-endpointruleset-trait" /></remarks>
public record EndpointRuleSet : TraitRecord
{
    [JsonPropertyName("version")]
    public string? Version { get; init; }

    [JsonPropertyName("parameters")]
    public IReadOnlyDictionary<string, EndpointParameter> Parameters { get; init; } = new Dictionary<string, EndpointParameter>();

    [JsonPropertyName("rules")]
    public required IReadOnlyList<EndpointRule> Rules { get; init; }
}

/// <summary>A rule-set parameter (e.g. Region, UseFIPS). <see cref="BuiltIn"/> names the config
/// source; <see cref="Default"/> supplies the parameters-class constructor default when present.</summary>
public record EndpointParameter
{
    /// <summary>The Smithy parameter type: <c>string</c>, <c>boolean</c>, or <c>stringArray</c>.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("required")]
    public bool Required { get; init; }

    [JsonPropertyName("builtIn")]
    public string? BuiltIn { get; init; }

    [JsonPropertyName("documentation")]
    public string? Documentation { get; init; }

    [JsonPropertyName("default")]
    public JsonElement? Default { get; init; }

    // Present drives an [Obsolete] attribute on the emitted property; not modeled yet, so the
    // parameters writer fails loud rather than silently dropping the deprecation.
    [JsonPropertyName("deprecated")]
    public JsonElement? Deprecated { get; init; }
}

/// <summary>
/// An individual endpoint rule. <see cref="Type"/> is <c>tree</c> (nested <see cref="Rules"/>),
/// <c>endpoint</c> (returns <see cref="Endpoint"/>), or <c>error</c> (throws <see cref="Error"/>).
/// A rule fires only when all its <see cref="Conditions"/> hold. 
/// <para />
/// The spec models these as three distinct rule types; they are merged here, so type-specific fields (<see cref="Rules"/> on tree,
/// <see cref="Endpoint"/>, <see cref="Error"/>) cannot be required.
/// </summary>
public record EndpointRule
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("conditions")]
    public required IReadOnlyList<EndpointCondition> Conditions { get; init; }

    // Required by the spec on tree rules only; endpoint/error rules omit it, so it can't be required
    // on the merged record.
    [JsonPropertyName("rules")]
    public IReadOnlyList<EndpointRule> Rules { get; init; } = [];

    [JsonPropertyName("endpoint")]
    public EndpointDefinition? Endpoint { get; init; }

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}

/// <summary>A function call used as a rule condition or as a nested function argument.
/// <see cref="Assign"/>, when set, binds the result into <c>refs</c> for later rules.</summary>
public record EndpointCondition
{
    [JsonPropertyName("fn")]
    public required string Fn { get; init; }

    [JsonPropertyName("argv")]
    public required IReadOnlyList<JsonElement> Argv { get; init; }

    [JsonPropertyName("assign")]
    public string? Assign { get; init; }
}

/// <summary>The endpoint an <c>endpoint</c> rule resolves to. <see cref="Url"/> is a template
/// string, a <c>{"ref": ...}</c>, or a <c>{"fn": ...}</c>.</summary>
public record EndpointDefinition
{
    [JsonPropertyName("url")]
    public required JsonElement Url { get; init; }

    [JsonPropertyName("properties")]
    public JsonElement? Properties { get; init; }

    [JsonPropertyName("headers")]
    public JsonElement? Headers { get; init; }
}

// The four context-parameter traits: how a rule-set parameter without a builtIn gets its value, from
// the client config, a per-operation constant, a request member, or a JMESPath over the request.

/// <summary>
/// One <c>smithy.rules#clientContextParams</c> entry (service-level): adds a settable property to
/// the generated client config, which then feeds the same-named rule-set parameter.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/parameters.html#smithy-rules-clientcontextparams-trait" /></remarks>
public record ClientContextParam
{
    /// <summary>
    /// The parameter type. The spec allows only <c>string</c> or <c>boolean</c> here — narrower than
    /// <see cref="EndpointParameter.Type"/>, which may also be <c>stringArray</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("documentation")]
    public string? Documentation { get; init; }
}

/// <summary>
/// One <c>smithy.rules#staticContextParams</c> entry (operation-level): a constant value for a
/// rule-set parameter whenever that operation is invoked.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/parameters.html#smithy-rules-staticcontextparams-trait" /></remarks>
public record StaticContextParam
{
    [JsonPropertyName("value")]
    public required JsonElement Value { get; init; }
}

/// <summary>
/// One <c>smithy.rules#operationContextParams</c> entry (operation-level): a JMESPath expression
/// evaluated against the operation input. <c>JmesPathCompiler</c> turns it into C#.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/parameters.html#smithy-rules-operationcontextparams-trait" /></remarks>
public record OperationContextParam
{
    [JsonPropertyName("path")]
    public required string Path { get; init; }
}

/// <summary>
/// The <c>smithy.rules#contextParam</c> trait on a request member: names the rule-set parameter the
/// member's value feeds.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/parameters.html#smithy-rules-contextparam-trait" /></remarks>
public record ContextParamTrait : TraitRecord
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
