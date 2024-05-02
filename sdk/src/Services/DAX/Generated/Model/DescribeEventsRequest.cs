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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
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
namespace Amazon.DAX.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEvents operation.
    /// Returns events related to DAX clusters and parameter groups. You can obtain events
    /// specific to a particular DAX cluster or parameter group by providing the name as a
    /// parameter.
    /// 
    ///  
    /// <para>
    /// By default, only the events occurring within the last 24 hours are returned; however,
    /// you can retrieve up to 14 days' worth of events if necessary.
    /// </para>
    /// </summary>
    public partial class DescribeEventsRequest : AmazonDAXRequest
    {
        private int? _duration;
        private DateTime? _endTime;
        private int? _maxResults;
        private string _nextToken;
        private string _sourceName;
        private SourceType _sourceType;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The number of minutes' worth of events to retrieve.
        /// </para>
        /// </summary>
        public int? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time interval for which to retrieve events, specified in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to include in the response. If more results exist than
        /// the specified <c>MaxResults</c> value, a token is included in the response so that
        /// the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// The value for <c>MaxResults</c> must be between 20 and 100.
        /// </para>
        /// </summary>
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
        /// An optional token returned from a prior request. Use this token for pagination of
        /// results from this action. If this parameter is specified, the response includes only
        /// results beyond the token, up to the value specified by <c>MaxResults</c>.
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
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The identifier of the event source for which events will be returned. If not specified,
        /// then all sources are included in the response.
        /// </para>
        /// </summary>
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The event source to retrieve events for. If no value is specified, all events are
        /// returned.
        /// </para>
        /// </summary>
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The beginning of the time interval to retrieve events for, specified in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}