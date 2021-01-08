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
    /// The status of the service update on the node group
    /// </summary>
    public partial class NodeGroupUpdateStatus
    {
        private string _nodeGroupId;
        private List<NodeGroupMemberUpdateStatus> _nodeGroupMemberUpdateStatus = new List<NodeGroupMemberUpdateStatus>();

        /// <summary>
        /// Gets and sets the property NodeGroupId. 
        /// <para>
        /// The ID of the node group
        /// </para>
        /// </summary>
        public string NodeGroupId
        {
            get { return this._nodeGroupId; }
            set { this._nodeGroupId = value; }
        }

        // Check to see if NodeGroupId property is set
        internal bool IsSetNodeGroupId()
        {
            return this._nodeGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property NodeGroupMemberUpdateStatus. 
        /// <para>
        /// The status of the service update on the node group member
        /// </para>
        /// </summary>
        public List<NodeGroupMemberUpdateStatus> NodeGroupMemberUpdateStatus
        {
            get { return this._nodeGroupMemberUpdateStatus; }
            set { this._nodeGroupMemberUpdateStatus = value; }
        }

        // Check to see if NodeGroupMemberUpdateStatus property is set
        internal bool IsSetNodeGroupMemberUpdateStatus()
        {
            return this._nodeGroupMemberUpdateStatus != null && this._nodeGroupMemberUpdateStatus.Count > 0; 
        }

    }
}