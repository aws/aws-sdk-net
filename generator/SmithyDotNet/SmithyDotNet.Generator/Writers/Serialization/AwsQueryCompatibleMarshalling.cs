using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// The protocol-neutral parts of <c>aws.protocols#awsQueryCompatible</c>: the request announces query mode,
/// and error dispatch runs on the shape name captured before the runtime rewrites <c>errorResponse.Code</c>
/// and <c>Type</c> from the <c>x-amzn-query-error</c> header. Shared by the Json and Cbor writers.
/// </summary>
public static class AwsQueryCompatibleMarshalling
{
    internal static void WriteQueryModeHeader(CodeWriter writer, GenerationContext context)
    {
        if (context.IsAwsQueryCompatible)
        {
            writer.WriteLine("""request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";""");
        }
    }

    /// <summary>The <c>maintainResponseBody</c> argument for the error context copy. C2J passes <c>true</c> for query-compatible
    /// services; the flag only caches the body for response logging, the query error header comes from the response data.</summary>
    internal static string MaintainResponseBody(GenerationContext context) => context.IsAwsQueryCompatible ? "true" : "false";

    /// <summary>Emits the code capture and header rewrite when needed, returning the expression the error dispatch compares.</summary>
    internal static string WriteErrorCodeSource(CodeWriter writer, GenerationContext context)
    {
        if (!context.IsAwsQueryCompatible)
        {
            return "errorResponse.Code";
        }

        writer.WriteLine("var errorTypeName = errorResponse.Code;");
        writer.WriteLine("Amazon.Runtime.Internal.Transform.AwsQueryCompatibleErrorHandler.ApplyQueryErrorHeader(errorResponse, context.ResponseData);");
        return "errorTypeName";
    }
}
