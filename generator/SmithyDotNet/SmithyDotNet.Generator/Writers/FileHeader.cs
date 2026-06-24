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
        "Amazon.Runtime.Internal.Util"
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
    public static void WriteUsings(CodeWriter writer, IReadOnlyList<string> namespaces)
    {
        foreach (var ns in namespaces)
        {
            writer.WriteLine($"using {ns};");
        }

        writer.WriteLine();
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
