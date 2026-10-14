using System.Xml;
using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.Examples;

/// <summary>
/// Emits <c>{ServiceName}.GeneratedSamples.extra.xml</c> from <c>smithy.api#examples</c>, with the entries
/// C2J's <c>ExampleMetadata.tt</c> writes. Each <c>&lt;doc&gt;</c> links an operation's request/response to a
/// sample region (by the id shared with <see cref="DocSamplesWriter"/>) the API reference includes
/// from the generated .cs file.
/// </summary>
public sealed class DocSampleMetadataWriter(GenerationContext context)
{
    public string Write(IReadOnlyList<DocSample> samples)
    {
        var ns = context.Namespace;
        var source = $@".\AWSSDKDocSamples\{context.ServiceName}\{context.ServiceName}.GeneratedSamples.cs";

        var writer = new CodeWriter();
        writer.WriteLine("""<?xml version="1.0" encoding="utf-8"?>""");
        writer.OpenXmlBlock("docs", () =>
        {
            foreach (var (operation, example, regionId) in samples)
            {
                var op = operation.Name;
                writer.OpenXmlBlock("doc", () =>
                {
                    writer.OpenXmlBlock("members", () =>
                    {
                        writer.WriteLine($"""<member name="M:{ns}.I{context.ClientName}.{op}({ns}.Model.{op}Request)" />""");
                        writer.WriteLine($"""<member name="M:{ns}.{context.ClientName}Client.{op}({ns}.Model.{op}Request)" />""");
                        writer.WriteLine($"""<member name="T:{ns}.Model.{op}Request" />""");
                        writer.WriteLine($"""<member name="T:{ns}.Model.{op}Response" />""");
                    });
                    writer.OpenXmlBlock("value", () =>
                    {
                        writer.OpenXmlBlock("example", () =>
                        {
                            writer.OpenXmlBlock("para", () => writer.WriteLine(EscapeXml(example.Documentation ?? string.Empty)));
                            writer.WriteLine($"""<code title="{EscapeXml(example.Title).Replace("\"", "&quot;")}" source="{source}" region="{regionId}" />""");
                        });
                    });
                });
            }
        });

        return writer.ToRawString();
    }

    // Only what XML requires, keeping apostrophes as C2J wrote them so unchanged samples don't churn. XML 1.0
    // can't carry most control characters even as references, so they are dropped.
    private static string EscapeXml(string text) =>
        string.Concat(text.Where(c => XmlConvert.IsXmlChar(c) || char.IsSurrogate(c)))
            .Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
}
