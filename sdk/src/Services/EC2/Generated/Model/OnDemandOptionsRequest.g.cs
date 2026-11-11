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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        public FleetOnDemandAllocationStrategy AllocationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the AllocationStrategy property is set.
        /// </summary>
        internal bool IsSetAllocationStrategy() => this.AllocationStrategy != null;

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
        public CapacityReservationOptionsRequest CapacityReservationOptions { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationOptions property is set.
        /// </summary>
        internal bool IsSetCapacityReservationOptions() => this.CapacityReservationOptions != null;

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
        public string MaxTotalPrice { get; set; }

        /// <summary>
        /// Checks to see if the MaxTotalPrice property is set.
        /// </summary>
        internal bool IsSetMaxTotalPrice() => this.MaxTotalPrice != null;

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
        public int? MinTargetCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MinTargetCapacity property is set.
        /// </summary>
        internal bool IsSetMinTargetCapacity() => this.MinTargetCapacity.HasValue;

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
        public bool? SingleAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the SingleAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetSingleAvailabilityZone() => this.SingleAvailabilityZone.HasValue;

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
        public bool? SingleInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the SingleInstanceType property is set.
        /// </summary>
        internal bool IsSetSingleInstanceType() => this.SingleInstanceType.HasValue;
    }
}
