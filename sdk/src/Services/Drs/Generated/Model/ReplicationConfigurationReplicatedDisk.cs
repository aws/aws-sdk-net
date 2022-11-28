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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// The configuration of a disk of the Source Server to be replicated.
    /// </summary>
    public partial class ReplicationConfigurationReplicatedDisk
    {
        private string _deviceName;
        private long? _iops;
        private bool? _isBootDisk;
        private ReplicationConfigurationReplicatedDiskStagingDiskType _optimizedStagingDiskType;
        private ReplicationConfigurationReplicatedDiskStagingDiskType _stagingDiskType;
        private long? _throughput;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The requested number of I/O operations per second (IOPS).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsBootDisk. 
        /// <para>
        /// Whether to boot from this disk or not.
        /// </para>
        /// </summary>
        public bool IsBootDisk
        {
            get { return this._isBootDisk.GetValueOrDefault(); }
            set { this._isBootDisk = value; }
        }

        // Check to see if IsBootDisk property is set
        internal bool IsSetIsBootDisk()
        {
            return this._isBootDisk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptimizedStagingDiskType. 
        /// <para>
        /// When <code>stagingDiskType</code> is set to Auto, this field shows the current staging
        /// disk EBS volume type as it is constantly updated by the service. This is a read-only
        /// field.
        /// </para>
        /// </summary>
        public ReplicationConfigurationReplicatedDiskStagingDiskType OptimizedStagingDiskType
        {
            get { return this._optimizedStagingDiskType; }
            set { this._optimizedStagingDiskType = value; }
        }

        // Check to see if OptimizedStagingDiskType property is set
        internal bool IsSetOptimizedStagingDiskType()
        {
            return this._optimizedStagingDiskType != null;
        }

        /// <summary>
        /// Gets and sets the property StagingDiskType. 
        /// <para>
        /// The Staging Disk EBS volume type to be used during replication.
        /// </para>
        /// </summary>
        public ReplicationConfigurationReplicatedDiskStagingDiskType StagingDiskType
        {
            get { return this._stagingDiskType; }
            set { this._stagingDiskType = value; }
        }

        // Check to see if StagingDiskType property is set
        internal bool IsSetStagingDiskType()
        {
            return this._stagingDiskType != null;
        }

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput to use for the EBS volume in MiB/s. This parameter is valid only for
        /// gp3 volumes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long Throughput
        {
            get { return this._throughput.GetValueOrDefault(); }
            set { this._throughput = value; }
        }

        // Check to see if Throughput property is set
        internal bool IsSetThroughput()
        {
            return this._throughput.HasValue; 
        }

    }
}