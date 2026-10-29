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
    /// Container for the parameters to the ListInsightsData operation. Returns Insights events
    /// generated on a trail that logs data events. You can list Insights events that occurred
    /// in a Region within the last 90 days. <para> ListInsightsData supports the following
    /// Dimensions for Insights events: </para> <ul> <li> <para> Event ID </para> </li> <li>
    /// <para> Event name </para> </li> <li> <para> Event source </para> </li> </ul> <para>
    /// All dimensions are optional. The default number of results returned is 50, with a
    /// maximum of 50 possible. The response includes a token that you can use to get the
    /// next page of results. </para> <para> The rate of ListInsightsData requests is limited
    /// to two per second, per account, per Region. If this limit is exceeded, a throttling
    /// error occurs. </para> <note> <para> For data event Insights on organization trails,
    /// only the management account and delegated administrator accounts can call <c>ListInsightsData</c>.
    /// For these callers, the API returns Insights events only for the caller's own account.
    /// Member accounts cannot call this API on organization trails. </para> </note>
    /// </summary>
    public partial class ListInsightsDataRequest : AmazonCloudTrailRequest
    {
        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// Specifies the category of events returned. To fetch Insights events, specify <c>InsightsEvents</c>
        /// as the value of <c>DataType</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ListInsightsDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Contains a map of dimensions. Currently the map can contain only one item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public Dictionary<string, string> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Specifies that only events that occur before or at the specified time are returned.
        /// If the specified end time is before the specified start time, an error is returned.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InsightSource. 
        /// <para>
        /// The Amazon Resource Name(ARN) of the trail for which you want to retrieve Insights
        /// events.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 256)]
        public string InsightSource { get; set; }

        /// <summary>
        /// Checks to see if the InsightSource property is set.
        /// </summary>
        internal bool IsSetInsightSource() => this.InsightSource != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of events to return. Possible values are 1 through 50. The default is 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to get the next page of results after a previous API call. This token
        /// must be passed in with the same parameters that were specified in the original call.
        /// For example, if the original call specified a EventName as a dimension with <c>PutObject</c>
        /// as a value, the call with NextToken should include those same parameters. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Specifies that only events that occur after or at the specified time are returned.
        /// If the specified start time is after the specified end time, an error is returned.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
