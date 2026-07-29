using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Model.Traits;

// Typed records for the smithy.rules#endpointTests trait. Each test case supplies parameters to
// feed the endpoint provider and either the expected resolved URL or the expected thrown error
// message. Only fields EndpointProviderTestSuiteWriter needs are modeled; see remarks below for what's
// omitted and why.
/// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/specification.html#testing-endpoint-rule-sets" /></remarks>
public record EndpointTestSuite : TraitRecord
{
    [JsonPropertyName("version")]
    public required string Version { get; init; }

    [JsonPropertyName("testCases")]
    public required IReadOnlyList<EndpointTestCase> TestCases { get; init; }
}

/// <summary>A single endpoint test case: parameters to feed the provider and the expected outcome.</summary>
/// <remarks>The trait also carries <c>tags</c> and <c>operationInputs</c> fields; the legacy
/// generator deserialized them too but never used them to emit output, so they're omitted here.</remarks>
public record EndpointTestCase
{
    [JsonPropertyName("documentation")]
    public string Documentation { get; init; } = "";

    /// <summary>Parameter values keyed by parameter name. Values are boolean, string, or string
    /// array in every case seen so far;
    /// <see cref="SmithyDotNet.Generator.Writers.Endpoints.EndpointProviderTestSuiteWriter"/> fails
    /// loud on anything else.</summary>
    [JsonPropertyName("params")]
    public IReadOnlyDictionary<string, JsonElement> Params { get; init; } = new Dictionary<string, JsonElement>();

    [JsonPropertyName("expect")]
    public required EndpointTestExpectation Expect { get; init; }
}

/// <summary>Either <see cref="Endpoint"/> or <see cref="Error"/> is set, never both.</summary>
public record EndpointTestExpectation
{
    [JsonPropertyName("endpoint")]
    public EndpointTestExpectedEndpoint? Endpoint { get; init; }

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}

/// <remarks>The trait also carries <c>properties</c> and <c>headers</c> fields; no pinned test file
/// anywhere in the SDK asserts on them (only <c>endpoint.URL</c>), so they're omitted here.</remarks>
public record EndpointTestExpectedEndpoint
{
    [JsonPropertyName("url")]
    public required string Url { get; init; }
}
