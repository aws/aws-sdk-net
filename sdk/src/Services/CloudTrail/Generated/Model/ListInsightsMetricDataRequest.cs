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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the ListInsightsMetricData operation.
    /// Returns Insights metrics data for trails that have enabled Insights. The request must
    /// include the <c>EventSource</c>, <c>EventName</c>, and <c>InsightType</c> parameters.
    /// 
    ///  
    /// <para>
    /// If the <c>InsightType</c> is set to <c>ApiErrorRateInsight</c>, the request must also
    /// include the <c>ErrorCode</c> parameter.
    /// </para>
    ///  
    /// <para>
    /// The following are the available time periods for <c>ListInsightsMetricData</c>. Each
    /// cutoff is inclusive.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Data points with a period of 60 seconds (1-minute) are available for 15 days.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Data points with a period of 300 seconds (5-minute) are available for 63 days.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Data points with a period of 3600 seconds (1 hour) are available for 90 days.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Access to the <c>ListInsightsMetricData</c> API operation is linked to the <c>cloudtrail:LookupEvents</c>
    /// action. To use this operation, you must have permissions to perform the <c>cloudtrail:LookupEvents</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class ListInsightsMetricDataRequest : AmazonCloudTrailRequest
    {
        private InsightsMetricDataType _dataType;
        private DateTime? _endTime;
        private string _errorCode;
        private string _eventName;
        private string _eventSource;
        private InsightType _insightType;
        private int? _maxResults;
        private string _nextToken;
        private int? _period;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// Type of data points to return. Valid values are <c>NonZeroData</c> and <c>FillWithZeros</c>.
        /// The default is <c>NonZeroData</c>.
        /// </para>
        /// </summary>
        public InsightsMetricDataType DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Specifies, in UTC, the end time for time-series data. The value specified is exclusive;
        /// results include data points up to the specified time stamp.
        /// </para>
        ///  
        /// <para>
        /// The default is the time of request.
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
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Conditionally required if the <c>InsightType</c> parameter is set to <c>ApiErrorRateInsight</c>.
        /// </para>
        ///  
        /// <para>
        /// If returning metrics for the <c>ApiErrorRateInsight</c> Insights type, this is the
        /// error to retrieve data for. For example, <c>AccessDenied</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        /// The name of the event, typically the Amazon Web Services API on which unusual levels
        /// of activity were recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string EventName
        {
            get { return this._eventName; }
            set { this._eventName = value; }
        }

        // Check to see if EventName property is set
        internal bool IsSetEventName()
        {
            return this._eventName != null;
        }

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The Amazon Web Services service to which the request was made, such as <c>iam.amazonaws.com</c>
        /// or <c>s3.amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }

        // Check to see if EventSource property is set
        internal bool IsSetEventSource()
        {
            return this._eventSource != null;
        }

        /// <summary>
        /// Gets and sets the property InsightType. 
        /// <para>
        /// The type of CloudTrail Insights event, which is either <c>ApiCallRateInsight</c> or
        /// <c>ApiErrorRateInsight</c>. The <c>ApiCallRateInsight</c> Insights type analyzes write-only
        /// management API calls that are aggregated per minute against a baseline API call volume.
        /// The <c>ApiErrorRateInsight</c> Insights type analyzes management API calls that result
        /// in error codes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InsightType InsightType
        {
            get { return this._insightType; }
            set { this._insightType = value; }
        }

        // Check to see if InsightType property is set
        internal bool IsSetInsightType()
        {
            return this._insightType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of data points to return. Valid values are integers from 1 to 21600.
        /// The default value is 21600.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=21600)]
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
        /// Returned if all datapoints can't be returned in a single call. For example, due to
        /// reaching <c>MaxResults</c>.
        /// </para>
        ///  
        /// <para>
        /// Add this parameter to the request to continue retrieving results starting from the
        /// last evaluated point.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
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
        /// Gets and sets the property Period. 
        /// <para>
        /// Granularity of data to retrieve, in seconds. Valid values are <c>60</c>, <c>300</c>,
        /// and <c>3600</c>. If you specify any other value, you will get an error. The default
        /// is 3600 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=3600)]
        public int? Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Specifies, in UTC, the start time for time-series data. The value specified is inclusive;
        /// results include data points with the specified time stamp.
        /// </para>
        ///  
        /// <para>
        /// The default is 90 days before the time of request.
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