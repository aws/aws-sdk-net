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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateAccounts operation.
    /// Associates one or more member accounts with your organization's management account,
    /// enabling centralized implementation of optimization actions across those accounts.
    /// Once associated, the management account (or a delegated administrator) can apply recommended
    /// actions to the member account. When you associate a member account, its organization
    /// rule mode is automatically set to "Any allowed," which permits the management account
    /// to create Automation rules that automatically apply actions to that account. If the
    /// member account has not previously enabled the Automation feature, the association
    /// process automatically enables it.
    /// 
    ///  <note> 
    /// <para>
    /// Only the management account or a delegated administrator can perform this action.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssociateAccountsRequest : AmazonComputeOptimizerAutomationRequest
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        ///  The IDs of the member accounts to associate. You can specify up to 50 account IDs.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique identifier to ensure idempotency of the request. Valid for 24 hours after
        /// creation. 
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

    }
}