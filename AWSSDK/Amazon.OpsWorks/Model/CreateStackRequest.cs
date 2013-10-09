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
    /// Container for the parameters to the CreateStack operation.
    /// <para>Creates a new stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-edit.html"
    /// >Create a New Stack</a> .</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateStack"/>
    public class CreateStackRequest : AmazonWebServiceRequest
    {
        private string name;
        private string region;
        private string vpcId;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();
        private string serviceRoleArn;
        private string defaultInstanceProfileArn;
        private string defaultOs;
        private string hostnameTheme;
        private string defaultAvailabilityZone;
        private string defaultSubnetId;
        private string customJson;
        private StackConfigurationManager configurationManager;
        private bool? useCustomCookbooks;
        private Source customCookbooksSource;
        private string defaultSshKeyName;
        private string defaultRootDeviceType;

        /// <summary>
        /// The stack name.
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
        public CreateStackRequest WithName(string name)
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
        /// The stack AWS region, such as "us-east-1". For more information about Amazon regions, see <a
        /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions and Endpoints</a>.
        ///  
        /// </summary>
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        /// <summary>
        /// Sets the Region property
        /// </summary>
        /// <param name="region">The value to set for the Region property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithRegion(string region)
        {
            this.region = region;
            return this;
        }
            

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;
        }

        /// <summary>
        /// The ID of the VPC that the stack is to be launched into. It must be in the specified region. All instances will be launched into this VPC,
        /// and you cannot change the ID later. <ul> <li>If your account supports EC2 Classic, the default value is no VPC.</li> <li>If your account
        /// does not support EC2 Classic, the default value is the default VPC for the specified region.</li> </ul> If the VPC ID corresponds to a
        /// default VPC and you have specified either the <c>DefaultAvailabilityZone</c> or the <c>DefaultSubnetId</c> parameter only, AWS OpsWorks
        /// infers the value of the other parameter. If you specify neither parameter, AWS OpsWorks sets these parameters to the first valid
        /// Availability Zone for the specified region and the corresponding default VPC subnet ID, respectively. If you specify a nondefault VPC ID,
        /// note the following: <ul> <li>It must belong to a VPC in your account that is in the specified region.</li> <li>You must specify a value for
        /// <c>DefaultSubnetId</c>.</li> </ul> For more information on how to use AWS OpsWorks with a VPC, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-vpc.html">Running a Stack in a VPC</a>. For more information on
        /// default VPC and EC2 Classic, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-supported-platforms.html">Supported
        /// Platforms</a>.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The value to set for the VpcId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithVpcId(string vpcId)
        {
            this.vpcId = vpcId;
            return this;
        }
            

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
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
        public CreateStackRequest WithAttributes(params KeyValuePair<string, string>[] pairs)
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
        /// The stack AWS Identity and Access Management (IAM) role, which allows AWS OpsWorks to work with AWS resources on your behalf. You must set
        /// this parameter to the Amazon Resource Name (ARN) for an existing IAM role. For more information about IAM ARNs, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using Identifiers</a>.
        ///  
        /// </summary>
        public string ServiceRoleArn
        {
            get { return this.serviceRoleArn; }
            set { this.serviceRoleArn = value; }
        }

        /// <summary>
        /// Sets the ServiceRoleArn property
        /// </summary>
        /// <param name="serviceRoleArn">The value to set for the ServiceRoleArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithServiceRoleArn(string serviceRoleArn)
        {
            this.serviceRoleArn = serviceRoleArn;
            return this;
        }
            

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this.serviceRoleArn != null;
        }

        /// <summary>
        /// The ARN of an IAM profile that is the default profile for all of the stack's EC2 instances. For more information about IAM ARNs, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using Identifiers</a>.
        ///  
        /// </summary>
        public string DefaultInstanceProfileArn
        {
            get { return this.defaultInstanceProfileArn; }
            set { this.defaultInstanceProfileArn = value; }
        }

        /// <summary>
        /// Sets the DefaultInstanceProfileArn property
        /// </summary>
        /// <param name="defaultInstanceProfileArn">The value to set for the DefaultInstanceProfileArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithDefaultInstanceProfileArn(string defaultInstanceProfileArn)
        {
            this.defaultInstanceProfileArn = defaultInstanceProfileArn;
            return this;
        }
            

        // Check to see if DefaultInstanceProfileArn property is set
        internal bool IsSetDefaultInstanceProfileArn()
        {
            return this.defaultInstanceProfileArn != null;
        }

        /// <summary>
        /// The stack's default operating system, which must be set to <c>Amazon Linux</c> or <c>Ubuntu 12.04 LTS</c>. The default option is <c>Amazon
        /// Linux</c>.
        ///  
        /// </summary>
        public string DefaultOs
        {
            get { return this.defaultOs; }
            set { this.defaultOs = value; }
        }

        /// <summary>
        /// Sets the DefaultOs property
        /// </summary>
        /// <param name="defaultOs">The value to set for the DefaultOs property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithDefaultOs(string defaultOs)
        {
            this.defaultOs = defaultOs;
            return this;
        }
            

        // Check to see if DefaultOs property is set
        internal bool IsSetDefaultOs()
        {
            return this.defaultOs != null;
        }

        /// <summary>
        /// The stack's host name theme, with spaces are replaced by underscores. The theme is used to generate host names for the stack's instances. By
        /// default, <c>HostnameTheme</c> is set to Layer_Dependent, which creates host names by appending integers to the layer's short name. The other
        /// themes are: <ul> <li>Baked_Goods</li> <li>Clouds</li> <li>European_Cities</li> <li>Fruits</li> <li>Greek_Deities</li>
        /// <li>Legendary_Creatures_from_Japan</li> <li>Planets_and_Moons</li> <li>Roman_Deities</li> <li>Scottish_Islands</li> <li>US_Cities</li>
        /// <li>Wild_Cats</li> </ul> To obtain a generated host name, call <c>GetHostNameSuggestion</c>, which returns a host name based on the current
        /// theme.
        ///  
        /// </summary>
        public string HostnameTheme
        {
            get { return this.hostnameTheme; }
            set { this.hostnameTheme = value; }
        }

        /// <summary>
        /// Sets the HostnameTheme property
        /// </summary>
        /// <param name="hostnameTheme">The value to set for the HostnameTheme property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithHostnameTheme(string hostnameTheme)
        {
            this.hostnameTheme = hostnameTheme;
            return this;
        }
            

        // Check to see if HostnameTheme property is set
        internal bool IsSetHostnameTheme()
        {
            return this.hostnameTheme != null;
        }

        /// <summary>
        /// The stack's default Availability Zone, which must be in the specified region. For more information, see <a
        /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions and Endpoints</a>. If you also specify a value for
        /// <c>DefaultSubnetId</c>, the subnet must be in the same zone. For more information, see the <c>VpcId</c> parameter description.
        ///  
        /// </summary>
        public string DefaultAvailabilityZone
        {
            get { return this.defaultAvailabilityZone; }
            set { this.defaultAvailabilityZone = value; }
        }

        /// <summary>
        /// Sets the DefaultAvailabilityZone property
        /// </summary>
        /// <param name="defaultAvailabilityZone">The value to set for the DefaultAvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithDefaultAvailabilityZone(string defaultAvailabilityZone)
        {
            this.defaultAvailabilityZone = defaultAvailabilityZone;
            return this;
        }
            

        // Check to see if DefaultAvailabilityZone property is set
        internal bool IsSetDefaultAvailabilityZone()
        {
            return this.defaultAvailabilityZone != null;
        }

        /// <summary>
        /// The stack's default subnet ID. All instances will be launched into this subnet unless you specify otherwise when you create the instance. If
        /// you also specify a value for <c>DefaultAvailabilityZone</c>, the subnet must be in that zone. For information on default values and when
        /// this parameter is required, see the <c>VpcId</c> parameter description.
        ///  
        /// </summary>
        public string DefaultSubnetId
        {
            get { return this.defaultSubnetId; }
            set { this.defaultSubnetId = value; }
        }

        /// <summary>
        /// Sets the DefaultSubnetId property
        /// </summary>
        /// <param name="defaultSubnetId">The value to set for the DefaultSubnetId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithDefaultSubnetId(string defaultSubnetId)
        {
            this.defaultSubnetId = defaultSubnetId;
            return this;
        }
            

        // Check to see if DefaultSubnetId property is set
        internal bool IsSetDefaultSubnetId()
        {
            return this.defaultSubnetId != null;
        }

        /// <summary>
        /// A string that contains user-defined, custom JSON. It is used to override the corresponding default stack configuration JSON values. The
        /// string should be in the following format and must escape characters such as '"'.: <c>"{\"key1\": \"value1\", \"key2\": \"value2\",...}"</c>
        /// For more information on custom JSON, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-json.html">Use Custom
        /// JSON to Modify the Stack Configuration JSON</a>.
        ///  
        /// </summary>
        public string CustomJson
        {
            get { return this.customJson; }
            set { this.customJson = value; }
        }

        /// <summary>
        /// Sets the CustomJson property
        /// </summary>
        /// <param name="customJson">The value to set for the CustomJson property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithCustomJson(string customJson)
        {
            this.customJson = customJson;
            return this;
        }
            

        // Check to see if CustomJson property is set
        internal bool IsSetCustomJson()
        {
            return this.customJson != null;
        }

        /// <summary>
        /// The configuration manager. When you create a stack we recommend that you use the configuration manager to specify the Chef version, 0.9 or
        /// 11.4. The default value is currently 0.9. However, we expect to change the default value to 11.4 in September 2013.
        ///  
        /// </summary>
        public StackConfigurationManager ConfigurationManager
        {
            get { return this.configurationManager; }
            set { this.configurationManager = value; }
        }

        /// <summary>
        /// Sets the ConfigurationManager property
        /// </summary>
        /// <param name="configurationManager">The value to set for the ConfigurationManager property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithConfigurationManager(StackConfigurationManager configurationManager)
        {
            this.configurationManager = configurationManager;
            return this;
        }
            

        // Check to see if ConfigurationManager property is set
        internal bool IsSetConfigurationManager()
        {
            return this.configurationManager != null;
        }

        /// <summary>
        /// Whether the stack uses custom cookbooks.
        ///  
        /// </summary>
        public bool UseCustomCookbooks
        {
            get { return this.useCustomCookbooks ?? default(bool); }
            set { this.useCustomCookbooks = value; }
        }

        /// <summary>
        /// Sets the UseCustomCookbooks property
        /// </summary>
        /// <param name="useCustomCookbooks">The value to set for the UseCustomCookbooks property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithUseCustomCookbooks(bool useCustomCookbooks)
        {
            this.useCustomCookbooks = useCustomCookbooks;
            return this;
        }
            

        // Check to see if UseCustomCookbooks property is set
        internal bool IsSetUseCustomCookbooks()
        {
            return this.useCustomCookbooks.HasValue;
        }

        /// <summary>
        /// Contains the information required to retrieve an app or cookbook from a repository. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html">Creating Apps</a> or <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook.html">Custom Recipes and Cookbooks</a>.
        ///  
        /// </summary>
        public Source CustomCookbooksSource
        {
            get { return this.customCookbooksSource; }
            set { this.customCookbooksSource = value; }
        }

        /// <summary>
        /// Sets the CustomCookbooksSource property
        /// </summary>
        /// <param name="customCookbooksSource">The value to set for the CustomCookbooksSource property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithCustomCookbooksSource(Source customCookbooksSource)
        {
            this.customCookbooksSource = customCookbooksSource;
            return this;
        }
            

        // Check to see if CustomCookbooksSource property is set
        internal bool IsSetCustomCookbooksSource()
        {
            return this.customCookbooksSource != null;
        }

        /// <summary>
        /// A default SSH key for the stack instances. You can override this value when you create or update an instance.
        ///  
        /// </summary>
        public string DefaultSshKeyName
        {
            get { return this.defaultSshKeyName; }
            set { this.defaultSshKeyName = value; }
        }

        /// <summary>
        /// Sets the DefaultSshKeyName property
        /// </summary>
        /// <param name="defaultSshKeyName">The value to set for the DefaultSshKeyName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithDefaultSshKeyName(string defaultSshKeyName)
        {
            this.defaultSshKeyName = defaultSshKeyName;
            return this;
        }
            

        // Check to see if DefaultSshKeyName property is set
        internal bool IsSetDefaultSshKeyName()
        {
            return this.defaultSshKeyName != null;
        }

        /// <summary>
        /// The default root device type. This value is used by default for all instances in the cloned stack, but you can override it when you create
        /// an instance. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html#storage-for-the-root-device">Storage for the Root Device</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ebs, instance-store</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultRootDeviceType
        {
            get { return this.defaultRootDeviceType; }
            set { this.defaultRootDeviceType = value; }
        }

        /// <summary>
        /// Sets the DefaultRootDeviceType property
        /// </summary>
        /// <param name="defaultRootDeviceType">The value to set for the DefaultRootDeviceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateStackRequest WithDefaultRootDeviceType(string defaultRootDeviceType)
        {
            this.defaultRootDeviceType = defaultRootDeviceType;
            return this;
        }
            

        // Check to see if DefaultRootDeviceType property is set
        internal bool IsSetDefaultRootDeviceType()
        {
            return this.defaultRootDeviceType != null;
        }
    }
}
    
