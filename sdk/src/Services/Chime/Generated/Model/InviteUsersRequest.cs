/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the InviteUsers operation.
    /// Sends email invites to as many as 50 users, inviting them to the specified Amazon
    /// Chime <code>Team</code> account. Only <code>Team</code> account types are currently
    /// supported for this action.
    /// </summary>
    public partial class InviteUsersRequest : AmazonChimeRequest
    {
        private string _accountId;
        private List<string> _userEmailList = new List<string>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
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
        /// Gets and sets the property UserEmailList. 
        /// <para>
        /// The user email addresses to which to send the invite.
        /// </para>
        /// </summary>
        public List<string> UserEmailList
        {
            get { return this._userEmailList; }
            set { this._userEmailList = value; }
        }

        // Check to see if UserEmailList property is set
        internal bool IsSetUserEmailList()
        {
            return this._userEmailList != null && this._userEmailList.Count > 0; 
        }

    }
}