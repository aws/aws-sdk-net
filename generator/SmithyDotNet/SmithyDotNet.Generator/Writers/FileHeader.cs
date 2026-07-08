namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the prologue of a generated source file. The license block and generation notice
/// are identical across all generated files; the using directives and warning-suppression
/// pragma vary by file kind, so the caller supplies those.
/// </summary>
public static class FileHeader
{
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
    /// Usings for marshaller files. These usings should be combined with the base-level ModelUsings
    /// </summary>
    public static IReadOnlyList<string> MarshallerUsings { get; } =
    [
        "Amazon.Runtime.Internal.Transform",
        "Amazon.Runtime.Internal.Util",
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
    /// Writes the Apache 2.0 license block and the "do not modify" generation notice,
    /// referencing <paramref name="modelFileName"/>.
    /// </summary>
    public static void WriteLicense(CodeWriter writer, string modelFileName)
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
        writer.WriteLine($" * Do not modify this file. This file is generated from the {modelFileName} service model.");
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
