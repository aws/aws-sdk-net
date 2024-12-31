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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the TestFailover operation.
    /// Represents the input of a <c>TestFailover</c> operation which tests automatic failover
    /// on a specified node group (called shard in the console) in a replication group (called
    /// cluster in the console).
    /// 
    ///  
    /// <para>
    /// This API is designed for testing the behavior of your application in case of ElastiCache
    /// failover. It is not designed to be an operational tool for initiating a failover to
    /// overcome a problem you may have with the cluster. Moreover, in certain conditions
    /// such as large-scale operational events, Amazon may block this API. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Note the following</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A customer can use this operation to test automatic failover on up to 15 shards (called
    /// node groups in the ElastiCache API and Amazon CLI) in any rolling 24-hour period.
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
    /// If calling this operation multiple times on different shards in the same Valkey or
    /// Redis OSS (cluster mode enabled) replication group, the first node replacement must
    /// complete before a subsequent call can be made.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To determine whether the node replacement is complete you can check Events using the
    /// Amazon ElastiCache console, the Amazon CLI, or the ElastiCache API. Look for the following
    /// automatic failover related events, listed here in order of occurrance:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Replication group message: <c>Test Failover API called for node group &lt;node-group-id&gt;</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cache cluster message: <c>Failover from primary node &lt;primary-node-id&gt; to replica
    /// node &lt;node-id&gt; completed</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Replication group message: <c>Failover from primary node &lt;primary-node-id&gt; to
    /// replica node &lt;node-id&gt; completed</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cache cluster message: <c>Recovering cache nodes &lt;node-id&gt;</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cache cluster message: <c>Finished recovery for cache nodes &lt;node-id&gt;</c> 
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information see:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/ECEvents.Viewing.html">Viewing
    /// ElastiCache Events</a> in the <i>ElastiCache User Guide</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_DescribeEvents.html">DescribeEvents</a>
    /// in the ElastiCache API Reference
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// Also see, <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/AutoFailover.html#auto-failover-test">Testing
    /// Multi-AZ </a> in the <i>ElastiCache User Guide</i>.
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
        /// to 15 node groups in any rolling 24-hour period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
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
        [AWSProperty(Required=true)]
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