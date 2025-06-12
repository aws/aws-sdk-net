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
    /// Encapsulates the statistical data that CloudWatch computes from metric data.
    /// </summary>
    public partial class Datapoint
    {
        private double? _average;
        private Dictionary<string, double> _extendedStatistics = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;
        private double? _maximum;
        private double? _minimum;
        private double? _sampleCount;
        private double? _sum;
        private DateTime? _timestamp;
        private StandardUnit _unit;

        /// <summary>
        /// Gets and sets the property Average. 
        /// <para>
        /// The average of the metric values that correspond to the data point.
        /// </para>
        /// </summary>
        public double? Average
        {
            get { return this._average; }
            set { this._average = value; }
        }

        // Check to see if Average property is set
        internal bool IsSetAverage()
        {
            return this._average.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExtendedStatistics. 
        /// <para>
        /// The percentile statistic for the data point.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, double> ExtendedStatistics
        {
            get { return this._extendedStatistics; }
            set { this._extendedStatistics = value; }
        }

        // Check to see if ExtendedStatistics property is set
        internal bool IsSetExtendedStatistics()
        {
            return this._extendedStatistics != null && (this._extendedStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The maximum metric value for the data point.
        /// </para>
        /// </summary>
        public double? Maximum
        {
            get { return this._maximum; }
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
        /// The minimum metric value for the data point.
        /// </para>
        /// </summary>
        public double? Minimum
        {
            get { return this._minimum; }
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
        /// The number of metric values that contributed to the aggregate value of this data point.
        /// </para>
        /// </summary>
        public double? SampleCount
        {
            get { return this._sampleCount; }
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
        /// The sum of the metric values for the data point.
        /// </para>
        /// </summary>
        public double? Sum
        {
            get { return this._sum; }
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
        /// The time stamp used for the data point.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
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
        /// The standard unit for the data point.
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