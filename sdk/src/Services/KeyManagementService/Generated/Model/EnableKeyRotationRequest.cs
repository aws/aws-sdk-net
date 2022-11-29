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
    /// Container for the parameters to the EnableKeyRotation operation.
    /// Enables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
    /// rotation of the key material</a> of the specified symmetric encryption KMS key. 
    /// 
    ///  
    /// <para>
    /// When you enable automatic rotation of a<a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
    /// managed KMS key</a>, KMS rotates the key material of the KMS key one year (approximately
    /// 365 days) from the enable date and every year thereafter. You can monitor rotation
    /// of the key material for your KMS keys in CloudTrail and Amazon CloudWatch. To disable
    /// rotation of the key material in a customer managed KMS key, use the <a>DisableKeyRotation</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// Automatic key rotation is supported only on <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#symmetric-cmks">symmetric
    /// encryption KMS keys</a>. You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
    /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
    /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
    /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-manage.html#multi-region-rotate">multi-Region
    /// keys</a>, set the property on the primary key. 
    /// </para>
    ///  
    /// <para>
    /// You cannot enable or disable automatic rotation <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
    /// Web Services managed KMS keys</a>. KMS always rotates the key material of Amazon Web
    /// Services managed keys every year. Rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-cmk">Amazon
    /// Web Services owned KMS keys</a> varies.
    /// </para>
    ///  <note> 
    /// <para>
    /// In May 2022, KMS changed the rotation schedule for Amazon Web Services managed keys
    /// from every three years (approximately 1,095 days) to every year (approximately 365
    /// days).
    /// </para>
    ///  
    /// <para>
    /// New Amazon Web Services managed keys are automatically rotated one year after they
    /// are created, and approximately every year thereafter. 
    /// </para>
    ///  
    /// <para>
    /// Existing Amazon Web Services managed keys are automatically rotated one year after
    /// their most recent rotation, and every year thereafter.
    /// </para>
    ///  </note> 
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
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKeyRotation</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DisableKeyRotation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetKeyRotationStatus</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class EnableKeyRotationRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies a symmetric encryption KMS key. You cannot enable automatic rotation of
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
        /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-manage.html#multi-region-rotate">multi-Region
        /// keys</a>, set the property on the primary key.
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

    }
}