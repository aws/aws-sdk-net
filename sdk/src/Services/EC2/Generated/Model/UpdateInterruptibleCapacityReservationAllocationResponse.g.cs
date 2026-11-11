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
    /// This is the response object from the UpdateInterruptibleCapacityReservationAllocation
    /// operation.
    /// </summary>
    public partial class UpdateInterruptibleCapacityReservationAllocationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        ///  The current number of instances allocated to the interruptible reservation. 
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InterruptibleCapacityReservationId. 
        /// <para>
        ///  The ID of the interruptible Capacity Reservation that was modified. 
        /// </para>
        /// </summary>
        public string InterruptibleCapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the InterruptibleCapacityReservationId property is set.
        /// </summary>
        internal bool IsSetInterruptibleCapacityReservationId() => this.InterruptibleCapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property InterruptionType. 
        /// <para>
        ///  The interruption type for the interruptible reservation. 
        /// </para>
        /// </summary>
        public InterruptionType InterruptionType { get; set; }

        /// <summary>
        /// Checks to see if the InterruptionType property is set.
        /// </summary>
        internal bool IsSetInterruptionType() => this.InterruptionType != null;

        /// <summary>
        /// Gets and sets the property SourceCapacityReservationId. 
        /// <para>
        ///  The ID of the source Capacity Reservation to which capacity was reclaimed or from
        /// which capacity was allocated. 
        /// </para>
        /// </summary>
        public string SourceCapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the SourceCapacityReservationId property is set.
        /// </summary>
        internal bool IsSetSourceCapacityReservationId() => this.SourceCapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the allocation (updating during reclamation, active when complete).
        /// 
        /// </para>
        /// </summary>
        public InterruptibleCapacityReservationAllocationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetInstanceCount. 
        /// <para>
        ///  The requested number of instances for the interruptible Capacity Reservation. 
        /// </para>
        /// </summary>
        public int? TargetInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the TargetInstanceCount property is set.
        /// </summary>
        internal bool IsSetTargetInstanceCount() => this.TargetInstanceCount.HasValue;
    }
}
