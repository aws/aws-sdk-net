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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private int? _availableComputeCapacity;
        private double? _availableStorageCapacityInTBs;
        private bool? _isDisabled;
        private int? _poolSize;
        private int? _poolStorageSizeInTBs;
        private int? _totalComputeCapacity;

        /// <summary>
        /// Gets and sets the property AvailableComputeCapacity. 
        /// <para>
        /// The available compute capacity in the resource pool.
        /// </para>
        /// </summary>
        public int? AvailableComputeCapacity
        {
            get { return this._availableComputeCapacity; }
            set { this._availableComputeCapacity = value; }
        }

        // Check to see if AvailableComputeCapacity property is set
        internal bool IsSetAvailableComputeCapacity()
        {
            return this._availableComputeCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableStorageCapacityInTBs. 
        /// <para>
        /// The available storage capacity in the resource pool, in TB.
        /// </para>
        /// </summary>
        public double? AvailableStorageCapacityInTBs
        {
            get { return this._availableStorageCapacityInTBs; }
            set { this._availableStorageCapacityInTBs = value; }
        }

        // Check to see if AvailableStorageCapacityInTBs property is set
        internal bool IsSetAvailableStorageCapacityInTBs()
        {
            return this._availableStorageCapacityInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsDisabled. 
        /// <para>
        /// Indicates whether the resource pool is disabled.
        /// </para>
        /// </summary>
        public bool? IsDisabled
        {
            get { return this._isDisabled; }
            set { this._isDisabled = value; }
        }

        // Check to see if IsDisabled property is set
        internal bool IsSetIsDisabled()
        {
            return this._isDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PoolSize. 
        /// <para>
        /// The number of Autonomous Databases that the resource pool can contain.
        /// </para>
        /// </summary>
        public int? PoolSize
        {
            get { return this._poolSize; }
            set { this._poolSize = value; }
        }

        // Check to see if PoolSize property is set
        internal bool IsSetPoolSize()
        {
            return this._poolSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PoolStorageSizeInTBs. 
        /// <para>
        /// The total storage size of the resource pool, in terabytes (TB).
        /// </para>
        /// </summary>
        public int? PoolStorageSizeInTBs
        {
            get { return this._poolStorageSizeInTBs; }
            set { this._poolStorageSizeInTBs = value; }
        }

        // Check to see if PoolStorageSizeInTBs property is set
        internal bool IsSetPoolStorageSizeInTBs()
        {
            return this._poolStorageSizeInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalComputeCapacity. 
        /// <para>
        /// The total compute capacity of the resource pool.
        /// </para>
        /// </summary>
        public int? TotalComputeCapacity
        {
            get { return this._totalComputeCapacity; }
            set { this._totalComputeCapacity = value; }
        }

        // Check to see if TotalComputeCapacity property is set
        internal bool IsSetTotalComputeCapacity()
        {
            return this._totalComputeCapacity.HasValue; 
        }

    }
}