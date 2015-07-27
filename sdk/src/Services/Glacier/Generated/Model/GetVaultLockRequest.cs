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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the GetVaultLock operation.
    /// This operation retrieves the following attributes from the <code>lock-policy</code>
    /// subresource set on the specified vault: <ul> <li> 
    /// <para>
    /// The vault lock policy set on the vault.
    /// 
    ///  </li> <li> 
    /// <para>
    /// The state of the vault lock, which is either <code>InProgess</code> or <code>Locked</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the lock ID expires. The lock ID is used to complete the vault locking process.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the vault lock was initiated and put into the <code>InProgress</code> state.
    /// </para>
    ///  </li> </ul> 
    /// </para>
    ///  
    /// <para>
    /// A vault lock is put into the <code>InProgress</code> state by calling <a>InitiateVaultLock</a>.
    /// A vault lock is put into the <code>Locked</code> state by calling <a>CompleteVaultLock</a>.
    /// You can abort the vault locking process by calling <a>AbortVaultLock</a>. For more
    /// information about the vault locking process, <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
    /// Glacier Vault Lock</a>. 
    /// </para>
    ///  
    /// <para>
    /// If there is no vault lock policy set on the vault, the operation returns a <code>404
    /// Not found</code> error. For more information about vault lock policies, <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
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
        /// The <code>AccountId</code> value is the AWS account ID of the account that owns the
        /// vault. You can either specify an AWS account ID or optionally a single apos<code>-</code>apos
        /// (hyphen), in which case Amazon Glacier uses the AWS account ID associated with the
        /// credentials used to sign the request. If you use an account ID, do not include any
        /// hyphens (apos-apos) in the ID.
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
        /// Gets and sets the property VaultName. 
        /// <para>
        /// The name of the vault.
        /// </para>
        /// </summary>
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