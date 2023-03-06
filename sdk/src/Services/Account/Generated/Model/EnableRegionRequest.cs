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

namespace Amazon.Account.Model
{
    /// <summary>
    /// Container for the parameters to the EnableRegion operation.
    /// Enables (opts-in) a particular Region for an account.
    /// </summary>
    public partial class EnableRegionRequest : AmazonAccountRequest
    {
        private string _accountId;
        private string _regionName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Specifies the 12-digit account ID number of the Amazon Web Services account that you
        /// want to access or modify with this operation. If you don't specify this parameter,
        /// it defaults to the Amazon Web Services account of the identity used to call the operation.
        /// To use this parameter, the caller must be an identity in the <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#account">organization's
        /// management account</a> or a delegated administrator account. The specified account
        /// ID must also be a member account in the same organization. The organization must have
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">all
        /// features enabled</a>, and the organization must have <a href="https://docs.aws.amazon.com/organizations/latest/userguide/using-orgs-trusted-access.html">trusted
        /// access</a> enabled for the Account Management service, and optionally a <a href="https://docs.aws.amazon.com/organizations/latest/userguide/using-orgs-delegated-admin.html">delegated
        /// admin</a> account assigned.
        /// </para>
        ///  <note> 
        /// <para>
        /// The management account can't specify its own <code>AccountId</code>. It must call
        /// the operation in standalone context by not including the <code>AccountId</code> parameter.
        /// </para>
        ///  </note> 
        /// <para>
        /// To call this operation on an account that is not a member of an organization, don't
        /// specify this parameter. Instead, call the operation using an identity belonging to
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

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// Specifies the Region-code for a given Region name (for example, <code>af-south-1</code>).
        /// When you enable a Region, Amazon Web Services performs actions to prepare your account
        /// in that Region, such as distributing your IAM resources to the Region. This process
        /// takes a few minutes for most accounts, but it can take several hours. You cannot use
        /// the Region until this process is complete. Furthermore, you cannot disable the Region
        /// until the enabling process is fully completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

    }
}