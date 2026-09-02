namespace SmithyDotNet.Generator.Model.Shapes;

/// <summary>
/// The Smithy prelude simple shapes (namespace <c>smithy.api</c>). 
/// <para />
/// These are implicit and never appear in a model's <c>shapes</c> map. 
/// Shape resolution falls back to this table, letting callers resolve a member's target 
/// without special-casing prelude references.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/model.html#prelude-shapes" /></remarks>
public static class PreludeShapes
{
    private static readonly Dictionary<string, Shape> ByName = new(StringComparer.Ordinal)
    {
        ["Blob"] = new BlobShape(),
        ["Boolean"] = new BooleanShape(),
        ["String"] = new StringShape(),
        ["Byte"] = new ByteShape(),
        ["Short"] = new ShortShape(),
        ["Integer"] = new IntegerShape(),
        ["Long"] = new LongShape(),
        ["Float"] = new FloatShape(),
        ["Double"] = new DoubleShape(),
        ["BigInteger"] = new BigIntegerShape(),
        ["BigDecimal"] = new BigDecimalShape(),
        ["Timestamp"] = new TimestampShape(),
        ["Document"] = new DocumentShape(),
        // Smithy 1.0 primitive shapes. Removed from the 2.0 prelude spec, but models converted
        // from 1.0 still reference them (bedrock-agent: PrimitiveLong; iotsitewise, omics:
        // PrimitiveBoolean). They map to the same .NET types as their plain counterparts —
        // the 1.0 "primitive" distinction was about default values, which don't affect our
        // nullability handling.
        ["PrimitiveBoolean"] = new BooleanShape(),
        ["PrimitiveByte"] = new ByteShape(),
        ["PrimitiveShort"] = new ShortShape(),
        ["PrimitiveInteger"] = new IntegerShape(),
        ["PrimitiveLong"] = new LongShape(),
        ["PrimitiveFloat"] = new FloatShape(),
        ["PrimitiveDouble"] = new DoubleShape(),
        // Unit is the prelude's "no meaningful value" structure. As an operation input/output it
        // is already special-cased in GenerationContext.ResolveStructure; resolving it here covers
        // union members targeting it (lambda-microvms, bedrock-agentcore, supportauthz,
        // workspaces-web), which flow through the plain structure codepath and emit the same
        // per-service empty Unit class C2J ships.
        ["Unit"] = new StructureShape(),
    };

    /// <summary>
    /// Returns the prelude shape for <paramref name="shapeId"/>, or <c>null</c> if it is not a
    /// known prelude simple shape.
    /// </summary>
    public static Shape? Resolve(ShapeId shapeId)
    {
        if (!shapeId.IsPrelude)
        {
            return null;
        }

        return ByName.TryGetValue(shapeId.Name, out var shape) ? shape : null;
    }
}
