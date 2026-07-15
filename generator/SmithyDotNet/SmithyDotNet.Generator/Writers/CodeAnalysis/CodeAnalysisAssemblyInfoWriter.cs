using SmithyDotNet.Generator.Generation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmithyDotNet.Generator.Writers.CodeAnalysis;

public class CodeAnalysisAssemblyInfoWriter(GenerationContext context)
{
    public string Write()
    {
        var writer = new CodeWriter();
        FileHeader.WriteUsings(writer, FileHeader.CodeAnalysisAssemblyInfoUsings);

        writer.WriteComment("General Information about an assembly is controlled through the following ");
        writer.WriteComment("set of attributes. Change these attribute values to modify the information");
        writer.WriteComment("associated with an assembly.");

        writer.WriteLine($"""[assembly: AssemblyTitle("{context.AssemblyName}")]""");
        writer.WriteLine($"""[assembly: AssemblyDescription("Code analysis project file for AWSSDK.{context.ServiceName}")]""");
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
        writer.WriteComment("\tMajor Version");
        writer.WriteComment("\tMinor Version");
        writer.WriteComment("\tBuild Number");
        writer.WriteComment("\tRevision");

        writer.WriteComment();
        writer.WriteComment("You can specify all the values or you can default the Build and Revision Numbers");
        writer.WriteComment("by using the '*' as shown below:");
        writer.WriteComment("""[assembly: AssemblyVersion("1.0.*")]""");

        var serviceManifest = context.Manifest.ServiceVersions[context.ServiceName];
        writer.WriteLine($"""[assembly: AssemblyVersion("{serviceManifest.AssemblyVersionOverride ?? serviceManifest.Version}")]""");
        writer.WriteLine($"""[assembly: AssemblyFileVersion("{serviceManifest.Version}")]""");
        return writer.ToRawString();
    }
}
