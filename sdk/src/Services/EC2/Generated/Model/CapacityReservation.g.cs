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
    /// Describes a Capacity Reservation.
    /// </summary>
    public partial class CapacityReservation
    {
        /// <summary>
        /// Gets and sets the property AdjustmentDetails. 
        /// <para>
        /// The configuration that the Capacity Reservation will have after the requested adjustment
        /// is applied.
        /// </para>
        /// </summary>
        public CapacityReservationAdjustmentDetails AdjustmentDetails { get; set; }

        /// <summary>
        /// Checks to see if the AdjustmentDetails property is set.
        /// </summary>
        internal bool IsSetAdjustmentDetails() => this.AdjustmentDetails != null;

        /// <summary>
        /// Gets and sets the property AdjustmentStatus. 
        /// <para>
        /// The status of the most recent modification to the Capacity Reservation. A Capacity
        /// Reservation can have one of the following adjustment statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>requested</c> - The modification was requested and is being processed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>applied</c> - The modification was applied to the Capacity Reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rejected</c> - The modification was not applied and the Capacity Reservation keeps
        /// its existing configuration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This field is not returned if the Capacity Reservation has never been modified.
        /// </para>
        /// </summary>
        public CapacityReservationAdjustmentStatus AdjustmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AdjustmentStatus property is set.
        /// </summary>
        internal bool IsSetAdjustmentStatus() => this.AdjustmentStatus != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the capacity is reserved.
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
        /// The ID of the Availability Zone in which the capacity is reserved.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The remaining capacity. Indicates the number of instances that can be launched in
        /// the Capacity Reservation.
        /// </para>
        /// </summary>
        public int? AvailableInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableInstanceCount property is set.
        /// </summary>
        internal bool IsSetAvailableInstanceCount() => this.AvailableInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityAllocations. 
        /// <para>
        /// Information about instance capacity usage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityAllocation> CapacityAllocations { get; set; } = AWSConfigs.InitializeCollections ? new List<CapacityAllocation>() : null;

        /// <summary>
        /// Checks to see if the CapacityAllocations property is set.
        /// </summary>
        internal bool IsSetCapacityAllocations() => this.CapacityAllocations != null && (this.CapacityAllocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityBlockId. 
        /// <para>
        /// The ID of the Capacity Block.
        /// </para>
        /// </summary>
        public string CapacityBlockId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockId property is set.
        /// </summary>
        internal bool IsSetCapacityBlockId() => this.CapacityBlockId != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string CapacityReservationArn { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationArn property is set.
        /// </summary>
        internal bool IsSetCapacityReservationArn() => this.CapacityReservationArn != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationFleetId. 
        /// <para>
        /// The ID of the Capacity Reservation Fleet to which the Capacity Reservation belongs.
        /// Only valid for Capacity Reservations that were created by a Capacity Reservation Fleet.
        /// </para>
        /// </summary>
        public string CapacityReservationFleetId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationFleetId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationFleetId() => this.CapacityReservationFleetId != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string CapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationId() => this.CapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property CommitmentInfo. 
        /// <para>
        /// Information about your commitment for a future-dated Capacity Reservation.
        /// </para>
        /// </summary>
        public CapacityReservationCommitmentInfo CommitmentInfo { get; set; }

        /// <summary>
        /// Checks to see if the CommitmentInfo property is set.
        /// </summary>
        internal bool IsSetCommitmentInfo() => this.CommitmentInfo != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time the Capacity Reservation was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property DeliveryPreference. 
        /// <para>
        /// The delivery method for a future-dated Capacity Reservation. <c>incremental</c> indicates
        /// that the requested capacity is delivered in addition to any running instances and
        /// reserved capacity that you have in your account at the requested date and time.
        /// </para>
        /// </summary>
        public CapacityReservationDeliveryPreference DeliveryPreference { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryPreference property is set.
        /// </summary>
        internal bool IsSetDeliveryPreference() => this.DeliveryPreference != null;

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether the Capacity Reservation supports EBS-optimized instances. This
        /// optimization provides dedicated throughput to Amazon EBS and an optimized configuration
        /// stack to provide optimal I/O performance. This optimization isn't available with all
        /// instance types. Additional usage charges apply when using an EBS- optimized instance.
        /// </para>
        /// </summary>
        public bool? EbsOptimized { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimized property is set.
        /// </summary>
        internal bool IsSetEbsOptimized() => this.EbsOptimized.HasValue;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time the Capacity Reservation expires. When a Capacity Reservation expires,
        /// the reserved capacity is released and you can no longer launch instances into it.
        /// The Capacity Reservation's state changes to <c>expired</c> when it reaches its end
        /// date and time.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property EndDateType. 
        /// <para>
        /// Indicates the way in which the Capacity Reservation ends. A Capacity Reservation can
        /// have one of the following end types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>unlimited</c> - The Capacity Reservation remains active until you explicitly cancel
        /// it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>limited</c> - The Capacity Reservation expires automatically at a specified date
        /// and time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndDateType EndDateType { get; set; }

        /// <summary>
        /// Checks to see if the EndDateType property is set.
        /// </summary>
        internal bool IsSetEndDateType() => this.EndDateType != null;

        /// <summary>
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        ///  <i>Deprecated.</i> 
        /// </para>
        /// </summary>
        public bool? EphemeralStorage { get; set; }

        /// <summary>
        /// Checks to see if the EphemeralStorage property is set.
        /// </summary>
        internal bool IsSetEphemeralStorage() => this.EphemeralStorage.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceMatchCriteria. 
        /// <para>
        /// Indicates the type of instance launches that the Capacity Reservation accepts. The
        /// options include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>open</c> - The Capacity Reservation accepts all instances that have matching attributes
        /// (instance type, platform, and Availability Zone). Instances that have matching attributes
        /// launch into the Capacity Reservation automatically without specifying any additional
        /// parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>targeted</c> - The Capacity Reservation only accepts instances that have matching
        /// attributes (instance type, platform, and Availability Zone), and explicitly target
        /// the Capacity Reservation. This ensures that only permitted instances can use the reserved
        /// capacity. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceMatchCriteria InstanceMatchCriteria { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMatchCriteria property is set.
        /// </summary>
        internal bool IsSetInstanceMatchCriteria() => this.InstanceMatchCriteria != null;

        /// <summary>
        /// Gets and sets the property InstancePlatform. 
        /// <para>
        /// The type of operating system for which the Capacity Reservation reserves capacity.
        /// </para>
        /// </summary>
        public CapacityReservationInstancePlatform InstancePlatform { get; set; }

        /// <summary>
        /// Checks to see if the InstancePlatform property is set.
        /// </summary>
        internal bool IsSetInstancePlatform() => this.InstancePlatform != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance for which the Capacity Reservation reserves capacity.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Interruptible. 
        /// <para>
        ///  Indicates whether this Capacity Reservation is interruptible, meaning instances may
        /// be terminated when the owner reclaims capacity. 
        /// </para>
        /// </summary>
        public bool? Interruptible { get; set; }

        /// <summary>
        /// Checks to see if the Interruptible property is set.
        /// </summary>
        internal bool IsSetInterruptible() => this.Interruptible.HasValue;

        /// <summary>
        /// Gets and sets the property InterruptibleCapacityAllocation. 
        /// <para>
        ///  Contains allocation details for interruptible reservations, including current allocated
        /// instances and target instance counts within the interruptibleCapacityAllocation object.
        /// 
        /// </para>
        /// </summary>
        public InterruptibleCapacityAllocation InterruptibleCapacityAllocation { get; set; }

        /// <summary>
        /// Checks to see if the InterruptibleCapacityAllocation property is set.
        /// </summary>
        internal bool IsSetInterruptibleCapacityAllocation() => this.InterruptibleCapacityAllocation != null;

        /// <summary>
        /// Gets and sets the property InterruptionInfo. 
        /// <para>
        ///  Information about the interruption configuration and association with the source
        /// reservation for interruptible Capacity Reservations. 
        /// </para>
        /// </summary>
        public InterruptionInfo InterruptionInfo { get; set; }

        /// <summary>
        /// Checks to see if the InterruptionInfo property is set.
        /// </summary>
        internal bool IsSetInterruptionInfo() => this.InterruptionInfo != null;

        /// <summary>
        /// Gets and sets the property LaunchStatus. <note> 
        /// <para>
        /// Only supported for UltraServers.
        /// </para>
        ///  </note> 
        /// <para>
        /// Indicates whether you can launch instances into the Capacity Reservation. A Capacity
        /// Reservation can have the following launch statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>launchable</c> - You can launch instances into the Capacity Reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unlaunchable</c> - You can't launch instances into the Capacity Reservation. For
        /// example, the Capacity Reservation is not active.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityReservationLaunchStatus LaunchStatus { get; set; }

        /// <summary>
        /// Checks to see if the LaunchStatus property is set.
        /// </summary>
        internal bool IsSetLaunchStatus() => this.LaunchStatus != null;

        /// <summary>
        /// Gets and sets the property OriginalStartDate. 
        /// <para>
        /// The start date that you originally requested for the Capacity Reservation, in the
        /// ISO8601 format in the UTC time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>). This value
        /// doesn't change when you push out the start date.
        /// </para>
        /// </summary>
        public DateTime? OriginalStartDate { get; set; }

        /// <summary>
        /// Checks to see if the OriginalStartDate property is set.
        /// </summary>
        internal bool IsSetOriginalStartDate() => this.OriginalStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost on which the Capacity Reservation was
        /// created.
        /// </para>
        /// </summary>
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the Capacity Reservation.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PlacementGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster placement group in which the Capacity
        /// Reservation was created. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/cr-cpg.html">
        /// Capacity Reservations for cluster placement groups</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string PlacementGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the PlacementGroupArn property is set.
        /// </summary>
        internal bool IsSetPlacementGroupArn() => this.PlacementGroupArn != null;

        /// <summary>
        /// Gets and sets the property ReservationType. 
        /// <para>
        /// The type of Capacity Reservation.
        /// </para>
        /// </summary>
        public CapacityReservationType ReservationType { get; set; }

        /// <summary>
        /// Checks to see if the ReservationType property is set.
        /// </summary>
        internal bool IsSetReservationType() => this.ReservationType != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date and time the Capacity Reservation was started.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the Capacity Reservation. A Capacity Reservation can be in one
        /// of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>active</c> - The capacity is available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>expired</c> - The Capacity Reservation expired automatically at the date and time
        /// specified in your reservation request. The reserved capacity is no longer available
        /// for your use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cancelled</c> - The Capacity Reservation was canceled. The reserved capacity is
        /// no longer available for your use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c> - The Capacity Reservation request was successful but the capacity
        /// provisioning is still pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c> - The Capacity Reservation request has failed. A request can fail due
        /// to request parameters that are not valid, capacity constraints, or instance limit
        /// constraints. You can view a failed request for 60 minutes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>scheduled</c> - (<i>Future-dated Capacity Reservations</i>) The future-dated Capacity
        /// Reservation request was approved and the Capacity Reservation is scheduled for delivery
        /// on the requested start date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>payment-pending</c> - (<i>Capacity Blocks</i>) The upfront payment has not been
        /// processed yet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>payment-failed</c> - (<i>Capacity Blocks</i>) The upfront payment was not processed
        /// in the 12-hour time frame. Your Capacity Block was released.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>assessing</c> - (<i>Future-dated Capacity Reservations</i>) Amazon EC2 is assessing
        /// your request for a future-dated Capacity Reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>delayed</c> - (<i>Future-dated Capacity Reservations</i>) Amazon EC2 encountered
        /// a delay in provisioning the requested future-dated Capacity Reservation. Amazon EC2
        /// is unable to deliver the requested capacity by the requested start date and time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unsupported</c> - (<i>Future-dated Capacity Reservations</i>) Amazon EC2 can't
        /// support the future-dated Capacity Reservation request due to capacity constraints.
        /// You can view unsupported requests for 30 days. The Capacity Reservation will not be
        /// delivered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cancelling</c> - (<i>Future-dated Capacity Reservations</i>) The Capacity Reservation
        /// is being cancelled. Capacity has been released but charges continue for the commitment
        /// wind-down period. The reservation transitions to <c>cancelled</c> when the wind-down
        /// completes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityReservationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the Capacity Reservation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Indicates the tenancy of the Capacity Reservation. A Capacity Reservation can have
        /// one of the following tenancy settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>default</c> - The Capacity Reservation is created on hardware that is shared with
        /// other Amazon Web Services accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dedicated</c> - The Capacity Reservation is created on single-tenant hardware
        /// that is dedicated to a single Amazon Web Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityReservationTenancy Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The total number of instances for which the Capacity Reservation reserves capacity.
        /// </para>
        /// </summary>
        public int? TotalInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalInstanceCount property is set.
        /// </summary>
        internal bool IsSetTotalInstanceCount() => this.TotalInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property UnusedReservationBillingOwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account to which billing of the unused capacity
        /// of the Capacity Reservation is assigned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string UnusedReservationBillingOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the UnusedReservationBillingOwnerId property is set.
        /// </summary>
        internal bool IsSetUnusedReservationBillingOwnerId() => this.UnusedReservationBillingOwnerId != null;

        /// <summary>
        /// Gets and sets the property ZeroSizePreference. 
        /// <para>
        ///  The zero-size preference configured for the interruptible Capacity Reservation. A
        /// value of <c>retain</c> keeps the interruptible Capacity Reservation active at zero
        /// capacity when you reduce its allocation to zero. A value of <c>default</c> cancels
        /// the interruptible Capacity Reservation when you reduce its allocation to zero. 
        /// </para>
        /// </summary>
        public ZeroSizePreference ZeroSizePreference { get; set; }

        /// <summary>
        /// Checks to see if the ZeroSizePreference property is set.
        /// </summary>
        internal bool IsSetZeroSizePreference() => this.ZeroSizePreference != null;
    }
}
