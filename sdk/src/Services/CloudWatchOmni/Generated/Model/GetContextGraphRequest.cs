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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the GetContextGraph operation.
    /// Queries the context graph with filtering, traversal, and pagination support.
    /// 
    ///  
    /// <para>
    /// Pagination note: nodes and edges are returned together as a coherent subgraph. Pagination
    /// cursors advance over nodes (the primary collection); each page includes all edges
    /// connecting nodes within that page. Callers should treat nodes as the paginated collection
    /// and edges as supplementary relationship data attached to those nodes.
    /// </para>
    /// </summary>
    public partial class GetContextGraphRequest : AmazonCloudWatchOmniRequest
    {
        private int? _depth;
        private EdgeFilters _edgeFilters;
        private DateTime? _endTime;
        private bool? _includeMetadata;
        private int? _maxEdgesPerNode;
        private int? _maxResults;
        private string _nextToken;
        private NodeFilters _nodeFilters;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property Depth. 
        /// <para>
        /// How many hops to traverse out from the nodes matched by nodeFilters. 0 returns only
        /// the matched nodes themselves.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public int? Depth
        {
            get { return this._depth; }
            set { this._depth = value; }
        }

        // Check to see if Depth property is set
        internal bool IsSetDepth()
        {
            return this._depth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeFilters. 
        /// <para>
        /// Criteria restricting which edges are returned.
        /// </para>
        /// </summary>
        public EdgeFilters EdgeFilters
        {
            get { return this._edgeFilters; }
            set { this._edgeFilters = value; }
        }

        // Check to see if EdgeFilters property is set
        internal bool IsSetEdgeFilters()
        {
            return this._edgeFilters != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End of the time range (UTC), inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeMetadata. 
        /// <para>
        /// Whether to return the metadata block, semantics included, on each node and edge. Off
        /// by default because it costs an extra lookup per returned node.
        /// </para>
        /// </summary>
        public bool? IncludeMetadata
        {
            get { return this._includeMetadata; }
            set { this._includeMetadata = value; }
        }

        // Check to see if IncludeMetadata property is set
        internal bool IsSetIncludeMetadata()
        {
            return this._includeMetadata.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxEdgesPerNode. 
        /// <para>
        /// The maximum number of edges to return per node, bounding the fan-out of a densely
        /// connected node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxEdgesPerNode
        {
            get { return this._maxEdgesPerNode; }
            set { this._maxEdgesPerNode = value; }
        }

        // Check to see if MaxEdgesPerNode property is set
        internal bool IsSetMaxEdgesPerNode()
        {
            return this._maxEdgesPerNode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of nodes to return in a single page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token from a previous response, to retrieve the next page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property NodeFilters. 
        /// <para>
        /// Criteria restricting which nodes are returned.
        /// </para>
        /// </summary>
        public NodeFilters NodeFilters
        {
            get { return this._nodeFilters; }
            set { this._nodeFilters = value; }
        }

        // Check to see if NodeFilters property is set
        internal bool IsSetNodeFilters()
        {
            return this._nodeFilters != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Start of the time range (UTC), inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}