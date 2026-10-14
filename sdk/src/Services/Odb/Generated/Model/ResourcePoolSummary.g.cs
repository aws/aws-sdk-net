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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// The configuration of a resource pool for an Autonomous Database.
    /// </summary>
    public partial class ResourcePoolSummary
    {
        /// <summary>
        /// Gets and sets the property AvailableComputeCapacity. 
        /// <para>
        /// The available compute capacity in the resource pool.
        /// </para>
        /// </summary>
        public int? AvailableComputeCapacity { get; set; }

        /// <summary>
        /// Checks to see if the AvailableComputeCapacity property is set.
        /// </summary>
        internal bool IsSetAvailableComputeCapacity() => this.AvailableComputeCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableStorageCapacityInTBs. 
        /// <para>
        /// The available storage capacity in the resource pool, in TB.
        /// </para>
        /// </summary>
        public double? AvailableStorageCapacityInTBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableStorageCapacityInTBs property is set.
        /// </summary>
        internal bool IsSetAvailableStorageCapacityInTBs() => this.AvailableStorageCapacityInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property IsDisabled. 
        /// <para>
        /// Indicates whether the resource pool is disabled.
        /// </para>
        /// </summary>
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Checks to see if the IsDisabled property is set.
        /// </summary>
        internal bool IsSetIsDisabled() => this.IsDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property PoolSize. 
        /// <para>
        /// The number of Autonomous Databases that the resource pool can contain.
        /// </para>
        /// </summary>
        public int? PoolSize { get; set; }

        /// <summary>
        /// Checks to see if the PoolSize property is set.
        /// </summary>
        internal bool IsSetPoolSize() => this.PoolSize.HasValue;

        /// <summary>
        /// Gets and sets the property PoolStorageSizeInTBs. 
        /// <para>
        /// The total storage size of the resource pool, in terabytes (TB).
        /// </para>
        /// </summary>
        public int? PoolStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the PoolStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetPoolStorageSizeInTBs() => this.PoolStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property TotalComputeCapacity. 
        /// <para>
        /// The total compute capacity of the resource pool.
        /// </para>
        /// </summary>
        public int? TotalComputeCapacity { get; set; }

        /// <summary>
        /// Checks to see if the TotalComputeCapacity property is set.
        /// </summary>
        internal bool IsSetTotalComputeCapacity() => this.TotalComputeCapacity.HasValue;
    }
}
