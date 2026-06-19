namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the public property + internal <c>IsSet{Property}()</c> for each
/// <see cref="Member"/>. Shared by all writers that produce model classes.
/// </summary>
public static class MemberWriter
{
    private const string CollectionDocParagraph =
        "Starting with version 4 of the SDK this property will default to null. " +
        "If no data for this property is returned from the service the property will also be null. " +
        "This was changed to improve performance and allow the SDK and caller to distinguish between " +
        "a property not set or a property being empty to clear out a value. To retain the previous " +
        "SDK behavior set the AWSConfigs.InitializeCollections static property to true.";

    /// <summary>
    /// Writes each member with a blank line between them.
    /// </summary>
    public static void WriteMembers(CodeWriter writer, IReadOnlyList<Member> members)
    {
        for (var i = 0; i < members.Count; i++)
        {
            if (i > 0)
            {
                writer.WriteLine();
            }

            WriteMember(writer, members[i]);
        }
    }

    private static void WriteMember(CodeWriter writer, Member member)
    {
        writer.WriteLine("/// <summary>");
        var cleanedDoc = DocumentationFormatter.Cleanup($"Gets and sets the property {member.PropertyName}. {member.Documentation}");
        DocumentationFormatter.WriteCommentBlock(writer, cleanedDoc);

        if (member.IsCollection)
        {
            writer.WriteLine("/// <para />");
            DocumentationFormatter.WriteCommentBlock(writer, DocumentationFormatter.Cleanup(CollectionDocParagraph));
        }

        writer.WriteLine("/// </summary>");

        if (member.AwsProperty is string awsProperty)
        {
            writer.WriteLine(awsProperty);
        }

        if (member.IsCollection)
        {
            writer.WriteLine($"public {member.DotNetType} {member.PropertyName} {{ get; set; }} = AWSConfigs.InitializeCollections ? new {member.DotNetType}() : null;");
        }
        else
        {
            writer.WriteLine($"public {member.DotNetType} {member.PropertyName} {{ get; set; }}");
        }

        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Checks to see if the {member.PropertyName} property is set.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"internal bool IsSet{member.PropertyName}() => {member.IsSetExpression};");
    }
}
