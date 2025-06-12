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
    /// This is the response object from the CreateCapacityReservationFleet operation.
    /// </summary>
    public partial class CreateCapacityReservationFleetResponse : AmazonWebServiceResponse
    {
        private string _allocationStrategy;
        private string _capacityReservationFleetId;
        private DateTime? _createTime;
        private DateTime? _endDate;
        private List<FleetCapacityReservation> _fleetCapacityReservations = AWSConfigs.InitializeCollections ? new List<FleetCapacityReservation>() : null;
        private FleetInstanceMatchCriteria _instanceMatchCriteria;
        private CapacityReservationFleetState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private FleetCapacityReservationTenancy _tenancy;
        private double? _totalFulfilledCapacity;
        private int? _totalTargetCapacity;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The allocation strategy used by the Capacity Reservation Fleet.
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
        /// Gets and sets the property FleetCapacityReservations. 
        /// <para>
        /// Information about the individual Capacity Reservations in the Capacity Reservation
        /// Fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FleetCapacityReservation> FleetCapacityReservations
        {
            get { return this._fleetCapacityReservations; }
            set { this._fleetCapacityReservations = value; }
        }

        // Check to see if FleetCapacityReservations property is set
        internal bool IsSetFleetCapacityReservations()
        {
            return this._fleetCapacityReservations != null && (this._fleetCapacityReservations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceMatchCriteria. 
        /// <para>
        /// The instance matching criteria for the Capacity Reservation Fleet.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The status of the Capacity Reservation Fleet.
        /// </para>
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
        /// Indicates the tenancy of Capacity Reservation Fleet.
        /// </para>
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
        /// The requested capacity units that have been successfully reserved.
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
        /// capacity.
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