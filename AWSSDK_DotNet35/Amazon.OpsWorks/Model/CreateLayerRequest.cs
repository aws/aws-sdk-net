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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
    /// Creates a layer. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-create.html">How
    /// to Create a Layer</a>.
    /// 
    ///  <note> 
    /// <para>
    /// You should use <b>CreateLayer</b> for noncustom layer types such as PHP App Server
    /// only if the stack does not have an existing layer of that type. A stack can have at
    /// most one instance of each noncustom layer; if you attempt to create a second instance,
    /// <b>CreateLayer</b> fails. A stack can have an arbitrary number of custom layers, so
    /// you can call <b>CreateLayer</b> as many times as you like for that layer type.
    /// </para>
    ///  </note> 
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached policy that explicitly grants permissions. For
    /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class CreateLayerRequest : AmazonOpsWorksRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private bool? _autoAssignElasticIps;
        private bool? _autoAssignPublicIps;
        private string _customInstanceProfileArn;
        private Recipes _customRecipes;
        private List<string> _customSecurityGroupIds = new List<string>();
        private bool? _enableAutoHealing;
        private bool? _installUpdatesOnBoot;
        private LifecycleEventConfiguration _lifecycleEventConfiguration;
        private string _name;
        private List<string> _packages = new List<string>();
        private string _shortname;
        private string _stackId;
        private LayerType _type;
        private bool? _useEbsOptimizedInstances;
        private List<VolumeConfiguration> _volumeConfigurations = new List<VolumeConfiguration>();

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more user-defined key/value pairs to be added to the stack attributes.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
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
        /// IP address</a> to the layer's instances. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-edit.html">How
        /// to Edit a Layer</a>.
        /// </para>
        /// </summary>
        public bool AutoAssignElasticIps
        {
            get { return this._autoAssignElasticIps.GetValueOrDefault(); }
            set { this._autoAssignElasticIps = value; }
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
        /// address to the layer's instances. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-edit.html">How
        /// to Edit a Layer</a>.
        /// </para>
        /// </summary>
        public bool AutoAssignPublicIps
        {
            get { return this._autoAssignPublicIps.GetValueOrDefault(); }
            set { this._autoAssignPublicIps = value; }
        }

        // Check to see if AutoAssignPublicIps property is set
        internal bool IsSetAutoAssignPublicIps()
        {
            return this._autoAssignPublicIps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomInstanceProfileArn. 
        /// <para>
        /// The ARN of an IAM profile that to be used for the layer's EC2 instances. For more
        /// information about IAM ARNs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using
        /// Identifiers</a>.
        /// </para>
        /// </summary>
        public string CustomInstanceProfileArn
        {
            get { return this._customInstanceProfileArn; }
            set { this._customInstanceProfileArn = value; }
        }

        // Check to see if CustomInstanceProfileArn property is set
        internal bool IsSetCustomInstanceProfileArn()
        {
            return this._customInstanceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomRecipes. 
        /// <para>
        /// A <code>LayerCustomRecipes</code> object that specifies the layer custom recipes.
        /// </para>
        /// </summary>
        public Recipes CustomRecipes
        {
            get { return this._customRecipes; }
            set { this._customRecipes = value; }
        }

        // Check to see if CustomRecipes property is set
        internal bool IsSetCustomRecipes()
        {
            return this._customRecipes != null;
        }

        /// <summary>
        /// Gets and sets the property CustomSecurityGroupIds. 
        /// <para>
        /// An array containing the layer custom security group IDs.
        /// </para>
        /// </summary>
        public List<string> CustomSecurityGroupIds
        {
            get { return this._customSecurityGroupIds; }
            set { this._customSecurityGroupIds = value; }
        }

        // Check to see if CustomSecurityGroupIds property is set
        internal bool IsSetCustomSecurityGroupIds()
        {
            return this._customSecurityGroupIds != null && this._customSecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableAutoHealing. 
        /// <para>
        /// Whether to disable auto healing for the layer.
        /// </para>
        /// </summary>
        public bool EnableAutoHealing
        {
            get { return this._enableAutoHealing.GetValueOrDefault(); }
            set { this._enableAutoHealing = value; }
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
        /// default value is <code>true</code>. To control when updates are installed, set this
        /// value to <code>false</code>. You must then update your instances manually by using
        /// <a>CreateDeployment</a> to run the <code>update_dependencies</code> stack command
        /// or manually running <code>yum</code> (Amazon Linux) or <code>apt-get</code> (Ubuntu)
        /// on the instances. 
        /// </para>
        ///  <note> 
        /// <para>
        /// We strongly recommend using the default value of <code>true</code>, to ensure that
        /// your instances have the latest security updates.
        /// </para>
        ///  </note>
        /// </summary>
        public bool InstallUpdatesOnBoot
        {
            get { return this._installUpdatesOnBoot.GetValueOrDefault(); }
            set { this._installUpdatesOnBoot = value; }
        }

        // Check to see if InstallUpdatesOnBoot property is set
        internal bool IsSetInstallUpdatesOnBoot()
        {
            return this._installUpdatesOnBoot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleEventConfiguration. 
        /// <para>
        /// A LifeCycleEventConfiguration object that you can use to configure the Shutdown event
        /// to specify an execution timeout and enable or disable Elastic Load Balancer connection
        /// draining.
        /// </para>
        /// </summary>
        public LifecycleEventConfiguration LifecycleEventConfiguration
        {
            get { return this._lifecycleEventConfiguration; }
            set { this._lifecycleEventConfiguration = value; }
        }

        // Check to see if LifecycleEventConfiguration property is set
        internal bool IsSetLifecycleEventConfiguration()
        {
            return this._lifecycleEventConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The layer name, which is used by the console.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Packages. 
        /// <para>
        /// An array of <code>Package</code> objects that describe the layer packages.
        /// </para>
        /// </summary>
        public List<string> Packages
        {
            get { return this._packages; }
            set { this._packages = value; }
        }

        // Check to see if Packages property is set
        internal bool IsSetPackages()
        {
            return this._packages != null && this._packages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Shortname. 
        /// <para>
        /// The layer short name, which is used internally by AWS OpsWorks and by Chef recipes.
        /// The short name is also used as the name for the directory where your app files are
        /// installed. It can have a maximum of 200 characters, which are limited to the alphanumeric
        /// characters, '-', '_', and '.'.
        /// </para>
        /// </summary>
        public string Shortname
        {
            get { return this._shortname; }
            set { this._shortname = value; }
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

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The layer type. A stack cannot have more than one built-in layer of the same type.
        /// It can have any number of custom layers.
        /// </para>
        /// </summary>
        public LayerType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UseEbsOptimizedInstances. 
        /// <para>
        /// Whether to use Amazon EBS-optimized instances.
        /// </para>
        /// </summary>
        public bool UseEbsOptimizedInstances
        {
            get { return this._useEbsOptimizedInstances.GetValueOrDefault(); }
            set { this._useEbsOptimizedInstances = value; }
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

        // Check to see if VolumeConfigurations property is set
        internal bool IsSetVolumeConfigurations()
        {
            return this._volumeConfigurations != null && this._volumeConfigurations.Count > 0; 
        }

    }
}