using System;
using System.Collections.Generic;
using System.IO;
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
            var rootDllReferenceGroup = FindRootDllReferenceGroup();

            var searchPattern = "*." + ProjectSuffix() + ".csproj";

            List<string> assemblyNames = new List<string>();
            List<ServiceProjectRefernece> references = new List<ServiceProjectRefernece>();
            foreach (var projectFile in Directory.GetFiles(ServiceRoot, searchPattern, SearchOption.AllDirectories))
            {
                var guid = ExtractProjectGuid(projectFile);
                references.Add(GetServiceReference(projectFile, guid));
                assemblyNames.Add(ExtractAssemblyName(projectFile));
            }

            assemblyNames.Sort();
            references.Sort();

            RemoveAllAWSSDKServiceDependencies(rootServiceItemGroup);
            RemoveAllServiceDllReference(rootDllReferenceGroup);

            foreach (var reference in references)
            {
                AddServiceReference(rootServiceItemGroup, reference.Include, reference.Guid, reference.Name);
            }

            foreach (var assemblyName in assemblyNames)
            {
                AddDllReference(rootDllReferenceGroup, assemblyName, this.ProjectFilePath.ToLower().Contains("net35") ? "net35" : "net45");
            }

            this._projectFileXml.Save(this.ProjectFilePath);
            Console.WriteLine("Writing new version of project file {0}", Path.GetFileName(this.ProjectFilePath));
        }

        void RemoveAllServiceDllReference(XmlElement itemGroupNode)
        {
            var child = itemGroupNode.FirstChild;
            while(child != null)
            {
                var nextSibling = child.NextSibling;
                itemGroupNode.RemoveChild(child);
                child = nextSibling;
            }
        }

        void RemoveAllAWSSDKServiceDependencies(XmlElement itemGroupNode)
        {
            var child = itemGroupNode.FirstChild;
            while(child != null)
            {
                var nextChild = child.NextSibling;

                XmlAttribute attribute = child.Attributes["Include"];
                if (attribute != null &&
                    attribute.Value.Contains("AWSSDK.") &&
                    !attribute.Value.Contains("AWSSDK.Core") &&
                    !attribute.Value.Contains("AWSSDK.CommonTest"))
                {
                    itemGroupNode.RemoveChild(child);
                }

                child = nextChild;
            }
        }

        ServiceProjectRefernece GetServiceReference(string projectFile, string guid)
        {
            var pathTokens = projectFile.Split('\\');
            string relativePath = string.Format(@"..\..\src\Services\{0}\{1}", pathTokens[pathTokens.Length - 2], Path.GetFileName(projectFile));

            return new ServiceProjectRefernece
            {
                Include = relativePath,
                Guid = guid,
                Name = Path.GetFileNameWithoutExtension(projectFile)
            };
        }

        void AddServiceReference(XmlElement itemGroupNode, string include, string guid, string projectName)
        {
            var projectReference = itemGroupNode.OwnerDocument.CreateElement("ProjectReference", VS_NAMESPACE);
            projectReference.SetAttribute("Include", include);

            var project = itemGroupNode.OwnerDocument.CreateElement("Project", VS_NAMESPACE);
            project.InnerText = guid;

            var name = itemGroupNode.OwnerDocument.CreateElement("Name", VS_NAMESPACE);
            name.InnerText = projectName;

            projectReference.AppendChild(project);
            projectReference.AppendChild(name);
            itemGroupNode.AppendChild(projectReference);
        }

        void AddDllReference(XmlElement itemGroupNode, string assemblyName, string targetFramework)
        {
            var hintPath = itemGroupNode.OwnerDocument.CreateElement("HintPath", VS_NAMESPACE);
            hintPath.InnerText = string.Format(@"..\..\..\Deployment\assemblies\{0}\{1}.dll", targetFramework, assemblyName);

            var reference = itemGroupNode.OwnerDocument.CreateElement("Reference", VS_NAMESPACE);
            reference.SetAttribute("Include", assemblyName);
            reference.AppendChild(hintPath);

            itemGroupNode.AppendChild(reference);
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

        XmlElement FindRootDllReferenceGroup()
        {
            var projectFileNameNode =
                ProjectFileXml.SelectSingleNode("//vs:ItemGroup/vs:Reference[contains(@Include, 'AWSSDK.AutoScaling')]", NamespaceManager) as XmlElement;

            var itemGroup = projectFileNameNode.ParentNode as XmlElement;
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

        string ExtractAssemblyName(string serviceProjectFile)
        {
            XmlDocument project = new XmlDocument();
            project.Load(serviceProjectFile);

            var projectGuidNode = project.SelectSingleNode("//vs:PropertyGroup/vs:AssemblyName", NamespaceManager) as XmlElement;
            return projectGuidNode.InnerText;
        }

        private class ServiceProjectRefernece : IComparable<ServiceProjectRefernece>
        {
            public string Include;
            public string Guid;
            public string Name;

            public int CompareTo(ServiceProjectRefernece other)
            {
                return Name.CompareTo(other.Name);
            }
        }
    }
}
