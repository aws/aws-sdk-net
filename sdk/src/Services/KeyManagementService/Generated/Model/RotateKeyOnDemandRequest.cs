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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the RotateKeyOnDemand operation.
    /// Immediately initiates rotation of the key material of the specified symmetric encryption
    /// KMS key.
    /// 
    ///  
    /// <para>
    /// You can perform <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-on-demand.html">on-demand
    /// rotation</a> of the key material in customer managed KMS keys, regardless of whether
    /// or not <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-enable-disable.html">automatic
    /// key rotation</a> is enabled. On-demand rotations do not change existing automatic
    /// rotation schedules. For example, consider a KMS key that has automatic key rotation
    /// enabled with a rotation period of 730 days. If the key is scheduled to automatically
    /// rotate on April 14, 2024, and you perform an on-demand rotation on April 10, 2024,
    /// the key will automatically rotate, as scheduled, on April 14, 2024 and every 730 days
    /// thereafter.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can perform on-demand key rotation a <b>maximum of 10 times</b> per KMS key. You
    /// can use the KMS console to view the number of remaining on-demand rotations available
    /// for a KMS key.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can use <a>GetKeyRotationStatus</a> to identify any in progress on-demand rotations.
    /// You can use <a>ListKeyRotations</a> to identify the date that completed on-demand
    /// rotations were performed. You can monitor rotation of the key material for your KMS
    /// keys in CloudTrail and Amazon CloudWatch.
    /// </para>
    ///  
    /// <para>
    /// On-demand key rotation is supported only on symmetric encryption KMS keys. You cannot
    /// perform on-demand rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
    /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
    /// KMS keys</a>, multi-Region KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
    /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
    /// key store</a>. When you initiate on-demand key rotation on a symmetric encryption
    /// KMS key with imported key material, you must have already imported <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-import-key-material.html">new
    /// key material</a> and that key material's state should be <c>PENDING_ROTATION</c>.
    /// Use the <c>ListKeyRotations</c> operation to check the state of all key materials
    /// associated with a KMS key. To perform on-demand rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region
    /// keys</a>, invoke the on-demand rotation on the primary key.
    /// </para>
    ///  
    /// <para>
    /// You cannot initiate on-demand rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
    /// Web Services managed KMS keys</a>. KMS always rotates the key material of Amazon Web
    /// Services managed keys every year. Rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-key">Amazon
    /// Web Services owned KMS keys</a> is managed by the Amazon Web Services service that
    /// owns the key.
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
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:RotateKeyOnDemand</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>EnableKeyRotation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisableKeyRotation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetKeyRotationStatus</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ImportKeyMaterial</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListKeyRotations</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class RotateKeyOnDemandRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies a symmetric encryption KMS key. You cannot perform on-demand rotation of
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
        /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// KMS keys</a>, multi-Region KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. To perform on-demand rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region
        /// keys</a>, invoke the on-demand rotation on the primary key.
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
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
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

    }
}