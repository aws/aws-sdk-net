namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// The SDK repository tree layout, defined once: the absolute per-service roots the batch driver
/// generates into, and the relative prefixes the project and solution writers embed in generated
/// files.
/// </summary>
public static class SdkTreeLayout
{
    /// <summary>generator/ServiceModels — model dirs, the control file, and _sdk-versions.json.</summary>
    public static string ModelsRoot(string repoRoot) => Path.Combine(repoRoot, "generator", "ServiceModels");

    /// <summary>The all-inclusive Smithy model each service directory under ModelsRoot carries at a fixed name.</summary>
    public const string SmithyModelFileName = "smithy.json";

    /// <summary>The control file under ModelsRoot listing the services the Smithy generator owns.</summary>
    public const string MigratedServicesFileName = "_smithy-migrated-services.json";

    /// <summary>generator/ServiceModels/_sdk-versions.json — also the marker file that identifies the repo root.</summary>
    public static string VersionManifestPath(string repoRoot) => Path.Combine(ModelsRoot(repoRoot), "_sdk-versions.json");

    public static string SdkRoot(string repoRoot) => Path.Combine(repoRoot, "sdk");

    /// <summary>sdk/src/Services/{Name} — the service source tree; csprojs, nuspec, and slnx land at its root.</summary>
    public static string ServiceSourceRoot(string repoRoot, string serviceName) => Path.Combine(SdkRoot(repoRoot), "src", "Services", serviceName);

    /// <summary>sdk/code-analysis/ServiceAnalysis/{Name} — the service's code-analysis project.</summary>
    public static string ServiceCodeAnalysisRoot(string repoRoot, string serviceName) => Path.Combine(SdkRoot(repoRoot), "code-analysis", "ServiceAnalysis", serviceName);

    /// <summary>sdk/test/Services/{Name} — the service test tree; the unit-test csproj lands under UnitTests/.</summary>
    public static string ServiceTestsRoot(string repoRoot, string serviceName) => Path.Combine(SdkRoot(repoRoot), "test", "Services", serviceName);

    // Relative prefixes embedded in generated files. Forward-slash so the generated references are
    // byte-identical whether the generator runs on Windows or Linux.

    /// <summary>From sdk/src/Services/{Name}/ up to sdk/.</summary>
    public const string SdkRootFromServiceSource = "../../..";

    /// <summary>From sdk/src/Services/{Name}/ up to sdk/src/.</summary>
    public const string SrcRootFromServiceSource = "../..";

    /// <summary>From sdk/test/Services/{Name}/UnitTests/ up to sdk/.</summary>
    public const string SdkRootFromUnitTests = "../../../..";

    /// <summary>From sdk/test/Services/{Name}/UnitTests/ up to sdk/test/.</summary>
    public const string TestRootFromUnitTests = "../../..";

    /// <summary>From sdk/code-analysis/ServiceAnalysis/{Name}/ up to sdk/code-analysis/.</summary>
    public const string CodeAnalysisRootFromServiceAnalysis = "../..";
}
