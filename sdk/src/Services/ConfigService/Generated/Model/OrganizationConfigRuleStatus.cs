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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Returns the status for an organization Config rule in an organization.
    /// </summary>
    public partial class OrganizationConfigRuleStatus
    {
        private string _errorCode;
        private string _errorMessage;
        private DateTime? _lastUpdateTime;
        private string _organizationConfigRuleName;
        private OrganizationRuleStatus _organizationRuleStatus;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// An error code that is returned when organization Config rule creation or deletion
        /// has failed.
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
        /// An error message indicating that organization Config rule creation or deletion failed
        /// due to an error.
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
        /// The timestamp of the last update.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationConfigRuleName. 
        /// <para>
        /// The name that you assign to organization Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string OrganizationConfigRuleName
        {
            get { return this._organizationConfigRuleName; }
            set { this._organizationConfigRuleName = value; }
        }

        // Check to see if OrganizationConfigRuleName property is set
        internal bool IsSetOrganizationConfigRuleName()
        {
            return this._organizationConfigRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationRuleStatus. 
        /// <para>
        /// Indicates deployment status of an organization Config rule. When management account
        /// calls PutOrganizationConfigRule action for the first time, Config rule status is created
        /// in all the member accounts. When management account calls PutOrganizationConfigRule
        /// action for the second time, Config rule status is updated in all the member accounts.
        /// Additionally, Config rule status is updated when one or more member accounts join
        /// or leave an organization. Config rule status is deleted when the management account
        /// deletes OrganizationConfigRule in all the member accounts and disables service access
        /// for <c>config-multiaccountsetup.amazonaws.com</c>.
        /// </para>
        ///  
        /// <para>
        /// Config sets the state of the rule to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_SUCCESSFUL</c> when an organization Config rule has been successfully created
        /// in all the member accounts. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> when an organization Config rule creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> when an organization Config rule creation failed in one or more
        /// member accounts within that organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_FAILED</c> when an organization Config rule deletion failed in one or more
        /// member accounts within that organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_IN_PROGRESS</c> when an organization Config rule deletion is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_SUCCESSFUL</c> when an organization Config rule has been successfully deleted
        /// from all the member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_SUCCESSFUL</c> when an organization Config rule has been successfully updated
        /// in all the member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_IN_PROGRESS</c> when an organization Config rule update is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_FAILED</c> when an organization Config rule update failed in one or more
        /// member accounts within that organization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrganizationRuleStatus OrganizationRuleStatus
        {
            get { return this._organizationRuleStatus; }
            set { this._organizationRuleStatus = value; }
        }

        // Check to see if OrganizationRuleStatus property is set
        internal bool IsSetOrganizationRuleStatus()
        {
            return this._organizationRuleStatus != null;
        }

    }
}