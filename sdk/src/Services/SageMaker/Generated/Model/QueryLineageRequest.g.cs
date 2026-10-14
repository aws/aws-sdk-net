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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the QueryLineage operation. Use this action to inspect
    /// your lineage and discover relationships between entities. For more information, see
    /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/querying-lineage-entities.html">
    /// Querying Lineage Entities</a> in the <i>Amazon SageMaker Developer Guide</i>.
    /// </summary>
    public partial class QueryLineageRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// Associations between lineage entities have a direction. This parameter determines
        /// the direction from the StartArn(s) that the query traverses.
        /// </para>
        /// </summary>
        public Direction Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

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
        public QueryFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property IncludeEdges. 
        /// <para>
        ///  Setting this value to <c>True</c> retrieves not only the entities of interest but
        /// also the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking-entities.html">Associations</a>
        /// and lineage entities on the path. Set to <c>False</c> to only return lineage entities
        /// that match your query.
        /// </para>
        /// </summary>
        public bool? IncludeEdges { get; set; }

        /// <summary>
        /// Checks to see if the IncludeEdges property is set.
        /// </summary>
        internal bool IsSetIncludeEdges() => this.IncludeEdges.HasValue;

        /// <summary>
        /// Gets and sets the property MaxDepth. 
        /// <para>
        /// The maximum depth in lineage relationships from the <c>StartArns</c> that are traversed.
        /// Depth is a measure of the number of <c>Associations</c> from the <c>StartArn</c> entity
        /// to the matched results.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 10)]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// Checks to see if the MaxDepth property is set.
        /// </summary>
        internal bool IsSetMaxDepth() => this.MaxDepth.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Limits the number of vertices in the results. Use the <c>NextToken</c> in a response
        /// to to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Limits the number of vertices in the request. Use the <c>NextToken</c> in a response
        /// to to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartArns. 
        /// <para>
        /// A list of resource Amazon Resource Name (ARN) that represent the starting point for
        /// your lineage query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> StartArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StartArns property is set.
        /// </summary>
        internal bool IsSetStartArns() => this.StartArns != null && (this.StartArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
