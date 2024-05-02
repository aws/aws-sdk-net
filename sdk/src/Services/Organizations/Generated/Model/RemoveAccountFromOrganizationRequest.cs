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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveAccountFromOrganization operation.
    /// Removes the specified account from the organization.
    /// 
    ///  
    /// <para>
    /// The removed account becomes a standalone account that isn't a member of any organization.
    /// It's no longer subject to any policies and is responsible for its own bill payments.
    /// The organization's management account is no longer charged for any expenses accrued
    /// by the member account after it's removed from the organization.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's management account. Member
    /// accounts can remove themselves with <a>LeaveOrganization</a> instead.
    /// </para>
    ///  <important> <ul> <li> 
    /// <para>
    /// You can remove an account from your organization only if the account is configured
    /// with the information required to operate as a standalone account. When you create
    /// an account in an organization using the Organizations console, API, or CLI commands,
    /// the information required of standalone accounts is <i>not</i> automatically collected.
    /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_account-before-remove.html">Considerations
    /// before removing an account from an organization</a> in the <i>Organizations User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The account that you want to leave must not be a delegated administrator account for
    /// any Amazon Web Services service enabled for your organization. If the account is a
    /// delegated administrator, you must first change the delegated administrator account
    /// to another account that is remaining in the organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After the account leaves the organization, all tags that were attached to the account
    /// object in the organization are deleted. Amazon Web Services accounts outside of an
    /// organization do not support tags.
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
        [AWSProperty(Required=true, Max=12)]
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