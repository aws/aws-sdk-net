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
    /// The status of the service update on the node group member
    /// </summary>
    public partial class NodeGroupMemberUpdateStatus
    {
        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The cache cluster ID
        /// </para>
        /// </summary>
        public string CacheClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterId property is set.
        /// </summary>
        internal bool IsSetCacheClusterId() => this.CacheClusterId != null;

        /// <summary>
        /// Gets and sets the property CacheNodeId. 
        /// <para>
        /// The node ID of the cache cluster
        /// </para>
        /// </summary>
        public string CacheNodeId { get; set; }

        /// <summary>
        /// Checks to see if the CacheNodeId property is set.
        /// </summary>
        internal bool IsSetCacheNodeId() => this.CacheNodeId != null;

        /// <summary>
        /// Gets and sets the property NodeDeletionDate. 
        /// <para>
        /// The deletion date of the node
        /// </para>
        /// </summary>
        public DateTime? NodeDeletionDate { get; set; }

        /// <summary>
        /// Checks to see if the NodeDeletionDate property is set.
        /// </summary>
        internal bool IsSetNodeDeletionDate() => this.NodeDeletionDate.HasValue;

        /// <summary>
        /// Gets and sets the property NodeUpdateEndDate. 
        /// <para>
        /// The end date of the update for a node
        /// </para>
        /// </summary>
        public DateTime? NodeUpdateEndDate { get; set; }

        /// <summary>
        /// Checks to see if the NodeUpdateEndDate property is set.
        /// </summary>
        internal bool IsSetNodeUpdateEndDate() => this.NodeUpdateEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property NodeUpdateInitiatedBy. 
        /// <para>
        /// Reflects whether the update was initiated by the customer or automatically applied
        /// </para>
        /// </summary>
        public NodeUpdateInitiatedBy NodeUpdateInitiatedBy { get; set; }

        /// <summary>
        /// Checks to see if the NodeUpdateInitiatedBy property is set.
        /// </summary>
        internal bool IsSetNodeUpdateInitiatedBy() => this.NodeUpdateInitiatedBy != null;

        /// <summary>
        /// Gets and sets the property NodeUpdateInitiatedDate. 
        /// <para>
        /// The date when the update is triggered
        /// </para>
        /// </summary>
        public DateTime? NodeUpdateInitiatedDate { get; set; }

        /// <summary>
        /// Checks to see if the NodeUpdateInitiatedDate property is set.
        /// </summary>
        internal bool IsSetNodeUpdateInitiatedDate() => this.NodeUpdateInitiatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property NodeUpdateStartDate. 
        /// <para>
        /// The start date of the update for a node
        /// </para>
        /// </summary>
        public DateTime? NodeUpdateStartDate { get; set; }

        /// <summary>
        /// Checks to see if the NodeUpdateStartDate property is set.
        /// </summary>
        internal bool IsSetNodeUpdateStartDate() => this.NodeUpdateStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property NodeUpdateStatus. 
        /// <para>
        /// The update status of the node
        /// </para>
        /// </summary>
        public NodeUpdateStatus NodeUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the NodeUpdateStatus property is set.
        /// </summary>
        internal bool IsSetNodeUpdateStatus() => this.NodeUpdateStatus != null;

        /// <summary>
        /// Gets and sets the property NodeUpdateStatusModifiedDate. 
        /// <para>
        /// The date when the NodeUpdateStatus was last modified
        /// </para>
        /// </summary>
        public DateTime? NodeUpdateStatusModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the NodeUpdateStatusModifiedDate property is set.
        /// </summary>
        internal bool IsSetNodeUpdateStatusModifiedDate() => this.NodeUpdateStatusModifiedDate.HasValue;
    }
}
