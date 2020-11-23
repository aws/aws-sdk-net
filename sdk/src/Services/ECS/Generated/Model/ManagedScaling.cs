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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The managed scaling settings for the Auto Scaling group capacity provider.
    /// 
    ///  
    /// <para>
    /// When managed scaling is enabled, Amazon ECS manages the scale-in and scale-out actions
    /// of the Auto Scaling group. Amazon ECS manages a target tracking scaling policy using
    /// an Amazon ECS-managed CloudWatch metric with the specified <code>targetCapacity</code>
    /// value as the target value for the metric. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/asg-capacity-providers.html#asg-capacity-providers-managed-scaling">Using
    /// Managed Scaling</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If managed scaling is disabled, the user must manage the scaling of the Auto Scaling
    /// group.
    /// </para>
    /// </summary>
    public partial class ManagedScaling
    {
        private int? _instanceWarmupPeriod;
        private int? _maximumScalingStepSize;
        private int? _minimumScalingStepSize;
        private ManagedScalingStatus _status;
        private int? _targetCapacity;

        /// <summary>
        /// Gets and sets the property InstanceWarmupPeriod. 
        /// <para>
        /// The period of time, in seconds, after a newly launched Amazon EC2 instance can contribute
        /// to CloudWatch metrics for Auto Scaling group. If this parameter is omitted, the default
        /// value of <code>300</code> seconds is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public int InstanceWarmupPeriod
        {
            get { return this._instanceWarmupPeriod.GetValueOrDefault(); }
            set { this._instanceWarmupPeriod = value; }
        }

        // Check to see if InstanceWarmupPeriod property is set
        internal bool IsSetInstanceWarmupPeriod()
        {
            return this._instanceWarmupPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumScalingStepSize. 
        /// <para>
        /// The maximum number of container instances that Amazon ECS will scale in or scale out
        /// at one time. If this parameter is omitted, the default value of <code>10000</code>
        /// is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int MaximumScalingStepSize
        {
            get { return this._maximumScalingStepSize.GetValueOrDefault(); }
            set { this._maximumScalingStepSize = value; }
        }

        // Check to see if MaximumScalingStepSize property is set
        internal bool IsSetMaximumScalingStepSize()
        {
            return this._maximumScalingStepSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumScalingStepSize. 
        /// <para>
        /// The minimum number of container instances that Amazon ECS will scale in or scale out
        /// at one time. If this parameter is omitted, the default value of <code>1</code> is
        /// used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int MinimumScalingStepSize
        {
            get { return this._minimumScalingStepSize.GetValueOrDefault(); }
            set { this._minimumScalingStepSize = value; }
        }

        // Check to see if MinimumScalingStepSize property is set
        internal bool IsSetMinimumScalingStepSize()
        {
            return this._minimumScalingStepSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether or not to enable managed scaling for the capacity provider.
        /// </para>
        /// </summary>
        public ManagedScalingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCapacity. 
        /// <para>
        /// The target capacity value for the capacity provider. The specified value must be greater
        /// than <code>0</code> and less than or equal to <code>100</code>. A value of <code>100</code>
        /// will result in the Amazon EC2 instances in your Auto Scaling group being completely
        /// utilized.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int TargetCapacity
        {
            get { return this._targetCapacity.GetValueOrDefault(); }
            set { this._targetCapacity = value; }
        }

        // Check to see if TargetCapacity property is set
        internal bool IsSetTargetCapacity()
        {
            return this._targetCapacity.HasValue; 
        }

    }
}