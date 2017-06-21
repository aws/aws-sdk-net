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
    /// Metada includes information like the ARN of the last user and the date/time the parameter
    /// was last used.
    /// </summary>
    public partial class ParameterMetadata
    {
        private string _allowedPattern;
        private string _description;
        private string _keyId;
        private DateTime? _lastModifiedDate;
        private string _lastModifiedUser;
        private string _name;
        private ParameterType _type;

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
        /// Description of the parameter actions.
        /// </para>
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
        /// The ID of the query key used for this parameter.
        /// </para>
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
        /// Amazon Resource Name (ARN) of the AWS user who last changed the parameter.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of parameter. Valid parameter types include the following: String, String
        /// list, Secure string.
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

    }
}