using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Describes a Project file to be generated
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Name of the project template configuration
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Used to generate the AssemblyName element of the project file
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// Used to generate the ProjectReference elements of the project file
        /// </summary>
        public IEnumerable<ProjectFileCreator.ProjectReference> ProjectReferences { get; set; }

        /// <summary>
        /// Used to generate the Include tag of the Reference elements of the project file
        /// </summary>
        public IEnumerable<Dependency> ReferenceDependencies { get; set; }

        /// <summary>
        /// Used to generate the PackageReference elements of the project file
        /// </summary>
        public IEnumerable<ProjectFileCreator.PackageReference> PackageReferences { get; set; }

        /// <summary>
        /// Used to generate the Include tag of the Service elements of the project file
        /// </summary>
        public IEnumerable<string> Services { get; set; }

        /// <summary>
        /// Used to generate the HintPath for Reference elements relative to Nuget dependencies
        /// </summary>
        public string NugetPackagesLocation { get; set; }

        /// <summary>
        /// Used to generate the TargetFramework or TargetFrameworks element of the project file
        /// </summary>
        public IEnumerable<string> TargetFrameworks { get; set; }

        /// <summary>
        /// Used to generate the DefineConstants element of the project file
        /// </summary>
        public IEnumerable<string> DefineConstants { get; set; }

        /// <summary>
        /// Used to generate the Remove tag of the Compile elements of the project file
        /// </summary>
        public IEnumerable<string> CompileRemoveList { get; set; }

        /// <summary>
        /// Used to generate the Include tag of the Compile elements of the project file for directories
        /// </summary>
        public IEnumerable<string> SourceDirectories { get; set; }

        /// <summary>
        /// Used to generate the Include tag of the Compile elements of the project file for single files
        /// </summary>
        public IEnumerable<string> IndividualFileIncludes { get; set; }

        /// <summary>
        /// Used to generate the Include tag of the EmbeddedResource elements of the project file
        /// </summary>
        public IEnumerable<string> EmbeddedResources { get; set; }

        /// <summary>
        /// Used to generate the FrameworkPathOverride element of the project file
        /// </summary>
        public string FrameworkPathOverride { get; set; }

        /// <summary>
        /// Used to generate the OutputPath element of the project file
        /// </summary>
        public string OutputPathOverride { get; set; }

        /// <summary>
        /// Used to generate the NoWarn element of the project file
        /// </summary>
        public string SupressWarnings { get; set; }

        /// <summary>
        /// Used to generate the ProjectGuid element of the project file
        /// </summary>
        public string ProjectGuid { get; set; }

        /// <summary>
        /// Used to generate the RootNamespace element of the project file
        /// </summary>
        public string RootNamespace { get; set; }

        /// <summary>
        /// Used to decide wether to generate the AssemblyOriginatorKeyFile element of the project file
        /// </summary>
        public bool SignBinaries { get; set; }

        /// <summary>
        /// Used to generate the AssemblyOriginatorKeyFile element of the project file
        /// </summary>
        public string KeyFilePath { get; set; }

        /// <summary>
        /// Used to generate the OutputPath element of the project file
        /// </summary>
        public string BinSubfolder { get; set; }

        /// <summary>
        /// Used to generate the RuleSet path of the project file
        /// </summary>
        public string FxcopAnalyzerRuleSetFilePath { get; set; }

        /// <summary>
        /// Used to generate the RuleSet path for build of the project file
        /// </summary>
        public string FxcopAnalyzerRuleSetFilePathForBuild { get; set; }

        /// <summary>
        /// Used to generate the Custom Roslyn Analyzers dll directory
        /// </summary>
        public string CustomRoslynAnalyzersDllDirectory { get; set; }
    }
}
