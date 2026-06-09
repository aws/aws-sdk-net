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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the ListOrderableInstanceTypes operation.
    /// Lists the instance types that can be ordered for an Outpost. You can filter the results
    /// by Outpost generation.
    /// </summary>
    public partial class ListOrderableInstanceTypesRequest : AmazonOutpostsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private OutpostGeneration _outpostGenerationFilter;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum page size.
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
        /// The pagination token.
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
        /// Gets and sets the property OutpostGenerationFilter. 
        /// <para>
        /// Filters the results by Outpost generation. Specify <c>GENERATION_1</c> for first-generation
        /// rack deployments or <c>GENERATION_2</c> for second-generation rack deployments.
        /// </para>
        /// </summary>
        public OutpostGeneration OutpostGenerationFilter
        {
            get { return this._outpostGenerationFilter; }
            set { this._outpostGenerationFilter = value; }
        }

        // Check to see if OutpostGenerationFilter property is set
        internal bool IsSetOutpostGenerationFilter()
        {
            return this._outpostGenerationFilter != null;
        }

    }
}