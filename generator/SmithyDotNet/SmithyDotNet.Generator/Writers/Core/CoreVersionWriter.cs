using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Generation.ProjectFiles;

namespace SmithyDotNet.Generator.Writers.Core;

/// <summary>
/// Emits Core's version-stamped files from <c>_sdk-versions.json</c>, as C2J's <c>CoreAssemblyInfo.tt</c>,
/// <c>InternalSDKUtils.tt</c> and <c>CoreNuspec.tt</c> do. The committed <c>AssemblyInfo.cs</c> and
/// <c>InternalSDKUtils.generated.cs</c> match C2J's output (trimmed, tabs as four spaces), so they don't change; the
/// nuspec is git-ignored, and C2J rewrites it after this generator.
/// </summary>
public sealed class CoreVersionWriter(SdkVersionManifest manifest)
{
    private static readonly string[] InternalsVisibleTo =
    [
        "AWSSDK.Extensions.CborProtocol",
        "AWSSDK.UnitTests.NetFramework",
        "AWSSDK.UnitTests.NetStandard",
        "AWSSDK.UnitTestUtilities",
        "AWSSDK.UnitTests.Core",
        // Moq's proxy assembly is signed with Castle's key, not the SDK's.
        "DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7",
    ];

    public string WriteAssemblyInfo()
    {
        var writer = new CodeWriter();
        FileHeader.WriteUsings(writer, FileHeader.AssemblyInfoUsings);
        FileHeader.WriteAssemblyInfoBody(
            writer,
            "AWSSDK.Core",
            body =>
            {
                FileHeader.WritePlatformDescriptions(body, label => $"The Amazon Web Services SDK for .NET ({label}) - Core Runtime");
                FileHeader.WriteInternalsVisibleTo(body, InternalsVisibleTo);
            },
            manifest.GetCoreAssemblyVersion(),
            manifest.GetCoreVersion());
        writer.WriteLine();
        writer.WriteLine("#if NETFRAMEWORK");
        writer.WriteLine("[assembly: System.Security.AllowPartiallyTrustedCallers]");
        writer.WriteLine();
        writer.WriteComment("Setting SecurityRules to level 1 to match .NET 2.0 rules and allow the");
        writer.WriteComment("Amazon.Util.Settings.UserCrypto methods to work in the .NET Framework");
        writer.WriteLine("[assembly: System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]");
        writer.WriteLine("#endif");
        return writer.ToRawString().TrimEnd();
    }

    public string WriteInternalSdkUtils()
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicenseWithNotice(writer, "This is a generated file.");
        writer.WriteLine();
        FileHeader.WriteUsings(writer, ["System", "System.Collections.Generic", "System.Linq", "System.Globalization", "System.Text"]);
        FileHeader.WriteUsings(writer, ["Amazon.Runtime.Internal.Util"]);
        writer.OpenNamespace("Amazon.Util.Internal", () =>
            writer.OpenBlock("public static partial class InternalSDKUtils", () =>
                writer.WriteLine($"internal const string CoreVersionNumber = {CodeWriter.Literal(manifest.GetCoreVersion())};")));
        return writer.ToRawString().TrimEnd();
    }

    public string WriteNuspec()
    {
        var writer = new CodeWriter();
        writer.WriteLine("""<?xml version="1.0" encoding="utf-8"?>""");
        writer.OpenXmlBlock("package", () =>
        {
            writer.OpenXmlBlock("metadata", () =>
            {
                writer.WriteLine("<id>AWSSDK.Core</id>");
                writer.WriteLine("<title>AWSSDK - Core Runtime</title>");
                writer.WriteLine($"<version>{manifest.GetCorePackageVersion()}</version>");
                writer.WriteLine("<authors>Amazon Web Services</authors>");
                writer.WriteLine("<description>The Amazon Web Services SDK for .NET - Core Runtime</description>");
                writer.WriteLine("<language>en-US</language>");
                writer.WriteLine("""<license type="expression">Apache-2.0</license>""");
                writer.WriteLine("<projectUrl>https://github.com/aws/aws-sdk-net/</projectUrl>");
                writer.WriteLine("<tags>AWS Amazon cloud aws-sdk-v4</tags>");
                writer.WriteLine("""<icon>images\AWSLogo.png</icon>""");
                writer.OpenXmlBlock("dependencies", () =>
                {
                    foreach (var platform in TargetPlatforms.Platforms)
                    {
                        writer.WriteXmlBlock($"""<group targetFramework="{platform.Tfm}">""", "group", () =>
                        {
                            foreach (var dependency in CoreNuspecDependencies.For(platform.Tfm))
                            {
                                writer.WriteLine($"""<dependency id="{dependency.Id}" version="{dependency.Version}" />""");
                            }
                        });
                    }
                });
            });
            writer.OpenXmlBlock("files", () =>
            {
                writer.WriteLine("""<file src="..\..\nuget-content\AWSLogo.png" target="images\" />""");
                writer.WriteLine("""<file src="..\..\nuget-content\account-management.ps1" target="tools" />""");
                foreach (var platform in TargetPlatforms.Platforms)
                {
                    foreach (var extension in new[] { "dll", "xml", "pdb" })
                    {
                        writer.WriteLine($"""<file src=".\bin\Release\{platform.Tfm}\AWSSDK.Core.{extension}" target="lib\{platform.Tfm}" />""");
                    }
                }
            });
        });
        return writer.ToRawString().TrimEnd();
    }
}
