using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Shapes;

/// <summary>
/// Emits <c>Generated/ServiceEnumerations.g.cs</c>: one <c>ConstantClass</c> per Smithy <c>enum</c>
/// shape, matching the public API the C2J generator produces. A service with no enum shapes still
/// emits the file (namespace only), matching the shipping SDK's generated file set.
/// </summary>
public sealed class ServiceEnumerationsWriter(GenerationContext context, string modelFileName)
{
    /// <summary>
    /// A resolved enum member: the munged C# member name and the raw wire value C2J stores verbatim
    /// as the <c>ConstantClass</c> constructor argument.
    /// </summary>
    private readonly record struct EnumMember(string PropertyName, string WireValue);

    /// <summary>
    /// Emits the complete formatted enumerations source for the service.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.ServiceEnumerationsUsings);
        writer.OpenNamespace(context.Namespace, () =>
        {
            for (var i = 0; i < context.Enums.Count; i++)
            {
                if (i > 0)
                {
                    writer.WriteLine();
                }

                WriteEnum(writer, context.Enums[i].Id, context.Enums[i].Shape);
            }
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteEnum(CodeWriter writer, ShapeId id, EnumShape shape)
    {
        var className = TypeMapper.EnumTypeName(id, context);
        var members = ResolveMembers(shape);

        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Constants used for properties of type {className}.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public class {className} : ConstantClass", () =>
        {
            for (var i = 0; i < members.Count; i++)
            {
                if (i > 0)
                {
                    writer.WriteLine();
                }

                var member = members[i];

                // A member named Equals is emitted with `new` so the readonly field doesn't hide
                // object.Equals.
                var newModifier = member.PropertyName == "Equals" ? "new " : string.Empty;
                writer.WriteLine("/// <summary>");
                writer.WriteLine($"/// Constant {member.PropertyName} for {className}");
                writer.WriteLine("/// </summary>");
                writer.WriteLine($"public {newModifier}static readonly {className} {member.PropertyName} = new {className}({CodeWriter.Literal(member.WireValue)});");
            }

            writer.WriteLine();
            WriteConstructor(writer, className);
            writer.WriteLine();
            WriteFindValue(writer, className);
            writer.WriteLine();
            WriteImplicitOperator(writer, className);
        });
    }

    // The wire value is the smithy.api#enumValue trait, which C2J stores verbatim as the ConstantClass
    // constructor argument; the member name is that value munged (SdkNaming.ToEnumMemberName). A missing
    // value throws rather than defaulting to the Smithy member name: C2J has no such value to carry, so
    // a reverted service would silently change its API.
    // TODO: enum property customizations (C2J's GetPropertyModifier(...).EmitName in SimpleModels.cs,
    // e.g. s3's BZIP2 -> Bzip2) are not applied yet; the wire value is emitted verbatim.
    // TODO: revisit the throw once more services are migrated - past a maturity bar new values could be
    // generated from Smithy directly (muhammad-othman's "freeze" suggestion).
    private static List<EnumMember> ResolveMembers(EnumShape shape)
    {
        var members = new List<EnumMember>(shape.Members.Count);
        foreach (var (memberName, member) in shape.Members)
        {
            var wireValue = member.GetEnumValue()
                ?? throw new GeneratorException($"Enum member '{memberName}' has no smithy.api#enumValue trait; C2J has no value to fall back to.");
            members.Add(new EnumMember(SdkNaming.ToEnumMemberName(wireValue), wireValue));
        }

        // Ordered by member name for stable output; the API does not depend on declaration order.
        return members.OrderBy(m => m.PropertyName, StringComparer.Ordinal).ToList();
    }

    private static void WriteConstructor(CodeWriter writer, string className)
    {
        // The doc comment is required: the generated service compiles with GenerateDocumentationFile +
        // TreatWarningsAsErrors, so an undocumented public member is a CS1591 build error.
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Constructs a custom {className} for a value not among the defined constants.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public {className}(string value) : base(value) {{ }}");
    }

    private static void WriteFindValue(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Finds the constant for the unique value.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("""/// <param name="value">The unique value for the constant</param>""");
        writer.WriteLine("/// <returns>The constant for the unique value</returns>");
        writer.OpenBlock($"public static {className} FindValue(string value)", () =>
        {
            writer.WriteLine($"return FindValue<{className}>(value);");
        });
    }

    private static void WriteImplicitOperator(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Utility method to convert strings to the constant class.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("""/// <param name="value">The string value to convert to the constant class.</param>""");
        writer.WriteLine("/// <returns></returns>");
        writer.OpenBlock($"public static implicit operator {className}(string value)", () =>
        {
            writer.WriteLine("return FindValue(value);");
        });
    }
}
