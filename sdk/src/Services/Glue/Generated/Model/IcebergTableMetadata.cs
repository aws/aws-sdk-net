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
    /// The Apache Iceberg table metadata, including format version, table identifier, schemas,
    /// partition specifications, sort orders, and table properties. This structure captures
    /// the current state of an Iceberg table's metadata as managed by the Glue Data Catalog.
    /// </summary>
    public partial class IcebergTableMetadata
    {
        private int? _currentSchemaId;
        private int? _defaultSortOrderId;
        private int? _defaultSpecId;
        private string _formatVersion;
        private int? _lastColumnId;
        private int? _lastPartitionId;
        private string _location;
        private List<IcebergPartitionSpec> _partitionSpecs = AWSConfigs.InitializeCollections ? new List<IcebergPartitionSpec>() : null;
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<IcebergSchema> _schemas = AWSConfigs.InitializeCollections ? new List<IcebergSchema>() : null;
        private List<IcebergSortOrder> _sortOrders = AWSConfigs.InitializeCollections ? new List<IcebergSortOrder>() : null;
        private string _tableUuid;

        /// <summary>
        /// Gets and sets the property CurrentSchemaId. 
        /// <para>
        /// The identifier of the schema that is currently active for the Iceberg table. Matches
        /// an entry in <c>Schemas</c>.
        /// </para>
        /// </summary>
        public int? CurrentSchemaId
        {
            get { return this._currentSchemaId; }
            set { this._currentSchemaId = value; }
        }

        // Check to see if CurrentSchemaId property is set
        internal bool IsSetCurrentSchemaId()
        {
            return this._currentSchemaId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultSortOrderId. 
        /// <para>
        /// The identifier of the sort order that is currently used by default when writing new
        /// data to the Iceberg table.
        /// </para>
        /// </summary>
        public int? DefaultSortOrderId
        {
            get { return this._defaultSortOrderId; }
            set { this._defaultSortOrderId = value; }
        }

        // Check to see if DefaultSortOrderId property is set
        internal bool IsSetDefaultSortOrderId()
        {
            return this._defaultSortOrderId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultSpecId. 
        /// <para>
        /// The identifier of the partition specification that is currently used by default when
        /// writing new data to the Iceberg table.
        /// </para>
        /// </summary>
        public int? DefaultSpecId
        {
            get { return this._defaultSpecId; }
            set { this._defaultSpecId = value; }
        }

        // Check to see if DefaultSpecId property is set
        internal bool IsSetDefaultSpecId()
        {
            return this._defaultSpecId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FormatVersion. 
        /// <para>
        /// The Apache Iceberg table format version, such as <c>1</c> or <c>2</c>. Determines
        /// the set of features and on-disk layout supported by the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FormatVersion
        {
            get { return this._formatVersion; }
            set { this._formatVersion = value; }
        }

        // Check to see if FormatVersion property is set
        internal bool IsSetFormatVersion()
        {
            return this._formatVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LastColumnId. 
        /// <para>
        /// The highest column identifier that has been assigned in the Iceberg table's schema,
        /// used to ensure unique IDs as new columns are added.
        /// </para>
        /// </summary>
        public int? LastColumnId
        {
            get { return this._lastColumnId; }
            set { this._lastColumnId = value; }
        }

        // Check to see if LastColumnId property is set
        internal bool IsSetLastColumnId()
        {
            return this._lastColumnId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastPartitionId. 
        /// <para>
        /// The highest partition field identifier that has been assigned across the table's partition
        /// specifications.
        /// </para>
        /// </summary>
        public int? LastPartitionId
        {
            get { return this._lastPartitionId; }
            set { this._lastPartitionId = value; }
        }

        // Check to see if LastPartitionId property is set
        internal bool IsSetLastPartitionId()
        {
            return this._lastPartitionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The base S3 location where the Iceberg table's data and metadata files are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2056)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionSpecs. 
        /// <para>
        /// The list of partition specifications that have been associated with the Iceberg table
        /// over its history, supporting partition evolution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IcebergPartitionSpec> PartitionSpecs
        {
            get { return this._partitionSpecs; }
            set { this._partitionSpecs = value; }
        }

        // Check to see if PartitionSpecs property is set
        internal bool IsSetPartitionSpecs()
        {
            return this._partitionSpecs != null && (this._partitionSpecs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A map of key-value pairs that define table-level properties and configuration settings
        /// for the Iceberg table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Schemas. 
        /// <para>
        /// The list of schemas that have been associated with the Iceberg table over its history,
        /// supporting schema evolution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IcebergSchema> Schemas
        {
            get { return this._schemas; }
            set { this._schemas = value; }
        }

        // Check to see if Schemas property is set
        internal bool IsSetSchemas()
        {
            return this._schemas != null && (this._schemas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SortOrders. 
        /// <para>
        /// The list of sort order specifications that have been associated with the Iceberg table
        /// over its history.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IcebergSortOrder> SortOrders
        {
            get { return this._sortOrders; }
            set { this._sortOrders = value; }
        }

        // Check to see if SortOrders property is set
        internal bool IsSetSortOrders()
        {
            return this._sortOrders != null && (this._sortOrders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableUuid. 
        /// <para>
        /// The unique identifier (UUID) for the Iceberg table, assigned when the table is created
        /// and used to track the table across metadata updates.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string TableUuid
        {
            get { return this._tableUuid; }
            set { this._tableUuid = value; }
        }

        // Check to see if TableUuid property is set
        internal bool IsSetTableUuid()
        {
            return this._tableUuid != null;
        }

    }
}