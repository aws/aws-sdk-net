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
    /// Container for the parameters to the CreateCapacityReservationFleet operation. Creates
    /// a Capacity Reservation Fleet. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/work-with-cr-fleets.html#create-crfleet">Create
    /// a Capacity Reservation Fleet</a> in the <i>Amazon EC2 User Guide</i>.
    /// </summary>
    public partial class CreateCapacityReservationFleetRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The strategy used by the Capacity Reservation Fleet to determine which of the specified
        /// instance types to use. Currently, only the <c>prioritized</c> allocation strategy
        /// is supported. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/crfleet-concepts.html#allocation-strategy">
        /// Allocation strategy</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>prioritized</c> 
        /// </para>
        /// </summary>
        public string AllocationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the AllocationStrategy property is set.
        /// </summary>
        internal bool IsSetAllocationStrategy() => this.AllocationStrategy != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensure
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time at which the Capacity Reservation Fleet expires. When the Capacity
        /// Reservation Fleet expires, its state changes to <c>expired</c> and all of the Capacity
        /// Reservations in the Fleet expire.
        /// </para>
        ///  
        /// <para>
        /// The Capacity Reservation Fleet expires within an hour after the specified time. For
        /// example, if you specify <c>5/31/2019</c>, <c>13:30:55</c>, the Capacity Reservation
        /// Fleet is guaranteed to expire between <c>13:30:55</c> and <c>14:30:55</c> on <c>5/31/2019</c>.
        /// 
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceMatchCriteria. 
        /// <para>
        /// Indicates the type of instance launches that the Capacity Reservation Fleet accepts.
        /// All Capacity Reservations in the Fleet inherit this instance matching criteria.
        /// </para>
        ///  
        /// <para>
        /// Currently, Capacity Reservation Fleets support <c>open</c> instance matching criteria
        /// only. This means that instances that have matching attributes (instance type, platform,
        /// and Availability Zone) run in the Capacity Reservations automatically. Instances do
        /// not need to explicitly target a Capacity Reservation Fleet to use its reserved capacity.
        /// </para>
        /// </summary>
        public FleetInstanceMatchCriteria InstanceMatchCriteria { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMatchCriteria property is set.
        /// </summary>
        internal bool IsSetInstanceMatchCriteria() => this.InstanceMatchCriteria != null;

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// </summary>
        public InstanceRequirementsRequest InstanceRequirements { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRequirements property is set.
        /// </summary>
        internal bool IsSetInstanceRequirements() => this.InstanceRequirements != null;

        /// <summary>
        /// Gets and sets the property InstanceTypeSpecifications. 
        /// <para>
        /// Information about the instance types for which to reserve the capacity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReservationFleetInstanceSpecification> InstanceTypeSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<ReservationFleetInstanceSpecification>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypeSpecifications property is set.
        /// </summary>
        internal bool IsSetInstanceTypeSpecifications() => this.InstanceTypeSpecifications != null && (this.InstanceTypeSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the Capacity Reservation Fleet. The tags are automatically assigned
        /// to the Capacity Reservations in the Fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Indicates the tenancy of the Capacity Reservation Fleet. All Capacity Reservations
        /// in the Fleet inherit this tenancy. The Capacity Reservation Fleet can have one of
        /// the following tenancy settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>default</c> - The Capacity Reservation Fleet is created on hardware that is shared
        /// with other Amazon Web Services accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dedicated</c> - The Capacity Reservations are created on single-tenant hardware
        /// that is dedicated to a single Amazon Web Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FleetCapacityReservationTenancy Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;

        /// <summary>
        /// Gets and sets the property TotalTargetCapacity. 
        /// <para>
        /// The total number of capacity units to be reserved by the Capacity Reservation Fleet.
        /// This value, together with the instance type weights that you assign to each instance
        /// type used by the Fleet determine the number of instances for which the Fleet reserves
        /// capacity. Both values are based on units that make sense for your workload. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/crfleet-concepts.html#target-capacity">Total
        /// target capacity</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalTargetCapacity { get; set; }

        /// <summary>
        /// Checks to see if the TotalTargetCapacity property is set.
        /// </summary>
        internal bool IsSetTotalTargetCapacity() => this.TotalTargetCapacity.HasValue;
    }
}
