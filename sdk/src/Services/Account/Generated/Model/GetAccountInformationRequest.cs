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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
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
namespace Amazon.Account.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccountInformation operation.
    /// Retrieves information about the specified account including its account name, account
    /// ID, and account creation date and time. To use this API, an IAM user or role must
    /// have the <c>account:GetAccountInformation</c> IAM permission.
    /// </summary>
    public partial class GetAccountInformationRequest : AmazonAccountRequest
    {
        private string _accountId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Specifies the 12 digit account ID number of the Amazon Web Services account that you
        /// want to access or modify with this operation.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify this parameter, it defaults to the Amazon Web Services account
        /// of the identity used to call the operation.
        /// </para>
        ///  
        /// <para>
        /// To use this parameter, the caller must be an identity in the <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#account">organization's
        /// management account</a> or a delegated administrator account, and the specified account
        /// ID must be a member account in the same organization. The organization must have <a
        /// href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">all
        /// features enabled</a>, and the organization must have <a href="https://docs.aws.amazon.com/organizations/latest/userguide/using-orgs-trusted-access.html">trusted
        /// access</a> enabled for the Account Management service, and optionally a <a href="https://docs.aws.amazon.com/organizations/latest/userguide/using-orgs-delegated-admin.html">delegated
        /// admin</a> account assigned.
        /// </para>
        ///  <note> 
        /// <para>
        /// The management account can't specify its own <c>AccountId</c>; it must call the operation
        /// in standalone context by not including the <c>AccountId</c> parameter.
        /// </para>
        ///  </note> 
        /// <para>
        /// To call this operation on an account that is not a member of an organization, then
        /// don't specify this parameter, and call the operation using an identity belonging to
        /// the account whose contacts you wish to retrieve or modify.
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