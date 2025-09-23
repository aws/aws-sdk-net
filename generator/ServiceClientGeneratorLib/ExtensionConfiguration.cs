using ServiceClientGenerator.Endpoints;
using ServiceClientGenerator.Endpoints.Tests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Represents the information for generating the code for an Extension
    /// </summary>
    public class ExtensionConfiguration
    {
        /// <summary>
        /// Name of the extension without AWSSDK.Extensions. prefix. Example: NETCore.Setup
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The ID of the extension which is the AWSSDK.Extensions. + Name
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Directory path where the extension is located
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Determines if the service is currently in preview.
        /// </summary>
        public bool InPreview {get; set;}

        /// <summary>
        /// The AWSSDK.* dependency lookup for the extension.
        /// </summary>
        public Dictionary<string, string> SdkDependencies { get; set; }        

        /// <summary>
        /// The extension version
        /// </summary>
        public string Version
        {
            get
            {
                if (!string.IsNullOrEmpty(AssemblyVersionOverride))
                {
                    return AssemblyVersionOverride;
                }
                return Utils.GetVersion(FileVersion);
            }
        }

        /// <summary>
        /// The file version of the extension
        /// </summary>
        public string FileVersion { get; set; }

        /// <summary>
        /// If specified this overrides the AssemblyVersion for the extension package in AssemblyInfo.cs.
        /// Assembly version defaults to x.y of ExtensionFileVersion if this is not specified.
        /// </summary>
        public string AssemblyVersionOverride { get; set; }
    }
}
