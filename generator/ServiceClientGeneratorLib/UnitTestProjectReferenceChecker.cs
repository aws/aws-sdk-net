using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ServiceClientGenerator
{
    public class UnitTestProjectReferenceChecker
    {
        const string VS_NAMESPACE = "http://schemas.microsoft.com/developer/msbuild/2003";

        public UnitTestProjectReferenceChecker()
        {
            XmlDocument unitTestProject = new XmlDocument();
            this.NamespaceManager = new System.Xml.XmlNamespaceManager(unitTestProject.NameTable);
            this.NamespaceManager.AddNamespace("vs", "http://schemas.microsoft.com/developer/msbuild/2003");
        }

        XmlNamespaceManager NamespaceManager { get; set; }


        string _projectFile;
        public string ProjectFilePath 
        {
            get { return this._projectFile; }
            set
            {
                this._projectFile = value;
                this._projectFileXml = null;
            }
        }

        XmlDocument _projectFileXml;
        public XmlDocument ProjectFileXml
        {
            get
            {
                if (this._projectFileXml == null)
                {
                    this._projectFileXml = new XmlDocument();
                    this._projectFileXml.Load(this.ProjectFilePath);
                }

                return this._projectFileXml;
            }
        }

        public string ServiceRoot
        {
            get;
            set;
        }

        public void Execute()
        {
            var existingGuids = FetchExistingProjectGuids();
            var rootServiceItemGroup = FindRootItemGroupForServices();

            var searchPattern = "*." + ProjectSuffix() + ".csproj";

            bool changed = false;
            foreach (var projectFile in Directory.GetFiles(ServiceRoot, searchPattern, SearchOption.AllDirectories))
            {
                var guid = ExtractProjectGuid(projectFile);
                if (!existingGuids.Contains(guid))
                {
                    Console.WriteLine("Adding reference to unit test project {0} : {1}",
                        Path.GetFileName(this.ProjectFilePath),
                        Path.GetFileName(projectFile));

                    AddServiceReference(rootServiceItemGroup, projectFile, guid);
                    changed = true;
                }
            }

            if (changed)
            {
                this._projectFileXml.Save(this.ProjectFilePath);
                Console.WriteLine("Writing new version of project file {0}", Path.GetFileName(this.ProjectFilePath));
            }
        }

        void AddServiceReference(XmlElement itemGroupNode, string projectFile, string guid)
        {
            var pathTokens = projectFile.Split('\\');
            string relativePath = string.Format(@"..\..\src\Services\{0}\{1}", pathTokens[pathTokens.Length - 2], Path.GetFileName(projectFile));

            var projectReference = itemGroupNode.OwnerDocument.CreateElement("ProjectReference", VS_NAMESPACE);
            projectReference.SetAttribute("Include", relativePath);

            var project = itemGroupNode.OwnerDocument.CreateElement("Project", VS_NAMESPACE);
            project.InnerText = guid;

            var name = itemGroupNode.OwnerDocument.CreateElement("Name", VS_NAMESPACE);
            name.InnerText = Path.GetFileNameWithoutExtension(projectFile);

            projectReference.AppendChild(project);
            projectReference.AppendChild(name);
            itemGroupNode.AppendChild(projectReference);
        }


        HashSet<string> FetchExistingProjectGuids()
        {
            HashSet<string> existingProjectGuids = new HashSet<string>();

            foreach (XmlElement node in ProjectFileXml.SelectNodes("//vs:ItemGroup/vs:ProjectReference/vs:Project", NamespaceManager))
            {
                existingProjectGuids.Add(node.InnerText);
            }
            return existingProjectGuids;
        }

        XmlElement FindRootItemGroupForServices()
        {
            var projectFileNameNode =
                ProjectFileXml.SelectSingleNode("//vs:ItemGroup/vs:ProjectReference/vs:Name[contains(., 'AWSSDK.AutoScaling')]", NamespaceManager) as XmlElement;

            var itemGroup = projectFileNameNode.ParentNode.ParentNode as XmlElement;
            return itemGroup;
        }

        string ProjectSuffix()
        {
            var projectFileNameNode =
                ProjectFileXml.SelectSingleNode("//vs:ItemGroup/vs:ProjectReference/vs:Name[contains(., 'AWSSDK.AutoScaling')]", NamespaceManager) as XmlElement;

            var tokens = projectFileNameNode.InnerText.Split('.');
            return tokens[tokens.Length - 1];
        }

        string ExtractProjectGuid(string serviceProjectFile)
        {
            XmlDocument project = new XmlDocument();
            project.Load(serviceProjectFile);

            var projectGuidNode = project.SelectSingleNode("//vs:PropertyGroup/vs:ProjectGuid", NamespaceManager) as XmlElement;
            return projectGuidNode.InnerText;
        }
    }
}
