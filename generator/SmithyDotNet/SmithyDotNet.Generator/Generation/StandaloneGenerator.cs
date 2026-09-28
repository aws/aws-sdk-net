using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Model;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// Generates one service from a single Smithy AST file into a self-contained project (see
/// <see cref="StandaloneOptions"/>). Compared with <see cref="BatchGenerator"/>:
/// no control file, metadata.json, customizations, version manifest, or repo tree; the
/// repo-only artifacts are skipped (see <see cref="ServiceGenerator"/>).
/// </summary>
public sealed class StandaloneGenerator(StandaloneOptions options)
{
    /// <summary>Returns the relative paths written under the output directory, which is logged.</summary>
    public IReadOnlyList<string> Run(CancellationToken ct = default)
    {
        var model = BatchGenerator.LoadModel(options.ModelPath);
        var index = new ServiceIndex(model);

        // The writers that read the manifest (AssemblyInfo, nuspec, code analysis) are skipped in
        // standalone mode, so an empty one satisfies the constructor.
        var context = new GenerationContext(index, new SdkVersionManifest());
        UnsupportedTraitValidator.Validate(index);

        var generator = new ServiceGenerator(context, Path.GetFileName(options.ModelPath), options.Version, DefaultConfigurationManifest.LoadEmbedded(), options);
        Log.Info($"Generating {context.AssemblyName} into '{options.OutputDirectory}'.");

        // Another service's project at the root would make `dotnet build` ambiguous, and it's the
        // user's directory, so nothing there is deleted: fail instead. Re-running the same service is fine.
        if (Directory.Exists(options.OutputDirectory))
        {
            foreach (var project in Directory.EnumerateFiles(options.OutputDirectory, "*.csproj"))
            {
                if (Path.GetFileName(project) != $"{context.AssemblyName}.csproj")
                {
                    throw new GeneratorException($"'{options.OutputDirectory}' already contains '{Path.GetFileName(project)}'; use an empty directory or one previously generated for {context.AssemblyName}.");
                }
            }
        }

        // Same reason as BatchGenerator.WipeStaleOutput: leftover files from an earlier model would
        // compile as duplicate types. Only the generated tree is touched.
        var generated = Path.Combine(options.OutputDirectory, "Generated");
        if (Directory.Exists(generated))
        {
            Directory.Delete(generated, recursive: true);
            Log.Info($"Deleted stale tree '{generated}'.");
        }

        // Nothing is written under the code-analysis root in standalone mode; the tests root is unused too.
        return generator.Generate(options.OutputDirectory, options.OutputDirectory, testsOutputPath: null, ct);
    }
}
