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
    /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
    /// specified in days, before deletion occurs. If you do not provide a waiting period,
    /// the default period of 30 days is used. When this operation is successful, the key
    /// state of the CMK changes to <code>PendingDeletion</code>. Before the waiting period
    /// ends, you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After
    /// the waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
    /// it, including all aliases that refer to it.
    /// 
    ///  <important> 
    /// <para>
    /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
    /// deleted, all data that was encrypted under the CMK is unrecoverable. To prevent the
    /// use of a CMK without deleting it, use <a>DisableKey</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you schedule deletion of a CMK from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
    /// the CMK from AWS KMS. Then AWS KMS makes a best effort to delete the key material
    /// from the associated AWS CloudHSM cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
    /// the orphaned key material</a> from the cluster and its backups.
    /// </para>
    ///  
    /// <para>
    /// For more information about scheduling a CMK for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
    /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The CMK that you use for this operation must be in a compatible key state. For details,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
    /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
    /// Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on a CMK in a different
    /// AWS account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ScheduleKeyDeletion</a>
    /// (key policy)
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
        /// The unique identifier of the customer master key (CMK) to delete.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or the Amazon Resource Name (ARN) of the CMK.
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
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
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
        /// The waiting period, specified in number of days. After the waiting period ends, AWS
        /// KMS deletes the customer master key (CMK).
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