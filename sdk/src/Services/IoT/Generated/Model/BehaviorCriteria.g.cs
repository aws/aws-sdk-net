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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The criteria by which the behavior is determined to be normal.
    /// </summary>
    public partial class BehaviorCriteria
    {
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
        public ComparisonOperator ComparisonOperator { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonOperator property is set.
        /// </summary>
        internal bool IsSetComparisonOperator() => this.ComparisonOperator != null;

        /// <summary>
        /// Gets and sets the property ConsecutiveDatapointsToAlarm. 
        /// <para>
        /// If a device is in violation of the behavior for the specified number of consecutive
        /// datapoints, an alarm occurs. If not specified, the default is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? ConsecutiveDatapointsToAlarm { get; set; }

        /// <summary>
        /// Checks to see if the ConsecutiveDatapointsToAlarm property is set.
        /// </summary>
        internal bool IsSetConsecutiveDatapointsToAlarm() => this.ConsecutiveDatapointsToAlarm.HasValue;

        /// <summary>
        /// Gets and sets the property ConsecutiveDatapointsToClear. 
        /// <para>
        /// If an alarm has occurred and the offending device is no longer in violation of the
        /// behavior for the specified number of consecutive datapoints, the alarm is cleared.
        /// If not specified, the default is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? ConsecutiveDatapointsToClear { get; set; }

        /// <summary>
        /// Checks to see if the ConsecutiveDatapointsToClear property is set.
        /// </summary>
        internal bool IsSetConsecutiveDatapointsToClear() => this.ConsecutiveDatapointsToClear.HasValue;

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
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MlDetectionConfig. 
        /// <para>
        ///  The configuration of an ML Detect 
        /// </para>
        /// </summary>
        public MachineLearningDetectionConfig MlDetectionConfig { get; set; }

        /// <summary>
        /// Checks to see if the MlDetectionConfig property is set.
        /// </summary>
        internal bool IsSetMlDetectionConfig() => this.MlDetectionConfig != null;

        /// <summary>
        /// Gets and sets the property StatisticalThreshold. 
        /// <para>
        /// A statistical ranking (percentile)that indicates a threshold value by which a behavior
        /// is determined to be in compliance or in violation of the behavior.
        /// </para>
        /// </summary>
        public StatisticalThreshold StatisticalThreshold { get; set; }

        /// <summary>
        /// Checks to see if the StatisticalThreshold property is set.
        /// </summary>
        internal bool IsSetStatisticalThreshold() => this.StatisticalThreshold != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to be compared with the <c>metric</c>.
        /// </para>
        /// </summary>
        public MetricValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
