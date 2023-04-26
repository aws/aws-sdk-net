using ServiceClientGenerator.Endpoints;
using ServiceClientGenerator.Endpoints.Tests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Represents the information for generating the code for a service
    /// </summary>
    public class ServiceConfiguration
    {
        private const string amazonDotPrefix = "Amazon.";

        private string _modelPath;
        private string _paginatorsPath;

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

        /// <summary>
        /// Path to the paginators for a service
        /// </summary>
        public string PaginatorsPath
        {
            get { return this._paginatorsPath; }
            set
            {
                this._paginatorsPath = value;
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
                    this._serviceModel = this._paginatorsPath != null ? new ServiceModel(this.ModelPath, this.CustomizationsPath, this._paginatorsPath) : 
                        new ServiceModel(this.ModelPath, this.CustomizationsPath);
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

        private static string SanitizeStringForClassName(string name)
        {
            if (null == name)
                return null;

            string className = name;
            className = className.Replace("AWS", "");
            className = className.Replace("Amazon", "");

            // concatenate all the words by removing whitespace.
            className = System.Text.RegularExpressions.Regex.Replace(className, @"[^a-zA-Z0-9]", "");

            return className.ToUpperFirstCharacter();
        }


        private string _className;

        /// <summary>
        /// The base name used in the client and the top level request class for a service
        /// </summary>
        public string ClassName
        {
            get
            {
                if (!string.IsNullOrEmpty(_className))
                {
                    return _className;
                }

                if (ClassNameOverride != null)
                {
                    _className = ClassNameOverride;
                }
                else if (!string.IsNullOrEmpty(this.LegacyServiceId))
                {
                    //Use legacy service class name calculation
                    if (this.ServiceModel.ServiceAbbreviation != null)
                    {
                        _className = SanitizeStringForClassName(_serviceModel.ServiceAbbreviation);
                    }
                    else if (this.ServiceModel.ServiceFullName != null)
                    {
                        _className = SanitizeStringForClassName(_serviceModel.ServiceFullName);
                    }
                    else
                    {
                        throw new InvalidDataException("Generator was not able to determine the ClassName for a service.");
                    }
                }
                else
                {
                    //All new services will not have a legacy-service-id metadata property value which indicates that they
                    //must use the ServiceId for the class name.
                    if (string.IsNullOrEmpty(this.ServiceId))
                    {
                        throw new InvalidDataException(
                            "Generator was not able to determine the ClassName for a service.");
                    }

                    _className = SanitizeStringForClassName(this.ServiceId);
                }

                return _className;
            }
        }

        /// <summary>
        /// Classname can be overriden by setting "base-name" in metadata.json
        /// </summary>
        public string ClassNameOverride { get; set; }

        string _namespace;

        /// <summary>
        /// The namespace of the service, if not specified it is Amazon.ClassName
        /// </summary>
        public string Namespace 
        {
            get
            {
                if (string.IsNullOrEmpty(this._namespace))
                    return amazonDotPrefix + this.ClassName;

                return this._namespace;
            }
            set { this._namespace = value; } 
        }

        // Base name in the manifest is not a reliable source of info, as if append-service
        // is set 'Service' gets appended and in the case of IAM then sends us to the wrong folder.
        // Instead we'll use the namespace and rip off any Amazon. prefix. This also helps us
        // handle versioned namespaces too.
        public string ServiceFolderName
        {
            get
            {
                var serviceNameRoot = this.Namespace.StartsWith("Amazon.", StringComparison.Ordinal)
                    ? this.Namespace.Substring(7)
                    : this.Namespace;

                return serviceNameRoot;
            }
        }

        public string TestCategory
        {
            get
            {
                return ServiceFolderName;
            }
        }

        public string AssemblyTitle
        {
            get
            {
                return this.Namespace.Replace(amazonDotPrefix, "AWSSDK.");
            }
        }

        public string AssemblyDescription(
            string versionIdentifier = "", 
            bool includePreamble = true, 
            bool includeBody = true, 
            bool includePostamble = true)
        {
            if (!string.IsNullOrEmpty(versionIdentifier) && !versionIdentifier.StartsWith("("))
                versionIdentifier = $"({versionIdentifier})";

            var preamble =
                includePreamble
                    ? $"The Amazon Web Services SDK for .NET {versionIdentifier} - "
                    : "";

            string body = "";
            if (includeBody)
            {
                body =
                    !string.IsNullOrEmpty(ServiceModel.ServiceFullName)
                        ? $"{ServiceModel.ServiceFullName}. "
                        : $"{ServiceId}. ";
            }
            
            var postamble =
                includePostamble 
                    ? $"{ (!string.IsNullOrEmpty(Synopsis) ? Synopsis : ServiceId) }"
                    : "";
            return $"{preamble}{body}{postamble}";
        }
        
        public string BaseException
        {
            get
            {
                var baseException = string.Format("Amazon{0}Exception",
                                        this.IsChildConfig ?
                                        this.ParentConfig.ClassName : this.ClassName);
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
        public string RegionLookupName { get { return this.ServiceModel.EndpointPrefix; } }
        public string LegacyServiceId { get; set; }
        public string ServiceId { 
            get {
                if (!string.IsNullOrEmpty(ServiceModel.ServiceId))
                    return ServiceModel.ServiceId;
                
                //ServiceID is required, but there are a few services that were created before that requirement
                if(!string.IsNullOrEmpty(LegacyServiceId)) 
                {
                    return LegacyServiceId;
                }

                //If it's a newer service, then the ServiceId field is required
                throw new Exception($"Invalid Service Model:  Missing required {ServiceModel.ServiceIdKey}");
            } 
        }
        public string AuthenticationServiceName { get { return this.ServiceModel.SigningName != null ? this.ServiceModel.SigningName : this.ServiceModel.EndpointPrefix; } }
        public int? OverrideMaxRetries { get; set; }
        public string DefaultRegion { get; set; }
        public bool GenerateConstructors { get; set; }
        public string LockedApiVersion { get; set; }
        public string Synopsis { get; set; }
        public Dictionary<string, string> ServiceDependencies { get; set; }
        public string LicenseUrl { get; set; }
        public bool RequireLicenseAcceptance { get; set; }
        public Dictionary<string, List<Dependency>> ReferenceDependencies { get; set; }
        public Dictionary<string, List<Dependency>> NugetDependencies { get; set; }
        public List<string> Tags { get; set; }
        public bool NetStandardSupport { get; set; }

        public string ServiceVersion
        {
            get
            {
                if (!string.IsNullOrEmpty(this.ServiceAssemblyVersionOverride))
                {
                    return ServiceAssemblyVersionOverride;
                }
                return Utils.GetVersion(ServiceFileVersion);
            }
        }

        public string ServiceFileVersion { get; set; }

        /// <summary>
        /// If specified this overrides the AssemblyVersion for the service package in AssemblyInfo.cs.
        /// Assembly version defaults to x.y of ServiceFileVersion if this is not specified.
        /// </summary>
        public string ServiceAssemblyVersionOverride { get; set; }

        public bool SkipV1 { get; set; }

        public bool IsChildConfig
        {
            get
            {
                return this.ParentConfig != null;
            }
        }

        private ServiceConfiguration _parentConfig;
        public ServiceConfiguration ParentConfig
        {
            get
            {
                return _parentConfig;
            }
            set
            {
                _parentConfig = value;
                ServiceModel.ParentModel = value.ServiceModel;
            }
        }

        public string ServiceDirectoryName
        {
            get
            {
                var directory = Path.GetDirectoryName(ModelPath);
                var directoryName = Path.GetFileName(directory);
                return directoryName;
            }
        }

        public string DisplayModelPath
        {
            get
            {
                return Path.GetFileName(ModelPath);
            }
        }
        
        public bool IsTestService { get; set; }

        public RuleSet EndpointsRuleSet { get; set; }
        public EndpointTests EndpointTests { get; set; }

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

        public static Dependency ParseJson(Json.LitJson.JsonData data)
        {
            return new Dependency
            {
                Name = data.SafeGetString("name"),
                Version = data.SafeGetString("version"),
                HintPath = data.SafeGetString("hintPath"),
            };
        }
    }
}
