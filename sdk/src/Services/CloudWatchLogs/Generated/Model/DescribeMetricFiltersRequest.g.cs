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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMetricFilters operation. Lists the specified
    /// metric filters. You can list all of the metric filters or filter the results by log
    /// name, prefix, metric name, or metric namespace. The results are ASCII-sorted by filter
    /// name.
    /// </summary>
    public partial class DescribeMetricFiltersRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DescribeMetricFiltersRequest() { }

        /// <summary>
        /// Instantiates DescribeMetricFiltersRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The name of the log group.</param>
        public DescribeMetricFiltersRequest(string logGroupName)
        {
            this.LogGroupName = logGroupName;
        }

        /// <summary>
        /// Gets and sets the property FilterNamePrefix. 
        /// <para>
        /// The prefix to match. CloudWatch Logs uses the value that you set here only if you
        /// also include the <c>logGroupName</c> parameter in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FilterNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the FilterNamePrefix property is set.
        /// </summary>
        internal bool IsSetFilterNamePrefix() => this.FilterNamePrefix != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items returned. If you don't specify a value, the default is
        /// up to 50 items.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// Filters results to include only those with the specified metric name. If you include
        /// this parameter in your request, you must also include the <c>metricNamespace</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property MetricNamespace. 
        /// <para>
        /// Filters results to include only those in the specified namespace. If you include this
        /// parameter in your request, you must also include the <c>metricName</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string MetricNamespace { get; set; }

        /// <summary>
        /// Checks to see if the MetricNamespace property is set.
        /// </summary>
        internal bool IsSetMetricNamespace() => this.MetricNamespace != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
