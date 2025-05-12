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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A summary of the metrics of a trial component.
    /// </summary>
    public partial class TrialComponentMetricSummary
    {
        private double? _avg;
        private int? _count;
        private double? _last;
        private double? _max;
        private string _metricName;
        private double? _min;
        private string _sourceArn;
        private double? _stdDev;
        private DateTime? _timeStamp;

        /// <summary>
        /// Gets and sets the property Avg. 
        /// <para>
        /// The average value of the metric.
        /// </para>
        /// </summary>
        public double? Avg
        {
            get { return this._avg; }
            set { this._avg = value; }
        }

        // Check to see if Avg property is set
        internal bool IsSetAvg()
        {
            return this._avg.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of samples used to generate the metric.
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Last. 
        /// <para>
        /// The most recent value of the metric.
        /// </para>
        /// </summary>
        public double? Last
        {
            get { return this._last; }
            set { this._last = value; }
        }

        // Check to see if Last property is set
        internal bool IsSetLast()
        {
            return this._last.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum value of the metric.
        /// </para>
        /// </summary>
        public double? Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric.
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
        /// Gets and sets the property Min. 
        /// <para>
        /// The minimum value of the metric.
        /// </para>
        /// </summary>
        public double? Min
        {
            get { return this._min; }
            set { this._min = value; }
        }

        // Check to see if Min property is set
        internal bool IsSetMin()
        {
            return this._min.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StdDev. 
        /// <para>
        /// The standard deviation of the metric.
        /// </para>
        /// </summary>
        public double? StdDev
        {
            get { return this._stdDev; }
            set { this._stdDev = value; }
        }

        // Check to see if StdDev property is set
        internal bool IsSetStdDev()
        {
            return this._stdDev.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeStamp. 
        /// <para>
        /// When the metric was last updated.
        /// </para>
        /// </summary>
        public DateTime? TimeStamp
        {
            get { return this._timeStamp; }
            set { this._timeStamp = value; }
        }

        // Check to see if TimeStamp property is set
        internal bool IsSetTimeStamp()
        {
            return this._timeStamp.HasValue; 
        }

    }
}