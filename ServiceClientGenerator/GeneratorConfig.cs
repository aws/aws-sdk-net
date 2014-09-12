using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceClientGenerator
{
    /// <summary>
    /// Represents the information for generating the code for a service
    /// </summary>
    public class GeneratorConfig
    {
        string modelPath;

        /// <summary>
        /// Path to the model that is represented by these attributes
        /// </summary>
        public string ModelPath 
        {
            get { return this.modelPath; }
            set 
            {
                this._serviceModel = null;
                this.modelPath = value; 
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
                    this._serviceModel = new ServiceModel(this.ModelPath, this.CustomizationsPath);

                return this._serviceModel;
            }
        }

        string customizationsPath;

        /// <summary>
        /// Path to the file used for customizations
        /// </summary>
        public string CustomizationsPath
        {
            get { return this.customizationsPath; }
            set
            {
                // Cause the service model to reload with customizations
                this._serviceModel = null;

                this.customizationsPath = value;
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
                    return "Amazon." + this.BaseName;

                return this._namespace;
            }
            set { this._namespace = value; } 
        }

        public bool HasOverrideNamespace { get { return !string.IsNullOrEmpty(this._namespace); } }
        public string RegionLookupName { get; set; }
        public string AuthenticationServiceName { get; set; }
        public int? OverrideMaxRetries { get; set; }
        public string ServiceUrl { get; set; }
        public string DefaultRegion { get; set; }
		public bool GenerateConstructors { get; set; }
        public string LockedAPIVersion { get; set; }

        public bool SkipV1
        {
            get;
            set;
        }

        public void SetSupportedMobilePlatforms(IEnumerable<string> mobilePlatforms)
        {
            foreach(var platform in mobilePlatforms)
            {
                if (string.Equals(platform, "WinRT", StringComparison.OrdinalIgnoreCase))
                    this.SupportedInWinRT = true;
                if (string.Equals(platform, "PCL", StringComparison.OrdinalIgnoreCase))
                    this.SupportedInPCL = true;
                if (string.Equals(platform, "WP8", StringComparison.OrdinalIgnoreCase))
                    this.SupportedInWP8 = true;
            }
        }

        public bool SupportedInWinRT
        {
            get;
            private set;
        }

        public bool SupportedInPCL
        {
            get;
            private set;
        }

        public bool SupportedInWP8
        {
            get;
            private set;
        }
    }
}
