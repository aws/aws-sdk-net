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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the GetVaultAccessPolicy operation.
    /// This operation retrieves the <code>access-policy</code> subresource set on the vault;
    /// for more information on setting this subresource, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-SetVaultAccessPolicy.html">Set
    /// Vault Access Policy (PUT access-policy)</a>. If there is no access policy set on the
    /// vault, the operation returns a <code>404 Not found</code> error. For more information
    /// about vault access policies, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-access-policy.html">Amazon
    /// Glacier Access Control with Vault Access Policies</a>.
    /// </summary>
    public partial class GetVaultAccessPolicyRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _vaultName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <code>AccountId</code> value is the AWS account ID of the account that owns the
        /// vault. You can either specify an AWS account ID or optionally a single '<code>-</code>'
        /// (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with
        /// the credentials used to sign the request. If you use an account ID, do not include
        /// any hyphens ('-') in the ID.
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
        /// Gets and sets the property VaultName. 
        /// <para>
        /// The name of the vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VaultName
        {
            get { return this._vaultName; }
            set { this._vaultName = value; }
        }

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this._vaultName != null;
        }

    }
}