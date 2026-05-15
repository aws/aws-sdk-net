namespace SmithyDotNet.Generator.Model.Traits;

// Typed records for Smithy trait values.

/// <remarks><see href="https://smithy.io/2.0/spec/type-refinement-traits.html#error-trait" /></remarks>
public record ErrorTrait(string Value);

/// <remarks><see href="https://smithy.io/2.0/spec/http-bindings.html#http-trait" /></remarks>
public record HttpTrait(string Method, string Uri, int Code);

/// <remarks><see href="https://smithy.io/2.0/spec/constraint-traits.html#length-trait" /></remarks>
public record LengthTrait(long? Min, long? Max);
