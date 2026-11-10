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
    /// This is the response object from the CreateCapacityReservationFleet operation.
    /// </summary>
    public partial class CreateCapacityReservationFleetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The allocation strategy used by the Capacity Reservation Fleet.
        /// </para>
        /// </summary>
        public string AllocationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the AllocationStrategy property is set.
        /// </summary>
        internal bool IsSetAllocationStrategy() => this.AllocationStrategy != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationFleetId. 
        /// <para>
        /// The ID of the Capacity Reservation Fleet.
        /// </para>
        /// </summary>
        public string CapacityReservationFleetId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationFleetId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationFleetId() => this.CapacityReservationFleetId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time at which the Capacity Reservation Fleet was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time at which the Capacity Reservation Fleet expires.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property FleetCapacityReservations. 
        /// <para>
        /// Information about the individual Capacity Reservations in the Capacity Reservation
        /// Fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FleetCapacityReservation> FleetCapacityReservations { get; set; } = AWSConfigs.InitializeCollections ? new List<FleetCapacityReservation>() : null;

        /// <summary>
        /// Checks to see if the FleetCapacityReservations property is set.
        /// </summary>
        internal bool IsSetFleetCapacityReservations() => this.FleetCapacityReservations != null && (this.FleetCapacityReservations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceMatchCriteria. 
        /// <para>
        /// The instance matching criteria for the Capacity Reservation Fleet.
        /// </para>
        /// </summary>
        public FleetInstanceMatchCriteria InstanceMatchCriteria { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMatchCriteria property is set.
        /// </summary>
        internal bool IsSetInstanceMatchCriteria() => this.InstanceMatchCriteria != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The status of the Capacity Reservation Fleet.
        /// </para>
        /// </summary>
        public CapacityReservationFleetState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the Capacity Reservation Fleet.
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
        /// Indicates the tenancy of Capacity Reservation Fleet.
        /// </para>
        /// </summary>
        public FleetCapacityReservationTenancy Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;

        /// <summary>
        /// Gets and sets the property TotalFulfilledCapacity. 
        /// <para>
        /// The requested capacity units that have been successfully reserved.
        /// </para>
        /// </summary>
        public double? TotalFulfilledCapacity { get; set; }

        /// <summary>
        /// Checks to see if the TotalFulfilledCapacity property is set.
        /// </summary>
        internal bool IsSetTotalFulfilledCapacity() => this.TotalFulfilledCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property TotalTargetCapacity. 
        /// <para>
        /// The total number of capacity units for which the Capacity Reservation Fleet reserves
        /// capacity.
        /// </para>
        /// </summary>
        public int? TotalTargetCapacity { get; set; }

        /// <summary>
        /// Checks to see if the TotalTargetCapacity property is set.
        /// </summary>
        internal bool IsSetTotalTargetCapacity() => this.TotalTargetCapacity.HasValue;
    }
}
