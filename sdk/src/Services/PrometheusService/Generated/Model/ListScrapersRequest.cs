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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Container for the parameters to the ListScrapers operation.
    /// The <c>ListScrapers</c> operation lists all of the scrapers in your account. This
    /// includes scrapers being created or deleted. You can optionally filter the returned
    /// list.
    /// </summary>
    public partial class ListScrapersRequest : AmazonPrometheusServiceRequest
    {
        private Dictionary<string, List<string>> _filters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// (Optional) A list of key-value pairs to filter the list of scrapers returned. Keys
        /// include <c>status</c>, <c>sourceArn</c>, <c>destinationArn</c>, and <c>alias</c>.
        /// </para>
        ///  
        /// <para>
        /// Filters on the same key are <c>OR</c>'d together, and filters on different keys are
        /// <c>AND</c>'d together. For example, <c>status=ACTIVE&amp;status=CREATING&amp;alias=Test</c>,
        /// will return all scrapers that have the alias Test, and are either in status ACTIVE
        /// or CREATING.
        /// </para>
        ///  
        /// <para>
        /// To find all active scrapers that are sending metrics to a specific Amazon Managed
        /// Service for Prometheus workspace, you would use the ARN of the workspace in a query:
        /// </para>
        ///  
        /// <para>
        ///  <c>status=ACTIVE&amp;destinationArn=arn:aws:aps:us-east-1:123456789012:workspace/ws-example1-1234-abcd-56ef-123456789012</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If this is included, it filters the results to only the scrapers that match the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public Dictionary<string, List<string>> Filters
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
        /// Optional) The maximum number of scrapers to return in one <c>ListScrapers</c> operation.
        /// The range is 1-1000.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the default of 100 is used.
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
        /// (Optional) The token for the next set of items to return. (You received this token
        /// from a previous call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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