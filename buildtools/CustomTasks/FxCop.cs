using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Build.Utilities;
using System.IO;
using System.Xml;
using System.Reflection;

namespace CustomTasks
{
    public class UpdateFxCopProject : Task
    {
        public string Assemblies { get; set; }
        public string FxCopProject { get; set; }

        public override bool Execute()
        {
            if (string.IsNullOrEmpty(Assemblies))
                throw new ArgumentNullException("Assemblies");
            if (string.IsNullOrEmpty(FxCopProject))
                throw new ArgumentNullException("FxCopProject");

            Assemblies = Path.GetFullPath(Assemblies);
            Log.LogMessage("Assemblies = " + Assemblies);

            FxCopProject = Path.GetFullPath(FxCopProject);
            Log.LogMessage("FxCopProject = " + FxCopProject);
			
            Log.LogMessage("Updating project...");
            FxCop.UpdateFxCopProject(Assemblies, FxCopProject);
            Log.LogMessage("Project updated");

            return true;
        }
    }

    public static class FxCop
    {
        public static void UpdateFxCopProject(string assembliesFolder, string fxCopProjectPath)
        {
            var allAssemblies = Directory.GetFiles(assembliesFolder, "*.dll").ToList();

            // move core assembly to the end of the list
            var coreAssembly = allAssemblies.Single(a => a.IndexOf(CoreAssemblyName, StringComparison.OrdinalIgnoreCase) >= 0);
            allAssemblies.Remove(coreAssembly);
            allAssemblies.Add(coreAssembly);

            var doc = new XmlDocument();
            doc.Load(fxCopProjectPath);

            var targetsNode = doc.SelectSingleNode(TargetsXpath);
            RemoveAllTargets(doc, targetsNode);

            foreach (var assembly in allAssemblies)
            {
                var assemblyName = Path.GetFileName(assembly);
                var isCore = string.Equals(CoreAssemblyName, assemblyName, StringComparison.OrdinalIgnoreCase);

                var newTarget = AddChildNode(targetsNode, "Target");
                AddAttribute(newTarget, "Name", assembly);
                AddAttribute(newTarget, "Analyze", "True");

                if (isCore)
                {
                    AddCoreAssembly(coreAssembly, newTarget);
                }
                else
                {
                    /*
                    <Target Name="$(ProjectDir)/Deployment/sdk/assemblies/net35/AWSSDK.AutoScaling.dll" Analyze="True" AnalyzeAllChildren="True" />
                    */
                    AddAttribute(newTarget, "AnalyzeAllChildren", "True");
                }
            }
            doc.Save(fxCopProjectPath);
        }

        private static void AddCoreAssembly(string coreAssemblyPath, XmlNode newTarget)
        {
            AddAttribute(newTarget, "AnalyzeAllChildren", "False");

            var assemblyName = Path.GetFileName(coreAssemblyPath);
            var coreAssembly = Assembly.LoadFrom(coreAssemblyPath);
            /*
  <Target Name="$(ProjectDir)/Deployment/sdk/assemblies/net35/AWSSDK.Core.dll" Analyze="True" AnalyzeAllChildren="False">
   <Modules AnalyzeAllChildren="False">
    <Module Name="awssdk.core.dll" Analyze="True" AnalyzeAllChildren="False">
     <Namespaces AnalyzeAllChildren="False">
      <Namespace Name="" Analyze="True" AnalyzeAllChildren="True" />
                */

            var modulesNode = AddChildNode(newTarget, "Modules");
            AddAttribute(modulesNode, "AnalyzeAllChildren", "False");

            var moduleNode = AddChildNode(modulesNode, "Module");
            AddAttribute(moduleNode, "Name", assemblyName);
            AddAttribute(moduleNode, "Analyze", "True");
            AddAttribute(moduleNode, "AnalyzeAllChildren", "False");

            var namespacesNode = AddChildNode(moduleNode, "Namespaces");
            AddAttribute(namespacesNode, "AnalyzeAllChildren", "False");

            var namespaces = GetNamespacesToExamine(coreAssembly);
            foreach (var ns in namespaces.OrderBy(k => k, StringComparer.Ordinal))
            {
                var namespaceNode = AddChildNode(namespacesNode, "Namespace");
                AddAttribute(namespaceNode, "Name", ns);
                AddAttribute(namespaceNode, "Analyze", "True");
                AddAttribute(namespaceNode, "AnalyzeAllChildren", "True");
            }
        }


        public static HashSet<string> NamespacePrefixesToSkip = new HashSet<string>(StringComparer.Ordinal)
        {
            "ThirdParty.BouncyCastle",
            "ThirdParty.Ionic.Zlib",
            "ThirdParty.Json",
        };
        public const string NamespacesXpath = "FxCopProject/Targets/Target/Modules/Module/Namespaces";
        public const string TargetsXpath = "FxCopProject/Targets";
        public const string TargetXpath = "FxCopProject/Targets/Target";
        public const string CoreAssemblyName = "AWSSDK.Core.dll";

        public static IEnumerable<string> GetNamespacesToExamine(Assembly assembly)
        {
            HashSet<string> namespaces = new HashSet<string>(StringComparer.Ordinal);

            var allTypes = assembly.GetTypes().ToList();
            foreach (var type in allTypes)
            {
                var ns = type.Namespace;
                if (ShouldSkip(ns))
                    continue;

                namespaces.Add(ns);
            }

            return namespaces;
        }

        private static bool ShouldSkip(string ns)
        {
            if (ns == null)
                return false;

            foreach (var toSkip in NamespacePrefixesToSkip)
                if (ns.StartsWith(toSkip, StringComparison.Ordinal))
                    return true;
            return false;
        }

        private static void AddAttribute(XmlNode node, string name, string value)
        {
            var doc = node.OwnerDocument;
            var attribute = doc.CreateAttribute(name);
            attribute.Value = value;
            node.Attributes.Append(attribute);
        }
        private static XmlNode AddChildNode(XmlNode parent, string name)
        {
            var doc = parent.OwnerDocument;
            var node = doc.CreateElement(name);
            parent.AppendChild(node);
            return node;
        }
        private static void RemoveAllTargets(XmlDocument doc, XmlNode targetsNode)
        {
            var allTargetNodes = doc.SelectNodes(TargetXpath);
            foreach (XmlNode targetNode in allTargetNodes)
                targetsNode.RemoveChild(targetNode);

        }
    }
}
