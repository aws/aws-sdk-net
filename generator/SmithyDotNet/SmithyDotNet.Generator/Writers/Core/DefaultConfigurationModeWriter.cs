using SmithyDotNet.Generator.Generation.Manifests;

namespace SmithyDotNet.Generator.Writers.Core;

/// <summary>Emits Core's <c>DefaultConfigurationMode</c> enum from <c>sdk-default-configuration.json</c>, as C2J's <c>DefaultConfigurationModeGenerator.tt</c> does.</summary>
public sealed class DefaultConfigurationModeWriter(IReadOnlyList<ResolvedDefaultConfigurationMode> modes)
{
    public string Write()
    {
        var writer = new CodeWriter();
        FileHeader.WriteCoreLicense(writer);
        writer.WriteLine();
        writer.WriteLine(" /*");
        writer.WriteLine(" * Do not modify this file. This file is generated from the sdk-default-configuration.json file.");
        writer.WriteLine(" */");
        writer.WriteLine();
        writer.OpenNamespace("Amazon.Runtime", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine("""/// Enumeration of the supported Default Configurations available to to <see cref="AmazonServiceClient" /> objects.""");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock("public enum DefaultConfigurationMode", () =>
            {
                for (var i = 0; i < modes.Count; i++)
                {
                    writer.WriteLine("/// <summary>");
                    writer.WriteLine($"/// {modes[i].Documentation}");
                    writer.WriteLine("/// </summary>");
                    writer.WriteLine(i < modes.Count - 1 ? $"{modes[i].Name}," : modes[i].Name);
                }
            });
        });
        return writer.ToRawString().TrimEnd();
    }
}
