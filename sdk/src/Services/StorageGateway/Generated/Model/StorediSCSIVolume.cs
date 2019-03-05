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
    /// Describes an iSCSI stored volume.
    /// </summary>
    public partial class StorediSCSIVolume
    {
        private DateTime? _createdDate;
        private string _kmsKey;
        private bool? _preservedExistingData;
        private string _sourceSnapshotId;
        private string _targetName;
        private string _volumeARN;
        private string _volumeAttachmentStatus;
        private string _volumeDiskId;
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
        /// Gets and sets the property PreservedExistingData. 
        /// <para>
        /// Indicates if when the stored volume was created, existing data on the underlying local
        /// disk was preserved.
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: true, false
        /// </para>
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
        /// <para>
        /// If the stored volume was created from a snapshot, this field contains the snapshot
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
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The name of the iSCSI target used by an initiator to connect to a volume and used
        /// as a suffix for the target ARN. For example, specifying <code>TargetName</code> as
        /// <i>myvolume</i> results in the target ARN of <code>arn:aws:storagegateway:us-east-2:111122223333:gateway/sgw-12A3456B/target/iqn.1997-05.com.amazon:myvolume</code>.
        /// The target name must be unique across all volumes on a gateway.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, Storage Gateway uses the value that was previously used
        /// for this volume as the new target name.
        /// </para>
        /// </summary>
        public string TargetName
        {
            get { return this._targetName; }
            set { this._targetName = value; }
        }

        // Check to see if TargetName property is set
        internal bool IsSetTargetName()
        {
            return this._targetName != null;
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
        /// Gets and sets the property VolumeAttachmentStatus. 
        /// <para>
        /// A value that indicates whether a storage volume is attached to, detached from, or
        /// is in the process of detaching from a gateway. For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/managing-volumes.html#attach-detach-volume">Moving
        /// Your Volumes to a Different Gateway</a>.
        /// </para>
        /// </summary>
        public string VolumeAttachmentStatus
        {
            get { return this._volumeAttachmentStatus; }
            set { this._volumeAttachmentStatus = value; }
        }

        // Check to see if VolumeAttachmentStatus property is set
        internal bool IsSetVolumeAttachmentStatus()
        {
            return this._volumeAttachmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeDiskId. 
        /// <para>
        /// The ID of the local disk that was specified in the <a>CreateStorediSCSIVolume</a>
        /// operation.
        /// </para>
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
        /// if the stored volume is not restoring or bootstrapping.
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
        /// The size of the volume in bytes.
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
        /// One of the VolumeType enumeration values describing the type of the volume.
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