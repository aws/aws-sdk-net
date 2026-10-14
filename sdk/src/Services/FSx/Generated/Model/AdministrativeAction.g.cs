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
    /// Describes a specific Amazon FSx administrative action for the current Windows, Lustre,
    /// OpenZFS, or ONTAP file system or volume.
    /// </summary>
    public partial class AdministrativeAction
    {
        /// <summary>
        /// Gets and sets the property AdministrativeActionType.
        /// </summary>
        public AdministrativeActionType AdministrativeActionType { get; set; }

        /// <summary>
        /// Checks to see if the AdministrativeActionType property is set.
        /// </summary>
        internal bool IsSetAdministrativeActionType() => this.AdministrativeActionType != null;

        /// <summary>
        /// Gets and sets the property FailureDetails.
        /// </summary>
        public AdministrativeActionFailureDetails FailureDetails { get; set; }

        /// <summary>
        /// Checks to see if the FailureDetails property is set.
        /// </summary>
        internal bool IsSetFailureDetails() => this.FailureDetails != null;

        /// <summary>
        /// Gets and sets the property Message.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// The percentage-complete status of a <c>STORAGE_OPTIMIZATION</c> or <c>DOWNLOAD_DATA_FROM_BACKUP</c>
        /// administrative action. Does not apply to any other administrative action type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? ProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercent property is set.
        /// </summary>
        internal bool IsSetProgressPercent() => this.ProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property RemainingTransferBytes. 
        /// <para>
        /// The remaining bytes to transfer for the FSx for OpenZFS snapshot that you're copying.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? RemainingTransferBytes { get; set; }

        /// <summary>
        /// Checks to see if the RemainingTransferBytes property is set.
        /// </summary>
        internal bool IsSetRemainingTransferBytes() => this.RemainingTransferBytes.HasValue;

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// The time that the administrative action request was received.
        /// </para>
        /// </summary>
        public DateTime? RequestTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestTime property is set.
        /// </summary>
        internal bool IsSetRequestTime() => this.RequestTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the administrative action, as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FAILED</c> - Amazon FSx failed to process the administrative action successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - Amazon FSx is processing the administrative action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> - Amazon FSx is waiting to process the administrative action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - Amazon FSx has finished processing the administrative task.
        /// </para>
        ///  
        /// <para>
        /// For a backup restore to a second-generation FSx for ONTAP file system, indicates that
        /// all data has been downloaded to the volume, and clients now have read-write access
        /// to volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATED_OPTIMIZING</c> - For a storage-capacity increase update, Amazon FSx has
        /// updated the file system with the new storage capacity, and is now performing the storage-optimization
        /// process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> - For a backup restore to a second-generation FSx for ONTAP file system,
        /// indicates that the file metadata is being downloaded onto the volume. The volume's
        /// Lifecycle state is CREATING.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - For a backup restore to a second-generation FSx for ONTAP file
        /// system, indicates that all metadata has been downloaded to the new volume and client
        /// can access data with read-only access while Amazon FSx downloads the file data to
        /// the volume. Track the progress of this process with the <c>ProgressPercent</c> element.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetFileSystemValues. 
        /// <para>
        /// The target value for the administration action, provided in the <c>UpdateFileSystem</c>
        /// operation. Returned for <c>FILE_SYSTEM_UPDATE</c> administrative actions. 
        /// </para>
        /// </summary>
        public FileSystem TargetFileSystemValues { get; set; }

        /// <summary>
        /// Checks to see if the TargetFileSystemValues property is set.
        /// </summary>
        internal bool IsSetTargetFileSystemValues() => this.TargetFileSystemValues != null;

        /// <summary>
        /// Gets and sets the property TargetSnapshotValues.
        /// </summary>
        public Snapshot TargetSnapshotValues { get; set; }

        /// <summary>
        /// Checks to see if the TargetSnapshotValues property is set.
        /// </summary>
        internal bool IsSetTargetSnapshotValues() => this.TargetSnapshotValues != null;

        /// <summary>
        /// Gets and sets the property TargetVolumeValues.
        /// </summary>
        public Volume TargetVolumeValues { get; set; }

        /// <summary>
        /// Checks to see if the TargetVolumeValues property is set.
        /// </summary>
        internal bool IsSetTargetVolumeValues() => this.TargetVolumeValues != null;

        /// <summary>
        /// Gets and sets the property TotalTransferBytes. 
        /// <para>
        /// The number of bytes that have transferred for the FSx for OpenZFS snapshot that you're
        /// copying.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalTransferBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalTransferBytes property is set.
        /// </summary>
        internal bool IsSetTotalTransferBytes() => this.TotalTransferBytes.HasValue;
    }
}
