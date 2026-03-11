using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace ServiceClientGenerator
{
    public class GeneratorExtensionsDriver
    {
        /// <summary>
        /// Generation manifest for the entire SDK.
        /// </summary>
        public GenerationManifest GenerationManifest { get; private set; }

        /// <summary>
        /// The configuration for the extension.
        /// </summary>
        public ExtensionConfiguration Configuration { get; private set; }
                
        /// <summary>
        /// Runtime options for the generation process, as supplied at the command line.
        /// </summary>
        public GeneratorOptions Options { get; private set; }

        private string _nuspecPath;
        private string _assemblyInfoPath;

        public GeneratorExtensionsDriver(ExtensionConfiguration config, GeneratorOptions options)
        {
            Configuration = config;         
            Options = options;                        
            _nuspecPath = Utils.PathCombineAlt(config.Path, config.Id + ".nuspec");
            _assemblyInfoPath = Utils.PathCombineAlt(config.Path, "Properties", "AssemblyInfo.cs");
        }

        /// <summary>
        /// Executes the extension generation process by updating nuspec and assembly info files, then validating consistency.
        /// </summary>
        public void Execute()
        {
            ProcessNuspec();
            ProcessAssemblyInfo();

            // Validate must be called after all changes have been made to the Nuspec and AssemblyInfo.cs file.
            Validate();
        }


        /// <summary>
        /// Validates bidirectional consistency between AWSSDK dependencies in nuspec and SdkDependencies configuration.
        /// </summary>
        public void Validate()
        {
            if (!File.Exists(_nuspecPath))
            {
                throw new Exception($"AWSSDK.{Configuration.Name} is missing a nuspec file at '{_nuspecPath}'.");
            }

            if (Configuration.SdkDependencies == null)
            {
                throw new Exception($"AWSSDK.{Configuration.Name} has no dependencies and must at least have a AWSSDK.Core dependency.");
            }

            var doc = new XmlDocument();
            doc.Load(_nuspecPath);
            
            var nuspecServices = new HashSet<string>();
            var dependencyNodes = doc.SelectNodes("//dependency[@id]");
            foreach (XmlNode node in dependencyNodes)
            {
                var id = node.Attributes["id"].Value;
                if (id.StartsWith("AWSSDK."))
                {
                    nuspecServices.Add(id.Substring(7));
                }
            }

            var configServices = new HashSet<string>(Configuration.SdkDependencies.Keys);

            foreach (var service in nuspecServices)
            {
                if (!configServices.Contains(service))
                    throw new Exception($"AWSSDK.{service} dependency found in nuspec but missing from SdkDependencies");
            }

            foreach (var service in configServices)
            {
                if (!nuspecServices.Contains(service))
                    throw new Exception($"{service} found in SdkDependencies but AWSSDK.{service} dependency missing from nuspec");
            }
        }

        /// <summary>
        /// Updates the nuspec file with the extension version and AWSSDK dependency versions from configuration.
        /// </summary>
        public void ProcessNuspec()
        {
            if (!File.Exists(_nuspecPath))
                return;

            var versionUpdated = false;
            var dependenciesUpdated = false;

            var doc = new XmlDocument();
            doc.Load(_nuspecPath);
            
            // Determine if the service file version needs updating.
            var versionNode = doc.SelectSingleNode("/package/metadata/version");
            if (versionNode != null)
            {
                if(versionNode.InnerText != Configuration.FileVersion)
                {
                    versionNode.InnerText = Configuration.FileVersion;
                    versionUpdated = true;
                }                
            }

            // Determine if any of the service dependencies need updating in the nuspec.
            var dependencyNodes = doc.SelectNodes("//dependency[@id]");
            foreach (XmlNode node in dependencyNodes)
            {
                var id = node.Attributes["id"].Value;
                if (id.StartsWith("AWSSDK."))
                {
                    var serviceName = id.Substring(7);
                    if (Configuration.SdkDependencies.ContainsKey(serviceName))
                    {
                        if(node.Attributes["version"].Value != Configuration.SdkDependencies[serviceName])
                        {
                            node.Attributes["version"].Value = Configuration.SdkDependencies[serviceName];
                            dependenciesUpdated = true;
                        }                            
                    }
                }
            }            

            if (!versionUpdated && dependenciesUpdated)
            {
                throw new Exception($"ERROR: {Configuration.Id} dependencies updated but the extension version was not updated.");
            }
            else if (versionUpdated)
            {
                doc.Save(_nuspecPath);
            }
        }

        /// <summary>
        /// Updates AssemblyVersion and AssemblyFileVersion attributes in the AssemblyInfo.cs file.
        /// </summary>
        public void ProcessAssemblyInfo()
        {
            if (!File.Exists(_assemblyInfoPath) || string.IsNullOrEmpty(Configuration.FileVersion))
                return;

            var content = File.ReadAllText(_assemblyInfoPath);
            var contentOrig = content;

            // Update AssemblyVersion
            var pattern = @"\[assembly:\s*AssemblyVersion\s*\(\s*""[^""]*""\s*\)\]";
            var replacement = $"[assembly: AssemblyVersion(\"{Configuration.Version}\")]";
            content = Regex.Replace(content, pattern, replacement);

            // Update AssemblyFileVersion
            pattern = @"\[assembly:\s*AssemblyFileVersion\s*\(\s*""[^""]*""\s*\)\]";
            replacement = $"[assembly: AssemblyFileVersion(\"{Configuration.FileVersion}\")]";            
            content = Regex.Replace(content, pattern, replacement);

            if(contentOrig != content)
            {
                File.WriteAllText(_assemblyInfoPath, content);
            }
        }
    }
}
