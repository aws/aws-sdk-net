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
    /// Container for the parameters to the BatchUnsuspendUser operation.
    /// Removes the suspension from up to 50 previously suspended users for the specified
    /// Amazon Chime <code>EnterpriseLWA</code> account. Only users on <code>EnterpriseLWA</code>
    /// accounts can be unsuspended using this action. For more information about different
    /// account types, see <a href="https://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">Managing
    /// Your Amazon Chime Accounts</a> in the <i>Amazon Chime Administration Guide</i>.
    /// 
    ///  
    /// <para>
    /// Previously suspended users who are unsuspended using this action are returned to <code>Registered</code>
    /// status. Users who are not previously suspended are ignored.
    /// </para>
    /// </summary>
    public partial class BatchUnsuspendUserRequest : AmazonChimeRequest
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
        /// The request containing the user IDs to unsuspend.
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