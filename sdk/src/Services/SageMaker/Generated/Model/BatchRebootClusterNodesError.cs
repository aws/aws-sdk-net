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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// Represents an error encountered when rebooting a node from a SageMaker HyperPod cluster.
    /// </summary>
    public partial class BatchRebootClusterNodesError
    {
        private BatchRebootClusterNodesErrorCode _errorCode;
        private string _message;
        private string _nodeId;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code associated with the error encountered when rebooting a node.
        /// </para>
        ///  
        /// <para>
        /// Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InstanceIdNotFound</c>: The instance does not exist in the specified cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidInstanceStatus</c>: The instance is in a state that does not allow rebooting.
        /// Wait for the instance to finish any ongoing changes before retrying.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstanceIdInUse</c>: Another operation is already in progress for this node. Wait
        /// for the operation to complete before retrying.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InternalServerError</c>: An internal error occurred while processing this node.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchRebootClusterNodesErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A human-readable message describing the error encountered when rebooting a node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// The EC2 instance ID of the node that encountered an error during the reboot operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

    }
}