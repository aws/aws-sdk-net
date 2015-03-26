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
            get { return this._serviceModel ?? (this._serviceModel = new ServiceModel(this.ModelPath, this.CustomizationsPath)); }
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
                    return "Amazon." + this.BaseName;

                return this._namespace;
            }
            set { this._namespace = value; } 
        }

        public string AssemblyTitle
        {
            get
            {
                return this.Namespace.Replace("Amazon.", "AWSSDK.");
            }
        }

        public string AssemblyDescription
        {
            get
            {
                return !string.IsNullOrEmpty(Synopsis) ? Synopsis : ServiceModel.ServiceFullName;
            }
        }

        public bool HasOverrideNamespace { get { return !string.IsNullOrEmpty(this._namespace); } }
        public string RegionLookupName { get; set; }
        public string AuthenticationServiceName { get; set; }
        public int? OverrideMaxRetries { get; set; }
        public string ServiceUrl { get; set; }
        public string DefaultRegion { get; set; }
		public bool GenerateConstructors { get; set; }
        public string LockedApiVersion { get; set; }
        public string Synopsis { get; set; }
        public List<string> ServiceDependencies { get; set; }

        public bool SkipV1 { get; set; }
    }
}
