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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a snapshot.
    /// </summary>
    public partial class Snapshot
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone or Local Zone of the snapshot. For example, <c>us-west-1a</c>
        /// (Availability Zone) or <c>us-west-2-lax-1a</c> (Local Zone).
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property CompletionDurationMinutes. <note> 
        /// <para>
        /// Only for snapshot copies created with time-based snapshot copy operations.
        /// </para>
        ///  </note> 
        /// <para>
        /// The completion duration requested for the time-based snapshot copy operation.
        /// </para>
        /// </summary>
        public int? CompletionDurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the CompletionDurationMinutes property is set.
        /// </summary>
        internal bool IsSetCompletionDurationMinutes() => this.CompletionDurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The time stamp when the snapshot was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataEncryptionKeyId. 
        /// <para>
        /// The data encryption key identifier for the snapshot. This value is a unique identifier
        /// that corresponds to the data encryption key that was used to encrypt the original
        /// volume or snapshot copy. Because data encryption keys are inherited by volumes created
        /// from snapshots, and vice versa, if snapshots share the same data encryption key identifier,
        /// then they belong to the same volume/snapshot lineage. This parameter is only returned
        /// by <a>DescribeSnapshots</a>.
        /// </para>
        /// </summary>
        public string DataEncryptionKeyId { get; set; }

        /// <summary>
        /// Checks to see if the DataEncryptionKeyId property is set.
        /// </summary>
        internal bool IsSetDataEncryptionKeyId() => this.DataEncryptionKeyId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the snapshot.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the snapshot is encrypted.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property FullSnapshotSizeInBytes. 
        /// <para>
        /// The full size of the snapshot, in bytes.
        /// </para>
        ///  <important> 
        /// <para>
        /// This is <b>not</b> the incremental size of the snapshot. This is the full snapshot
        /// size and represents the size of all the blocks that were written to the source volume
        /// at the time the snapshot was created.
        /// </para>
        ///  </important>
        /// </summary>
        public long? FullSnapshotSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the FullSnapshotSizeInBytes property is set.
        /// </summary>
        internal bool IsSetFullSnapshotSizeInBytes() => this.FullSnapshotSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key that was used to protect the volume
        /// encryption key for the parent volume.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The ARN of the Outpost on which the snapshot is stored. For more information, see
        /// <a href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html">Amazon
        /// EBS local snapshots on Outposts</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property OwnerAlias. 
        /// <para>
        /// The Amazon Web Services owner alias, from an Amazon-maintained list (<c>amazon</c>).
        /// This is not the user-configured Amazon Web Services account alias set using the IAM
        /// console.
        /// </para>
        /// </summary>
        public string OwnerAlias { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAlias property is set.
        /// </summary>
        internal bool IsSetOwnerAlias() => this.OwnerAlias != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the EBS snapshot.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The progress of the snapshot, as a percentage.
        /// </para>
        /// </summary>
        public string Progress { get; set; }

        /// <summary>
        /// Checks to see if the Progress property is set.
        /// </summary>
        internal bool IsSetProgress() => this.Progress != null;

        /// <summary>
        /// Gets and sets the property RestoreExpiryTime. 
        /// <para>
        /// Only for archived snapshots that are temporarily restored. Indicates the date and
        /// time when a temporarily restored snapshot will be automatically re-archived.
        /// </para>
        /// </summary>
        public DateTime? RestoreExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the RestoreExpiryTime property is set.
        /// </summary>
        internal bool IsSetRestoreExpiryTime() => this.RestoreExpiryTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot. Each snapshot receives a unique identifier when it is created.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property SseType. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public SSEType SseType { get; set; }

        /// <summary>
        /// Checks to see if the SseType property is set.
        /// </summary>
        internal bool IsSetSseType() => this.SseType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time stamp when the snapshot was initiated.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The snapshot state.
        /// </para>
        /// </summary>
        public SnapshotState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// Encrypted Amazon EBS snapshots are copied asynchronously. If a snapshot copy operation
        /// fails (for example, if the proper KMS permissions are not obtained) this field displays
        /// error state details to help you diagnose why the error occurred. This parameter is
        /// only returned by <a>DescribeSnapshots</a>.
        /// </para>
        /// </summary>
        public string StateMessage { get; set; }

        /// <summary>
        /// Checks to see if the StateMessage property is set.
        /// </summary>
        internal bool IsSetStateMessage() => this.StateMessage != null;

        /// <summary>
        /// Gets and sets the property StorageTier. 
        /// <para>
        /// The storage tier in which the snapshot is stored. <c>standard</c> indicates that the
        /// snapshot is stored in the standard snapshot storage tier and that it is ready for
        /// use. <c>archive</c> indicates that the snapshot is currently archived and that it
        /// must be restored before it can be used.
        /// </para>
        /// </summary>
        public StorageTier StorageTier { get; set; }

        /// <summary>
        /// Checks to see if the StorageTier property is set.
        /// </summary>
        internal bool IsSetStorageTier() => this.StorageTier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransferType. <note> 
        /// <para>
        /// Only for snapshot copies.
        /// </para>
        ///  </note> 
        /// <para>
        /// Indicates whether the snapshot copy was created with a standard or time-based snapshot
        /// copy operation. Time-based snapshot copy operations complete within the completion
        /// duration specified in the request. Standard snapshot copy operations are completed
        /// on a best-effort basis.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>standard</c> - The snapshot copy was created with a standard snapshot copy operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>time-based</c> - The snapshot copy was created with a time-based snapshot copy
        /// operation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TransferType TransferType { get; set; }

        /// <summary>
        /// Checks to see if the TransferType property is set.
        /// </summary>
        internal bool IsSetTransferType() => this.TransferType != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume that was used to create the snapshot. Snapshots created by a
        /// copy snapshot operation have an arbitrary volume ID that you should not use for any
        /// purpose.
        /// </para>
        /// </summary>
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume, in GiB.
        /// </para>
        /// </summary>
        public int? VolumeSize { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSize property is set.
        /// </summary>
        internal bool IsSetVolumeSize() => this.VolumeSize.HasValue;
    }
}
