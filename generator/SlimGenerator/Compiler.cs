using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SlimGenerator
{
    internal static class Compiler
    {
        public static string Compile(string generatedServiceRoot, string outputDllPath, string coreNuGetVersion)
        {
            var outputDir = Path.GetDirectoryName(outputDllPath);
            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);

            var assemblyName = Path.GetFileNameWithoutExtension(outputDllPath);

            var csprojContent = $@"<Project Sdk=""Microsoft.NET.Sdk"">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <DefineConstants>$(DefineConstants);NETSTANDARD;AWS_ASYNC_ENUMERABLES_API</DefineConstants>
    <LangVersion>11.0</LangVersion>
    <OutputType>Library</OutputType>
    <AssemblyName>{assemblyName}</AssemblyName>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>
    <GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>
    <GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>
    <GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>
    <GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>
    <GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>
    <GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>
    <GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>
    <NoWarn>CS0108;CS0114;CS0162;CS0168;CS0169;CS0219;CS0414;CS0612;CS0618;CS0649;CS0693;CS1591;CS1570;CS8600;CS8601;CS8602;CS8603;CS8604;CS8618;CS8625;CS0109;CA1822</NoWarn>
    <SignAssembly>false</SignAssembly>
  </PropertyGroup>
  <ItemGroup>
    <Compile Remove=""**/_bcl/**"" />
    <Compile Remove=""**/obj/**"" />
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include=""AWSSDK.Core"" Version=""{coreNuGetVersion}"" />
  </ItemGroup>
</Project>";

            var csprojPath = Path.Combine(generatedServiceRoot, "Build.csproj");
            File.WriteAllText(csprojPath, csprojContent);

            var psi = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"build \"{csprojPath}\" -c Release -o \"{outputDir}\"",
                WorkingDirectory = generatedServiceRoot,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            var process = Process.Start(psi);
            var stdout = process.StandardOutput.ReadToEnd();
            var stderr = process.StandardError.ReadToEnd();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                Console.Error.WriteLine(stdout);
                Console.Error.WriteLine(stderr);
                throw new InvalidOperationException($"Compilation failed with exit code {process.ExitCode}");
            }

            return outputDllPath;
        }
    }
}
