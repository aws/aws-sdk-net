using System.Diagnostics;
using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.ProjectFiles;

namespace SmithyDotNet.Generator;

public static class Program
{
    public static int Main(string[] args)
    {
        // Standalone mode generates one model outside the repo; see StandaloneUsage.
        if (args.Contains("--model"))
        {
            return RunStandalone(args);
        }

        // Repo mode accepts no arguments, or "--repo-root <path>". The path is normalized to a
        // full path so logged output paths are readable rather than ..-relative.
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

    private const string StandaloneUsage = "--model <smithy-ast.json> --tfms <tfm[;tfm...]> --output <dir> [--core-version <version>] [--version <version>]";

    private static int RunStandalone(string[] args)
    {
        try
        {
            var options = new StandaloneOptions
            {
                ModelPath = Path.GetFullPath(RequiredOption(args, "--model")),
                OutputDirectory = Path.GetFullPath(RequiredOption(args, "--output")),
                TargetFrameworks = RequiredOption(args, "--tfms").Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries),
                CoreVersion = Option(args, "--core-version") ?? StandaloneOptions.DefaultCoreVersion,
                Version = Option(args, "--version") ?? StandaloneOptions.DefaultVersion,
            };

            var stopwatch = Stopwatch.StartNew();
            var written = new StandaloneGenerator(options).Run();
            Log.Info($"Generated {written.Count} files in {stopwatch.Elapsed}.");
            return 0;
        }
        catch (Exception ex) when (ex is GeneratorException or IOException or UnauthorizedAccessException or JsonException)
        {
            Log.Error(ex.Message);
            return 1;
        }
    }

    // The value following the option name, or null when the option is absent.
    private static string? Option(string[] args, string name)
    {
        var index = Array.IndexOf(args, name);
        return index >= 0 && index + 1 < args.Length ? args[index + 1] : null;
    }

    private static string RequiredOption(string[] args, string name) =>
        Option(args, name) ?? throw new GeneratorException($"{name} is required. Usage: {StandaloneUsage}");

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
