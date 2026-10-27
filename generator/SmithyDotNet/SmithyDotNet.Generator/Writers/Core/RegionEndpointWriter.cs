using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Manifests;

namespace SmithyDotNet.Generator.Writers.Core;

/// <summary>
/// Emits Core's <c>RegionEndpoint.generated.cs</c>: a public <c>RegionEndpoint</c> constant per region in
/// <c>partitions.json</c>, in the file's order.
/// </summary>
public sealed class RegionEndpointWriter(IReadOnlyList<AwsPartition> partitions)
{
    private const string HostnameTemplate = "{service}.{region}.{dnsSuffix}";

    public string Write()
    {
        var writer = new CodeWriter();
        FileHeader.WriteCoreLicense(writer);
        writer.OpenNamespace("Amazon", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// This class contains region information used to lazily compute the service endpoints. The static constants representing the ");
            writer.WriteLine("/// regions can be used while constructing the AWS client instead of looking up the exact endpoint URL.");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock("public partial class RegionEndpoint", () =>
            {
                foreach (var partition in partitions)
                {
                    // The SDK has never shipped constants for the partition-wide *-global pseudo-regions.
                    foreach (var region in partition.Regions.Where(region => !region.Code.EndsWith("-global", StringComparison.OrdinalIgnoreCase)))
                    {
                        // S3 still accepts the legacy us-east-1-regional name, so it keeps a private constant.
                        if (region.Code == "us-east-1")
                        {
                            WriteConstant(writer, ["The US East (Virginia) regional endpoint.", "S3-specific, use for backward compatibility only."], "private", "USEast1Regional", new AwsRegion("us-east-1-regional", "US East (Virginia) regional"), partition);
                        }

                        WriteConstant(writer, [$"The {region.Description} endpoint."], "public", ConstantName(region.Code), region, partition);
                    }
                }
            });
        });

        // C2J's template output has no final newline; matching it leaves the committed file unchanged.
        return writer.ToRawString().TrimEnd();
    }

    private static void WriteConstant(CodeWriter writer, IReadOnlyList<string> summary, string modifier, string name, AwsRegion region, AwsPartition partition)
    {
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        foreach (var line in summary)
        {
            writer.WriteLine($"/// {line}");
        }

        writer.WriteLine("/// </summary>");
        // The regex stays a verbatim string, as C2J emitted it; Literal would double its backslashes.
        writer.WriteLine($"""{modifier} static readonly RegionEndpoint {name} = GetRegionEndpoint({CodeWriter.Literal(region.Code)}, {CodeWriter.Literal(region.Description)}, {CodeWriter.Literal(partition.Id)}, {CodeWriter.Literal(partition.DnsSuffix)}, @"{partition.RegionRegex}", {CodeWriter.Literal(HostnameTemplate)});""");
    }

    /// <summary>
    /// The constant's name: each dash-separated part upper-cased first, the first part entirely (<c>us-east-1</c> is
    /// <c>USEast1</c>). The <c>NorthWest</c> and <c>GovCloud</c> spellings keep the names the SDK has always shipped.
    /// </summary>
    private static string ConstantName(string regionCode)
    {
        var parts = regionCode.Split('-');
        return parts[0].ToUpperInvariant() + string.Concat(parts.Skip(1).Select(part => part switch
        {
            "northwest" => "NorthWest",
            "gov" => "GovCloud",
            _ => SdkNaming.ToUpperFirstCharacter(part),
        }));
    }
}
