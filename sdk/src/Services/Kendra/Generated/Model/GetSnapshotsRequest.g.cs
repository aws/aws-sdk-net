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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the GetSnapshots operation. Retrieves search metrics
    /// data. The data provides a snapshot of how your users interact with your search application
    /// and how effective the application is.
    /// </summary>
    public partial class GetSnapshotsRequest : AmazonKendraRequest
    {
        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index to get search metrics data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string IndexId { get; set; }

        /// <summary>
        /// Checks to see if the IndexId property is set.
        /// </summary>
        internal bool IsSetIndexId() => this.IndexId != null;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The time interval or time window to get search metrics data. The time interval uses
        /// the time zone of your index. You can view data in the following time windows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>THIS_WEEK</c>: The current week, starting on the Sunday and ending on the day
        /// before the current date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ONE_WEEK_AGO</c>: The previous week, starting on the Sunday and ending on the
        /// following Saturday.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TWO_WEEKS_AGO</c>: The week before the previous week, starting on the Sunday and
        /// ending on the following Saturday.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>THIS_MONTH</c>: The current month, starting on the first day of the month and
        /// ending on the day before the current date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ONE_MONTH_AGO</c>: The previous month, starting on the first day of the month
        /// and ending on the last day of the month.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TWO_MONTHS_AGO</c>: The month before the previous month, starting on the first
        /// day of the month and ending on last day of the month.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public Interval Interval { get; set; }

        /// <summary>
        /// Checks to see if the Interval property is set.
        /// </summary>
        internal bool IsSetInterval() => this.Interval != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of returned data for the metric.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MetricType. 
        /// <para>
        /// The metric you want to retrieve. You can specify only one metric per call.
        /// </para>
        ///  
        /// <para>
        /// For more information about the metrics you can view, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/search-analytics.html">Gaining
        /// insights with search analytics</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetricType MetricType { get; set; }

        /// <summary>
        /// Checks to see if the MetricType property is set.
        /// </summary>
        internal bool IsSetMetricType() => this.MetricType != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was incomplete (because there is more data to retrieve),
        /// Amazon Kendra returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of search metrics data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 800)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
