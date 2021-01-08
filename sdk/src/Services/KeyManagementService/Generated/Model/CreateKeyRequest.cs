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
    /// Container for the parameters to the CreateKey operation.
    /// Creates a unique customer managed <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master-keys">customer
    /// master key</a> (CMK) in your AWS account and Region.
    /// 
    ///  
    /// <para>
    /// You can use the <code>CreateKey</code> operation to create symmetric or asymmetric
    /// CMKs.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Symmetric CMKs</b> contain a 256-bit symmetric key that never leaves AWS KMS unencrypted.
    /// To use the CMK, you must call AWS KMS. You can use a symmetric CMK to encrypt and
    /// decrypt small amounts of data, but they are typically used to generate <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-keys">data
    /// keys</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-key-pairs">data
    /// keys pairs</a>. For details, see <a>GenerateDataKey</a> and <a>GenerateDataKeyPair</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Asymmetric CMKs</b> can contain an RSA key pair or an Elliptic Curve (ECC) key
    /// pair. The private key in an asymmetric CMK never leaves AWS KMS unencrypted. However,
    /// you can use the <a>GetPublicKey</a> operation to download the public key so it can
    /// be used outside of AWS KMS. CMKs with RSA key pairs can be used to encrypt or decrypt
    /// data or sign and verify messages (but not both). CMKs with ECC key pairs can be used
    /// only to sign and verify messages.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about symmetric and asymmetric CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
    /// Symmetric and Asymmetric CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To create different types of CMKs, use the following guidance:
    /// </para>
    ///  <dl> <dt>Asymmetric CMKs</dt> <dd> 
    /// <para>
    /// To create an asymmetric CMK, use the <code>CustomerMasterKeySpec</code> parameter
    /// to specify the type of key material in the CMK. Then, use the <code>KeyUsage</code>
    /// parameter to determine whether the CMK will be used to encrypt and decrypt or sign
    /// and verify. You can't change these properties after the CMK is created.
    /// </para>
    ///  
    /// <para>
    ///  
    /// </para>
    ///  </dd> <dt>Symmetric CMKs</dt> <dd> 
    /// <para>
    /// When creating a symmetric CMK, you don't need to specify the <code>CustomerMasterKeySpec</code>
    /// or <code>KeyUsage</code> parameters. The default value for <code>CustomerMasterKeySpec</code>,
    /// <code>SYMMETRIC_DEFAULT</code>, and the default value for <code>KeyUsage</code>, <code>ENCRYPT_DECRYPT</code>,
    /// are the only valid values for symmetric CMKs. 
    /// </para>
    ///  
    /// <para>
    ///  
    /// </para>
    ///  </dd> <dt>Imported Key Material</dt> <dd> 
    /// <para>
    /// To import your own key material, begin by creating a symmetric CMK with no key material.
    /// To do this, use the <code>Origin</code> parameter of <code>CreateKey</code> with a
    /// value of <code>EXTERNAL</code>. Next, use <a>GetParametersForImport</a> operation
    /// to get a public key and import token, and use the public key to encrypt your key material.
    /// Then, use <a>ImportKeyMaterial</a> with your import token to import the key material.
    /// For step-by-step instructions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
    /// Key Material</a> in the <i> <i>AWS Key Management Service Developer Guide</i> </i>.
    /// You cannot import the key material into an asymmetric CMK.
    /// </para>
    ///  
    /// <para>
    ///  
    /// </para>
    ///  </dd> <dt>Custom Key Stores</dt> <dd> 
    /// <para>
    /// To create a symmetric CMK in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key store</a>, use the <code>CustomKeyStoreId</code> parameter to specify the custom
    /// key store. You must also use the <code>Origin</code> parameter with a value of <code>AWS_CLOUDHSM</code>.
    /// The AWS CloudHSM cluster that is associated with the custom key store must have at
    /// least two active HSMs in different Availability Zones in the AWS Region. 
    /// </para>
    ///  
    /// <para>
    /// You cannot create an asymmetric CMK in a custom key store. For information about custom
    /// key stores in AWS KMS see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Using
    /// Custom Key Stores</a> in the <i> <i>AWS Key Management Service Developer Guide</i>
    /// </i>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot use this operation to create a CMK in a
    /// different AWS account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateKey</a>
    /// (IAM policy). To use the <code>Tags</code> parameter, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:TagResource</a>
    /// (IAM policy). For examples and information about related permissions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/iam-policies.html#iam-policy-example-create-key">Allow
    /// a user to create CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListKeys</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ScheduleKeyDeletion</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateKeyRequest : AmazonKeyManagementServiceRequest
    {
        private bool? _bypassPolicyLockoutSafetyCheck;
        private CustomerMasterKeySpec _customerMasterKeySpec;
        private string _customKeyStoreId;
        private string _description;
        private KeyUsageType _keyUsage;
        private OriginType _origin;
        private string _policy;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property BypassPolicyLockoutSafetyCheck. 
        /// <para>
        /// A flag to indicate whether to bypass the key policy lockout safety check.
        /// </para>
        ///  <important> 
        /// <para>
        /// Setting this value to true increases the risk that the CMK becomes unmanageable. Do
        /// not set this value to true indiscriminately.
        /// </para>
        ///  
        /// <para>
        /// For more information, refer to the scenario in the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default
        /// Key Policy</a> section in the <i> <i>AWS Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use this parameter only when you include a policy in the request and you intend to
        /// prevent the principal that is making the request from making a subsequent <a>PutKeyPolicy</a>
        /// request on the CMK.
        /// </para>
        ///  
        /// <para>
        /// The default value is false.
        /// </para>
        /// </summary>
        public bool BypassPolicyLockoutSafetyCheck
        {
            get { return this._bypassPolicyLockoutSafetyCheck.GetValueOrDefault(); }
            set { this._bypassPolicyLockoutSafetyCheck = value; }
        }

        // Check to see if BypassPolicyLockoutSafetyCheck property is set
        internal bool IsSetBypassPolicyLockoutSafetyCheck()
        {
            return this._bypassPolicyLockoutSafetyCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerMasterKeySpec. 
        /// <para>
        /// Specifies the type of CMK to create. The default value, <code>SYMMETRIC_DEFAULT</code>,
        /// creates a CMK with a 256-bit symmetric key for encryption and decryption. For help
        /// choosing a key spec for your CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-choose.html">How
        /// to Choose Your CMK Configuration</a> in the <i>AWS Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <code>CustomerMasterKeySpec</code> determines whether the CMK contains a symmetric
        /// key or an asymmetric key pair. It also determines the encryption algorithms or signing
        /// algorithms that the CMK supports. You can't change the <code>CustomerMasterKeySpec</code>
        /// after the CMK is created. To further restrict the algorithms that can be used with
        /// the CMK, use a condition key in its key policy or IAM policy. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/policy-conditions.html#conditions-kms-encryption-algorithm">kms:EncryptionAlgorithm</a>
        /// or <a href="https://docs.aws.amazon.com/kms/latest/developerguide/policy-conditions.html#conditions-kms-signing-algorithm">kms:Signing
        /// Algorithm</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <a href="http://aws.amazon.com/kms/features/#AWS_Service_Integration">AWS services
        /// that are integrated with AWS KMS</a> use symmetric CMKs to protect your data. These
        /// services do not support asymmetric CMKs. For help determining whether a CMK is symmetric
        /// or asymmetric, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/find-symm-asymm.html">Identifying
        /// Symmetric and Asymmetric CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// AWS KMS supports the following key specs for CMKs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Symmetric key (default)
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SYMMETRIC_DEFAULT</code> (AES-256-GCM)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Asymmetric RSA key pairs
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RSA_2048</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RSA_3072</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RSA_4096</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Asymmetric NIST-recommended elliptic curve key pairs
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ECC_NIST_P256</code> (secp256r1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ECC_NIST_P384</code> (secp384r1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ECC_NIST_P521</code> (secp521r1)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Other asymmetric elliptic curve key pairs
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ECC_SECG_P256K1</code> (secp256k1), commonly used for cryptocurrencies.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public CustomerMasterKeySpec CustomerMasterKeySpec
        {
            get { return this._customerMasterKeySpec; }
            set { this._customerMasterKeySpec = value; }
        }

        // Check to see if CustomerMasterKeySpec property is set
        internal bool IsSetCustomerMasterKeySpec()
        {
            return this._customerMasterKeySpec != null;
        }

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// Creates the CMK in the specified <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> and the key material in its associated AWS CloudHSM cluster. To create
        /// a CMK in a custom key store, you must also specify the <code>Origin</code> parameter
        /// with a value of <code>AWS_CLOUDHSM</code>. The AWS CloudHSM cluster that is associated
        /// with the custom key store must have at least two active HSMs, each in a different
        /// Availability Zone in the Region.
        /// </para>
        ///  
        /// <para>
        /// This parameter is valid only for symmetric CMKs. You cannot create an asymmetric CMK
        /// in a custom key store.
        /// </para>
        ///  
        /// <para>
        /// To find the ID of a custom key store, use the <a>DescribeCustomKeyStores</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The response includes the custom key store ID and the ID of the AWS CloudHSM cluster.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CustomKeyStoreId
        {
            get { return this._customKeyStoreId; }
            set { this._customKeyStoreId = value; }
        }

        // Check to see if CustomKeyStoreId property is set
        internal bool IsSetCustomKeyStoreId()
        {
            return this._customKeyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the CMK.
        /// </para>
        ///  
        /// <para>
        /// Use a description that helps you decide whether the CMK is appropriate for a task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// Determines the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a> for which you can use the CMK. The default value is <code>ENCRYPT_DECRYPT</code>.
        /// This parameter is required only for asymmetric CMKs. You can't change the <code>KeyUsage</code>
        /// value after the CMK is created.
        /// </para>
        ///  
        /// <para>
        /// Select only one valid value.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For symmetric CMKs, omit the parameter or specify <code>ENCRYPT_DECRYPT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For asymmetric CMKs with RSA key material, specify <code>ENCRYPT_DECRYPT</code> or
        /// <code>SIGN_VERIFY</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For asymmetric CMKs with ECC key material, specify <code>SIGN_VERIFY</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KeyUsageType KeyUsage
        {
            get { return this._keyUsage; }
            set { this._keyUsage = value; }
        }

        // Check to see if KeyUsage property is set
        internal bool IsSetKeyUsage()
        {
            return this._keyUsage != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// The source of the key material for the CMK. You cannot change the origin after you
        /// create the CMK. The default is <code>AWS_KMS</code>, which means AWS KMS creates the
        /// key material.
        /// </para>
        ///  
        /// <para>
        /// When the parameter value is <code>EXTERNAL</code>, AWS KMS creates a CMK without key
        /// material so that you can import key material from your existing key management infrastructure.
        /// For more information about importing key material into AWS KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>. This value
        /// is valid only for symmetric CMKs.
        /// </para>
        ///  
        /// <para>
        /// When the parameter value is <code>AWS_CLOUDHSM</code>, AWS KMS creates the CMK in
        /// an AWS KMS <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> and creates its key material in the associated AWS CloudHSM cluster.
        /// You must also use the <code>CustomKeyStoreId</code> parameter to identify the custom
        /// key store. This value is valid only for symmetric CMKs.
        /// </para>
        /// </summary>
        public OriginType Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The key policy to attach to the CMK.
        /// </para>
        ///  
        /// <para>
        /// If you provide a key policy, it must meet the following criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you don't set <code>BypassPolicyLockoutSafetyCheck</code> to true, the key policy
        /// must allow the principal that is making the <code>CreateKey</code> request to make
        /// a subsequent <a>PutKeyPolicy</a> request on the CMK. This reduces the risk that the
        /// CMK becomes unmanageable. For more information, refer to the scenario in the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default
        /// Key Policy</a> section of the <i> <i>AWS Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each statement in the key policy must contain one or more principals. The principals
        /// in the key policy must exist and be visible to AWS KMS. When you create a new AWS
        /// principal (for example, an IAM user or role), you might need to enforce a delay before
        /// including the new principal in a key policy because the new principal might not be
        /// immediately visible to AWS KMS. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes
        /// that I make are not always immediately visible</a> in the <i>AWS Identity and Access
        /// Management User Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you do not provide a key policy, AWS KMS attaches a default key policy to the CMK.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default">Default
        /// Key Policy</a> in the <i>AWS Key Management Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// The key policy size quota is 32 kilobytes (32768 bytes).
        /// </para>
        ///  
        /// <para>
        /// For help writing and formatting a JSON policy document, see the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
        /// JSON Policy Reference</a> in the <i> <i>IAM User Guide</i> </i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string Policy
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags. Each tag consists of a tag key and a tag value. Both the tag key
        /// and the tag value are required, but the tag value can be an empty (null) string. 
        /// </para>
        ///  
        /// <para>
        /// When you add tags to an AWS resource, AWS generates a cost allocation report with
        /// usage and costs aggregated by tags. For information about adding, changing, deleting
        /// and listing tags for CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">Tagging
        /// Keys</a>.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter to tag the CMK when it is created. To add tags to an existing CMK,
        /// use the <a>TagResource</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To use this parameter, you must have <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:TagResource</a>
        /// permission in an IAM policy.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}