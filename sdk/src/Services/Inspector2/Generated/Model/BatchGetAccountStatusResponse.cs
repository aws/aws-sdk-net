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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// This is the response object from the BatchGetAccountStatus operation.
    /// </summary>
    public partial class BatchGetAccountStatusResponse : AmazonWebServiceResponse
    {
        private List<AccountState> _accounts = AWSConfigs.InitializeCollections ? new List<AccountState>() : null;
        private List<FailedAccount> _failedAccounts = AWSConfigs.InitializeCollections ? new List<FailedAccount>() : null;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// An array of objects that provide details on the status of Amazon Inspector for each
        /// of the requested accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<AccountState> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && (this._accounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedAccounts. 
        /// <para>
        /// An array of objects detailing any accounts that failed to enable Amazon Inspector
        /// and why.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<FailedAccount> FailedAccounts
        {
            get { return this._failedAccounts; }
            set { this._failedAccounts = value; }
        }

        // Check to see if FailedAccounts property is set
        internal bool IsSetFailedAccounts()
        {
            return this._failedAccounts != null && (this._failedAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}