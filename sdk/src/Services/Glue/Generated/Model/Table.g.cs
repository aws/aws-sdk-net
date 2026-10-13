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
    /// Represents a collection of related data organized in columns and rows.
    /// </summary>
    public partial class Table
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which the table resides.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time when the table definition was created in the Data Catalog.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The person or entity who created the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database where the table metadata resides. For Hive compatibility,
        /// this must be all lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FederatedTable. 
        /// <para>
        /// A <c>FederatedTable</c> structure that references an entity outside the Glue Data
        /// Catalog.
        /// </para>
        /// </summary>
        public FederatedTable FederatedTable { get; set; }

        /// <summary>
        /// Checks to see if the FederatedTable property is set.
        /// </summary>
        internal bool IsSetFederatedTable() => this.FederatedTable != null;

        /// <summary>
        /// Gets and sets the property IcebergTableMetadata. 
        /// <para>
        /// The latest Apache Iceberg table metadata for the table, including format version,
        /// schemas, partition specifications, and sort orders. This field is populated for Iceberg
        /// tables and reflects the current state of the table's Iceberg metadata.
        /// </para>
        /// </summary>
        public IcebergTableMetadata IcebergTableMetadata { get; set; }

        /// <summary>
        /// Checks to see if the IcebergTableMetadata property is set.
        /// </summary>
        internal bool IsSetIcebergTableMetadata() => this.IcebergTableMetadata != null;

        /// <summary>
        /// Gets and sets the property IsMaterializedView. 
        /// <para>
        /// Indicates a table is a <c>MaterializedView</c>.
        /// </para>
        /// </summary>
        public bool? IsMaterializedView { get; set; }

        /// <summary>
        /// Checks to see if the IsMaterializedView property is set.
        /// </summary>
        internal bool IsSetIsMaterializedView() => this.IsMaterializedView.HasValue;

        /// <summary>
        /// Gets and sets the property IsMultiDialectView. 
        /// <para>
        /// Specifies whether the view supports the SQL dialects of one or more different query
        /// engines and can therefore be read by those engines.
        /// </para>
        /// </summary>
        public bool? IsMultiDialectView { get; set; }

        /// <summary>
        /// Checks to see if the IsMultiDialectView property is set.
        /// </summary>
        internal bool IsSetIsMultiDialectView() => this.IsMultiDialectView.HasValue;

        /// <summary>
        /// Gets and sets the property IsRegisteredWithLakeFormation. 
        /// <para>
        /// Indicates whether the table has been registered with Lake Formation.
        /// </para>
        /// </summary>
        public bool? IsRegisteredWithLakeFormation { get; set; }

        /// <summary>
        /// Checks to see if the IsRegisteredWithLakeFormation property is set.
        /// </summary>
        internal bool IsSetIsRegisteredWithLakeFormation() => this.IsRegisteredWithLakeFormation.HasValue;

        /// <summary>
        /// Gets and sets the property LastAccessTime. 
        /// <para>
        /// The last time that the table was accessed. This is usually taken from HDFS, and might
        /// not be reliable.
        /// </para>
        /// </summary>
        public DateTime? LastAccessTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAccessTime property is set.
        /// </summary>
        internal bool IsSetLastAccessTime() => this.LastAccessTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastAnalyzedTime. 
        /// <para>
        /// The last time that column statistics were computed for this table.
        /// </para>
        /// </summary>
        public DateTime? LastAnalyzedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAnalyzedTime property is set.
        /// </summary>
        internal bool IsSetLastAnalyzedTime() => this.LastAnalyzedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The table name. For Hive compatibility, this must be entirely lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// These key-value pairs define properties associated with the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// A list of columns by which the table is partitioned. Only primitive types are supported
        /// as partition keys.
        /// </para>
        ///  
        /// <para>
        /// When you create a table used by Amazon Athena, and you do not specify any <c>partitionKeys</c>,
        /// you must at least set the value of <c>partitionKeys</c> to an empty list. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"PartitionKeys": []</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Column> PartitionKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<Column>() : null;

        /// <summary>
        /// Checks to see if the PartitionKeys property is set.
        /// </summary>
        internal bool IsSetPartitionKeys() => this.PartitionKeys != null && (this.PartitionKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RLSProperties. 
        /// <para>
        /// A <c>RLSProperties</c> structure that describes the default row-level security policy
        /// of the table.
        /// </para>
        /// </summary>
        public RLSProperties RLSProperties { get; set; }

        /// <summary>
        /// Checks to see if the RLSProperties property is set.
        /// </summary>
        internal bool IsSetRLSProperties() => this.RLSProperties != null;

        /// <summary>
        /// Gets and sets the property Retention. 
        /// <para>
        /// The retention time for this table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Retention { get; set; }

        /// <summary>
        /// Checks to see if the Retention property is set.
        /// </summary>
        internal bool IsSetRetention() => this.Retention.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the the state of an asynchronous change to a table.
        /// </para>
        /// </summary>
        public TableStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageDescriptor. 
        /// <para>
        /// A storage descriptor containing information about the physical storage of this table.
        /// </para>
        /// </summary>
        public StorageDescriptor StorageDescriptor { get; set; }

        /// <summary>
        /// Checks to see if the StorageDescriptor property is set.
        /// </summary>
        internal bool IsSetStorageDescriptor() => this.StorageDescriptor != null;

        /// <summary>
        /// Gets and sets the property TableType. 
        /// <para>
        /// The type of this table. Glue will create tables with the <c>EXTERNAL_TABLE</c> type.
        /// Other services, such as Athena, may create tables with additional table types. 
        /// </para>
        ///  
        /// <para>
        /// Glue related table types:
        /// </para>
        ///  <dl> <dt>EXTERNAL_TABLE</dt> <dd> 
        /// <para>
        /// Hive compatible attribute - indicates a non-Hive managed table.
        /// </para>
        ///  </dd> <dt>GOVERNED</dt> <dd> 
        /// <para>
        /// Used by Lake Formation. The Glue Data Catalog understands <c>GOVERNED</c>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string TableType { get; set; }

        /// <summary>
        /// Checks to see if the TableType property is set.
        /// </summary>
        internal bool IsSetTableType() => this.TableType != null;

        /// <summary>
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// A <c>TableIdentifier</c> structure that describes a target table for resource linking.
        /// </para>
        /// </summary>
        public TableIdentifier TargetTable { get; set; }

        /// <summary>
        /// Checks to see if the TargetTable property is set.
        /// </summary>
        internal bool IsSetTargetTable() => this.TargetTable != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The last time that the table was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of the table version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;

        /// <summary>
        /// Gets and sets the property ViewDefinition. 
        /// <para>
        /// A structure that contains all the information that defines the view, including the
        /// dialect or dialects for the view, and the query.
        /// </para>
        /// </summary>
        public ViewDefinition ViewDefinition { get; set; }

        /// <summary>
        /// Checks to see if the ViewDefinition property is set.
        /// </summary>
        internal bool IsSetViewDefinition() => this.ViewDefinition != null;

        /// <summary>
        /// Gets and sets the property ViewExpandedText. 
        /// <para>
        /// Included for Apache Hive compatibility. Not used in the normal course of Glue operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 409600)]
        public string ViewExpandedText { get; set; }

        /// <summary>
        /// Checks to see if the ViewExpandedText property is set.
        /// </summary>
        internal bool IsSetViewExpandedText() => this.ViewExpandedText != null;

        /// <summary>
        /// Gets and sets the property ViewOriginalText. 
        /// <para>
        /// Included for Apache Hive compatibility. Not used in the normal course of Glue operations.
        /// If the table is a <c>VIRTUAL_VIEW</c>, certain Athena configuration encoded in base64.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 409600)]
        public string ViewOriginalText { get; set; }

        /// <summary>
        /// Checks to see if the ViewOriginalText property is set.
        /// </summary>
        internal bool IsSetViewOriginalText() => this.ViewOriginalText != null;
    }
}
