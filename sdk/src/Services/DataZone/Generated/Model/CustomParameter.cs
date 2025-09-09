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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of user parameters of an environment blueprint.
    /// </summary>
    public partial class CustomParameter
    {
        private string _defaultValue;
        private string _description;
        private string _fieldType;
        private bool? _isEditable;
        private bool? _isOptional;
        private bool? _isUpdateSupported;
        private string _keyName;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the parameter.
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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
        /// Gets and sets the property FieldType. 
        /// <para>
        /// The filed type of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FieldType
        {
            get { return this._fieldType; }
            set { this._fieldType = value; }
        }

        // Check to see if FieldType property is set
        internal bool IsSetFieldType()
        {
            return this._fieldType != null;
        }

        /// <summary>
        /// Gets and sets the property IsEditable. 
        /// <para>
        /// Specifies whether the parameter is editable.
        /// </para>
        /// </summary>
        public bool? IsEditable
        {
            get { return this._isEditable; }
            set { this._isEditable = value; }
        }

        // Check to see if IsEditable property is set
        internal bool IsSetIsEditable()
        {
            return this._isEditable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsOptional. 
        /// <para>
        /// Specifies whether the custom parameter is optional.
        /// </para>
        /// </summary>
        public bool? IsOptional
        {
            get { return this._isOptional; }
            set { this._isOptional = value; }
        }

        // Check to see if IsOptional property is set
        internal bool IsSetIsOptional()
        {
            return this._isOptional.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsUpdateSupported. 
        /// <para>
        /// Specifies whether a parameter value can be updated after creation. 
        /// </para>
        /// </summary>
        public bool? IsUpdateSupported
        {
            get { return this._isUpdateSupported; }
            set { this._isUpdateSupported = value; }
        }

        // Check to see if IsUpdateSupported property is set
        internal bool IsSetIsUpdateSupported()
        {
            return this._isUpdateSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The key name of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

    }
}