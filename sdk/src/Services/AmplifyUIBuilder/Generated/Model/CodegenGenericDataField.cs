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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes a field in a generic data schema.
    /// </summary>
    public partial class CodegenGenericDataField
    {
        private CodegenGenericDataFieldDataType _dataType;
        private string _dataTypeValue;
        private bool? _isArray;
        private bool? _readOnly;
        private CodegenGenericDataRelationshipType _relationship;
        private bool? _required;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type for the generic data field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CodegenGenericDataFieldDataType DataType
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
        /// Gets and sets the property DataTypeValue. 
        /// <para>
        /// The value of the data type for the generic data field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataTypeValue
        {
            get { return this._dataTypeValue; }
            set { this._dataTypeValue = value; }
        }

        // Check to see if DataTypeValue property is set
        internal bool IsSetDataTypeValue()
        {
            return this._dataTypeValue != null;
        }

        /// <summary>
        /// Gets and sets the property IsArray. 
        /// <para>
        /// Specifies whether the generic data field is an array.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsArray
        {
            get { return this._isArray; }
            set { this._isArray = value; }
        }

        // Check to see if IsArray property is set
        internal bool IsSetIsArray()
        {
            return this._isArray.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// Specifies whether the generic data field is read-only.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ReadOnly
        {
            get { return this._readOnly; }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Relationship. 
        /// <para>
        /// The relationship of the generic data schema.
        /// </para>
        /// </summary>
        public CodegenGenericDataRelationshipType Relationship
        {
            get { return this._relationship; }
            set { this._relationship = value; }
        }

        // Check to see if Relationship property is set
        internal bool IsSetRelationship()
        {
            return this._relationship != null;
        }

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Specifies whether the generic data field is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Required
        {
            get { return this._required; }
            set { this._required = value; }
        }

        // Check to see if Required property is set
        internal bool IsSetRequired()
        {
            return this._required.HasValue; 
        }

    }
}