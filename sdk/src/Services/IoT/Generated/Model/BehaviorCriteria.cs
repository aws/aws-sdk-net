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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The criteria by which the behavior is determined to be normal.
    /// </summary>
    public partial class BehaviorCriteria
    {
        private ComparisonOperator _comparisonOperator;
        private int? _consecutiveDatapointsToAlarm;
        private int? _consecutiveDatapointsToClear;
        private int? _durationSeconds;
        private StatisticalThreshold _statisticalThreshold;
        private MetricValue _value;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The operator that relates the thing measured (<code>metric</code>) to the criteria
        /// (containing a <code>value</code> or <code>statisticalThreshold</code>).
        /// </para>
        /// </summary>
        public ComparisonOperator ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property ConsecutiveDatapointsToAlarm. 
        /// <para>
        /// If a device is in violation of the behavior for the specified number of consecutive
        /// datapoints, an alarm occurs. If not specified, the default is 1.
        /// </para>
        /// </summary>
        public int ConsecutiveDatapointsToAlarm
        {
            get { return this._consecutiveDatapointsToAlarm.GetValueOrDefault(); }
            set { this._consecutiveDatapointsToAlarm = value; }
        }

        // Check to see if ConsecutiveDatapointsToAlarm property is set
        internal bool IsSetConsecutiveDatapointsToAlarm()
        {
            return this._consecutiveDatapointsToAlarm.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsecutiveDatapointsToClear. 
        /// <para>
        /// If an alarm has occurred and the offending device is no longer in violation of the
        /// behavior for the specified number of consecutive datapoints, the alarm is cleared.
        /// If not specified, the default is 1.
        /// </para>
        /// </summary>
        public int ConsecutiveDatapointsToClear
        {
            get { return this._consecutiveDatapointsToClear.GetValueOrDefault(); }
            set { this._consecutiveDatapointsToClear = value; }
        }

        // Check to see if ConsecutiveDatapointsToClear property is set
        internal bool IsSetConsecutiveDatapointsToClear()
        {
            return this._consecutiveDatapointsToClear.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// Use this to specify the time duration over which the behavior is evaluated, for those
        /// criteria which have a time dimension (for example, <code>NUM_MESSAGES_SENT</code>).
        /// For a <code>statisticalThreshhold</code> metric comparison, measurements from all
        /// devices are accumulated over this time duration before being used to calculate percentiles,
        /// and later, measurements from an individual device are also accumulated over this time
        /// duration before being given a percentile rank.
        /// </para>
        /// </summary>
        public int DurationSeconds
        {
            get { return this._durationSeconds.GetValueOrDefault(); }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatisticalThreshold. 
        /// <para>
        /// A statistical ranking (percentile) which indicates a threshold value by which a behavior
        /// is determined to be in compliance or in violation of the behavior.
        /// </para>
        /// </summary>
        public StatisticalThreshold StatisticalThreshold
        {
            get { return this._statisticalThreshold; }
            set { this._statisticalThreshold = value; }
        }

        // Check to see if StatisticalThreshold property is set
        internal bool IsSetStatisticalThreshold()
        {
            return this._statisticalThreshold != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to be compared with the <code>metric</code>.
        /// </para>
        /// </summary>
        public MetricValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}