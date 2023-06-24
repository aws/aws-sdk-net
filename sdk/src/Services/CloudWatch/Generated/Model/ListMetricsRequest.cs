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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the ListMetrics operation.
    /// List the specified metrics. You can use the returned metrics with <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>
    /// to get statistical data.
    /// 
    ///  
    /// <para>
    /// Up to 500 results are returned for any one call. To retrieve additional results, use
    /// the returned token with subsequent calls.
    /// </para>
    ///  
    /// <para>
    /// After you create a metric, allow up to 15 minutes for the metric to appear. To see
    /// metric statistics sooner, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
    /// </para>
    ///  
    /// <para>
    /// If you are using CloudWatch cross-account observability, you can use this operation
    /// in a monitoring account and view metrics from the linked source accounts. For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>.
    /// </para>
    ///  
    /// <para>
    ///  <code>ListMetrics</code> doesn't return information about metrics if those metrics
    /// haven't reported data in the past two weeks. To retrieve those metrics, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
    /// </para>
    /// </summary>
    public partial class ListMetricsRequest : AmazonCloudWatchRequest
    {
        private List<DimensionFilter> _dimensions = new List<DimensionFilter>();
        private bool? _includeLinkedAccounts;
        private string _metricName;
        private string _awsNamespace;
        private string _nextToken;
        private string _owningAccount;
        private RecentlyActive _recentlyActive;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions to filter against. Only the dimensions that match exactly will be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<DimensionFilter> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeLinkedAccounts. 
        /// <para>
        /// If you are using this operation in a monitoring account, specify <code>true</code>
        /// to include metrics from source accounts in the returned data.
        /// </para>
        ///  
        /// <para>
        /// The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool IncludeLinkedAccounts
        {
            get { return this._includeLinkedAccounts.GetValueOrDefault(); }
            set { this._includeLinkedAccounts = value; }
        }

        // Check to see if IncludeLinkedAccounts property is set
        internal bool IsSetIncludeLinkedAccounts()
        {
            return this._includeLinkedAccounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric to filter against. Only the metrics with names that match exactly
        /// will be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The metric namespace to filter against. Only the namespace that matches exactly will
        /// be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned by a previous call to indicate that there is more data available.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OwningAccount. 
        /// <para>
        /// When you use this operation in a monitoring account, use this field to return metrics
        /// only from one source account. To do so, specify that source account ID in this field,
        /// and also specify <code>true</code> for <code>IncludeLinkedAccounts</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OwningAccount
        {
            get { return this._owningAccount; }
            set { this._owningAccount = value; }
        }

        // Check to see if OwningAccount property is set
        internal bool IsSetOwningAccount()
        {
            return this._owningAccount != null;
        }

        /// <summary>
        /// Gets and sets the property RecentlyActive. 
        /// <para>
        /// To filter the results to show only metrics that have had data points published in
        /// the past three hours, specify this parameter with a value of <code>PT3H</code>. This
        /// is the only valid value for this parameter.
        /// </para>
        ///  
        /// <para>
        /// The results that are returned are an approximation of the value you specify. There
        /// is a low probability that the returned results include metrics with last published
        /// data as much as 40 minutes more than the specified time interval.
        /// </para>
        /// </summary>
        public RecentlyActive RecentlyActive
        {
            get { return this._recentlyActive; }
            set { this._recentlyActive = value; }
        }

        // Check to see if RecentlyActive property is set
        internal bool IsSetRecentlyActive()
        {
            return this._recentlyActive != null;
        }

    }
}