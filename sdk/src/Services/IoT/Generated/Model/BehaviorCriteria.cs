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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private MachineLearningDetectionConfig _mlDetectionConfig;
        private StatisticalThreshold _statisticalThreshold;
        private MetricValue _value;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The operator that relates the thing measured (<c>metric</c>) to the criteria (containing
        /// a <c>value</c> or <c>statisticalThreshold</c>). Valid operators include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>string-list</c>: <c>in-set</c> and <c>not-in-set</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>number-list</c>: <c>in-set</c> and <c>not-in-set</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ip-address-list</c>: <c>in-cidr-set</c> and <c>not-in-cidr-set</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>number</c>: <c>less-than</c>, <c>less-than-equals</c>, <c>greater-than</c>, and
        /// <c>greater-than-equals</c> 
        /// </para>
        ///  </li> </ul>
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
        [AWSProperty(Min=1, Max=10)]
        public int? ConsecutiveDatapointsToAlarm
        {
            get { return this._consecutiveDatapointsToAlarm; }
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
        [AWSProperty(Min=1, Max=10)]
        public int? ConsecutiveDatapointsToClear
        {
            get { return this._consecutiveDatapointsToClear; }
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
        /// criteria that have a time dimension (for example, <c>NUM_MESSAGES_SENT</c>). For a
        /// <c>statisticalThreshhold</c> metric comparison, measurements from all devices are
        /// accumulated over this time duration before being used to calculate percentiles, and
        /// later, measurements from an individual device are also accumulated over this time
        /// duration before being given a percentile rank. Cannot be used with list-based metric
        /// datatypes.
        /// </para>
        /// </summary>
        public int? DurationSeconds
        {
            get { return this._durationSeconds; }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MlDetectionConfig. 
        /// <para>
        ///  The configuration of an ML Detect 
        /// </para>
        /// </summary>
        public MachineLearningDetectionConfig MlDetectionConfig
        {
            get { return this._mlDetectionConfig; }
            set { this._mlDetectionConfig = value; }
        }

        // Check to see if MlDetectionConfig property is set
        internal bool IsSetMlDetectionConfig()
        {
            return this._mlDetectionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property StatisticalThreshold. 
        /// <para>
        /// A statistical ranking (percentile)that indicates a threshold value by which a behavior
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
        /// The value to be compared with the <c>metric</c>.
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