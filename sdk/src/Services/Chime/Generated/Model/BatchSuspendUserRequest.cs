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
    /// Container for the parameters to the BatchSuspendUser operation.
    /// Suspends up to 50 users from a <code>Team</code> or <code>EnterpriseLWA</code> Amazon
    /// Chime account. For more information about different account types, see <a href="https://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">Managing
    /// Your Amazon Chime Accounts</a> in the <i>Amazon Chime Administration Guide</i>.
    /// 
    ///  
    /// <para>
    /// Users suspended from a <code>Team</code> account are dissociated from the account,
    /// but they can continue to use Amazon Chime as free users. To remove the suspension
    /// from suspended <code>Team</code> account users, invite them to the <code>Team</code>
    /// account again. You can use the <a>InviteUsers</a> action to do so.
    /// </para>
    ///  
    /// <para>
    /// Users suspended from an <code>EnterpriseLWA</code> account are immediately signed
    /// out of Amazon Chime and are no longer able to sign in. To remove the suspension from
    /// suspended <code>EnterpriseLWA</code> account users, use the <a>BatchUnsuspendUser</a>
    /// action. 
    /// </para>
    ///  
    /// <para>
    /// To sign out users without suspending them, use the <a>LogoutUser</a> action.
    /// </para>
    /// </summary>
    public partial class BatchSuspendUserRequest : AmazonChimeRequest
    {
        private string _accountId;
        private List<string> _userIdList = new List<string>();

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
        /// Gets and sets the property UserIdList. 
        /// <para>
        /// The request containing the user IDs to suspend.
        /// </para>
        /// </summary>
        public List<string> UserIdList
        {
            get { return this._userIdList; }
            set { this._userIdList = value; }
        }

        // Check to see if UserIdList property is set
        internal bool IsSetUserIdList()
        {
            return this._userIdList != null && this._userIdList.Count > 0; 
        }

    }
}