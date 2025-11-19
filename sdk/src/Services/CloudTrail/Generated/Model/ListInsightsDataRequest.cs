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
    /// Container for the parameters to the ListInsightsData operation.
    /// Returns Insights events generated on a trail that logs data events. You can list Insights
    /// events that occurred in a Region within the last 90 days.
    /// 
    ///  
    /// <para>
    /// ListInsightsData supports the following Dimensions for Insights events:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Event ID
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Event name
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Event source
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// All dimensions are optional. The default number of results returned is 50, with a
    /// maximum of 50 possible. The response includes a token that you can use to get the
    /// next page of results.
    /// </para>
    ///  
    /// <para>
    /// The rate of ListInsightsData requests is limited to two per second, per account, per
    /// Region. If this limit is exceeded, a throttling error occurs.
    /// </para>
    /// </summary>
    public partial class ListInsightsDataRequest : AmazonCloudTrailRequest
    {
        private ListInsightsDataType _dataType;
        private Dictionary<string, string> _dimensions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _endTime;
        private string _insightSource;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// Specifies the category of events returned. To fetch Insights events, specify <c>InsightsEvents</c>
        /// as the value of <c>DataType</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ListInsightsDataType DataType
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
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Contains a map of dimensions. Currently the map can contain only one item.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public Dictionary<string, string> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Specifies that only events that occur before or at the specified time are returned.
        /// If the specified end time is before the specified start time, an error is returned.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InsightSource. 
        /// <para>
        /// The Amazon Resource Name(ARN) of the trail for which you want to retrieve Insights
        /// events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=256)]
        public string InsightSource
        {
            get { return this._insightSource; }
            set { this._insightSource = value; }
        }

        // Check to see if InsightSource property is set
        internal bool IsSetInsightSource()
        {
            return this._insightSource != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of events to return. Possible values are 1 through 50. The default is 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The token to use to get the next page of results after a previous API call. This token
        /// must be passed in with the same parameters that were specified in the original call.
        /// For example, if the original call specified a EventName as a dimension with <c>PutObject</c>
        /// as a value, the call with NextToken should include those same parameters. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1000)]
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Specifies that only events that occur after or at the specified time are returned.
        /// If the specified start time is after the specified end time, an error is returned.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}