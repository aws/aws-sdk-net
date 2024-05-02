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
    /// Container for the parameters to the GetAggregateDiscoveredResourceCounts operation.
    /// Returns the resource counts across accounts and regions that are present in your Config
    /// aggregator. You can request the resource counts by providing filters and GroupByKey.
    /// 
    ///  
    /// <para>
    /// For example, if the input contains accountID 12345678910 and region us-east-1 in filters,
    /// the API returns the count of resources in account ID 12345678910 and region us-east-1.
    /// If the input contains ACCOUNT_ID as a GroupByKey, the API returns resource counts
    /// for all source accounts that are present in your aggregator.
    /// </para>
    /// </summary>
    public partial class GetAggregateDiscoveredResourceCountsRequest : AmazonConfigServiceRequest
    {
        private string _configurationAggregatorName;
        private ResourceCountFilters _filters;
        private ResourceCountGroupKey _groupByKey;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorName. 
        /// <para>
        /// The name of the configuration aggregator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConfigurationAggregatorName
        {
            get { return this._configurationAggregatorName; }
            set { this._configurationAggregatorName = value; }
        }

        // Check to see if ConfigurationAggregatorName property is set
        internal bool IsSetConfigurationAggregatorName()
        {
            return this._configurationAggregatorName != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters the results based on the <c>ResourceCountFilters</c> object.
        /// </para>
        /// </summary>
        public ResourceCountFilters Filters
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
        /// Gets and sets the property GroupByKey. 
        /// <para>
        /// The key to group the resource counts.
        /// </para>
        /// </summary>
        public ResourceCountGroupKey GroupByKey
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of <a>GroupedResourceCount</a> objects returned on each page. The
        /// default is 1000. You cannot specify a number greater than 1000. If you specify 0,
        /// Config uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
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

    }
}