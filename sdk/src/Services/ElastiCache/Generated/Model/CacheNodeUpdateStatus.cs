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
    /// The status of the service update on the cache node
    /// </summary>
    public partial class CacheNodeUpdateStatus
    {
        private string _cacheNodeId;
        private DateTime? _nodeDeletionDate;
        private DateTime? _nodeUpdateEndDate;
        private NodeUpdateInitiatedBy _nodeUpdateInitiatedBy;
        private DateTime? _nodeUpdateInitiatedDate;
        private DateTime? _nodeUpdateStartDate;
        private NodeUpdateStatus _nodeUpdateStatus;
        private DateTime? _nodeUpdateStatusModifiedDate;

        /// <summary>
        /// Gets and sets the property CacheNodeId. 
        /// <para>
        /// The node ID of the cache cluster
        /// </para>
        /// </summary>
        public string CacheNodeId
        {
            get { return this._cacheNodeId; }
            set { this._cacheNodeId = value; }
        }

        // Check to see if CacheNodeId property is set
        internal bool IsSetCacheNodeId()
        {
            return this._cacheNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property NodeDeletionDate. 
        /// <para>
        /// The deletion date of the node
        /// </para>
        /// </summary>
        public DateTime? NodeDeletionDate
        {
            get { return this._nodeDeletionDate; }
            set { this._nodeDeletionDate = value; }
        }

        // Check to see if NodeDeletionDate property is set
        internal bool IsSetNodeDeletionDate()
        {
            return this._nodeDeletionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeUpdateEndDate. 
        /// <para>
        /// The end date of the update for a node
        /// </para>
        /// </summary>
        public DateTime? NodeUpdateEndDate
        {
            get { return this._nodeUpdateEndDate; }
            set { this._nodeUpdateEndDate = value; }
        }

        // Check to see if NodeUpdateEndDate property is set
        internal bool IsSetNodeUpdateEndDate()
        {
            return this._nodeUpdateEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeUpdateInitiatedBy. 
        /// <para>
        /// Reflects whether the update was initiated by the customer or automatically applied
        /// </para>
        /// </summary>
        public NodeUpdateInitiatedBy NodeUpdateInitiatedBy
        {
            get { return this._nodeUpdateInitiatedBy; }
            set { this._nodeUpdateInitiatedBy = value; }
        }

        // Check to see if NodeUpdateInitiatedBy property is set
        internal bool IsSetNodeUpdateInitiatedBy()
        {
            return this._nodeUpdateInitiatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property NodeUpdateInitiatedDate. 
        /// <para>
        /// The date when the update is triggered
        /// </para>
        /// </summary>
        public DateTime? NodeUpdateInitiatedDate
        {
            get { return this._nodeUpdateInitiatedDate; }
            set { this._nodeUpdateInitiatedDate = value; }
        }

        // Check to see if NodeUpdateInitiatedDate property is set
        internal bool IsSetNodeUpdateInitiatedDate()
        {
            return this._nodeUpdateInitiatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeUpdateStartDate. 
        /// <para>
        /// The start date of the update for a node
        /// </para>
        /// </summary>
        public DateTime? NodeUpdateStartDate
        {
            get { return this._nodeUpdateStartDate; }
            set { this._nodeUpdateStartDate = value; }
        }

        // Check to see if NodeUpdateStartDate property is set
        internal bool IsSetNodeUpdateStartDate()
        {
            return this._nodeUpdateStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeUpdateStatus. 
        /// <para>
        /// The update status of the node
        /// </para>
        /// </summary>
        public NodeUpdateStatus NodeUpdateStatus
        {
            get { return this._nodeUpdateStatus; }
            set { this._nodeUpdateStatus = value; }
        }

        // Check to see if NodeUpdateStatus property is set
        internal bool IsSetNodeUpdateStatus()
        {
            return this._nodeUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NodeUpdateStatusModifiedDate. 
        /// <para>
        /// The date when the NodeUpdateStatus was last modified&gt;
        /// </para>
        /// </summary>
        public DateTime? NodeUpdateStatusModifiedDate
        {
            get { return this._nodeUpdateStatusModifiedDate; }
            set { this._nodeUpdateStatusModifiedDate = value; }
        }

        // Check to see if NodeUpdateStatusModifiedDate property is set
        internal bool IsSetNodeUpdateStatusModifiedDate()
        {
            return this._nodeUpdateStatusModifiedDate.HasValue; 
        }

    }
}