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
    /// Container for the parameters to the UpdateTable operation. Modifies the provisioned
    /// throughput settings, global secondary indexes, DynamoDB Streams settings, or global
    /// table replica settings for a given table. <para> You can only perform one of the following
    /// operations at once: </para> <ul> <li> <para> Modify the provisioned throughput settings
    /// of the table. </para> </li> <li> <para> Remove a global secondary index from the table.
    /// </para> </li> <li> <para> Create a new global secondary index on the table. After
    /// the index begins backfilling, you can use <c>UpdateTable</c> to perform other operations.
    /// </para> </li> <li> <para> Enable or disable disassociation protection for the local
    /// global table replica. </para> </li> <li> <para> Disassociate the local global table
    /// replica and keep it as a standalone regional table. The <c>Disassociate</c> action
    /// must be the only replica update in the request. If the request includes any other
    /// update, <c>UpdateTable</c> fails with a <c>ValidationException</c> and the disassociation
    /// does not start. </para> </li> </ul> <para> <c>UpdateTable</c> is an asynchronous operation;
    /// while it's executing, the table status changes from <c>ACTIVE</c> to <c>UPDATING</c>.
    /// While it's <c>UPDATING</c>, you can't issue another <c>UpdateTable</c> request. Use
    /// <c>DescribeTable</c> to monitor the table's status. </para> <para> To use this operation
    /// to disassociate a local replica, you must have the <c>dynamodb:UpdateTable</c> and
    /// <c>dynamodb:DisassociateTableReplica</c> IAM permissions on the local replica. Send
    /// disassociation and disassociation protection requests to the replica's Region using
    /// credentials for the account that owns the replica. For prerequisites and the procedure,
    /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables-disassociate.html">Disassociating
    /// a global table replica</a> in the <i>Amazon DynamoDB Developer Guide</i>. </para>
    /// <para> To confirm successful disassociation, call <c>DescribeTable</c> in the replica's
    /// Region and verify that <c>TableStatus</c> is <c>ACTIVE</c> and <c>Replicas</c> is
    /// absent or empty. If <c>TableStatus</c> returns to <c>ACTIVE</c> but the response still
    /// includes a <c>Replicas</c> list, the disassociation did not complete. Check <c>ReplicaStatus</c>
    /// for a replication-permission or encryption-access problem, resolve it, and retry.
    /// </para>
    /// </summary>
    public partial class UpdateTableRequest : AmazonDynamoDBRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public UpdateTableRequest() { }

        /// <summary>
        /// Instantiates UpdateTableRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table to be updated. You can also provide the Amazon Resource Name (ARN) of the table   in this parameter.</param>
        /// <param name="provisionedThroughput">The new provisioned throughput settings for the specified table or index.</param>
        public UpdateTableRequest(string tableName, ProvisionedThroughput provisionedThroughput)
        {
            this.TableName = tableName;
            this.ProvisionedThroughput = provisionedThroughput;
        }

        /// <summary>
        /// Gets and sets the property AttributeDefinitions. 
        /// <para>
        /// An array of attributes that describe the key schema for the table and indexes. If
        /// you are adding a new global secondary index to the table, <c>AttributeDefinitions</c>
        /// must include the key element(s) of the new index.
        /// </para>
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
        public BillingMode BillingMode { get; set; }

        /// <summary>
        /// Checks to see if the BillingMode property is set.
        /// </summary>
        internal bool IsSetBillingMode() => this.BillingMode != null;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Indicates whether deletion protection is to be enabled (true) or disabled (false)
        /// on the table.
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
        /// for the local replica of a multi-Region eventual consistency (MREC) global table using
        /// Version 2019.11.21.
        /// </para>
        ///  
        /// <para>
        /// Disassociation protection is enabled by default. If you omit this parameter, the existing
        /// setting is unchanged. This setting is independent of <c>DeletionProtectionEnabled</c>.
        /// </para>
        ///  
        /// <para>
        /// You can't combine this change with any other change in the same <c>UpdateTable</c>
        /// request.
        /// </para>
        /// </summary>
        public bool? DisassociationProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DisassociationProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDisassociationProtectionEnabled() => this.DisassociationProtectionEnabled.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalSecondaryIndexUpdate> GlobalSecondaryIndexUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalSecondaryIndexUpdate>() : null;

        /// <summary>
        /// Checks to see if the GlobalSecondaryIndexUpdates property is set.
        /// </summary>
        internal bool IsSetGlobalSecondaryIndexUpdates() => this.GlobalSecondaryIndexUpdates != null && (this.GlobalSecondaryIndexUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlobalTableSettingsReplicationMode. 
        /// <para>
        /// Controls the settings replication mode for a global table replica. This attribute
        /// can be defined using UpdateTable operation only on a regional table with values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c>: Defines settings replication on a regional table to be used as a
        /// source table for creating Multi-Account Global Table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c>: Remove settings replication on a regional table. Settings replication
        /// needs to be defined to ENABLED again in order to create a Multi-Account Global Table
        /// using this table. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GlobalTableSettingsReplicationMode GlobalTableSettingsReplicationMode { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableSettingsReplicationMode property is set.
        /// </summary>
        internal bool IsSetGlobalTableSettingsReplicationMode() => this.GlobalTableSettingsReplicationMode != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<GlobalTableWitnessGroupUpdate> GlobalTableWitnessUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalTableWitnessGroupUpdate>() : null;

        /// <summary>
        /// Checks to see if the GlobalTableWitnessUpdates property is set.
        /// </summary>
        internal bool IsSetGlobalTableWitnessUpdates() => this.GlobalTableWitnessUpdates != null && (this.GlobalTableWitnessUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public MultiRegionConsistency MultiRegionConsistency { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionConsistency property is set.
        /// </summary>
        internal bool IsSetMultiRegionConsistency() => this.MultiRegionConsistency != null;

        /// <summary>
        /// Gets and sets the property OnDemandThroughput. 
        /// <para>
        /// Updates the maximum number of read and write units for the specified table in on-demand
        /// capacity mode. If you use this parameter, you must specify <c>MaxReadRequestUnits</c>,
        /// <c>MaxWriteRequestUnits</c>, or both.
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
        /// The new provisioned throughput settings for the specified table or index.
        /// </para>
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughput property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughput() => this.ProvisionedThroughput != null;

        /// <summary>
        /// Gets and sets the property ReplicaUpdates. 
        /// <para>
        /// A list of replica update actions (create, delete, update, or disassociate) for the
        /// table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ReplicationGroupUpdate> ReplicaUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicationGroupUpdate>() : null;

        /// <summary>
        /// Checks to see if the ReplicaUpdates property is set.
        /// </summary>
        internal bool IsSetReplicaUpdates() => this.ReplicaUpdates != null && (this.ReplicaUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SSESpecification. 
        /// <para>
        /// The new server-side encryption settings for the specified table.
        /// </para>
        /// </summary>
        public SSESpecification SSESpecification { get; set; }

        /// <summary>
        /// Checks to see if the SSESpecification property is set.
        /// </summary>
        internal bool IsSetSSESpecification() => this.SSESpecification != null;

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
        public StreamSpecification StreamSpecification { get; set; }

        /// <summary>
        /// Checks to see if the StreamSpecification property is set.
        /// </summary>
        internal bool IsSetStreamSpecification() => this.StreamSpecification != null;

        /// <summary>
        /// Gets and sets the property TableClass. 
        /// <para>
        /// The table class of the table to be updated. Valid values are <c>STANDARD</c> and <c>STANDARD_INFREQUENT_ACCESS</c>.
        /// </para>
        /// </summary>
        public TableClass TableClass { get; set; }

        /// <summary>
        /// Checks to see if the TableClass property is set.
        /// </summary>
        internal bool IsSetTableClass() => this.TableClass != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table to be updated. You can also provide the Amazon Resource Name
        /// (ARN) of the table in this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property VectorIndexUpdates. 
        /// <para>
        /// A list of vector indexes to be added to or removed from the table. You can add or
        /// remove one vector index for each <c>UpdateTable</c> operation.
        /// </para>
        ///  
        /// <para>
        /// To add a vector index, specify <c>IndexName</c>, <c>VectorAttribute</c>, <c>Dimensions</c>,
        /// <c>DistanceFunction</c>, and <c>Projection</c>. To remove a vector index, specify
        /// only the <c>IndexName</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VectorIndexUpdate> VectorIndexUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<VectorIndexUpdate>() : null;

        /// <summary>
        /// Checks to see if the VectorIndexUpdates property is set.
        /// </summary>
        internal bool IsSetVectorIndexUpdates() => this.VectorIndexUpdates != null && (this.VectorIndexUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WarmThroughput. 
        /// <para>
        /// Represents the warm throughput (in read units per second and write units per second)
        /// for updating a table.
        /// </para>
        /// </summary>
        public WarmThroughput WarmThroughput { get; set; }

        /// <summary>
        /// Checks to see if the WarmThroughput property is set.
        /// </summary>
        internal bool IsSetWarmThroughput() => this.WarmThroughput != null;
    }
}
