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
    /// Container for the parameters to the UpdateTable operation.
    /// Modifies the provisioned throughput settings, global secondary indexes, or DynamoDB
    /// Streams settings for a given table.
    /// 
    ///  
    /// <para>
    /// You can only perform one of the following operations at once:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Modify the provisioned throughput settings of the table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Remove a global secondary index from the table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create a new global secondary index on the table. After the index begins backfilling,
    /// you can use <c>UpdateTable</c> to perform other operations.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <c>UpdateTable</c> is an asynchronous operation; while it's executing, the table
    /// status changes from <c>ACTIVE</c> to <c>UPDATING</c>. While it's <c>UPDATING</c>,
    /// you can't issue another <c>UpdateTable</c> request. When the table returns to the
    /// <c>ACTIVE</c> state, the <c>UpdateTable</c> operation is complete.
    /// </para>
    /// </summary>
    public partial class UpdateTableRequest : AmazonDynamoDBRequest
    {
        private List<AttributeDefinition> _attributeDefinitions = AWSConfigs.InitializeCollections ? new List<AttributeDefinition>() : null;
        private BillingMode _billingMode;
        private bool? _deletionProtectionEnabled;
        private List<GlobalSecondaryIndexUpdate> _globalSecondaryIndexUpdates = AWSConfigs.InitializeCollections ? new List<GlobalSecondaryIndexUpdate>() : null;
        private List<GlobalTableWitnessGroupUpdate> _globalTableWitnessUpdates = AWSConfigs.InitializeCollections ? new List<GlobalTableWitnessGroupUpdate>() : null;
        private MultiRegionConsistency _multiRegionConsistency;
        private OnDemandThroughput _onDemandThroughput;
        private ProvisionedThroughput _provisionedThroughput;
        private List<ReplicationGroupUpdate> _replicaUpdates = AWSConfigs.InitializeCollections ? new List<ReplicationGroupUpdate>() : null;
        private SSESpecification _sseSpecification;
        private StreamSpecification _streamSpecification;
        private TableClass _tableClass;
        private string _tableName;
        private WarmThroughput _warmThroughput;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateTableRequest() { }

        /// <summary>
        /// Instantiates UpdateTableRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table to be updated. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="provisionedThroughput">The new provisioned throughput settings for the specified table or index.</param>
        public UpdateTableRequest(string tableName, ProvisionedThroughput provisionedThroughput)
        {
            _tableName = tableName;
            _provisionedThroughput = provisionedThroughput;
        }

        /// <summary>
        /// Gets and sets the property AttributeDefinitions. 
        /// <para>
        /// An array of attributes that describe the key schema for the table and indexes. If
        /// you are adding a new global secondary index to the table, <c>AttributeDefinitions</c>
        /// must include the key element(s) of the new index.
        /// </para>
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
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// Controls how you are charged for read and write throughput and how you manage capacity.
        /// When switching from pay-per-request to provisioned capacity, initial provisioned capacity
        /// values must be set. The initial provisioned capacity values are estimated based on
        /// the consumed read and write capacity of your table and global secondary indexes over
        /// the past 30 minutes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PAY_PER_REQUEST</c> - We recommend using <c>PAY_PER_REQUEST</c> for most DynamoDB
        /// workloads. <c>PAY_PER_REQUEST</c> sets the billing mode to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/on-demand-capacity-mode.html">On-demand
        /// capacity mode</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROVISIONED</c> - We recommend using <c>PROVISIONED</c> for steady workloads with
        /// predictable growth where capacity requirements can be reliably forecasted. <c>PROVISIONED</c>
        /// sets the billing mode to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/provisioned-capacity-mode.html">Provisioned
        /// capacity mode</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BillingMode BillingMode
        {
            get { return this._billingMode; }
            set { this._billingMode = value; }
        }

        // Check to see if BillingMode property is set
        internal bool IsSetBillingMode()
        {
            return this._billingMode != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Indicates whether deletion protection is to be enabled (true) or disabled (false)
        /// on the table.
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
        /// Gets and sets the property GlobalSecondaryIndexUpdates. 
        /// <para>
        /// An array of one or more global secondary indexes for the table. For each index in
        /// the array, you can request one action:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Create</c> - add a new global secondary index to the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Update</c> - modify the provisioned throughput settings of an existing global
        /// secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Delete</c> - remove a global secondary index from the table.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create or delete only one global secondary index per <c>UpdateTable</c> operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GSI.OnlineOps.html">Managing
        /// Global Secondary Indexes</a> in the <i>Amazon DynamoDB Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalSecondaryIndexUpdate> GlobalSecondaryIndexUpdates
        {
            get { return this._globalSecondaryIndexUpdates; }
            set { this._globalSecondaryIndexUpdates = value; }
        }

        // Check to see if GlobalSecondaryIndexUpdates property is set
        internal bool IsSetGlobalSecondaryIndexUpdates()
        {
            return this._globalSecondaryIndexUpdates != null && (this._globalSecondaryIndexUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GlobalTableWitnessUpdates. 
        /// <para>
        /// A list of witness updates for a MRSC global table. A witness provides a cost-effective
        /// alternative to a full replica in a MRSC global table by maintaining replicated change
        /// data written to global table replicas. You cannot perform read or write operations
        /// on a witness. For each witness, you can request one action:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Create</c> - add a new witness to the global table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Delete</c> - remove a witness from the global table.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create or delete only one witness per <c>UpdateTable</c> operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_HowItWorks.html#V2globaltables_HowItWorks.consistency-modes">Multi-Region
        /// strong consistency (MRSC)</a> in the Amazon DynamoDB Developer Guide
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<GlobalTableWitnessGroupUpdate> GlobalTableWitnessUpdates
        {
            get { return this._globalTableWitnessUpdates; }
            set { this._globalTableWitnessUpdates = value; }
        }

        // Check to see if GlobalTableWitnessUpdates property is set
        internal bool IsSetGlobalTableWitnessUpdates()
        {
            return this._globalTableWitnessUpdates != null && (this._globalTableWitnessUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MultiRegionConsistency. 
        /// <para>
        /// Specifies the consistency mode for a new global table. This parameter is only valid
        /// when you create a global table by specifying one or more <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ReplicationGroupUpdate.html#DDB-Type-ReplicationGroupUpdate-Create">Create</a>
        /// actions in the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_UpdateTable.html#DDB-UpdateTable-request-ReplicaUpdates">ReplicaUpdates</a>
        /// action list.
        /// </para>
        ///  
        /// <para>
        /// You can specify one of the following consistency modes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EVENTUAL</c>: Configures a new global table for multi-Region eventual consistency
        /// (MREC). This is the default consistency mode for global tables.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STRONG</c>: Configures a new global table for multi-Region strong consistency
        /// (MRSC).
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
        /// Updates the maximum number of read and write units for the specified table in on-demand
        /// capacity mode. If you use this parameter, you must specify <c>MaxReadRequestUnits</c>,
        /// <c>MaxWriteRequestUnits</c>, or both.
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
        /// The new provisioned throughput settings for the specified table or index.
        /// </para>
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput
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
        /// Gets and sets the property ReplicaUpdates. 
        /// <para>
        /// A list of replica update actions (create, delete, or update) for the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ReplicationGroupUpdate> ReplicaUpdates
        {
            get { return this._replicaUpdates; }
            set { this._replicaUpdates = value; }
        }

        // Check to see if ReplicaUpdates property is set
        internal bool IsSetReplicaUpdates()
        {
            return this._replicaUpdates != null && (this._replicaUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SSESpecification. 
        /// <para>
        /// The new server-side encryption settings for the specified table.
        /// </para>
        /// </summary>
        public SSESpecification SSESpecification
        {
            get { return this._sseSpecification; }
            set { this._sseSpecification = value; }
        }

        // Check to see if SSESpecification property is set
        internal bool IsSetSSESpecification()
        {
            return this._sseSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property StreamSpecification. 
        /// <para>
        /// Represents the DynamoDB Streams configuration for the table.
        /// </para>
        ///  <note> 
        /// <para>
        /// You receive a <c>ValidationException</c> if you try to enable a stream on a table
        /// that already has a stream, or if you try to disable a stream on a table that doesn't
        /// have a stream.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property TableClass. 
        /// <para>
        /// The table class of the table to be updated. Valid values are <c>STANDARD</c> and <c>STANDARD_INFREQUENT_ACCESS</c>.
        /// </para>
        /// </summary>
        public TableClass TableClass
        {
            get { return this._tableClass; }
            set { this._tableClass = value; }
        }

        // Check to see if TableClass property is set
        internal bool IsSetTableClass()
        {
            return this._tableClass != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table to be updated. You can also provide the Amazon Resource Name
        /// (ARN) of the table in this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// Gets and sets the property WarmThroughput. 
        /// <para>
        /// Represents the warm throughput (in read units per second and write units per second)
        /// for updating a table.
        /// </para>
        /// </summary>
        public WarmThroughput WarmThroughput
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