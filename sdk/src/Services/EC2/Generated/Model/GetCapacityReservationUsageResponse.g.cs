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
    /// This is the response object from the GetCapacityReservationUsage operation.
    /// </summary>
    public partial class GetCapacityReservationUsageResponse : AmazonWebServiceResponse
    {
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
        /// Gets and sets the property InstanceUsages. 
        /// <para>
        /// Information about the Capacity Reservation usage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceUsage> InstanceUsages { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceUsage>() : null;

        /// <summary>
        /// Checks to see if the InstanceUsages property is set.
        /// </summary>
        internal bool IsSetInstanceUsages() => this.InstanceUsages != null && (this.InstanceUsages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Interruptible. 
        /// <para>
        ///  Indicates whether the Capacity Reservation is interruptible, meaning instances may
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
        ///  Information about the capacity allocated to the interruptible Capacity Reservation,
        /// including instance counts and allocation status. 
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
        ///  Details about the interruption configuration and source reservation for interruptible
        /// Capacity Reservations. 
        /// </para>
        /// </summary>
        public InterruptionInfo InterruptionInfo { get; set; }

        /// <summary>
        /// Checks to see if the InterruptionInfo property is set.
        /// </summary>
        internal bool IsSetInterruptionInfo() => this.InterruptionInfo != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is <c>null</c> when
        /// there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

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
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The number of instances for which the Capacity Reservation reserves capacity.
        /// </para>
        /// </summary>
        public int? TotalInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalInstanceCount property is set.
        /// </summary>
        internal bool IsSetTotalInstanceCount() => this.TotalInstanceCount.HasValue;
    }
}
