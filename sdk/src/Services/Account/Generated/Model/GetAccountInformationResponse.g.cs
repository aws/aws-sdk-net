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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the GetAccountInformation operation.
    /// </summary>
    public partial class GetAccountInformationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountCreatedDate. 
        /// <para>
        /// The date and time the account was created.
        /// </para>
        /// </summary>
        public DateTime? AccountCreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the AccountCreatedDate property is set.
        /// </summary>
        internal bool IsSetAccountCreatedDate() => this.AccountCreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Specifies the 12-digit account ID number of the Amazon Web Services account that you
        /// want to access or modify with this operation. To use this parameter, the caller must
        /// be an identity in the <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#account">organization's
        /// management account</a> or a delegated administrator account. The specified account
        /// ID must be a member account in the same organization. The organization must have <a
        /// href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">all
        /// features enabled</a>, and the organization must have <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">trusted
        /// access</a> enabled for the Account Management service, and optionally a <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#delegated-admin">delegated
        /// admin</a> account assigned.
        /// </para>
        ///  
        /// <para>
        /// This operation can only be called from the management account or the delegated administrator
        /// account of an organization for a member account.
        /// </para>
        ///  <note> 
        /// <para>
        /// The management account can't specify its own <c>AccountId</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The name of the account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property AccountState. 
        /// <para>
        /// The state of the account. Each account state represents a specific phase in the account
        /// lifecycle. Use this information to manage account access, automate workflows, or trigger
        /// actions based on account state changes.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>PENDING_ACTIVATION | ACTIVE | SUSPENDED | CLOSED</c> 
        /// </para>
        /// </summary>
        public AccountState AccountState { get; set; }

        /// <summary>
        /// Checks to see if the AccountState property is set.
        /// </summary>
        internal bool IsSetAccountState() => this.AccountState != null;
    }
}
