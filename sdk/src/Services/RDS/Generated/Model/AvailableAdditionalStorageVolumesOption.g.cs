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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the available options for additional storage volumes for a DB instance class.
    /// </summary>
    public partial class AvailableAdditionalStorageVolumesOption
    {
        /// <summary>
        /// Gets and sets the property MaxIops. 
        /// <para>
        /// The maximum number of I/O operations per second (IOPS) that the additional storage
        /// volume supports.
        /// </para>
        /// </summary>
        public int? MaxIops { get; set; }

        /// <summary>
        /// Checks to see if the MaxIops property is set.
        /// </summary>
        internal bool IsSetMaxIops() => this.MaxIops.HasValue;

        /// <summary>
        /// Gets and sets the property MaxIopsPerGib. 
        /// <para>
        /// The maximum ratio of I/O operations per second (IOPS) to gibibytes (GiB) of storage
        /// for the additional storage volume.
        /// </para>
        /// </summary>
        public double? MaxIopsPerGib { get; set; }

        /// <summary>
        /// Checks to see if the MaxIopsPerGib property is set.
        /// </summary>
        internal bool IsSetMaxIopsPerGib() => this.MaxIopsPerGib.HasValue;

        /// <summary>
        /// Gets and sets the property MaxStorageSize. 
        /// <para>
        /// The maximum amount of storage that you can allocate for the additional storage volume,
        /// in gibibytes (GiB).
        /// </para>
        /// </summary>
        public int? MaxStorageSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxStorageSize property is set.
        /// </summary>
        internal bool IsSetMaxStorageSize() => this.MaxStorageSize.HasValue;

        /// <summary>
        /// Gets and sets the property MaxStorageThroughput. 
        /// <para>
        /// The maximum storage throughput that the additional storage volume supports, in mebibytes
        /// per second (MiBps).
        /// </para>
        /// </summary>
        public int? MaxStorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the MaxStorageThroughput property is set.
        /// </summary>
        internal bool IsSetMaxStorageThroughput() => this.MaxStorageThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property MinIops. 
        /// <para>
        /// The minimum number of I/O operations per second (IOPS) that the additional storage
        /// volume supports.
        /// </para>
        /// </summary>
        public int? MinIops { get; set; }

        /// <summary>
        /// Checks to see if the MinIops property is set.
        /// </summary>
        internal bool IsSetMinIops() => this.MinIops.HasValue;

        /// <summary>
        /// Gets and sets the property MinIopsPerGib. 
        /// <para>
        /// The minimum ratio of I/O operations per second (IOPS) to gibibytes (GiB) of storage
        /// for the additional storage volume.
        /// </para>
        /// </summary>
        public double? MinIopsPerGib { get; set; }

        /// <summary>
        /// Checks to see if the MinIopsPerGib property is set.
        /// </summary>
        internal bool IsSetMinIopsPerGib() => this.MinIopsPerGib.HasValue;

        /// <summary>
        /// Gets and sets the property MinStorageSize. 
        /// <para>
        /// The minimum amount of storage that you can allocate for the additional storage volume,
        /// in gibibytes (GiB).
        /// </para>
        /// </summary>
        public int? MinStorageSize { get; set; }

        /// <summary>
        /// Checks to see if the MinStorageSize property is set.
        /// </summary>
        internal bool IsSetMinStorageSize() => this.MinStorageSize.HasValue;

        /// <summary>
        /// Gets and sets the property MinStorageThroughput. 
        /// <para>
        /// The minimum storage throughput that the additional storage volume supports, in mebibytes
        /// per second (MiBps).
        /// </para>
        /// </summary>
        public int? MinStorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the MinStorageThroughput property is set.
        /// </summary>
        internal bool IsSetMinStorageThroughput() => this.MinStorageThroughput.HasValue;

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
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property SupportsIops. 
        /// <para>
        /// Indicates whether the additional storage volume supports provisioned IOPS.
        /// </para>
        /// </summary>
        public bool? SupportsIops { get; set; }

        /// <summary>
        /// Checks to see if the SupportsIops property is set.
        /// </summary>
        internal bool IsSetSupportsIops() => this.SupportsIops.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsStorageAutoscaling. 
        /// <para>
        /// Indicates whether the additional storage volume supports storage autoscaling.
        /// </para>
        /// </summary>
        public bool? SupportsStorageAutoscaling { get; set; }

        /// <summary>
        /// Checks to see if the SupportsStorageAutoscaling property is set.
        /// </summary>
        internal bool IsSetSupportsStorageAutoscaling() => this.SupportsStorageAutoscaling.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsStorageThroughput. 
        /// <para>
        /// Indicates whether the additional storage volume supports configurable storage throughput.
        /// </para>
        /// </summary>
        public bool? SupportsStorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the SupportsStorageThroughput property is set.
        /// </summary>
        internal bool IsSetSupportsStorageThroughput() => this.SupportsStorageThroughput.HasValue;
    }
}
