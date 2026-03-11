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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
        private AdministrativeActionType _administrativeActionType;
        private AdministrativeActionFailureDetails _failureDetails;
        private string _message;
        private int? _progressPercent;
        private long? _remainingTransferBytes;
        private DateTime? _requestTime;
        private Status _status;
        private FileSystem _targetFileSystemValues;
        private Snapshot _targetSnapshotValues;
        private Volume _targetVolumeValues;
        private long? _totalTransferBytes;

        /// <summary>
        /// Gets and sets the property AdministrativeActionType.
        /// </summary>
        public AdministrativeActionType AdministrativeActionType
        {
            get { return this._administrativeActionType; }
            set { this._administrativeActionType = value; }
        }

        // Check to see if AdministrativeActionType property is set
        internal bool IsSetAdministrativeActionType()
        {
            return this._administrativeActionType != null;
        }

        /// <summary>
        /// Gets and sets the property FailureDetails.
        /// </summary>
        public AdministrativeActionFailureDetails FailureDetails
        {
            get { return this._failureDetails; }
            set { this._failureDetails = value; }
        }

        // Check to see if FailureDetails property is set
        internal bool IsSetFailureDetails()
        {
            return this._failureDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Message.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// The percentage-complete status of a <c>STORAGE_OPTIMIZATION</c> or <c>DOWNLOAD_DATA_FROM_BACKUP</c>
        /// administrative action. Does not apply to any other administrative action type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? ProgressPercent
        {
            get { return this._progressPercent; }
            set { this._progressPercent = value; }
        }

        // Check to see if ProgressPercent property is set
        internal bool IsSetProgressPercent()
        {
            return this._progressPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemainingTransferBytes. 
        /// <para>
        /// The remaining bytes to transfer for the FSx for OpenZFS snapshot that you're copying.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? RemainingTransferBytes
        {
            get { return this._remainingTransferBytes; }
            set { this._remainingTransferBytes = value; }
        }

        // Check to see if RemainingTransferBytes property is set
        internal bool IsSetRemainingTransferBytes()
        {
            return this._remainingTransferBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// The time that the administrative action request was received.
        /// </para>
        /// </summary>
        public DateTime? RequestTime
        {
            get { return this._requestTime; }
            set { this._requestTime = value; }
        }

        // Check to see if RequestTime property is set
        internal bool IsSetRequestTime()
        {
            return this._requestTime.HasValue; 
        }

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
        public Status Status
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
        /// Gets and sets the property TargetFileSystemValues. 
        /// <para>
        /// The target value for the administration action, provided in the <c>UpdateFileSystem</c>
        /// operation. Returned for <c>FILE_SYSTEM_UPDATE</c> administrative actions. 
        /// </para>
        /// </summary>
        public FileSystem TargetFileSystemValues
        {
            get { return this._targetFileSystemValues; }
            set { this._targetFileSystemValues = value; }
        }

        // Check to see if TargetFileSystemValues property is set
        internal bool IsSetTargetFileSystemValues()
        {
            return this._targetFileSystemValues != null;
        }

        /// <summary>
        /// Gets and sets the property TargetSnapshotValues.
        /// </summary>
        public Snapshot TargetSnapshotValues
        {
            get { return this._targetSnapshotValues; }
            set { this._targetSnapshotValues = value; }
        }

        // Check to see if TargetSnapshotValues property is set
        internal bool IsSetTargetSnapshotValues()
        {
            return this._targetSnapshotValues != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVolumeValues.
        /// </summary>
        public Volume TargetVolumeValues
        {
            get { return this._targetVolumeValues; }
            set { this._targetVolumeValues = value; }
        }

        // Check to see if TargetVolumeValues property is set
        internal bool IsSetTargetVolumeValues()
        {
            return this._targetVolumeValues != null;
        }

        /// <summary>
        /// Gets and sets the property TotalTransferBytes. 
        /// <para>
        /// The number of bytes that have transferred for the FSx for OpenZFS snapshot that you're
        /// copying.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? TotalTransferBytes
        {
            get { return this._totalTransferBytes; }
            set { this._totalTransferBytes = value; }
        }

        // Check to see if TotalTransferBytes property is set
        internal bool IsSetTotalTransferBytes()
        {
            return this._totalTransferBytes.HasValue; 
        }

    }
}