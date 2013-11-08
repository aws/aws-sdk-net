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
    /// <summary>Cachedi S C S I Volume
    /// </summary>
    public class CachediSCSIVolume
    {
        
        private string volumeARN;
        private string volumeId;
        private string volumeType;
        private string volumeStatus;
        private long? volumeSizeInBytes;
        private double? volumeProgress;
        private string sourceSnapshotId;
        private VolumeiSCSIAttributes volumeiSCSIAttributes;

        public string VolumeARN
        {
            get { return this.volumeARN; }
            set { this.volumeARN = value; }
        }

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this.volumeARN != null;
        }
        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;
        }
        public string VolumeType
        {
            get { return this.volumeType; }
            set { this.volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this.volumeType != null;
        }
        public string VolumeStatus
        {
            get { return this.volumeStatus; }
            set { this.volumeStatus = value; }
        }

        // Check to see if VolumeStatus property is set
        internal bool IsSetVolumeStatus()
        {
            return this.volumeStatus != null;
        }
        public long VolumeSizeInBytes
        {
            get { return this.volumeSizeInBytes ?? default(long); }
            set { this.volumeSizeInBytes = value; }
        }

        // Check to see if VolumeSizeInBytes property is set
        internal bool IsSetVolumeSizeInBytes()
        {
            return this.volumeSizeInBytes.HasValue;
        }
        public double VolumeProgress
        {
            get { return this.volumeProgress ?? default(double); }
            set { this.volumeProgress = value; }
        }

        // Check to see if VolumeProgress property is set
        internal bool IsSetVolumeProgress()
        {
            return this.volumeProgress.HasValue;
        }
        public string SourceSnapshotId
        {
            get { return this.sourceSnapshotId; }
            set { this.sourceSnapshotId = value; }
        }

        // Check to see if SourceSnapshotId property is set
        internal bool IsSetSourceSnapshotId()
        {
            return this.sourceSnapshotId != null;
        }

        /// <summary>
        /// Lists iSCSI information about a volume.
        ///  
        /// </summary>
        public VolumeiSCSIAttributes VolumeiSCSIAttributes
        {
            get { return this.volumeiSCSIAttributes; }
            set { this.volumeiSCSIAttributes = value; }
        }

        // Check to see if VolumeiSCSIAttributes property is set
        internal bool IsSetVolumeiSCSIAttributes()
        {
            return this.volumeiSCSIAttributes != null;
        }
    }
}
