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
    /// Container for the parameters to the CreateCapacityReservation operation.
    /// Creates a new Capacity Reservation with the specified attributes.
    /// 
    ///  
    /// <para>
    /// Capacity Reservations enable you to reserve capacity for your Amazon EC2 instances
    /// in a specific Availability Zone for any duration. This gives you the flexibility to
    /// selectively add capacity reservations and still get the Regional RI discounts for
    /// that usage. By creating Capacity Reservations, you ensure that you always have access
    /// to Amazon EC2 capacity when you need it, for as long as you need it. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-capacity-reservations.html">Capacity
    /// Reservations</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Your request to create a Capacity Reservation could fail if Amazon EC2 does not have
    /// sufficient capacity to fulfill the request. If your request fails due to Amazon EC2
    /// capacity constraints, either try again at a later time, try in a different Availability
    /// Zone, or request a smaller capacity reservation. If your application is flexible across
    /// instance types and sizes, try to create a Capacity Reservation with different instance
    /// attributes.
    /// </para>
    ///  
    /// <para>
    /// Your request could also fail if the requested quantity exceeds your On-Demand Instance
    /// limit for the selected instance type. If your request fails due to limit constraints,
    /// increase your On-Demand Instance limit for the required instance type and try again.
    /// For more information about increasing your instance limits, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-resource-limits.html">Amazon
    /// EC2 Service Limits</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateCapacityReservationRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private string _clientToken;
        private bool? _ebsOptimized;
        private DateTime? _endDate;
        private EndDateType _endDateType;
        private bool? _ephemeralStorage;
        private int? _instanceCount;
        private InstanceMatchCriteria _instanceMatchCriteria;
        private CapacityReservationInstancePlatform _instancePlatform;
        private string _instanceType;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private CapacityReservationTenancy _tenancy;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to create the Capacity Reservation.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">How
        /// to Ensure Idempotency</a>.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Maximum 64 ASCII characters.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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
        ///  
        /// <para>
        /// You must provide an <code>EndDate</code> value if <code>EndDateType</code> is <code>limited</code>.
        /// Omit <code>EndDate</code> if <code>EndDateType</code> is <code>unlimited</code>.
        /// </para>
        ///  
        /// <para>
        /// If the <code>EndDateType</code> is <code>limited</code>, the Capacity Reservation
        /// is cancelled within an hour from the specified time. For example, if you specify 5/31/2019,
        /// 13:30:55, the Capacity Reservation is guaranteed to end between 13:30:55 and 14:30:55
        /// on 5/31/2019.
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
        /// cancel it. Do not provide an <code>EndDate</code> if the <code>EndDateType</code>
        /// is <code>unlimited</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>limited</code> - The Capacity Reservation expires automatically at a specified
        /// date and time. You must provide an <code>EndDate</code> value if the <code>EndDateType</code>
        /// value is <code>limited</code>.
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
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances for which to reserve capacity.
        /// </para>
        /// </summary>
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceMatchCriteria. 
        /// <para>
        /// Indicates the type of instance launches that the Capacity Reservation accepts. The
        /// options include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>open</code> - The Capacity Reservation automatically matches all instances
        /// that have matching attributes (instance type, platform, and Availability Zone). Instances
        /// that have matching attributes run in the Capacity Reservation automatically without
        /// specifying any additional parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>targeted</code> - The Capacity Reservation only accepts instances that have
        /// matching attributes (instance type, platform, and Availability Zone), and explicitly
        /// target the Capacity Reservation. This ensures that only permitted instances can use
        /// the reserved capacity. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <code>open</code> 
        /// </para>
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
        /// The type of operating system for which to reserve capacity.
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
        /// The instance type for which to reserve capacity. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the Capacity Reservation during launch.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
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

    }
}