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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
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
namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Container for the parameters to the SearchFixtures operation.
    /// Searches for the fixtures (sports events, such as a specific basketball game) that
    /// are available for a sport in a date window. Each fixture in the response includes
    /// a fixtureId that you specify in the clipping output of a feed, so that Elemental Inference
    /// maps the event data for that fixture onto the clipping metadata. This operation is
    /// paginated: if there are more fixtures than fit in one page, the response includes
    /// a nextToken that you pass in a subsequent request.
    /// </summary>
    public partial class SearchFixturesRequest : AmazonElementalInferenceRequest
    {
        private string _endDate;
        private List<SearchFilter> _filters = AWSConfigs.InitializeCollections ? new List<SearchFilter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private DataSourceSport _sport;
        private string _startDate;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The last day of the search window, in UTC. The search includes fixtures that are scheduled
        /// on this day. Specify the date in ISO 8601 format, as <c>YYYY-MM-DD</c>. 
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, Elemental Inference searches only the day that you specified
        /// in startDate. The window from startDate through endDate must not exceed seven days.
        /// 
        /// </para>
        /// </summary>
        public string EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of filters that narrow the results. Each filter applies to one dimension
        /// of a fixture, such as the competitor. You can specify up to 10 filters. 
        /// </para>
        ///  
        /// <para>
        /// A fixture must satisfy every filter in the array in order to appear in the results.
        /// Within one filter, a fixture must match at least one of the values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<SearchFilter> Filters
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
        /// The maximum number of fixtures to return for each API request.
        /// </para>
        ///  
        /// <para>
        /// The service might return fewer fixtures than the maxResults value. When more fixtures
        /// match the search, the response also includes a nextToken value that you can use to
        /// fetch the next batch of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token that identifies the batch of results that you want to see.
        /// </para>
        ///  
        /// <para>
        /// For example, you submit a SearchFixtures request with maxResults set at 5. The service
        /// returns the first batch of results (up to 5) and a nextToken value. To see the next
        /// batch of results, you submit the SearchFixtures request a second time, with the same
        /// search criteria, and specify the nextToken value. 
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
        /// Gets and sets the property Sport. 
        /// <para>
        /// The sport to search for fixtures. Valid values: basketball (search for basketball
        /// fixtures), american-football (search for american-football fixtures). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceSport Sport
        {
            get { return this._sport; }
            set { this._sport = value; }
        }

        // Check to see if Sport property is set
        internal bool IsSetSport()
        {
            return this._sport != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The first day of the search window, in UTC. The search includes fixtures that are
        /// scheduled on this day. 
        /// </para>
        ///  
        /// <para>
        /// Specify the date in ISO 8601 format, as <c>YYYY-MM-DD</c>. For example, 2026-03-14.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate != null;
        }

    }
}