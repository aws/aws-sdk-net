namespace SmithyDotNet.Generator.Model;

/// <summary>Uninterpreted binary data.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#blob" /></remarks>
public record BlobShape : Shape { public override string Type => "blob"; }

/// <summary>Boolean value.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#boolean" /></remarks>
public record BooleanShape : Shape { public override string Type => "boolean"; }

/// <summary>UTF-8 string value.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#string" /></remarks>
public record StringShape : Shape { public override string Type => "string"; }

/// <summary>8-bit signed integer.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#byte" /></remarks>
public record ByteShape : Shape { public override string Type => "byte"; }

/// <summary>16-bit signed integer.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#short" /></remarks>
public record ShortShape : Shape { public override string Type => "short"; }

/// <summary>32-bit signed integer.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#integer" /></remarks>
public record IntegerShape : Shape { public override string Type => "integer"; }

/// <summary>64-bit signed integer.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#long" /></remarks>
public record LongShape : Shape { public override string Type => "long"; }

/// <summary>Single-precision IEEE 754 floating point.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#float" /></remarks>
public record FloatShape : Shape { public override string Type => "float"; }

/// <summary>Double-precision IEEE 754 floating point.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#double" /></remarks>
public record DoubleShape : Shape { public override string Type => "double"; }

/// <summary>Arbitrary-precision integer.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#biginteger" /></remarks>
public record BigIntegerShape : Shape { public override string Type => "bigInteger"; }

/// <summary>Arbitrary-precision decimal.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#bigdecimal" /></remarks>
public record BigDecimalShape : Shape { public override string Type => "bigDecimal"; }

/// <summary>An instant in time.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#timestamp" /></remarks>
public record TimestampShape : Shape { public override string Type => "timestamp"; }

/// <summary>Protocol-agnostic open content.</summary>
/// <remarks><see href="https://smithy.io/2.0/spec/simple-types.html#document" /></remarks>
public record DocumentShape : Shape { public override string Type => "document"; }
