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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Defines the auto-scaling configuration for an Express service. This determines how
    /// the service automatically adjusts the number of running tasks based on demand metrics
    /// such as CPU utilization, memory utilization, or request count per target.
    /// 
    ///  
    /// <para>
    /// Auto-scaling helps ensure your application can handle varying levels of traffic while
    /// optimizing costs by scaling down during low-demand periods. You can specify the minimum
    /// and maximum number of tasks, the scaling metric, and the target value for that metric.
    /// </para>
    /// </summary>
    public partial class ExpressGatewayScalingTarget
    {
        private ExpressGatewayServiceScalingMetric _autoScalingMetric;
        private int? _autoScalingTargetValue;
        private int? _maxTaskCount;
        private int? _minTaskCount;

        /// <summary>
        /// Gets and sets the property AutoScalingMetric. 
        /// <para>
        /// The metric used for auto-scaling decisions. The default metric used for an Express
        /// service is <c>CPUUtilization</c>.
        /// </para>
        /// </summary>
        public ExpressGatewayServiceScalingMetric AutoScalingMetric
        {
            get { return this._autoScalingMetric; }
            set { this._autoScalingMetric = value; }
        }

        // Check to see if AutoScalingMetric property is set
        internal bool IsSetAutoScalingMetric()
        {
            return this._autoScalingMetric != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingTargetValue. 
        /// <para>
        /// The target value for the auto-scaling metric. The default value for an Express service
        /// is 60.
        /// </para>
        /// </summary>
        public int? AutoScalingTargetValue
        {
            get { return this._autoScalingTargetValue; }
            set { this._autoScalingTargetValue = value; }
        }

        // Check to see if AutoScalingTargetValue property is set
        internal bool IsSetAutoScalingTargetValue()
        {
            return this._autoScalingTargetValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxTaskCount. 
        /// <para>
        /// The maximum number of tasks to run in the Express service.
        /// </para>
        /// </summary>
        public int? MaxTaskCount
        {
            get { return this._maxTaskCount; }
            set { this._maxTaskCount = value; }
        }

        // Check to see if MaxTaskCount property is set
        internal bool IsSetMaxTaskCount()
        {
            return this._maxTaskCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinTaskCount. 
        /// <para>
        /// The minimum number of tasks to run in the Express service.
        /// </para>
        /// </summary>
        public int? MinTaskCount
        {
            get { return this._minTaskCount; }
            set { this._minTaskCount = value; }
        }

        // Check to see if MinTaskCount property is set
        internal bool IsSetMinTaskCount()
        {
            return this._minTaskCount.HasValue; 
        }

    }
}