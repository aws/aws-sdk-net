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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// The configuration of a disk of the Source Server to be replicated.
    /// </summary>
    public partial class ReplicationConfigurationReplicatedDisk
    {
        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The requested number of I/O operations per second (IOPS).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property IsBootDisk. 
        /// <para>
        /// Whether to boot from this disk or not.
        /// </para>
        /// </summary>
        public bool? IsBootDisk { get; set; }

        /// <summary>
        /// Checks to see if the IsBootDisk property is set.
        /// </summary>
        internal bool IsSetIsBootDisk() => this.IsBootDisk.HasValue;

        /// <summary>
        /// Gets and sets the property OptimizedStagingDiskType. 
        /// <para>
        /// The Staging Disk EBS volume type to be used during replication when <c>stagingDiskType</c>
        /// is set to Auto. This is a read-only field.
        /// </para>
        /// </summary>
        public ReplicationConfigurationReplicatedDiskStagingDiskType OptimizedStagingDiskType { get; set; }

        /// <summary>
        /// Checks to see if the OptimizedStagingDiskType property is set.
        /// </summary>
        internal bool IsSetOptimizedStagingDiskType() => this.OptimizedStagingDiskType != null;

        /// <summary>
        /// Gets and sets the property StagingDiskType. 
        /// <para>
        /// The Staging Disk EBS volume type to be used during replication.
        /// </para>
        /// </summary>
        public ReplicationConfigurationReplicatedDiskStagingDiskType StagingDiskType { get; set; }

        /// <summary>
        /// Checks to see if the StagingDiskType property is set.
        /// </summary>
        internal bool IsSetStagingDiskType() => this.StagingDiskType != null;

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput to use for the EBS volume in MiB/s. This parameter is valid only for
        /// gp3 volumes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Throughput { get; set; }

        /// <summary>
        /// Checks to see if the Throughput property is set.
        /// </summary>
        internal bool IsSetThroughput() => this.Throughput.HasValue;
    }
}
