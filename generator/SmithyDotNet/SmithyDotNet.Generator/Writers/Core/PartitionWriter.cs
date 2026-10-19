using SmithyDotNet.Generator.Generation.Manifests;

namespace SmithyDotNet.Generator.Writers.Core;

/// <summary>
/// Emits Core's <c>Partition.generated.cs</c>: the static constructor filling the endpoint rules' partition lookup
/// tables (one attributes object per partition, its region regex, and every region name, global ones included).
/// </summary>
public sealed class PartitionWriter(IReadOnlyList<AwsPartition> partitions)
{
    public string Write()
    {
        var writer = new CodeWriter();
        FileHeader.WriteCoreLicense(writer);
        writer.WriteLine("using System.Text.RegularExpressions;");
        writer.WriteLine();
        writer.OpenNamespace("Amazon.Runtime.Internal.Endpoints.StandardLibrary", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// Generated implementation of partition-specific data.");
            writer.WriteLine("/// Based on the data from partitions.json");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock("public partial class Partition", () =>
            {
                writer.OpenBlock("static Partition()", () =>
                {
                    foreach (var partition in partitions)
                    {
                        var variable = partition.Id.Replace('-', '_');
                        writer.OpenBlock($"var {variable} = new PartitionAttributesShape", "};", () =>
                        {
                            writer.WriteLine($"name = {CodeWriter.Literal(partition.Name)},");
                            writer.WriteLine($"dnsSuffix = {CodeWriter.Literal(partition.DnsSuffix)},");
                            writer.WriteLine($"dualStackDnsSuffix = {CodeWriter.Literal(partition.DualStackDnsSuffix)},");
                            writer.WriteLine($"supportsFIPS = {(partition.SupportsFips ? "true" : "false")},");
                            writer.WriteLine($"supportsDualStack = {(partition.SupportsDualStack ? "true" : "false")},");
                            writer.WriteLine($"implicitGlobalRegion = {CodeWriter.Literal(partition.ImplicitGlobalRegion)}");
                        });
                        // The regex stays a verbatim string, as C2J emitted it; Literal would double its backslashes.
                        writer.WriteLine($"""_partitionsByRegex.Add((new Regex(@"{partition.RegionRegex}", RegexOptions.Compiled), {variable}));""");
                        foreach (var region in partition.Regions)
                        {
                            writer.WriteLine($"_partitionsByRegionName.Add({CodeWriter.Literal(region.Code)}, {variable});");
                        }

                        writer.WriteLine();
                    }

                    writer.WriteLine("_defaultPartition = aws;");
                });
            });
        });

        // C2J's template output has no final newline; matching it leaves the committed file unchanged.
        return writer.ToRawString().TrimEnd();
    }
}
