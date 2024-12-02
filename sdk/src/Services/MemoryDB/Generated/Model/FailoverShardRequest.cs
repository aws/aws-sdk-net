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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the FailoverShard operation.
    /// Used to failover a shard. This API is designed for testing the behavior of your application
    /// in case of MemoryDB failover. It is not designed to be used as a production-level
    /// tool for initiating a failover to overcome a problem you may have with the cluster.
    /// Moreover, in certain conditions such as large scale operational events, Amazon may
    /// block this API.
    /// </summary>
    public partial class FailoverShardRequest : AmazonMemoryDBRequest
    {
        private string _clusterName;
        private string _shardName;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The cluster being failed over.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property ShardName. 
        /// <para>
        /// The name of the shard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ShardName
        {
            get { return this._shardName; }
            set { this._shardName = value; }
        }

        // Check to see if ShardName property is set
        internal bool IsSetShardName()
        {
            return this._shardName != null;
        }

    }
}