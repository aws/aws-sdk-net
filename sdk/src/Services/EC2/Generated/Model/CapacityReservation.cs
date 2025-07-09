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
    /// Describes a Capacity Reservation.
    /// </summary>
    public partial class CapacityReservation
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private int? _availableInstanceCount;
        private List<CapacityAllocation> _capacityAllocations = AWSConfigs.InitializeCollections ? new List<CapacityAllocation>() : null;
        private string _capacityBlockId;
        private string _capacityReservationArn;
        private string _capacityReservationFleetId;
        private string _capacityReservationId;
        private CapacityReservationCommitmentInfo _commitmentInfo;
        private DateTime? _createDate;
        private CapacityReservationDeliveryPreference _deliveryPreference;
        private bool? _ebsOptimized;
        private DateTime? _endDate;
        private EndDateType _endDateType;
        private bool? _ephemeralStorage;
        private InstanceMatchCriteria _instanceMatchCriteria;
        private CapacityReservationInstancePlatform _instancePlatform;
        private string _instanceType;
        private string _outpostArn;
        private string _ownerId;
        private string _placementGroupArn;
        private CapacityReservationType _reservationType;
        private DateTime? _startDate;
        private CapacityReservationState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private CapacityReservationTenancy _tenancy;
        private int? _totalInstanceCount;
        private string _unusedReservationBillingOwnerId;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the capacity is reserved.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The remaining capacity. Indicates the number of instances that can be launched in
        /// the Capacity Reservation.
        /// </para>
        /// </summary>
        public int? AvailableInstanceCount
        {
            get { return this._availableInstanceCount; }
            set { this._availableInstanceCount = value; }
        }

        // Check to see if AvailableInstanceCount property is set
        internal bool IsSetAvailableInstanceCount()
        {
            return this._availableInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityAllocations. 
        /// <para>
        /// Information about instance capacity usage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityAllocation> CapacityAllocations
        {
            get { return this._capacityAllocations; }
            set { this._capacityAllocations = value; }
        }

        // Check to see if CapacityAllocations property is set
        internal bool IsSetCapacityAllocations()
        {
            return this._capacityAllocations != null && (this._capacityAllocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityBlockId. 
        /// <para>
        /// The ID of the Capacity Block.
        /// </para>
        /// </summary>
        public string CapacityBlockId
        {
            get { return this._capacityBlockId; }
            set { this._capacityBlockId = value; }
        }

        // Check to see if CapacityBlockId property is set
        internal bool IsSetCapacityBlockId()
        {
            return this._capacityBlockId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string CapacityReservationArn
        {
            get { return this._capacityReservationArn; }
            set { this._capacityReservationArn = value; }
        }

        // Check to see if CapacityReservationArn property is set
        internal bool IsSetCapacityReservationArn()
        {
            return this._capacityReservationArn != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationFleetId. 
        /// <para>
        /// The ID of the Capacity Reservation Fleet to which the Capacity Reservation belongs.
        /// Only valid for Capacity Reservations that were created by a Capacity Reservation Fleet.
        /// </para>
        /// </summary>
        public string CapacityReservationFleetId
        {
            get { return this._capacityReservationFleetId; }
            set { this._capacityReservationFleetId = value; }
        }

        // Check to see if CapacityReservationFleetId property is set
        internal bool IsSetCapacityReservationFleetId()
        {
            return this._capacityReservationFleetId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string CapacityReservationId
        {
            get { return this._capacityReservationId; }
            set { this._capacityReservationId = value; }
        }

        // Check to see if CapacityReservationId property is set
        internal bool IsSetCapacityReservationId()
        {
            return this._capacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property CommitmentInfo. 
        /// <para>
        /// Information about your commitment for a future-dated Capacity Reservation.
        /// </para>
        /// </summary>
        public CapacityReservationCommitmentInfo CommitmentInfo
        {
            get { return this._commitmentInfo; }
            set { this._commitmentInfo = value; }
        }

        // Check to see if CommitmentInfo property is set
        internal bool IsSetCommitmentInfo()
        {
            return this._commitmentInfo != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time at which the Capacity Reservation was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeliveryPreference. 
        /// <para>
        /// The delivery method for a future-dated Capacity Reservation. <c>incremental</c> indicates
        /// that the requested capacity is delivered in addition to any running instances and
        /// reserved capacity that you have in your account at the requested date and time.
        /// </para>
        /// </summary>
        public CapacityReservationDeliveryPreference DeliveryPreference
        {
            get { return this._deliveryPreference; }
            set { this._deliveryPreference = value; }
        }

        // Check to see if DeliveryPreference property is set
        internal bool IsSetDeliveryPreference()
        {
            return this._deliveryPreference != null;
        }

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether the Capacity Reservation supports EBS-optimized instances. This
        /// optimization provides dedicated throughput to Amazon EBS and an optimized configuration
        /// stack to provide optimal I/O performance. This optimization isn't available with all
        /// instance types. Additional usage charges apply when using an EBS- optimized instance.
        /// </para>
        /// </summary>
        public bool? EbsOptimized
        {
            get { return this._ebsOptimized; }
            set { this._ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time at which the Capacity Reservation expires. When a Capacity Reservation
        /// expires, the reserved capacity is released and you can no longer launch instances
        /// into it. The Capacity Reservation's state changes to <c>expired</c> when it reaches
        /// its end date and time.
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

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
        public EndDateType EndDateType
        {
            get { return this._endDateType; }
            set { this._endDateType = value; }
        }

        // Check to see if EndDateType property is set
        internal bool IsSetEndDateType()
        {
            return this._endDateType != null;
        }

        /// <summary>
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        ///  <i>Deprecated.</i> 
        /// </para>
        /// </summary>
        public bool? EphemeralStorage
        {
            get { return this._ephemeralStorage; }
            set { this._ephemeralStorage = value; }
        }

        // Check to see if EphemeralStorage property is set
        internal bool IsSetEphemeralStorage()
        {
            return this._ephemeralStorage.HasValue; 
        }

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
        public InstanceMatchCriteria InstanceMatchCriteria
        {
            get { return this._instanceMatchCriteria; }
            set { this._instanceMatchCriteria = value; }
        }

        // Check to see if InstanceMatchCriteria property is set
        internal bool IsSetInstanceMatchCriteria()
        {
            return this._instanceMatchCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property InstancePlatform. 
        /// <para>
        /// The type of operating system for which the Capacity Reservation reserves capacity.
        /// </para>
        /// </summary>
        public CapacityReservationInstancePlatform InstancePlatform
        {
            get { return this._instancePlatform; }
            set { this._instancePlatform = value; }
        }

        // Check to see if InstancePlatform property is set
        internal bool IsSetInstancePlatform()
        {
            return this._instancePlatform != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance for which the Capacity Reservation reserves capacity.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost on which the Capacity Reservation was
        /// created.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the Capacity Reservation.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PlacementGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster placement group in which the Capacity
        /// Reservation was created. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/cr-cpg.html">
        /// Capacity Reservations for cluster placement groups</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string PlacementGroupArn
        {
            get { return this._placementGroupArn; }
            set { this._placementGroupArn = value; }
        }

        // Check to see if PlacementGroupArn property is set
        internal bool IsSetPlacementGroupArn()
        {
            return this._placementGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationType. 
        /// <para>
        /// The type of Capacity Reservation.
        /// </para>
        /// </summary>
        public CapacityReservationType ReservationType
        {
            get { return this._reservationType; }
            set { this._reservationType = value; }
        }

        // Check to see if ReservationType property is set
        internal bool IsSetReservationType()
        {
            return this._reservationType != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date and time at which the Capacity Reservation was started.
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

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
        ///  </li> </ul>
        /// </summary>
        public CapacityReservationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the Capacity Reservation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public CapacityReservationTenancy Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The total number of instances for which the Capacity Reservation reserves capacity.
        /// </para>
        /// </summary>
        public int? TotalInstanceCount
        {
            get { return this._totalInstanceCount; }
            set { this._totalInstanceCount = value; }
        }

        // Check to see if TotalInstanceCount property is set
        internal bool IsSetTotalInstanceCount()
        {
            return this._totalInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnusedReservationBillingOwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account to which billing of the unused capacity
        /// of the Capacity Reservation is assigned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string UnusedReservationBillingOwnerId
        {
            get { return this._unusedReservationBillingOwnerId; }
            set { this._unusedReservationBillingOwnerId = value; }
        }

        // Check to see if UnusedReservationBillingOwnerId property is set
        internal bool IsSetUnusedReservationBillingOwnerId()
        {
            return this._unusedReservationBillingOwnerId != null;
        }

    }
}