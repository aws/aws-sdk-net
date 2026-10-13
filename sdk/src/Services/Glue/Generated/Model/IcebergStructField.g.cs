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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a single field within an Iceberg table schema, including its identifier, name,
    /// data type, nullability, and documentation.
    /// </summary>
    public partial class IcebergStructField
    {
        /// <summary>
        /// Gets and sets the property Doc. 
        /// <para>
        /// Optional documentation or description text that provides additional context about
        /// the purpose and usage of this field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Doc { get; set; }

        /// <summary>
        /// Checks to see if the Doc property is set.
        /// </summary>
        internal bool IsSetDoc() => this.Doc != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier assigned to this field within the Iceberg table schema, used
        /// for schema evolution and field tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id.HasValue;

        /// <summary>
        /// Gets and sets the property InitialDefault. 
        /// <para>
        /// Default value used to populate the field's value for all records that were written
        /// before the field was added to the schema. This enables backward compatibility when
        /// adding new fields to existing Iceberg tables.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document InitialDefault { get; set; }

        /// <summary>
        /// Checks to see if the InitialDefault property is set.
        /// </summary>
        internal bool IsSetInitialDefault() => !this.InitialDefault.IsNull();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the field as it appears in the table schema and query operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Indicates whether this field is required (non-nullable) or optional (nullable) in
        /// the table schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type definition for this field, specifying the structure and format of the
        /// data it contains.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amazon.Runtime.Documents.Document Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => !this.Type.IsNull();

        /// <summary>
        /// Gets and sets the property WriteDefault. 
        /// <para>
        /// Default value used to populate the field's value for any records written after the
        /// field was added to the schema, if the writer does not supply the field's value. This
        /// can be changed through schema evolution.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document WriteDefault { get; set; }

        /// <summary>
        /// Checks to see if the WriteDefault property is set.
        /// </summary>
        internal bool IsSetWriteDefault() => !this.WriteDefault.IsNull();
    }
}
