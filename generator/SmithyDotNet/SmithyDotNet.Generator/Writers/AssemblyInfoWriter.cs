using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits <c>Properties/AssemblyInfo.cs</c> for a service assembly. The output mirrors the
/// legacy T4 template (<c>AssemblyInfo.tt</c>): assembly title, platform-conditional description,
/// and version attributes sourced from <c>_sdk-versions.json</c>.
/// <para/>
/// The <c>AssemblyDescription</c> uses the Smithy <c>@title</c> trait rather than the service
/// synopsis. The synopsis is a stale snapshot of initial release notes; the title tracks the
/// model and matches the shipped SDK assemblies.
/// </summary>
public sealed class AssemblyInfoWriter(GenerationContext context, string serviceFileVersion)
{
    public string Write(CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var writer = new CodeWriter();
        FileHeader.WriteUsings(writer, FileHeader.AssemblyInfoUsings);

        var assemblyVersion = context.Manifest.GetServiceAssemblyVersion(context.ServiceName);

        FileHeader.WriteAssemblyInfoBody(
            writer,
            context.AssemblyName,
            WritePlatformDescriptions,
            assemblyVersion,
            serviceFileVersion);

        return writer.ToRawString();
    }

    private void WritePlatformDescriptions(CodeWriter writer)
    {
        var platforms = TargetPlatforms.Platforms;
        for (var i = 0; i < platforms.Count; i++)
        {
            var platform = platforms[i];
            var directive = i == 0 ? "#if" : "#elif";
            writer.WriteLine($"{directive} {platform.Symbol}");
            writer.WriteLine($"""[assembly: AssemblyDescription("{AssemblyDescription(platform.Label)}")]""");
        }

        writer.WriteLine("#else");
        writer.WriteLine("#error Unknown platform constant - unable to set correct AssemblyDescription");
        writer.WriteLine("#endif");
    }

    // The synopsis is intentionally excluded: it is a snapshot of the service's initial release
    // notes and goes stale, while the title tracks the model.
    private string AssemblyDescription(string versionIdentifier)
    {
        var serviceFullName = context.ServiceTitle ?? throw new GeneratorException("Service shape is missing the smithy.api#title trait; cannot build AssemblyDescription.");
        return $"The Amazon Web Services SDK for .NET ({versionIdentifier}) - {serviceFullName}.";
    }
}
