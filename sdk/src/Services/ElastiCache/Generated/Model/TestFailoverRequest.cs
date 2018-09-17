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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the TestFailover operation.
    /// Represents the input of a <code>TestFailover</code> operation which test automatic
    /// failover on a specified node group (called shard in the console) in a replication
    /// group (called cluster in the console).
    /// 
    ///  <p class="title"> <b>Note the following</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A customer can use this operation to test automatic failover on up to 5 shards (called
    /// node groups in the ElastiCache API and AWS CLI) in any rolling 24-hour period.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If calling this operation on shards in different clusters (called replication groups
    /// in the API and CLI), the calls can be made concurrently.
    /// </para>
    ///  
    /// <para>
    ///  
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If calling this operation multiple times on different shards in the same Redis (cluster
    /// mode enabled) replication group, the first node replacement must complete before a
    /// subsequent call can be made.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To determine whether the node replacement is complete you can check Events using the
    /// Amazon ElastiCache console, the AWS CLI, or the ElastiCache API. Look for the following
    /// automatic failover related events, listed here in order of occurrance:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Replication group message: <code>Test Failover API called for node group &lt;node-group-id&gt;</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cache cluster message: <code>Failover from master node &lt;primary-node-id&gt; to
    /// replica node &lt;node-id&gt; completed</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Replication group message: <code>Failover from master node &lt;primary-node-id&gt;
    /// to replica node &lt;node-id&gt; completed</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cache cluster message: <code>Recovering cache nodes &lt;node-id&gt;</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cache cluster message: <code>Finished recovery for cache nodes &lt;node-id&gt;</code>
    /// 
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information see:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/ECEvents.Viewing.html">Viewing
    /// ElastiCache Events</a> in the <i>ElastiCache User Guide</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_DescribeEvents.html">DescribeEvents</a>
    /// in the ElastiCache API Reference
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// Also see, <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/AutoFailover.html#auto-failover-test">Testing
    /// Multi-AZ with Automatic Failover</a> in the <i>ElastiCache User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TestFailoverRequest : AmazonElastiCacheRequest
    {
        private string _nodeGroupId;
        private string _replicationGroupId;

        /// <summary>
        /// Gets and sets the property NodeGroupId. 
        /// <para>
        /// The name of the node group (called shard in the console) in this replication group
        /// on which automatic failover is to be tested. You may test automatic failover on up
        /// to 5 node groups in any rolling 24-hour period.
        /// </para>
        /// </summary>
        public string NodeGroupId
        {
            get { return this._nodeGroupId; }
            set { this._nodeGroupId = value; }
        }

        // Check to see if NodeGroupId property is set
        internal bool IsSetNodeGroupId()
        {
            return this._nodeGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The name of the replication group (console: cluster) whose automatic failover is being
        /// tested by this operation.
        /// </para>
        /// </summary>
        public string ReplicationGroupId
        {
            get { return this._replicationGroupId; }
            set { this._replicationGroupId = value; }
        }

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this._replicationGroupId != null;
        }

    }
}