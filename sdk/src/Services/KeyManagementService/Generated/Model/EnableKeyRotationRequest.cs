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
    /// Container for the parameters to the EnableKeyRotation operation.
    /// Enables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-enable-disable.html">automatic
    /// rotation of the key material</a> of the specified symmetric encryption KMS key. 
    /// 
    ///  
    /// <para>
    /// By default, when you enable automatic rotation of a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer
    /// managed KMS key</a>, KMS rotates the key material of the KMS key one year (approximately
    /// 365 days) from the enable date and every year thereafter. You can use the optional
    /// <c>RotationPeriodInDays</c> parameter to specify a custom rotation period when you
    /// enable key rotation, or you can use <c>RotationPeriodInDays</c> to modify the rotation
    /// period of a key that you previously enabled automatic key rotation on.
    /// </para>
    ///  
    /// <para>
    /// You can monitor rotation of the key material for your KMS keys in CloudTrail and Amazon
    /// CloudWatch. To disable rotation of the key material in a customer managed KMS key,
    /// use the <a>DisableKeyRotation</a> operation. You can use the <a>GetKeyRotationStatus</a>
    /// operation to identify any in progress rotations. You can use the <a>ListKeyRotations</a>
    /// operation to view the details of completed rotations.
    /// </para>
    ///  
    /// <para>
    /// Automatic key rotation is supported only on symmetric encryption KMS keys. You cannot
    /// enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
    /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
    /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
    /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
    /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region
    /// keys</a>, set the property on the primary key. 
    /// </para>
    ///  
    /// <para>
    /// You cannot enable or disable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
    /// Web Services managed KMS keys</a>. KMS always rotates the key material of Amazon Web
    /// Services managed keys every year. Rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-key">Amazon
    /// Web Services owned KMS keys</a> is managed by the Amazon Web Services service that
    /// owns the key.
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
    ///  </li> <li> 
    /// <para>
    ///  <a>ListKeyRotations</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RotateKeyOnDemand</a> 
    /// </para>
    ///  <note> 
    /// <para>
    /// You can perform on-demand (<a>RotateKeyOnDemand</a>) rotation of the key material
    /// in customer managed KMS keys, regardless of whether or not automatic key rotation
    /// is enabled.
    /// </para>
    ///  </note> </li> </ul> 
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class EnableKeyRotationRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;
        private int? _rotationPeriodInDays;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies a symmetric encryption KMS key. You cannot enable automatic rotation of
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
        /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region
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

        /// <summary>
        /// Gets and sets the property RotationPeriodInDays. 
        /// <para>
        /// Use this parameter to specify a custom period of time between each rotation date.
        /// If no value is specified, the default value is 365 days.
        /// </para>
        ///  
        /// <para>
        /// The rotation period defines the number of days after you enable automatic key rotation
        /// that KMS will rotate your key material, and the number of days between each automatic
        /// rotation thereafter.
        /// </para>
        ///  
        /// <para>
        /// You can use the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/conditions-kms.html#conditions-kms-rotation-period-in-days">
        /// <c>kms:RotationPeriodInDays</c> </a> condition key to further constrain the values
        /// that principals can specify in the <c>RotationPeriodInDays</c> parameter.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        /// </summary>
        [AWSProperty(Min=90, Max=2560)]
        public int? RotationPeriodInDays
        {
            get { return this._rotationPeriodInDays; }
            set { this._rotationPeriodInDays = value; }
        }

        // Check to see if RotationPeriodInDays property is set
        internal bool IsSetRotationPeriodInDays()
        {
            return this._rotationPeriodInDays.HasValue; 
        }

    }
}