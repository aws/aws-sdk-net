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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
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
namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Represents a predictive scaling policy configuration. Predictive scaling is supported
    /// on Amazon ECS services.
    /// </summary>
    public partial class PredictiveScalingPolicyConfiguration
    {
        private PredictiveScalingMaxCapacityBreachBehavior _maxCapacityBreachBehavior;
        private int? _maxCapacityBuffer;
        private List<PredictiveScalingMetricSpecification> _metricSpecifications = AWSConfigs.InitializeCollections ? new List<PredictiveScalingMetricSpecification>() : null;
        private PredictiveScalingMode _mode;
        private int? _schedulingBufferTime;

        /// <summary>
        /// Gets and sets the property MaxCapacityBreachBehavior. 
        /// <para>
        ///  Defines the behavior that should be applied if the forecast capacity approaches or
        /// exceeds the maximum capacity. Defaults to <c>HonorMaxCapacity</c> if not specified.
        /// 
        /// </para>
        /// </summary>
        public PredictiveScalingMaxCapacityBreachBehavior MaxCapacityBreachBehavior
        {
            get { return this._maxCapacityBreachBehavior; }
            set { this._maxCapacityBreachBehavior = value; }
        }

        // Check to see if MaxCapacityBreachBehavior property is set
        internal bool IsSetMaxCapacityBreachBehavior()
        {
            return this._maxCapacityBreachBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCapacityBuffer. 
        /// <para>
        ///  The size of the capacity buffer to use when the forecast capacity is close to or
        /// exceeds the maximum capacity. The value is specified as a percentage relative to the
        /// forecast capacity. For example, if the buffer is 10, this means a 10 percent buffer,
        /// such that if the forecast capacity is 50, and the maximum capacity is 40, then the
        /// effective maximum capacity is 55. 
        /// </para>
        ///  
        /// <para>
        /// Required if the <c>MaxCapacityBreachBehavior</c> property is set to <c>IncreaseMaxCapacity</c>,
        /// and cannot be used otherwise.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? MaxCapacityBuffer
        {
            get { return this._maxCapacityBuffer; }
            set { this._maxCapacityBuffer = value; }
        }

        // Check to see if MaxCapacityBuffer property is set
        internal bool IsSetMaxCapacityBuffer()
        {
            return this._maxCapacityBuffer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricSpecifications. 
        /// <para>
        ///  This structure includes the metrics and target utilization to use for predictive
        /// scaling. 
        /// </para>
        ///  
        /// <para>
        /// This is an array, but we currently only support a single metric specification. That
        /// is, you can specify a target value and a single metric pair, or a target value and
        /// one scaling metric and one load metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PredictiveScalingMetricSpecification> MetricSpecifications
        {
            get { return this._metricSpecifications; }
            set { this._metricSpecifications = value; }
        }

        // Check to see if MetricSpecifications property is set
        internal bool IsSetMetricSpecifications()
        {
            return this._metricSpecifications != null && (this._metricSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        ///  The predictive scaling mode. Defaults to <c>ForecastOnly</c> if not specified. 
        /// </para>
        /// </summary>
        public PredictiveScalingMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property SchedulingBufferTime. 
        /// <para>
        ///  The amount of time, in seconds, that the start time can be advanced. 
        /// </para>
        ///  
        /// <para>
        /// The value must be less than the forecast interval duration of 3600 seconds (60 minutes).
        /// Defaults to 300 seconds if not specified. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int? SchedulingBufferTime
        {
            get { return this._schedulingBufferTime; }
            set { this._schedulingBufferTime = value; }
        }

        // Check to see if SchedulingBufferTime property is set
        internal bool IsSetSchedulingBufferTime()
        {
            return this._schedulingBufferTime.HasValue; 
        }

    }
}