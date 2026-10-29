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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListInsightsMetricData operation. Returns Insights
    /// metrics data for trails that have enabled Insights. The request must include the <c>EventSource</c>,
    /// <c>EventName</c>, and <c>InsightType</c> parameters. <para> If the <c>InsightType</c>
    /// is set to <c>ApiErrorRateInsight</c>, the request must also include the <c>ErrorCode</c>
    /// parameter. </para> <para> The following are the available time periods for <c>ListInsightsMetricData</c>.
    /// Each cutoff is inclusive. </para> <ul> <li> <para> Data points with a period of 60
    /// seconds (1-minute) are available for 15 days. </para> </li> <li> <para> Data points
    /// with a period of 300 seconds (5-minute) are available for 63 days. </para> </li> <li>
    /// <para> Data points with a period of 3600 seconds (1 hour) are available for 90 days.
    /// </para> </li> </ul> <para> To use <c>ListInsightsMetricData</c> operation, you must
    /// have the following permissions: </para> <ul> <li> <para> If <c>ListInsightsMetricData</c>
    /// is invoked with <c>TrailName</c> parameter, access to the <c>ListInsightsMetricData</c>
    /// API operation is linked to the <c>cloudtrail:LookupEvents</c> action and <c>cloudtrail:ListInsightsData</c>.
    /// To use this operation, you must have permissions to perform the <c>cloudtrail:LookupEvents</c>
    /// and <c>cloudtrail:ListInsightsData</c> action on the specific trail. </para> </li>
    /// <li> <para> If <c>ListInsightsMetricData</c> is invoked without <c>TrailName</c> parameter,
    /// access to the <c>ListInsightsMetricData</c> API operation is linked to the <c>cloudtrail:LookupEvents</c>
    /// action only. To use this operation, you must have permissions to perform the <c>cloudtrail:LookupEvents</c>
    /// action. </para> </li> </ul> <note> <para> For data event Insights on organization
    /// trails, only the management account and delegated administrator accounts can call
    /// <c>ListInsightsMetricData</c>. For these callers, the API returns Insights metrics
    /// only for the caller's own account. Member accounts cannot call this API on organization
    /// trails. </para> </note>
    /// </summary>
    public partial class ListInsightsMetricDataRequest : AmazonCloudTrailRequest
    {
        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// Type of data points to return. Valid values are <c>NonZeroData</c> and <c>FillWithZeros</c>.
        /// The default is <c>NonZeroData</c>.
        /// </para>
        /// </summary>
        public InsightsMetricDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

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
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

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
        [AWSProperty(Min = 0, Max = 128)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        /// The name of the event, typically the Amazon Web Services API on which unusual levels
        /// of activity were recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string EventName { get; set; }

        /// <summary>
        /// Checks to see if the EventName property is set.
        /// </summary>
        internal bool IsSetEventName() => this.EventName != null;

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The Amazon Web Services service to which the request was made, such as <c>iam.amazonaws.com</c>
        /// or <c>s3.amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string EventSource { get; set; }

        /// <summary>
        /// Checks to see if the EventSource property is set.
        /// </summary>
        internal bool IsSetEventSource() => this.EventSource != null;

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
        [AWSProperty(Required = true)]
        public InsightType InsightType { get; set; }

        /// <summary>
        /// Checks to see if the InsightType property is set.
        /// </summary>
        internal bool IsSetInsightType() => this.InsightType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of data points to return. Valid values are integers from 1 to 21600.
        /// The default value is 21600.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 21600)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

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
        [AWSProperty(Min = 1, Max = 5000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// Granularity of data to retrieve, in seconds. Valid values are <c>60</c>, <c>300</c>,
        /// and <c>3600</c>. If you specify any other value, you will get an error. The default
        /// is 3600 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 3600)]
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;

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
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrailName. 
        /// <para>
        /// The Amazon Resource Name(ARN) or name of the trail for which you want to retrieve
        /// Insights metrics data. This parameter should only be provided to fetch Insights metrics
        /// data generated on trails logging data events. This parameter is not required for Insights
        /// metric data generated on trails logging management events.
        /// </para>
        /// </summary>
        public string TrailName { get; set; }

        /// <summary>
        /// Checks to see if the TrailName property is set.
        /// </summary>
        internal bool IsSetTrailName() => this.TrailName != null;
    }
}
