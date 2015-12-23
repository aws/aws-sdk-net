using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
            if (!Directory.Exists(codeAnalysisRoot))
                Directory.CreateDirectory(codeAnalysisRoot);

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
            templateSession["EmbeddedResources"] = GetEmbeddedResources(codeAnalysisRoot);

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
            StringBuilder sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb, new XmlWriterSettings {Indent = true }))
            {
                writer.WriteStartElement("property-value-rules");

                if (!string.Equals(serviceConfiguration.BaseName, "S3", StringComparison.InvariantCultureIgnoreCase))
                {

                    HashSet<string> requestAndResponseShapes = new HashSet<string>();
                    foreach (var operation in serviceConfiguration.ServiceModel.Operations)
                    {
                        if (operation.RequestStructure != null)
                        {
                            GenerateProperyValueRules(serviceConfiguration, writer, operation.Name + "Request", operation.RequestStructure);
                            requestAndResponseShapes.Add(operation.RequestStructure.Name);
                        }
                        if (operation.ResponseStructure != null)
                        {
                            GenerateProperyValueRules(serviceConfiguration, writer, operation.Name + "Response", operation.ResponseStructure);
                            requestAndResponseShapes.Add(operation.ResponseStructure.Name);
                        }
                    }

                    foreach (var shape in serviceConfiguration.ServiceModel.Shapes.OrderBy(x => x.Name))
                    {
                        if (requestAndResponseShapes.Contains(shape.Name))
                            continue;

                        if (shape.IsStructure)
                        {
                            GenerateProperyValueRules(serviceConfiguration, writer, shape.Name, shape);
                        }
                    }
                }
                writer.WriteEndElement();
            }
            var content = sb.ToString();
            GeneratorDriver.WriteFile(Path.Combine(codeAnalysisRoot, "Generated"), string.Empty, "PropertyValueRules.xml", content);
        }

        private void GenerateProperyValueRules(ServiceConfiguration serviceConfiguration, XmlWriter writer, string shapeName, Shape shape)
        {
            foreach (var member in shape.Members)
            {
                var memberShape = member.Shape;
                if (!memberShape.IsPrimitiveType)
                    continue;

                if (memberShape.Min == null && memberShape.Max == null && memberShape.Pattern == null)
                    continue;

                writer.WriteStartElement("property-value-rule");

                var propertyName = string.Format("{0}.Model.{1}.{2}", serviceConfiguration.Namespace, shapeName, member.PropertyName);
                writer.WriteElementString("property", propertyName);

                if (memberShape.Min != null)
                    writer.WriteElementString("min", memberShape.Min.Value.ToString());

                if (memberShape.Max != null)
                    writer.WriteElementString("max", memberShape.Max.Value.ToString());

                if (memberShape.Pattern != null)
                {
                    try
                    {
                        // Make sure we can compile the expression
                        new System.Text.RegularExpressions.Regex(memberShape.Pattern);
                        writer.WriteElementString("pattern", memberShape.Pattern);
                    }
                    catch(Exception e)
                    {
                        Console.Error.WriteLine("Failed to compile regex {0} for property {1}: {2}", memberShape.Pattern, propertyName, e.Message);
                    }
                }

                writer.WriteEndElement();
            }
        }

        private void GenerateProperyValueAnalyzer(string codeAnalysisRoot, ServiceConfiguration serviceConfiguration)
        {
            var generator = new PropertyValueAssignmentAnalyzer { Config = serviceConfiguration };
            var text = generator.TransformText();
            GeneratorDriver.WriteFile(codeAnalysisRoot, "Generated", "PropertyValueAssignmentAnalyzer.cs", text);
        }


        private IList<string> GetEmbeddedResources(string codeAnalysisRoot)
        {
            var embeddedResources = new List<string>();

            foreach(var file in Directory.GetFiles(codeAnalysisRoot, "*.xml", SearchOption.AllDirectories))
            {
                var relativePath = file.Substring(codeAnalysisRoot.Length);
                if (!relativePath.StartsWith(@"\Custom", StringComparison.OrdinalIgnoreCase))
                    continue;

                embeddedResources.Add(relativePath.TrimStart('\\'));
            }

            return embeddedResources;
        }

        private IList<string> GetProjectSourceFolders(string codeAnalysisRoot)
        {
            // Start with the standard generated code folders for the platform
            var sourceCodeFolders = new List<string>
            {
                "Generated"
            };

            if (Directory.Exists(codeAnalysisRoot))
            {
                var subFolders = Directory.GetDirectories(codeAnalysisRoot, "*", SearchOption.AllDirectories);
                foreach (var folder in subFolders)
                {
                    var serviceRelativeFolder = folder.Substring(codeAnalysisRoot.Length);

                    if (!serviceRelativeFolder.StartsWith(@"\Custom", StringComparison.OrdinalIgnoreCase))
                        continue;

                    sourceCodeFolders.Add(serviceRelativeFolder.TrimStart('\\'));
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
