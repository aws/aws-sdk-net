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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains information about a restore access backup vault.
    /// </summary>
    public partial class RestoreAccessBackupVaultListMember
    {
        private DateTime? _approvalDate;
        private DateTime? _creationDate;
        private LatestRevokeRequest _latestRevokeRequest;
        private string _restoreAccessBackupVaultArn;
        private VaultState _vaultState;

        /// <summary>
        /// Gets and sets the property ApprovalDate. 
        /// <para>
        /// The date and time when the restore access backup vault was approved.
        /// </para>
        /// </summary>
        public DateTime ApprovalDate
        {
            get { return this._approvalDate.GetValueOrDefault(); }
            set { this._approvalDate = value; }
        }

        // Check to see if ApprovalDate property is set
        internal bool IsSetApprovalDate()
        {
            return this._approvalDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the restore access backup vault was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestRevokeRequest. 
        /// <para>
        /// Information about the latest request to revoke access to this backup vault.
        /// </para>
        /// </summary>
        public LatestRevokeRequest LatestRevokeRequest
        {
            get { return this._latestRevokeRequest; }
            set { this._latestRevokeRequest = value; }
        }

        // Check to see if LatestRevokeRequest property is set
        internal bool IsSetLatestRevokeRequest()
        {
            return this._latestRevokeRequest != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreAccessBackupVaultArn. 
        /// <para>
        /// The ARN of the restore access backup vault.
        /// </para>
        /// </summary>
        public string RestoreAccessBackupVaultArn
        {
            get { return this._restoreAccessBackupVaultArn; }
            set { this._restoreAccessBackupVaultArn = value; }
        }

        // Check to see if RestoreAccessBackupVaultArn property is set
        internal bool IsSetRestoreAccessBackupVaultArn()
        {
            return this._restoreAccessBackupVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property VaultState. 
        /// <para>
        /// The current state of the restore access backup vault.
        /// </para>
        /// </summary>
        public VaultState VaultState
        {
            get { return this._vaultState; }
            set { this._vaultState = value; }
        }

        // Check to see if VaultState property is set
        internal bool IsSetVaultState()
        {
            return this._vaultState != null;
        }

    }
}