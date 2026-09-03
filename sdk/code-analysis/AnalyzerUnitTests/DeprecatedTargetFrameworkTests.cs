using Amazon.CodeAnalysis.Shared;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using VerifyCS = AnalyzerUnitTests.Test.CSharpAnalyzerVerifier<Amazon.CodeAnalysis.DeprecatedTargetFrameworkAnalyzer>;

namespace AnalyzerUnitTests.Test
{
    /// <summary>
    /// The deprecated target frameworks the analyzer matches against are baked in from the
    /// DeprecatedTargets property in sdk/Directory.Build.props. These tests drive off the generated
    /// DeprecatedTargetFrameworks arrays so they cover whatever set that property currently declares.
    /// </summary>
    [TestClass]
    public class DeprecatedTargetFrameworkTests
    {
        private const string EmptyClass = "class Program { }";

        /// <summary>
        /// Every deprecated target reported through the build property (the path the .NET SDK uses)
        /// must produce the AWSSDK3000 warning.
        /// </summary>
        [TestMethod]
        public async Task EveryDeprecatedTargetFromBuildPropertyIsReported()
        {
            Assert.IsTrue(DeprecatedTargetFrameworks.ShortNames.Length > 0, "No deprecated targets were baked in; the loop would pass vacuously.");

            foreach (var targetFramework in DeprecatedTargetFrameworks.ShortNames)
            {
                var test = BuildTest(EmptyClass, targetFrameworkBuildProperty: targetFramework);
                test.ExpectedDiagnostics.Add(ExpectedDiagnostic(targetFramework));

                await test.RunAsync();
            }
        }

        /// <summary>
        /// The fallback path for builds that do not publish MSBuild properties to analyzers: the same
        /// deprecated targets must be recognized from the long-form TargetFrameworkAttribute value.
        /// </summary>
        [TestMethod]
        public async Task EveryDeprecatedTargetFromAssemblyAttributeIsReported()
        {
            Assert.IsTrue(DeprecatedTargetFrameworks.ShortNames.Length > 0, "No deprecated targets were baked in; the loop would pass vacuously.");

            for (var i = 0; i < DeprecatedTargetFrameworks.ShortNames.Length; i++)
            {
                var frameworkName = $"{DeprecatedTargetFrameworks.Identifiers[i]},Version=v{DeprecatedTargetFrameworks.Versions[i]}";

                var test = BuildTest(TargetFrameworkAttribute(frameworkName));
                test.ExpectedDiagnostics.Add(ExpectedDiagnostic(DeprecatedTargetFrameworks.ShortNames[i]));

                await test.RunAsync();
            }
        }

        [TestMethod]
        public async Task SupportedTargetFrameworkFromBuildProperty()
        {
            await BuildTest(EmptyClass, targetFrameworkBuildProperty: "net8.0").RunAsync();
        }

        [TestMethod]
        public async Task SupportedTargetFrameworkFromAssemblyAttribute()
        {
            await BuildTest(TargetFrameworkAttribute(".NETCoreApp,Version=v8.0")).RunAsync();
        }

        [TestMethod]
        public async Task NetFrameworkTargetIsNotReported()
        {
            await BuildTest(TargetFrameworkAttribute(".NETFramework,Version=v4.7.2,Profile=Client")).RunAsync();
        }

        [TestMethod]
        public async Task NetStandard20FromBuildPropertyIsNotReported()
        {
            await BuildTest(EmptyClass, targetFrameworkBuildProperty: "netstandard2.0").RunAsync();
        }

        [TestMethod]
        public async Task NetStandard20FromAssemblyAttributeIsNotReported()
        {
            await BuildTest(TargetFrameworkAttribute(".NETStandard,Version=v2.0")).RunAsync();
        }

        [TestMethod]
        public async Task NetFramework472FromBuildPropertyIsNotReported()
        {
            await BuildTest(EmptyClass, targetFrameworkBuildProperty: "net472").RunAsync();
        }

        [TestMethod]
        public async Task NetFramework48FromBuildPropertyIsNotReported()
        {
            await BuildTest(EmptyClass, targetFrameworkBuildProperty: "net48").RunAsync();
        }

        [TestMethod]
        public async Task NetFramework48FromAssemblyAttributeIsNotReported()
        {
            await BuildTest(TargetFrameworkAttribute(".NETFramework,Version=v4.8")).RunAsync();
        }

        /// <summary>
        /// A build property naming a supported target wins over a stale assembly attribute, so the
        /// two sources are never combined into a false positive.
        /// </summary>
        [TestMethod]
        public async Task BuildPropertyTakesPrecedenceOverAssemblyAttribute()
        {
            await BuildTest(TargetFrameworkAttribute(".NETCoreApp,Version=v3.1"), targetFrameworkBuildProperty: "net8.0").RunAsync();
        }

        [TestMethod]
        public async Task NoTargetFrameworkInformationIsNotReported()
        {
            await BuildTest(EmptyClass).RunAsync();
        }

        private static string TargetFrameworkAttribute(string frameworkName)
        {
            return $"[assembly: System.Runtime.Versioning.TargetFramework(\"{frameworkName}\")]\n{EmptyClass}";
        }

        private static string BuildExpectedMessage(string framework)
        {
            return $"The target framework '{framework}' is no longer supported by the AWS SDK for .NET. " +
                "This project has fallen back to the netstandard2.0 assemblies of the SDK, which do not " +
                "include the features and optimizations available on supported targets. Retarget the " +
                "project to a supported .NET target, or suppress this warning with <NoWarn>AWSSDK3000</NoWarn>.";
        }

        private static DiagnosticResult ExpectedDiagnostic(string framework)
        {
            return new DiagnosticResult("AWSSDK3000", DiagnosticSeverity.Warning)
                .WithMessage(BuildExpectedMessage(framework))
                .WithArguments(framework, "netstandard2.0", "AWSSDK3000");
        }

        private static VerifyCS.Test BuildTest(string source, string targetFrameworkBuildProperty = null)
        {
            var test = new VerifyCS.Test
            {
                TestState = { Sources = { source } },
                ReferenceAssemblies = ReferenceAssemblies.Net.Net80
            };

            if (targetFrameworkBuildProperty != null)
            {
                // Mirrors the global analyzer config the .NET SDK generates for every project.
                test.TestState.AnalyzerConfigFiles.Add(
                    ("/.globalconfig", $"is_global = true\nbuild_property.TargetFramework = {targetFrameworkBuildProperty}\n"));
            }

            return test;
        }
    }
}
