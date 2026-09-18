using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Service;

/// <summary>
/// Emits the C# source for operation request and response classes.
/// </summary>
public sealed class OperationWriter(GenerationContext context, string modelFileName)
{
    /// <summary>
    /// Emits the service-level request base class (e.g. <c>AmazonCloudTrailDataRequest</c>),
    /// which all operation request classes extend.
    /// </summary>
    public string WriteServiceRequest(CancellationToken cancellationToken = default)
    {
        var className = $"Amazon{context.BaseName}Request";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, ["Amazon.Runtime"]);
        writer.OpenNamespace(context.Namespace, () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Base class for {context.BaseName} operation requests.");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {className} : AmazonWebServiceRequest", () => { });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    /// <summary>
    /// Emits the request class for an operation.
    /// </summary>
    public string WriteRequest(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Request";
        var baseClass = $"Amazon{context.BaseName}Request";

        // Cleanup the operation doc on its own first so its leading <p> wrapper is stripped,
        // then prepend the request preface so it reads as a single paragraph.
        var cleanedOperationDoc = DocumentationFormatter.Cleanup(operation.Shape.GetDocumentation());
        var doc = $"Container for the parameters to the {operation.Name} operation. {cleanedOperationDoc}";

        var members = ApplyEventStreamPublisher(operation, TypeMapper.ResolveMembers(operation.Input, context));
        var record = new OperationRecord(className, baseClass, doc, members, TypeMapper.BuildObsolete(operation.Input));
        return WriteClass(record, cancellationToken);
    }

    // A request event-stream member (target is a @streaming union) is emitted as a Func publisher property
    // named {Member}Publisher — matching C2J, which replaces the normal member. The list is re-sorted
    // because the rename can change alphabetical order relative to the other members.
    private List<Member> ApplyEventStreamPublisher(Operation operation, List<Member> members)
    {
        var stream = context.RequestEventStreams.FirstOrDefault(candidate => candidate.Operations.Any(op => op.Name == operation.Name));
        if (stream is null)
        {
            return members;
        }

        // The property keeps the input member's name (+ "Publisher"); the interface and event list are the union's.
        var memberName = operation.Input.Members.First(member => member.Value.Target == stream.Id).Key;
        var memberProperty = SdkNaming.ToUpperFirstCharacter(memberName);
        var eventClasses = stream.Events.Select(context.ToDotNetName).ToList();
        var publisher = new EventStreamPublisherInfo(stream.InterfaceName, eventClasses);
        return members
            // Clear HidesBaseMember: the "Publisher" suffix means a member named "equals" no longer
            // shadows object.Equals, so it must not keep the `new` modifier (CS0109).
            .Select(member => member.PropertyName == memberProperty && member.Type.IsEventStream
                ? member with { PropertyName = $"{memberProperty}Publisher", EventStreamPublisher = publisher, HidesBaseMember = false }
                : member)
            .OrderBy(member => member.PropertyName, StringComparer.Ordinal)
            .ToList();
    }

    /// <summary>
    /// Emits the response class for an operation.
    /// </summary>
    public string WriteResponse(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Response";
        var members = TypeMapper.ResolveMembers(operation.Output, context);

        // A response member named ContentLength is omitted rather than shadowed with `new`:
        // AmazonWebServiceResponse already declares it, and the unmarshaller assigns the inherited property.
        members.RemoveAll(m => m.PropertyName == "ContentLength");

        // A @streaming output member (raw blob stream or event stream) hands back a stream the caller
        // must dispose. The trait lives on the target shape, so detect it via the resolved member type.
        var streamingMembers = members.Where(m => m.Type.IsStreaming || m.Type.IsEventStream).ToList();

        // The response of an operation that sends an event stream owns the request handle Core gives it
        // (C2J: `Operation.IsEventStreamInput`); an output-only stream doesn't.
        var hasRequestEventStream = context.RequestEventStreams.Any(stream => stream.Operations.Contains(operation));
        var baseClass = "AmazonWebServiceResponse";

        if (hasRequestEventStream)
        {
            baseClass = baseClass + ", Amazon.Runtime.EventStreams.IEventInputStreamContextOwner";
        }

        if (streamingMembers.Count > 0 || hasRequestEventStream)
        {
            baseClass = baseClass + ", IDisposable";
        }

        var doc = $"This is the response object from the {operation.Name} operation.";
        var record = new OperationRecord(className, baseClass, doc, members, TypeMapper.BuildObsolete(operation.Output), streamingMembers, hasRequestEventStream);
        return WriteClass(record, cancellationToken);
    }

    /// <summary>
    /// Describes an operation request or response class to emit: its name, base type, documentation,
    /// members, and any <c>@streaming</c> members whose streams the class must dispose.
    /// </summary>
    private sealed record OperationRecord(
        string ClassName,
        string BaseClass,
        string Doc,
        List<Member> Members,
        string? Obsolete = null,
        List<Member>? StreamingMembers = null,
        bool HasRequestEventStream = false);

    private string WriteClass(OperationRecord opRecord, CancellationToken cancellationToken)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        FileHeader.WritePragma(writer, FileHeader.ModelWarnings);
        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            writer.WriteLine("/// <summary>");
            DocumentationFormatter.WriteCommentBlock(writer, DocumentationFormatter.Cleanup(opRecord.Doc));
            writer.WriteLine("/// </summary>");
            if (opRecord.Obsolete is string obsolete)
            {
                writer.WriteLine(obsolete);
            }
            writer.OpenBlock($"public partial class {opRecord.ClassName} : {opRecord.BaseClass}", () =>
            {
                MemberWriter.WriteMembers(writer, opRecord.Members);
                if (opRecord.HasRequestEventStream)
                {
                    WriteEventInputStreamContextOwner(writer);
                }

                // Unlike C2J, also emitted for an input-only stream (it would otherwise declare IDisposable without implementing it).
                var streamingMembers = opRecord.StreamingMembers ?? [];
                if (streamingMembers.Count > 0 || opRecord.HasRequestEventStream)
                {
                    WriteDisposePattern(writer, streamingMembers, opRecord.HasRequestEventStream);
                }
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    // Explicit interface implementation, so CA1033 (make it accessible to derived types) is suppressed like C2J does.
    private static void WriteEventInputStreamContextOwner(CodeWriter writer)
    {
        writer.WriteLine();
        writer.WriteLine("#pragma warning disable CA1033");
        writer.WriteLine("Amazon.Runtime.EventStreams.EventInputStreamContext _eventInputStreamContext;");
        writer.OpenBlock("void Amazon.Runtime.EventStreams.IEventInputStreamContextOwner.SetEventInputStreamContext(Amazon.Runtime.EventStreams.EventInputStreamContext eventInputStreamContext)", () =>
        {
            writer.WriteLine("this._eventInputStreamContext = eventInputStreamContext;");
        });
        writer.WriteLine("#pragma warning restore CA1033");
    }

    /// <summary>
    /// Emits the standard <see cref="IDisposable"/> region that releases each streaming member's stream
    /// (and the event input stream context first, when the response owns one).
    /// </summary>
    private static void WriteDisposePattern(CodeWriter writer, List<Member> streamingMembers, bool hasRequestEventStream)
    {
        writer.WriteLine();
        writer.WriteLine("#region Dispose Pattern");
        writer.WriteLine();
        writer.WriteLine("private bool _disposed;");
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Disposes of all managed and unmanaged resources.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public void Dispose()", () =>
        {
            writer.WriteLine("Dispose(true);");
            writer.WriteLine("GC.SuppressFinalize(this);");
        });
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Disposes of all managed and unmanaged resources.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("protected virtual void Dispose(bool disposing)", () =>
        {
            writer.OpenBlock("if (_disposed)", () => writer.WriteLine("return;"));
            writer.WriteLine();
            writer.OpenBlock("if (disposing)", () =>
            {
                if (hasRequestEventStream)
                {
                    writer.WriteLine("this._eventInputStreamContext?.Dispose();");
                    writer.WriteLine("this._eventInputStreamContext = null;");
                }
                foreach (var member in streamingMembers)
                {
                    writer.WriteLine($"this.{member.PropertyName}?.Dispose();");
                    writer.WriteLine($"this.{member.PropertyName} = null;");
                }
            });
            writer.WriteLine();
            writer.WriteLine("this._disposed = true;");
        });
        writer.WriteLine();
        writer.WriteLine("#endregion");
    }
}
