/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// The <code>Datapoint</code> data type encapsulates the statistical data that Amazon
    /// CloudWatch computes from metric data.
    /// </summary>
    public partial class Datapoint
    {
        private double? _average;
        private double? _maximum;
        private double? _minimum;
        private double? _sampleCount;
        private double? _sum;
        private DateTime? _timestamp;
        private StandardUnit _unit;

        /// <summary>
        /// Gets and sets the property Average. 
        /// <para>
        ///  The average of metric values that correspond to the datapoint. 
        /// </para>
        /// </summary>
        public double Average
        {
            get { return this._average.GetValueOrDefault(); }
            set { this._average = value; }
        }

        // Check to see if Average property is set
        internal bool IsSetAverage()
        {
            return this._average.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        ///  The maximum of the metric value used for the datapoint. 
        /// </para>
        /// </summary>
        public double Maximum
        {
            get { return this._maximum.GetValueOrDefault(); }
            set { this._maximum = value; }
        }

        // Check to see if Maximum property is set
        internal bool IsSetMaximum()
        {
            return this._maximum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        ///  The minimum metric value used for the datapoint. 
        /// </para>
        /// </summary>
        public double Minimum
        {
            get { return this._minimum.GetValueOrDefault(); }
            set { this._minimum = value; }
        }

        // Check to see if Minimum property is set
        internal bool IsSetMinimum()
        {
            return this._minimum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleCount. 
        /// <para>
        ///  The number of metric values that contributed to the aggregate value of this datapoint.
        /// 
        /// </para>
        /// </summary>
        public double SampleCount
        {
            get { return this._sampleCount.GetValueOrDefault(); }
            set { this._sampleCount = value; }
        }

        // Check to see if SampleCount property is set
        internal bool IsSetSampleCount()
        {
            return this._sampleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        ///  The sum of metric values used for the datapoint. 
        /// </para>
        /// </summary>
        public double Sum
        {
            get { return this._sum.GetValueOrDefault(); }
            set { this._sum = value; }
        }

        // Check to see if Sum property is set
        internal bool IsSetSum()
        {
            return this._sum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        ///  The time stamp used for the datapoint. Amazon CloudWatch uses Coordinated Universal
        /// Time (UTC) when returning time stamps, which do not accommodate seasonal adjustments
        /// such as daylight savings time. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp">Time
        /// stamps</a> in the <i>Amazon CloudWatch Developer Guide</i>. 
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        ///  The standard unit used for the datapoint. 
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