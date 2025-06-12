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
    /// This is the response object from the ListInsightsMetricData operation.
    /// </summary>
    public partial class ListInsightsMetricDataResponse : AmazonWebServiceResponse
    {
        private string _errorCode;
        private string _eventName;
        private string _eventSource;
        private InsightType _insightType;
        private string _nextToken;
        private List<DateTime> _timestamps = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;
        private List<double> _values = AWSConfigs.InitializeCollections ? new List<double>() : null;

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
        [AWSProperty(Max=128)]
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
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Only returned if the full results could not be returned in a single query. You can
        /// set the <c>NextToken</c> parameter in the next request to this value to continue retrieval.
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
        /// Gets and sets the property Timestamps. 
        /// <para>
        /// List of timestamps at intervals corresponding to the specified time period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> Timestamps
        {
            get { return this._timestamps; }
            set { this._timestamps = value; }
        }

        // Check to see if Timestamps property is set
        internal bool IsSetTimestamps()
        {
            return this._timestamps != null && (this._timestamps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// List of values representing the API call rate or error rate at each timestamp. The
        /// number of values is equal to the number of timestamps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}