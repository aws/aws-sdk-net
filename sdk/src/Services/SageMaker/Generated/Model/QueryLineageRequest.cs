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
    /// Container for the parameters to the QueryLineage operation.
    /// Use this action to inspect your lineage and discover relationships between entities.
    /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/querying-lineage-entities.html">
    /// Querying Lineage Entities</a> in the <i>Amazon SageMaker Developer Guide</i>.
    /// </summary>
    public partial class QueryLineageRequest : AmazonSageMakerRequest
    {
        private Direction _direction;
        private QueryFilters _filters;
        private bool? _includeEdges;
        private int? _maxDepth;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _startArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// Associations between lineage entities have a direction. This parameter determines
        /// the direction from the StartArn(s) that the query traverses.
        /// </para>
        /// </summary>
        public Direction Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A set of filtering parameters that allow you to specify which entities should be returned.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Properties - Key-value pairs to match on the lineage entities' properties.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LineageTypes - A set of lineage entity types to match on. For example: <c>TrialComponent</c>,
        /// <c>Artifact</c>, or <c>Context</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CreatedBefore - Filter entities created before this date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ModifiedBefore - Filter entities modified before this date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ModifiedAfter - Filter entities modified after this date.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public QueryFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeEdges. 
        /// <para>
        ///  Setting this value to <c>True</c> retrieves not only the entities of interest but
        /// also the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking-entities.html">Associations</a>
        /// and lineage entities on the path. Set to <c>False</c> to only return lineage entities
        /// that match your query.
        /// </para>
        /// </summary>
        public bool? IncludeEdges
        {
            get { return this._includeEdges; }
            set { this._includeEdges = value; }
        }

        // Check to see if IncludeEdges property is set
        internal bool IsSetIncludeEdges()
        {
            return this._includeEdges.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDepth. 
        /// <para>
        /// The maximum depth in lineage relationships from the <c>StartArns</c> that are traversed.
        /// Depth is a measure of the number of <c>Associations</c> from the <c>StartArn</c> entity
        /// to the matched results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public int? MaxDepth
        {
            get { return this._maxDepth; }
            set { this._maxDepth = value; }
        }

        // Check to see if MaxDepth property is set
        internal bool IsSetMaxDepth()
        {
            return this._maxDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Limits the number of vertices in the results. Use the <c>NextToken</c> in a response
        /// to to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
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
        /// Limits the number of vertices in the request. Use the <c>NextToken</c> in a response
        /// to to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// Gets and sets the property StartArns. 
        /// <para>
        /// A list of resource Amazon Resource Name (ARN) that represent the starting point for
        /// your lineage query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> StartArns
        {
            get { return this._startArns; }
            set { this._startArns = value; }
        }

        // Check to see if StartArns property is set
        internal bool IsSetStartArns()
        {
            return this._startArns != null && (this._startArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}