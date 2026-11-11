using SmithyDotNet.Generator.Generation.ProjectFiles;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the prologue of a generated source file. The license block and generation notice
/// are identical across all generated files; the using directives and warning-suppression
/// pragma vary by file kind, so the caller supplies those.
/// </summary>
public static class FileHeader
{
    // The public half of sdk/awssdk.dll.snk, which signs every SDK assembly.
    private const string SdkPublicKey = "0024000004800000940000000602000000240000525341310004000001000100db5f59f098d27276c7833875a6263a3cc74ab17ba9a9df0b52aedbe7252745db7274d5271fd79c1f08f668ecfa8eaab5626fa76adc811d3c8fc55859b0d09d3bc0a84eecd0ba891f2b8a2fc55141cdcc37c2053d53491e650a479967c3622762977900eddbf1252ed08a2413f00a28f3a0752a81203f03ccb7f684db373518b4";

    /// <summary>
    /// The default warning codes suppressed in model-level generated files.
    /// </summary>
    public static IReadOnlyList<string> ModelWarnings { get; } = ["CS0612", "CS0618", "CS1570"];

    /// <summary>
    /// The default warning codes suppressed in marshaller-level generated files.
    /// </summary>
    public static IReadOnlyList<string> MarshallerWarnings { get; } = ["CS0612", "CS0618"];

    /// <summary>
    /// Usings for model-level files (structures, exceptions, request/response).
    /// </summary>
    public static IReadOnlyList<string> ModelUsings { get; } =
    [
        "System",
        "System.Collections.Generic",
        "System.Xml.Serialization",
        "System.Text",
        "System.IO",
        "System.Net",
        "Amazon.Runtime",
        "Amazon.Runtime.Internal",
    ];

    /// <summary>
    /// Event-stream-specific usings for the response event-stream class, appended to
    /// <see cref="ModelUsings"/>. The caller also emits the service's <c>.Model.Internal.MarshallTransformations</c>
    /// namespace (dynamic, so not a constant here).
    /// </summary>
    public static IReadOnlyList<string> EventStreamOutputUsings { get; } =
    [
        "Amazon.Runtime.EventStreams",
        "Amazon.Runtime.EventStreams.Internal",
        "Amazon.Runtime.EventStreams.Utils",
        "Amazon.Runtime.Internal.Util",
    ];

    /// <summary>
    /// Usings for the request event-stream publisher marshaller. Order matches C2J's
    /// <c>EventStreamPublisherMarshaller</c> so the emitted <c>using</c> block is identical.
    /// </summary>
    public static IReadOnlyList<string> EventStreamPublisherUsings { get; } =
    [
        "System",
        "System.IO",
        "System.Threading.Tasks",
        "Amazon.Runtime.EventStreams",
        "System.Collections.Generic",
    ];

    /// <summary>
    /// Usings for paginator files (class, interface, and factory).
    /// </summary>
    public static IReadOnlyList<string> PaginatorUsings { get; } =
    [
        "System",
        "System.Collections.Generic",
        "System.Threading",
        "System.Threading.Tasks",
        "Amazon.Runtime",
        "Amazon.Runtime.Internal",
    ];

    /// <summary>
    /// Usings for marshaller files. These usings should be combined with the base-level ModelUsings
    /// </summary>
    public static IReadOnlyList<string> MarshallerUsings { get; } =
    [
        "Amazon.Runtime.Internal.Transform",
        "Amazon.Runtime.Internal.Util",
    ];

    /// <summary>
    /// Added to <see cref="MarshallerUsings"/> for rpcv2Cbor marshallers.
    /// </summary>
    public static IReadOnlyList<string> CborMarshallerUsings { get; } =
    [
        "Amazon.Extensions.CborProtocol",
        "Amazon.Extensions.CborProtocol.Internal",
        "Amazon.Extensions.CborProtocol.Internal.Transform",
    ];

    /// <summary>
    /// Added to <see cref="MarshallerUsings"/> for rpcv2Cbor unmarshallers.
    /// </summary>
    public static IReadOnlyList<string> CborUnmarshallerUsings { get; } =
    [
        "System.Formats.Cbor",
        "Amazon.Extensions.CborProtocol.Internal.Transform",
    ];

    /// <summary>
    /// Usings for the exception (error-response) unmarshaller file. Carries
    /// <c>System.Globalization</c>, which the shared <see cref="ModelUsings"/> omit, to match the
    /// legacy generated output verbatim.
    /// </summary>
    public static IReadOnlyList<string> ExceptionUnmarshallerUsings { get; } =
    [
        "System",
        "System.Collections.Generic",
        "System.Globalization",
        "System.IO",
        "System.Net",
        "System.Text",
        "System.Xml.Serialization",
    ];

    /// <summary>
    /// Usings for the endpoint parameters file.
    /// </summary>
    public static IReadOnlyList<string> EndpointParametersUsings { get; } =
    [
        "System.Collections.Generic",
        "Amazon.Runtime",
        "Amazon.Runtime.Endpoints",
    ];

    /// <summary>
    /// Usings for the endpoint provider file. The static import brings in the rules-engine
    /// standard library (<c>IsSet</c>, <c>Equals</c>, <c>Partition</c>, ...) the compiled rules call.
    /// </summary>
    public static IReadOnlyList<string> EndpointProviderUsings { get; } =
    [
        "System",
        "System.Collections.Generic",
        "Amazon.Runtime",
        "Amazon.Runtime.Endpoints",
        "static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn",
    ];

    /// <summary>
    /// Usings for the endpoint provider tests file. Callers append the service's
    /// <c>*.Endpoints</c> and <c>*.Internal</c> namespaces for the parameters and provider types.
    /// </summary>
    public static IReadOnlyList<string> EndpointProviderTestsUsings { get; } =
    [
        "Microsoft.VisualStudio.TestTools.UnitTesting",
        "System.Collections.Generic",
        "Amazon.Runtime",
    ];

    /// <summary>
    /// Usings for the <c>simpleConstructors</c> tests file. The caller appends the service namespace
    /// and its <c>.Model</c> namespace.
    /// </summary>
    public static IReadOnlyList<string> SimpleConstructorTestsUsings { get; } =
    [
        "System.Collections.Generic",
        "System.IO",
        "Microsoft.VisualStudio.TestTools.UnitTesting",
    ];

    /// <summary>
    /// Usings for the <c>simpleMethods</c> tests file. The caller appends, as a second group, the
    /// service's <c>.Model</c> namespace and the service namespace.
    /// </summary>
    public static IReadOnlyList<string> SimpleMethodTestsUsings { get; } =
    [
        "System",
        "System.Collections.Generic",
        "System.IO",
        "System.Linq",
        "System.Text",
        "Microsoft.VisualStudio.TestTools.UnitTesting",
    ];

    /// <summary>
    /// Usings for the auth resolver file: the runtime, auth, and identity namespaces the resolver references.
    /// </summary>
    public static IReadOnlyList<string> AuthResolverUsings { get; } =
    [
        "Amazon.Runtime",
        "Amazon.Runtime.Credentials.Internal",
        "Amazon.Runtime.Internal",
        "Amazon.Runtime.Internal.Auth",
        "Amazon.Runtime.Identity",
        "System.Collections.Generic",
    ];

    // these three exist in marshallers today but are unused so far. if future marshallers need them, add them back.
    // "System.Xml.Serialization",
    // "System.Globalization",
    // "System.Text"
    /// <summary>
    /// Usings for Json Request Marshaller files. Used individually for JsonRequest Marshallers
    /// </summary>
    public static IReadOnlyList<string> JsonRequestMarshallerUsings { get; } =
    [
        "System",
        "System.Collections.Generic",
        "System.IO",
        "Amazon.Runtime",
        "Amazon.Runtime.Internal",
        "Amazon.Runtime.Internal.Transform",
        "Amazon.Runtime.Internal.Util",
        "System.Text.Json",
        "System.Buffers",
    ];

    /// <summary>
    /// Usings for restXml request marshaller files.
    /// </summary>
    public static IReadOnlyList<string> XmlRequestMarshallerUsings { get; } =
    [
        "System",
        "System.Collections.Generic",
        "System.Globalization",
        "System.IO",
        "System.Text",
        "System.Xml",
        "Amazon.Runtime",
        "Amazon.Runtime.Internal",
        "Amazon.Runtime.Internal.Transform",
        "Amazon.Runtime.Internal.Util",
    ];

    /// <summary>
    /// Usings for awsQuery request marshaller files. The request body is URL-encoded form parameters
    /// (no XML writer), so this drops <c>System.Xml</c>/<c>System.Text</c> from the restXml set.
    /// </summary>
    public static IReadOnlyList<string> QueryRequestMarshallerUsings { get; } =
    [
        "System",
        "System.Collections.Generic",
        "System.Globalization",
        "System.IO",
        "Amazon.Runtime",
        "Amazon.Runtime.Internal",
        "Amazon.Runtime.Internal.Transform",
        "Amazon.Runtime.Internal.Util",
    ];

    /// <summary>
    /// Usings for the default-configuration file.
    /// </summary>
    public static IReadOnlyList<string> DefaultConfigurationUsings { get; } =
    [
        "System",
        "System.Collections.Generic",
        "System.Collections.ObjectModel",
        "Amazon.Runtime",
    ];

    public static IReadOnlyList<string> NullCollectionInitializerAnalyzerUsings { get; } =
    [
        "Microsoft.CodeAnalysis",
        "Microsoft.CodeAnalysis.Diagnostics",
        "Amazon.CodeAnalysis.Shared"
    ];

    public static IReadOnlyList<string> PropertyValueAssignmentAnalyzerUsings { get; } =
    [
        "System",
        "System.Collections.Generic",
        "System.Collections.Immutable",
        "System.Reflection",
        "System.Linq",
        "System.Xml.Linq",
        "System.Threading",
        "Microsoft.CodeAnalysis",
        "Microsoft.CodeAnalysis.CSharp",
        "Microsoft.CodeAnalysis.CSharp.Syntax",
        "Microsoft.CodeAnalysis.Diagnostics",
        "Amazon.CodeAnalysis.Shared"
    ];

    public static IReadOnlyList<string> CodeAnalysisAssemblyInfoUsings { get; } =
    [
        "System.Reflection",
        "System.Runtime.InteropServices"
    ];

    /// <summary>
    /// Usings for the service-enumerations file.
    /// </summary>
    public static IReadOnlyList<string> ServiceEnumerationsUsings { get; } =
    [
        "System",
        "Amazon.Runtime",
    ];

    /// <summary>
    /// Usings for the service <c>AssemblyInfo.cs</c> file.
    /// </summary>
    public static IReadOnlyList<string> AssemblyInfoUsings { get; } =
    [
        "System",
        "System.Reflection",
        "System.Runtime.InteropServices",
        "System.Runtime.CompilerServices",
    ];

    /// <summary>
    /// Writes the shared assembly attribute body that appears in the service, code-analysis and Core
    /// <c>AssemblyInfo.cs</c> files: the title, configuration, product, company,
    /// copyright, trademark, culture, ComVisible, and version attributes. The caller supplies
    /// an <paramref name="assemblyDescription"/> action to emit the description attribute(s),
    /// since the service file uses a platform-conditional <c>#if</c> chain while the
    /// code-analysis file uses a static string.
    /// </summary>
    public static void WriteAssemblyInfoBody(
        CodeWriter writer,
        string assemblyName,
        Action<CodeWriter> assemblyDescription,
        string assemblyVersion,
        string fileVersion)
    {
        writer.WriteComment("General Information about an assembly is controlled through the following ");
        writer.WriteComment("set of attributes. Change these attribute values to modify the information");
        writer.WriteComment("associated with an assembly.");

        writer.WriteLine($"""[assembly: AssemblyTitle("{assemblyName}")]""");

        assemblyDescription(writer);

        writer.WriteLine("""[assembly: AssemblyConfiguration("")]""");
        writer.WriteLine("""[assembly: AssemblyProduct("Amazon Web Services SDK for .NET")]""");
        writer.WriteLine("""[assembly: AssemblyCompany("Amazon.com, Inc")]""");
        writer.WriteLine("""[assembly: AssemblyCopyright("Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.")]""");
        writer.WriteLine("""[assembly: AssemblyTrademark("")]""");
        writer.WriteLine("""[assembly: AssemblyCulture("")]""");
        writer.WriteLine();

        writer.WriteComment("Setting ComVisible to false makes the types in this assembly not visible");
        writer.WriteComment("to COM components.  If you need to access a type in this assembly from");
        writer.WriteComment("COM, set the ComVisible attribute to true on that type.");

        writer.WriteLine("[assembly: ComVisible(false)]");
        writer.WriteLine();
        writer.WriteComment("Version information for an assembly consists of the following four values:");
        writer.WriteComment();
        writer.WriteComment("     Major Version");
        writer.WriteComment("     Minor Version ");
        writer.WriteComment("     Build Number");
        writer.WriteComment("     Revision");

        writer.WriteComment();
        writer.WriteComment("You can specify all the values or you can default the Build and Revision Numbers ");
        writer.WriteComment("by using the '*' as shown below:");
        writer.WriteComment("""[assembly: AssemblyVersion("1.0.*")]""");

        writer.WriteLine($"""[assembly: AssemblyVersion("{assemblyVersion}")]""");
        writer.WriteLine($"""[assembly: AssemblyFileVersion("{fileVersion}")]""");
    }

    /// <summary>Writes the <c>#if</c> chain giving each target platform its <paramref name="description"/>.</summary>
    public static void WritePlatformDescriptions(CodeWriter writer, Func<string, string> description)
    {
        var platforms = TargetPlatforms.Platforms;
        for (var i = 0; i < platforms.Count; i++)
        {
            var platform = platforms[i];
            var directive = i == 0 ? "#if" : "#elif";
            writer.WriteLine($"{directive} {platform.Symbol}");
            writer.WriteLine($"""[assembly: AssemblyDescription("{description(platform.Label)}")]""");
        }

        writer.WriteLine("#else");
        writer.WriteLine("#error Unknown platform constant - unable to set correct AssemblyDescription");
        writer.WriteLine("#endif");
    }

    /// <summary>
    /// Writes an <c>[InternalsVisibleTo]</c> per assembly, signed with the SDK's key unless the entry names its own.
    /// </summary>
    public static void WriteInternalsVisibleTo(CodeWriter writer, IReadOnlyList<string> assemblies)
    {
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

    /// <summary>
    /// Writes the Apache 2.0 license block and the "do not modify" generation notice,
    /// referencing <paramref name="modelFileName"/>.
    /// </summary>
    public static void WriteLicense(CodeWriter writer, string modelFileName) =>
        WriteLicenseWithNotice(writer, $"This file is generated from the {modelFileName} service model.");

    /// <summary>Writes the Apache 2.0 license block and a "do not modify" notice ending in <paramref name="notice"/>.</summary>
    public static void WriteLicenseWithNotice(CodeWriter writer, string notice)
    {
        writer.WriteLine("/*");
        writer.WriteLine(" * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.");
        writer.WriteLine(" * ");
        writer.WriteLine(" * Licensed under the Apache License, Version 2.0 (the \"License\").");
        writer.WriteLine(" * You may not use this file except in compliance with the License.");
        writer.WriteLine(" * A copy of the License is located at");
        writer.WriteLine(" * ");
        writer.WriteLine(" *  http://aws.amazon.com/apache2.0");
        writer.WriteLine(" * ");
        writer.WriteLine(" * or in the \"license\" file accompanying this file. This file is distributed");
        writer.WriteLine(" * on an \"AS IS\" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either");
        writer.WriteLine(" * express or implied. See the License for the specific language governing");
        writer.WriteLine(" * permissions and limitations under the License.");
        writer.WriteLine(" */");
        writer.WriteLine();
        writer.WriteLine("/*");
        writer.WriteLine($" * Do not modify this file. {notice}");
        writer.WriteLine(" */");
    }

    /// <summary>
    /// Writes the license header of Core's generated files, which C2J's templates carry and the service files don't.
    /// It stays while C2J writes the same files, since both outputs must match.
    /// </summary>
    public static void WriteCoreLicense(CodeWriter writer)
    {
        writer.WriteLine("/*******************************************************************************");
        writer.WriteLine(" *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.");
        writer.WriteLine(""" *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use""");
        writer.WriteLine(" *  this file except in compliance with the License. A copy of the License is located at");
        writer.WriteLine(" *");
        writer.WriteLine(" *  http://aws.amazon.com/apache2.0");
        writer.WriteLine(" *");
        writer.WriteLine(""" *  or in the "license" file accompanying this file.""");
        writer.WriteLine(""" *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR""");
        writer.WriteLine(" *  CONDITIONS OF ANY KIND, either express or implied. See the License for the");
        writer.WriteLine(" *  specific language governing permissions and limitations under the License.");
        writer.WriteLine(" * *****************************************************************************");
        writer.WriteLine(" *    __  _    _  ___");
        writer.WriteLine(""" *   (  )( \/\/ )/ __)""");
        writer.WriteLine(""" *   /__\ \    / \__ \""");
        writer.WriteLine(""" *  (_)(_) \/\/  (___/""");
        writer.WriteLine(" *");
        writer.WriteLine(" *  AWS SDK for .NET");
        writer.WriteLine(" *");
        writer.WriteLine(" */");
    }

    /// <summary>
    /// Writes one <c>using {namespace};</c> directive per entry, in the order given.
    /// </summary>
    public static void WriteUsings(CodeWriter writer, IReadOnlyList<string> namespaces, bool emitTrailingNewLine = true)
    {
        foreach (var ns in namespaces)
        {
            writer.WriteLine($"using {ns};");
        }
        if (emitTrailingNewLine)
        {
            writer.WriteLine();
        }
    }

    /// <summary>
    /// Writes a <c>#pragma warning disable</c> line for the given warning codes
    /// (e.g. <c>CS0612</c>), or nothing when the list is empty.
    /// </summary>
    public static void WritePragma(CodeWriter writer, IReadOnlyList<string> warnings)
    {
        if (warnings.Count == 0)
        {
            return;
        }

        writer.WriteLine($"#pragma warning disable {string.Join(",", warnings)}");
        writer.WriteLine();
    }
}
