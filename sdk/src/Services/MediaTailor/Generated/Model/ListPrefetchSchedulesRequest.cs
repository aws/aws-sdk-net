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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Container for the parameters to the ListPrefetchSchedules operation.
    /// Lists the prefetch schedules for a playback configuration.
    /// </summary>
    public partial class ListPrefetchSchedulesRequest : AmazonMediaTailorRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _playbackConfigurationName;
        private ListPrefetchScheduleType _scheduleType;
        private string _streamId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of prefetch schedules that you want MediaTailor to return in response
        /// to the current request. If there are more than <c>MaxResults</c> prefetch schedules,
        /// use the value of <c>NextToken</c> in the response to get the next page of results.
        /// </para>
        ///  
        /// <para>
        /// The default value is 100. MediaTailor uses DynamoDB-based pagination, which means
        /// that a response might contain fewer than <c>MaxResults</c> items, including 0 items,
        /// even when more results are available. To retrieve all results, you must continue making
        /// requests using the <c>NextToken</c> value from each response until the response no
        /// longer includes a <c>NextToken</c> value.
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
        /// Pagination token returned by the list request when results exceed the maximum allowed.
        /// Use the token to fetch the next page of results.
        /// </para>
        ///  
        /// <para>
        /// For the first <c>ListPrefetchSchedules</c> request, omit this value. For subsequent
        /// requests, get the value of <c>NextToken</c> from the previous response and specify
        /// that value for <c>NextToken</c> in the request. Continue making requests until the
        /// response no longer includes a <c>NextToken</c> value, which indicates that all results
        /// have been retrieved.
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
        /// Gets and sets the property PlaybackConfigurationName. 
        /// <para>
        /// Retrieves the prefetch schedule(s) for a specific playback configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlaybackConfigurationName
        {
            get { return this._playbackConfigurationName; }
            set { this._playbackConfigurationName = value; }
        }

        // Check to see if PlaybackConfigurationName property is set
        internal bool IsSetPlaybackConfigurationName()
        {
            return this._playbackConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleType. 
        /// <para>
        /// The type of prefetch schedules that you want to list. <c>SINGLE</c> indicates that
        /// you want to list the configured single prefetch schedules. <c>RECURRING</c> indicates
        /// that you want to list the configured recurring prefetch schedules. <c>ALL</c> indicates
        /// that you want to list all configured prefetch schedules.
        /// </para>
        /// </summary>
        public ListPrefetchScheduleType ScheduleType
        {
            get { return this._scheduleType; }
            set { this._scheduleType = value; }
        }

        // Check to see if ScheduleType property is set
        internal bool IsSetScheduleType()
        {
            return this._scheduleType != null;
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// An optional filtering parameter whereby MediaTailor filters the prefetch schedules
        /// to include only specific streams.
        /// </para>
        /// </summary>
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

    }
}