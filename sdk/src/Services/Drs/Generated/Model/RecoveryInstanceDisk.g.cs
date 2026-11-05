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
    /// An object representing a block storage device on the Recovery Instance.
    /// </summary>
    public partial class RecoveryInstanceDisk
    {
        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// The amount of storage on the disk in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Bytes { get; set; }

        /// <summary>
        /// Checks to see if the Bytes property is set.
        /// </summary>
        internal bool IsSetBytes() => this.Bytes.HasValue;

        /// <summary>
        /// Gets and sets the property EbsVolumeID. 
        /// <para>
        /// The EBS Volume ID of this disk.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 19)]
        public string EbsVolumeID { get; set; }

        /// <summary>
        /// Checks to see if the EbsVolumeID property is set.
        /// </summary>
        internal bool IsSetEbsVolumeID() => this.EbsVolumeID != null;

        /// <summary>
        /// Gets and sets the property InternalDeviceName. 
        /// <para>
        /// The internal device name of this disk. This is the name that is visible on the machine
        /// itself and not from the EC2 console.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string InternalDeviceName { get; set; }

        /// <summary>
        /// Checks to see if the InternalDeviceName property is set.
        /// </summary>
        internal bool IsSetInternalDeviceName() => this.InternalDeviceName != null;
    }
}
