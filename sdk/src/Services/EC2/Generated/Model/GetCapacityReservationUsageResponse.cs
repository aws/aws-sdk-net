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
    /// This is the response object from the GetCapacityReservationUsage operation.
    /// </summary>
    public partial class GetCapacityReservationUsageResponse : AmazonWebServiceResponse
    {
        private int? _availableInstanceCount;
        private string _capacityReservationId;
        private string _instanceType;
        private List<InstanceUsage> _instanceUsages = AWSConfigs.InitializeCollections ? new List<InstanceUsage>() : null;
        private string _nextToken;
        private CapacityReservationState _state;
        private int? _totalInstanceCount;

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
        /// Gets and sets the property InstanceUsages. 
        /// <para>
        /// Information about the Capacity Reservation usage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceUsage> InstanceUsages
        {
            get { return this._instanceUsages; }
            set { this._instanceUsages = value; }
        }

        // Check to see if InstanceUsages property is set
        internal bool IsSetInstanceUsages()
        {
            return this._instanceUsages != null && (this._instanceUsages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is <c>null</c> when
        /// there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
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
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The number of instances for which the Capacity Reservation reserves capacity.
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

    }
}