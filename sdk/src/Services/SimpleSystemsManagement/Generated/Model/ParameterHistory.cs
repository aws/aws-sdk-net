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
    /// Information about parameter usage.
    /// </summary>
    public partial class ParameterHistory
    {
        private string _allowedPattern;
        private string _dataType;
        private string _description;
        private string _keyId;
        private List<string> _labels = new List<string>();
        private DateTime? _lastModifiedDate;
        private string _lastModifiedUser;
        private string _name;
        private List<ParameterInlinePolicy> _policies = new List<ParameterInlinePolicy>();
        private ParameterTier _tier;
        private ParameterType _type;
        private string _value;
        private long? _version;

        /// <summary>
        /// Gets and sets the property AllowedPattern. 
        /// <para>
        /// Parameter names can include the following letters and symbols.
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
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the parameter, such as <code>text</code> or <code>aws:ec2:image</code>.
        /// The default is <code>text</code>.
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
        /// Information about the parameter.
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
        /// The ID of the query key used for this parameter.
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
        /// Gets and sets the property Labels. 
        /// <para>
        /// Labels assigned to the parameter version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && this._labels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Date the parameter was last changed or updated.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
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
        /// The name of the parameter.
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
        /// Information about the policies assigned to a parameter.
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-policies.html">Assigning
        /// parameter policies</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public List<ParameterInlinePolicy> Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null && this._policies.Count > 0; 
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
        /// The type of parameter used.
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The parameter value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The parameter version.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}