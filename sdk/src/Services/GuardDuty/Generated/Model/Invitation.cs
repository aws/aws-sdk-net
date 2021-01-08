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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the invitation to become a member account.
    /// </summary>
    public partial class Invitation
    {
        private string _accountId;
        private string _invitationId;
        private string _invitedAt;
        private string _relationshipStatus;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the account that the invitation was sent from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property InvitationId. 
        /// <para>
        /// The ID of the invitation. This value is used to validate the inviter account to the
        /// member account.
        /// </para>
        /// </summary>
        public string InvitationId
        {
            get { return this._invitationId; }
            set { this._invitationId = value; }
        }

        // Check to see if InvitationId property is set
        internal bool IsSetInvitationId()
        {
            return this._invitationId != null;
        }

        /// <summary>
        /// Gets and sets the property InvitedAt. 
        /// <para>
        /// The timestamp when the invitation was sent.
        /// </para>
        /// </summary>
        public string InvitedAt
        {
            get { return this._invitedAt; }
            set { this._invitedAt = value; }
        }

        // Check to see if InvitedAt property is set
        internal bool IsSetInvitedAt()
        {
            return this._invitedAt != null;
        }

        /// <summary>
        /// Gets and sets the property RelationshipStatus. 
        /// <para>
        /// The status of the relationship between the inviter and invitee accounts.
        /// </para>
        /// </summary>
        public string RelationshipStatus
        {
            get { return this._relationshipStatus; }
            set { this._relationshipStatus = value; }
        }

        // Check to see if RelationshipStatus property is set
        internal bool IsSetRelationshipStatus()
        {
            return this._relationshipStatus != null;
        }

    }
}