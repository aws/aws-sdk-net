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

        // The doc's second paragraph: the Func explanation for a publisher, the V4 null-default note for
        // a collection. Each is its own <para> sibling of the prefix above, so multi-paragraph member
        // docs don't nest.
        if (member.EventStreamPublisher is { } publisher)
        {
            WritePublisherDocBody(writer, publisher);
        }
        else if (member.Type.IsCollection)
        {
            writer.WriteLine("/// <para />");
            DocumentationFormatter.WriteCommentBlock(writer, DocumentationFormatter.Cleanup(CollectionDocParagraph));
        }

        writer.WriteLine("/// </summary>");

        if (member.Obsolete is string obsolete)
        {
            writer.WriteLine(obsolete);
        }

        if (member.AwsProperty is string awsProperty)
        {
            writer.WriteLine(awsProperty);
        }

        // `new` when the member shadows a base-class member (e.g., Equals or Retryable); empty otherwise.
        var modifier = member.HidesBaseMember ? "new " : string.Empty;

        // A request event-stream member is a consumer-supplied Func the marshaller wires unconditionally,
        // so it has no IsSet method.
        if (member.EventStreamPublisher is { } eventStreamPublisher)
        {
            writer.WriteLine($"public {modifier}Func<System.Threading.Tasks.Task<{eventStreamPublisher.InterfaceName}>> {member.PropertyName} {{ get; set; }}");
            return;
        }

        if (member.Type.IsCollection)
        {
            writer.WriteLine($"public {modifier}{member.Type.DotNetType} {member.PropertyName} {{ get; set; }} = AWSConfigs.InitializeCollections ? new {member.Type.DotNetType}() : null;");
        }
        else
        {
            writer.WriteLine($"public {modifier}{member.Type.DotNetType} {member.PropertyName} {{ get; set; }}");
        }

        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Checks to see if the {member.PropertyName} property is set.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"internal bool IsSet{member.PropertyName}() => {member.IsSetExpression};");
    }

    // The doc text matches C2J's GenerateEventPublisherDocumentation so it ships identically in the .xml.
    private static void WritePublisherDocBody(CodeWriter writer, EventStreamPublisherInfo publisher)
    {
        writer.WriteLine("/// <para>");
        writer.WriteLine("/// The Func set for this property by the consumer of the SDK is used to stream events into the service. Consumers");
        writer.WriteLine("/// provide a Func that the SDK will continue to call to get events to send. When the consumer is done streaming");
        writer.WriteLine("/// events to the service the Func can return null to stop the SDK calling the Func for new events. The Func must");
        writer.WriteLine($"/// return an event known by the service which can be identified by implementing the {publisher.InterfaceName}");
        writer.WriteLine("/// interface. The known implementatons in the SDK for this interface are:");
        writer.WriteLine("""/// <list type="bullet">""");
        foreach (var eventClass in publisher.EventClasses)
        {
            writer.WriteLine($"""///   <item><term><see cref="{eventClass}"/></term></item>""");
        }
        writer.WriteLine("/// </list>");
        writer.WriteLine("/// </para>");
    }
}
