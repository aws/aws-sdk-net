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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLayer operation.
    /// <para>Creates a layer. For more information, see How to Create a Layer.</para> <para><b>NOTE:</b>You should use CreateLayer for non-custom
    /// layer types such as PHP App Server only if the stack does not have an existing layer of that type. A stack can have at most one instance of
    /// each non-custom layer; if you attempt to create a second instance, CreateLayer fails. A stack can have an arbitrary number of custom layers,
    /// so you can call CreateLayer as many times as you like for that layer type.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateLayer"/>
    public class CreateLayerRequest : AmazonWebServiceRequest
    {
        private string stackId;
        private string type;
        private string name;
        private string shortname;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();
        private string customInstanceProfileArn;
        private List<string> customSecurityGroupIds = new List<string>();
        private List<string> packages = new List<string>();
        private List<VolumeConfiguration> volumeConfigurations = new List<VolumeConfiguration>();
        private bool? enableAutoHealing;
        private bool? autoAssignElasticIps;
        private Recipes customRecipes;
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
        public CreateLayerRequest WithStackId(string stackId)
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
        /// The layer type. A stack cannot have more than one layer of the same type. This parameter must be set to one of the following: <ul> <li>lb:
        /// An HAProxy layer</li> <li>web: A Static Web Server layer</li> <li>rails-app: A Rails App Server layer</li> <li>php-app: A PHP App Server
        /// layer</li> <li>nodejs-app: A Node.js App Server layer</li> <li>memcached: A Memcached layer</li> <li>db-master: A MySQL layer</li>
        /// <li>monitoring-master: A Ganglia layer</li> <li>custom: A custom layer</li> </ul>
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
        public CreateLayerRequest WithType(string type)
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
        /// The layer name, which is used by the console.
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
        public CreateLayerRequest WithName(string name)
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
        /// The layer short name, which is used internally by AWS OpsWorks and by Chef recipes. The short name is also used as the name for the
        /// directory where your app files are installed. It can have a maximum of 200 characters, which are limited to the alphanumeric characters,
        /// '-', '_', and '.'.
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
        public CreateLayerRequest WithShortname(string shortname)
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
        /// One or more user-defined key/value pairs to be added to the stack attributes bag.
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
        public CreateLayerRequest WithAttributes(params KeyValuePair<string, string>[] pairs)
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
        /// The ARN of an IAM profile that to be used for the layer's EC2 instances. For more information about IAM ARNs, see <a
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
        public CreateLayerRequest WithCustomInstanceProfileArn(string customInstanceProfileArn)
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
        /// An array containing the layer custom security group IDs.
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
        public CreateLayerRequest WithCustomSecurityGroupIds(params string[] customSecurityGroupIds)
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
        public CreateLayerRequest WithCustomSecurityGroupIds(IEnumerable<string> customSecurityGroupIds)
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
        /// An array of <c>Package</c> objects that describe the layer packages.
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
        public CreateLayerRequest WithPackages(params string[] packages)
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
        public CreateLayerRequest WithPackages(IEnumerable<string> packages)
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
        /// A <c>VolumeConfigurations</c> object that describes the layer Amazon EBS volumes.
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
        public CreateLayerRequest WithVolumeConfigurations(params VolumeConfiguration[] volumeConfigurations)
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
        public CreateLayerRequest WithVolumeConfigurations(IEnumerable<VolumeConfiguration> volumeConfigurations)
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
        /// Whether to disable auto healing for the layer.
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
        public CreateLayerRequest WithEnableAutoHealing(bool enableAutoHealing)
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
        /// address</a> to the layer.
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
        public CreateLayerRequest WithAutoAssignElasticIps(bool autoAssignElasticIps)
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
        /// A <c>LayerCustomRecipes</c> object that specifies the layer custom recipes.
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
        public CreateLayerRequest WithCustomRecipes(Recipes customRecipes)
        {
            this.customRecipes = customRecipes;
            return this;
        }
            

        // Check to see if CustomRecipes property is set
        internal bool IsSetCustomRecipes()
        {
            return this.customRecipes != null;
        }
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
        public CreateLayerRequest WithInstallUpdatesOnBoot(bool installUpdatesOnBoot)
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
    
