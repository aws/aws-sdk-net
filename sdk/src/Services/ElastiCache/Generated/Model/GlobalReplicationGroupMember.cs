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
    /// A member of a Global datastore. It contains the Replication Group Id, the Amazon region
    /// and the role of the replication group.
    /// </summary>
    public partial class GlobalReplicationGroupMember
    {
        private AutomaticFailoverStatus _automaticFailover;
        private string _replicationGroupId;
        private string _replicationGroupRegion;
        private string _role;
        private string _status;

        /// <summary>
        /// Gets and sets the property AutomaticFailover. 
        /// <para>
        /// Indicates whether automatic failover is enabled for the replication group.
        /// </para>
        /// </summary>
        public AutomaticFailoverStatus AutomaticFailover
        {
            get { return this._automaticFailover; }
            set { this._automaticFailover = value; }
        }

        // Check to see if AutomaticFailover property is set
        internal bool IsSetAutomaticFailover()
        {
            return this._automaticFailover != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The replication group id of the Global datastore member.
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

        /// <summary>
        /// Gets and sets the property ReplicationGroupRegion. 
        /// <para>
        /// The Amazon region of the Global datastore member.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Role. 
        /// <para>
        /// Indicates the role of the replication group, primary or secondary.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the membership of the replication group.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}