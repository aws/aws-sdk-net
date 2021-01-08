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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Describes a specific Amazon FSx administrative action for the current Windows or Lustre
    /// file system.
    /// </summary>
    public partial class AdministrativeAction
    {
        private AdministrativeActionType _administrativeActionType;
        private AdministrativeActionFailureDetails _failureDetails;
        private int? _progressPercent;
        private DateTime? _requestTime;
        private Status _status;
        private FileSystem _targetFileSystemValues;

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
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// Provides the percent complete of a <code>STORAGE_OPTIMIZATION</code> administrative
        /// action. Does not apply to any other administrative action type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int ProgressPercent
        {
            get { return this._progressPercent.GetValueOrDefault(); }
            set { this._progressPercent = value; }
        }

        // Check to see if ProgressPercent property is set
        internal bool IsSetProgressPercent()
        {
            return this._progressPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// Time that the administrative action request was received.
        /// </para>
        /// </summary>
        public DateTime RequestTime
        {
            get { return this._requestTime.GetValueOrDefault(); }
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
        /// Describes the status of the administrative action, as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FAILED</code> - Amazon FSx failed to process the administrative action successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code> - Amazon FSx is processing the administrative action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING</code> - Amazon FSx is waiting to process the administrative action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPLETED</code> - Amazon FSx has finished processing the administrative task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATED_OPTIMIZING</code> - For a storage capacity increase update, Amazon
        /// FSx has updated the file system with the new storage capacity, and is now performing
        /// the storage optimization process. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-storage-capacity.html">Managing
        /// storage capacity</a> in the <i>Amazon FSx for Windows File Server User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/managing-storage-capacity.html">Managing
        /// storage and throughput capacity</a> in the <i>Amazon FSx for Lustre User Guide</i>.
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
        /// Describes the target value for the administration action, provided in the <code>UpdateFileSystem</code>
        /// operation. Returned for <code>FILE_SYSTEM_UPDATE</code> administrative actions. 
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

    }
}