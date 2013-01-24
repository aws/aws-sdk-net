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
    /// <para>A JSON object containing the following fields:</para>
    /// <ul>
    /// <li> CreateSnapshotFromVolumeRecoveryPointOutput$SnapshotId </li>
    /// <li> CreateSnapshotFromVolumeRecoveryPointOutput$VolumeARN </li>
    /// <li> CreateSnapshotFromVolumeRecoveryPointOutput$VolumeRecoveryPointTime </li>
    /// 
    /// </ul>
    /// </summary>
    public class CreateSnapshotFromVolumeRecoveryPointResult  
    {
        
        private string snapshotId;
        private string volumeARN;
        private string volumeRecoveryPointTime;

        /// <summary>
        /// The snapshot ID that is used to refer to the snapshot in future operations such as describing snapshots (Amazon Elastic Compute Cloud API
        /// DescribeSnapshots) or creating a volume from a snapshot (<a>CreateStorediSCSIVolume</a>).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>\Asnap-[0-9a-fA-F]{8}\z</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this.snapshotId; }
            set { this.snapshotId = value; }
        }

        /// <summary>
        /// Sets the SnapshotId property
        /// </summary>
        /// <param name="snapshotId">The value to set for the SnapshotId property </param>
        /// <returns>this instance</returns>
        public CreateSnapshotFromVolumeRecoveryPointResult WithSnapshotId(string snapshotId)
        {
            this.snapshotId = snapshotId;
            return this;
        }
            

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this.snapshotId != null;       
        }

        /// <summary>
        /// The ARN of the volume of which the snapshot was taken. Obtain volume ARNs from the <a>ListVolumes</a> operation.
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
        public CreateSnapshotFromVolumeRecoveryPointResult WithVolumeARN(string volumeARN)
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
        /// The time of the recovery point. Data up to this recovery point are included in the snapshot. <emphasis>Type</emphasis>: String format of a
        /// date in the ISO8601 extended YYYY-MM-DD'T'HH:MM:SS'Z' format.
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
        public CreateSnapshotFromVolumeRecoveryPointResult WithVolumeRecoveryPointTime(string volumeRecoveryPointTime)
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
