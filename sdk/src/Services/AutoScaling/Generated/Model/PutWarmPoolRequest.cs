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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutWarmPool operation.
    /// Creates or updates a warm pool for the specified Auto Scaling group. A warm pool is
    /// a pool of pre-initialized EC2 instances that sits alongside the Auto Scaling group.
    /// Whenever your application needs to scale out, the Auto Scaling group can draw on the
    /// warm pool to meet its new desired capacity. For more information and example configurations,
    /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
    /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// 
    ///  
    /// <para>
    /// This operation must be called from the Region in which the Auto Scaling group was
    /// created. This operation cannot be called on an Auto Scaling group that has a mixed
    /// instances policy or a launch template or launch configuration that requests Spot Instances.
    /// </para>
    ///  
    /// <para>
    /// You can view the instances in the warm pool using the <a>DescribeWarmPool</a> API
    /// call. If you are no longer using a warm pool, you can delete it by calling the <a>DeleteWarmPool</a>
    /// API.
    /// </para>
    /// </summary>
    public partial class PutWarmPoolRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private InstanceReusePolicy _instanceReusePolicy;
        private int? _maxGroupPreparedCapacity;
        private int? _minSize;
        private WarmPoolState _poolState;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceReusePolicy. 
        /// <para>
        /// Indicates whether instances in the Auto Scaling group can be returned to the warm
        /// pool on scale in. The default is to terminate instances in the Auto Scaling group
        /// when the group scales in.
        /// </para>
        /// </summary>
        public InstanceReusePolicy InstanceReusePolicy
        {
            get { return this._instanceReusePolicy; }
            set { this._instanceReusePolicy = value; }
        }

        // Check to see if InstanceReusePolicy property is set
        internal bool IsSetInstanceReusePolicy()
        {
            return this._instanceReusePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property MaxGroupPreparedCapacity. 
        /// <para>
        /// Specifies the maximum number of instances that are allowed to be in the warm pool
        /// or in any state except <code>Terminated</code> for the Auto Scaling group. This is
        /// an optional property. Specify it only if you do not want the warm pool size to be
        /// determined by the difference between the group's maximum capacity and its desired
        /// capacity. 
        /// </para>
        ///  <important> 
        /// <para>
        /// If a value for <code>MaxGroupPreparedCapacity</code> is not specified, Amazon EC2
        /// Auto Scaling launches and maintains the difference between the group's maximum capacity
        /// and its desired capacity. If you specify a value for <code>MaxGroupPreparedCapacity</code>,
        /// Amazon EC2 Auto Scaling uses the difference between the <code>MaxGroupPreparedCapacity</code>
        /// and the desired capacity instead. 
        /// </para>
        ///  
        /// <para>
        /// The size of the warm pool is dynamic. Only when <code>MaxGroupPreparedCapacity</code>
        /// and <code>MinSize</code> are set to the same value does the warm pool have an absolute
        /// size.
        /// </para>
        ///  </important> 
        /// <para>
        /// If the desired capacity of the Auto Scaling group is higher than the <code>MaxGroupPreparedCapacity</code>,
        /// the capacity of the warm pool is 0, unless you specify a value for <code>MinSize</code>.
        /// To remove a value that you previously set, include the property but specify -1 for
        /// the value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1)]
        public int MaxGroupPreparedCapacity
        {
            get { return this._maxGroupPreparedCapacity.GetValueOrDefault(); }
            set { this._maxGroupPreparedCapacity = value; }
        }

        // Check to see if MaxGroupPreparedCapacity property is set
        internal bool IsSetMaxGroupPreparedCapacity()
        {
            return this._maxGroupPreparedCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// Specifies the minimum number of instances to maintain in the warm pool. This helps
        /// you to ensure that there is always a certain number of warmed instances available
        /// to handle traffic spikes. Defaults to 0 if not specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PoolState. 
        /// <para>
        /// Sets the instance state to transition to after the lifecycle actions are complete.
        /// Default is <code>Stopped</code>.
        /// </para>
        /// </summary>
        public WarmPoolState PoolState
        {
            get { return this._poolState; }
            set { this._poolState = value; }
        }

        // Check to see if PoolState property is set
        internal bool IsSetPoolState()
        {
            return this._poolState != null;
        }

    }
}