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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about an Amazon Macie membership invitation.
    /// </summary>
    public partial class Invitation
    {
        private string _accountId;
        private string _invitationId;
        private DateTime? _invitedAt;
        private RelationshipStatus _relationshipStatus;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the account that sent the invitation.
        /// </para>
        /// </summary>
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
        /// The unique identifier for the invitation.
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
        /// The date and time, in UTC and extended ISO 8601 format, when the invitation was sent.
        /// </para>
        /// </summary>
        public DateTime? InvitedAt
        {
            get { return this._invitedAt; }
            set { this._invitedAt = value; }
        }

        // Check to see if InvitedAt property is set
        internal bool IsSetInvitedAt()
        {
            return this._invitedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelationshipStatus. 
        /// <para>
        /// The status of the relationship between the account that sent the invitation and the
        /// account that received the invitation.
        /// </para>
        /// </summary>
        public RelationshipStatus RelationshipStatus
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