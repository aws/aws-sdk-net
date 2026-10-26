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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNodeState operation. Update the state of
    /// a node.
    /// </summary>
    public partial class UpdateNodeStateRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterId. The ID of the cluster
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property NodeId. The ID of the node.
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodeId { get; set; }

        /// <summary>
        /// Checks to see if the NodeId property is set.
        /// </summary>
        internal bool IsSetNodeId() => this.NodeId != null;

        /// <summary>
        /// Gets and sets the property State. The state to apply to the Node. Set to ACTIVE (COMMISSIONED)
        /// to indicate that the Node is deployable. MediaLive Anywhere will consider this node
        /// it needs a Node to run a Channel on, or when it needs a Node to promote from a backup
        /// node to an active node. Set to DRAINING to isolate the Node so that MediaLive Anywhere
        /// won't use it.
        /// </summary>
        public UpdateNodeState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
