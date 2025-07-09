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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// Defines the schema structure for an Iceberg table, including field definitions, data
    /// types, and schema metadata.
    /// </summary>
    public partial class IcebergSchema
    {
        private List<IcebergStructField> _fields = AWSConfigs.InitializeCollections ? new List<IcebergStructField>() : null;
        private List<int> _identifierFieldIds = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private int? _schemaId;
        private IcebergStructTypeEnum _type;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The list of field definitions that make up the table schema, including field names,
        /// types, and metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<IcebergStructField> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdentifierFieldIds. 
        /// <para>
        /// The list of field identifiers that uniquely identify records in the table, used for
        /// row-level operations and deduplication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IdentifierFieldIds
        {
            get { return this._identifierFieldIds; }
            set { this._identifierFieldIds = value; }
        }

        // Check to see if IdentifierFieldIds property is set
        internal bool IsSetIdentifierFieldIds()
        {
            return this._identifierFieldIds != null && (this._identifierFieldIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// The unique identifier for this schema version within the Iceberg table's schema evolution
        /// history.
        /// </para>
        /// </summary>
        public int? SchemaId
        {
            get { return this._schemaId; }
            set { this._schemaId = value; }
        }

        // Check to see if SchemaId property is set
        internal bool IsSetSchemaId()
        {
            return this._schemaId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The root type of the schema structure, typically "struct" for Iceberg table schemas.
        /// </para>
        /// </summary>
        public IcebergStructTypeEnum Type
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