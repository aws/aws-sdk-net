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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the ListCrawls operation.
    /// Returns all the crawls of a specified crawler. Returns only the crawls that have occurred
    /// since the launch date of the crawler history feature, and only retains up to 12 months
    /// of crawls. Older crawls will not be returned.
    /// 
    ///  
    /// <para>
    /// You may use this API to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Retrive all the crawls of a specified crawler.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Retrieve all the crawls of a specified crawler within a limited count.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Retrieve all the crawls of a specified crawler in a specific time range.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Retrieve all the crawls of a specified crawler with a particular state, crawl ID,
    /// or DPU hour value.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListCrawlsRequest : AmazonGlueRequest
    {
        private string _crawlerName;
        private List<CrawlsFilter> _filters = AWSConfigs.InitializeCollections ? new List<CrawlsFilter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CrawlerName. 
        /// <para>
        /// The name of the crawler whose runs you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string CrawlerName
        {
            get { return this._crawlerName; }
            set { this._crawlerName = value; }
        }

        // Check to see if CrawlerName property is set
        internal bool IsSetCrawlerName()
        {
            return this._crawlerName != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters the crawls by the criteria you specify in a list of <c>CrawlsFilter</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CrawlsFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return. The default is 20, and maximum is 100.
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
        /// A continuation token, if this is a continuation call.
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