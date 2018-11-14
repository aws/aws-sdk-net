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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the configuration of Spot Instances in an EC2 Fleet request.
    /// </summary>
    public partial class SpotOptionsRequest
    {
        private SpotAllocationStrategy _allocationStrategy;
        private SpotInstanceInterruptionBehavior _instanceInterruptionBehavior;
        private int? _instancePoolsToUseCount;
        private int? _minTargetCapacity;
        private bool? _singleInstanceType;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// Indicates how to allocate the target capacity across the Spot pools specified by the
        /// Spot Fleet request. The default is <code>lowestPrice</code>.
        /// </para>
        /// </summary>
        public SpotAllocationStrategy AllocationStrategy
        {
            get { return this._allocationStrategy; }
            set { this._allocationStrategy = value; }
        }

        // Check to see if AllocationStrategy property is set
        internal bool IsSetAllocationStrategy()
        {
            return this._allocationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceInterruptionBehavior. 
        /// <para>
        /// The behavior when a Spot Instance is interrupted. The default is <code>terminate</code>.
        /// </para>
        /// </summary>
        public SpotInstanceInterruptionBehavior InstanceInterruptionBehavior
        {
            get { return this._instanceInterruptionBehavior; }
            set { this._instanceInterruptionBehavior = value; }
        }

        // Check to see if InstanceInterruptionBehavior property is set
        internal bool IsSetInstanceInterruptionBehavior()
        {
            return this._instanceInterruptionBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property InstancePoolsToUseCount. 
        /// <para>
        /// The number of Spot pools across which to allocate your target Spot capacity. Valid
        /// only when Spot <b>AllocationStrategy</b> is set to <code>lowest-price</code>. EC2
        /// Fleet selects the cheapest Spot pools and evenly allocates your target Spot capacity
        /// across the number of Spot pools that you specify.
        /// </para>
        /// </summary>
        public int InstancePoolsToUseCount
        {
            get { return this._instancePoolsToUseCount.GetValueOrDefault(); }
            set { this._instancePoolsToUseCount = value; }
        }

        // Check to see if InstancePoolsToUseCount property is set
        internal bool IsSetInstancePoolsToUseCount()
        {
            return this._instancePoolsToUseCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinTargetCapacity. 
        /// <para>
        /// The minimum target capacity for Spot Instances in the fleet. If the minimum target
        /// capacity is not reached, the fleet launches no instances.
        /// </para>
        /// </summary>
        public int MinTargetCapacity
        {
            get { return this._minTargetCapacity.GetValueOrDefault(); }
            set { this._minTargetCapacity = value; }
        }

        // Check to see if MinTargetCapacity property is set
        internal bool IsSetMinTargetCapacity()
        {
            return this._minTargetCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SingleInstanceType. 
        /// <para>
        /// Indicates that the fleet uses a single instance type to launch all Spot Instances
        /// in the fleet.
        /// </para>
        /// </summary>
        public bool SingleInstanceType
        {
            get { return this._singleInstanceType.GetValueOrDefault(); }
            set { this._singleInstanceType = value; }
        }

        // Check to see if SingleInstanceType property is set
        internal bool IsSetSingleInstanceType()
        {
            return this._singleInstanceType.HasValue; 
        }

    }
}