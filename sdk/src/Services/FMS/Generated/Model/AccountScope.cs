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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Configures the accounts within the administrator's Organizations organization that
    /// the specified Firewall Manager administrator can apply policies to.
    /// </summary>
    public partial class AccountScope
    {
        private List<string> _accounts = new List<string>();
        private bool? _allAccountsEnabled;
        private bool? _excludeSpecifiedAccounts;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// The list of accounts within the organization that the specified Firewall Manager administrator
        /// either can or cannot apply policies to, based on the value of <code>ExcludeSpecifiedAccounts</code>.
        /// If <code>ExcludeSpecifiedAccounts</code> is set to <code>true</code>, then the Firewall
        /// Manager administrator can apply policies to all members of the organization except
        /// for the accounts in this list. If <code>ExcludeSpecifiedAccounts</code> is set to
        /// <code>false</code>, then the Firewall Manager administrator can only apply policies
        /// to the accounts in this list.
        /// </para>
        /// </summary>
        public List<string> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && this._accounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AllAccountsEnabled. 
        /// <para>
        /// A boolean value that indicates if the administrator can apply policies to all accounts
        /// within an organization. If true, the administrator can apply policies to all accounts
        /// within the organization. You can either enable management of all accounts through
        /// this operation, or you can specify a list of accounts to manage in <code>AccountScope$Accounts</code>.
        /// You cannot specify both.
        /// </para>
        /// </summary>
        public bool AllAccountsEnabled
        {
            get { return this._allAccountsEnabled.GetValueOrDefault(); }
            set { this._allAccountsEnabled = value; }
        }

        // Check to see if AllAccountsEnabled property is set
        internal bool IsSetAllAccountsEnabled()
        {
            return this._allAccountsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeSpecifiedAccounts. 
        /// <para>
        /// A boolean value that excludes the accounts in <code>AccountScope$Accounts</code> from
        /// the administrator's scope. If true, the Firewall Manager administrator can apply policies
        /// to all members of the organization except for the accounts listed in <code>AccountScope$Accounts</code>.
        /// You can either specify a list of accounts to exclude by <code>AccountScope$Accounts</code>,
        /// or you can enable management of all accounts by <code>AccountScope$AllAccountsEnabled</code>.
        /// You cannot specify both.
        /// </para>
        /// </summary>
        public bool ExcludeSpecifiedAccounts
        {
            get { return this._excludeSpecifiedAccounts.GetValueOrDefault(); }
            set { this._excludeSpecifiedAccounts = value; }
        }

        // Check to see if ExcludeSpecifiedAccounts property is set
        internal bool IsSetExcludeSpecifiedAccounts()
        {
            return this._excludeSpecifiedAccounts.HasValue; 
        }

    }
}