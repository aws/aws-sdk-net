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
    /// Describes an iSCSI stored volume.
    /// </summary>
    public partial class StorediSCSIVolume
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the volume was created. Volumes created prior to March 28, 2017 don’t have
        /// this timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property KMSKey.
        /// </summary>
        [AWSProperty(Min = 7, Max = 2048)]
        public string KMSKey { get; set; }

        /// <summary>
        /// Checks to see if the KMSKey property is set.
        /// </summary>
        internal bool IsSetKMSKey() => this.KMSKey != null;

        /// <summary>
        /// Gets and sets the property PreservedExistingData. 
        /// <para>
        /// Indicates if when the stored volume was created, existing data on the underlying local
        /// disk was preserved.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool? PreservedExistingData { get; set; }

        /// <summary>
        /// Checks to see if the PreservedExistingData property is set.
        /// </summary>
        internal bool IsSetPreservedExistingData() => this.PreservedExistingData.HasValue;

        /// <summary>
        /// Gets and sets the property SourceSnapshotId. 
        /// <para>
        /// If the stored volume was created from a snapshot, this field contains the snapshot
        /// ID used, e.g. snap-78e22663. Otherwise, this field is not included.
        /// </para>
        /// </summary>
        public string SourceSnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SourceSnapshotId property is set.
        /// </summary>
        internal bool IsSetSourceSnapshotId() => this.SourceSnapshotId != null;

        /// <summary>
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The name of the iSCSI target used by an initiator to connect to a volume and used
        /// as a suffix for the target ARN. For example, specifying <c>TargetName</c> as <i>myvolume</i>
        /// results in the target ARN of <c>arn:aws:storagegateway:us-east-2:111122223333:gateway/sgw-12A3456B/target/iqn.1997-05.com.amazon:myvolume</c>.
        /// The target name must be unique across all volumes on a gateway.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, Storage Gateway uses the value that was previously used
        /// for this volume as the new target name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string TargetName { get; set; }

        /// <summary>
        /// Checks to see if the TargetName property is set.
        /// </summary>
        internal bool IsSetTargetName() => this.TargetName != null;

        /// <summary>
        /// Gets and sets the property VolumeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the storage volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string VolumeARN { get; set; }

        /// <summary>
        /// Checks to see if the VolumeARN property is set.
        /// </summary>
        internal bool IsSetVolumeARN() => this.VolumeARN != null;

        /// <summary>
        /// Gets and sets the property VolumeAttachmentStatus. 
        /// <para>
        /// A value that indicates whether a storage volume is attached to, detached from, or
        /// is in the process of detaching from a gateway. For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/managing-volumes.html#attach-detach-volume">Moving
        /// your volumes to a different gateway</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 50)]
        public string VolumeAttachmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the VolumeAttachmentStatus property is set.
        /// </summary>
        internal bool IsSetVolumeAttachmentStatus() => this.VolumeAttachmentStatus != null;

        /// <summary>
        /// Gets and sets the property VolumeDiskId. 
        /// <para>
        /// The ID of the local disk that was specified in the <a>CreateStorediSCSIVolume</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string VolumeDiskId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeDiskId property is set.
        /// </summary>
        internal bool IsSetVolumeDiskId() => this.VolumeDiskId != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The unique identifier of the volume, e.g., vol-AE4B946D.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 30)]
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;

        /// <summary>
        /// Gets and sets the property VolumeProgress. 
        /// <para>
        /// Represents the percentage complete if the volume is restoring or bootstrapping that
        /// represents the percent of data transferred. This field does not appear in the response
        /// if the stored volume is not restoring or bootstrapping.
        /// </para>
        /// </summary>
        public double? VolumeProgress { get; set; }

        /// <summary>
        /// Checks to see if the VolumeProgress property is set.
        /// </summary>
        internal bool IsSetVolumeProgress() => this.VolumeProgress.HasValue;

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
        /// Gets and sets the property VolumeStatus. 
        /// <para>
        /// One of the VolumeStatus values that indicates the state of the storage volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 50)]
        public string VolumeStatus { get; set; }

        /// <summary>
        /// Checks to see if the VolumeStatus property is set.
        /// </summary>
        internal bool IsSetVolumeStatus() => this.VolumeStatus != null;

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// One of the VolumeType enumeration values describing the type of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string VolumeType { get; set; }

        /// <summary>
        /// Checks to see if the VolumeType property is set.
        /// </summary>
        internal bool IsSetVolumeType() => this.VolumeType != null;

        /// <summary>
        /// Gets and sets the property VolumeUsedInBytes. 
        /// <para>
        /// The size of the data stored on the volume in bytes. This value is calculated based
        /// on the number of blocks that are touched, instead of the actual amount of data written.
        /// This value can be useful for sequential write patterns but less accurate for random
        /// write patterns. <c>VolumeUsedInBytes</c> is different from the compressed size of
        /// the volume, which is the value that is used to calculate your bill.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value is not available for volumes created prior to May 13, 2015, until you store
        /// data on the volume.
        /// </para>
        ///  </note>
        /// </summary>
        public long? VolumeUsedInBytes { get; set; }

        /// <summary>
        /// Checks to see if the VolumeUsedInBytes property is set.
        /// </summary>
        internal bool IsSetVolumeUsedInBytes() => this.VolumeUsedInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeiSCSIAttributes. 
        /// <para>
        /// An <a>VolumeiSCSIAttributes</a> object that represents a collection of iSCSI attributes
        /// for one stored volume.
        /// </para>
        /// </summary>
        public VolumeiSCSIAttributes VolumeiSCSIAttributes { get; set; }

        /// <summary>
        /// Checks to see if the VolumeiSCSIAttributes property is set.
        /// </summary>
        internal bool IsSetVolumeiSCSIAttributes() => this.VolumeiSCSIAttributes != null;
    }
}
