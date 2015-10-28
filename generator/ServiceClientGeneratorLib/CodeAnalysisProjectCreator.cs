using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceClientGenerator.Generators.CodeAnalysis;

namespace ServiceClientGenerator
{
    public class CodeAnalysisProjectCreator
    {
        public void Execute(string codeAnalysisRoot, ServiceConfiguration serviceConfiguration)
        {
            SetupProjectFile(codeAnalysisRoot, serviceConfiguration);
            SetupPackageConfigFile(codeAnalysisRoot, serviceConfiguration);
            GenerateAssemblyInfo(codeAnalysisRoot, serviceConfiguration);
            GenerateProperyValueRules(codeAnalysisRoot, serviceConfiguration);
            GenerateProperyValueAnalyzer(codeAnalysisRoot, serviceConfiguration);
        }

        void SetupProjectFile(string codeAnalysisRoot, ServiceConfiguration serviceConfiguration)
        {
            var assemblyName = "AWSSDK." + serviceConfiguration.Namespace.Split('.')[1] + ".CodeAnalysis";
            var projectFilename = string.Concat(assemblyName, ".csproj");
            string projectGuid;
            if (File.Exists(Path.Combine(codeAnalysisRoot, projectFilename)))
            {
                Console.WriteLine("...updating existing project file {0}", projectFilename);
                var projectPath = Path.Combine(codeAnalysisRoot, projectFilename);
                projectGuid = Utils.GetProjectGuid(projectPath);
            }
            else
            {
                projectGuid = Utils.NewProjectGuid;
                Console.WriteLine("...creating project file {0}", projectFilename);
            }

            var templateSession = new Dictionary<string, object>();

            templateSession["ProjectGuid"] = projectGuid;
            templateSession["RootNamespace"] = serviceConfiguration.Namespace + ".CodeAnalysis";
            templateSession["AssemblyName"] = assemblyName;
            templateSession["SourceDirectories"] = GetProjectSourceFolders(codeAnalysisRoot);

            CodeAnalysisProjectFile generator = new CodeAnalysisProjectFile();
            generator.Session = templateSession;
            var generatedContent = generator.TransformText();

            GeneratorDriver.WriteFile(codeAnalysisRoot, string.Empty, projectFilename, generatedContent);
        }

        private void SetupPackageConfigFile(string codeAnalysisRoot, ServiceConfiguration serviceConfiguration)
        {
            CodeAnalysisPackages generator = new CodeAnalysisPackages();
            var generatedContent = generator.TransformText();
            GeneratorDriver.WriteFile(codeAnalysisRoot, string.Empty, "packages.config", generatedContent);
        }

        private void GenerateAssemblyInfo(string codeAnalysisRoot, ServiceConfiguration serviceConfiguration)
        {
            var generator = new CodeAnalysisAssemblyInfo { Config = serviceConfiguration };
            var text = generator.TransformText();
            GeneratorDriver.WriteFile(codeAnalysisRoot, "Properties", "AssemblyInfo.cs", text);
        }

        private void GenerateProperyValueRules(string codeAnalysisRoot, ServiceConfiguration serviceConfiguration)
        {
            var content = "stuff";
            GeneratorDriver.WriteFile(Path.Combine(codeAnalysisRoot, "Generated"), string.Empty, "PropertyValueRules.xml", content);
        }

        private void GenerateProperyValueAnalyzer(string codeAnalysisRoot, ServiceConfiguration serviceConfiguration)
        {
            var generator = new PropertyValueAssignmentAnalyzer { Config = serviceConfiguration };
            var text = generator.TransformText();
            GeneratorDriver.WriteFile(codeAnalysisRoot, "Generated", "PropertyValueAssignmentAnalyzer.cs", text);
        }




        private IList<string> GetProjectSourceFolders(string codeAnalysisRoot)
        {
            // Start with the standard generated code folders for the platform
            var sourceCodeFolders = new List<string>
            {
                "Generated"
            };

            // Augment the returned folders with any custom subfolders already in existence. If the custom folder 
            // ends with a recognised platform, only add it to the set if it matches the platform being generated
            if (Directory.Exists(codeAnalysisRoot))
            {
                var subFolders = Directory.GetDirectories(codeAnalysisRoot, "*", SearchOption.AllDirectories);
                if (subFolders.Any())
                {
                    foreach (var folder in subFolders)
                    {
                        var serviceRelativeFolder = folder.Substring(codeAnalysisRoot.Length);

                        if (!serviceRelativeFolder.StartsWith(@"\Custom", StringComparison.OrdinalIgnoreCase))
                            continue;

                        sourceCodeFolders.Add(serviceRelativeFolder.TrimStart('\\'));
                    }
                }
            }

            var foldersThatExist = new List<string>();
            foreach (var folder in sourceCodeFolders)
            {
                if (Directory.Exists(Path.Combine(codeAnalysisRoot, folder)))
                    foldersThatExist.Add(folder);
            }

            // sort so we get a predictable layout
            foldersThatExist.Sort(StringComparer.OrdinalIgnoreCase);
            return foldersThatExist;
        }
    }
}
