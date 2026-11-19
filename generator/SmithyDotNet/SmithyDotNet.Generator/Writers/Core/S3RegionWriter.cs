using SmithyDotNet.Generator.Generation.Manifests;

namespace SmithyDotNet.Generator.Writers.Core;

/// <summary>
/// Emits S3's <c>S3Enumerations.cs</c>: an <c>S3Region</c> constant per region in <c>partitions.json</c>, named
/// like Core's <c>RegionEndpoint</c> constants and in the same order.
/// </summary>
public sealed class S3RegionWriter(IReadOnlyList<AwsPartition> partitions)
{
    public string Write()
    {
        var writer = new CodeWriter();
        FileHeader.WriteCoreLicense(writer);
        writer.OpenNamespace("Amazon.S3", () =>
        {
            writer.OpenBlock("public sealed partial class S3Region", () =>
            {
                foreach (var region in partitions.SelectMany(partition => partition.Regions).Where(region => !RegionEndpointWriter.IsGlobalPseudoRegion(region)))
                {
                    writer.WriteLine("/// <summary>");
                    writer.WriteLine($"/// Specifies that the S3 Bucket should use the {region.Code} locality.");
                    writer.WriteLine("/// </summary>");
                    writer.WriteLine($"public static readonly S3Region {RegionEndpointWriter.ConstantName(region.Code)} = new S3Region({CodeWriter.Literal(BucketRegionValue(region.Code))});");
                    writer.WriteLine();
                }
            });
        });

        // C2J's template output has no final newline; matching it leaves the committed file unchanged.
        return writer.ToRawString().TrimEnd();
    }

    // S3 predates region codes for its two oldest locations: us-east-1 is the empty location constraint and
    // eu-west-1 is "EU". The values are part of the public API, so they stay.
    private static string BucketRegionValue(string regionCode) => regionCode switch
    {
        "us-east-1" => "",
        "eu-west-1" => "EU",
        _ => regionCode,
    };
}
