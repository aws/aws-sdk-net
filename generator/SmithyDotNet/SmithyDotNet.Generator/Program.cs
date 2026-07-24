using System.Diagnostics;
using System.Text.Json;
using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator;

public static class Program
{
    public static int Main(string[] args)
    {
        // The only accepted invocations: no arguments, or "--repo-root <path>". The path is
        // normalized to a full path so logged output paths are readable rather than ..-relative.
        string? repoRoot = null;
        if (args.Length == 2 && args[0] == "--repo-root")
        {
            repoRoot = Path.GetFullPath(args[1]);
        }
        else if (args.Length != 0)
        {
            Log.Error($"Unexpected arguments: {string.Join(' ', args)}");
            Log.Error("Usage is dotnet run --project SmithyDotNet.Generator/SmithyDotNet.Generator.csproj -- [--repo-root <path>]");
            return 1;
        }

        repoRoot ??= FindRepoRoot();
        if (repoRoot is null || !File.Exists(SdkTreeLayout.VersionManifestPath(repoRoot)))
        {
            Log.Error("Could not locate the repo root (a directory containing 'generator/ServiceModels/_sdk-versions.json'). Pass it with --repo-root.");
            return 1;
        }

        try
        {
            var stopwatch = Stopwatch.StartNew();
            var generated = new BatchGenerator(repoRoot).Run();
            Log.Info($"Generated {generated.Count} service(s) in {stopwatch.Elapsed}.");
            return 0;
        }
        catch (Exception ex) when (ex is GeneratorException or IOException or UnauthorizedAccessException or JsonException)
        {
            // GeneratorException: validation/lookup/config failures (including wrapped XML errors).
            // IO/UnauthorizedAccess: reading models/manifests or writing output. JsonException: a
            // malformed model or manifest.
            Log.Error(ex.Message);
            return 1;
        }
    }

    // Walks up from the current directory looking for the version manifest; the directory containing
    // its relative path is the repo root. Returns null when not inside the repo.
    private static string? FindRepoRoot()
    {
        var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
        while (directory is not null)
        {
            if (File.Exists(SdkTreeLayout.VersionManifestPath(directory.FullName)))
            {
                return directory.FullName;
            }

            directory = directory.Parent;
        }

        return null;
    }
}
