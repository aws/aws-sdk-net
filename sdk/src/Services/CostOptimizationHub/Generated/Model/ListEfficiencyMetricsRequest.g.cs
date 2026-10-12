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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Container for the parameters to the ListEfficiencyMetrics operation. Returns cost
    /// efficiency metrics aggregated over time and optionally grouped by a specified dimension.
    /// The metrics provide insights into your cost optimization progress by tracking estimated
    /// savings, spending, and measures how effectively you're optimizing your Cloud resources.
    /// <para> The operation supports both daily and monthly time granularities and allows
    /// grouping results by account ID, Amazon Web Services Region. Results are returned as
    /// time-series data, enabling you to analyze trends in your cost optimization performance
    /// over the specified time period. </para>
    /// </summary>
    public partial class ListEfficiencyMetricsRequest : AmazonCostOptimizationHubRequest
    {
        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The time granularity for the cost efficiency metrics. Specify <c>Daily</c> for metrics
        /// aggregated by day, or <c>Monthly</c> for metrics aggregated by month.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GranularityType Granularity { get; set; }

        /// <summary>
        /// Checks to see if the Granularity property is set.
        /// </summary>
        internal bool IsSetGranularity() => this.Granularity != null;

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The dimension by which to group the cost efficiency metrics. Valid values include
        /// account ID, Amazon Web Services Region. When no grouping is specified, metrics are
        /// aggregated across all resources in the specified time period.
        /// </para>
        /// </summary>
        public string GroupBy { get; set; }

        /// <summary>
        /// Checks to see if the GroupBy property is set.
        /// </summary>
        internal bool IsSetGroupBy() => this.GroupBy != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of groups to return in the response. Valid values range from 0
        /// to 1000. Use in conjunction with <c>nextToken</c> to paginate through results when
        /// the total number of groups exceeds this limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next page of results. This value is returned in the response
        /// when the number of groups exceeds the specified <c>maxResults</c> value.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// The ordering specification for the results. Defines which dimension to sort by and
        /// whether to sort in ascending or descending order.
        /// </para>
        /// </summary>
        public OrderBy OrderBy { get; set; }

        /// <summary>
        /// Checks to see if the OrderBy property is set.
        /// </summary>
        internal bool IsSetOrderBy() => this.OrderBy != null;

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period for which to retrieve the cost efficiency metrics. The start date
        /// is inclusive and the end date is exclusive. Dates can be specified in either YYYY-MM-DD
        /// format or YYYY-MM format depending on the desired granularity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimePeriod TimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the TimePeriod property is set.
        /// </summary>
        internal bool IsSetTimePeriod() => this.TimePeriod != null;
    }
}
