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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// A reservation for a specified number of data processing units (DPUs). When a reservation
    /// is initially created, it has no DPUs. Athena allocates DPUs until the allocated amount
    /// equals the requested amount.
    /// </summary>
    public partial class CapacityReservation
    {
        /// <summary>
        /// Gets and sets the property AllocatedDpus. 
        /// <para>
        /// The number of data processing units currently allocated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? AllocatedDpus { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedDpus property is set.
        /// </summary>
        internal bool IsSetAllocatedDpus() => this.AllocatedDpus.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time in UTC epoch millis when the capacity reservation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastAllocation.
        /// </summary>
        public CapacityAllocation LastAllocation { get; set; }

        /// <summary>
        /// Checks to see if the LastAllocation property is set.
        /// </summary>
        internal bool IsSetLastAllocation() => this.LastAllocation != null;

        /// <summary>
        /// Gets and sets the property LastSuccessfulAllocationTime. 
        /// <para>
        /// The time of the most recent capacity allocation that succeeded.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulAllocationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulAllocationTime property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulAllocationTime() => this.LastSuccessfulAllocationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityReservationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetDpus. 
        /// <para>
        /// The number of data processing units requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4)]
        public int? TargetDpus { get; set; }

        /// <summary>
        /// Checks to see if the TargetDpus property is set.
        /// </summary>
        internal bool IsSetTargetDpus() => this.TargetDpus.HasValue;
    }
}
