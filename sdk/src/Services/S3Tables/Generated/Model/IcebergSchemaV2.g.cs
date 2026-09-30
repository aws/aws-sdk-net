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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Contains details about the schema for an Iceberg table using the V2 format. This schema
    /// format supports nested and complex data types such as <c>struct</c>, <c>list</c>,
    /// and <c>map</c>, in addition to primitive types.
    /// </summary>
    public partial class IcebergSchemaV2
    {
        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The schema fields for the table. Each field defines a column in the table, including
        /// its name, type, and whether it is required.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<SchemaV2Field> Fields { get; set; } = AWSConfigs.InitializeCollections ? new List<SchemaV2Field>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IdentifierFieldIds. 
        /// <para>
        /// A list of field IDs that are used as the identifier fields for the table. Identifier
        /// fields uniquely identify a row in the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IdentifierFieldIds { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the IdentifierFieldIds property is set.
        /// </summary>
        internal bool IsSetIdentifierFieldIds() => this.IdentifierFieldIds != null && (this.IdentifierFieldIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// An optional unique identifier for the schema. Schema IDs are used by Apache Iceberg
        /// to track schema evolution.
        /// </para>
        /// </summary>
        public int? SchemaId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaId property is set.
        /// </summary>
        internal bool IsSetSchemaId() => this.SchemaId.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the top-level schema, which is always a <c>struct</c> type as defined
        /// in the <a href="https://iceberg.apache.org/spec/#schemas-and-data-types">Apache Iceberg
        /// specification</a>. This value must be <c>struct</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaV2FieldType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
