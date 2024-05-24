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
    /// Container for the parameters to the CompleteVaultLock operation.
    /// This operation completes the vault locking process by transitioning the vault lock
    /// from the <c>InProgress</c> state to the <c>Locked</c> state, which causes the vault
    /// lock policy to become unchangeable. A vault lock is put into the <c>InProgress</c>
    /// state by calling <a>InitiateVaultLock</a>. You can obtain the state of the vault lock
    /// by calling <a>GetVaultLock</a>. For more information about the vault locking process,
    /// <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
    /// Glacier Vault Lock</a>. 
    /// 
    ///  
    /// <para>
    /// This operation is idempotent. This request is always successful if the vault lock
    /// is in the <c>Locked</c> state and the provided lock ID matches the lock ID originally
    /// used to lock the vault.
    /// </para>
    ///  
    /// <para>
    /// If an invalid lock ID is passed in the request when the vault lock is in the <c>Locked</c>
    /// state, the operation returns an <c>AccessDeniedException</c> error. If an invalid
    /// lock ID is passed in the request when the vault lock is in the <c>InProgress</c> state,
    /// the operation throws an <c>InvalidParameter</c> error.
    /// </para>
    /// </summary>
    public partial class CompleteVaultLockRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _lockId;
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
        /// Gets and sets the property LockId. 
        /// <para>
        /// The <c>lockId</c> value is the lock ID obtained from a <a>InitiateVaultLock</a> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LockId
        {
            get { return this._lockId; }
            set { this._lockId = value; }
        }

        // Check to see if LockId property is set
        internal bool IsSetLockId()
        {
            return this._lockId != null;
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