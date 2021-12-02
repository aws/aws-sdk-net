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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the QueryLineage operation.
    /// </summary>
    public partial class QueryLineageResponse : AmazonWebServiceResponse
    {
        private List<Edge> _edges = new List<Edge>();
        private string _nextToken;
        private List<Vertex> _vertices = new List<Vertex>();

        /// <summary>
        /// Gets and sets the property Edges. 
        /// <para>
        /// A list of edges that connect vertices in the response.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Limits the number of vertices in the response. Use the <code>NextToken</code> in a
        /// response to to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Vertices. 
        /// <para>
        /// A list of vertices connected to the start entity(ies) in the lineage graph.
        /// </para>
        /// </summary>
        public List<Vertex> Vertices
        {
            get { return this._vertices; }
            set { this._vertices = value; }
        }

        // Check to see if Vertices property is set
        internal bool IsSetVertices()
        {
            return this._vertices != null && this._vertices.Count > 0; 
        }

    }
}