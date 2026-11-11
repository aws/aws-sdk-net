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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the ListMetrics operation. List the specified metrics.
    /// You can use the returned metrics with <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>
    /// to get statistical data. <para> Up to 500 results are returned for any one call. To
    /// retrieve additional results, use the returned token with subsequent calls. </para>
    /// <para> After you create a metric, allow up to 15 minutes for the metric to appear.
    /// To see metric statistics sooner, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
    /// </para> <para> If you are using CloudWatch cross-account observability, you can use
    /// this operation in a monitoring account and view metrics from the linked source accounts.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>. </para> <para> <c>ListMetrics</c> doesn't return
    /// information about metrics if those metrics haven't reported data in the past two weeks.
    /// To retrieve those metrics, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
    /// </para>
    /// </summary>
    public partial class ListMetricsRequest : AmazonCloudWatchRequest
    {
        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions to filter against. Only the dimension with names that match exactly
        /// will be returned. If you specify one dimension name and a metric has that dimension
        /// and also other dimensions, it will be returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<DimensionFilter> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionFilter>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeLinkedAccounts. 
        /// <para>
        /// If you are using this operation in a monitoring account, specify <c>true</c> to include
        /// metrics from source accounts in the returned data.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeLinkedAccounts { get; set; }

        /// <summary>
        /// Checks to see if the IncludeLinkedAccounts property is set.
        /// </summary>
        internal bool IsSetIncludeLinkedAccounts() => this.IncludeLinkedAccounts.HasValue;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric to filter against. Only the metrics with names that match exactly
        /// will be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The metric namespace to filter against. Only the namespace that matches exactly will
        /// be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned by a previous call to indicate that there is more data available.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OwningAccount. 
        /// <para>
        /// When you use this operation in a monitoring account, use this field to return metrics
        /// only from one source account. To do so, specify that source account ID in this field,
        /// and also specify <c>true</c> for <c>IncludeLinkedAccounts</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OwningAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwningAccount property is set.
        /// </summary>
        internal bool IsSetOwningAccount() => this.OwningAccount != null;

        /// <summary>
        /// Gets and sets the property RecentlyActive. 
        /// <para>
        /// To filter the results to show only metrics that have had data points published in
        /// the past three hours, specify this parameter with a value of <c>PT3H</c>. This is
        /// the only valid value for this parameter.
        /// </para>
        ///  
        /// <para>
        /// The results that are returned are an approximation of the value you specify. There
        /// is a low probability that the returned results include metrics with last published
        /// data as much as 50 minutes more than the specified time interval.
        /// </para>
        /// </summary>
        public RecentlyActive RecentlyActive { get; set; }

        /// <summary>
        /// Checks to see if the RecentlyActive property is set.
        /// </summary>
        internal bool IsSetRecentlyActive() => this.RecentlyActive != null;
    }
}
