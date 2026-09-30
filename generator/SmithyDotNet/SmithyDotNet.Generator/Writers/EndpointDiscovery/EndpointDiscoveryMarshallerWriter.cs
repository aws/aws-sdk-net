using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Writers.Serialization;

namespace SmithyDotNet.Generator.Writers.EndpointDiscovery;

/// <summary>
/// Emits <c>{Operation}EndpointDiscoveryMarshaller</c>, which tells Core whether the operation must use a
/// discovered endpoint. C2J reference: <c>EndpointDiscoveryMarshaller.tt</c>.
/// </summary>
public sealed class EndpointDiscoveryMarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(Operation operation, bool required, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}EndpointDiscoveryMarshaller";
        var requestType = $"{operation.Name}Request";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Endpoint discovery parameters for {operation.Name} operation");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {className} : IMarshaller<EndpointDiscoveryDataBase, {requestType}>, IMarshaller<EndpointDiscoveryDataBase, AmazonWebServiceRequest>", () =>
            {
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// Marshall the request object to its endpoint discovery data.");
                writer.WriteLine("/// </summary>");
                writer.OpenBlock("public EndpointDiscoveryDataBase Marshall(AmazonWebServiceRequest input)", () =>
                {
                    writer.WriteLine($"return this.Marshall(({requestType})input);");
                });
                writer.WriteLine();

                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// Marshall the request object to its endpoint discovery data.");
                writer.WriteLine("/// </summary>");
                writer.OpenBlock($"public EndpointDiscoveryDataBase Marshall({requestType} publicRequest)", () =>
                {
                    writer.WriteLine($"return new EndpointDiscoveryData({(required ? "true" : "false")});");
                });
                writer.WriteLine();

                MarshallerCommon.WriteUnmarshallerSingleton(writer, className);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }
}
