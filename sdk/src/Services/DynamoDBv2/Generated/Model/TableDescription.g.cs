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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the properties of a table.
    /// </summary>
    public partial class TableDescription
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public TableDescription() { }

        /// <summary>
        /// Gets and sets the property ArchivalSummary. 
        /// <para>
        /// Contains information about the table archive.
        /// </para>
        /// </summary>
        public ArchivalSummary ArchivalSummary { get; set; }

        /// <summary>
        /// Checks to see if the ArchivalSummary property is set.
        /// </summary>
        internal bool IsSetArchivalSummary() => this.ArchivalSummary != null;

        /// <summary>
        /// Gets and sets the property AttributeDefinitions. 
        /// <para>
        /// An array of <c>AttributeDefinition</c> objects. Each of these objects describes one
        /// attribute in the table and index key schema.
        /// </para>
        ///  
        /// <para>
        /// Each <c>AttributeDefinition</c> object in this array is composed of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AttributeName</c> - The name of the attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AttributeType</c> - The data type for the attribute.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeDefinition> AttributeDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeDefinition>() : null;

        /// <summary>
        /// Checks to see if the AttributeDefinitions property is set.
        /// </summary>
        internal bool IsSetAttributeDefinitions() => this.AttributeDefinitions != null && (this.AttributeDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillingModeSummary. 
        /// <para>
        /// Contains the details for the read/write capacity mode.
        /// </para>
        /// </summary>
        public BillingModeSummary BillingModeSummary { get; set; }

        /// <summary>
        /// Checks to see if the BillingModeSummary property is set.
        /// </summary>
        internal bool IsSetBillingModeSummary() => this.BillingModeSummary != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time when the table was created, in <a href="http://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Indicates whether deletion protection is enabled (true) or disabled (false) on the
        /// table.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property DisassociationProtectionEnabled. 
        /// <para>
        /// Specifies whether disassociation protection is enabled (<c>true</c>) or disabled (<c>false</c>)
        /// for the local global table replica. Protection is enabled by default.
        /// </para>
        /// </summary>
        public bool? DisassociationProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DisassociationProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDisassociationProtectionEnabled() => this.DisassociationProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexes. 
        /// <para>
        /// The global secondary indexes, if any, on the table. Each index is scoped to a given
        /// partition key value. Each element is composed of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Backfilling</c> - If true, then the index is currently in the backfilling phase.
        /// Backfilling occurs only when a new global secondary index is added to the table. It
        /// is the process by which DynamoDB populates the new index with data from the table.
        /// (This attribute does not appear for indexes that were created during a <c>CreateTable</c>
        /// operation.) 
        /// </para>
        ///  
        /// <para>
        ///  You can delete an index that is being created during the <c>Backfilling</c> phase
        /// when <c>IndexStatus</c> is set to CREATING and <c>Backfilling</c> is true. You can't
        /// delete the index that is being created when <c>IndexStatus</c> is set to CREATING
        /// and <c>Backfilling</c> is false. (This attribute does not appear for indexes that
        /// were created during a <c>CreateTable</c> operation.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IndexName</c> - The name of the global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IndexSizeBytes</c> - The total size of the global secondary index, in bytes. DynamoDB
        /// updates this value approximately every six hours. Recent changes might not be reflected
        /// in this value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IndexStatus</c> - The current status of the global secondary index:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The index is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The index is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The index is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The index is ready for use.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ItemCount</c> - The number of items in the global secondary index. DynamoDB updates
        /// this value approximately every six hours. Recent changes might not be reflected in
        /// this value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeySchema</c> - Specifies the complete index key schema. The attribute names in
        /// the key schema must be between 1 and 255 characters (inclusive). The key schema must
        /// begin with the same partition key as the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Projection</c> - Specifies attributes that are copied (projected) from the table
        /// into the index. These are in addition to the primary key attributes and index key
        /// attributes, which are automatically projected. Each attribute specification is composed
        /// of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ProjectionType</c> - One of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> - Only the index and primary keys are projected into the index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCLUDE</c> - In addition to the attributes described in <c>KEYS_ONLY</c>, the
        /// secondary index will include other non-key attributes that you specify.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> - All of the table attributes are projected into the index.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NonKeyAttributes</c> - A list of one or more non-key attribute names that are
        /// projected into the secondary index. The total count of attributes provided in <c>NonKeyAttributes</c>,
        /// summed across all of the secondary indexes, must not exceed 100. If you project the
        /// same attribute into two different indexes, this counts as two distinct attributes
        /// when determining the total. This limit only applies when you specify the ProjectionType
        /// of <c>INCLUDE</c>. You still can specify the ProjectionType of <c>ALL</c> to project
        /// all attributes from the source table, even if the table has more than 100 attributes.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ProvisionedThroughput</c> - The provisioned throughput settings for the global
        /// secondary index, consisting of read and write capacity units, along with data about
        /// increases and decreases. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the table is in the <c>DELETING</c> state, no information about indexes will be
        /// returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalSecondaryIndexDescription> GlobalSecondaryIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalSecondaryIndexDescription>() : null;

        /// <summary>
        /// Checks to see if the GlobalSecondaryIndexes property is set.
        /// </summary>
        internal bool IsSetGlobalSecondaryIndexes() => this.GlobalSecondaryIndexes != null && (this.GlobalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlobalTableSettingsReplicationMode. 
        /// <para>
        /// Indicates one of the settings synchronization modes for the global table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c>: Indicates that the settings synchronization mode for the global table
        /// is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c>: Indicates that the settings synchronization mode for the global
        /// table is disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLED_WITH_OVERRIDES</c>: This mode is set by default for a same account global
        /// table. Indicates that certain global table settings can be overridden.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GlobalTableSettingsReplicationMode GlobalTableSettingsReplicationMode { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableSettingsReplicationMode property is set.
        /// </summary>
        internal bool IsSetGlobalTableSettingsReplicationMode() => this.GlobalTableSettingsReplicationMode != null;

        /// <summary>
        /// Gets and sets the property GlobalTableVersion. 
        /// <para>
        /// Represents the version of <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">global
        /// tables</a> in use, if the table is replicated across Amazon Web Services Regions.
        /// </para>
        /// </summary>
        public string GlobalTableVersion { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableVersion property is set.
        /// </summary>
        internal bool IsSetGlobalTableVersion() => this.GlobalTableVersion != null;

        /// <summary>
        /// Gets and sets the property GlobalTableWitnesses. 
        /// <para>
        /// The witness Region and its current status in the MRSC global table. Only one witness
        /// Region can be configured per MRSC global table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalTableWitnessDescription> GlobalTableWitnesses { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalTableWitnessDescription>() : null;

        /// <summary>
        /// Checks to see if the GlobalTableWitnesses property is set.
        /// </summary>
        internal bool IsSetGlobalTableWitnesses() => this.GlobalTableWitnesses != null && (this.GlobalTableWitnesses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items in the specified table. DynamoDB updates this value approximately
        /// every six hours. Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        public long? ItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ItemCount property is set.
        /// </summary>
        internal bool IsSetItemCount() => this.ItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property KeySchema. 
        /// <para>
        /// The primary key structure for the table. Each <c>KeySchemaElement</c> consists of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AttributeName</c> - The name of the attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeyType</c> - The role of the attribute:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HASH</c> - partition key
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RANGE</c> - sort key
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The partition key of an item is also known as its <i>hash attribute</i>. The term
        /// "hash attribute" derives from DynamoDB's usage of an internal hash function to evenly
        /// distribute data items across partitions, based on their partition key values.
        /// </para>
        ///  
        /// <para>
        /// The sort key of an item is also known as its <i>range attribute</i>. The term "range
        /// attribute" derives from the way DynamoDB stores items with the same partition key
        /// physically close together, in sorted order by the sort key value.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For more information about primary keys, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html#DataModelPrimaryKey">Primary
        /// Key</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<KeySchemaElement> KeySchema { get; set; } = AWSConfigs.InitializeCollections ? new List<KeySchemaElement>() : null;

        /// <summary>
        /// Checks to see if the KeySchema property is set.
        /// </summary>
        internal bool IsSetKeySchema() => this.KeySchema != null && (this.KeySchema.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LatestStreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the latest stream for this
        /// table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 37, Max = 1024)]
        public string LatestStreamArn { get; set; }

        /// <summary>
        /// Checks to see if the LatestStreamArn property is set.
        /// </summary>
        internal bool IsSetLatestStreamArn() => this.LatestStreamArn != null;

        /// <summary>
        /// Gets and sets the property LatestStreamLabel. 
        /// <para>
        /// A timestamp, in ISO 8601 format, for this stream.
        /// </para>
        ///  
        /// <para>
        /// Note that <c>LatestStreamLabel</c> is not a unique identifier for the stream, because
        /// it is possible that a stream from another table might have the same timestamp. However,
        /// the combination of the following three elements is guaranteed to be unique:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services customer ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Table name
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StreamLabel</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string LatestStreamLabel { get; set; }

        /// <summary>
        /// Checks to see if the LatestStreamLabel property is set.
        /// </summary>
        internal bool IsSetLatestStreamLabel() => this.LatestStreamLabel != null;

        /// <summary>
        /// Gets and sets the property LocalSecondaryIndexes. 
        /// <para>
        /// Represents one or more local secondary indexes on the table. Each index is scoped
        /// to a given partition key value. Tables with one or more local secondary indexes are
        /// subject to an item collection size limit, where the amount of data within a given
        /// item collection cannot exceed 10 GB. Each element is composed of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IndexName</c> - The name of the local secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeySchema</c> - Specifies the complete index key schema. The attribute names in
        /// the key schema must be between 1 and 255 characters (inclusive). The key schema must
        /// begin with the same partition key as the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Projection</c> - Specifies attributes that are copied (projected) from the table
        /// into the index. These are in addition to the primary key attributes and index key
        /// attributes, which are automatically projected. Each attribute specification is composed
        /// of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ProjectionType</c> - One of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> - Only the index and primary keys are projected into the index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCLUDE</c> - Only the specified table attributes are projected into the index.
        /// The list of projected attributes is in <c>NonKeyAttributes</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> - All of the table attributes are projected into the index.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NonKeyAttributes</c> - A list of one or more non-key attribute names that are
        /// projected into the secondary index. The total count of attributes provided in <c>NonKeyAttributes</c>,
        /// summed across all of the secondary indexes, must not exceed 100. If you project the
        /// same attribute into two different indexes, this counts as two distinct attributes
        /// when determining the total. This limit only applies when you specify the ProjectionType
        /// of <c>INCLUDE</c>. You still can specify the ProjectionType of <c>ALL</c> to project
        /// all attributes from the source table, even if the table has more than 100 attributes.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>IndexSizeBytes</c> - Represents the total size of the index, in bytes. DynamoDB
        /// updates this value approximately every six hours. Recent changes might not be reflected
        /// in this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ItemCount</c> - Represents the number of items in the index. DynamoDB updates
        /// this value approximately every six hours. Recent changes might not be reflected in
        /// this value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the table is in the <c>DELETING</c> state, no information about indexes will be
        /// returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LocalSecondaryIndexDescription> LocalSecondaryIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<LocalSecondaryIndexDescription>() : null;

        /// <summary>
        /// Checks to see if the LocalSecondaryIndexes property is set.
        /// </summary>
        internal bool IsSetLocalSecondaryIndexes() => this.LocalSecondaryIndexes != null && (this.LocalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MultiRegionConsistency. 
        /// <para>
        /// Indicates one of the following consistency modes for a global table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EVENTUAL</c>: Indicates that the global table is configured for multi-Region eventual
        /// consistency (MREC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STRONG</c>: Indicates that the global table is configured for multi-Region strong
        /// consistency (MRSC).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify this field, the global table consistency mode defaults to <c>EVENTUAL</c>.
        /// For more information about global tables consistency modes, see <a href="https://docs.aws.amazon.com/V2globaltables_HowItWorks.html#V2globaltables_HowItWorks.consistency-modes">
        /// Consistency modes</a> in DynamoDB developer guide. 
        /// </para>
        /// </summary>
        public MultiRegionConsistency MultiRegionConsistency { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionConsistency property is set.
        /// </summary>
        internal bool IsSetMultiRegionConsistency() => this.MultiRegionConsistency != null;

        /// <summary>
        /// Gets and sets the property OnDemandThroughput. 
        /// <para>
        /// The maximum number of read and write units for the specified on-demand table. If you
        /// use this parameter, you must specify <c>MaxReadRequestUnits</c>, <c>MaxWriteRequestUnits</c>,
        /// or both.
        /// </para>
        /// </summary>
        public OnDemandThroughput OnDemandThroughput { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandThroughput property is set.
        /// </summary>
        internal bool IsSetOnDemandThroughput() => this.OnDemandThroughput != null;

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput. 
        /// <para>
        /// The provisioned throughput settings for the table, consisting of read and write capacity
        /// units, along with data about increases and decreases.
        /// </para>
        /// </summary>
        public ProvisionedThroughputDescription ProvisionedThroughput { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughput property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughput() => this.ProvisionedThroughput != null;

        /// <summary>
        /// Gets and sets the property Replicas. 
        /// <para>
        /// Represents replicas of the table.
        /// </para>
        ///  
        /// <para>
        /// After a successful disassociation, this list is absent or empty. To confirm disassociation,
        /// also verify that <c>TableStatus</c> is <c>ACTIVE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicaDescription> Replicas { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicaDescription>() : null;

        /// <summary>
        /// Checks to see if the Replicas property is set.
        /// </summary>
        internal bool IsSetReplicas() => this.Replicas != null && (this.Replicas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestoreSummary. 
        /// <para>
        /// Contains details for the restore.
        /// </para>
        /// </summary>
        public RestoreSummary RestoreSummary { get; set; }

        /// <summary>
        /// Checks to see if the RestoreSummary property is set.
        /// </summary>
        internal bool IsSetRestoreSummary() => this.RestoreSummary != null;

        /// <summary>
        /// Gets and sets the property SSEDescription. 
        /// <para>
        /// The description of the server-side encryption status on the specified table.
        /// </para>
        /// </summary>
        public SSEDescription SSEDescription { get; set; }

        /// <summary>
        /// Checks to see if the SSEDescription property is set.
        /// </summary>
        internal bool IsSetSSEDescription() => this.SSEDescription != null;

        /// <summary>
        /// Gets and sets the property StreamSpecification. 
        /// <para>
        /// The current DynamoDB Streams configuration for the table.
        /// </para>
        /// </summary>
        public StreamSpecification StreamSpecification { get; set; }

        /// <summary>
        /// Checks to see if the StreamSpecification property is set.
        /// </summary>
        internal bool IsSetStreamSpecification() => this.StreamSpecification != null;

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the table.
        /// </para>
        /// </summary>
        public string TableArn { get; set; }

        /// <summary>
        /// Checks to see if the TableArn property is set.
        /// </summary>
        internal bool IsSetTableArn() => this.TableArn != null;

        /// <summary>
        /// Gets and sets the property TableClassSummary. 
        /// <para>
        /// Contains details of the table class.
        /// </para>
        /// </summary>
        public TableClassSummary TableClassSummary { get; set; }

        /// <summary>
        /// Checks to see if the TableClassSummary property is set.
        /// </summary>
        internal bool IsSetTableClassSummary() => this.TableClassSummary != null;

        /// <summary>
        /// Gets and sets the property TableId. 
        /// <para>
        /// A unique identifier for the table, in UUID format, generated by DynamoDB when the
        /// table is created.
        /// </para>
        /// </summary>
        public string TableId { get; set; }

        /// <summary>
        /// Checks to see if the TableId property is set.
        /// </summary>
        internal bool IsSetTableId() => this.TableId != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TableSizeBytes. 
        /// <para>
        /// The total size of the specified table, in bytes. DynamoDB updates this value approximately
        /// every six hours. Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        public long? TableSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the TableSizeBytes property is set.
        /// </summary>
        internal bool IsSetTableSizeBytes() => this.TableSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property TableStatus. 
        /// <para>
        /// The current state of the table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The table is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The table/index configuration is being updated. The table/index
        /// remains available for data operations when <c>UPDATING</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The table is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The table is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACCESSIBLE_ENCRYPTION_CREDENTIALS</c> - The KMS key used to encrypt the table
        /// in inaccessible. Table operations may fail due to failure to use the KMS key. DynamoDB
        /// will initiate the table archival process when a table's KMS key remains inaccessible
        /// for more than seven days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARCHIVING</c> - The table is being archived. Operations are not allowed until
        /// archival is complete. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARCHIVED</c> - The table has been archived. See the ArchivalReason for more information.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TableStatus TableStatus { get; set; }

        /// <summary>
        /// Checks to see if the TableStatus property is set.
        /// </summary>
        internal bool IsSetTableStatus() => this.TableStatus != null;

        /// <summary>
        /// Gets and sets the property VectorIndexes. 
        /// <para>
        /// The vector indexes, if any, on the table. Each element is composed of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IndexName</c> - The name of the vector index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IndexStatus</c> - The current status of the vector index: <c>CREATING</c>, <c>ACTIVE</c>,
        /// or <c>DELETING</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Backfilling</c> - Specifies whether the index is currently backfilling. During
        /// backfill, <c>SearchVectors</c> operations might return incomplete results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VectorAttribute</c> - The attribute that contains vector embeddings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Dimensions</c> - The number of dimensions in each vector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DistanceFunction</c> - The distance function used to calculate similarity (<c>COSINE</c>,
        /// <c>EUCLIDEAN</c>, or <c>DOT_PRODUCT</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SearchSchema</c> - The partition key and inline filter attributes for the vector
        /// index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Projection</c> - Specifies attributes that are copied (projected) from the table
        /// into the vector index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IndexArn</c> - The Amazon Resource Name (ARN) that uniquely identifies the index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IndexSizeBytes</c> - The total size of the vector index, in bytes. Amazon DynamoDB
        /// updates this value approximately every six hours. Recent changes might not be reflected
        /// in this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ItemCount</c> - The number of items indexed in the vector index. Amazon DynamoDB
        /// updates this value approximately every six hours. Recent changes might not be reflected
        /// in this value.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VectorIndexDescription> VectorIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<VectorIndexDescription>() : null;

        /// <summary>
        /// Checks to see if the VectorIndexes property is set.
        /// </summary>
        internal bool IsSetVectorIndexes() => this.VectorIndexes != null && (this.VectorIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WarmThroughput. 
        /// <para>
        /// Describes the warm throughput value of the base table.
        /// </para>
        /// </summary>
        public TableWarmThroughputDescription WarmThroughput { get; set; }

        /// <summary>
        /// Checks to see if the WarmThroughput property is set.
        /// </summary>
        internal bool IsSetWarmThroughput() => this.WarmThroughput != null;
    }
}
