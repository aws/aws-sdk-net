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
    /// Container for the parameters to the DeleteGlobalReplicationGroup operation.
    /// Deleting a Global datastore is a two-step process: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// First, you must <a>DisassociateGlobalReplicationGroup</a> to remove the secondary
    /// clusters in the Global datastore.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Once the Global datastore contains only the primary cluster, you can use the <c>DeleteGlobalReplicationGroup</c>
    /// API to delete the Global datastore while retainining the primary cluster using <c>RetainPrimaryReplicationGroup=true</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Since the Global Datastore has only a primary cluster, you can delete the Global Datastore
    /// while retaining the primary by setting <c>RetainPrimaryReplicationGroup=true</c>.
    /// The primary cluster is never deleted when deleting a Global Datastore. It can only
    /// be deleted when it no longer is associated with any Global Datastore.
    /// </para>
    ///  
    /// <para>
    /// When you receive a successful response from this operation, Amazon ElastiCache immediately
    /// begins deleting the selected resources; you cannot cancel or revert this operation.
    /// </para>
    /// </summary>
    public partial class DeleteGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private string _globalReplicationGroupId;
        private bool? _retainPrimaryReplicationGroup;

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
        /// Gets and sets the property RetainPrimaryReplicationGroup. 
        /// <para>
        /// The primary replication group is retained as a standalone replication group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? RetainPrimaryReplicationGroup
        {
            get { return this._retainPrimaryReplicationGroup; }
            set { this._retainPrimaryReplicationGroup = value; }
        }

        // Check to see if RetainPrimaryReplicationGroup property is set
        internal bool IsSetRetainPrimaryReplicationGroup()
        {
            return this._retainPrimaryReplicationGroup.HasValue; 
        }

    }
}