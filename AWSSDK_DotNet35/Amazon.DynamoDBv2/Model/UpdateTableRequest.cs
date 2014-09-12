/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTable operation.
    /// Updates the provisioned throughput for the given table. Setting the throughput for
    /// a table      helps you manage performance and is part of the provisioned throughput
    /// feature of DynamoDB.
    /// 
    ///     
    /// <para>
    /// The provisioned throughput values can be upgraded or downgraded based on the maximums
    /// and      minimums listed in the <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Limits</a>
    /// section in the      Amazon DynamoDB Developer Guide.
    /// </para>
    ///     
    /// <para>
    /// The table must be in the <code>ACTIVE</code> state for this operation to succeed.
    ///        <i>UpdateTable</i> is an asynchronous operation; while executing the operation,
    /// the table is      in the <code>UPDATING</code> state. While the table is in the <code>UPDATING</code>
    /// state, the      table still has the provisioned throughput from before the call. The
    /// new provisioned      throughput setting is in effect only when the table returns to
    /// the <code>ACTIVE</code> state      after the <i>UpdateTable</i> operation. 
    /// </para>
    ///     
    /// <para>
    /// You cannot add, modify or delete indexes using <i>UpdateTable</i>. Indexes can only
    /// be      defined at table creation time.
    /// </para>
    /// </summary>
    public partial class UpdateTableRequest : AmazonDynamoDBRequest
    {
        private List<GlobalSecondaryIndexUpdate> _globalSecondaryIndexUpdates = new List<GlobalSecondaryIndexUpdate>();
        private ProvisionedThroughput _provisionedThroughput;
        private string _tableName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateTableRequest() { }

        /// <summary>
        /// Instantiates UpdateTableRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table to be updated.</param>
        /// <param name="provisionedThroughput">Sets the UpdateTableRequest ProvisionedThroughput property</param>
        public UpdateTableRequest(string tableName, ProvisionedThroughput provisionedThroughput)
        {
            _tableName = tableName;
            _provisionedThroughput = provisionedThroughput;
        }

        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexUpdates. 
        /// <para>
        /// An array of one or more global secondary indexes on the table, together with provisioned
        /// throughput settings      for each index.
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
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table to be updated.
        /// </para>
        /// </summary>
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