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
    /// <summary>Create Snapshot From Volume Recovery Point Result
    /// </summary>
    public partial class CreateSnapshotFromVolumeRecoveryPointResult
    {
        
        private string snapshotId;
        private string volumeARN;
        private string volumeRecoveryPointTime;
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
