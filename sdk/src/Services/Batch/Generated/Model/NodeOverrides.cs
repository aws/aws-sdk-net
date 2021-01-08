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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Object representing any node overrides to a job definition that's used in a <a>SubmitJob</a>
    /// API operation.
    /// 
    ///  <note> 
    /// <para>
    /// This isn't applicable to jobs running on Fargate resources and shouldn't be provided;
    /// use <code>containerOverrides</code> instead.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class NodeOverrides
    {
        private List<NodePropertyOverride> _nodePropertyOverrides = new List<NodePropertyOverride>();
        private int? _numNodes;

        /// <summary>
        /// Gets and sets the property NodePropertyOverrides. 
        /// <para>
        /// The node property overrides for the job.
        /// </para>
        /// </summary>
        public List<NodePropertyOverride> NodePropertyOverrides
        {
            get { return this._nodePropertyOverrides; }
            set { this._nodePropertyOverrides = value; }
        }

        // Check to see if NodePropertyOverrides property is set
        internal bool IsSetNodePropertyOverrides()
        {
            return this._nodePropertyOverrides != null && this._nodePropertyOverrides.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NumNodes. 
        /// <para>
        /// The number of nodes to use with a multi-node parallel job. This value overrides the
        /// number of nodes that are specified in the job definition. To use this override:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There must be at least one node range in your job definition that has an open upper
        /// boundary (such as <code>:</code> or <code>n:</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The lower boundary of the node range specified in the job definition must be fewer
        /// than the number of nodes specified in the override.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The main node index specified in the job definition must be fewer than the number
        /// of nodes specified in the override.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int NumNodes
        {
            get { return this._numNodes.GetValueOrDefault(); }
            set { this._numNodes = value; }
        }

        // Check to see if NumNodes property is set
        internal bool IsSetNumNodes()
        {
            return this._numNodes.HasValue; 
        }

    }
}