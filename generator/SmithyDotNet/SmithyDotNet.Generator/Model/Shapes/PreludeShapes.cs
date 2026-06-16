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
