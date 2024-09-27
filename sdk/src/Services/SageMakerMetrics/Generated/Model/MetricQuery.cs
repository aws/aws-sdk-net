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
 * Do not modify this file. This file is generated from the sagemaker-metrics-2022-09-30.normal.json service model.
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
namespace Amazon.SageMakerMetrics.Model
{
    /// <summary>
    /// Specifies a query to retrieve training metrics from SageMaker.
    /// </summary>
    public partial class MetricQuery
    {
        private long? _end;
        private string _metricName;
        private MetricStatistic _metricStat;
        private Period _period;
        private string _resourceArn;
        private long? _start;
        private XAxisType _xAxisType;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end time of metrics to retrieve.
        /// </para>
        /// </summary>
        public long? End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric to retrieve.
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
        /// Gets and sets the property MetricStat. 
        /// <para>
        /// The metrics stat type of metrics to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricStatistic MetricStat
        {
            get { return this._metricStat; }
            set { this._metricStat = value; }
        }

        // Check to see if MetricStat property is set
        internal bool IsSetMetricStat()
        {
            return this._metricStat != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The time period of metrics to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Period Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the SageMaker resource to retrieve metrics for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The start time of metrics to retrieve.
        /// </para>
        /// </summary>
        public long? Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property XAxisType. 
        /// <para>
        /// The x-axis type of metrics to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public XAxisType XAxisType
        {
            get { return this._xAxisType; }
            set { this._xAxisType = value; }
        }

        // Check to see if XAxisType property is set
        internal bool IsSetXAxisType()
        {
            return this._xAxisType != null;
        }

    }
}