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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about an Amazon CloudWatch metric.
    /// </summary>
    public partial class CloudWatchMetricsDetail
    {
        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        ///  An array of CloudWatch dimensions associated with 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudWatchMetricsDimension> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<CloudWatchMetricsDimension>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricDataSummary. 
        /// <para>
        /// This object returns anomaly metric data.
        /// </para>
        /// </summary>
        public CloudWatchMetricsDataSummary MetricDataSummary { get; set; }

        /// <summary>
        /// Checks to see if the MetricDataSummary property is set.
        /// </summary>
        internal bool IsSetMetricDataSummary() => this.MetricDataSummary != null;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        ///  The name of the CloudWatch metric. 
        /// </para>
        /// </summary>
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        ///  The namespace of the CloudWatch metric. A namespace is a container for CloudWatch
        /// metrics. 
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        ///  The length of time associated with the CloudWatch metric in number of seconds. 
        /// </para>
        /// </summary>
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;

        /// <summary>
        /// Gets and sets the property Stat. 
        /// <para>
        ///  The type of statistic associated with the CloudWatch metric. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html#Statistic">Statistics</a>
        /// in the <i>Amazon CloudWatch User Guide</i>. 
        /// </para>
        /// </summary>
        public CloudWatchMetricsStat Stat { get; set; }

        /// <summary>
        /// Checks to see if the Stat property is set.
        /// </summary>
        internal bool IsSetStat() => this.Stat != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        ///  The unit of measure used for the CloudWatch metric. For example, <c>Bytes</c>, <c>Seconds</c>,
        /// <c>Count</c>, and <c>Percent</c>. 
        /// </para>
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
