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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Describes an Amazon FSx for NetApp ONTAP SnapMirror relationship.
    /// </summary>
    public partial class SnapmirrorRelationship
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination endpoint of the SnapMirror relationship.
        /// </para>
        /// </summary>
        public SnapmirrorDestination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property ExportedSnapshot. 
        /// <para>
        /// The latest snapshot that SnapMirror transferred to the destination volume.
        /// </para>
        /// </summary>
        public SnapmirrorExportedSnapshot ExportedSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the ExportedSnapshot property is set.
        /// </summary>
        internal bool IsSetExportedSnapshot() => this.ExportedSnapshot != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The globally unique ID of the file system that the destination volume is on, assigned
        /// by Amazon FSx.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 21)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property Healthy. 
        /// <para>
        /// Indicates whether ONTAP reports the SnapMirror relationship as healthy.
        /// </para>
        /// </summary>
        public bool? Healthy { get; set; }

        /// <summary>
        /// Checks to see if the Healthy property is set.
        /// </summary>
        internal bool IsSetHealthy() => this.Healthy.HasValue;

        /// <summary>
        /// Gets and sets the property LagTimeInMinutes. 
        /// <para>
        /// The time, in minutes, since ONTAP created the latest snapshot that SnapMirror transferred
        /// to the destination volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? LagTimeInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the LagTimeInMinutes property is set.
        /// </summary>
        internal bool IsSetLagTimeInMinutes() => this.LagTimeInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the SnapMirror relationship can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATED</c> – The SnapMirror relationship is fully available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> – Amazon FSx is creating the SnapMirror relationship.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> – Amazon FSx is deleting the SnapMirror relationship.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – Amazon FSx was unable to create the SnapMirror relationship.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SnapmirrorRelationshipLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property LifecycleTransitionReason. 
        /// <para>
        /// The reason why the SnapMirror relationship lifecycle status changed.
        /// </para>
        /// </summary>
        public LifecycleTransitionReason LifecycleTransitionReason { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleTransitionReason property is set.
        /// </summary>
        internal bool IsSetLifecycleTransitionReason() => this.LifecycleTransitionReason != null;

        /// <summary>
        /// Gets and sets the property ResourceARN.
        /// </summary>
        [AWSProperty(Min = 8, Max = 512)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property SnapmirrorPolicy. 
        /// <para>
        /// The SnapMirror policy that the SnapMirror relationship uses.
        /// </para>
        /// </summary>
        public SnapmirrorRelationshipPolicy SnapmirrorPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SnapmirrorPolicy property is set.
        /// </summary>
        internal bool IsSetSnapmirrorPolicy() => this.SnapmirrorPolicy != null;

        /// <summary>
        /// Gets and sets the property SnapmirrorRelationshipId. 
        /// <para>
        /// The system-generated, unique ID of the SnapMirror relationship.
        /// </para>
        /// </summary>
        public string SnapmirrorRelationshipId { get; set; }

        /// <summary>
        /// Checks to see if the SnapmirrorRelationshipId property is set.
        /// </summary>
        internal bool IsSetSnapmirrorRelationshipId() => this.SnapmirrorRelationshipId != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source endpoint of the SnapMirror relationship.
        /// </para>
        /// </summary>
        public SnapmirrorSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the SnapMirror relationship in ONTAP can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UNINITIALIZED</c> – SnapMirror hasn't transferred the baseline copy of the source
        /// volume to the destination volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRANSFERRING</c> – SnapMirror is transferring data to the destination volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SNAPMIRRORED</c> – SnapMirror transferred the baseline copy, and the destination
        /// volume receives updates from the source volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAUSED</c> – SnapMirror transfers for the relationship are paused.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BROKEN_OFF</c> – The relationship is broken off, and the destination volume is
        /// writable. SnapMirror doesn't transfer data to the destination volume.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SnapmirrorRelationshipState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThrottleInKbps. 
        /// <para>
        /// The maximum bandwidth, in kilobytes per second (KBps), that SnapMirror uses to transfer
        /// data for the relationship. A value of <c>0</c> means that the bandwidth is unlimited.
        /// This value overrides the throttle of the SnapMirror policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ThrottleInKbps { get; set; }

        /// <summary>
        /// Checks to see if the ThrottleInKbps property is set.
        /// </summary>
        internal bool IsSetThrottleInKbps() => this.ThrottleInKbps.HasValue;

        /// <summary>
        /// Gets and sets the property TransferSchedule. 
        /// <para>
        /// The name of the ONTAP schedule that determines when SnapMirror transfers data for
        /// the relationship. This schedule overrides the transfer schedule of the SnapMirror
        /// policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TransferSchedule { get; set; }

        /// <summary>
        /// Checks to see if the TransferSchedule property is set.
        /// </summary>
        internal bool IsSetTransferSchedule() => this.TransferSchedule != null;

        /// <summary>
        /// Gets and sets the property TransferState. 
        /// <para>
        /// The latest SnapMirror transfer for the relationship. If a transfer is in progress,
        /// this is the in-progress transfer. Otherwise, it's the most recently completed transfer.
        /// </para>
        /// </summary>
        public SnapmirrorTransferState TransferState { get; set; }

        /// <summary>
        /// Checks to see if the TransferState property is set.
        /// </summary>
        internal bool IsSetTransferState() => this.TransferState != null;

        /// <summary>
        /// Gets and sets the property UUID. 
        /// <para>
        /// The SnapMirror relationship's universally unique identifier (UUID).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 36)]
        public string UUID { get; set; }

        /// <summary>
        /// Checks to see if the UUID property is set.
        /// </summary>
        internal bool IsSetUUID() => this.UUID != null;

        /// <summary>
        /// Gets and sets the property UnhealthyReason. 
        /// <para>
        /// The reason that ONTAP reports for why the SnapMirror relationship is unhealthy, if
        /// <c>Healthy</c> is <c>false</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string UnhealthyReason { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyReason property is set.
        /// </summary>
        internal bool IsSetUnhealthyReason() => this.UnhealthyReason != null;
    }
}
