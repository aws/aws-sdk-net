/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object representing the node properties of a multi-node parallel job.
    /// </summary>
    public partial class NodeProperties
    {
        private int? _mainNode;
        private List<NodeRangeProperty> _nodeRangeProperties = new List<NodeRangeProperty>();
        private int? _numNodes;

        /// <summary>
        /// Gets and sets the property MainNode. 
        /// <para>
        /// Specifies the node index for the main node of a multi-node parallel job.
        /// </para>
        /// </summary>
        public int MainNode
        {
            get { return this._mainNode.GetValueOrDefault(); }
            set { this._mainNode = value; }
        }

        // Check to see if MainNode property is set
        internal bool IsSetMainNode()
        {
            return this._mainNode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeRangeProperties. 
        /// <para>
        /// A list of node ranges and their properties associated with a multi-node parallel job.
        /// </para>
        /// </summary>
        public List<NodeRangeProperty> NodeRangeProperties
        {
            get { return this._nodeRangeProperties; }
            set { this._nodeRangeProperties = value; }
        }

        // Check to see if NodeRangeProperties property is set
        internal bool IsSetNodeRangeProperties()
        {
            return this._nodeRangeProperties != null && this._nodeRangeProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NumNodes. 
        /// <para>
        /// The number of nodes associated with a multi-node parallel job.
        /// </para>
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