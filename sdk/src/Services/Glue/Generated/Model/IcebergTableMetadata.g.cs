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
    /// The Apache Iceberg table metadata, including format version, table identifier, schemas,
    /// partition specifications, sort orders, and table properties. This structure captures
    /// the current state of an Iceberg table's metadata as managed by the Glue Data Catalog.
    /// </summary>
    public partial class IcebergTableMetadata
    {
        /// <summary>
        /// Gets and sets the property CurrentSchemaId. 
        /// <para>
        /// The identifier of the schema that is currently active for the Iceberg table. Matches
        /// an entry in <c>Schemas</c>.
        /// </para>
        /// </summary>
        public int? CurrentSchemaId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentSchemaId property is set.
        /// </summary>
        internal bool IsSetCurrentSchemaId() => this.CurrentSchemaId.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultSortOrderId. 
        /// <para>
        /// The identifier of the sort order that is currently used by default when writing new
        /// data to the Iceberg table.
        /// </para>
        /// </summary>
        public int? DefaultSortOrderId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSortOrderId property is set.
        /// </summary>
        internal bool IsSetDefaultSortOrderId() => this.DefaultSortOrderId.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultSpecId. 
        /// <para>
        /// The identifier of the partition specification that is currently used by default when
        /// writing new data to the Iceberg table.
        /// </para>
        /// </summary>
        public int? DefaultSpecId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSpecId property is set.
        /// </summary>
        internal bool IsSetDefaultSpecId() => this.DefaultSpecId.HasValue;

        /// <summary>
        /// Gets and sets the property FormatVersion. 
        /// <para>
        /// The Apache Iceberg table format version, such as <c>1</c> or <c>2</c>. Determines
        /// the set of features and on-disk layout supported by the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string FormatVersion { get; set; }

        /// <summary>
        /// Checks to see if the FormatVersion property is set.
        /// </summary>
        internal bool IsSetFormatVersion() => this.FormatVersion != null;

        /// <summary>
        /// Gets and sets the property LastColumnId. 
        /// <para>
        /// The highest column identifier that has been assigned in the Iceberg table's schema,
        /// used to ensure unique IDs as new columns are added.
        /// </para>
        /// </summary>
        public int? LastColumnId { get; set; }

        /// <summary>
        /// Checks to see if the LastColumnId property is set.
        /// </summary>
        internal bool IsSetLastColumnId() => this.LastColumnId.HasValue;

        /// <summary>
        /// Gets and sets the property LastPartitionId. 
        /// <para>
        /// The highest partition field identifier that has been assigned across the table's partition
        /// specifications.
        /// </para>
        /// </summary>
        public int? LastPartitionId { get; set; }

        /// <summary>
        /// Checks to see if the LastPartitionId property is set.
        /// </summary>
        internal bool IsSetLastPartitionId() => this.LastPartitionId.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The base S3 location where the Iceberg table's data and metadata files are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2056)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property PartitionSpecs. 
        /// <para>
        /// The list of partition specifications that have been associated with the Iceberg table
        /// over its history, supporting partition evolution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IcebergPartitionSpec> PartitionSpecs { get; set; } = AWSConfigs.InitializeCollections ? new List<IcebergPartitionSpec>() : null;

        /// <summary>
        /// Checks to see if the PartitionSpecs property is set.
        /// </summary>
        internal bool IsSetPartitionSpecs() => this.PartitionSpecs != null && (this.PartitionSpecs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A map of key-value pairs that define table-level properties and configuration settings
        /// for the Iceberg table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Properties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null && (this.Properties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Schemas. 
        /// <para>
        /// The list of schemas that have been associated with the Iceberg table over its history,
        /// supporting schema evolution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IcebergSchema> Schemas { get; set; } = AWSConfigs.InitializeCollections ? new List<IcebergSchema>() : null;

        /// <summary>
        /// Checks to see if the Schemas property is set.
        /// </summary>
        internal bool IsSetSchemas() => this.Schemas != null && (this.Schemas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SortOrders. 
        /// <para>
        /// The list of sort order specifications that have been associated with the Iceberg table
        /// over its history.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IcebergSortOrder> SortOrders { get; set; } = AWSConfigs.InitializeCollections ? new List<IcebergSortOrder>() : null;

        /// <summary>
        /// Checks to see if the SortOrders property is set.
        /// </summary>
        internal bool IsSetSortOrders() => this.SortOrders != null && (this.SortOrders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TableUuid. 
        /// <para>
        /// The unique identifier (UUID) for the Iceberg table, assigned when the table is created
        /// and used to track the table across metadata updates.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string TableUuid { get; set; }

        /// <summary>
        /// Checks to see if the TableUuid property is set.
        /// </summary>
        internal bool IsSetTableUuid() => this.TableUuid != null;
    }
}
