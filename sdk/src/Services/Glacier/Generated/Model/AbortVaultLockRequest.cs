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
    /// Container for the parameters to the AbortVaultLock operation.
    /// This operation aborts the vault locking process if the vault lock is not in the <c>Locked</c>
    /// state. If the vault lock is in the <c>Locked</c> state when this operation is requested,
    /// the operation returns an <c>AccessDeniedException</c> error. Aborting the vault locking
    /// process removes the vault lock policy from the specified vault. 
    /// 
    ///  
    /// <para>
    /// A vault lock is put into the <c>InProgress</c> state by calling <a>InitiateVaultLock</a>.
    /// A vault lock is put into the <c>Locked</c> state by calling <a>CompleteVaultLock</a>.
    /// You can get the state of a vault lock by calling <a>GetVaultLock</a>. For more information
    /// about the vault locking process, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
    /// Glacier Vault Lock</a>. For more information about vault lock policies, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
    /// Glacier Access Control with Vault Lock Policies</a>. 
    /// </para>
    ///  
    /// <para>
    /// This operation is idempotent. You can successfully invoke this operation multiple
    /// times, if the vault lock is in the <c>InProgress</c> state or if there is no policy
    /// associated with the vault.
    /// </para>
    /// </summary>
    public partial class AbortVaultLockRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _vaultName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>AccountId</c> value is the AWS account ID. This value must match the AWS account
        /// ID associated with the credentials used to sign the request. You can either specify
        /// an AWS account ID or optionally a single '<c>-</c>' (hyphen), in which case Amazon
        /// Glacier uses the AWS account ID associated with the credentials used to sign the request.
        /// If you specify your account ID, do not include any hyphens ('-') in the ID.
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