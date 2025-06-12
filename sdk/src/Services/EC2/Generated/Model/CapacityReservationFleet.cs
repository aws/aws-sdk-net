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
    /// Information about a Capacity Reservation Fleet.
    /// </summary>
    public partial class CapacityReservationFleet
    {
        private string _allocationStrategy;
        private string _capacityReservationFleetArn;
        private string _capacityReservationFleetId;
        private DateTime? _createTime;
        private DateTime? _endDate;
        private FleetInstanceMatchCriteria _instanceMatchCriteria;
        private List<FleetCapacityReservation> _instanceTypeSpecifications = AWSConfigs.InitializeCollections ? new List<FleetCapacityReservation>() : null;
        private CapacityReservationFleetState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private FleetCapacityReservationTenancy _tenancy;
        private double? _totalFulfilledCapacity;
        private int? _totalTargetCapacity;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The strategy used by the Capacity Reservation Fleet to determine which of the specified
        /// instance types to use. For more information, see For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/crfleet-concepts.html#allocation-strategy">Allocation
        /// strategy</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string AllocationStrategy
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
        /// Gets and sets the property CapacityReservationFleetArn. 
        /// <para>
        /// The ARN of the Capacity Reservation Fleet.
        /// </para>
        /// </summary>
        public string CapacityReservationFleetArn
        {
            get { return this._capacityReservationFleetArn; }
            set { this._capacityReservationFleetArn = value; }
        }

        // Check to see if CapacityReservationFleetArn property is set
        internal bool IsSetCapacityReservationFleetArn()
        {
            return this._capacityReservationFleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationFleetId. 
        /// <para>
        /// The ID of the Capacity Reservation Fleet.
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time at which the Capacity Reservation Fleet was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time at which the Capacity Reservation Fleet expires.
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
        public FleetInstanceMatchCriteria InstanceMatchCriteria
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
        /// Gets and sets the property InstanceTypeSpecifications. 
        /// <para>
        /// Information about the instance types for which to reserve the capacity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FleetCapacityReservation> InstanceTypeSpecifications
        {
            get { return this._instanceTypeSpecifications; }
            set { this._instanceTypeSpecifications = value; }
        }

        // Check to see if InstanceTypeSpecifications property is set
        internal bool IsSetInstanceTypeSpecifications()
        {
            return this._instanceTypeSpecifications != null && (this._instanceTypeSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the Capacity Reservation Fleet. Possible states include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>submitted</c> - The Capacity Reservation Fleet request has been submitted and
        /// Amazon Elastic Compute Cloud is preparing to create the Capacity Reservations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modifying</c> - The Capacity Reservation Fleet is being modified. The Fleet remains
        /// in this state until the modification is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>active</c> - The Capacity Reservation Fleet has fulfilled its total target capacity
        /// and it is attempting to maintain this capacity. The Fleet remains in this state until
        /// it is modified or deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>partially_fulfilled</c> - The Capacity Reservation Fleet has partially fulfilled
        /// its total target capacity. There is insufficient Amazon EC2 to fulfill the total target
        /// capacity. The Fleet is attempting to asynchronously fulfill its total target capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>expiring</c> - The Capacity Reservation Fleet has reach its end date and it is
        /// in the process of expiring. One or more of its Capacity reservations might still be
        /// active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>expired</c> - The Capacity Reservation Fleet has reach its end date. The Fleet
        /// and its Capacity Reservations are expired. The Fleet can't create new Capacity Reservations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cancelling</c> - The Capacity Reservation Fleet is in the process of being cancelled.
        /// One or more of its Capacity reservations might still be active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cancelled</c> - The Capacity Reservation Fleet has been manually cancelled. The
        /// Fleet and its Capacity Reservations are cancelled and the Fleet can't create new Capacity
        /// Reservations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c> - The Capacity Reservation Fleet failed to reserve capacity for the
        /// specified instance types.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityReservationFleetState State
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
        /// The tags assigned to the Capacity Reservation Fleet.
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
        /// The tenancy of the Capacity Reservation Fleet. Tenancies include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>default</c> - The Capacity Reservation Fleet is created on hardware that is shared
        /// with other Amazon Web Services accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dedicated</c> - The Capacity Reservation Fleet is created on single-tenant hardware
        /// that is dedicated to a single Amazon Web Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FleetCapacityReservationTenancy Tenancy
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
        /// Gets and sets the property TotalFulfilledCapacity. 
        /// <para>
        /// The capacity units that have been fulfilled.
        /// </para>
        /// </summary>
        public double? TotalFulfilledCapacity
        {
            get { return this._totalFulfilledCapacity; }
            set { this._totalFulfilledCapacity = value; }
        }

        // Check to see if TotalFulfilledCapacity property is set
        internal bool IsSetTotalFulfilledCapacity()
        {
            return this._totalFulfilledCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalTargetCapacity. 
        /// <para>
        /// The total number of capacity units for which the Capacity Reservation Fleet reserves
        /// capacity. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/crfleet-concepts.html#target-capacity">Total
        /// target capacity</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public int? TotalTargetCapacity
        {
            get { return this._totalTargetCapacity; }
            set { this._totalTargetCapacity = value; }
        }

        // Check to see if TotalTargetCapacity property is set
        internal bool IsSetTotalTargetCapacity()
        {
            return this._totalTargetCapacity.HasValue; 
        }

    }
}