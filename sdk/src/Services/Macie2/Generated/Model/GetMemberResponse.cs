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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetMember operation.
    /// </summary>
    public partial class GetMemberResponse : AmazonWebServiceResponse
    {
        private string _accountId;
        private string _administratorAccountId;
        private string _arn;
        private string _email;
        private DateTime? _invitedAt;
        private string _masterAccountId;
        private RelationshipStatus _relationshipStatus;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the account.
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
        /// Gets and sets the property AdministratorAccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the administrator account.
        /// </para>
        /// </summary>
        public string AdministratorAccountId
        {
            get { return this._administratorAccountId; }
            set { this._administratorAccountId = value; }
        }

        // Check to see if AdministratorAccountId property is set
        internal bool IsSetAdministratorAccountId()
        {
            return this._administratorAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address for the account. This value is null if the account is associated
        /// with the administrator account through Organizations.
        /// </para>
        /// </summary>
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
        /// The date and time, in UTC and extended ISO 8601 format, when an Amazon Macie membership
        /// invitation was last sent to the account. This value is null if a Macie membership
        /// invitation hasn't been sent to the account.
        /// </para>
        /// </summary>
        public DateTime InvitedAt
        {
            get { return this._invitedAt.GetValueOrDefault(); }
            set { this._invitedAt = value; }
        }

        // Check to see if InvitedAt property is set
        internal bool IsSetInvitedAt()
        {
            return this._invitedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterAccountId. 
        /// <para>
        /// (Deprecated) The Amazon Web Services account ID for the administrator account. This
        /// property has been replaced by the administratorAccountId property and is retained
        /// only for backward compatibility.
        /// </para>
        /// </summary>
        public string MasterAccountId
        {
            get { return this._masterAccountId; }
            set { this._masterAccountId = value; }
        }

        // Check to see if MasterAccountId property is set
        internal bool IsSetMasterAccountId()
        {
            return this._masterAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property RelationshipStatus. 
        /// <para>
        /// The current status of the relationship between the account and the administrator account.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that specifies which tags (keys and values) are associated
        /// with the account in Amazon Macie.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, of the most recent change
        /// to the status of the relationship between the account and the administrator account.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}