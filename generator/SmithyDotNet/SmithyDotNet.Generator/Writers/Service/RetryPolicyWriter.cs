using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Service;

/// <summary>
/// Emits <c>Amazon{BaseName}RetryPolicy</c>: a partial class listing request types to retry when a
/// 200 response carries an error. Only S3 uses this today (C2J <c>AmazonS3RetryPolicy.tt</c>).
/// <para />
/// An operation is excluded only when its output has a <c>@streaming</c> blob, whose body is handed to
/// the caller as a stream. C2J's template also reads as excluding event streams and string payloads, but
/// neither guard fires against its own model — <c>Member.IsEventStream</c> reads the member node while
/// the trait sits on the target shape, and <c>PayloadMember.OwningShape.IsString</c> asks whether the
/// containing structure is a string. So S3 ships with <c>SelectObjectContent</c> and
/// <c>GetBucketPolicy</c> in the list, and dropping them here would stop retrying them.
/// </summary>
public sealed class RetryPolicyWriter(GenerationContext context, string modelFileName)
{
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, [.. FileHeader.RetryPolicyUsings, $"{context.Namespace}.Model"]);
        writer.OpenNamespace($"{context.Namespace}.Internal", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// This generated class exists solely to populate the list of request types that should be retried when a 200 status code with an error is encountered. The list");
            writer.WriteLine("/// is model driven, and should not be modified.");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {context.ClientName}RetryPolicy : DefaultRetryPolicy", () =>
            {
                writer.OpenBlock("internal static readonly ICollection<Type> RequestsWith200Error = new HashSet<Type>", "};", () =>
                {
                    foreach (var operation in context.Operations.Where(Includes))
                    {
                        writer.WriteLine($"typeof({operation.Name}Request),");
                    }
                });
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private bool Includes(Operation operation) =>
        !operation.Output.Members.Values.Any(member => context.Resolve(member.Target) is BlobShape target && target.IsStreaming());
}
