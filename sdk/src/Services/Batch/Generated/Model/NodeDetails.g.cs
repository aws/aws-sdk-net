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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the details of a multi-node parallel job node.
    /// </summary>
    public partial class NodeDetails
    {
        /// <summary>
        /// Gets and sets the property IsMainNode. 
        /// <para>
        /// Specifies whether the current node is the main node for a multi-node parallel job.
        /// </para>
        /// </summary>
        public bool? IsMainNode { get; set; }

        /// <summary>
        /// Checks to see if the IsMainNode property is set.
        /// </summary>
        internal bool IsSetIsMainNode() => this.IsMainNode.HasValue;

        /// <summary>
        /// Gets and sets the property NodeIndex. 
        /// <para>
        /// The node index for the node. Node index numbering starts at zero. This index is also
        /// available on the node with the <c>AWS_BATCH_JOB_NODE_INDEX</c> environment variable.
        /// </para>
        /// </summary>
        public int? NodeIndex { get; set; }

        /// <summary>
        /// Checks to see if the NodeIndex property is set.
        /// </summary>
        internal bool IsSetNodeIndex() => this.NodeIndex.HasValue;
    }
}
