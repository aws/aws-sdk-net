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
    /// Container for the parameters to the CreateStack operation.
    /// Creates a new stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-edit.html">Create
    /// a New Stack</a>.
    /// 
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have an attached
    /// policy that explicitly grants permissions. For more information on user permissions,
    /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class CreateStackRequest : AmazonOpsWorksRequest
    {
        private string _agentVersion;
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private ChefConfiguration _chefConfiguration;
        private StackConfigurationManager _configurationManager;
        private Source _customCookbooksSource;
        private string _customJson;
        private string _defaultAvailabilityZone;
        private string _defaultInstanceProfileArn;
        private string _defaultOs;
        private RootDeviceType _defaultRootDeviceType;
        private string _defaultSshKeyName;
        private string _defaultSubnetId;
        private string _hostnameTheme;
        private string _name;
        private string _region;
        private string _serviceRoleArn;
        private bool? _useCustomCookbooks;
        private bool? _useOpsworksSecurityGroups;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The default AWS OpsWorks Stacks agent version. You have the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto-update - Set this parameter to <code>LATEST</code>. AWS OpsWorks Stacks automatically
        /// installs new agent versions on the stack's instances as soon as they are available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fixed version - Set this parameter to your preferred agent version. To update the
        /// agent version, you must edit the stack configuration and specify a new version. AWS
        /// OpsWorks Stacks then automatically installs that version on the stack's instances.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default setting is the most recent release of the agent. To specify an agent version,
        /// you must use the complete version number, not the abbreviated number shown on the
        /// console. For a list of available agent version numbers, call <a>DescribeAgentVersions</a>.
        /// AgentVersion cannot be set to Chef 12.2.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can also specify an agent version when you create or update an instance, which
        /// overrides the stack's default setting.
        /// </para>
        ///  </note>
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more user-defined key-value pairs to be added to the stack attributes.
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
        /// Gets and sets the property ChefConfiguration. 
        /// <para>
        /// A <code>ChefConfiguration</code> object that specifies whether to enable Berkshelf
        /// and the Berkshelf version on Chef 11.10 stacks. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-creating.html">Create
        /// a New Stack</a>.
        /// </para>
        /// </summary>
        public ChefConfiguration ChefConfiguration
        {
            get { return this._chefConfiguration; }
            set { this._chefConfiguration = value; }
        }

        // Check to see if ChefConfiguration property is set
        internal bool IsSetChefConfiguration()
        {
            return this._chefConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationManager. 
        /// <para>
        /// The configuration manager. When you create a stack we recommend that you use the configuration
        /// manager to specify the Chef version: 12, 11.10, or 11.4 for Linux stacks, or 12.2
        /// for Windows stacks. The default value for Linux stacks is currently 11.4.
        /// </para>
        /// </summary>
        public StackConfigurationManager ConfigurationManager
        {
            get { return this._configurationManager; }
            set { this._configurationManager = value; }
        }

        // Check to see if ConfigurationManager property is set
        internal bool IsSetConfigurationManager()
        {
            return this._configurationManager != null;
        }

        /// <summary>
        /// Gets and sets the property CustomCookbooksSource.
        /// </summary>
        public Source CustomCookbooksSource
        {
            get { return this._customCookbooksSource; }
            set { this._customCookbooksSource = value; }
        }

        // Check to see if CustomCookbooksSource property is set
        internal bool IsSetCustomCookbooksSource()
        {
            return this._customCookbooksSource != null;
        }

        /// <summary>
        /// Gets and sets the property CustomJson. 
        /// <para>
        /// A string that contains user-defined, custom JSON. It can be used to override the corresponding
        /// default stack configuration attribute values or to pass data to recipes. The string
        /// should be in the following format:
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"key1\": \"value1\", \"key2\": \"value2\",...}"</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information on custom JSON, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-json.html">Use
        /// Custom JSON to Modify the Stack Configuration Attributes</a>.
        /// </para>
        /// </summary>
        public string CustomJson
        {
            get { return this._customJson; }
            set { this._customJson = value; }
        }

        // Check to see if CustomJson property is set
        internal bool IsSetCustomJson()
        {
            return this._customJson != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultAvailabilityZone. 
        /// <para>
        /// The stack's default Availability Zone, which must be in the specified region. For
        /// more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a>. If you also specify a value for <code>DefaultSubnetId</code>, the
        /// subnet must be in the same zone. For more information, see the <code>VpcId</code>
        /// parameter description. 
        /// </para>
        /// </summary>
        public string DefaultAvailabilityZone
        {
            get { return this._defaultAvailabilityZone; }
            set { this._defaultAvailabilityZone = value; }
        }

        // Check to see if DefaultAvailabilityZone property is set
        internal bool IsSetDefaultAvailabilityZone()
        {
            return this._defaultAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultInstanceProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM profile that is the default profile for all
        /// of the stack's EC2 instances. For more information about IAM ARNs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using
        /// Identifiers</a>.
        /// </para>
        /// </summary>
        public string DefaultInstanceProfileArn
        {
            get { return this._defaultInstanceProfileArn; }
            set { this._defaultInstanceProfileArn = value; }
        }

        // Check to see if DefaultInstanceProfileArn property is set
        internal bool IsSetDefaultInstanceProfileArn()
        {
            return this._defaultInstanceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultOs. 
        /// <para>
        /// The stack's default operating system, which is installed on every instance unless
        /// you specify a different operating system when you create the instance. You can specify
        /// one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A supported Linux operating system: An Amazon Linux version, such as <code>Amazon
        /// Linux 2017.09</code>, <code>Amazon Linux 2017.03</code>, <code>Amazon Linux 2016.09</code>,
        /// <code>Amazon Linux 2016.03</code>, <code>Amazon Linux 2015.09</code>, or <code>Amazon
        /// Linux 2015.03</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A supported Ubuntu operating system, such as <code>Ubuntu 16.04 LTS</code>, <code>Ubuntu
        /// 14.04 LTS</code>, or <code>Ubuntu 12.04 LTS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CentOS Linux 7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Red Hat Enterprise Linux 7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A supported Windows operating system, such as <code>Microsoft Windows Server 2012
        /// R2 Base</code>, <code>Microsoft Windows Server 2012 R2 with SQL Server Express</code>,
        /// <code>Microsoft Windows Server 2012 R2 with SQL Server Standard</code>, or <code>Microsoft
        /// Windows Server 2012 R2 with SQL Server Web</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A custom AMI: <code>Custom</code>. You specify the custom AMI you want to use when
        /// you create instances. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-custom-ami.html">
        /// Using Custom AMIs</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default option is the current Amazon Linux version. For more information on the
        /// supported operating systems, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-os.html">AWS
        /// OpsWorks Stacks Operating Systems</a>.
        /// </para>
        /// </summary>
        public string DefaultOs
        {
            get { return this._defaultOs; }
            set { this._defaultOs = value; }
        }

        // Check to see if DefaultOs property is set
        internal bool IsSetDefaultOs()
        {
            return this._defaultOs != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRootDeviceType. 
        /// <para>
        /// The default root device type. This value is the default for all instances in the stack,
        /// but you can override it when you create an instance. The default option is <code>instance-store</code>.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html#storage-for-the-root-device">Storage
        /// for the Root Device</a>.
        /// </para>
        /// </summary>
        public RootDeviceType DefaultRootDeviceType
        {
            get { return this._defaultRootDeviceType; }
            set { this._defaultRootDeviceType = value; }
        }

        // Check to see if DefaultRootDeviceType property is set
        internal bool IsSetDefaultRootDeviceType()
        {
            return this._defaultRootDeviceType != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultSshKeyName. 
        /// <para>
        /// A default Amazon EC2 key pair name. The default value is none. If you specify a key
        /// pair name, AWS OpsWorks installs the public key on the instance and you can use the
        /// private key with an SSH client to log in to the instance. For more information, see
        /// <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-ssh.html">
        /// Using SSH to Communicate with an Instance</a> and <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/security-ssh-access.html">
        /// Managing SSH Access</a>. You can override this setting by specifying a different key
        /// pair, or no key pair, when you <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-add.html">
        /// create an instance</a>. 
        /// </para>
        /// </summary>
        public string DefaultSshKeyName
        {
            get { return this._defaultSshKeyName; }
            set { this._defaultSshKeyName = value; }
        }

        // Check to see if DefaultSshKeyName property is set
        internal bool IsSetDefaultSshKeyName()
        {
            return this._defaultSshKeyName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultSubnetId. 
        /// <para>
        /// The stack's default VPC subnet ID. This parameter is required if you specify a value
        /// for the <code>VpcId</code> parameter. All instances are launched into this subnet
        /// unless you specify otherwise when you create the instance. If you also specify a value
        /// for <code>DefaultAvailabilityZone</code>, the subnet must be in that zone. For information
        /// on default values and when this parameter is required, see the <code>VpcId</code>
        /// parameter description. 
        /// </para>
        /// </summary>
        public string DefaultSubnetId
        {
            get { return this._defaultSubnetId; }
            set { this._defaultSubnetId = value; }
        }

        // Check to see if DefaultSubnetId property is set
        internal bool IsSetDefaultSubnetId()
        {
            return this._defaultSubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property HostnameTheme. 
        /// <para>
        /// The stack's host name theme, with spaces replaced by underscores. The theme is used
        /// to generate host names for the stack's instances. By default, <code>HostnameTheme</code>
        /// is set to <code>Layer_Dependent</code>, which creates host names by appending integers
        /// to the layer's short name. The other themes are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Baked_Goods</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Clouds</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Europe_Cities</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Fruits</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Greek_Deities</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Legendary_creatures_from_Japan</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Planets_and_Moons</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Roman_Deities</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Scottish_Islands</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>US_Cities</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Wild_Cats</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To obtain a generated host name, call <code>GetHostNameSuggestion</code>, which returns
        /// a host name based on the current theme.
        /// </para>
        /// </summary>
        public string HostnameTheme
        {
            get { return this._hostnameTheme; }
            set { this._hostnameTheme = value; }
        }

        // Check to see if HostnameTheme property is set
        internal bool IsSetHostnameTheme()
        {
            return this._hostnameTheme != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The stack name.
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The stack's AWS region, such as "ap-south-1". For more information about Amazon regions,
        /// see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions and
        /// Endpoints</a>.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The stack's AWS Identity and Access Management (IAM) role, which allows AWS OpsWorks
        /// Stacks to work with AWS resources on your behalf. You must set this parameter to the
        /// Amazon Resource Name (ARN) for an existing IAM role. For more information about IAM
        /// ARNs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using
        /// Identifiers</a>.
        /// </para>
        /// </summary>
        public string ServiceRoleArn
        {
            get { return this._serviceRoleArn; }
            set { this._serviceRoleArn = value; }
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this._serviceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property UseCustomCookbooks. 
        /// <para>
        /// Whether the stack uses custom cookbooks.
        /// </para>
        /// </summary>
        public bool UseCustomCookbooks
        {
            get { return this._useCustomCookbooks.GetValueOrDefault(); }
            set { this._useCustomCookbooks = value; }
        }

        // Check to see if UseCustomCookbooks property is set
        internal bool IsSetUseCustomCookbooks()
        {
            return this._useCustomCookbooks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseOpsworksSecurityGroups. 
        /// <para>
        /// Whether to associate the AWS OpsWorks Stacks built-in security groups with the stack's
        /// layers.
        /// </para>
        ///  
        /// <para>
        /// AWS OpsWorks Stacks provides a standard set of built-in security groups, one for each
        /// layer, which are associated with layers by default. With <code>UseOpsworksSecurityGroups</code>
        /// you can instead provide your own custom security groups. <code>UseOpsworksSecurityGroups</code>
        /// has the following settings: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// True - AWS OpsWorks Stacks automatically associates the appropriate built-in security
        /// group with each layer (default setting). You can associate additional security groups
        /// with a layer after you create it, but you cannot delete the built-in security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// False - AWS OpsWorks Stacks does not associate built-in security groups with layers.
        /// You must create appropriate EC2 security groups and associate a security group with
        /// each layer that you create. However, you can still manually associate a built-in security
        /// group with a layer on creation; custom security groups are required only for those
        /// layers that need custom settings.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-creating.html">Create
        /// a New Stack</a>.
        /// </para>
        /// </summary>
        public bool UseOpsworksSecurityGroups
        {
            get { return this._useOpsworksSecurityGroups.GetValueOrDefault(); }
            set { this._useOpsworksSecurityGroups = value; }
        }

        // Check to see if UseOpsworksSecurityGroups property is set
        internal bool IsSetUseOpsworksSecurityGroups()
        {
            return this._useOpsworksSecurityGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC that the stack is to be launched into. The VPC must be in the stack's
        /// region. All instances are launched into this VPC. You cannot change the ID later.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If your account supports EC2-Classic, the default value is <code>no VPC</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your account does not support EC2-Classic, the default value is the default VPC
        /// for the specified region.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the VPC ID corresponds to a default VPC and you have specified either the <code>DefaultAvailabilityZone</code>
        /// or the <code>DefaultSubnetId</code> parameter only, AWS OpsWorks Stacks infers the
        /// value of the other parameter. If you specify neither parameter, AWS OpsWorks Stacks
        /// sets these parameters to the first valid Availability Zone for the specified region
        /// and the corresponding default VPC subnet ID, respectively.
        /// </para>
        ///  
        /// <para>
        /// If you specify a nondefault VPC ID, note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It must belong to a VPC in your account that is in the specified region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify a value for <code>DefaultSubnetId</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on how to use AWS OpsWorks Stacks with a VPC, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-vpc.html">Running
        /// a Stack in a VPC</a>. For more information on default VPC and EC2-Classic, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-supported-platforms.html">Supported
        /// Platforms</a>. 
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}