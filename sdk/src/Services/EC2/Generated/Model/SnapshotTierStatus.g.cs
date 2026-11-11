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
    /// Provides information about a snapshot's storage tier.
    /// </summary>
    public partial class SnapshotTierStatus
    {
        /// <summary>
        /// Gets and sets the property ArchivalCompleteTime. 
        /// <para>
        /// The date and time when the last archive process was completed.
        /// </para>
        /// </summary>
        public DateTime? ArchivalCompleteTime { get; set; }

        /// <summary>
        /// Checks to see if the ArchivalCompleteTime property is set.
        /// </summary>
        internal bool IsSetArchivalCompleteTime() => this.ArchivalCompleteTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastTieringOperationStatus. 
        /// <para>
        /// The status of the last archive or restore process.
        /// </para>
        /// </summary>
        public TieringOperationStatus LastTieringOperationStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastTieringOperationStatus property is set.
        /// </summary>
        internal bool IsSetLastTieringOperationStatus() => this.LastTieringOperationStatus != null;

        /// <summary>
        /// Gets and sets the property LastTieringOperationStatusDetail. 
        /// <para>
        /// A message describing the status of the last archive or restore process.
        /// </para>
        /// </summary>
        public string LastTieringOperationStatusDetail { get; set; }

        /// <summary>
        /// Checks to see if the LastTieringOperationStatusDetail property is set.
        /// </summary>
        internal bool IsSetLastTieringOperationStatusDetail() => this.LastTieringOperationStatusDetail != null;

        /// <summary>
        /// Gets and sets the property LastTieringProgress. 
        /// <para>
        /// The progress of the last archive or restore process, as a percentage.
        /// </para>
        /// </summary>
        public int? LastTieringProgress { get; set; }

        /// <summary>
        /// Checks to see if the LastTieringProgress property is set.
        /// </summary>
        internal bool IsSetLastTieringProgress() => this.LastTieringProgress.HasValue;

        /// <summary>
        /// Gets and sets the property LastTieringStartTime. 
        /// <para>
        /// The date and time when the last archive or restore process was started.
        /// </para>
        /// </summary>
        public DateTime? LastTieringStartTime { get; set; }

        /// <summary>
        /// Checks to see if the LastTieringStartTime property is set.
        /// </summary>
        internal bool IsSetLastTieringStartTime() => this.LastTieringStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the snapshot.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

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
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the snapshot.
        /// </para>
        /// </summary>
        public SnapshotState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// The tags that are assigned to the snapshot.
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
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume from which the snapshot was created.
        /// </para>
        /// </summary>
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;
    }
}
