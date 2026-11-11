using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Amazon.CodeAnalysis.Shared
{
    /// <summary>
    /// Warns when the project being compiled targets a .NET target framework the AWS SDK for .NET
    /// no longer ships assemblies for. NuGet does not fail in that situation, it quietly resolves
    /// the netstandard2.0 assets instead, so without this diagnostic the downgrade is invisible.
    /// </summary>
    public abstract class AbstractDeprecatedTargetFrameworkAnalyzer : DiagnosticAnalyzer
    {
        // Using the AWSSDK3XXX as the range of diagnostic ids for SDK packaging and target
        // framework diagnostic messages.
        public const string DiagnosticId = "AWSSDK3000";

        private const string TargetFrameworkBuildProperty = "build_property.TargetFramework";
        private const string TargetFrameworkAttributeName = "System.Runtime.Versioning.TargetFrameworkAttribute";
        private const string FallbackTargetFramework = "netstandard2.0";

        private static readonly LocalizableString Title = new LocalizableResourceString(nameof(Resources.DeprecatedTargetFrameworkRule_Title), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat = new LocalizableResourceString(nameof(Resources.DeprecatedTargetFrameworkRule_MessageFormat), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description = new LocalizableResourceString(nameof(Resources.DeprecatedTargetFrameworkRule_Description), Resources.ResourceManager, typeof(Resources));
        private const string Category = "AWSSDK.Packaging";

        private static readonly DiagnosticDescriptor DeprecatedTargetFrameworkRule = new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(DeprecatedTargetFrameworkRule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.EnableConcurrentExecution();

            context.RegisterCompilationAction(CheckTargetFramework);
        }

        private void CheckTargetFramework(CompilationAnalysisContext context)
        {
            if (DeprecatedTargetFrameworks.ShortNames.Length == 0)
                return;

            var targetFramework = GetDeprecatedTargetFramework(context);
            if (targetFramework == null)
                return;

            if (!TryClaimCompilation(context.Compilation))
                return;

            context.ReportDiagnostic(Diagnostic.Create(DeprecatedTargetFrameworkRule, Location.None, targetFramework, FallbackTargetFramework, DiagnosticId));
        }

        /// <summary>
        /// Returns the project's target framework when it is one the SDK has dropped, otherwise null.
        /// </summary>
        private static string GetDeprecatedTargetFramework(CompilationAnalysisContext context)
        {
            var fromBuildProperty = GetTargetFrameworkFromBuildProperty(context);
            if (fromBuildProperty != null)
                return IsDeprecatedShortName(fromBuildProperty) ? fromBuildProperty : null;

            return GetDeprecatedTargetFrameworkFromAssemblyAttribute(context.Compilation);
        }

        /// <summary>
        /// Reads the short target framework name, for example netcoreapp3.1, that the .NET SDK
        /// publishes to analyzers. The SDK writes it to a global analyzer config, and global entries
        /// are merged into the options of every syntax tree, so reading it per tree rather than from
        /// AnalyzerConfigOptionsProvider.GlobalOptions keeps this analyzer loadable on the older
        /// Roslyn versions the SDK's analyzers are compiled against.
        /// </summary>
        private static string GetTargetFrameworkFromBuildProperty(CompilationAnalysisContext context)
        {
            var provider = context.Options?.AnalyzerConfigOptionsProvider;
            if (provider == null)
                return null;

            var tree = context.Compilation.SyntaxTrees.FirstOrDefault();
            if (tree == null)
                return null;

            string targetFramework;
            if (provider.GetOptions(tree).TryGetValue(TargetFrameworkBuildProperty, out targetFramework) &&
                !string.IsNullOrEmpty(targetFramework))
            {
                return targetFramework;
            }

            return null;
        }

        /// <summary>
        /// Fallback for builds that predate the .NET SDK publishing build properties to analyzers.
        /// TargetFrameworkAttribute carries the long form of the moniker, for example
        /// ".NETCoreApp,Version=v3.1", which is matched against the identifier and version of each
        /// deprecated target and reported back as its short name.
        /// </summary>
        private static string GetDeprecatedTargetFrameworkFromAssemblyAttribute(Compilation compilation)
        {
            foreach (var attribute in compilation.Assembly.GetAttributes())
            {
                var attributeClass = attribute.AttributeClass;
                if (attributeClass == null || attributeClass.ToDisplayString() != TargetFrameworkAttributeName)
                    continue;

                if (attribute.ConstructorArguments.Length == 0)
                    continue;

                var frameworkName = attribute.ConstructorArguments[0].Value as string;
                if (string.IsNullOrEmpty(frameworkName))
                    continue;

                string identifier;
                Version version;
                if (!TryParseFrameworkName(frameworkName, out identifier, out version))
                    continue;

                for (var i = 0; i < DeprecatedTargetFrameworks.ShortNames.Length; i++)
                {
                    if (!string.Equals(identifier, DeprecatedTargetFrameworks.Identifiers[i], StringComparison.OrdinalIgnoreCase))
                        continue;

                    Version deprecatedVersion;
                    if (!Version.TryParse(DeprecatedTargetFrameworks.Versions[i], out deprecatedVersion))
                        continue;

                    if (version.Major == deprecatedVersion.Major && version.Minor == deprecatedVersion.Minor)
                        return DeprecatedTargetFrameworks.ShortNames[i];
                }
            }

            return null;
        }

        /// <summary>
        /// Splits a framework name such as ".NETCoreApp,Version=v3.1" or
        /// ".NETFramework,Version=v4.7.2,Profile=Client" into its identifier and version. Any
        /// trailing profile is ignored.
        /// </summary>
        private static bool TryParseFrameworkName(string frameworkName, out string identifier, out Version version)
        {
            identifier = null;
            version = null;

            var parts = frameworkName.Split(',');
            if (parts.Length < 2)
                return false;

            identifier = parts[0].Trim();

            foreach (var part in parts.Skip(1))
            {
                var trimmed = part.Trim();
                if (!trimmed.StartsWith("Version=", StringComparison.OrdinalIgnoreCase))
                    continue;

                return Version.TryParse(trimmed.Substring("Version=".Length).TrimStart('v', 'V'), out version);
            }

            return false;
        }

        private static bool IsDeprecatedShortName(string targetFramework)
        {
            return DeprecatedTargetFrameworks.ShortNames
                .Any(name => IsSameOrOsSpecificVariant(name, targetFramework));
        }

        /// <summary>
        /// Matches the reported target framework against a deprecated base target, treating OS-specific
        /// TFMs such as net6.0-browser or net6.0-windows10.0.19041 as the base target they extend. Those
        /// monikers are always the base short name followed by "-{platform}", so a prefix comparison
        /// covers the whole family without hard-coding the set of platforms.
        /// </summary>
        private static bool IsSameOrOsSpecificVariant(string deprecatedShortName, string targetFramework)
        {
            if (string.Equals(deprecatedShortName, targetFramework, StringComparison.OrdinalIgnoreCase))
                return true;

            return targetFramework.StartsWith(deprecatedShortName + "-", StringComparison.OrdinalIgnoreCase);
        }

        private const string ClaimSlotName = "AWSSDK.CodeAnalysis.DeprecatedTargetFrameworkAnalyzer.Claims";
        private static readonly object ClaimMarker = new object();

        /// <summary>
        /// Every AWS SDK package ships its own copy of this analyzer, so a project referencing
        /// several AWS packages loads several independent copies of it and each one would report the
        /// same warning. Static state is per copy, so the claim is parked on the AppDomain, the one
        /// object all of the copies share, keyed by the compilation being analyzed.
        /// </summary>
        private static bool TryClaimCompilation(Compilation compilation)
        {
            try
            {
                var domain = AppDomain.CurrentDomain;
                lock (domain)
                {
                    var claims = domain.GetData(ClaimSlotName) as ConditionalWeakTable<Compilation, object>;
                    if (claims == null)
                    {
                        claims = new ConditionalWeakTable<Compilation, object>();
                        domain.SetData(ClaimSlotName, claims);
                    }

                    object alreadyClaimed;
                    if (claims.TryGetValue(compilation, out alreadyClaimed))
                        return false;

                    claims.Add(compilation, ClaimMarker);
                    return true;
                }
            }
            catch (Exception)
            {
                // A duplicate warning is an acceptable outcome, a missing one is not, so never let
                // the de-duplication bookkeeping swallow the diagnostic.
                return true;
            }
        }
    }
}
