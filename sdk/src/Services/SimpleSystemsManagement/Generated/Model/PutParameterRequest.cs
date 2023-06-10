/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the PutParameter operation.
    /// Add a parameter to the system.
    /// </summary>
    public partial class PutParameterRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _allowedPattern;
        private string _dataType;
        private string _description;
        private string _keyId;
        private string _name;
        private bool? _overwrite;
        private string _policies;
        private List<Tag> _tags = new List<Tag>();
        private ParameterTier _tier;
        private ParameterType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property AllowedPattern. 
        /// <para>
        /// A regular expression used to validate the parameter value. For example, for String
        /// types with values restricted to numbers, you can specify the following: AllowedPattern=^\d+$
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AllowedPattern
        {
            get { return this._allowedPattern; }
            set { this._allowedPattern = value; }
        }

        // Check to see if AllowedPattern property is set
        internal bool IsSetAllowedPattern()
        {
            return this._allowedPattern != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type for a <code>String</code> parameter. Supported data types include plain
        /// text and Amazon Machine Image (AMI) IDs.
        /// </para>
        ///  
        /// <para>
        ///  <b>The following data type values are supported.</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>text</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aws:ec2:image</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aws:ssm:integration</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you create a <code>String</code> parameter and specify <code>aws:ec2:image</code>,
        /// Amazon Web Services Systems Manager validates the parameter value is in the required
        /// format, such as <code>ami-12345abcdeEXAMPLE</code>, and that the specified AMI is
        /// available in your Amazon Web Services account.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the action is successful, the service sends back an HTTP 200 response which indicates
        /// a successful <code>PutParameter</code> call for all cases except for data type <code>aws:ec2:image</code>.
        /// If you call <code>PutParameter</code> with <code>aws:ec2:image</code> data type, a
        /// successful HTTP 200 response does not guarantee that your parameter was successfully
        /// created or updated. The <code>aws:ec2:image</code> value is validated asynchronously,
        /// and the <code>PutParameter</code> call returns before the validation is complete.
        /// If you submit an invalid AMI value, the PutParameter operation will return success,
        /// but the asynchronous validation will fail and the parameter will not be created or
        /// updated. To monitor whether your <code>aws:ec2:image</code> parameters are created
        /// successfully, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-cwe.html">Setting
        /// up notifications or trigger actions based on Parameter Store events</a>. For more
        /// information about AMI format validation , see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-ec2-aliases.html">Native
        /// parameter support for Amazon Machine Image (AMI) IDs</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Information about the parameter that you want to add to the system. Optional but recommended.
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't enter personally identifiable information in this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Key Management Service (KMS) ID that you want to use to encrypt a parameter. Use
        /// a custom key for better security. Required for parameters that use the <code>SecureString</code>
        /// data type.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a key ID, the system uses the default key associated with your
        /// Amazon Web Services account which is not as secure as using a custom key.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To use a custom KMS key, choose the <code>SecureString</code> data type with the <code>Key
        /// ID</code> parameter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The fully qualified name of the parameter that you want to add to the system. The
        /// fully qualified name includes the complete hierarchy of the parameter path and name.
        /// For parameters in a hierarchy, you must include a leading forward slash character
        /// (/) when you create or reference a parameter. For example: <code>/Dev/DBServer/MySQL/db-string13</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Naming Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Parameter names are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A parameter name must be unique within an Amazon Web Services Region
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A parameter name can't be prefixed with "<code>aws</code>" or "<code>ssm</code>" (case-insensitive).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Parameter names can include only the following symbols and letters: <code>a-zA-Z0-9_.-</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// In addition, the slash character ( / ) is used to delineate hierarchies in parameter
        /// names. For example: <code>/Dev/Production/East/Project-ABC/MyParameter</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A parameter name can't include spaces.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Parameter hierarchies are limited to a maximum depth of fifteen levels.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For additional information about valid values for parameter names, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-su-create.html">Creating
        /// Systems Manager parameters</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum length constraint of 2048 characters listed below includes 1037 characters
        /// reserved for internal use by Systems Manager. The maximum length for a parameter name
        /// that you create is 1011 characters. This includes the characters in the ARN that precede
        /// the name you specify, such as <code>arn:aws:ssm:us-east-2:111122223333:parameter/</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property Overwrite. 
        /// <para>
        /// Overwrite an existing parameter. The default value is <code>false</code>.
        /// </para>
        /// </summary>
        public bool Overwrite
        {
            get { return this._overwrite.GetValueOrDefault(); }
            set { this._overwrite = value; }
        }

        // Check to see if Overwrite property is set
        internal bool IsSetOverwrite()
        {
            return this._overwrite.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// One or more policies to apply to a parameter. This operation takes a JSON array. Parameter
        /// Store, a capability of Amazon Web Services Systems Manager supports the following
        /// policy types:
        /// </para>
        ///  
        /// <para>
        /// Expiration: This policy deletes the parameter after it expires. When you create the
        /// policy, you specify the expiration date. You can update the expiration date and time
        /// by updating the policy. Updating the <i>parameter</i> doesn't affect the expiration
        /// date and time. When the expiration time is reached, Parameter Store deletes the parameter.
        /// </para>
        ///  
        /// <para>
        /// ExpirationNotification: This policy initiates an event in Amazon CloudWatch Events
        /// that notifies you about the expiration. By using this policy, you can receive notification
        /// before or after the expiration time is reached, in units of days or hours.
        /// </para>
        ///  
        /// <para>
        /// NoChangeNotification: This policy initiates a CloudWatch Events event if a parameter
        /// hasn't been modified for a specified period of time. This policy type is useful when,
        /// for example, a secret needs to be changed within a period of time, but it hasn't been
        /// changed.
        /// </para>
        ///  
        /// <para>
        /// All existing policies are preserved until you send new policies or an empty policy.
        /// For more information about parameter policies, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-policies.html">Assigning
        /// parameter policies</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. Tags enable you to categorize a resource
        /// in different ways, such as by purpose, owner, or environment. For example, you might
        /// want to tag a Systems Manager parameter to identify the type of resource to which
        /// it applies, the environment, or the type of configuration data referenced by the parameter.
        /// In this case, you could specify the following key-value pairs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Key=Resource,Value=S3bucket</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=OS,Value=Windows</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=ParameterType,Value=LicenseKey</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// To add tags to an existing Systems Manager parameter, use the <a>AddTagsToResource</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=1000)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The parameter tier to assign to a parameter.
        /// </para>
        ///  
        /// <para>
        /// Parameter Store offers a standard tier and an advanced tier for parameters. Standard
        /// parameters have a content size limit of 4 KB and can't be configured to use parameter
        /// policies. You can create a maximum of 10,000 standard parameters for each Region in
        /// an Amazon Web Services account. Standard parameters are offered at no additional cost.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Advanced parameters have a content size limit of 8 KB and can be configured to use
        /// parameter policies. You can create a maximum of 100,000 advanced parameters for each
        /// Region in an Amazon Web Services account. Advanced parameters incur a charge. For
        /// more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-advanced-parameters.html">Standard
        /// and advanced parameter tiers</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can change a standard parameter to an advanced parameter any time. But you can't
        /// revert an advanced parameter to a standard parameter. Reverting an advanced parameter
        /// to a standard parameter would result in data loss because the system would truncate
        /// the size of the parameter from 8 KB to 4 KB. Reverting would also remove any policies
        /// attached to the parameter. Lastly, advanced parameters use a different form of encryption
        /// than standard parameters. 
        /// </para>
        ///  
        /// <para>
        /// If you no longer need an advanced parameter, or if you no longer want to incur charges
        /// for an advanced parameter, you must delete it and recreate it as a new standard parameter.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Using the Default Tier Configuration</b> 
        /// </para>
        ///  
        /// <para>
        /// In <code>PutParameter</code> requests, you can specify the tier to create the parameter
        /// in. Whenever you specify a tier in the request, Parameter Store creates or updates
        /// the parameter according to that request. However, if you don't specify a tier in a
        /// request, Parameter Store assigns the tier based on the current Parameter Store default
        /// tier configuration.
        /// </para>
        ///  
        /// <para>
        /// The default tier when you begin using Parameter Store is the standard-parameter tier.
        /// If you use the advanced-parameter tier, you can specify one of the following as the
        /// default:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Advanced</b>: With this option, Parameter Store evaluates all requests as advanced
        /// parameters. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Intelligent-Tiering</b>: With this option, Parameter Store evaluates each request
        /// to determine if the parameter is standard or advanced. 
        /// </para>
        ///  
        /// <para>
        /// If the request doesn't include any options that require an advanced parameter, the
        /// parameter is created in the standard-parameter tier. If one or more options requiring
        /// an advanced parameter are included in the request, Parameter Store create a parameter
        /// in the advanced-parameter tier.
        /// </para>
        ///  
        /// <para>
        /// This approach helps control your parameter-related costs by always creating standard
        /// parameters unless an advanced parameter is necessary. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Options that require an advanced parameter include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The content size of the parameter is more than 4 KB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The parameter uses a parameter policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// More than 10,000 parameters already exist in your Amazon Web Services account in the
        /// current Amazon Web Services Region.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about configuring the default tier option, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/ps-default-tier.html">Specifying
        /// a default parameter tier</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public ParameterTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of parameter that you want to add to the system.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>SecureString</code> isn't currently supported for CloudFormation templates.
        /// </para>
        ///  </note> 
        /// <para>
        /// Items in a <code>StringList</code> must be separated by a comma (,). You can't use
        /// other punctuation or special character to escape items in the list. If you have a
        /// parameter value that requires a comma, then use the <code>String</code> data type.
        /// </para>
        ///  <important> 
        /// <para>
        /// Specifying a parameter type isn't required when updating a parameter. You must specify
        /// a parameter type when creating a parameter.
        /// </para>
        ///  </important>
        /// </summary>
        public ParameterType Type
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The parameter value that you want to add to the system. Standard parameters have a
        /// value limit of 4 KB. Advanced parameters have a value limit of 8 KB.
        /// </para>
        ///  <note> 
        /// <para>
        /// Parameters can't be referenced or nested in the values of other parameters. You can't
        /// include <code>{{}}</code> or <code>{{ssm:<i>parameter-name</i>}}</code> in a parameter
        /// value.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}