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
    /// Container for the parameters to the DisassociateGlobalReplicationGroup operation.
    /// Remove a secondary cluster from the Global datastore using the Global datastore name.
    /// The secondary cluster will no longer receive updates from the primary cluster, but
    /// will remain as a standalone cluster in that Amazon region.
    /// </summary>
    public partial class DisassociateGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private string _globalReplicationGroupId;
        private string _replicationGroupId;
        private string _replicationGroupRegion;

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupId. 
        /// <para>
        /// The name of the Global datastore
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GlobalReplicationGroupId
        {
            get { return this._globalReplicationGroupId; }
            set { this._globalReplicationGroupId = value; }
        }

        // Check to see if GlobalReplicationGroupId property is set
        internal bool IsSetGlobalReplicationGroupId()
        {
            return this._globalReplicationGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The name of the secondary cluster you wish to remove from the Global datastore
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

        /// <summary>
        /// Gets and sets the property ReplicationGroupRegion. 
        /// <para>
        /// The Amazon region of secondary cluster you wish to remove from the Global datastore
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationGroupRegion
        {
            get { return this._replicationGroupRegion; }
            set { this._replicationGroupRegion = value; }
        }

        // Check to see if ReplicationGroupRegion property is set
        internal bool IsSetReplicationGroupRegion()
        {
            return this._replicationGroupRegion != null;
        }

    }
}