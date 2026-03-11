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
    /// Information about an error that occurred when attempting to delete a node identified
    /// by its <c>NodeLogicalId</c>.
    /// </summary>
    public partial class BatchDeleteClusterNodeLogicalIdsError
    {
        private BatchDeleteClusterNodesErrorCode _code;
        private string _message;
        private string _nodeLogicalId;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code associated with the failure. Possible values include <c>NodeLogicalIdNotFound</c>,
        /// <c>InvalidNodeStatus</c>, and <c>InternalError</c>.
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
        /// A descriptive message providing additional details about the error.
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
        /// Gets and sets the property NodeLogicalId. 
        /// <para>
        /// The <c>NodeLogicalId</c> of the node that could not be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string NodeLogicalId
        {
            get { return this._nodeLogicalId; }
            set { this._nodeLogicalId = value; }
        }

        // Check to see if NodeLogicalId property is set
        internal bool IsSetNodeLogicalId()
        {
            return this._nodeLogicalId != null;
        }

    }
}