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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveAccountFromOrganization operation.
    /// Removes the specified account from the organization.
    /// 
    ///  
    /// <para>
    /// The removed account becomes a stand-alone account that is not a member of any organization.
    /// It is no longer subject to any policies and is responsible for its own bill payments.
    /// The organization's master account is no longer charged for any expenses accrued by
    /// the member account after it is removed from the organization.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account. Member accounts
    /// can remove themselves with <a>LeaveOrganization</a> instead.
    /// </para>
    ///  <important> 
    /// <para>
    /// You can remove an account from your organization only if the account is configured
    /// with the information required to operate as a standalone account. When you create
    /// an account in an organization using the AWS Organizations console, API, or CLI commands,
    /// the information required of standalone accounts is <i>not</i> automatically collected.
    /// For an account that you want to make standalone, you must accept the End User License
    /// Agreement (EULA), choose a support plan, provide and verify the required contact information,
    /// and provide a current payment method. AWS uses the payment method to charge for any
    /// billable (not free tier) AWS activity that occurs while the account is not attached
    /// to an organization. To remove an account that does not yet have this information,
    /// you must sign in as the member account and follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
    /// To leave an organization when all required account information has not yet been provided</a>
    /// in the <i>AWS Organizations User Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class RemoveAccountFromOrganizationRequest : AmazonOrganizationsRequest
    {
        private string _accountId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier (ID) of the member account that you want to remove from the
        /// organization.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for an account ID
        /// string requires exactly 12 digits.
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

    }
}