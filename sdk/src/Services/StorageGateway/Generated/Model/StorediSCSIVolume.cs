/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class StorediSCSIVolume
    {
        private bool? _preservedExistingData;
        private string _sourceSnapshotId;
        private string _volumeARN;
        private string _volumeDiskId;
        private string _volumeId;
        private VolumeiSCSIAttributes _volumeiSCSIAttributes;
        private double? _volumeProgress;
        private long? _volumeSizeInBytes;
        private string _volumeStatus;
        private string _volumeType;

        /// <summary>
        /// Gets and sets the property PreservedExistingData.
        /// </summary>
        public bool PreservedExistingData
        {
            get { return this._preservedExistingData.GetValueOrDefault(); }
            set { this._preservedExistingData = value; }
        }

        // Check to see if PreservedExistingData property is set
        internal bool IsSetPreservedExistingData()
        {
            return this._preservedExistingData.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotId.
        /// </summary>
        public string SourceSnapshotId
        {
            get { return this._sourceSnapshotId; }
            set { this._sourceSnapshotId = value; }
        }

        // Check to see if SourceSnapshotId property is set
        internal bool IsSetSourceSnapshotId()
        {
            return this._sourceSnapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeARN.
        /// </summary>
        public string VolumeARN
        {
            get { return this._volumeARN; }
            set { this._volumeARN = value; }
        }

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this._volumeARN != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeDiskId.
        /// </summary>
        public string VolumeDiskId
        {
            get { return this._volumeDiskId; }
            set { this._volumeDiskId = value; }
        }

        // Check to see if VolumeDiskId property is set
        internal bool IsSetVolumeDiskId()
        {
            return this._volumeDiskId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId.
        /// </summary>
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeiSCSIAttributes.
        /// </summary>
        public VolumeiSCSIAttributes VolumeiSCSIAttributes
        {
            get { return this._volumeiSCSIAttributes; }
            set { this._volumeiSCSIAttributes = value; }
        }

        // Check to see if VolumeiSCSIAttributes property is set
        internal bool IsSetVolumeiSCSIAttributes()
        {
            return this._volumeiSCSIAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeProgress.
        /// </summary>
        public double VolumeProgress
        {
            get { return this._volumeProgress.GetValueOrDefault(); }
            set { this._volumeProgress = value; }
        }

        // Check to see if VolumeProgress property is set
        internal bool IsSetVolumeProgress()
        {
            return this._volumeProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeSizeInBytes.
        /// </summary>
        public long VolumeSizeInBytes
        {
            get { return this._volumeSizeInBytes.GetValueOrDefault(); }
            set { this._volumeSizeInBytes = value; }
        }

        // Check to see if VolumeSizeInBytes property is set
        internal bool IsSetVolumeSizeInBytes()
        {
            return this._volumeSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeStatus.
        /// </summary>
        public string VolumeStatus
        {
            get { return this._volumeStatus; }
            set { this._volumeStatus = value; }
        }

        // Check to see if VolumeStatus property is set
        internal bool IsSetVolumeStatus()
        {
            return this._volumeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeType.
        /// </summary>
        public string VolumeType
        {
            get { return this._volumeType; }
            set { this._volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this._volumeType != null;
        }

    }
}