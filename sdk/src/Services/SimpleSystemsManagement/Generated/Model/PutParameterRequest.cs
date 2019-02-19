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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

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
        private string _description;
        private string _keyId;
        private string _name;
        private bool? _overwrite;
        private List<Tag> _tags = new List<Tag>();
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Information about the parameter that you want to add to the system. Optional but recommended.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not enter personally identifiable information in this field.
        /// </para>
        ///  </important>
        /// </summary>
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
        /// The KMS Key ID that you want to use to encrypt a parameter. Either the default AWS
        /// Key Management Service (AWS KMS) key automatically assigned to your AWS account or
        /// a custom key. Required for parameters that use the <code>SecureString</code> data
        /// type.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a key ID, the system uses the default key associated with your
        /// AWS account.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To use your default AWS KMS key, choose the <code>SecureString</code> data type, and
        /// do <i>not</i> specify the <code>Key ID</code> when you create the parameter. The system
        /// automatically populates <code>Key ID</code> with your default KMS key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To use a custom KMS key, choose the <code>SecureString</code> data type with the <code>Key
        /// ID</code> parameter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// For example: <code>/Dev/DBServer/MySQL/db-string13</code> 
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
        /// A parameter name must be unique within an AWS Region
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A parameter name can't be prefixed with "aws" or "ssm" (case-insensitive).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Parameter names can include only the following symbols and letters: <code>a-zA-Z0-9_.-/</code>
        /// 
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
        /// For additional information about valid values for parameter names, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-parameter-name-constraints.html">Requirements
        /// and Constraints for Parameter Names</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum length constraint listed below includes capacity for additional system
        /// attributes that are not part of the name. The maximum length for the fully qualified
        /// parameter name is 1011 characters. 
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Overwrite. 
        /// <para>
        /// Overwrite an existing parameter. If not specified, will default to "false".
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. Tags enable you to categorize a resource
        /// in different ways, such as by purpose, owner, or environment. For example, you might
        /// want to tag a Systems Manager parameter to identify the type of resource to which
        /// it applies, the environment, or the type of configuration data referenced by the parameter.
        /// In this case, you could specify the following key name/value pairs:
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
        /// action.
        /// </para>
        ///  </note>
        /// </summary>
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of parameter that you want to add to the system.
        /// </para>
        ///  
        /// <para>
        /// Items in a <code>StringList</code> must be separated by a comma (,). You can't use
        /// other punctuation or special character to escape items in the list. If you have a
        /// parameter value that requires a comma, then use the <code>String</code> data type.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>SecureString</code> is not currently supported for AWS CloudFormation templates
        /// or in the China Regions.
        /// </para>
        ///  </note>
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
        /// The parameter value that you want to add to the system.
        /// </para>
        /// </summary>
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