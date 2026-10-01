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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Request to query disks replicated.
    /// </summary>
    public partial class DataReplicationInfoReplicatedDisk
    {
        /// <summary>
        /// Gets and sets the property BackloggedStorageBytes. 
        /// <para>
        /// Request to query data replication backlog size in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? BackloggedStorageBytes { get; set; }

        /// <summary>
        /// Checks to see if the BackloggedStorageBytes property is set.
        /// </summary>
        internal bool IsSetBackloggedStorageBytes() => this.BackloggedStorageBytes.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// Request to query device name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property ReplicatedStorageBytes. 
        /// <para>
        /// Request to query amount of data replicated in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ReplicatedStorageBytes { get; set; }

        /// <summary>
        /// Checks to see if the ReplicatedStorageBytes property is set.
        /// </summary>
        internal bool IsSetReplicatedStorageBytes() => this.ReplicatedStorageBytes.HasValue;

        /// <summary>
        /// Gets and sets the property RescannedStorageBytes. 
        /// <para>
        /// Request to query amount of data rescanned in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? RescannedStorageBytes { get; set; }

        /// <summary>
        /// Checks to see if the RescannedStorageBytes property is set.
        /// </summary>
        internal bool IsSetRescannedStorageBytes() => this.RescannedStorageBytes.HasValue;

        /// <summary>
        /// Gets and sets the property TotalStorageBytes. 
        /// <para>
        /// Request to query total amount of data replicated in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalStorageBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalStorageBytes property is set.
        /// </summary>
        internal bool IsSetTotalStorageBytes() => this.TotalStorageBytes.HasValue;
    }
}
