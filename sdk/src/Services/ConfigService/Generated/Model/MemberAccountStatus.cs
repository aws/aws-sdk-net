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
    /// Organization config rule creation or deletion status in each member account. This
    /// includes the name of the rule, the status, error code and error message when the rule
    /// creation or deletion failed.
    /// </summary>
    public partial class MemberAccountStatus
    {
        private string _accountId;
        private string _configRuleName;
        private string _errorCode;
        private string _errorMessage;
        private DateTime? _lastUpdateTime;
        private MemberAccountRuleStatus _memberAccountRuleStatus;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit account ID of a member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of config rule deployed in the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// An error code that is returned when config rule creation or deletion failed in the
        /// member account.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message indicating that config rule account creation or deletion has failed
        /// due to an error in the member account.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The timestamp of the last status update.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this._lastUpdateTime.GetValueOrDefault(); }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemberAccountRuleStatus. 
        /// <para>
        /// Indicates deployment status for config rule in the member account. When master account
        /// calls <code>PutOrganizationConfigRule</code> action for the first time, config rule
        /// status is created in the member account. When master account calls <code>PutOrganizationConfigRule</code>
        /// action for the second time, config rule status is updated in the member account. Config
        /// rule status is deleted when the master account deletes <code>OrganizationConfigRule</code>
        /// and disables service access for <code>config-multiaccountsetup.amazonaws.com</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  AWS Config sets the state of the rule to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATE_SUCCESSFUL</code> when config rule has been created in the member account.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_IN_PROGRESS</code> when config rule is being created in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_FAILED</code> when config rule creation has failed in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_FAILED</code> when config rule deletion has failed in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_IN_PROGRESS</code> when config rule is being deleted in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_SUCCESSFUL</code> when config rule has been deleted in the member account.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_SUCCESSFUL</code> when config rule has been updated in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_IN_PROGRESS</code> when config rule is being updated in the member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_FAILED</code> when config rule deletion has failed in the member account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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