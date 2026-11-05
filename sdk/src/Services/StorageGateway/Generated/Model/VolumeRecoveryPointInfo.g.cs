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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Describes a storage volume recovery point object.
    /// </summary>
    public partial class VolumeRecoveryPointInfo
    {
        /// <summary>
        /// Gets and sets the property VolumeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the volume target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string VolumeARN { get; set; }

        /// <summary>
        /// Checks to see if the VolumeARN property is set.
        /// </summary>
        internal bool IsSetVolumeARN() => this.VolumeARN != null;

        /// <summary>
        /// Gets and sets the property VolumeRecoveryPointTime. 
        /// <para>
        /// The time the recovery point was taken.
        /// </para>
        /// </summary>
        public string VolumeRecoveryPointTime { get; set; }

        /// <summary>
        /// Checks to see if the VolumeRecoveryPointTime property is set.
        /// </summary>
        internal bool IsSetVolumeRecoveryPointTime() => this.VolumeRecoveryPointTime != null;

        /// <summary>
        /// Gets and sets the property VolumeSizeInBytes. 
        /// <para>
        /// The size of the volume in bytes.
        /// </para>
        /// </summary>
        public long? VolumeSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeInBytes property is set.
        /// </summary>
        internal bool IsSetVolumeSizeInBytes() => this.VolumeSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeUsageInBytes. 
        /// <para>
        /// The size of the data stored on the volume in bytes.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value is not available for volumes created prior to May 13, 2015, until you store
        /// data on the volume.
        /// </para>
        ///  </note>
        /// </summary>
        public long? VolumeUsageInBytes { get; set; }

        /// <summary>
        /// Checks to see if the VolumeUsageInBytes property is set.
        /// </summary>
        internal bool IsSetVolumeUsageInBytes() => this.VolumeUsageInBytes.HasValue;
    }
}
