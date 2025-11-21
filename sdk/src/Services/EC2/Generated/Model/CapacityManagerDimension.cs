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
    /// Represents dimension values for capacity metrics, including resource identifiers,
    /// geographic information, and reservation details used for grouping and filtering capacity
    /// data.
    /// </summary>
    public partial class CapacityManagerDimension
    {
        private string _accountId;
        private string _availabilityZoneId;
        private string _instanceFamily;
        private string _instancePlatform;
        private string _instanceType;
        private string _reservationArn;
        private DateTime? _reservationCreateTimestamp;
        private ReservationEndDateType _reservationEndDateType;
        private DateTime? _reservationEndTimestamp;
        private string _reservationId;
        private string _reservationInstanceMatchCriteria;
        private DateTime? _reservationStartTimestamp;
        private ReservationState _reservationState;
        private ReservationType _reservationType;
        private string _reservationUnusedFinancialOwner;
        private string _resourceRegion;
        private CapacityTenancy _tenancy;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID that owns the capacity resource. 
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        ///  The unique identifier of the Availability Zone where the capacity resource is located.
        /// 
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
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        ///  The EC2 instance family of the capacity resource. 
        /// </para>
        /// </summary>
        public string InstanceFamily
        {
            get { return this._instanceFamily; }
            set { this._instanceFamily = value; }
        }

        // Check to see if InstanceFamily property is set
        internal bool IsSetInstanceFamily()
        {
            return this._instanceFamily != null;
        }

        /// <summary>
        /// Gets and sets the property InstancePlatform. 
        /// <para>
        ///  The platform or operating system of the instance. 
        /// </para>
        /// </summary>
        public string InstancePlatform
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
        ///  The specific EC2 instance type of the capacity resource. 
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
        /// Gets and sets the property ReservationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the capacity reservation. This provides a unique
        /// identifier that can be used across Amazon Web Services services to reference the specific
        /// reservation. 
        /// </para>
        /// </summary>
        public string ReservationArn
        {
            get { return this._reservationArn; }
            set { this._reservationArn = value; }
        }

        // Check to see if ReservationArn property is set
        internal bool IsSetReservationArn()
        {
            return this._reservationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationCreateTimestamp. 
        /// <para>
        ///  The timestamp when the capacity reservation was originally created, in milliseconds
        /// since epoch. This differs from the start timestamp as reservations can be created
        /// before they become active. 
        /// </para>
        /// </summary>
        public DateTime? ReservationCreateTimestamp
        {
            get { return this._reservationCreateTimestamp; }
            set { this._reservationCreateTimestamp = value; }
        }

        // Check to see if ReservationCreateTimestamp property is set
        internal bool IsSetReservationCreateTimestamp()
        {
            return this._reservationCreateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservationEndDateType. 
        /// <para>
        ///  The type of end date for the capacity reservation. This indicates whether the reservation
        /// has a fixed end date, is open-ended, or follows a specific termination pattern. 
        /// </para>
        /// </summary>
        public ReservationEndDateType ReservationEndDateType
        {
            get { return this._reservationEndDateType; }
            set { this._reservationEndDateType = value; }
        }

        // Check to see if ReservationEndDateType property is set
        internal bool IsSetReservationEndDateType()
        {
            return this._reservationEndDateType != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationEndTimestamp. 
        /// <para>
        ///  The timestamp when the capacity reservation expires and is no longer available, in
        /// milliseconds since epoch. After this time, the reservation will not provide any capacity.
        /// 
        /// </para>
        /// </summary>
        public DateTime? ReservationEndTimestamp
        {
            get { return this._reservationEndTimestamp; }
            set { this._reservationEndTimestamp = value; }
        }

        // Check to see if ReservationEndTimestamp property is set
        internal bool IsSetReservationEndTimestamp()
        {
            return this._reservationEndTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservationId. 
        /// <para>
        ///  The unique identifier of the capacity reservation. 
        /// </para>
        /// </summary>
        public string ReservationId
        {
            get { return this._reservationId; }
            set { this._reservationId = value; }
        }

        // Check to see if ReservationId property is set
        internal bool IsSetReservationId()
        {
            return this._reservationId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationInstanceMatchCriteria. 
        /// <para>
        ///  The instance matching criteria for the capacity reservation, determining how instances
        /// are matched to the reservation. 
        /// </para>
        /// </summary>
        public string ReservationInstanceMatchCriteria
        {
            get { return this._reservationInstanceMatchCriteria; }
            set { this._reservationInstanceMatchCriteria = value; }
        }

        // Check to see if ReservationInstanceMatchCriteria property is set
        internal bool IsSetReservationInstanceMatchCriteria()
        {
            return this._reservationInstanceMatchCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationStartTimestamp. 
        /// <para>
        ///  The timestamp when the capacity reservation becomes active and available for use,
        /// in milliseconds since epoch. This is when the reservation begins providing capacity.
        /// 
        /// </para>
        /// </summary>
        public DateTime? ReservationStartTimestamp
        {
            get { return this._reservationStartTimestamp; }
            set { this._reservationStartTimestamp = value; }
        }

        // Check to see if ReservationStartTimestamp property is set
        internal bool IsSetReservationStartTimestamp()
        {
            return this._reservationStartTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservationState. 
        /// <para>
        ///  The current state of the capacity reservation. 
        /// </para>
        /// </summary>
        public ReservationState ReservationState
        {
            get { return this._reservationState; }
            set { this._reservationState = value; }
        }

        // Check to see if ReservationState property is set
        internal bool IsSetReservationState()
        {
            return this._reservationState != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationType. 
        /// <para>
        ///  The type of capacity reservation. 
        /// </para>
        /// </summary>
        public ReservationType ReservationType
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
        /// Gets and sets the property ReservationUnusedFinancialOwner. 
        /// <para>
        ///  The Amazon Web Services account ID that is financially responsible for unused capacity
        /// reservation costs. 
        /// </para>
        /// </summary>
        public string ReservationUnusedFinancialOwner
        {
            get { return this._reservationUnusedFinancialOwner; }
            set { this._reservationUnusedFinancialOwner = value; }
        }

        // Check to see if ReservationUnusedFinancialOwner property is set
        internal bool IsSetReservationUnusedFinancialOwner()
        {
            return this._reservationUnusedFinancialOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        ///  The Amazon Web Services Region where the capacity resource is located. 
        /// </para>
        /// </summary>
        public string ResourceRegion
        {
            get { return this._resourceRegion; }
            set { this._resourceRegion = value; }
        }

        // Check to see if ResourceRegion property is set
        internal bool IsSetResourceRegion()
        {
            return this._resourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        ///  The tenancy of the EC2 instances associated with this capacity dimension. Valid values
        /// are 'default' for shared tenancy, 'dedicated' for dedicated instances, or 'host' for
        /// dedicated hosts. 
        /// </para>
        /// </summary>
        public CapacityTenancy Tenancy
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