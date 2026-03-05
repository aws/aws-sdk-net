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
    /// Information about instance capacity usage for a Capacity Reservation.
    /// </summary>
    public partial class CapacityAllocation
    {
        private List<CapacityAllocationMetadataEntry> _allocationMetadata = AWSConfigs.InitializeCollections ? new List<CapacityAllocationMetadataEntry>() : null;
        private AllocationType _allocationType;
        private int? _count;

        /// <summary>
        /// Gets and sets the property AllocationMetadata. 
        /// <para>
        /// Additional metadata associated with the capacity allocation. Each entry contains a
        /// key-value pair providing context about the allocation.
        /// </para>
        /// </summary>
        public List<CapacityAllocationMetadataEntry> AllocationMetadata
        {
            get { return this._allocationMetadata; }
            set { this._allocationMetadata = value; }
        }

        // Check to see if AllocationMetadata property is set
        internal bool IsSetAllocationMetadata()
        {
            return this._allocationMetadata != null && (this._allocationMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllocationType. 
        /// <para>
        /// The usage type. <c>used</c> indicates that the instance capacity is in use by instances
        /// that are running in the Capacity Reservation.
        /// </para>
        /// </summary>
        public AllocationType AllocationType
        {
            get { return this._allocationType; }
            set { this._allocationType = value; }
        }

        // Check to see if AllocationType property is set
        internal bool IsSetAllocationType()
        {
            return this._allocationType != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The amount of instance capacity associated with the usage. For example a value of
        /// <c>4</c> indicates that instance capacity for 4 instances is currently in use.
        /// </para>
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

    }
}