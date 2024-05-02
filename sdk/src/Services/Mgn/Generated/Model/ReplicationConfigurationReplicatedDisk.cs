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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Replication Configuration replicated disk.
    /// </summary>
    public partial class ReplicationConfigurationReplicatedDisk
    {
        private string _deviceName;
        private long? _iops;
        private bool? _isBootDisk;
        private ReplicationConfigurationReplicatedDiskStagingDiskType _stagingDiskType;
        private long? _throughput;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// Replication Configuration replicated disk device name.
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
        /// Replication Configuration replicated disk IOPs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? Iops
        {
            get { return this._iops; }
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
        /// Replication Configuration replicated disk boot disk.
        /// </para>
        /// </summary>
        public bool? IsBootDisk
        {
            get { return this._isBootDisk; }
            set { this._isBootDisk = value; }
        }

        // Check to see if IsBootDisk property is set
        internal bool IsSetIsBootDisk()
        {
            return this._isBootDisk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StagingDiskType. 
        /// <para>
        /// Replication Configuration replicated disk staging disk type.
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
        /// Replication Configuration replicated disk throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? Throughput
        {
            get { return this._throughput; }
            set { this._throughput = value; }
        }

        // Check to see if Throughput property is set
        internal bool IsSetThroughput()
        {
            return this._throughput.HasValue; 
        }

    }
}