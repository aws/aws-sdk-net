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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the GetContextGraph operation. Queries the context
    /// graph with filtering, traversal, and pagination support. Pagination note: nodes and
    /// edges are returned together as a coherent subgraph. Pagination cursors advance over
    /// nodes (the primary collection); each page includes all edges connecting nodes within
    /// that page. Callers should treat nodes as the paginated collection and edges as supplementary
    /// relationship data attached to those nodes.
    /// </summary>
    public partial class GetContextGraphRequest : AmazonCloudWatchOmniRequest
    {
        /// <summary>
        /// Gets and sets the property Depth. How many hops to traverse out from the nodes matched
        /// by nodeFilters. 0 returns only the matched nodes themselves.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public int? Depth { get; set; }

        /// <summary>
        /// Checks to see if the Depth property is set.
        /// </summary>
        internal bool IsSetDepth() => this.Depth.HasValue;

        /// <summary>
        /// Gets and sets the property EdgeFilters. Criteria restricting which edges are returned.
        /// </summary>
        public EdgeFilters EdgeFilters { get; set; }

        /// <summary>
        /// Checks to see if the EdgeFilters property is set.
        /// </summary>
        internal bool IsSetEdgeFilters() => this.EdgeFilters != null;

        /// <summary>
        /// Gets and sets the property EndTime. End of the time range (UTC), inclusive.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeMetadata. Whether to return the metadata block,
        /// semantics included, on each node and edge. Off by default because it costs an extra
        /// lookup per returned node.
        /// </summary>
        public bool? IncludeMetadata { get; set; }

        /// <summary>
        /// Checks to see if the IncludeMetadata property is set.
        /// </summary>
        internal bool IsSetIncludeMetadata() => this.IncludeMetadata.HasValue;

        /// <summary>
        /// Gets and sets the property MaxEdgesPerNode. The maximum number of edges to return
        /// per node, bounding the fan-out of a densely connected node.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxEdgesPerNode { get; set; }

        /// <summary>
        /// Checks to see if the MaxEdgesPerNode property is set.
        /// </summary>
        internal bool IsSetMaxEdgesPerNode() => this.MaxEdgesPerNode.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. The maximum number of nodes to return in a
        /// single page.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. Pagination token from a previous response, to
        /// retrieve the next page.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property NodeFilters. Criteria restricting which nodes are returned.
        /// </summary>
        public NodeFilters NodeFilters { get; set; }

        /// <summary>
        /// Checks to see if the NodeFilters property is set.
        /// </summary>
        internal bool IsSetNodeFilters() => this.NodeFilters != null;

        /// <summary>
        /// Gets and sets the property StartTime. Start of the time range (UTC), inclusive.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
