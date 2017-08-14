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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateScript operation.
    /// Transforms a directed acyclic graph (DAG) into a Python script.
    /// </summary>
    public partial class CreateScriptRequest : AmazonGlueRequest
    {
        private List<CodeGenEdge> _dagEdges = new List<CodeGenEdge>();
        private List<CodeGenNode> _dagNodes = new List<CodeGenNode>();

        /// <summary>
        /// Gets and sets the property DagEdges. 
        /// <para>
        /// A list of the edges in the DAG.
        /// </para>
        /// </summary>
        public List<CodeGenEdge> DagEdges
        {
            get { return this._dagEdges; }
            set { this._dagEdges = value; }
        }

        // Check to see if DagEdges property is set
        internal bool IsSetDagEdges()
        {
            return this._dagEdges != null && this._dagEdges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DagNodes. 
        /// <para>
        /// A list of the nodes in the DAG.
        /// </para>
        /// </summary>
        public List<CodeGenNode> DagNodes
        {
            get { return this._dagNodes; }
            set { this._dagNodes = value; }
        }

        // Check to see if DagNodes property is set
        internal bool IsSetDagNodes()
        {
            return this._dagNodes != null && this._dagNodes.Count > 0; 
        }

    }
}