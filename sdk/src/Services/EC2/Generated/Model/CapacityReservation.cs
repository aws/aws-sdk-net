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
    /// Describes a Capacity Reservation.
    /// </summary>
    public partial class CapacityReservation
    {
        private string _availabilityZone;
        private int? _availableInstanceCount;
        private string _capacityReservationId;
        private DateTime? _createDate;
        private bool? _ebsOptimized;
        private DateTime? _endDate;
        private EndDateType _endDateType;
        private bool? _ephemeralStorage;
        private InstanceMatchCriteria _instanceMatchCriteria;
        private CapacityReservationInstancePlatform _instancePlatform;
        private string _instanceType;
        private CapacityReservationState _state;
        private List<Tag> _tags = new List<Tag>();
        private CapacityReservationTenancy _tenancy;
        private int? _totalInstanceCount;

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
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The remaining capacity. Indicates the number of instances that can be launched in
        /// the Capacity Reservation.
        /// </para>
        /// </summary>
        public int AvailableInstanceCount
        {
            get { return this._availableInstanceCount.GetValueOrDefault(); }
            set { this._availableInstanceCount = value; }
        }

        // Check to see if AvailableInstanceCount property is set
        internal bool IsSetAvailableInstanceCount()
        {
            return this._availableInstanceCount.HasValue; 
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
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time at which the Capacity Reservation was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
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
        public bool EbsOptimized
        {
            get { return this._ebsOptimized.GetValueOrDefault(); }
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
        /// into it. The Capacity Reservation's state changes to <code>expired</code> when it
        /// reaches its end date and time.
        /// </para>
        /// </summary>
        public DateTime EndDate
        {
            get { return this._endDate.GetValueOrDefault(); }
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
        ///  <code>unlimited</code> - The Capacity Reservation remains active until you explicitly
        /// cancel it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>limited</code> - The Capacity Reservation expires automatically at a specified
        /// date and time.
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
        /// Indicates whether the Capacity Reservation supports instances with temporary, block-level
        /// storage.
        /// </para>
        /// </summary>
        public bool EphemeralStorage
        {
            get { return this._ephemeralStorage.GetValueOrDefault(); }
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
        ///  <code>open</code> - The Capacity Reservation accepts all instances that have matching
        /// attributes (instance type, platform, and Availability Zone). Instances that have matching
        /// attributes launch into the Capacity Reservation automatically without specifying any
        /// additional parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>targeted</code> - The Capacity Reservation only accepts instances that have
        /// matching attributes (instance type, platform, and Availability Zone), and explicitly
        /// target the Capacity Reservation. This ensures that only permitted instances can use
        /// the reserved capacity. 
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the Capacity Reservation. A Capacity Reservation can be in one
        /// of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>active</code> - The Capacity Reservation is active and the capacity is available
        /// for your use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cancelled</code> - The Capacity Reservation expired automatically at the date
        /// and time specified in your request. The reserved capacity is no longer available for
        /// your use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>expired</code> - The Capacity Reservation was manually cancelled. The reserved
        /// capacity is no longer available for your use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pending</code> - The Capacity Reservation request was successful but the capacity
        /// provisioning is still pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>failed</code> - The Capacity Reservation request has failed. A request might
        /// fail due to invalid request parameters, capacity constraints, or instance limit constraints.
        /// Failed requests are retained for 60 minutes.
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
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Indicates the tenancy of the Capacity Reservation. A Capacity Reservation can have
        /// one of the following tenancy settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>default</code> - The Capacity Reservation is created on hardware that is shared
        /// with other AWS accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dedicated</code> - The Capacity Reservation is created on single-tenant hardware
        /// that is dedicated to a single AWS account.
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
        /// The number of instances for which the Capacity Reservation reserves capacity.
        /// </para>
        /// </summary>
        public int TotalInstanceCount
        {
            get { return this._totalInstanceCount.GetValueOrDefault(); }
            set { this._totalInstanceCount = value; }
        }

        // Check to see if TotalInstanceCount property is set
        internal bool IsSetTotalInstanceCount()
        {
            return this._totalInstanceCount.HasValue; 
        }

    }
}