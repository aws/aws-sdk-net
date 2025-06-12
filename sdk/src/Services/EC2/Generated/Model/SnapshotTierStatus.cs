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
    /// Provides information about a snapshot's storage tier.
    /// </summary>
    public partial class SnapshotTierStatus
    {
        private DateTime? _archivalCompleteTime;
        private TieringOperationStatus _lastTieringOperationStatus;
        private string _lastTieringOperationStatusDetail;
        private int? _lastTieringProgress;
        private DateTime? _lastTieringStartTime;
        private string _ownerId;
        private DateTime? _restoreExpiryTime;
        private string _snapshotId;
        private SnapshotState _status;
        private StorageTier _storageTier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property ArchivalCompleteTime. 
        /// <para>
        /// The date and time when the last archive process was completed.
        /// </para>
        /// </summary>
        public DateTime? ArchivalCompleteTime
        {
            get { return this._archivalCompleteTime; }
            set { this._archivalCompleteTime = value; }
        }

        // Check to see if ArchivalCompleteTime property is set
        internal bool IsSetArchivalCompleteTime()
        {
            return this._archivalCompleteTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastTieringOperationStatus. 
        /// <para>
        /// The status of the last archive or restore process.
        /// </para>
        /// </summary>
        public TieringOperationStatus LastTieringOperationStatus
        {
            get { return this._lastTieringOperationStatus; }
            set { this._lastTieringOperationStatus = value; }
        }

        // Check to see if LastTieringOperationStatus property is set
        internal bool IsSetLastTieringOperationStatus()
        {
            return this._lastTieringOperationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastTieringOperationStatusDetail. 
        /// <para>
        /// A message describing the status of the last archive or restore process.
        /// </para>
        /// </summary>
        public string LastTieringOperationStatusDetail
        {
            get { return this._lastTieringOperationStatusDetail; }
            set { this._lastTieringOperationStatusDetail = value; }
        }

        // Check to see if LastTieringOperationStatusDetail property is set
        internal bool IsSetLastTieringOperationStatusDetail()
        {
            return this._lastTieringOperationStatusDetail != null;
        }

        /// <summary>
        /// Gets and sets the property LastTieringProgress. 
        /// <para>
        /// The progress of the last archive or restore process, as a percentage.
        /// </para>
        /// </summary>
        public int? LastTieringProgress
        {
            get { return this._lastTieringProgress; }
            set { this._lastTieringProgress = value; }
        }

        // Check to see if LastTieringProgress property is set
        internal bool IsSetLastTieringProgress()
        {
            return this._lastTieringProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastTieringStartTime. 
        /// <para>
        /// The date and time when the last archive or restore process was started.
        /// </para>
        /// </summary>
        public DateTime? LastTieringStartTime
        {
            get { return this._lastTieringStartTime; }
            set { this._lastTieringStartTime = value; }
        }

        // Check to see if LastTieringStartTime property is set
        internal bool IsSetLastTieringStartTime()
        {
            return this._lastTieringStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the snapshot.
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
        /// The ID of the snapshot.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the snapshot.
        /// </para>
        /// </summary>
        public SnapshotState Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
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
        /// The tags that are assigned to the snapshot.
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
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume from which the snapshot was created.
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

    }
}