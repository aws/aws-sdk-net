using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using System.Collections.Generic;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for a JSON request marshaller matching the public API surface
/// of the existing AWS SDK for .NET.
/// <para />
/// Phase 1 scope: restJson1 operations whose body members are lists of structures or strings,
/// and whose query-string members are strings. Other member types throw a
/// <see cref="GeneratorException"/>.
/// </summary>
public sealed class JsonRequestMarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Request";
        var httpTrait = operation.Shape.GetHttp() ?? throw new GeneratorException($"Operation '{operation.Name}' is missing the @http trait.");
        var members = TypeMapper.ResolveMembers(operation.Input, context);

        var partitioned = PartitionMembers(operation.Input, members);

        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            WriteMarshallerDocumentation(writer, operation.Name);
            writer.OpenBlock($"public partial class {className}Marshaller : IMarshaller<IRequest, {className}>, IMarshaller<IRequest, AmazonWebServiceRequest>", () =>
            {
                WriteBaseMarshallMethod(writer, className);
                writer.WriteLine("");
                WriteTypedMarshallMethod(writer, className, httpTrait, partitioned);
                writer.WriteLine("");
                WriteSingleton(writer, className);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteBaseMarshallMethod(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Marshall the request object to the HTTP request.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public IRequest Marshall(AmazonWebServiceRequest input)", () =>
        {
            writer.WriteLine($"return this.Marshall(({className})input);");
        });
    }

    private void WriteTypedMarshallMethod(
        CodeWriter writer,
        string className,
        HttpTrait httpTrait,
        PartitionedMembers partitioned)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Marshall the request object to the HTTP request.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public IRequest Marshall({className} publicRequest)", () =>
        {
            writer.WriteLine($"IRequest request = new DefaultRequest(publicRequest, \"{context.Namespace}\");");
            // TODO: Content-type must be smarter and it can be overridden in customizations or for non restJSON
            // it can be application/x-amz-json, and for string payloads it can be "text/plain". For now we just put 
            // "application/json" here since this is just a start.
            writer.WriteLine("request.Headers[\"Content-Type\"] = \"application/json\";");
            writer.WriteLine($"request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = \"{context.ApiVersion}\";");
            writer.WriteLine($"request.HttpMethod = \"{httpTrait.Method}\";");
            writer.WriteLine("");

            WriteQueryStringMembers(writer, partitioned.QueryMembers);
            WriteHeaderMembers(writer, partitioned.HeaderMembers);
            WriteResourcePath(writer, httpTrait, partitioned.LabelMembers);

            if (partitioned.BodyMembers.Count > 0)
            {
                WriteBodySerialization(writer, partitioned.BodyMembers);
            }

            writer.WriteLine("");

            if (partitioned.QueryMembers.Count > 0)
            {
                writer.WriteLine("request.UseQueryString = true;");
                writer.WriteLine("");
            }

            writer.WriteLine("return request;");
        });
    }

    //https://smithy.io/2.0/spec/http-bindings.html#httpquery-trait
    private void WriteQueryStringMembers(CodeWriter writer, List<(Member Member, string QueryName)> queryMembers)
    {
        foreach (var (member, queryName) in queryMembers)
        {
            if (member.DotNetType != "string")
            {
                throw new GeneratorException($"Only string query members are handled currently (member: {member.PropertyName}).");
            }

            if (member.IsRequired)
            {
                writer.OpenBlock($"if (string.IsNullOrEmpty(publicRequest.{member.PropertyName}))", () =>
                {
                    writer.WriteLine($"throw new Amazon{context.ServiceName}Exception(\"Request object does not have required field {member.PropertyName} set\");");
                });
                writer.WriteLine("");
            }

            writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"request.Parameters.Add(\"{queryName}\", StringUtils.FromString(publicRequest.{member.PropertyName}));");
            });
            writer.WriteLine("");
        }
    }

    // https://smithy.io/2.0/spec/http-bindings.html#httpheader-trait
    private void WriteHeaderMembers(CodeWriter writer, List<(Member Member, string HeaderName)> headerMembers)
    {
        foreach (var (member, headerName) in headerMembers)
        {
            if (member.DotNetType != "string")
            {
                throw new GeneratorException($"Only string header members are handled currently (member: {member.PropertyName}).");
            }
            writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"request.Headers[\"{headerName}\"] = publicRequest.{member.PropertyName};");
            });
            writer.WriteLine("");
        }
    }

    // https://smithy.io/2.0/spec/http-bindings.html#httplabel-trait
    private void WriteResourcePath(CodeWriter writer, HttpTrait httpTrait, List<Member> labelMembers)
    {
        foreach (var member in labelMembers)
        {
            if (member.DotNetType != "string")
            {
                throw new GeneratorException($"Only string label members are handled currently (member: {member.PropertyName}).");
            }
            writer.OpenBlock($"if (!publicRequest.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"throw new Amazon{context.ServiceName}Exception(\"Request object does not have required field {member.PropertyName} set\");");
            });
            writer.WriteLine($"request.AddPathResource(\"{{{member.ModeledName}}}\", StringUtils.FromString(publicRequest.{member.PropertyName}));");
            writer.WriteLine("");
        }
        writer.WriteLine($"request.ResourcePath = \"{httpTrait.Uri}\";");
    }

    private void WriteBodySerialization(CodeWriter writer, List<Member> bodyMembers)
    {
        writer.WriteLine("#if !NETFRAMEWORK");
        writer.WriteLine("request.ContentStream = new PooledContentStream();");
        writer.WriteLine("using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);");
        writer.WriteLine("#else");
        writer.WriteLine("using var memoryStream = new MemoryStream();");
        writer.WriteLine("using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);");
        writer.WriteLine("#endif");
        writer.WriteLine("writer.WriteStartObject();");
        writer.WriteLine("var context = new JsonMarshallerContext(request, writer);");

        foreach (var member in bodyMembers)
        {
            WriteBodyMember(writer, member);
        }

        writer.WriteLine("");
        writer.WriteLine("writer.WriteEndObject();");
        writer.WriteLine("writer.Flush();");
        writer.WriteLine("#if NETFRAMEWORK");
        writer.WriteLine("request.Content = memoryStream.ToArray();");
        writer.WriteLine("#endif");
    }

    private void WriteBodyMember(CodeWriter writer, Member member)
    {
        
        if (member.DotNetType == "string")
        {
            writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"context.Writer.WritePropertyName(\"{member.JsonName ?? member.ModeledName}\");");
                writer.WriteLine($"context.Writer.WriteStringValue(publicRequest.{member.PropertyName});");
            });
        }
        else if (member.DotNetType.StartsWith("List<", StringComparison.Ordinal))
        {
            if (string.IsNullOrEmpty(member.ElementType))
            {
                throw new GeneratorException("A List's element type must be populated.");
            }
            writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"context.Writer.WritePropertyName(\"{member.JsonName ?? member.ModeledName}\");");
                writer.WriteLine("context.Writer.WriteStartArray();");
                writer.OpenBlock($"foreach (var publicRequest{member.PropertyName}ListValue in publicRequest.{member.PropertyName})", () =>
                {
                    WriteListElement(writer, member);
                });
                writer.WriteLine("context.Writer.WriteEndArray();");
            });
        }
        else
        {
            throw new GeneratorException($"Only string and List<T> body members are handled currently (member: {member.PropertyName}, type: {member.DotNetType}).");
        }
    }

    private void WriteListElement(CodeWriter writer, Member member)
    {
        
        if (member.ElementType == "string")
        {
            writer.WriteLine($"context.Writer.WriteStringValue(publicRequest{member.PropertyName}ListValue);");
        }
        // a structure
        else if (member.IsElementStructure)
        {
            writer.WriteLine("context.Writer.WriteStartObject();");
            writer.WriteLine("");
            writer.WriteLine($"var marshaller = {member.ElementType}Marshaller.Instance;");
            writer.WriteLine($"marshaller.Marshall(publicRequest{member.PropertyName}ListValue, context);");
            writer.WriteLine("");
            writer.WriteLine("context.Writer.WriteEndObject();");
        }
        else
        {
            throw new GeneratorException("Only strings and structure list element types are handled right now!");
        }
    }

    private static PartitionedMembers PartitionMembers(StructureShape input, List<Member> members)
    {
        var queryMembers = new List<(Member Member, string QueryName)>();
        var headerMembers = new List<(Member Member, string HeaderName)>();
        var labelMembers = new List<Member>();
        var bodyMembers = new List<Member>();

        foreach (var member in members)
        {
            var memberShape = input.Members[member.ModeledName];
            var httpQuery = memberShape.GetHttpQuery();
            var httpHeader = memberShape.GetHttpHeader();

            if (httpQuery is not null)
            {
                queryMembers.Add((member, httpQuery));
            }
            else if (httpHeader is not null)
            {
                headerMembers.Add((member, httpHeader));
            }
            else if (memberShape.IsHttpLabel())
            {
                labelMembers.Add(member);
            }
            else if (memberShape.IsHttpPayload())
            {
                throw new GeneratorException($"@httpPayload members are not handled currently (member: {member.PropertyName}).");
            }
            else
            {
                bodyMembers.Add(member);
            }
        }

        return new PartitionedMembers(queryMembers, headerMembers, labelMembers, bodyMembers);
    }

    private record PartitionedMembers(
        List<(Member Member, string QueryName)> QueryMembers,
        List<(Member Member, string HeaderName)> HeaderMembers,
        List<Member> LabelMembers,
        List<Member> BodyMembers);

    private static void WriteMarshallerDocumentation(CodeWriter writer, string operationName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// {operationName} Request Marshaller");
        writer.WriteLine("/// </summary>");
    }

    private static void WriteSingleton(CodeWriter writer, string className)
    {
        writer.WriteLine($"private static readonly {className}Marshaller _instance = new();");
        writer.WriteLine("");
        writer.WriteLine($"internal static {className}Marshaller GetInstance() => _instance;");
        writer.WriteLine("");
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the singleton.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public static {className}Marshaller Instance => _instance;");
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.JsonRequestMarshallerUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        writer.WriteLine("#if !NETFRAMEWORK");
        writer.WriteLine("using ThirdParty.RuntimeBackports;");
        writer.WriteLine("#endif");
    }
}
