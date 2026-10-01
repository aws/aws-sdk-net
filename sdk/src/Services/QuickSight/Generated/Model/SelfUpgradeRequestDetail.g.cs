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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Details of a self-upgrade request.
    /// </summary>
    public partial class SelfUpgradeRequestDetail
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the self-upgrade request was created.
        /// </para>
        /// </summary>
        public long? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateAttemptTime. 
        /// <para>
        /// The time of the last update attempt for the self-upgrade request.
        /// </para>
        /// </summary>
        public long? LastUpdateAttemptTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateAttemptTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateAttemptTime() => this.LastUpdateAttemptTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateFailureReason. 
        /// <para>
        /// The reason for the last update failure, if applicable.
        /// </para>
        /// </summary>
        public string LastUpdateFailureReason { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateFailureReason property is set.
        /// </summary>
        internal bool IsSetLastUpdateFailureReason() => this.LastUpdateFailureReason != null;

        /// <summary>
        /// Gets and sets the property OriginalRole. 
        /// <para>
        /// The original role of the user before the upgrade.
        /// </para>
        /// </summary>
        public UserRole OriginalRole { get; set; }

        /// <summary>
        /// Checks to see if the OriginalRole property is set.
        /// </summary>
        internal bool IsSetOriginalRole() => this.OriginalRole != null;

        /// <summary>
        /// Gets and sets the property RequestNote. 
        /// <para>
        /// An optional note explaining the reason for the self-upgrade request.
        /// </para>
        /// </summary>
        public string RequestNote { get; set; }

        /// <summary>
        /// Checks to see if the RequestNote property is set.
        /// </summary>
        internal bool IsSetRequestNote() => this.RequestNote != null;

        /// <summary>
        /// Gets and sets the property RequestStatus. 
        /// <para>
        /// The status of the self-upgrade request.
        /// </para>
        /// </summary>
        public SelfUpgradeRequestStatus RequestStatus { get; set; }

        /// <summary>
        /// Checks to see if the RequestStatus property is set.
        /// </summary>
        internal bool IsSetRequestStatus() => this.RequestStatus != null;

        /// <summary>
        /// Gets and sets the property RequestedRole. 
        /// <para>
        /// The role that the user is requesting to upgrade to.
        /// </para>
        /// </summary>
        public UserRole RequestedRole { get; set; }

        /// <summary>
        /// Checks to see if the RequestedRole property is set.
        /// </summary>
        internal bool IsSetRequestedRole() => this.RequestedRole != null;

        /// <summary>
        /// Gets and sets the property UpgradeRequestId. 
        /// <para>
        /// The ID of the self-upgrade request.
        /// </para>
        /// </summary>
        public string UpgradeRequestId { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeRequestId property is set.
        /// </summary>
        internal bool IsSetUpgradeRequestId() => this.UpgradeRequestId != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The username of the user who initiated the self-upgrade request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
