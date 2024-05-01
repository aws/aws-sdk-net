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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details on a member account in your organization.
    /// </summary>
    public partial class Member
    {
        private string _accountId;
        private string _delegatedAdminAccountId;
        private RelationshipStatus _relationshipStatus;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the member account.
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
        /// Gets and sets the property DelegatedAdminAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the Amazon Inspector delegated administrator
        /// for this member account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DelegatedAdminAccountId
        {
            get { return this._delegatedAdminAccountId; }
            set { this._delegatedAdminAccountId = value; }
        }

        // Check to see if DelegatedAdminAccountId property is set
        internal bool IsSetDelegatedAdminAccountId()
        {
            return this._delegatedAdminAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property RelationshipStatus. 
        /// <para>
        /// The status of the member account.
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// A timestamp showing when the status of this member was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}