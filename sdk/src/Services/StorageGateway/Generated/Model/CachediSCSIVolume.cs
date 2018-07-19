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
    /// Describes an iSCSI cached volume.
    /// </summary>
    public partial class CachediSCSIVolume
    {
        private DateTime? _createdDate;
        private string _kmsKey;
        private string _sourceSnapshotId;
        private string _volumeARN;
        private string _volumeId;
        private VolumeiSCSIAttributes _volumeiSCSIAttributes;
        private double? _volumeProgress;
        private long? _volumeSizeInBytes;
        private string _volumeStatus;
        private string _volumeType;
        private long? _volumeUsedInBytes;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the volume was created. Volumes created prior to March 28, 2017 don’t have
        /// this time stamp.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSKey.
        /// </summary>
        public string KMSKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KMSKey property is set
        internal bool IsSetKMSKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotId. 
        /// <para>
        /// If the cached volume was created from a snapshot, this field contains the snapshot
        /// ID used, e.g. snap-78e22663. Otherwise, this field is not included.
        /// </para>
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
        /// <para>
        /// The Amazon Resource Name (ARN) of the storage volume.
        /// </para>
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
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The unique identifier of the volume, e.g. vol-AE4B946D.
        /// </para>
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
        /// <para>
        /// An <a>VolumeiSCSIAttributes</a> object that represents a collection of iSCSI attributes
        /// for one stored volume.
        /// </para>
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
        /// <para>
        /// Represents the percentage complete if the volume is restoring or bootstrapping that
        /// represents the percent of data transferred. This field does not appear in the response
        /// if the cached volume is not restoring or bootstrapping.
        /// </para>
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
        /// <para>
        /// The size, in bytes, of the volume capacity.
        /// </para>
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
        /// <para>
        /// One of the VolumeStatus values that indicates the state of the storage volume.
        /// </para>
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
        /// <para>
        /// One of the VolumeType enumeration values that describes the type of the volume.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property VolumeUsedInBytes. 
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
        public long VolumeUsedInBytes
        {
            get { return this._volumeUsedInBytes.GetValueOrDefault(); }
            set { this._volumeUsedInBytes = value; }
        }

        // Check to see if VolumeUsedInBytes property is set
        internal bool IsSetVolumeUsedInBytes()
        {
            return this._volumeUsedInBytes.HasValue; 
        }

    }
}