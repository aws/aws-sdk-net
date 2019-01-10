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
    /// The allocation strategy of On-Demand Instances in an EC2 Fleet.
    /// </summary>
    public partial class OnDemandOptionsRequest
    {
        private FleetOnDemandAllocationStrategy _allocationStrategy;
        private int? _minTargetCapacity;
        private bool? _singleAvailabilityZone;
        private bool? _singleInstanceType;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The order of the launch template overrides to use in fulfilling On-Demand capacity.
        /// If you specify <code>lowest-price</code>, EC2 Fleet uses price to determine the order,
        /// launching the lowest price first. If you specify <code>prioritized</code>, EC2 Fleet
        /// uses the priority that you assigned to each launch template override, launching the
        /// highest priority first. If you do not specify a value, EC2 Fleet defaults to <code>lowest-price</code>.
        /// </para>
        /// </summary>
        public FleetOnDemandAllocationStrategy AllocationStrategy
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
        /// Gets and sets the property MinTargetCapacity. 
        /// <para>
        /// The minimum target capacity for On-Demand Instances in the fleet. If the minimum target
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
        /// Gets and sets the property SingleAvailabilityZone. 
        /// <para>
        /// Indicates that the fleet launches all On-Demand Instances into a single Availability
        /// Zone.
        /// </para>
        /// </summary>
        public bool SingleAvailabilityZone
        {
            get { return this._singleAvailabilityZone.GetValueOrDefault(); }
            set { this._singleAvailabilityZone = value; }
        }

        // Check to see if SingleAvailabilityZone property is set
        internal bool IsSetSingleAvailabilityZone()
        {
            return this._singleAvailabilityZone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SingleInstanceType. 
        /// <para>
        /// Indicates that the fleet uses a single instance type to launch all On-Demand Instances
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