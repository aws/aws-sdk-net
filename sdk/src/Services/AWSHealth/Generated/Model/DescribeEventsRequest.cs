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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEvents operation.
    /// Returns information about events that meet the specified filter criteria. Events
    /// are returned in a summary form and do not include the detailed description, any additional
    /// metadata that depends on the event type, or any affected resources. To retrieve that
    /// information, use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventDetails.html">DescribeEventDetails</a>
    /// and <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntities.html">DescribeAffectedEntities</a>
    /// operations.
    /// 
    ///  
    /// <para>
    /// If no filter criteria are specified, all events are returned. Results are sorted by
    /// <c>lastModifiedTime</c>, starting with the most recent event.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// When you call the <c>DescribeEvents</c> operation and specify an entity for the <c>entityValues</c>
    /// parameter, Health might return public events that aren't specific to that resource.
    /// For example, if you call <c>DescribeEvents</c> and specify an ID for an Amazon Elastic
    /// Compute Cloud (Amazon EC2) instance, Health might return events that aren't specific
    /// to that resource or service. To get events that are specific to a service, use the
    /// <c>services</c> parameter in the <c>filter</c> object. For more information, see <a
    /// href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
    /// next request to return more results.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class DescribeEventsRequest : AmazonAWSHealthRequest
    {
        private EventFilter _filter;
        private string _locale;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Values to narrow the results returned.
        /// </para>
        /// </summary>
        public EventFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale (language) to return information in. English (en) is the default and the
        /// only supported value at this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=256)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return in one batch, between 10 and 100, inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=100)]
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
        /// If the results of a search are large, only a portion of the results are returned,
        /// and a <c>nextToken</c> pagination token is returned in the response. To retrieve the
        /// next batch of results, reissue the search request and include the returned token.
        /// When all results have been returned, the response does not contain a pagination token
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=10000)]
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