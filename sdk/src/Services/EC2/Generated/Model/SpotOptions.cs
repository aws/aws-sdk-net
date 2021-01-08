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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the configuration of Spot Instances in an EC2 Fleet.
    /// </summary>
    public partial class SpotOptions
    {
        private SpotAllocationStrategy _allocationStrategy;
        private SpotInstanceInterruptionBehavior _instanceInterruptionBehavior;
        private int? _instancePoolsToUseCount;
        private FleetSpotMaintenanceStrategies _maintenanceStrategies;
        private string _maxTotalPrice;
        private int? _minTargetCapacity;
        private bool? _singleAvailabilityZone;
        private bool? _singleInstanceType;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// Indicates how to allocate the target Spot Instance capacity across the Spot Instance
        /// pools specified by the EC2 Fleet.
        /// </para>
        ///  
        /// <para>
        /// If the allocation strategy is <code>lowest-price</code>, EC2 Fleet launches instances
        /// from the Spot Instance pools with the lowest price. This is the default allocation
        /// strategy.
        /// </para>
        ///  
        /// <para>
        /// If the allocation strategy is <code>diversified</code>, EC2 Fleet launches instances
        /// from all of the Spot Instance pools that you specify.
        /// </para>
        ///  
        /// <para>
        /// If the allocation strategy is <code>capacity-optimized</code>, EC2 Fleet launches
        /// instances from Spot Instance pools with optimal capacity for the number of instances
        /// that are launching.
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
        /// only when <b>AllocationStrategy</b> is set to <code>lowest-price</code>. EC2 Fleet
        /// selects the cheapest Spot pools and evenly allocates your target Spot capacity across
        /// the number of Spot pools that you specify.
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
        /// Gets and sets the property MaintenanceStrategies. 
        /// <para>
        /// The strategies for managing your workloads on your Spot Instances that will be interrupted.
        /// Currently only the capacity rebalance strategy is available.
        /// </para>
        /// </summary>
        public FleetSpotMaintenanceStrategies MaintenanceStrategies
        {
            get { return this._maintenanceStrategies; }
            set { this._maintenanceStrategies = value; }
        }

        // Check to see if MaintenanceStrategies property is set
        internal bool IsSetMaintenanceStrategies()
        {
            return this._maintenanceStrategies != null;
        }

        /// <summary>
        /// Gets and sets the property MaxTotalPrice. 
        /// <para>
        /// The maximum amount per hour for Spot Instances that you're willing to pay.
        /// </para>
        /// </summary>
        public string MaxTotalPrice
        {
            get { return this._maxTotalPrice; }
            set { this._maxTotalPrice = value; }
        }

        // Check to see if MaxTotalPrice property is set
        internal bool IsSetMaxTotalPrice()
        {
            return this._maxTotalPrice != null;
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
        /// Gets and sets the property SingleAvailabilityZone. 
        /// <para>
        /// Indicates that the fleet launches all Spot Instances into a single Availability Zone.
        /// Supported only for fleets of type <code>instant</code>.
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
        /// Indicates that the fleet uses a single instance type to launch all Spot Instances
        /// in the fleet. Supported only for fleets of type <code>instant</code>.
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