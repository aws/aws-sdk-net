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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Drs.Model
{
    /// <summary>
    /// An object representing a block storage device on the Recovery Instance.
    /// </summary>
    public partial class RecoveryInstanceDisk
    {
        private long? _bytes;
        private string _ebsVolumeID;
        private string _internalDeviceName;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// The amount of storage on the disk in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? Bytes
        {
            get { return this._bytes; }
            set { this._bytes = value; }
        }

        // Check to see if Bytes property is set
        internal bool IsSetBytes()
        {
            return this._bytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbsVolumeID. 
        /// <para>
        /// The EBS Volume ID of this disk.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=19)]
        public string EbsVolumeID
        {
            get { return this._ebsVolumeID; }
            set { this._ebsVolumeID = value; }
        }

        // Check to see if EbsVolumeID property is set
        internal bool IsSetEbsVolumeID()
        {
            return this._ebsVolumeID != null;
        }

        /// <summary>
        /// Gets and sets the property InternalDeviceName. 
        /// <para>
        /// The internal device name of this disk. This is the name that is visible on the machine
        /// itself and not from the EC2 console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string InternalDeviceName
        {
            get { return this._internalDeviceName; }
            set { this._internalDeviceName = value; }
        }

        // Check to see if InternalDeviceName property is set
        internal bool IsSetInternalDeviceName()
        {
            return this._internalDeviceName != null;
        }

    }
}