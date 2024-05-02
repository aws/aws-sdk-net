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
    /// Request to query disks replicated.
    /// </summary>
    public partial class DataReplicationInfoReplicatedDisk
    {
        private long? _backloggedStorageBytes;
        private string _deviceName;
        private long? _replicatedStorageBytes;
        private long? _rescannedStorageBytes;
        private long? _totalStorageBytes;

        /// <summary>
        /// Gets and sets the property BackloggedStorageBytes. 
        /// <para>
        /// Request to query data replication backlog size in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? BackloggedStorageBytes
        {
            get { return this._backloggedStorageBytes; }
            set { this._backloggedStorageBytes = value; }
        }

        // Check to see if BackloggedStorageBytes property is set
        internal bool IsSetBackloggedStorageBytes()
        {
            return this._backloggedStorageBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// Request to query device name.
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
        /// Gets and sets the property ReplicatedStorageBytes. 
        /// <para>
        /// Request to query amount of data replicated in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ReplicatedStorageBytes
        {
            get { return this._replicatedStorageBytes; }
            set { this._replicatedStorageBytes = value; }
        }

        // Check to see if ReplicatedStorageBytes property is set
        internal bool IsSetReplicatedStorageBytes()
        {
            return this._replicatedStorageBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RescannedStorageBytes. 
        /// <para>
        /// Request to query amount of data rescanned in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? RescannedStorageBytes
        {
            get { return this._rescannedStorageBytes; }
            set { this._rescannedStorageBytes = value; }
        }

        // Check to see if RescannedStorageBytes property is set
        internal bool IsSetRescannedStorageBytes()
        {
            return this._rescannedStorageBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalStorageBytes. 
        /// <para>
        /// Request to query total amount of data replicated in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? TotalStorageBytes
        {
            get { return this._totalStorageBytes; }
            set { this._totalStorageBytes = value; }
        }

        // Check to see if TotalStorageBytes property is set
        internal bool IsSetTotalStorageBytes()
        {
            return this._totalStorageBytes.HasValue; 
        }

    }
}