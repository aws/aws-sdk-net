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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The configuration for an Amazon EC2 Auto Scaling warm pool attached to an Amazon EKS
    /// managed node group. Warm pools maintain pre-initialized EC2 instances alongside your
    /// Auto Scaling group that have already completed the bootup initialization process and
    /// can be kept in a <c>Stopped</c>, <c>Running</c>, or <c>Hibernated</c> state.
    /// </summary>
    public partial class WarmPoolConfig
    {
        private bool? _enabled;
        private int? _maxGroupPreparedCapacity;
        private int? _minSize;
        private WarmPoolState _poolState;
        private bool? _reuseOnScaleIn;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to attach warm pools on the managed node group. Set to <c>true</c>
        /// to enable the warm pool, or <c>false</c> to disable and remove it. If not specified
        /// during an update, the current value is preserved.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxGroupPreparedCapacity. 
        /// <para>
        /// The maximum total number of instances across the warm pool and Auto Scaling group
        /// combined. This value controls the total prepared capacity available for your node
        /// group.
        /// </para>
        /// </summary>
        public int? MaxGroupPreparedCapacity
        {
            get { return this._maxGroupPreparedCapacity; }
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
        /// The minimum number of instances to maintain in the warm pool. Default: <c>0</c>. Size
        /// your warm pool based on scaling patterns to balance cost and availability. Start with
        /// 10-20% of expected peak capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MinSize
        {
            get { return this._minSize; }
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
        /// The desired state for warm pool instances. Default: <c>Stopped</c>. Valid values are
        /// <c>Stopped</c> (most cost-effective with EBS storage costs only), <c>Running</c> (fastest
        /// transition time with full EC2 costs), and <c>Hibernated</c> (balance between cost
        /// and speed, only supported on specific instance types). Warm pool instances in the
        /// <c>Hibernated</c> state are not supported with Bottlerocket AMIs.
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

        /// <summary>
        /// Gets and sets the property ReuseOnScaleIn. 
        /// <para>
        /// Indicates whether instances should return to the warm pool during scale-in events
        /// instead of being terminated. Default: <c>false</c>. Enable this to reduce costs by
        /// reusing instances. This feature is not supported for Bottlerocket AMIs.
        /// </para>
        /// </summary>
        public bool? ReuseOnScaleIn
        {
            get { return this._reuseOnScaleIn; }
            set { this._reuseOnScaleIn = value; }
        }

        // Check to see if ReuseOnScaleIn property is set
        internal bool IsSetReuseOnScaleIn()
        {
            return this._reuseOnScaleIn.HasValue; 
        }

    }
}