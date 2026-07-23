namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// File names of the shared test and generator projects a service's slnx references.
/// </summary>
public static class ProjectFileNames
{
    public const string GeneratorLib = "ServiceClientGeneratorLib.csproj";
    public const string CommonTest = "AWSSDK.CommonTest.csproj";
    public const string UnitTestsCore = "AWSSDK.UnitTests.Core.csproj";
    public const string UnitTestUtility = "AWSSDK.UnitTestUtilities.csproj";
    public const string IntegrationTestUtility = "AWSSDK.IntegrationTestUtilities.csproj";
}

/// <summary>A NuGet package reference emitted with <c>PrivateAssets=all</c>.</summary>
public sealed record PackageRef(string Id, string Version);

/// <summary>
/// Configuration for a single service project file variant (NetFramework or NetStandard).
/// Carries everything the project file writer needs that isn't service-specific: target framework
/// property, define constants, relative paths, package references, framework references, and
/// suppressions.
/// <para/>
/// The generated csproj references the target frameworks by MSBuild property
/// (<c>$(SdkNetFrameworkTargets)</c> / <c>$(SdkNetTargets)</c>), so the concrete TFM set lives only
/// in <c>sdk/Directory.Build.props</c> and resolves at build time.
/// </summary>
public sealed record ServiceProjectConfiguration
{
    /// <summary>The MSBuild property expression for the TargetFrameworks element.</summary>
    public required string TargetFrameworksProperty { get; init; }

    /// <summary>Compile-time define constants.</summary>
    public required IReadOnlyList<string> DefineConstants { get; init; }

    /// <summary>
    /// Whether any target framework is trimmable (.NET 8+), so the <c>IsTrimmable</c> PropertyGroup
    /// is emitted. False for the .NET Framework variant, whose only target never qualifies.
    /// </summary>
    public required bool HasTrimmableTarget { get; init; }

    /// <summary>Relative path from the service csproj to the Core project reference.</summary>
    public required string CoreProjectReference { get; init; }

    /// <summary>Relative path to the signing key file (fallback when <c>$(AWSKeyFile)</c> is empty).</summary>
    public required string KeyFilePath { get; init; }

    /// <summary>Relative path to the custom Roslyn analyzers DLL.</summary>
    public required string AnalyzersPath { get; init; }

    /// <summary>Relative path to the default ruleset file.</summary>
    public required string RuleSetFilePath { get; init; }

    /// <summary>Relative path to the build-time ruleset file.</summary>
    public required string RuleSetFilePathForBuild { get; init; }

    /// <summary>NoWarn value.</summary>
    public required string NoWarn { get; init; }

    /// <summary>NuGet package references (analyzers, emitted with PrivateAssets=all).</summary>
    public required IReadOnlyList<PackageRef> PackageReferences { get; init; }

    /// <summary>.NET Framework assembly references.</summary>
    public required IReadOnlyList<string> FrameworkReferences { get; init; }

    // TODO: Add service-to-service ProjectReferences (e.g. SecurityToken, S3) once services with
    // SDK dependencies beyond Core are onboarded.
}

/// <summary>
/// Provides the two standard service project configurations.
/// </summary>
public static class ServiceProjectConfigurations
{
    // Service csprojs live at sdk/src/Services/{Service}/ — 3 levels below sdk/.
    private static string SdkRoot = Utils.PathCombineAlt("..", "..", "..");
    private static string ServicesRoot = Utils.PathCombineAlt("..", "..");

    public static ServiceProjectConfiguration NetFramework { get; } = new()
    {
        TargetFrameworksProperty = "$(SdkNetFrameworkTargets)",
        DefineConstants = ["BCL", "CODE_ANALYSIS"],
        HasTrimmableTarget = false,
        CoreProjectReference = Utils.PathCombineAlt(ServicesRoot, "Core", "AWSSDK.Core.NetFramework.csproj"),
        KeyFilePath = Utils.PathCombineAlt(SdkRoot, "awssdk.dll.snk"),
        AnalyzersPath = Utils.PathCombineAlt(SdkRoot, "..", "buildtools", "CustomRoslynAnalyzers.dll"),
        RuleSetFilePath = Utils.PathCombineAlt(SdkRoot, "AWSDotNetSDK.ruleset"),
        RuleSetFilePathForBuild = Utils.PathCombineAlt(SdkRoot, "AWSDotNetSDKForBuild.ruleset"),
        NoWarn = "CA1822",
        PackageReferences =
        [
            new("Microsoft.CodeAnalysis.FxCopAnalyzers", "2.9.3"),
            new("Microsoft.DotNet.Analyzers.Compatibility", "0.2.12-alpha"),
        ],
        FrameworkReferences = ["System.Configuration"],
    };

    public static ServiceProjectConfiguration NetStandard { get; } = new()
    {
        TargetFrameworksProperty = "$(SdkNetTargets)",
        // AWS_ASYNC_ENUMERABLES_API is unconditional here: every NetStandard-variant target is
        // non-.NET-Framework, so the constant always applies.
        DefineConstants = ["NETSTANDARD", "AWS_ASYNC_ENUMERABLES_API"],
        HasTrimmableTarget = true,
        CoreProjectReference = Utils.PathCombineAlt(ServicesRoot, "Core", "AWSSDK.Core.NetStandard.csproj"),
        KeyFilePath = Utils.PathCombineAlt(SdkRoot, "awssdk.dll.snk"),
        AnalyzersPath = Utils.PathCombineAlt(SdkRoot, "..", "buildtools", "CustomRoslynAnalyzers.dll"),
        RuleSetFilePath = Utils.PathCombineAlt(SdkRoot, "AWSDotNetSDK.ruleset"),
        RuleSetFilePathForBuild = Utils.PathCombineAlt(SdkRoot, "AWSDotNetSDKForBuild.ruleset"),
        NoWarn = "CA1822",
        PackageReferences =
        [
            new("Microsoft.CodeAnalysis.FxCopAnalyzers", "2.9.3"),
            new("Microsoft.DotNet.Analyzers.Compatibility", "0.2.12-alpha"),
        ],
        FrameworkReferences = [],
    };
}
