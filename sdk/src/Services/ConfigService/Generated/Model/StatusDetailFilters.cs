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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Status filter object to filter results based on specific member account ID or status
    /// type for an organization Config rule.
    /// </summary>
    public partial class StatusDetailFilters
    {
        private string _accountId;
        private MemberAccountRuleStatus _memberAccountRuleStatus;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit account ID of the member account within an organization.
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
        /// Gets and sets the property MemberAccountRuleStatus. 
        /// <para>
        /// Indicates deployment status for Config rule in the member account. When management
        /// account calls <code>PutOrganizationConfigRule</code> action for the first time, Config
        /// rule status is created in the member account. When management account calls <code>PutOrganizationConfigRule</code>
        /// action for the second time, Config rule status is updated in the member account. Config
        /// rule status is deleted when the management account deletes <code>OrganizationConfigRule</code>
        /// and disables service access for <code>config-multiaccountsetup.amazonaws.com</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Config sets the state of the rule to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATE_SUCCESSFUL</code> when Config rule has been created in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_IN_PROGRESS</code> when Config rule is being created in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_FAILED</code> when Config rule creation has failed in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_FAILED</code> when Config rule deletion has failed in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_IN_PROGRESS</code> when Config rule is being deleted in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_SUCCESSFUL</code> when Config rule has been deleted in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_SUCCESSFUL</code> when Config rule has been updated in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_IN_PROGRESS</code> when Config rule is being updated in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_FAILED</code> when Config rule deletion has failed in the member account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MemberAccountRuleStatus MemberAccountRuleStatus
        {
            get { return this._memberAccountRuleStatus; }
            set { this._memberAccountRuleStatus = value; }
        }

        // Check to see if MemberAccountRuleStatus property is set
        internal bool IsSetMemberAccountRuleStatus()
        {
            return this._memberAccountRuleStatus != null;
        }

    }
}