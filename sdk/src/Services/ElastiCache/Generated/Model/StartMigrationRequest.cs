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
    /// Container for the parameters to the StartMigration operation.
    /// Start the migration of data.
    /// </summary>
    public partial class StartMigrationRequest : AmazonElastiCacheRequest
    {
        private List<CustomerNodeEndpoint> _customerNodeEndpointList = new List<CustomerNodeEndpoint>();
        private string _replicationGroupId;

        /// <summary>
        /// Gets and sets the property CustomerNodeEndpointList. 
        /// <para>
        /// List of endpoints from which data should be migrated. For Redis (cluster mode disabled),
        /// list should have only one element.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<CustomerNodeEndpoint> CustomerNodeEndpointList
        {
            get { return this._customerNodeEndpointList; }
            set { this._customerNodeEndpointList = value; }
        }

        // Check to see if CustomerNodeEndpointList property is set
        internal bool IsSetCustomerNodeEndpointList()
        {
            return this._customerNodeEndpointList != null && this._customerNodeEndpointList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The ID of the replication group to which data should be migrated.
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