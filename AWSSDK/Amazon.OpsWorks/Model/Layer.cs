/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes a layer.
    /// </summary>
    public partial class Layer
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private bool? _autoAssignElasticIps;
        private bool? _autoAssignPublicIps;
        private string _createdAt;
        private string _customInstanceProfileArn;
        private Recipes _customRecipes;
        private List<string> _customSecurityGroupIds = new List<string>();
        private Recipes _defaultRecipes;
        private List<string> _defaultSecurityGroupNames = new List<string>();
        private bool? _enableAutoHealing;
        private bool? _installUpdatesOnBoot;
        private string _layerId;
        private string _name;
        private List<string> _packages = new List<string>();
        private string _shortname;
        private string _stackId;
        private string _type;
        private bool? _useEbsOptimizedInstances;
        private List<VolumeConfiguration> _volumeConfigurations = new List<VolumeConfiguration>();


        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The layer attributes.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Attributes dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Attributes dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithAttributes(params KeyValuePair<string, string>[] pairs)
        {
            foreach (KeyValuePair<string, string> pair in pairs)
            {
                this.Attributes[pair.Key] = pair.Value;
            }
            return this;
        }
        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property AutoAssignElasticIps. 
        /// <para>
        /// Whether to automatically assign an <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        ///         IP address</a> to the layer's instances.         For more information, see
        /// <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-edit.html">How
        /// to Edit a Layer</a>.
        /// </para>
        /// </summary>
        public bool AutoAssignElasticIps
        {
            get { return this._autoAssignElasticIps.GetValueOrDefault(); }
            set { this._autoAssignElasticIps = value; }
        }


        /// <summary>
        /// Sets the AutoAssignElasticIps property
        /// </summary>
        /// <param name="autoAssignElasticIps">The value to set for the AutoAssignElasticIps property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithAutoAssignElasticIps(bool autoAssignElasticIps)
        {
            this._autoAssignElasticIps = autoAssignElasticIps;
            return this;
        }

        // Check to see if AutoAssignElasticIps property is set
        internal bool IsSetAutoAssignElasticIps()
        {
            return this._autoAssignElasticIps.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property AutoAssignPublicIps. 
        /// <para>
        /// For stacks that are running in a VPC, whether to automatically assign a public IP
        /// address to the layer's instances.         For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-edit.html">How
        /// to Edit a Layer</a>.
        /// </para>
        /// </summary>
        public bool AutoAssignPublicIps
        {
            get { return this._autoAssignPublicIps.GetValueOrDefault(); }
            set { this._autoAssignPublicIps = value; }
        }


        /// <summary>
        /// Sets the AutoAssignPublicIps property
        /// </summary>
        /// <param name="autoAssignPublicIps">The value to set for the AutoAssignPublicIps property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithAutoAssignPublicIps(bool autoAssignPublicIps)
        {
            this._autoAssignPublicIps = autoAssignPublicIps;
            return this;
        }

        // Check to see if AutoAssignPublicIps property is set
        internal bool IsSetAutoAssignPublicIps()
        {
            return this._autoAssignPublicIps.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Date when the layer was created.
        /// </para>
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }


        /// <summary>
        /// Sets the CreatedAt property
        /// </summary>
        /// <param name="createdAt">The value to set for the CreatedAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithCreatedAt(string createdAt)
        {
            this._createdAt = createdAt;
            return this;
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }


        /// <summary>
        /// Gets and sets the property CustomInstanceProfileArn. 
        /// <para>
        /// The ARN of the default IAM profile to be used for the layer's EC2 instances. For more
        /// information about IAM ARNs, see  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using
        /// Identifiers</a>.
        /// </para>
        /// </summary>
        public string CustomInstanceProfileArn
        {
            get { return this._customInstanceProfileArn; }
            set { this._customInstanceProfileArn = value; }
        }


        /// <summary>
        /// Sets the CustomInstanceProfileArn property
        /// </summary>
        /// <param name="customInstanceProfileArn">The value to set for the CustomInstanceProfileArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithCustomInstanceProfileArn(string customInstanceProfileArn)
        {
            this._customInstanceProfileArn = customInstanceProfileArn;
            return this;
        }

        // Check to see if CustomInstanceProfileArn property is set
        internal bool IsSetCustomInstanceProfileArn()
        {
            return this._customInstanceProfileArn != null;
        }


        /// <summary>
        /// Gets and sets the property CustomRecipes. 
        /// <para>
        /// A <code>LayerCustomRecipes</code> object that specifies the layer's custom recipes.
        /// </para>
        /// </summary>
        public Recipes CustomRecipes
        {
            get { return this._customRecipes; }
            set { this._customRecipes = value; }
        }


        /// <summary>
        /// Sets the CustomRecipes property
        /// </summary>
        /// <param name="customRecipes">The value to set for the CustomRecipes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithCustomRecipes(Recipes customRecipes)
        {
            this._customRecipes = customRecipes;
            return this;
        }

        // Check to see if CustomRecipes property is set
        internal bool IsSetCustomRecipes()
        {
            return this._customRecipes != null;
        }


        /// <summary>
        /// Gets and sets the property CustomSecurityGroupIds. 
        /// <para>
        /// An array containing the layer's custom security group IDs.
        /// </para>
        /// </summary>
        public List<string> CustomSecurityGroupIds
        {
            get { return this._customSecurityGroupIds; }
            set { this._customSecurityGroupIds = value; }
        }

        /// <summary>
        /// Sets the CustomSecurityGroupIds property
        /// </summary>
        /// <param name="customSecurityGroupIds">The values to add to the CustomSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithCustomSecurityGroupIds(params string[] customSecurityGroupIds)
        {
            foreach (var element in customSecurityGroupIds)
            {
                this._customSecurityGroupIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the CustomSecurityGroupIds property
        /// </summary>
        /// <param name="customSecurityGroupIds">The values to add to the CustomSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithCustomSecurityGroupIds(IEnumerable<string> customSecurityGroupIds)
        {
            foreach (var element in customSecurityGroupIds)
            {
                this._customSecurityGroupIds.Add(element);
            }
            return this;
        }
        // Check to see if CustomSecurityGroupIds property is set
        internal bool IsSetCustomSecurityGroupIds()
        {
            return this._customSecurityGroupIds != null && this._customSecurityGroupIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property DefaultRecipes.
        /// </summary>
        public Recipes DefaultRecipes
        {
            get { return this._defaultRecipes; }
            set { this._defaultRecipes = value; }
        }


        /// <summary>
        /// Sets the DefaultRecipes property
        /// </summary>
        /// <param name="defaultRecipes">The value to set for the DefaultRecipes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithDefaultRecipes(Recipes defaultRecipes)
        {
            this._defaultRecipes = defaultRecipes;
            return this;
        }

        // Check to see if DefaultRecipes property is set
        internal bool IsSetDefaultRecipes()
        {
            return this._defaultRecipes != null;
        }


        /// <summary>
        /// Gets and sets the property DefaultSecurityGroupNames. 
        /// <para>
        /// An array containing the layer's security group names.
        /// </para>
        /// </summary>
        public List<string> DefaultSecurityGroupNames
        {
            get { return this._defaultSecurityGroupNames; }
            set { this._defaultSecurityGroupNames = value; }
        }

        /// <summary>
        /// Sets the DefaultSecurityGroupNames property
        /// </summary>
        /// <param name="defaultSecurityGroupNames">The values to add to the DefaultSecurityGroupNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithDefaultSecurityGroupNames(params string[] defaultSecurityGroupNames)
        {
            foreach (var element in defaultSecurityGroupNames)
            {
                this._defaultSecurityGroupNames.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the DefaultSecurityGroupNames property
        /// </summary>
        /// <param name="defaultSecurityGroupNames">The values to add to the DefaultSecurityGroupNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithDefaultSecurityGroupNames(IEnumerable<string> defaultSecurityGroupNames)
        {
            foreach (var element in defaultSecurityGroupNames)
            {
                this._defaultSecurityGroupNames.Add(element);
            }
            return this;
        }
        // Check to see if DefaultSecurityGroupNames property is set
        internal bool IsSetDefaultSecurityGroupNames()
        {
            return this._defaultSecurityGroupNames != null && this._defaultSecurityGroupNames.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property EnableAutoHealing. 
        /// <para>
        /// Whether auto healing is disabled for the layer.
        /// </para>
        /// </summary>
        public bool EnableAutoHealing
        {
            get { return this._enableAutoHealing.GetValueOrDefault(); }
            set { this._enableAutoHealing = value; }
        }


        /// <summary>
        /// Sets the EnableAutoHealing property
        /// </summary>
        /// <param name="enableAutoHealing">The value to set for the EnableAutoHealing property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithEnableAutoHealing(bool enableAutoHealing)
        {
            this._enableAutoHealing = enableAutoHealing;
            return this;
        }

        // Check to see if EnableAutoHealing property is set
        internal bool IsSetEnableAutoHealing()
        {
            return this._enableAutoHealing.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property InstallUpdatesOnBoot. 
        /// <para>
        /// Whether to install operating system and package updates when the instance boots. The
        /// default value is <code>true</code>.         If this value is set to <code>false</code>,
        /// you must then update your instances manually by         using <a>CreateDeployment</a>
        /// to run the <code>update_dependencies</code> stack command or         manually running
        /// <code>yum</code> (Amazon Linux) or <code>apt-get</code> (Ubuntu) on the instances.
        ///  
        /// </para>
        ///   <note>      
        /// <para>
        /// We strongly recommend using the default value of <code>true</code>, to ensure that
        /// your        instances have the latest security updates.
        /// </para>
        ///     </note>
        /// </summary>
        public bool InstallUpdatesOnBoot
        {
            get { return this._installUpdatesOnBoot.GetValueOrDefault(); }
            set { this._installUpdatesOnBoot = value; }
        }


        /// <summary>
        /// Sets the InstallUpdatesOnBoot property
        /// </summary>
        /// <param name="installUpdatesOnBoot">The value to set for the InstallUpdatesOnBoot property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithInstallUpdatesOnBoot(bool installUpdatesOnBoot)
        {
            this._installUpdatesOnBoot = installUpdatesOnBoot;
            return this;
        }

        // Check to see if InstallUpdatesOnBoot property is set
        internal bool IsSetInstallUpdatesOnBoot()
        {
            return this._installUpdatesOnBoot.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property LayerId. 
        /// <para>
        /// The layer ID.
        /// </para>
        /// </summary>
        public string LayerId
        {
            get { return this._layerId; }
            set { this._layerId = value; }
        }


        /// <summary>
        /// Sets the LayerId property
        /// </summary>
        /// <param name="layerId">The value to set for the LayerId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithLayerId(string layerId)
        {
            this._layerId = layerId;
            return this;
        }

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this._layerId != null;
        }


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The layer name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property Packages. 
        /// <para>
        /// An array of <code>Package</code> objects that describe the layer's packages.
        /// </para>
        /// </summary>
        public List<string> Packages
        {
            get { return this._packages; }
            set { this._packages = value; }
        }

        /// <summary>
        /// Sets the Packages property
        /// </summary>
        /// <param name="packages">The values to add to the Packages collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithPackages(params string[] packages)
        {
            foreach (var element in packages)
            {
                this._packages.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Packages property
        /// </summary>
        /// <param name="packages">The values to add to the Packages collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithPackages(IEnumerable<string> packages)
        {
            foreach (var element in packages)
            {
                this._packages.Add(element);
            }
            return this;
        }
        // Check to see if Packages property is set
        internal bool IsSetPackages()
        {
            return this._packages != null && this._packages.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Shortname. 
        /// <para>
        /// The layer short name.
        /// </para>
        /// </summary>
        public string Shortname
        {
            get { return this._shortname; }
            set { this._shortname = value; }
        }


        /// <summary>
        /// Sets the Shortname property
        /// </summary>
        /// <param name="shortname">The value to set for the Shortname property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithShortname(string shortname)
        {
            this._shortname = shortname;
            return this;
        }

        // Check to see if Shortname property is set
        internal bool IsSetShortname()
        {
            return this._shortname != null;
        }


        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The layer stack ID.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }


        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithStackId(string stackId)
        {
            this._stackId = stackId;
            return this;
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }


        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The layer type, which must be one of the following:
        /// </para>
        ///   <ul>  <li>Custom</li>  <li>GangliaMonitoringMaster</li>  <li>HaProxy</li>  <li>MemcachedServer</li>
        ///  <li>MySqlMaster</li>  <li>NodeJsAppServer</li>  <li>PhpAppServer</li>  <li>RailsAppServer</li>
        ///  <li>WebServer</li>  </ul>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }


        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithType(string type)
        {
            this._type = type;
            return this;
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }


        /// <summary>
        /// Gets and sets the property UseEbsOptimizedInstances. 
        /// <para>
        /// Whether the layer uses Amazon EBS-optimized instances.
        /// </para>
        /// </summary>
        public bool UseEbsOptimizedInstances
        {
            get { return this._useEbsOptimizedInstances.GetValueOrDefault(); }
            set { this._useEbsOptimizedInstances = value; }
        }


        /// <summary>
        /// Sets the UseEbsOptimizedInstances property
        /// </summary>
        /// <param name="useEbsOptimizedInstances">The value to set for the UseEbsOptimizedInstances property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithUseEbsOptimizedInstances(bool useEbsOptimizedInstances)
        {
            this._useEbsOptimizedInstances = useEbsOptimizedInstances;
            return this;
        }

        // Check to see if UseEbsOptimizedInstances property is set
        internal bool IsSetUseEbsOptimizedInstances()
        {
            return this._useEbsOptimizedInstances.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property VolumeConfigurations. 
        /// <para>
        /// A <code>VolumeConfigurations</code> object that describes the layer's Amazon EBS volumes.
        /// </para>
        /// </summary>
        public List<VolumeConfiguration> VolumeConfigurations
        {
            get { return this._volumeConfigurations; }
            set { this._volumeConfigurations = value; }
        }

        /// <summary>
        /// Sets the VolumeConfigurations property
        /// </summary>
        /// <param name="volumeConfigurations">The values to add to the VolumeConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithVolumeConfigurations(params VolumeConfiguration[] volumeConfigurations)
        {
            foreach (var element in volumeConfigurations)
            {
                this._volumeConfigurations.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the VolumeConfigurations property
        /// </summary>
        /// <param name="volumeConfigurations">The values to add to the VolumeConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithVolumeConfigurations(IEnumerable<VolumeConfiguration> volumeConfigurations)
        {
            foreach (var element in volumeConfigurations)
            {
                this._volumeConfigurations.Add(element);
            }
            return this;
        }
        // Check to see if VolumeConfigurations property is set
        internal bool IsSetVolumeConfigurations()
        {
            return this._volumeConfigurations != null && this._volumeConfigurations.Count > 0; 
        }

    }
}