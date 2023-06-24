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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMetricFilters operation.
    /// Lists the specified metric filters. You can list all of the metric filters or filter
    /// the results by log name, prefix, metric name, or metric namespace. The results are
    /// ASCII-sorted by filter name.
    /// </summary>
    public partial class DescribeMetricFiltersRequest : AmazonCloudWatchLogsRequest
    {
        private string _filterNamePrefix;
        private int? _limit;
        private string _logGroupName;
        private string _metricName;
        private string _metricNamespace;
        private string _nextToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeMetricFiltersRequest() { }

        /// <summary>
        /// Instantiates DescribeMetricFiltersRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The name of the log group.</param>
        public DescribeMetricFiltersRequest(string logGroupName)
        {
            _logGroupName = logGroupName;
        }

        /// <summary>
        /// Gets and sets the property FilterNamePrefix. 
        /// <para>
        /// The prefix to match. CloudWatch Logs uses the value that you set here only if you
        /// also include the <code>logGroupName</code> parameter in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string FilterNamePrefix
        {
            get { return this._filterNamePrefix; }
            set { this._filterNamePrefix = value; }
        }

        // Check to see if FilterNamePrefix property is set
        internal bool IsSetFilterNamePrefix()
        {
            return this._filterNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items returned. If you don't specify a value, the default is
        /// up to 50 items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// Filters results to include only those with the specified metric name. If you include
        /// this parameter in your request, you must also include the <code>metricNamespace</code>
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricNamespace. 
        /// <para>
        /// Filters results to include only those in the specified namespace. If you include this
        /// parameter in your request, you must also include the <code>metricName</code> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string MetricNamespace
        {
            get { return this._metricNamespace; }
            set { this._metricNamespace = value; }
        }

        // Check to see if MetricNamespace property is set
        internal bool IsSetMetricNamespace()
        {
            return this._metricNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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

    }
}