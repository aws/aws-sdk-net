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
    /// Container for the parameters to the UpdateInterruptibleCapacityReservationAllocation
    /// operation. Modifies the number of instances allocated to an interruptible reservation,
    /// allowing you to add more capacity or reclaim capacity to your source Capacity Reservation.
    /// </summary>
    public partial class UpdateInterruptibleCapacityReservationAllocationRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        ///  The ID of the source Capacity Reservation containing the interruptible allocation
        /// to modify. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationId() => this.CapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        ///  Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. 
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property TargetInstanceCount. 
        /// <para>
        ///  The new number of instances to allocate. Enter a higher number to add more capacity
        /// to share, or a lower number to reclaim capacity to your source Capacity Reservation.
        /// 
        /// </para>
        /// </summary>
        public int? TargetInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the TargetInstanceCount property is set.
        /// </summary>
        internal bool IsSetTargetInstanceCount() => this.TargetInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ZeroSizePreference. 
        /// <para>
        ///  Specifies the updated behavior for the interruptible Capacity Reservation when you
        /// reduce its allocation to zero instances. Specify <c>retain</c> to keep the interruptible
        /// Capacity Reservation active at zero capacity so that you can allocate instances to
        /// it again later. Specify <c>default</c> to cancel the interruptible Capacity Reservation
        /// and return the capacity to your source Capacity Reservation. 
        /// </para>
        /// </summary>
        public ZeroSizePreference ZeroSizePreference { get; set; }

        /// <summary>
        /// Checks to see if the ZeroSizePreference property is set.
        /// </summary>
        internal bool IsSetZeroSizePreference() => this.ZeroSizePreference != null;
    }
}
