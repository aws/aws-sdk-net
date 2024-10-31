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
    /// Represents an error encountered when deleting a node from a SageMaker HyperPod cluster.
    /// </summary>
    public partial class BatchDeleteClusterNodesError
    {
        private BatchDeleteClusterNodesErrorCode _code;
        private string _message;
        private string _nodeId;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code associated with the error encountered when deleting a node.
        /// </para>
        ///  
        /// <para>
        /// The code provides information about the specific issue encountered, such as the node
        /// not being found, the node's status being invalid for deletion, or the node ID being
        /// in use by another process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchDeleteClusterNodesErrorCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message describing the error encountered when deleting a node.
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
        /// The ID of the node that encountered an error during the deletion process.
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