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
    /// Container for the parameters to the FailoverGlobalReplicationGroup operation.
    /// Used to failover the primary region to a secondary region. The secondary region will
    /// become primary, and all other clusters will become secondary.
    /// </summary>
    public partial class FailoverGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private string _globalReplicationGroupId;
        private string _primaryRegion;
        private string _primaryReplicationGroupId;

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
        /// Gets and sets the property PrimaryRegion. 
        /// <para>
        /// The Amazon region of the primary cluster of the Global datastore
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrimaryRegion
        {
            get { return this._primaryRegion; }
            set { this._primaryRegion = value; }
        }

        // Check to see if PrimaryRegion property is set
        internal bool IsSetPrimaryRegion()
        {
            return this._primaryRegion != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryReplicationGroupId. 
        /// <para>
        /// The name of the primary replication group
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrimaryReplicationGroupId
        {
            get { return this._primaryReplicationGroupId; }
            set { this._primaryReplicationGroupId = value; }
        }

        // Check to see if PrimaryReplicationGroupId property is set
        internal bool IsSetPrimaryReplicationGroupId()
        {
            return this._primaryReplicationGroupId != null;
        }

    }
}