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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
        private List<CloudWatchMetricsDimension> _dimensions = AWSConfigs.InitializeCollections ? new List<CloudWatchMetricsDimension>() : null;
        private CloudWatchMetricsDataSummary _metricDataSummary;
        private string _metricName;
        private string _awsNamespace;
        private int? _period;
        private CloudWatchMetricsStat _stat;
        private string _unit;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        ///  An array of CloudWatch dimensions associated with 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudWatchMetricsDimension> Dimensions
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
        /// Gets and sets the property MetricDataSummary. 
        /// <para>
        /// This object returns anomaly metric data.
        /// </para>
        /// </summary>
        public CloudWatchMetricsDataSummary MetricDataSummary
        {
            get { return this._metricDataSummary; }
            set { this._metricDataSummary = value; }
        }

        // Check to see if MetricDataSummary property is set
        internal bool IsSetMetricDataSummary()
        {
            return this._metricDataSummary != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        ///  The name of the CloudWatch metric. 
        /// </para>
        /// </summary>
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
        ///  The namespace of the CloudWatch metric. A namespace is a container for CloudWatch
        /// metrics. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Period. 
        /// <para>
        ///  The length of time associated with the CloudWatch metric in number of seconds. 
        /// </para>
        /// </summary>
        public int? Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stat. 
        /// <para>
        ///  The type of statistic associated with the CloudWatch metric. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html#Statistic">Statistics</a>
        /// in the <i>Amazon CloudWatch User Guide</i>. 
        /// </para>
        /// </summary>
        public CloudWatchMetricsStat Stat
        {
            get { return this._stat; }
            set { this._stat = value; }
        }

        // Check to see if Stat property is set
        internal bool IsSetStat()
        {
            return this._stat != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        ///  The unit of measure used for the CloudWatch metric. For example, <c>Bytes</c>, <c>Seconds</c>,
        /// <c>Count</c>, and <c>Percent</c>. 
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}