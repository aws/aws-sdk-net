using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Represents the information for generating the code for a service
    /// </summary>
    public class ServiceConfiguration
    {
        private const string amazonDotPrefix = "Amazon.";

        string _modelPath;

        /// <summary>
        /// The name of the model, taken from the "model" entry in the service models 
        /// manifest.
        /// </summary>
        public string ModelName { get; set; }

        /// <summary>
        /// Path to the model that is represented by these attributes
        /// </summary>
        public string ModelPath 
        {
            get { return this._modelPath; }
            set 
            {
                this._serviceModel = null;
                this._modelPath = value; 
            }
        }

        ServiceModel _serviceModel;

        /// <summary>
        /// The ServiceModel object, used to parse information inside of the model*.normal.json file as well as any customizations
        /// </summary>
        public ServiceModel ServiceModel 
        {
            get
            {
                if (this._serviceModel == null)
                {
                    this._serviceModel = new ServiceModel(this.ModelPath, this.CustomizationsPath);

                    if (this.IsChildConfig)
                    {
                        _serviceModel.ParentModel = ParentConfig.ServiceModel;
                    }
                }

                return this._serviceModel;
            }
        }

        string _customizationsPath;

        /// <summary>
        /// Path to the file used for customizations
        /// </summary>
        public string CustomizationsPath
        {
            get { return this._customizationsPath; }
            set
            {
                // Cause the service model to reload with customizations
                this._serviceModel = null;

                this._customizationsPath = value;
            }
        }

        /// <summary>
        /// The base name used in the client and the top level request class for a service
        /// </summary>
        public string BaseName { get; set; }

        string _namespace;

        /// <summary>
        /// The namespace of the service, if not specified it is Amazon.BASENAME
        /// </summary>
        public string Namespace 
        {
            get
            {
                if (string.IsNullOrEmpty(this._namespace))
                    return amazonDotPrefix + this.BaseName;

                return this._namespace;
            }
            set { this._namespace = value; } 
        }

        public string AssemblyTitle
        {
            get
            {
                return this.Namespace.Replace(amazonDotPrefix, "AWSSDK.");
            }
        }

        public string AssemblyDescription
        {
            get
            {
                return !string.IsNullOrEmpty(Synopsis) ? Synopsis : ServiceModel.ServiceFullName;
            }
        }

        public string BaseException
        {
            get
            {
                var baseException = string.Format("Amazon{0}Exception",
                                        this.IsChildConfig ?
                                        this.ParentConfig.BaseName : this.BaseName);
                return baseException;
            }
        }

        /// <summary>
        /// An option suffix added on to the end of the Nuget package title.
        /// </summary>
        public string NugetPackageTitleSuffix { get; set; }

        // Base name in the manifest is not a reliable source of info, as if append-service
        // is set 'Service' gets appended and in the case of IAM then sends us to the wrong folder.
        // Instead we'll use the namespace and rip off any Amazon. prefix. This also helps us
        // handle versioned namespaces too.
        public string ServiceNameRoot
        {
            get
            {
                var serviceNameRoot = this.Namespace.StartsWith(amazonDotPrefix, StringComparison.Ordinal)
                           ? this.Namespace.Substring(amazonDotPrefix.Length)
                           : this.Namespace;
                return serviceNameRoot;
            }
        }

        public bool InPreview {get; set;}

        public bool HasOverrideNamespace { get { return !string.IsNullOrEmpty(this._namespace); } }
        public string RegionLookupName { get; set; }
        public string AuthenticationServiceName { get; set; }
        public int? OverrideMaxRetries { get; set; }
        public string ServiceUrl { get; set; }
        public string DefaultRegion { get; set; }
		public bool GenerateConstructors { get; set; }
        public string LockedApiVersion { get; set; }
        public string Synopsis { get; set; }
        public Dictionary<string, string> ServiceDependencies { get; set; }
        public bool UsePclProjectDependencies { get; set; }
        public string LicenseUrl { get; set; }
        public bool RequireLicenseAcceptance { get; set; }
        public Dictionary<string, List<Dependency>> ReferenceDependencies { get; set; }
        public Dictionary<string, List<Dependency>> NugetDependencies { get; set; }
        public List<string> PclVariants { get; set; }
        public List<string> Tags { get; set; }

        public bool EnableXamarinComponent { get; set; }

        public string ServiceVersion
        {
            get
            {
                return Utils.GetVersion(ServiceFileVersion);
            }
        }

        public string ServiceFileVersion { get; set; }

        public bool SkipV1 { get; set; }

        public IEnumerable<string> SupportedMobilePlatforms
        {
            set
            {
                if (value == null)
                    return;

                foreach (var platform in value)
                {
                    if (string.Equals(platform, "Unity", StringComparison.OrdinalIgnoreCase)) 
                    {
                        this.SupportedInUnity = true;
                    }
                }
            }
        }

        public bool SupportedInUnity
        {
            get;
            private set;
        }

        public bool IsChildConfig
        {
            get
            {
                return this.ParentConfig != null;
            }
        }

        public ServiceConfiguration ParentConfig { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Namespace, this.ModelPath);
        }
    }

    public class Dependency
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string HintPath { get; set; }
    }
}
