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
    /// Container for the parameters to the DeleteGlobalReplicationGroup operation.
    /// Deleting a Global Datastore is a two-step process: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// First, you must <a>DisassociateGlobalReplicationGroup</a> to remove the secondary
    /// clusters in the Global Datastore.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Once the Global Datastore contains only the primary cluster, you can use DeleteGlobalReplicationGroup
    /// API to delete the Global Datastore while retainining the primary cluster using Retain…=
    /// true.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Since the Global Datastore has only a primary cluster, you can delete the Global Datastore
    /// while retaining the primary by setting <code>RetainPrimaryCluster=true</code>.
    /// </para>
    ///  
    /// <para>
    /// When you receive a successful response from this operation, Amazon ElastiCache immediately
    /// begins deleting the selected resources; you cannot cancel or revert this operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is valid for Redis only.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private string _globalReplicationGroupId;
        private bool? _retainPrimaryReplicationGroup;

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupId. 
        /// <para>
        /// The name of the Global Datastore
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
        /// If set to <code>true</code>, the primary replication is retained as a standalone replication
        /// group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool RetainPrimaryReplicationGroup
        {
            get { return this._retainPrimaryReplicationGroup.GetValueOrDefault(); }
            set { this._retainPrimaryReplicationGroup = value; }
        }

        // Check to see if RetainPrimaryReplicationGroup property is set
        internal bool IsSetRetainPrimaryReplicationGroup()
        {
            return this._retainPrimaryReplicationGroup.HasValue; 
        }

    }
}