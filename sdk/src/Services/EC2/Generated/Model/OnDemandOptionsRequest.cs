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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the configuration of On-Demand Instances in an EC2 Fleet.
    /// </summary>
    public partial class OnDemandOptionsRequest
    {
        private FleetOnDemandAllocationStrategy _allocationStrategy;
        private CapacityReservationOptionsRequest _capacityReservationOptions;
        private string _maxTotalPrice;
        private int? _minTargetCapacity;
        private bool? _singleAvailabilityZone;
        private bool? _singleInstanceType;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The strategy that determines the order of the launch template overrides to use in
        /// fulfilling On-Demand capacity.
        /// </para>
        ///  
        /// <para>
        ///  <c>lowest-price</c> - EC2 Fleet uses price to determine the order, launching the
        /// lowest price first.
        /// </para>
        ///  
        /// <para>
        ///  <c>prioritized</c> - EC2 Fleet uses the priority that you assigned to each launch
        /// template override, launching the highest priority first.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>lowest-price</c> 
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
        /// Gets and sets the property CapacityReservationOptions. 
        /// <para>
        /// The strategy for using unused Capacity Reservations for fulfilling On-Demand capacity.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
        /// </para>
        /// </summary>
        public CapacityReservationOptionsRequest CapacityReservationOptions
        {
            get { return this._capacityReservationOptions; }
            set { this._capacityReservationOptions = value; }
        }

        // Check to see if CapacityReservationOptions property is set
        internal bool IsSetCapacityReservationOptions()
        {
            return this._capacityReservationOptions != null;
        }

        /// <summary>
        /// Gets and sets the property MaxTotalPrice. 
        /// <para>
        /// The maximum amount per hour for On-Demand Instances that you're willing to pay.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your fleet includes T instances that are configured as <c>unlimited</c>, and if
        /// their average CPU usage exceeds the baseline utilization, you will incur a charge
        /// for surplus credits. The <c>MaxTotalPrice</c> does not account for surplus credits,
        /// and, if you use surplus credits, your final cost might be higher than what you specified
        /// for <c>MaxTotalPrice</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances-unlimited-mode-concepts.html#unlimited-mode-surplus-credits">Surplus
        /// credits can incur charges</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </note>
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
        /// The minimum target capacity for On-Demand Instances in the fleet. If this minimum
        /// capacity isn't reached, no instances are launched.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum value of <c>1000</c>. Supported only for fleets of type <c>instant</c>.
        /// </para>
        ///  
        /// <para>
        /// At least one of the following must be specified: <c>SingleAvailabilityZone</c> | <c>SingleInstanceType</c>
        /// 
        /// </para>
        /// </summary>
        public int? MinTargetCapacity
        {
            get { return this._minTargetCapacity; }
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
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
        /// </para>
        /// </summary>
        public bool? SingleAvailabilityZone
        {
            get { return this._singleAvailabilityZone; }
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
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
        /// </para>
        /// </summary>
        public bool? SingleInstanceType
        {
            get { return this._singleInstanceType; }
            set { this._singleInstanceType = value; }
        }

        // Check to see if SingleInstanceType property is set
        internal bool IsSetSingleInstanceType()
        {
            return this._singleInstanceType.HasValue; 
        }

    }
}