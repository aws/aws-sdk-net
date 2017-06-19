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
    ///  <important> <ul> <li> 
    /// <para>
    /// You can remove only accounts that were created outside your organization and invited
    /// to join. If you created the account using the AWS Organizations console, the Organizations
    /// API, or the Organizations CLI commands, then you cannot remove the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can remove a member account only after you enable IAM user access to billing in
    /// the member account. For more information, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html#ControllingAccessWebsite-Activate">Activating
    /// Access to the Billing and Cost Management Console</a> in the <i>AWS Billing and Cost
    /// Management User Guide</i>.
    /// </para>
    ///  </li> </ul> </important>
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