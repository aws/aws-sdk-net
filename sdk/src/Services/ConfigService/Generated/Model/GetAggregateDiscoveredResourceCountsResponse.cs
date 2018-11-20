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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the GetAggregateDiscoveredResourceCounts operation.
    /// </summary>
    public partial class GetAggregateDiscoveredResourceCountsResponse : AmazonWebServiceResponse
    {
        private string _groupByKey;
        private List<GroupedResourceCount> _groupedResourceCounts = new List<GroupedResourceCount>();
        private string _nextToken;
        private long? _totalDiscoveredResources;

        /// <summary>
        /// Gets and sets the property GroupByKey. 
        /// <para>
        /// The key passed into the request object. If <code>GroupByKey</code> is not provided,
        /// the result will be empty.
        /// </para>
        /// </summary>
        public string GroupByKey
        {
            get { return this._groupByKey; }
            set { this._groupByKey = value; }
        }

        // Check to see if GroupByKey property is set
        internal bool IsSetGroupByKey()
        {
            return this._groupByKey != null;
        }

        /// <summary>
        /// Gets and sets the property GroupedResourceCounts. 
        /// <para>
        /// Returns a list of GroupedResourceCount objects.
        /// </para>
        /// </summary>
        public List<GroupedResourceCount> GroupedResourceCounts
        {
            get { return this._groupedResourceCounts; }
            set { this._groupedResourceCounts = value; }
        }

        // Check to see if GroupedResourceCounts property is set
        internal bool IsSetGroupedResourceCounts()
        {
            return this._groupedResourceCounts != null && this._groupedResourceCounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string returned on a previous page that you use to get
        /// the next page of results in a paginated response.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TotalDiscoveredResources. 
        /// <para>
        /// The total number of resources that are present in an aggregator with the filters that
        /// you provide.
        /// </para>
        /// </summary>
        public long TotalDiscoveredResources
        {
            get { return this._totalDiscoveredResources.GetValueOrDefault(); }
            set { this._totalDiscoveredResources = value; }
        }

        // Check to see if TotalDiscoveredResources property is set
        internal bool IsSetTotalDiscoveredResources()
        {
            return this._totalDiscoveredResources.HasValue; 
        }

    }
}