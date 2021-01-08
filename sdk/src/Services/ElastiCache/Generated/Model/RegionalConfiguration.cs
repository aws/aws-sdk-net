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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// A list of the replication groups
    /// </summary>
    public partial class RegionalConfiguration
    {
        private string _replicationGroupId;
        private string _replicationGroupRegion;
        private List<ReshardingConfiguration> _reshardingConfiguration = new List<ReshardingConfiguration>();

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The name of the secondary cluster
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
        /// The AWS region where the cluster is stored
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

        /// <summary>
        /// Gets and sets the property ReshardingConfiguration. 
        /// <para>
        /// A list of <code>PreferredAvailabilityZones</code> objects that specifies the configuration
        /// of a node group in the resharded cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ReshardingConfiguration> ReshardingConfiguration
        {
            get { return this._reshardingConfiguration; }
            set { this._reshardingConfiguration = value; }
        }

        // Check to see if ReshardingConfiguration property is set
        internal bool IsSetReshardingConfiguration()
        {
            return this._reshardingConfiguration != null && this._reshardingConfiguration.Count > 0; 
        }

    }
}