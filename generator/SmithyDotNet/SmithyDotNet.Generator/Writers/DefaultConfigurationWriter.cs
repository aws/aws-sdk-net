using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for the service's default-configuration class (e.g.
/// <c>AmazonCloudTrailDataDefaultConfiguration</c>): one <c>IDefaultConfiguration</c> property per
/// mode plus <c>GetAllConfigurations()</c>, which the generated config's constructor consumes.
/// <para />
/// The mode values are not in the Smithy model (they come from the repo-wide
/// <c>sdk-default-configuration.json</c>), so they are supplied as a constructor argument.
/// </summary>
public sealed class DefaultConfigurationWriter(GenerationContext context, string modelFileName, IReadOnlyList<ResolvedDefaultConfigurationMode> modes)
{
    /// <summary>
    /// Emits the complete formatted default-configuration source for the service.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.DefaultConfigurationUsings);
        writer.OpenNamespace(context.Namespace, () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Configuration for accessing Amazon {context.ServiceName} service");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public static class {context.ClientName}DefaultConfiguration", () =>
            {
                WriteGetAllConfigurations(writer);
                foreach (var mode in modes)
                {
                    writer.WriteLine();
                    WriteMode(writer, mode);
                }
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteGetAllConfigurations(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Collection of all <see cref=\"DefaultConfiguration\"/>s supported by {context.ServiceName}");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public static ReadOnlyCollection<IDefaultConfiguration> GetAllConfigurations()", () =>
        {
            writer.OpenBlock("return new ReadOnlyCollection<IDefaultConfiguration>(new List<IDefaultConfiguration>", "});", () =>
            {
                for (var i = 0; i < modes.Count; i++)
                {
                    writer.WriteLine(i < modes.Count - 1 ? $"{modes[i].Name}," : modes[i].Name);
                }
            });
        });
    }

    private static void WriteMode(CodeWriter writer, ResolvedDefaultConfigurationMode mode)
    {
        writer.WriteLine("/// <summary>");
        DocumentationFormatter.WriteCommentBlock(writer, DocumentationFormatter.Cleanup(mode.Documentation));
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public static IDefaultConfiguration {mode.Name} {{ get; }} = new DefaultConfiguration", "};", () =>
        {
            writer.WriteLine($"Name = DefaultConfigurationMode.{mode.Name},");
            writer.WriteLine($"RetryMode = RequestRetryMode.{mode.RetryMode},");
            writer.WriteLine($"S3UsEast1RegionalEndpoint = S3UsEast1RegionalEndpointValue.{mode.S3UsEast1RegionalEndpoint},");
            writer.WriteLine($"ConnectTimeout = {TimeoutValue(mode.ConnectTimeoutInMillis)},");
            writer.WriteLine($"TlsNegotiationTimeout = {TimeoutValue(mode.TlsNegotiationTimeoutInMillis)},");
            writer.WriteLine($"TimeToFirstByteTimeout = {TimeoutValue(mode.TimeToFirstByteTimeoutInMillis)},");
            writer.WriteLine($"HttpRequestTimeout = {TimeoutValue(mode.HttpRequestTimeoutInMillis)}");
        });
    }

    // Options without a value are still assigned (as null) so every mode spells out the full
    // option set.
    private static string TimeoutValue(int? millis)
    {
        return millis is { } value ? $"TimeSpan.FromMilliseconds({value})" : "null";
    }
}
