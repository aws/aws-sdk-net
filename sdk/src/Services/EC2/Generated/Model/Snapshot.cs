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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _availabilityZone;
        private int? _completionDurationMinutes;
        private DateTime? _completionTime;
        private string _dataEncryptionKeyId;
        private string _description;
        private bool? _encrypted;
        private long? _fullSnapshotSizeInBytes;
        private string _kmsKeyId;
        private string _outpostArn;
        private string _ownerAlias;
        private string _ownerId;
        private string _progress;
        private DateTime? _restoreExpiryTime;
        private string _snapshotId;
        private SSEType _sseType;
        private DateTime? _startTime;
        private SnapshotState _state;
        private string _stateMessage;
        private StorageTier _storageTier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TransferType _transferType;
        private string _volumeId;
        private int? _volumeSize;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone or Local Zone of the snapshot. For example, <c>us-west-1a</c>
        /// (Availability Zone) or <c>us-west-2-lax-1a</c> (Local Zone).
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

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
        public int? CompletionDurationMinutes
        {
            get { return this._completionDurationMinutes; }
            set { this._completionDurationMinutes = value; }
        }

        // Check to see if CompletionDurationMinutes property is set
        internal bool IsSetCompletionDurationMinutes()
        {
            return this._completionDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The time stamp when the snapshot was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime
        {
            get { return this._completionTime; }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

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
        public string DataEncryptionKeyId
        {
            get { return this._dataEncryptionKeyId; }
            set { this._dataEncryptionKeyId = value; }
        }

        // Check to see if DataEncryptionKeyId property is set
        internal bool IsSetDataEncryptionKeyId()
        {
            return this._dataEncryptionKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the snapshot.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the snapshot is encrypted.
        /// </para>
        /// </summary>
        public bool? Encrypted
        {
            get { return this._encrypted; }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

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
        public long? FullSnapshotSizeInBytes
        {
            get { return this._fullSnapshotSizeInBytes; }
            set { this._fullSnapshotSizeInBytes = value; }
        }

        // Check to see if FullSnapshotSizeInBytes property is set
        internal bool IsSetFullSnapshotSizeInBytes()
        {
            return this._fullSnapshotSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key that was used to protect the volume
        /// encryption key for the parent volume.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The ARN of the Outpost on which the snapshot is stored. For more information, see
        /// <a href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html">Amazon
        /// EBS local snapshots on Outposts</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAlias. 
        /// <para>
        /// The Amazon Web Services owner alias, from an Amazon-maintained list (<c>amazon</c>).
        /// This is not the user-configured Amazon Web Services account alias set using the IAM
        /// console.
        /// </para>
        /// </summary>
        public string OwnerAlias
        {
            get { return this._ownerAlias; }
            set { this._ownerAlias = value; }
        }

        // Check to see if OwnerAlias property is set
        internal bool IsSetOwnerAlias()
        {
            return this._ownerAlias != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the EBS snapshot.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The progress of the snapshot, as a percentage.
        /// </para>
        /// </summary>
        public string Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreExpiryTime. 
        /// <para>
        /// Only for archived snapshots that are temporarily restored. Indicates the date and
        /// time when a temporarily restored snapshot will be automatically re-archived.
        /// </para>
        /// </summary>
        public DateTime? RestoreExpiryTime
        {
            get { return this._restoreExpiryTime; }
            set { this._restoreExpiryTime = value; }
        }

        // Check to see if RestoreExpiryTime property is set
        internal bool IsSetRestoreExpiryTime()
        {
            return this._restoreExpiryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot. Each snapshot receives a unique identifier when it is created.
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property SseType. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public SSEType SseType
        {
            get { return this._sseType; }
            set { this._sseType = value; }
        }

        // Check to see if SseType property is set
        internal bool IsSetSseType()
        {
            return this._sseType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time stamp when the snapshot was initiated.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The snapshot state.
        /// </para>
        /// </summary>
        public SnapshotState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// Encrypted Amazon EBS snapshots are copied asynchronously. If a snapshot copy operation
        /// fails (for example, if the proper KMS permissions are not obtained) this field displays
        /// error state details to help you diagnose why the error occurred. This parameter is
        /// only returned by <a>DescribeSnapshots</a>.
        /// </para>
        /// </summary>
        public string StateMessage
        {
            get { return this._stateMessage; }
            set { this._stateMessage = value; }
        }

        // Check to see if StateMessage property is set
        internal bool IsSetStateMessage()
        {
            return this._stateMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StorageTier. 
        /// <para>
        /// The storage tier in which the snapshot is stored. <c>standard</c> indicates that the
        /// snapshot is stored in the standard snapshot storage tier and that it is ready for
        /// use. <c>archive</c> indicates that the snapshot is currently archived and that it
        /// must be restored before it can be used.
        /// </para>
        /// </summary>
        public StorageTier StorageTier
        {
            get { return this._storageTier; }
            set { this._storageTier = value; }
        }

        // Check to see if StorageTier property is set
        internal bool IsSetStorageTier()
        {
            return this._storageTier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public TransferType TransferType
        {
            get { return this._transferType; }
            set { this._transferType = value; }
        }

        // Check to see if TransferType property is set
        internal bool IsSetTransferType()
        {
            return this._transferType != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume that was used to create the snapshot. Snapshots created by a
        /// copy snapshot operation have an arbitrary volume ID that you should not use for any
        /// purpose.
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
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume, in GiB.
        /// </para>
        /// </summary>
        public int? VolumeSize
        {
            get { return this._volumeSize; }
            set { this._volumeSize = value; }
        }

        // Check to see if VolumeSize property is set
        internal bool IsSetVolumeSize()
        {
            return this._volumeSize.HasValue; 
        }

    }
}