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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the member account.
    /// </summary>
    public partial class Member
    {
        private string _accountId;
        private string _administratorId;
        private string _detectorId;
        private string _email;
        private string _invitedAt;
        private string _masterId;
        private string _relationshipStatus;
        private string _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
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
        /// Gets and sets the property AdministratorId. 
        /// <para>
        /// The administrator account ID.
        /// </para>
        /// </summary>
        public string AdministratorId
        {
            get { return this._administratorId; }
            set { this._administratorId = value; }
        }

        // Check to see if AdministratorId property is set
        internal bool IsSetAdministratorId()
        {
            return this._administratorId != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detector ID of the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=6, Max=64)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
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
        /// Gets and sets the property MasterId. 
        /// <para>
        /// The administrator account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MasterId
        {
            get { return this._masterId; }
            set { this._masterId = value; }
        }

        // Check to see if MasterId property is set
        internal bool IsSetMasterId()
        {
            return this._masterId != null;
        }

        /// <summary>
        /// Gets and sets the property RelationshipStatus. 
        /// <para>
        /// The status of the relationship between the member and the administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The last-updated timestamp of the member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt != null;
        }

    }
}