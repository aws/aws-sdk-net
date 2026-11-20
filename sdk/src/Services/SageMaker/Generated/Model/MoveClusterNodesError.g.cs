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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Describes why a node, identified by its instance ID, could not be moved in a <c>MoveClusterNodes</c>
    /// request. Contains the instance ID, an error code, and an error message.
    /// </summary>
    public partial class MoveClusterNodesError
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code associated with the error encountered when moving the node. The error
        /// code is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NodeIdNotFound</c>: The node does not exist in the source instance group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidNodeStatus</c>: The node is not in a state that allows the move. For example,
        /// the node is not <c>Running</c>, is not in a subnet of the target instance group, or
        /// has an attached Amazon EBS volume that you must detach first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NodeIdInUse</c>: Another operation is already in progress for this node. Wait
        /// for the operation to complete before retrying.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NodeInstanceTypeMismatch</c>: The target instance group does not support the node's
        /// instance type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public MoveClusterNodesErrorCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A human-readable message describing the error encountered when moving the node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// The instance ID of the node that could not be moved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string NodeId { get; set; }

        /// <summary>
        /// Checks to see if the NodeId property is set.
        /// </summary>
        internal bool IsSetNodeId() => this.NodeId != null;
    }
}
