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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
        private ArchivalSummary _archivalSummary;
        private List<AttributeDefinition> _attributeDefinitions = AWSConfigs.InitializeCollections ? new List<AttributeDefinition>() : null;
        private BillingModeSummary _billingModeSummary;
        private DateTime? _creationDateTime;
        private bool? _deletionProtectionEnabled;
        private List<GlobalSecondaryIndexDescription> _globalSecondaryIndexes = AWSConfigs.InitializeCollections ? new List<GlobalSecondaryIndexDescription>() : null;
        private string _globalTableVersion;
        private List<GlobalTableWitnessDescription> _globalTableWitnesses = AWSConfigs.InitializeCollections ? new List<GlobalTableWitnessDescription>() : null;
        private long? _itemCount;
        private List<KeySchemaElement> _keySchema = AWSConfigs.InitializeCollections ? new List<KeySchemaElement>() : null;
        private string _latestStreamArn;
        private string _latestStreamLabel;
        private List<LocalSecondaryIndexDescription> _localSecondaryIndexes = AWSConfigs.InitializeCollections ? new List<LocalSecondaryIndexDescription>() : null;
        private MultiRegionConsistency _multiRegionConsistency;
        private OnDemandThroughput _onDemandThroughput;
        private ProvisionedThroughputDescription _provisionedThroughput;
        private List<ReplicaDescription> _replicas = AWSConfigs.InitializeCollections ? new List<ReplicaDescription>() : null;
        private RestoreSummary _restoreSummary;
        private SSEDescription _sseDescription;
        private StreamSpecification _streamSpecification;
        private string _tableArn;
        private TableClassSummary _tableClassSummary;
        private string _tableId;
        private string _tableName;
        private long? _tableSizeBytes;
        private TableStatus _tableStatus;
        private TableWarmThroughputDescription _warmThroughput;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public TableDescription() { }

        /// <summary>
        /// Gets and sets the property ArchivalSummary. 
        /// <para>
        /// Contains information about the table archive.
        /// </para>
        /// </summary>
        public ArchivalSummary ArchivalSummary
        {
            get { return this._archivalSummary; }
            set { this._archivalSummary = value; }
        }

        // Check to see if ArchivalSummary property is set
        internal bool IsSetArchivalSummary()
        {
            return this._archivalSummary != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeDefinition> AttributeDefinitions
        {
            get { return this._attributeDefinitions; }
            set { this._attributeDefinitions = value; }
        }

        // Check to see if AttributeDefinitions property is set
        internal bool IsSetAttributeDefinitions()
        {
            return this._attributeDefinitions != null && (this._attributeDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BillingModeSummary. 
        /// <para>
        /// Contains the details for the read/write capacity mode.
        /// </para>
        /// </summary>
        public BillingModeSummary BillingModeSummary
        {
            get { return this._billingModeSummary; }
            set { this._billingModeSummary = value; }
        }

        // Check to see if BillingModeSummary property is set
        internal bool IsSetBillingModeSummary()
        {
            return this._billingModeSummary != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time when the table was created, in <a href="http://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Indicates whether deletion protection is enabled (true) or disabled (false) on the
        /// table.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled; }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalSecondaryIndexDescription> GlobalSecondaryIndexes
        {
            get { return this._globalSecondaryIndexes; }
            set { this._globalSecondaryIndexes = value; }
        }

        // Check to see if GlobalSecondaryIndexes property is set
        internal bool IsSetGlobalSecondaryIndexes()
        {
            return this._globalSecondaryIndexes != null && (this._globalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GlobalTableVersion. 
        /// <para>
        /// Represents the version of <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">global
        /// tables</a> in use, if the table is replicated across Amazon Web Services Regions.
        /// </para>
        /// </summary>
        public string GlobalTableVersion
        {
            get { return this._globalTableVersion; }
            set { this._globalTableVersion = value; }
        }

        // Check to see if GlobalTableVersion property is set
        internal bool IsSetGlobalTableVersion()
        {
            return this._globalTableVersion != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalTableWitnesses. 
        /// <para>
        /// The witness Region and its current status in the MRSC global table. Only one witness
        /// Region can be configured per MRSC global table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalTableWitnessDescription> GlobalTableWitnesses
        {
            get { return this._globalTableWitnesses; }
            set { this._globalTableWitnesses = value; }
        }

        // Check to see if GlobalTableWitnesses property is set
        internal bool IsSetGlobalTableWitnesses()
        {
            return this._globalTableWitnesses != null && (this._globalTableWitnesses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items in the specified table. DynamoDB updates this value approximately
        /// every six hours. Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        public long? ItemCount
        {
            get { return this._itemCount; }
            set { this._itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this._itemCount.HasValue; 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<KeySchemaElement> KeySchema
        {
            get { return this._keySchema; }
            set { this._keySchema = value; }
        }

        // Check to see if KeySchema property is set
        internal bool IsSetKeySchema()
        {
            return this._keySchema != null && (this._keySchema.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LatestStreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the latest stream for this
        /// table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=37, Max=1024)]
        public string LatestStreamArn
        {
            get { return this._latestStreamArn; }
            set { this._latestStreamArn = value; }
        }

        // Check to see if LatestStreamArn property is set
        internal bool IsSetLatestStreamArn()
        {
            return this._latestStreamArn != null;
        }

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
        public string LatestStreamLabel
        {
            get { return this._latestStreamLabel; }
            set { this._latestStreamLabel = value; }
        }

        // Check to see if LatestStreamLabel property is set
        internal bool IsSetLatestStreamLabel()
        {
            return this._latestStreamLabel != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LocalSecondaryIndexDescription> LocalSecondaryIndexes
        {
            get { return this._localSecondaryIndexes; }
            set { this._localSecondaryIndexes = value; }
        }

        // Check to see if LocalSecondaryIndexes property is set
        internal bool IsSetLocalSecondaryIndexes()
        {
            return this._localSecondaryIndexes != null && (this._localSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public MultiRegionConsistency MultiRegionConsistency
        {
            get { return this._multiRegionConsistency; }
            set { this._multiRegionConsistency = value; }
        }

        // Check to see if MultiRegionConsistency property is set
        internal bool IsSetMultiRegionConsistency()
        {
            return this._multiRegionConsistency != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandThroughput. 
        /// <para>
        /// The maximum number of read and write units for the specified on-demand table. If you
        /// use this parameter, you must specify <c>MaxReadRequestUnits</c>, <c>MaxWriteRequestUnits</c>,
        /// or both.
        /// </para>
        /// </summary>
        public OnDemandThroughput OnDemandThroughput
        {
            get { return this._onDemandThroughput; }
            set { this._onDemandThroughput = value; }
        }

        // Check to see if OnDemandThroughput property is set
        internal bool IsSetOnDemandThroughput()
        {
            return this._onDemandThroughput != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput. 
        /// <para>
        /// The provisioned throughput settings for the table, consisting of read and write capacity
        /// units, along with data about increases and decreases.
        /// </para>
        /// </summary>
        public ProvisionedThroughputDescription ProvisionedThroughput
        {
            get { return this._provisionedThroughput; }
            set { this._provisionedThroughput = value; }
        }

        // Check to see if ProvisionedThroughput property is set
        internal bool IsSetProvisionedThroughput()
        {
            return this._provisionedThroughput != null;
        }

        /// <summary>
        /// Gets and sets the property Replicas. 
        /// <para>
        /// Represents replicas of the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicaDescription> Replicas
        {
            get { return this._replicas; }
            set { this._replicas = value; }
        }

        // Check to see if Replicas property is set
        internal bool IsSetReplicas()
        {
            return this._replicas != null && (this._replicas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RestoreSummary. 
        /// <para>
        /// Contains details for the restore.
        /// </para>
        /// </summary>
        public RestoreSummary RestoreSummary
        {
            get { return this._restoreSummary; }
            set { this._restoreSummary = value; }
        }

        // Check to see if RestoreSummary property is set
        internal bool IsSetRestoreSummary()
        {
            return this._restoreSummary != null;
        }

        /// <summary>
        /// Gets and sets the property SSEDescription. 
        /// <para>
        /// The description of the server-side encryption status on the specified table.
        /// </para>
        /// </summary>
        public SSEDescription SSEDescription
        {
            get { return this._sseDescription; }
            set { this._sseDescription = value; }
        }

        // Check to see if SSEDescription property is set
        internal bool IsSetSSEDescription()
        {
            return this._sseDescription != null;
        }

        /// <summary>
        /// Gets and sets the property StreamSpecification. 
        /// <para>
        /// The current DynamoDB Streams configuration for the table.
        /// </para>
        /// </summary>
        public StreamSpecification StreamSpecification
        {
            get { return this._streamSpecification; }
            set { this._streamSpecification = value; }
        }

        // Check to see if StreamSpecification property is set
        internal bool IsSetStreamSpecification()
        {
            return this._streamSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the table.
        /// </para>
        /// </summary>
        public string TableArn
        {
            get { return this._tableArn; }
            set { this._tableArn = value; }
        }

        // Check to see if TableArn property is set
        internal bool IsSetTableArn()
        {
            return this._tableArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableClassSummary. 
        /// <para>
        /// Contains details of the table class.
        /// </para>
        /// </summary>
        public TableClassSummary TableClassSummary
        {
            get { return this._tableClassSummary; }
            set { this._tableClassSummary = value; }
        }

        // Check to see if TableClassSummary property is set
        internal bool IsSetTableClassSummary()
        {
            return this._tableClassSummary != null;
        }

        /// <summary>
        /// Gets and sets the property TableId. 
        /// <para>
        /// Unique identifier for the table for which the backup was created. 
        /// </para>
        /// </summary>
        public string TableId
        {
            get { return this._tableId; }
            set { this._tableId = value; }
        }

        // Check to see if TableId property is set
        internal bool IsSetTableId()
        {
            return this._tableId != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TableSizeBytes. 
        /// <para>
        /// The total size of the specified table, in bytes. DynamoDB updates this value approximately
        /// every six hours. Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        public long? TableSizeBytes
        {
            get { return this._tableSizeBytes; }
            set { this._tableSizeBytes = value; }
        }

        // Check to see if TableSizeBytes property is set
        internal bool IsSetTableSizeBytes()
        {
            return this._tableSizeBytes.HasValue; 
        }

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
        public TableStatus TableStatus
        {
            get { return this._tableStatus; }
            set { this._tableStatus = value; }
        }

        // Check to see if TableStatus property is set
        internal bool IsSetTableStatus()
        {
            return this._tableStatus != null;
        }

        /// <summary>
        /// Gets and sets the property WarmThroughput. 
        /// <para>
        /// Describes the warm throughput value of the base table.
        /// </para>
        /// </summary>
        public TableWarmThroughputDescription WarmThroughput
        {
            get { return this._warmThroughput; }
            set { this._warmThroughput = value; }
        }

        // Check to see if WarmThroughput property is set
        internal bool IsSetWarmThroughput()
        {
            return this._warmThroughput != null;
        }

    }
}