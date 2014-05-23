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
    /// Describes a stack.
    /// </summary>
    public partial class Stack
    {
        private string _arn;
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private ChefConfiguration _chefConfiguration;
        private StackConfigurationManager _configurationManager;
        private string _createdAt;
        private Source _customCookbooksSource;
        private string _customJson;
        private string _defaultAvailabilityZone;
        private string _defaultInstanceProfileArn;
        private string _defaultOs;
        private string _defaultRootDeviceType;
        private string _defaultSshKeyName;
        private string _defaultSubnetId;
        private string _hostnameTheme;
        private string _name;
        private string _region;
        private string _serviceRoleArn;
        private string _stackId;
        private bool? _useCustomCookbooks;
        private bool? _useOpsworksSecurityGroups;
        private string _vpcId;


        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The stack's ARN.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }


        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithArn(string arn)
        {
            this._arn = arn;
            return this;
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }


        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The stack's attributes.
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
        public Stack WithAttributes(params KeyValuePair<string, string>[] pairs)
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
        /// Gets and sets the property ChefConfiguration. 
        /// <para>
        /// A <code>ChefConfiguration</code> object that specifies whether to enable Berkshelf
        /// and the Berkshelf version.    For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-creating.html">Create
        /// a New Stack</a>.
        /// </para>
        /// </summary>
        public ChefConfiguration ChefConfiguration
        {
            get { return this._chefConfiguration; }
            set { this._chefConfiguration = value; }
        }


        /// <summary>
        /// Sets the ChefConfiguration property
        /// </summary>
        /// <param name="chefConfiguration">The value to set for the ChefConfiguration property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithChefConfiguration(ChefConfiguration chefConfiguration)
        {
            this._chefConfiguration = chefConfiguration;
            return this;
        }

        // Check to see if ChefConfiguration property is set
        internal bool IsSetChefConfiguration()
        {
            return this._chefConfiguration != null;
        }


        /// <summary>
        /// Gets and sets the property ConfigurationManager. 
        /// <para>
        /// The configuration manager.
        /// </para>
        /// </summary>
        public StackConfigurationManager ConfigurationManager
        {
            get { return this._configurationManager; }
            set { this._configurationManager = value; }
        }


        /// <summary>
        /// Sets the ConfigurationManager property
        /// </summary>
        /// <param name="configurationManager">The value to set for the ConfigurationManager property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithConfigurationManager(StackConfigurationManager configurationManager)
        {
            this._configurationManager = configurationManager;
            return this;
        }

        // Check to see if ConfigurationManager property is set
        internal bool IsSetConfigurationManager()
        {
            return this._configurationManager != null;
        }


        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Date when the stack was created.
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
        public Stack WithCreatedAt(string createdAt)
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
        /// Gets and sets the property CustomCookbooksSource.
        /// </summary>
        public Source CustomCookbooksSource
        {
            get { return this._customCookbooksSource; }
            set { this._customCookbooksSource = value; }
        }


        /// <summary>
        /// Sets the CustomCookbooksSource property
        /// </summary>
        /// <param name="customCookbooksSource">The value to set for the CustomCookbooksSource property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithCustomCookbooksSource(Source customCookbooksSource)
        {
            this._customCookbooksSource = customCookbooksSource;
            return this;
        }

        // Check to see if CustomCookbooksSource property is set
        internal bool IsSetCustomCookbooksSource()
        {
            return this._customCookbooksSource != null;
        }


        /// <summary>
        /// Gets and sets the property CustomJson. 
        /// <para>
        /// A string that contains user-defined, custom JSON. It is used to override the corresponding
        /// default stack configuration JSON values.The string should be in the following format
        /// and must escape characters such as '"'.:
        /// </para>
        ///     
        /// <para>
        /// <code>"{\"key1\": \"value1\", \"key2\": \"value2\",...}"</code>
        /// </para>
        ///   
        /// <para>
        /// For more information on custom JSON, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-json.html">Use
        /// Custom JSON to Modify the Stack Configuration JSON</a>.
        /// </para>
        /// </summary>
        public string CustomJson
        {
            get { return this._customJson; }
            set { this._customJson = value; }
        }


        /// <summary>
        /// Sets the CustomJson property
        /// </summary>
        /// <param name="customJson">The value to set for the CustomJson property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithCustomJson(string customJson)
        {
            this._customJson = customJson;
            return this;
        }

        // Check to see if CustomJson property is set
        internal bool IsSetCustomJson()
        {
            return this._customJson != null;
        }


        /// <summary>
        /// Gets and sets the property DefaultAvailabilityZone. 
        /// <para>
        /// The stack's default Availability Zone. For more information, see  <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a>.
        /// </para>
        /// </summary>
        public string DefaultAvailabilityZone
        {
            get { return this._defaultAvailabilityZone; }
            set { this._defaultAvailabilityZone = value; }
        }


        /// <summary>
        /// Sets the DefaultAvailabilityZone property
        /// </summary>
        /// <param name="defaultAvailabilityZone">The value to set for the DefaultAvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithDefaultAvailabilityZone(string defaultAvailabilityZone)
        {
            this._defaultAvailabilityZone = defaultAvailabilityZone;
            return this;
        }

        // Check to see if DefaultAvailabilityZone property is set
        internal bool IsSetDefaultAvailabilityZone()
        {
            return this._defaultAvailabilityZone != null;
        }


        /// <summary>
        /// Gets and sets the property DefaultInstanceProfileArn. 
        /// <para>
        /// The ARN of an IAM profile that is the default profile for all of the stack's EC2 instances.
        /// For more information about IAM ARNs, see  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using
        /// Identifiers</a>.
        /// </para>
        /// </summary>
        public string DefaultInstanceProfileArn
        {
            get { return this._defaultInstanceProfileArn; }
            set { this._defaultInstanceProfileArn = value; }
        }


        /// <summary>
        /// Sets the DefaultInstanceProfileArn property
        /// </summary>
        /// <param name="defaultInstanceProfileArn">The value to set for the DefaultInstanceProfileArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithDefaultInstanceProfileArn(string defaultInstanceProfileArn)
        {
            this._defaultInstanceProfileArn = defaultInstanceProfileArn;
            return this;
        }

        // Check to see if DefaultInstanceProfileArn property is set
        internal bool IsSetDefaultInstanceProfileArn()
        {
            return this._defaultInstanceProfileArn != null;
        }


        /// <summary>
        /// Gets and sets the property DefaultOs. 
        /// <para>
        /// The stack's default operating system, which must be set to <code>Amazon Linux</code>
        /// or <code>Ubuntu 12.04 LTS</code>.         The default option is <code>Amazon Linux</code>.
        ///  
        /// </para>
        /// </summary>
        public string DefaultOs
        {
            get { return this._defaultOs; }
            set { this._defaultOs = value; }
        }


        /// <summary>
        /// Sets the DefaultOs property
        /// </summary>
        /// <param name="defaultOs">The value to set for the DefaultOs property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithDefaultOs(string defaultOs)
        {
            this._defaultOs = defaultOs;
            return this;
        }

        // Check to see if DefaultOs property is set
        internal bool IsSetDefaultOs()
        {
            return this._defaultOs != null;
        }


        /// <summary>
        /// Gets and sets the property DefaultRootDeviceType. 
        /// <para>
        /// The default root device type. This value is used by default for all instances in the
        /// stack,         but you can override it when you create an instance. For more information,
        /// see  <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html#storage-for-the-root-device">Storage
        /// for the Root Device</a>.
        /// </para>
        /// </summary>
        public string DefaultRootDeviceType
        {
            get { return this._defaultRootDeviceType; }
            set { this._defaultRootDeviceType = value; }
        }


        /// <summary>
        /// Sets the DefaultRootDeviceType property
        /// </summary>
        /// <param name="defaultRootDeviceType">The value to set for the DefaultRootDeviceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithDefaultRootDeviceType(string defaultRootDeviceType)
        {
            this._defaultRootDeviceType = defaultRootDeviceType;
            return this;
        }

        // Check to see if DefaultRootDeviceType property is set
        internal bool IsSetDefaultRootDeviceType()
        {
            return this._defaultRootDeviceType != null;
        }


        /// <summary>
        /// Gets and sets the property DefaultSshKeyName. 
        /// <para>
        /// A default SSH key for the stack's instances. You can override this value when you
        /// create or update an instance.
        /// </para>
        /// </summary>
        public string DefaultSshKeyName
        {
            get { return this._defaultSshKeyName; }
            set { this._defaultSshKeyName = value; }
        }


        /// <summary>
        /// Sets the DefaultSshKeyName property
        /// </summary>
        /// <param name="defaultSshKeyName">The value to set for the DefaultSshKeyName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithDefaultSshKeyName(string defaultSshKeyName)
        {
            this._defaultSshKeyName = defaultSshKeyName;
            return this;
        }

        // Check to see if DefaultSshKeyName property is set
        internal bool IsSetDefaultSshKeyName()
        {
            return this._defaultSshKeyName != null;
        }


        /// <summary>
        /// Gets and sets the property DefaultSubnetId. 
        /// <para>
        /// The default subnet ID, if the stack is running in a VPC.
        /// </para>
        /// </summary>
        public string DefaultSubnetId
        {
            get { return this._defaultSubnetId; }
            set { this._defaultSubnetId = value; }
        }


        /// <summary>
        /// Sets the DefaultSubnetId property
        /// </summary>
        /// <param name="defaultSubnetId">The value to set for the DefaultSubnetId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithDefaultSubnetId(string defaultSubnetId)
        {
            this._defaultSubnetId = defaultSubnetId;
            return this;
        }

        // Check to see if DefaultSubnetId property is set
        internal bool IsSetDefaultSubnetId()
        {
            return this._defaultSubnetId != null;
        }


        /// <summary>
        /// Gets and sets the property HostnameTheme. 
        /// <para>
        /// The stack host name theme, with spaces replaced by underscores.
        /// </para>
        /// </summary>
        public string HostnameTheme
        {
            get { return this._hostnameTheme; }
            set { this._hostnameTheme = value; }
        }


        /// <summary>
        /// Sets the HostnameTheme property
        /// </summary>
        /// <param name="hostnameTheme">The value to set for the HostnameTheme property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithHostnameTheme(string hostnameTheme)
        {
            this._hostnameTheme = hostnameTheme;
            return this;
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


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithName(string name)
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The stack AWS region, such as "us-east-1". For more information about AWS regions,
        /// see  <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions and
        /// Endpoints</a>.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }


        /// <summary>
        /// Sets the Region property
        /// </summary>
        /// <param name="region">The value to set for the Region property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithRegion(string region)
        {
            this._region = region;
            return this;
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }


        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The stack AWS Identity and Access Management (IAM) role.
        /// </para>
        /// </summary>
        public string ServiceRoleArn
        {
            get { return this._serviceRoleArn; }
            set { this._serviceRoleArn = value; }
        }


        /// <summary>
        /// Sets the ServiceRoleArn property
        /// </summary>
        /// <param name="serviceRoleArn">The value to set for the ServiceRoleArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithServiceRoleArn(string serviceRoleArn)
        {
            this._serviceRoleArn = serviceRoleArn;
            return this;
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this._serviceRoleArn != null;
        }


        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID.
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
        public Stack WithStackId(string stackId)
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


        /// <summary>
        /// Sets the UseCustomCookbooks property
        /// </summary>
        /// <param name="useCustomCookbooks">The value to set for the UseCustomCookbooks property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithUseCustomCookbooks(bool useCustomCookbooks)
        {
            this._useCustomCookbooks = useCustomCookbooks;
            return this;
        }

        // Check to see if UseCustomCookbooks property is set
        internal bool IsSetUseCustomCookbooks()
        {
            return this._useCustomCookbooks.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property UseOpsworksSecurityGroups. 
        /// <para>
        /// Whether the stack automatically associates the AWS OpsWorks built-in security groups
        /// with the stack's layers.
        /// </para>
        /// </summary>
        public bool UseOpsworksSecurityGroups
        {
            get { return this._useOpsworksSecurityGroups.GetValueOrDefault(); }
            set { this._useOpsworksSecurityGroups = value; }
        }


        /// <summary>
        /// Sets the UseOpsworksSecurityGroups property
        /// </summary>
        /// <param name="useOpsworksSecurityGroups">The value to set for the UseOpsworksSecurityGroups property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithUseOpsworksSecurityGroups(bool useOpsworksSecurityGroups)
        {
            this._useOpsworksSecurityGroups = useOpsworksSecurityGroups;
            return this;
        }

        // Check to see if UseOpsworksSecurityGroups property is set
        internal bool IsSetUseOpsworksSecurityGroups()
        {
            return this._useOpsworksSecurityGroups.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID, if the stack is running in a VPC.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }


        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The value to set for the VpcId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Stack WithVpcId(string vpcId)
        {
            this._vpcId = vpcId;
            return this;
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}