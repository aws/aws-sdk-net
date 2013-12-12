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
    /// Container for the parameters to the UpdateLayer operation.
    /// <para>Updates a specified layer.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    public partial class UpdateLayerRequest : AmazonOpsWorksRequest
    {
        private string layerId;
        private string name;
        private string shortname;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();
        private string customInstanceProfileArn;
        private List<string> customSecurityGroupIds = new List<string>();
        private List<string> packages = new List<string>();
        private List<VolumeConfiguration> volumeConfigurations = new List<VolumeConfiguration>();
        private bool? enableAutoHealing;
        private bool? autoAssignElasticIps;
        private bool? autoAssignPublicIps;
        private Recipes customRecipes;
        private bool? installUpdatesOnBoot;


        /// <summary>
        /// The layer ID.
        ///  
        /// </summary>
        public string LayerId
        {
            get { return this.layerId; }
            set { this.layerId = value; }
        }

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this.layerId != null;
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

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The layer short name, which is used internally by AWS OpsWorksand by Chef. The short name is also used as the name for the directory where
        /// your app files are installed. It can have a maximum of 200 characters and must be in the following format: /\A[a-z0-9\-\_\.]+\Z/.
        ///  
        /// </summary>
        public string Shortname
        {
            get { return this.shortname; }
            set { this.shortname = value; }
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

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
        }

        /// <summary>
        /// The ARN of an IAM profile to be used for all of the layer's EC2 instances. For more information about IAM ARNs, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using Identifiers</a>.
        ///  
        /// </summary>
        public string CustomInstanceProfileArn
        {
            get { return this.customInstanceProfileArn; }
            set { this.customInstanceProfileArn = value; }
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

        // Check to see if CustomSecurityGroupIds property is set
        internal bool IsSetCustomSecurityGroupIds()
        {
            return this.customSecurityGroupIds.Count > 0;
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

        // Check to see if AutoAssignPublicIps property is set
        internal bool IsSetAutoAssignPublicIps()
        {
            return this.autoAssignPublicIps.HasValue;
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

        // Check to see if CustomRecipes property is set
        internal bool IsSetCustomRecipes()
        {
            return this.customRecipes != null;
        }

        /// <summary>
        /// Whether to install operating system and package updates when the instance boots. The default value is <c>true</c>. To control when updates
        /// are installed, set this value to <c>false</c>. You must then update your instances manually by using <a>CreateDeployment</a> to run the
        /// <c>update_dependencies</c> stack command or manually running <c>yum</c> (Amazon Linux) or <c>apt-get</c> (Ubuntu) on the instances. <note>We
        /// strongly recommend using the default value of <c>true</c>, to ensure that your instances have the latest security updates.</note>
        ///  
        /// </summary>
        public bool InstallUpdatesOnBoot
        {
            get { return this.installUpdatesOnBoot ?? default(bool); }
            set { this.installUpdatesOnBoot = value; }
        }

        // Check to see if InstallUpdatesOnBoot property is set
        internal bool IsSetInstallUpdatesOnBoot()
        {
            return this.installUpdatesOnBoot.HasValue;
        }

    }
}
    
