using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceClientGenerator.Generators.CodeAnalysis;

namespace ServiceClientGenerator
{
    public class CodeAnalysisSolutionCreator
    {
        public GeneratorOptions Options { get; set; }
        const string projectTypeWildCard = "AWSSDK.*.csproj";

        public void Execute()
        {
            var codeAnalysisProjects = GetListOfCodeAnalysisProjects();

            if (Options.CreateCodeAnalysisVsixAssets)
            {
                GenerateVsixProject(codeAnalysisProjects);
                GenerateVsixManifest(codeAnalysisProjects);
            }

            GenerateSolutionFile(codeAnalysisProjects);
        }

        public void GenerateSolutionFile(List<Project> codeAnalysisProjects)
        {
            var templateSession = new Dictionary<string, object>();

            templateSession["CodeAnalysisProjects"] = codeAnalysisProjects;

            CodeAnalysisSolutionFile generator = new CodeAnalysisSolutionFile();
            generator.Session = templateSession;
            var generatedContent = generator.TransformText();

            GeneratorDriver.WriteFile(Options.SdkRootFolder, string.Empty, "AWSSDK.CodeAnalysis.sln", generatedContent, false, false);
        }

        public void GenerateVsixProject(List<Project> codeAnalysisProjects)
        {
            var templateSession = new Dictionary<string, object>();

            templateSession["CodeAnalysisProjects"] = codeAnalysisProjects;

            var generator = new VsixTestProfileFile();
            generator.Session = templateSession;
            var generatedContent = generator.TransformText();

            GeneratorDriver.WriteFile(Utils.PathCombineAlt(Options.SdkRootFolder, GeneratorDriver.CodeAnalysisFoldername), "AWSCodeAnalysisTestExtension", "AWSCodeAnalysisTestExtension.Vsix.csproj", generatedContent, false, false);
        }

        public void GenerateVsixManifest(List<Project> codeAnalysisProjects)
        {
            var templateSession = new Dictionary<string, object>();

            templateSession["CodeAnalysisProjects"] = codeAnalysisProjects;

            var generator = new VsixManifest();
            generator.Session = templateSession;
            var generatedContent = generator.TransformText();

            GeneratorDriver.WriteFile(Utils.PathCombineAlt(Options.SdkRootFolder, GeneratorDriver.CodeAnalysisFoldername), "AWSCodeAnalysisTestExtension", "source.extension.vsixmanifest", generatedContent, false, false);
        }


        public List<Project> GetListOfCodeAnalysisProjects()
        {
            List<Project> projects = new List<Project>();
            var codeAnalysisProjectsRoot = Utils.PathCombineAlt(Options.SdkRootFolder, GeneratorDriver.CodeAnalysisFoldername);
            foreach (var projectFile in Directory.GetFiles(codeAnalysisProjectsRoot, projectTypeWildCard, SearchOption.AllDirectories).OrderBy(f => f))
            {
                var fullPath = Utils.ConvertPathAlt(Path.GetFullPath(projectFile));
                var relativePath = fullPath.Substring(fullPath.IndexOf("code-analysis"));

                var projectNameInSolution = 
                    Path.GetFileNameWithoutExtension(projectFile);

                var project = new Project
                {
                    Name =  projectNameInSolution,
                    ShortName = projectNameInSolution.Replace("AWSSDK.", "").Replace(".CodeAnalysis", ""),
                    ProjectGuid = Utils.GetProjectGuid(projectFile),
                    ProjectPath = relativePath
                };
                projects.Add(project);
            }

            return projects;
        }


        public class Project
        {
            public string ProjectGuid { get; set; }
            public string ProjectPath { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }
    }
}
