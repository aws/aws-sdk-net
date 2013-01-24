/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>Lists information about the recovery points of a cached volume.</para>
    /// </summary>
    public class VolumeRecoveryPointInfo  
    {
        
        private string volumeARN;
        private long? volumeSizeInBytes;
        private long? volumeUsageInBytes;
        private string volumeRecoveryPointTime;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the volume associated with the recovery point.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VolumeARN
        {
            get { return this.volumeARN; }
            set { this.volumeARN = value; }
        }

        /// <summary>
        /// Sets the VolumeARN property
        /// </summary>
        /// <param name="volumeARN">The value to set for the VolumeARN property </param>
        /// <returns>this instance</returns>
        public VolumeRecoveryPointInfo WithVolumeARN(string volumeARN)
        {
            this.volumeARN = volumeARN;
            return this;
        }
            

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this.volumeARN != null;       
        }

        /// <summary>
        /// The size, in bytes, of the volume to which the recovery point is associated.
        ///  
        /// </summary>
        public long VolumeSizeInBytes
        {
            get { return this.volumeSizeInBytes ?? default(long); }
            set { this.volumeSizeInBytes = value; }
        }

        /// <summary>
        /// Sets the VolumeSizeInBytes property
        /// </summary>
        /// <param name="volumeSizeInBytes">The value to set for the VolumeSizeInBytes property </param>
        /// <returns>this instance</returns>
        public VolumeRecoveryPointInfo WithVolumeSizeInBytes(long volumeSizeInBytes)
        {
            this.volumeSizeInBytes = volumeSizeInBytes;
            return this;
        }
            

        // Check to see if VolumeSizeInBytes property is set
        internal bool IsSetVolumeSizeInBytes()
        {
            return this.volumeSizeInBytes.HasValue;       
        }

        /// <summary>
        /// The size, in bytes, of the volume in use at the time of the recovery point.
        ///  
        /// </summary>
        public long VolumeUsageInBytes
        {
            get { return this.volumeUsageInBytes ?? default(long); }
            set { this.volumeUsageInBytes = value; }
        }

        /// <summary>
        /// Sets the VolumeUsageInBytes property
        /// </summary>
        /// <param name="volumeUsageInBytes">The value to set for the VolumeUsageInBytes property </param>
        /// <returns>this instance</returns>
        public VolumeRecoveryPointInfo WithVolumeUsageInBytes(long volumeUsageInBytes)
        {
            this.volumeUsageInBytes = volumeUsageInBytes;
            return this;
        }
            

        // Check to see if VolumeUsageInBytes property is set
        internal bool IsSetVolumeUsageInBytes()
        {
            return this.volumeUsageInBytes.HasValue;       
        }

        /// <summary>
        /// The time of the recovery point. The format of the time is in the ISO8601 extended YYYY-MM-DD'T'HH:MM:SS'Z' format.
        ///  
        /// </summary>
        public string VolumeRecoveryPointTime
        {
            get { return this.volumeRecoveryPointTime; }
            set { this.volumeRecoveryPointTime = value; }
        }

        /// <summary>
        /// Sets the VolumeRecoveryPointTime property
        /// </summary>
        /// <param name="volumeRecoveryPointTime">The value to set for the VolumeRecoveryPointTime property </param>
        /// <returns>this instance</returns>
        public VolumeRecoveryPointInfo WithVolumeRecoveryPointTime(string volumeRecoveryPointTime)
        {
            this.volumeRecoveryPointTime = volumeRecoveryPointTime;
            return this;
        }
            

        // Check to see if VolumeRecoveryPointTime property is set
        internal bool IsSetVolumeRecoveryPointTime()
        {
            return this.volumeRecoveryPointTime != null;       
        }
    }
}
