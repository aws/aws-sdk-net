namespace SmithyDotNet.Generator.Model;

/// <summary>
/// Identifies a shape in a Smithy model. Format: <c>namespace#name</c> or <c>namespace#name$member</c>.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/model.html#shape-id" /></remarks>
public record ShapeId(string Namespace, string Name, string? Member = null)
{
    /// <summary>
    /// Returns <c>namespace#name</c> without the member component.
    /// Used as the key in the top-level shapes dictionary.
    /// </summary>
    public string AbsoluteName => $"{Namespace}#{Name}";

    /// <summary>
    /// Whether this shape belongs to the Smithy prelude (<c>smithy.api</c> namespace).
    /// Prelude shapes like <c>smithy.api#String</c> are implicit and not present in the model JSON.
    /// </summary>
    public bool IsPrelude => Namespace == "smithy.api";

    /// <summary>
    /// Parses an absolute shape ID string. Expects exactly one <c>#</c> separator.
    /// </summary>
    public static ShapeId Parse(string absoluteShapeId)
    {
        var parts = absoluteShapeId.Split('#');
        if (parts.Length != 2)
        {
            throw new ArgumentException($"Invalid ShapeId '{absoluteShapeId}': expected exactly one '#' separator.");
        }

        var @namespace = parts[0];
        if (@namespace.Length == 0)
        {
            throw new ArgumentException($"Invalid ShapeId '{absoluteShapeId}': namespace is empty.");
        }

        var nameAndMember = parts[1].Split('$', 2);
        if (nameAndMember[0].Length == 0)
        {
            throw new ArgumentException($"Invalid ShapeId '{absoluteShapeId}': shape name is empty.");
        }

        if (nameAndMember.Length == 2 && (nameAndMember[1].Length == 0 || nameAndMember[1].Contains('$')))
        {
            throw new ArgumentException($"Invalid ShapeId '{absoluteShapeId}': member name is empty or contains invalid characters.");
        }

        return nameAndMember.Length == 2
            ? new ShapeId(@namespace, nameAndMember[0], nameAndMember[1])
            : new ShapeId(@namespace, nameAndMember[0]);
    }

    public static implicit operator string(ShapeId id) => id.ToString();

    public override string ToString() => Member is null ? AbsoluteName : $"{AbsoluteName}${Member}";
}
