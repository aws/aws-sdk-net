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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the ScheduleKeyDeletion operation.
    /// Schedules the deletion of a KMS key. By default, KMS applies a waiting period of 30
    /// days, but you can specify a waiting period of 7-30 days. When this operation is successful,
    /// the key state of the KMS key changes to <code>PendingDeletion</code> and the key can't
    /// be used in any cryptographic operations. It remains in this state for the duration
    /// of the waiting period. Before the waiting period ends, you can use <a>CancelKeyDeletion</a>
    /// to cancel the deletion of the KMS key. After the waiting period ends, KMS deletes
    /// the KMS key, its key material, and all KMS data associated with it, including all
    /// aliases that refer to it.
    /// 
    ///  <important> 
    /// <para>
    /// Deleting a KMS key is a destructive and potentially dangerous operation. When a KMS
    /// key is deleted, all data that was encrypted under the KMS key is unrecoverable. (The
    /// only exception is a multi-Region replica key.) To prevent the use of a KMS key without
    /// deleting it, use <a>DisableKey</a>. 
    /// </para>
    ///  </important> 
    /// <para>
    /// You can schedule the deletion of a multi-Region primary key and its replica keys at
    /// any time. However, KMS will not delete a multi-Region primary key with existing replica
    /// keys. If you schedule the deletion of a primary key with replicas, its key state changes
    /// to <code>PendingReplicaDeletion</code> and it cannot be replicated or used in cryptographic
    /// operations. This status can continue indefinitely. When the last of its replicas keys
    /// is deleted (not just scheduled), the key state of the primary key changes to <code>PendingDeletion</code>
    /// and its waiting period (<code>PendingWindowInDays</code>) begins. For details, see
    /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-delete.html">Deleting
    /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When KMS <a href="https://docs.aws.amazon.com/kms/latest/developerguide/delete-cmk-keystore.html">deletes
    /// a KMS key from an CloudHSM key store</a>, it makes a best effort to delete the associated
    /// key material from the associated CloudHSM cluster. However, you might need to manually
    /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
    /// the orphaned key material</a> from the cluster and its backups. <a href="https://docs.aws.amazon.com/kms/latest/developerguide/delete-xks-key.html">Deleting
    /// a KMS key from an external key store</a> has no effect on the associated external
    /// key. However, for both types of custom key stores, deleting a KMS key is destructive
    /// and irreversible. You cannot decrypt ciphertext encrypted under the KMS key by using
    /// only its associated external key or CloudHSM key. Also, you cannot recreate a KMS
    /// key in an external key store by creating a new KMS key with the same key material.
    /// </para>
    ///  
    /// <para>
    /// For more information about scheduling a KMS key for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
    /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
    /// different Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: kms:ScheduleKeyDeletion (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CancelKeyDeletion</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisableKey</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ScheduleKeyDeletionRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;
        private int? _pendingWindowInDays;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The unique identifier of the KMS key to delete.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or key ARN of the KMS key.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property PendingWindowInDays. 
        /// <para>
        /// The waiting period, specified in number of days. After the waiting period ends, KMS
        /// deletes the KMS key.
        /// </para>
        ///  
        /// <para>
        /// If the KMS key is a multi-Region primary key with replica keys, the waiting period
        /// begins when the last of its replica keys is deleted. Otherwise, the waiting period
        /// begins immediately.
        /// </para>
        ///  
        /// <para>
        /// This value is optional. If you include a value, it must be between 7 and 30, inclusive.
        /// If you do not include a value, it defaults to 30.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=365)]
        public int PendingWindowInDays
        {
            get { return this._pendingWindowInDays.GetValueOrDefault(); }
            set { this._pendingWindowInDays = value; }
        }

        // Check to see if PendingWindowInDays property is set
        internal bool IsSetPendingWindowInDays()
        {
            return this._pendingWindowInDays.HasValue; 
        }

    }
}