/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes a layer.</para>
    /// </summary>
    public class Layer
    {
        
        private string stackId;
        private string layerId;
        private string type;
        private string name;
        private string shortname;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();
        private string customInstanceProfileArn;
        private List<string> customSecurityGroupIds = new List<string>();
        private List<string> defaultSecurityGroupNames = new List<string>();
        private List<string> packages = new List<string>();
        private List<VolumeConfiguration> volumeConfigurations = new List<VolumeConfiguration>();
        private bool? enableAutoHealing;
        private bool? autoAssignElasticIps;
        private bool? autoAssignPublicIps;
        private Recipes defaultRecipes;
        private Recipes customRecipes;
        private string createdAt;
        private bool? installUpdatesOnBoot;

        /// <summary>
        /// The layer stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The layer ID.
        ///  
        /// </summary>
        public string LayerId
        {
            get { return this.layerId; }
            set { this.layerId = value; }
        }

        /// <summary>
        /// Sets the LayerId property
        /// </summary>
        /// <param name="layerId">The value to set for the LayerId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithLayerId(string layerId)
        {
            this.layerId = layerId;
            return this;
        }
            

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this.layerId != null;
        }

        /// <summary>
        /// The layer type, which must be one of the following: <ul> <li>Custom</li> <li>GangliaMonitoringMaster</li> <li>HaProxy</li>
        /// <li>MemcachedServer</li> <li>MySqlMaster</li> <li>NodeJsAppServer</li> <li>PhpAppServer</li> <li>RailsAppServer</li> <li>WebServer</li>
        /// </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>lb, web, php-app, rails-app, nodejs-app, memcached, db-master, monitoring-master, custom</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithType(string type)
        {
            this.type = type;
            return this;
        }
            

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }

        /// <summary>
        /// The layer name.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The layer short name.
        ///  
        /// </summary>
        public string Shortname
        {
            get { return this.shortname; }
            set { this.shortname = value; }
        }

        /// <summary>
        /// Sets the Shortname property
        /// </summary>
        /// <param name="shortname">The value to set for the Shortname property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithShortname(string shortname)
        {
            this.shortname = shortname;
            return this;
        }
            

        // Check to see if Shortname property is set
        internal bool IsSetShortname()
        {
            return this.shortname != null;
        }

        /// <summary>
        /// The layer attributes.
        ///  
        /// </summary>
        public Dictionary<string,string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
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
            return this.attributes != null;
        }

        /// <summary>
        /// The ARN of the default IAM profile to be used for the layer's EC2 instances. For more information about IAM ARNs, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using Identifiers</a>.
        ///  
        /// </summary>
        public string CustomInstanceProfileArn
        {
            get { return this.customInstanceProfileArn; }
            set { this.customInstanceProfileArn = value; }
        }

        /// <summary>
        /// Sets the CustomInstanceProfileArn property
        /// </summary>
        /// <param name="customInstanceProfileArn">The value to set for the CustomInstanceProfileArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithCustomInstanceProfileArn(string customInstanceProfileArn)
        {
            this.customInstanceProfileArn = customInstanceProfileArn;
            return this;
        }
            

        // Check to see if CustomInstanceProfileArn property is set
        internal bool IsSetCustomInstanceProfileArn()
        {
            return this.customInstanceProfileArn != null;
        }

        /// <summary>
        /// An array containing the layer's custom security group IDs.
        ///  
        /// </summary>
        public List<string> CustomSecurityGroupIds
        {
            get { return this.customSecurityGroupIds; }
            set { this.customSecurityGroupIds = value; }
        }
        /// <summary>
        /// Adds elements to the CustomSecurityGroupIds collection
        /// </summary>
        /// <param name="customSecurityGroupIds">The values to add to the CustomSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithCustomSecurityGroupIds(params string[] customSecurityGroupIds)
        {
            foreach (string element in customSecurityGroupIds)
            {
                this.customSecurityGroupIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CustomSecurityGroupIds collection
        /// </summary>
        /// <param name="customSecurityGroupIds">The values to add to the CustomSecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithCustomSecurityGroupIds(IEnumerable<string> customSecurityGroupIds)
        {
            foreach (string element in customSecurityGroupIds)
            {
                this.customSecurityGroupIds.Add(element);
            }

            return this;
        }

        // Check to see if CustomSecurityGroupIds property is set
        internal bool IsSetCustomSecurityGroupIds()
        {
            return this.customSecurityGroupIds.Count > 0;
        }

        /// <summary>
        /// An array containing the layer's security group names.
        ///  
        /// </summary>
        public List<string> DefaultSecurityGroupNames
        {
            get { return this.defaultSecurityGroupNames; }
            set { this.defaultSecurityGroupNames = value; }
        }
        /// <summary>
        /// Adds elements to the DefaultSecurityGroupNames collection
        /// </summary>
        /// <param name="defaultSecurityGroupNames">The values to add to the DefaultSecurityGroupNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithDefaultSecurityGroupNames(params string[] defaultSecurityGroupNames)
        {
            foreach (string element in defaultSecurityGroupNames)
            {
                this.defaultSecurityGroupNames.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the DefaultSecurityGroupNames collection
        /// </summary>
        /// <param name="defaultSecurityGroupNames">The values to add to the DefaultSecurityGroupNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithDefaultSecurityGroupNames(IEnumerable<string> defaultSecurityGroupNames)
        {
            foreach (string element in defaultSecurityGroupNames)
            {
                this.defaultSecurityGroupNames.Add(element);
            }

            return this;
        }

        // Check to see if DefaultSecurityGroupNames property is set
        internal bool IsSetDefaultSecurityGroupNames()
        {
            return this.defaultSecurityGroupNames.Count > 0;
        }

        /// <summary>
        /// An array of <c>Package</c> objects that describe the layer's packages.
        ///  
        /// </summary>
        public List<string> Packages
        {
            get { return this.packages; }
            set { this.packages = value; }
        }
        /// <summary>
        /// Adds elements to the Packages collection
        /// </summary>
        /// <param name="packages">The values to add to the Packages collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithPackages(params string[] packages)
        {
            foreach (string element in packages)
            {
                this.packages.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Packages collection
        /// </summary>
        /// <param name="packages">The values to add to the Packages collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithPackages(IEnumerable<string> packages)
        {
            foreach (string element in packages)
            {
                this.packages.Add(element);
            }

            return this;
        }

        // Check to see if Packages property is set
        internal bool IsSetPackages()
        {
            return this.packages.Count > 0;
        }

        /// <summary>
        /// A <c>VolumeConfigurations</c> object that describes the layer's Amazon EBS volumes.
        ///  
        /// </summary>
        public List<VolumeConfiguration> VolumeConfigurations
        {
            get { return this.volumeConfigurations; }
            set { this.volumeConfigurations = value; }
        }
        /// <summary>
        /// Adds elements to the VolumeConfigurations collection
        /// </summary>
        /// <param name="volumeConfigurations">The values to add to the VolumeConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithVolumeConfigurations(params VolumeConfiguration[] volumeConfigurations)
        {
            foreach (VolumeConfiguration element in volumeConfigurations)
            {
                this.volumeConfigurations.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the VolumeConfigurations collection
        /// </summary>
        /// <param name="volumeConfigurations">The values to add to the VolumeConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithVolumeConfigurations(IEnumerable<VolumeConfiguration> volumeConfigurations)
        {
            foreach (VolumeConfiguration element in volumeConfigurations)
            {
                this.volumeConfigurations.Add(element);
            }

            return this;
        }

        // Check to see if VolumeConfigurations property is set
        internal bool IsSetVolumeConfigurations()
        {
            return this.volumeConfigurations.Count > 0;
        }

        /// <summary>
        /// Whether auto healing is disabled for the layer.
        ///  
        /// </summary>
        public bool EnableAutoHealing
        {
            get { return this.enableAutoHealing ?? default(bool); }
            set { this.enableAutoHealing = value; }
        }

        /// <summary>
        /// Sets the EnableAutoHealing property
        /// </summary>
        /// <param name="enableAutoHealing">The value to set for the EnableAutoHealing property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithEnableAutoHealing(bool enableAutoHealing)
        {
            this.enableAutoHealing = enableAutoHealing;
            return this;
        }
            

        // Check to see if EnableAutoHealing property is set
        internal bool IsSetEnableAutoHealing()
        {
            return this.enableAutoHealing.HasValue;
        }

        /// <summary>
        /// Whether to automatically assign an <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic IP
        /// address</a> to the layer's instances. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-edit.html">How to Edit a Layer</a>.
        ///  
        /// </summary>
        public bool AutoAssignElasticIps
        {
            get { return this.autoAssignElasticIps ?? default(bool); }
            set { this.autoAssignElasticIps = value; }
        }

        /// <summary>
        /// Sets the AutoAssignElasticIps property
        /// </summary>
        /// <param name="autoAssignElasticIps">The value to set for the AutoAssignElasticIps property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithAutoAssignElasticIps(bool autoAssignElasticIps)
        {
            this.autoAssignElasticIps = autoAssignElasticIps;
            return this;
        }
            

        // Check to see if AutoAssignElasticIps property is set
        internal bool IsSetAutoAssignElasticIps()
        {
            return this.autoAssignElasticIps.HasValue;
        }

        /// <summary>
        /// For stacks that are running in a VPC, whether to automatically assign a public IP address to the layer's instances. For more information,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-edit.html">How to Edit a Layer</a>.
        ///  
        /// </summary>
        public bool AutoAssignPublicIps
        {
            get { return this.autoAssignPublicIps ?? default(bool); }
            set { this.autoAssignPublicIps = value; }
        }

        /// <summary>
        /// Sets the AutoAssignPublicIps property
        /// </summary>
        /// <param name="autoAssignPublicIps">The value to set for the AutoAssignPublicIps property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithAutoAssignPublicIps(bool autoAssignPublicIps)
        {
            this.autoAssignPublicIps = autoAssignPublicIps;
            return this;
        }
            

        // Check to see if AutoAssignPublicIps property is set
        internal bool IsSetAutoAssignPublicIps()
        {
            return this.autoAssignPublicIps.HasValue;
        }

        /// <summary>
        /// AWS OpsWorks supports five lifecycle events, <b>setup</b>, <b>configuration</b>, <b>deploy</b>, <b>undeploy</b>, and <b>shutdown</b>. For
        /// each layer, AWS OpsWorks runs a set of standard recipes for each event. In addition, you can provide custom recipes for any or all layers
        /// and events. AWS OpsWorks runs custom event recipes after the standard recipes. <c>LayerCustomRecipes</c> specifies the custom recipes for a
        /// particular layer to be run in response to each of the five events. To specify a recipe, use the cookbook's directory name in the repository
        /// followed by two colons and the recipe name, which is the recipe's file name without the .rb extension. For example: phpapp2::dbsetup
        /// specifies the dbsetup.rb recipe in the repository's phpapp2 folder.
        ///  
        /// </summary>
        public Recipes DefaultRecipes
        {
            get { return this.defaultRecipes; }
            set { this.defaultRecipes = value; }
        }

        /// <summary>
        /// Sets the DefaultRecipes property
        /// </summary>
        /// <param name="defaultRecipes">The value to set for the DefaultRecipes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithDefaultRecipes(Recipes defaultRecipes)
        {
            this.defaultRecipes = defaultRecipes;
            return this;
        }
            

        // Check to see if DefaultRecipes property is set
        internal bool IsSetDefaultRecipes()
        {
            return this.defaultRecipes != null;
        }

        /// <summary>
        /// A <c>LayerCustomRecipes</c> object that specifies the layer's custom recipes.
        ///  
        /// </summary>
        public Recipes CustomRecipes
        {
            get { return this.customRecipes; }
            set { this.customRecipes = value; }
        }

        /// <summary>
        /// Sets the CustomRecipes property
        /// </summary>
        /// <param name="customRecipes">The value to set for the CustomRecipes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithCustomRecipes(Recipes customRecipes)
        {
            this.customRecipes = customRecipes;
            return this;
        }
            

        // Check to see if CustomRecipes property is set
        internal bool IsSetCustomRecipes()
        {
            return this.customRecipes != null;
        }

        /// <summary>
        /// Date when the layer was created.
        ///  
        /// </summary>
        public string CreatedAt
        {
            get { return this.createdAt; }
            set { this.createdAt = value; }
        }

        /// <summary>
        /// Sets the CreatedAt property
        /// </summary>
        /// <param name="createdAt">The value to set for the CreatedAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithCreatedAt(string createdAt)
        {
            this.createdAt = createdAt;
            return this;
        }
            

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this.createdAt != null;
        }

        /// <summary>
        /// Whether to install operating system and package updates when the instance boots. The default value is <c>true</c>. If this value is set to
        /// <c>false</c>, you must then update your instances manually by using <a>CreateDeployment</a> to run the <c>update_dependencies</c> stack
        /// command or manually running <c>yum</c> (Amazon Linux) or <c>apt-get</c> (Ubuntu) on the instances. <note>We strongly recommend using the
        /// default value of <c>true</c>, to ensure that your instances have the latest security updates.</note>
        ///  
        /// </summary>
        public bool InstallUpdatesOnBoot
        {
            get { return this.installUpdatesOnBoot ?? default(bool); }
            set { this.installUpdatesOnBoot = value; }
        }

        /// <summary>
        /// Sets the InstallUpdatesOnBoot property
        /// </summary>
        /// <param name="installUpdatesOnBoot">The value to set for the InstallUpdatesOnBoot property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Layer WithInstallUpdatesOnBoot(bool installUpdatesOnBoot)
        {
            this.installUpdatesOnBoot = installUpdatesOnBoot;
            return this;
        }
            

        // Check to see if InstallUpdatesOnBoot property is set
        internal bool IsSetInstallUpdatesOnBoot()
        {
            return this.installUpdatesOnBoot.HasValue;
        }
    }
}
