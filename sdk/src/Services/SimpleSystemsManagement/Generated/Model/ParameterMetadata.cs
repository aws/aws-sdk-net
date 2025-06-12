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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Metadata includes information like the Amazon Resource Name (ARN) of the last user
    /// to update the parameter and the date and time the parameter was last used.
    /// </summary>
    public partial class ParameterMetadata
    {
        private string _allowedPattern;
        private string _arn;
        private string _dataType;
        private string _description;
        private string _keyId;
        private DateTime? _lastModifiedDate;
        private string _lastModifiedUser;
        private string _name;
        private List<ParameterInlinePolicy> _policies = AWSConfigs.InitializeCollections ? new List<ParameterInlinePolicy>() : null;
        private ParameterTier _tier;
        private ParameterType _type;
        private long? _version;

        /// <summary>
        /// Gets and sets the property AllowedPattern. 
        /// <para>
        /// A parameter name can include only the following letters and symbols.
        /// </para>
        ///  
        /// <para>
        /// a-zA-Z0-9_.-
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
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the parameter.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the parameter, such as <c>text</c> or <c>aws:ec2:image</c>. The default
        /// is <c>text</c>.
        /// </para>
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
        /// Description of the parameter actions.
        /// </para>
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
        /// The alias of the Key Management Service (KMS) key used to encrypt the parameter. Applies
        /// to <c>SecureString</c> parameters only.
        /// </para>
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
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Date the parameter was last changed or updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedUser. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Amazon Web Services user who last changed the parameter.
        /// </para>
        /// </summary>
        public string LastModifiedUser
        {
            get { return this._lastModifiedUser; }
            set { this._lastModifiedUser = value; }
        }

        // Check to see if LastModifiedUser property is set
        internal bool IsSetLastModifiedUser()
        {
            return this._lastModifiedUser != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The parameter name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Policies. 
        /// <para>
        /// A list of policies associated with a parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterInlinePolicy> Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null && (this._policies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The parameter tier.
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
        /// The type of parameter. Valid parameter types include the following: <c>String</c>,
        /// <c>StringList</c>, and <c>SecureString</c>.
        /// </para>
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The parameter version.
        /// </para>
        /// </summary>
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}