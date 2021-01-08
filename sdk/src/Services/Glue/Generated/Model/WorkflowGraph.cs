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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A workflow graph represents the complete workflow containing all the AWS Glue components
    /// present in the workflow and all the directed connections between them.
    /// </summary>
    public partial class WorkflowGraph
    {
        private List<Edge> _edges = new List<Edge>();
        private List<Node> _nodes = new List<Node>();

        /// <summary>
        /// Gets and sets the property Edges. 
        /// <para>
        /// A list of all the directed connections between the nodes belonging to the workflow.
        /// </para>
        /// </summary>
        public List<Edge> Edges
        {
            get { return this._edges; }
            set { this._edges = value; }
        }

        // Check to see if Edges property is set
        internal bool IsSetEdges()
        {
            return this._edges != null && this._edges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Nodes. 
        /// <para>
        /// A list of the the AWS Glue components belong to the workflow represented as nodes.
        /// </para>
        /// </summary>
        public List<Node> Nodes
        {
            get { return this._nodes; }
            set { this._nodes = value; }
        }

        // Check to see if Nodes property is set
        internal bool IsSetNodes()
        {
            return this._nodes != null && this._nodes.Count > 0; 
        }

    }
}