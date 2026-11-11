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
    /// Information about instance capacity usage for a Capacity Reservation.
    /// </summary>
    public partial class CapacityAllocation
    {
        /// <summary>
        /// Gets and sets the property AllocationMetadata. 
        /// <para>
        /// Additional metadata associated with the capacity allocation. Each entry contains a
        /// key-value pair providing context about the allocation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityAllocationMetadataEntry> AllocationMetadata { get; set; } = AWSConfigs.InitializeCollections ? new List<CapacityAllocationMetadataEntry>() : null;

        /// <summary>
        /// Checks to see if the AllocationMetadata property is set.
        /// </summary>
        internal bool IsSetAllocationMetadata() => this.AllocationMetadata != null && (this.AllocationMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllocationType. 
        /// <para>
        /// The usage type. <c>used</c> indicates that the instance capacity is in use by instances
        /// that are running in the Capacity Reservation.
        /// </para>
        /// </summary>
        public AllocationType AllocationType { get; set; }

        /// <summary>
        /// Checks to see if the AllocationType property is set.
        /// </summary>
        internal bool IsSetAllocationType() => this.AllocationType != null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The amount of instance capacity associated with the usage. For example a value of
        /// <c>4</c> indicates that instance capacity for 4 instances is currently in use.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;
    }
}
