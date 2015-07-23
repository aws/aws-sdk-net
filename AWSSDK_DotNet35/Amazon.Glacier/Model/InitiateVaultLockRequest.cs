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
    /// Container for the parameters to the InitiateVaultLock operation.
    /// This operation initiates the vault locking process by doing the following: <ul> <li>
    /// 
    /// <para>
    /// Installing a vault lock policy on the specified vault.
    /// 
    ///  </li> <li> 
    /// <para>
    /// Setting the lock state of vault lock to <code>InProgress</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Returning a lock ID, which is used to complete the vault locking process. 
    /// </para>
    ///  </li> </ul> 
    /// </para>
    ///  
    /// <para>
    /// You can set one vault lock policy for each vault and this policy can be up to 20 KB
    /// in size. For more information about vault lock policies, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
    /// Glacier Access Control with Vault Lock Policies</a>. 
    /// </para>
    ///  
    /// <para>
    /// You must complete the vault locking process within 24 hours after the vault lock enters
    /// the <code>InProgress</code> state. After the 24 hour window ends, the lock ID expires,
    /// the vault automatically exits the <code>InProgress</code> state, and the vault lock
    /// policy is removed from the vault. You call <a>CompleteVaultLock</a> to complete the
    /// vault locking process by setting the state of the vault lock to <code>Locked</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// After a vault lock is in the <code>Locked</code> state, you cannot initiate a new
    /// vault lock for the vault.
    /// </para>
    ///  
    /// <para>
    /// You can abort the vault locking process by calling <a>AbortVaultLock</a>. You can
    /// get the state of the vault lock by calling <a>GetVaultLock</a>. For more information
    /// about the vault locking process, <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
    /// Glacier Vault Lock</a>.
    /// </para>
    ///  
    /// <para>
    /// If this operation is called when the vault lock is in the <code>InProgress</code>
    /// state, the operation returns an <code>AccessDeniedException</code> error. When the
    /// vault lock is in the <code>InProgress</code> state you must call <a>AbortVaultLock</a>
    /// before you can initiate a new vault lock policy. 
    /// </para>
    /// </summary>
    public partial class InitiateVaultLockRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private VaultLockPolicy _policy;
        private string _vaultName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <code>AccountId</code> value is the AWS account ID. This value must match the
        /// AWS account ID associated with the credentials used to sign the request. You can either
        /// specify an AWS account ID or optionally a single apos<code>-</code>apos (hyphen),
        /// in which case Amazon Glacier uses the AWS account ID associated with the credentials
        /// used to sign the request. If you specify your account ID, do not include any hyphens
        /// (apos-apos) in the ID.
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
        /// Gets and sets the property Policy. 
        /// <para>
        /// The vault lock policy as a JSON string, which uses "\" as an escape character.
        /// </para>
        /// </summary>
        public VaultLockPolicy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
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