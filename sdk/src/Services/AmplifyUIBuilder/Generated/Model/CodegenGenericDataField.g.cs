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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type for the generic data field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CodegenGenericDataFieldDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property DataTypeValue. 
        /// <para>
        /// The value of the data type for the generic data field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataTypeValue { get; set; }

        /// <summary>
        /// Checks to see if the DataTypeValue property is set.
        /// </summary>
        internal bool IsSetDataTypeValue() => this.DataTypeValue != null;

        /// <summary>
        /// Gets and sets the property IsArray. 
        /// <para>
        /// Specifies whether the generic data field is an array.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsArray { get; set; }

        /// <summary>
        /// Checks to see if the IsArray property is set.
        /// </summary>
        internal bool IsSetIsArray() => this.IsArray.HasValue;

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// Specifies whether the generic data field is read-only.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Checks to see if the ReadOnly property is set.
        /// </summary>
        internal bool IsSetReadOnly() => this.ReadOnly.HasValue;

        /// <summary>
        /// Gets and sets the property Relationship. 
        /// <para>
        /// The relationship of the generic data schema.
        /// </para>
        /// </summary>
        public CodegenGenericDataRelationshipType Relationship { get; set; }

        /// <summary>
        /// Checks to see if the Relationship property is set.
        /// </summary>
        internal bool IsSetRelationship() => this.Relationship != null;

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Specifies whether the generic data field is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;
    }
}
