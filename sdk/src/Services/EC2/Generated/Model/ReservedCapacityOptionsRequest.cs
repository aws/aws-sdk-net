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
    /// Defines EC2 Fleet preferences for utilizing reserved capacity when <c>DefaultTargetCapacityType</c>
    /// is set to <c>reserved-capacity</c>. EC2 Fleet can fulfill reserved capacity using
    /// On-Demand Capacity Reservations, Capacity Blocks for ML, and interruptible Capacity
    /// Reservations.
    /// 
    ///  <note> 
    /// <para>
    /// This configuration can only be used if the EC2 Fleet is of type <c>instant</c>.
    /// </para>
    ///  </note> 
    /// <para>
    /// When you specify <c>ReservedCapacityOptions</c>, you must also set <c>DefaultTargetCapacityType</c>
    /// to <c>reserved-capacity</c> in the <c>TargetCapacitySpecification</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information about interruptible Capacity Reservations, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-launch-instances-interruptible-cr-walkthrough.html">Launch
    /// instances into an interruptible Capacity Reservation</a> in the <i>Amazon EC2 User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class ReservedCapacityOptionsRequest
    {
        private ReservedCapacityAllocationStrategy _allocationStrategy;
        private FleetCapacityReservationTargetRequest _capacityReservationTarget;
        private List<string> _reservationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ReservedCapacityFallbackOptionsRequest _reservedCapacityFallbackOptions;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The strategy that determines the order in which EC2 Fleet launches instances across
        /// the reservation types that you specify. The only supported value is <c>prioritized</c>,
        /// which launches instances in the priority order that you specify in your launch template
        /// overrides. If you don't specify an allocation strategy, instances are launched in
        /// a random order.
        /// </para>
        /// </summary>
        public ReservedCapacityAllocationStrategy AllocationStrategy
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
        /// Gets and sets the property CapacityReservationTarget. 
        /// <para>
        /// The Capacity Reservations or Capacity Reservation Resource Groups to use for fulfilling
        /// the EC2 Fleet request. You can specify Capacity Reservation IDs or a Capacity Reservation
        /// Resource Group ARN, but not both.
        /// </para>
        /// </summary>
        public FleetCapacityReservationTargetRequest CapacityReservationTarget
        {
            get { return this._capacityReservationTarget; }
            set { this._capacityReservationTarget = value; }
        }

        // Check to see if CapacityReservationTarget property is set
        internal bool IsSetCapacityReservationTarget()
        {
            return this._capacityReservationTarget != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationTypes. 
        /// <para>
        /// The types of Capacity Reservations to use for fulfilling the EC2 Fleet request. This
        /// is an ordered list: EC2 Fleet attempts to launch instances into each Capacity Reservation
        /// type in the order that you specify them before moving on to the next type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReservationTypes
        {
            get { return this._reservationTypes; }
            set { this._reservationTypes = value; }
        }

        // Check to see if ReservationTypes property is set
        internal bool IsSetReservationTypes()
        {
            return this._reservationTypes != null && (this._reservationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReservedCapacityFallbackOptions. 
        /// <para>
        /// The fallback behavior for the EC2 Fleet when there is not enough reserved capacity
        /// available to meet the target capacity. This member takes a <c>ReservedCapacityFallbackOptionsRequest</c>
        /// structure, in which you set <c>MarketTypes</c> to the instance purchasing options
        /// to fall back to.
        /// </para>
        /// </summary>
        public ReservedCapacityFallbackOptionsRequest ReservedCapacityFallbackOptions
        {
            get { return this._reservedCapacityFallbackOptions; }
            set { this._reservedCapacityFallbackOptions = value; }
        }

        // Check to see if ReservedCapacityFallbackOptions property is set
        internal bool IsSetReservedCapacityFallbackOptions()
        {
            return this._reservedCapacityFallbackOptions != null;
        }

    }
}