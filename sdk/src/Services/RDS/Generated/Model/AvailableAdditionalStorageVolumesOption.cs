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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the available options for additional storage volumes for a DB instance class.
    /// </summary>
    public partial class AvailableAdditionalStorageVolumesOption
    {
        private int? _maxIops;
        private double? _maxIopsPerGib;
        private int? _maxStorageSize;
        private int? _maxStorageThroughput;
        private int? _minIops;
        private double? _minIopsPerGib;
        private int? _minStorageSize;
        private int? _minStorageThroughput;
        private string _storageType;
        private bool? _supportsIops;
        private bool? _supportsStorageAutoscaling;
        private bool? _supportsStorageThroughput;

        /// <summary>
        /// Gets and sets the property MaxIops. 
        /// <para>
        /// The maximum number of I/O operations per second (IOPS) that the additional storage
        /// volume supports.
        /// </para>
        /// </summary>
        public int? MaxIops
        {
            get { return this._maxIops; }
            set { this._maxIops = value; }
        }

        // Check to see if MaxIops property is set
        internal bool IsSetMaxIops()
        {
            return this._maxIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxIopsPerGib. 
        /// <para>
        /// The maximum ratio of I/O operations per second (IOPS) to gibibytes (GiB) of storage
        /// for the additional storage volume.
        /// </para>
        /// </summary>
        public double? MaxIopsPerGib
        {
            get { return this._maxIopsPerGib; }
            set { this._maxIopsPerGib = value; }
        }

        // Check to see if MaxIopsPerGib property is set
        internal bool IsSetMaxIopsPerGib()
        {
            return this._maxIopsPerGib.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxStorageSize. 
        /// <para>
        /// The maximum amount of storage that you can allocate for the additional storage volume,
        /// in gibibytes (GiB).
        /// </para>
        /// </summary>
        public int? MaxStorageSize
        {
            get { return this._maxStorageSize; }
            set { this._maxStorageSize = value; }
        }

        // Check to see if MaxStorageSize property is set
        internal bool IsSetMaxStorageSize()
        {
            return this._maxStorageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxStorageThroughput. 
        /// <para>
        /// The maximum storage throughput that the additional storage volume supports, in mebibytes
        /// per second (MiBps).
        /// </para>
        /// </summary>
        public int? MaxStorageThroughput
        {
            get { return this._maxStorageThroughput; }
            set { this._maxStorageThroughput = value; }
        }

        // Check to see if MaxStorageThroughput property is set
        internal bool IsSetMaxStorageThroughput()
        {
            return this._maxStorageThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinIops. 
        /// <para>
        /// The minimum number of I/O operations per second (IOPS) that the additional storage
        /// volume supports.
        /// </para>
        /// </summary>
        public int? MinIops
        {
            get { return this._minIops; }
            set { this._minIops = value; }
        }

        // Check to see if MinIops property is set
        internal bool IsSetMinIops()
        {
            return this._minIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinIopsPerGib. 
        /// <para>
        /// The minimum ratio of I/O operations per second (IOPS) to gibibytes (GiB) of storage
        /// for the additional storage volume.
        /// </para>
        /// </summary>
        public double? MinIopsPerGib
        {
            get { return this._minIopsPerGib; }
            set { this._minIopsPerGib = value; }
        }

        // Check to see if MinIopsPerGib property is set
        internal bool IsSetMinIopsPerGib()
        {
            return this._minIopsPerGib.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinStorageSize. 
        /// <para>
        /// The minimum amount of storage that you can allocate for the additional storage volume,
        /// in gibibytes (GiB).
        /// </para>
        /// </summary>
        public int? MinStorageSize
        {
            get { return this._minStorageSize; }
            set { this._minStorageSize = value; }
        }

        // Check to see if MinStorageSize property is set
        internal bool IsSetMinStorageSize()
        {
            return this._minStorageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinStorageThroughput. 
        /// <para>
        /// The minimum storage throughput that the additional storage volume supports, in mebibytes
        /// per second (MiBps).
        /// </para>
        /// </summary>
        public int? MinStorageThroughput
        {
            get { return this._minStorageThroughput; }
            set { this._minStorageThroughput = value; }
        }

        // Check to see if MinStorageThroughput property is set
        internal bool IsSetMinStorageThroughput()
        {
            return this._minStorageThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type for the additional storage volume.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>GP3 | IO2</c> 
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property SupportsIops. 
        /// <para>
        /// Indicates whether the additional storage volume supports provisioned IOPS.
        /// </para>
        /// </summary>
        public bool? SupportsIops
        {
            get { return this._supportsIops; }
            set { this._supportsIops = value; }
        }

        // Check to see if SupportsIops property is set
        internal bool IsSetSupportsIops()
        {
            return this._supportsIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsStorageAutoscaling. 
        /// <para>
        /// Indicates whether the additional storage volume supports storage autoscaling.
        /// </para>
        /// </summary>
        public bool? SupportsStorageAutoscaling
        {
            get { return this._supportsStorageAutoscaling; }
            set { this._supportsStorageAutoscaling = value; }
        }

        // Check to see if SupportsStorageAutoscaling property is set
        internal bool IsSetSupportsStorageAutoscaling()
        {
            return this._supportsStorageAutoscaling.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsStorageThroughput. 
        /// <para>
        /// Indicates whether the additional storage volume supports configurable storage throughput.
        /// </para>
        /// </summary>
        public bool? SupportsStorageThroughput
        {
            get { return this._supportsStorageThroughput; }
            set { this._supportsStorageThroughput = value; }
        }

        // Check to see if SupportsStorageThroughput property is set
        internal bool IsSetSupportsStorageThroughput()
        {
            return this._supportsStorageThroughput.HasValue; 
        }

    }
}