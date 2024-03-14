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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTable operation.
    /// Modifies the provisioned throughput settings, global secondary indexes, or DynamoDB
    /// Streams settings for a given table.
    /// 
    ///  <important> 
    /// <para>
    /// This operation only applies to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.V2.html">Version
    /// 2019.11.21 (Current)</a> of global tables. 
    /// </para>
    ///  </important> 
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
    /// you can't issue another <c>UpdateTable</c> request on the base table nor any replicas.
    /// When the table returns to the <c>ACTIVE</c> state, the <c>UpdateTable</c> operation
    /// is complete.
    /// </para>
    /// </summary>
    public partial class UpdateTableRequest : AmazonDynamoDBRequest
    {
        private List<AttributeDefinition> _attributeDefinitions = new List<AttributeDefinition>();
        private BillingMode _billingMode;
        private bool? _deletionProtectionEnabled;
        private List<GlobalSecondaryIndexUpdate> _globalSecondaryIndexUpdates = new List<GlobalSecondaryIndexUpdate>();
        private ProvisionedThroughput _provisionedThroughput;
        private List<ReplicationGroupUpdate> _replicaUpdates = new List<ReplicationGroupUpdate>();
        private SSESpecification _sseSpecification;
        private StreamSpecification _streamSpecification;
        private TableClass _tableClass;
        private string _tableName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateTableRequest() { }

        /// <summary>
        /// Instantiates UpdateTableRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table to be updated.</param>
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
        /// </summary>
        public List<AttributeDefinition> AttributeDefinitions
        {
            get { return this._attributeDefinitions; }
            set { this._attributeDefinitions = value; }
        }

        // Check to see if AttributeDefinitions property is set
        internal bool IsSetAttributeDefinitions()
        {
            return this._attributeDefinitions != null && this._attributeDefinitions.Count > 0; 
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
        ///  <c>PROVISIONED</c> - We recommend using <c>PROVISIONED</c> for predictable workloads.
        /// <c>PROVISIONED</c> sets the billing mode to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadWriteCapacityMode.html#HowItWorks.ProvisionedThroughput.Manual">Provisioned
        /// Mode</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAY_PER_REQUEST</c> - We recommend using <c>PAY_PER_REQUEST</c> for unpredictable
        /// workloads. <c>PAY_PER_REQUEST</c> sets the billing mode to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadWriteCapacityMode.html#HowItWorks.OnDemand">On-Demand
        /// Mode</a>. 
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
        /// </summary>
        public List<GlobalSecondaryIndexUpdate> GlobalSecondaryIndexUpdates
        {
            get { return this._globalSecondaryIndexUpdates; }
            set { this._globalSecondaryIndexUpdates = value; }
        }

        // Check to see if GlobalSecondaryIndexUpdates property is set
        internal bool IsSetGlobalSecondaryIndexUpdates()
        {
            return this._globalSecondaryIndexUpdates != null && this._globalSecondaryIndexUpdates.Count > 0; 
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
        ///  <note> 
        /// <para>
        /// This property only applies to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.V2.html">Version
        /// 2019.11.21 (Current)</a> of global tables. 
        /// </para>
        ///  </note>
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
            return this._replicaUpdates != null && this._replicaUpdates.Count > 0; 
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
        /// The name of the table to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
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

    }
}