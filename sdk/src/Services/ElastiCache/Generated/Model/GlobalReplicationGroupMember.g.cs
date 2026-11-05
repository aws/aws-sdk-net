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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AutomaticFailover. 
        /// <para>
        /// Indicates whether automatic failover is enabled for the replication group.
        /// </para>
        /// </summary>
        public AutomaticFailoverStatus AutomaticFailover { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticFailover property is set.
        /// </summary>
        internal bool IsSetAutomaticFailover() => this.AutomaticFailover != null;

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The replication group id of the Global datastore member.
        /// </para>
        /// </summary>
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;

        /// <summary>
        /// Gets and sets the property ReplicationGroupRegion. 
        /// <para>
        /// The Amazon region of the Global datastore member.
        /// </para>
        /// </summary>
        public string ReplicationGroupRegion { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupRegion property is set.
        /// </summary>
        internal bool IsSetReplicationGroupRegion() => this.ReplicationGroupRegion != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// Indicates the role of the replication group, primary or secondary.
        /// </para>
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the membership of the replication group.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
