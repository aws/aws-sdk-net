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
    /// <para>Describes a stack.</para>
    /// </summary>
    public class Stack
    {
        
        private string stackId;
        private string name;
        private string region;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();
        private string serviceRoleArn;
        private string defaultInstanceProfileArn;
        private string defaultOs;
        private string hostnameTheme;
        private string defaultAvailabilityZone;
        private string customJson;
        private bool? useCustomCookbooks;
        private Source customCookbooksSource;
        private string defaultSshKeyName;
        private string createdAt;
        private string defaultRootDeviceType;

        /// <summary>
        /// The stack ID.
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
        public Stack WithStackId(string stackId)
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
        public Stack WithName(string name)
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
        /// The stack AWS region, such as "us-east-1". For more information about AWS regions, see <a
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
        public Stack WithRegion(string region)
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
        /// The contents of the stack's attributes bag.
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
            return this.attributes != null;
        }

        /// <summary>
        /// The stack AWS Identity and Access Management (IAM) role.
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
        public Stack WithServiceRoleArn(string serviceRoleArn)
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
        public Stack WithDefaultInstanceProfileArn(string defaultInstanceProfileArn)
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
        /// The cloned stack default operating system, which must be either "Amazon Linux" or "Ubuntu 12.04 LTS".
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
        public Stack WithDefaultOs(string defaultOs)
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
        /// The stack host name theme, with spaces replaced by underscores.
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
        public Stack WithHostnameTheme(string hostnameTheme)
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
        /// The stack's default Availability Zone. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a>.
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
        public Stack WithDefaultAvailabilityZone(string defaultAvailabilityZone)
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
        /// A string that contains user-defined, custom JSON. It is used to override the corresponding default stack configuration JSON values. The
        /// string should be in the following format and must escape characters such as '"'.: <c>"{\"key1\": \"value1\", \"key2\": \"value2\",...}"</c>
        /// For more information on custom JSON, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-json.html"> Use Custom
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
        public Stack WithCustomJson(string customJson)
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
        public Stack WithUseCustomCookbooks(bool useCustomCookbooks)
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
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook-installingcustom.html">Custom Recipes and Cookbooks</a>.
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
        public Stack WithCustomCookbooksSource(Source customCookbooksSource)
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
        /// A default SSH key for the stack's instances. You can override this value when you create or update an instance.
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
        public Stack WithDefaultSshKeyName(string defaultSshKeyName)
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
        /// Date when the stack was created.
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
        public Stack WithCreatedAt(string createdAt)
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
        public Stack WithDefaultRootDeviceType(string defaultRootDeviceType)
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
