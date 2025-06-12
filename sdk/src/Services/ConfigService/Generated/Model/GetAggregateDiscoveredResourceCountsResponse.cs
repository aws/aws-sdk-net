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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the GetAggregateDiscoveredResourceCounts operation.
    /// </summary>
    public partial class GetAggregateDiscoveredResourceCountsResponse : AmazonWebServiceResponse
    {
        private string _groupByKey;
        private List<GroupedResourceCount> _groupedResourceCounts = AWSConfigs.InitializeCollections ? new List<GroupedResourceCount>() : null;
        private string _nextToken;
        private long? _totalDiscoveredResources;

        /// <summary>
        /// Gets and sets the property GroupByKey. 
        /// <para>
        /// The key passed into the request object. If <c>GroupByKey</c> is not provided, the
        /// result will be empty.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupedResourceCount> GroupedResourceCounts
        {
            get { return this._groupedResourceCounts; }
            set { this._groupedResourceCounts = value; }
        }

        // Check to see if GroupedResourceCounts property is set
        internal bool IsSetGroupedResourceCounts()
        {
            return this._groupedResourceCounts != null && (this._groupedResourceCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response.
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
        [AWSProperty(Required=true)]
        public long? TotalDiscoveredResources
        {
            get { return this._totalDiscoveredResources; }
            set { this._totalDiscoveredResources = value; }
        }

        // Check to see if TotalDiscoveredResources property is set
        internal bool IsSetTotalDiscoveredResources()
        {
            return this._totalDiscoveredResources.HasValue; 
        }

    }
}