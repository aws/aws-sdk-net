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
    /// This is the response object from the ListInsightsMetricData operation.
    /// </summary>
    public partial class ListInsightsMetricDataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Only returned if <c>InsightType</c> parameter was set to <c>ApiErrorRateInsight</c>.
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
        [AWSProperty(Min = 0, Max = 128)]
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
        [AWSProperty(Min = 0, Max = 256)]
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
        public InsightType InsightType { get; set; }

        /// <summary>
        /// Checks to see if the InsightType property is set.
        /// </summary>
        internal bool IsSetInsightType() => this.InsightType != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Only returned if the full results could not be returned in a single query. You can
        /// set the <c>NextToken</c> parameter in the next request to this value to continue retrieval.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Timestamps. 
        /// <para>
        /// List of timestamps at intervals corresponding to the specified time period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> Timestamps { get; set; } = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;

        /// <summary>
        /// Checks to see if the Timestamps property is set.
        /// </summary>
        internal bool IsSetTimestamps() => this.Timestamps != null && (this.Timestamps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrailARN. 
        /// <para>
        /// Specifies the ARN of the trail. This is only returned when Insights is enabled on
        /// a trail logging data events. 
        /// </para>
        /// </summary>
        public string TrailARN { get; set; }

        /// <summary>
        /// Checks to see if the TrailARN property is set.
        /// </summary>
        internal bool IsSetTrailARN() => this.TrailARN != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// List of values representing the API call rate or error rate at each timestamp. The
        /// number of values is equal to the number of timestamps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
