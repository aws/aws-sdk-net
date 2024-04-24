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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the GetVaultLock operation.
    /// This operation retrieves the following attributes from the <c>lock-policy</c> subresource
    /// set on the specified vault: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The vault lock policy set on the vault.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The state of the vault lock, which is either <c>InProgess</c> or <c>Locked</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the lock ID expires. The lock ID is used to complete the vault locking process.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the vault lock was initiated and put into the <c>InProgress</c> state.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A vault lock is put into the <c>InProgress</c> state by calling <a>InitiateVaultLock</a>.
    /// A vault lock is put into the <c>Locked</c> state by calling <a>CompleteVaultLock</a>.
    /// You can abort the vault locking process by calling <a>AbortVaultLock</a>. For more
    /// information about the vault locking process, <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
    /// Glacier Vault Lock</a>. 
    /// </para>
    ///  
    /// <para>
    /// If there is no vault lock policy set on the vault, the operation returns a <c>404
    /// Not found</c> error. For more information about vault lock policies, <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
    /// Glacier Access Control with Vault Lock Policies</a>. 
    /// </para>
    /// </summary>
    public partial class GetVaultLockRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _vaultName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>AccountId</c> value is the AWS account ID of the account that owns the vault.
        /// You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen),
        /// in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials
        /// used to sign the request. If you use an account ID, do not include any hyphens ('-')
        /// in the ID.
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