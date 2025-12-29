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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Details of a self-upgrade request.
    /// </summary>
    public partial class SelfUpgradeRequestDetail
    {
        private long? _creationTime;
        private long? _lastUpdateAttemptTime;
        private string _lastUpdateFailureReason;
        private UserRole _originalRole;
        private UserRole _requestedRole;
        private string _requestNote;
        private SelfUpgradeRequestStatus _requestStatus;
        private string _upgradeRequestId;
        private string _userName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the self-upgrade request was created.
        /// </para>
        /// </summary>
        public long CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateAttemptTime. 
        /// <para>
        /// The time of the last update attempt for the self-upgrade request.
        /// </para>
        /// </summary>
        public long LastUpdateAttemptTime
        {
            get { return this._lastUpdateAttemptTime.GetValueOrDefault(); }
            set { this._lastUpdateAttemptTime = value; }
        }

        // Check to see if LastUpdateAttemptTime property is set
        internal bool IsSetLastUpdateAttemptTime()
        {
            return this._lastUpdateAttemptTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateFailureReason. 
        /// <para>
        /// The reason for the last update failure, if applicable.
        /// </para>
        /// </summary>
        public string LastUpdateFailureReason
        {
            get { return this._lastUpdateFailureReason; }
            set { this._lastUpdateFailureReason = value; }
        }

        // Check to see if LastUpdateFailureReason property is set
        internal bool IsSetLastUpdateFailureReason()
        {
            return this._lastUpdateFailureReason != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalRole. 
        /// <para>
        /// The original role of the user before the upgrade.
        /// </para>
        /// </summary>
        public UserRole OriginalRole
        {
            get { return this._originalRole; }
            set { this._originalRole = value; }
        }

        // Check to see if OriginalRole property is set
        internal bool IsSetOriginalRole()
        {
            return this._originalRole != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedRole. 
        /// <para>
        /// The role that the user is requesting to upgrade to.
        /// </para>
        /// </summary>
        public UserRole RequestedRole
        {
            get { return this._requestedRole; }
            set { this._requestedRole = value; }
        }

        // Check to see if RequestedRole property is set
        internal bool IsSetRequestedRole()
        {
            return this._requestedRole != null;
        }

        /// <summary>
        /// Gets and sets the property RequestNote. 
        /// <para>
        /// An optional note explaining the reason for the self-upgrade request.
        /// </para>
        /// </summary>
        public string RequestNote
        {
            get { return this._requestNote; }
            set { this._requestNote = value; }
        }

        // Check to see if RequestNote property is set
        internal bool IsSetRequestNote()
        {
            return this._requestNote != null;
        }

        /// <summary>
        /// Gets and sets the property RequestStatus. 
        /// <para>
        /// The status of the self-upgrade request.
        /// </para>
        /// </summary>
        public SelfUpgradeRequestStatus RequestStatus
        {
            get { return this._requestStatus; }
            set { this._requestStatus = value; }
        }

        // Check to see if RequestStatus property is set
        internal bool IsSetRequestStatus()
        {
            return this._requestStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpgradeRequestId. 
        /// <para>
        /// The ID of the self-upgrade request.
        /// </para>
        /// </summary>
        public string UpgradeRequestId
        {
            get { return this._upgradeRequestId; }
            set { this._upgradeRequestId = value; }
        }

        // Check to see if UpgradeRequestId property is set
        internal bool IsSetUpgradeRequestId()
        {
            return this._upgradeRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The username of the user who initiated the self-upgrade request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}