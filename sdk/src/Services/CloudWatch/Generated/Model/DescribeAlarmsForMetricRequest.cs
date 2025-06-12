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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAlarmsForMetric operation.
    /// Retrieves the alarms for the specified metric. To filter the results, specify a statistic,
    /// period, or unit.
    /// 
    ///  
    /// <para>
    /// This operation retrieves only standard alarms that are based on the specified metric.
    /// It does not return alarms based on math expressions that use the specified metric,
    /// or composite alarms that use the specified metric.
    /// </para>
    /// </summary>
    public partial class DescribeAlarmsForMetricRequest : AmazonCloudWatchRequest
    {
        private List<Dimension> _dimensions = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;
        private string _extendedStatistic;
        private string _metricName;
        private string _awsNamespace;
        private int? _period;
        private Statistic _statistic;
        private StandardUnit _unit;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions associated with the metric. If the metric has any associated dimensions,
        /// you must specify them in order for the call to succeed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=30)]
        public List<Dimension> Dimensions
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
        /// Gets and sets the property ExtendedStatistic. 
        /// <para>
        /// The percentile statistic for the metric. Specify a value between p0.0 and p100.
        /// </para>
        /// </summary>
        public string ExtendedStatistic
        {
            get { return this._extendedStatistic; }
            set { this._extendedStatistic = value; }
        }

        // Check to see if ExtendedStatistic property is set
        internal bool IsSetExtendedStatistic()
        {
            return this._extendedStatistic != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The namespace of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The period, in seconds, over which the statistic is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic for the metric, other than percentiles. For percentile statistics, use
        /// <c>ExtendedStatistics</c>.
        /// </para>
        /// </summary>
        public Statistic Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit for the metric.
        /// </para>
        /// </summary>
        public StandardUnit Unit
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