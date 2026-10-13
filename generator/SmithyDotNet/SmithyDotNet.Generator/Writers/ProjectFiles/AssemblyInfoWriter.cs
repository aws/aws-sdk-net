using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.ProjectFiles;

namespace SmithyDotNet.Generator.Writers.ProjectFiles;

/// <summary>
/// Emits <c>Properties/AssemblyInfo.cs</c> for a service assembly. The output mirrors the
/// legacy T4 template (<c>AssemblyInfo.tt</c>): assembly title, platform-conditional description,
/// <c>[InternalsVisibleTo]</c> grants from metadata.json's <c>internals-visible-to</c>, and version
/// attributes sourced from <c>_sdk-versions.json</c>.
/// <para/>
/// The <c>AssemblyDescription</c> uses the Smithy <c>@title</c> trait rather than the service
/// synopsis. The synopsis is a stale snapshot of initial release notes; the title tracks the
/// model and matches the shipped SDK assemblies.
/// </summary>
public sealed class AssemblyInfoWriter(GenerationContext context, string serviceFileVersion)
{
    // The public half of sdk/awssdk.dll.snk, which signs every SDK assembly.
    private const string SdkPublicKey = "0024000004800000940000000602000000240000525341310004000001000100db5f59f098d27276c7833875a6263a3cc74ab17ba9a9df0b52aedbe7252745db7274d5271fd79c1f08f668ecfa8eaab5626fa76adc811d3c8fc55859b0d09d3bc0a84eecd0ba891f2b8a2fc55141cdcc37c2053d53491e650a479967c3622762977900eddbf1252ed08a2413f00a28f3a0752a81203f03ccb7f684db373518b4";

    public string Write(CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var writer = new CodeWriter();
        FileHeader.WriteUsings(writer, FileHeader.AssemblyInfoUsings);

        var assemblyVersion = context.Manifest.GetServiceAssemblyVersion(context.ServiceName);

        FileHeader.WriteAssemblyInfoBody(
            writer,
            context.AssemblyName,
            body =>
            {
                WritePlatformDescriptions(body);
                WriteInternalsVisibleTo(body);
            },
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

    private void WriteInternalsVisibleTo(CodeWriter writer)
    {
        var assemblies = context.Metadata?.InternalsVisibleTo ?? [];
        if (assemblies.Count == 0)
        {
            return;
        }

        writer.WriteLine();
        foreach (var assembly in assemblies)
        {
            var target = assembly.Contains("PublicKey=") ? assembly : $"{assembly}, PublicKey={SdkPublicKey}";
            writer.WriteLine($"""[assembly: InternalsVisibleTo("{target}")]""");
        }
        writer.WriteLine();
    }

    // The synopsis is intentionally excluded: it is a snapshot of the service's initial release
    // notes and goes stale, while the title tracks the model.
    private string AssemblyDescription(string versionIdentifier)
    {
        var serviceFullName = context.ServiceTitle ?? throw new GeneratorException("Service shape is missing the smithy.api#title trait; cannot build AssemblyDescription.");
        return $"The Amazon Web Services SDK for .NET ({versionIdentifier}) - {serviceFullName}.";
    }
}
