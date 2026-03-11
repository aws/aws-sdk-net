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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKey operation.
    /// Creates an Amazon Web Services Payment Cryptography key, a logical representation
    /// of a cryptographic key, that is unique in your account and Amazon Web Services Region.
    /// You use keys for cryptographic functions such as encryption and decryption. 
    /// 
    ///  
    /// <para>
    /// In addition to the key material used in cryptographic operations, an Amazon Web Services
    /// Payment Cryptography key includes metadata such as the key ARN, key usage, key origin,
    /// creation date, description, and key state.
    /// </para>
    ///  
    /// <para>
    /// When you create a key, you specify both immutable and mutable data about the key.
    /// The immutable data contains key attributes that define the scope and cryptographic
    /// operations that you can perform using the key, for example key class (example: <c>SYMMETRIC_KEY</c>),
    /// key algorithm (example: <c>TDES_2KEY</c>), key usage (example: <c>TR31_P0_PIN_ENCRYPTION_KEY</c>)
    /// and key modes of use (example: <c>Encrypt</c>). Amazon Web Services Payment Cryptography
    /// binds key attributes to keys using key blocks when you store or export them. Amazon
    /// Web Services Payment Cryptography stores the key contents wrapped and never stores
    /// or transmits them in the clear.
    /// </para>
    ///  
    /// <para>
    /// For information about valid combinations of key attributes, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
    /// key attributes</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// The mutable data contained within a key includes usage timestamp and key deletion
    /// timestamp and can be modified after creation.
    /// </para>
    ///  
    /// <para>
    /// You can use the <c>CreateKey</c> operation to generate an ECC (Elliptic Curve Cryptography)
    /// key pair used for establishing an ECDH (Elliptic Curve Diffie-Hellman) key agreement
    /// between two parties. In the ECDH key agreement process, both parties generate their
    /// own ECC key pair with key usage K3 and exchange the public keys. Each party then use
    /// their private key, the received public key from the other party, and the key derivation
    /// parameters including key derivation function, hash algorithm, derivation data, and
    /// key algorithm to derive a shared key.
    /// </para>
    ///  
    /// <para>
    /// To maintain the single-use principle of cryptographic keys in payments, ECDH derived
    /// keys should not be used for multiple purposes, such as a <c>TR31_P0_PIN_ENCRYPTION_KEY</c>
    /// and <c>TR31_K1_KEY_BLOCK_PROTECTION_KEY</c>. When creating ECC key pairs in Amazon
    /// Web Services Payment Cryptography you can optionally set the <c>DeriveKeyUsage</c>
    /// parameter, which defines the key usage bound to the symmetric key that will be derived
    /// using the ECC key pair.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
    /// Services accounts.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteKey.html">DeleteKey</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetKey.html">GetKey</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListKeys.html">ListKeys</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateKeyRequest : AmazonPaymentCryptographyRequest
    {
        private DeriveKeyUsage _deriveKeyUsage;
        private bool? _enabled;
        private bool? _exportable;
        private KeyAttributes _keyAttributes;
        private KeyCheckValueAlgorithm _keyCheckValueAlgorithm;
        private List<string> _replicationRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DeriveKeyUsage. 
        /// <para>
        /// The intended cryptographic usage of keys derived from the ECC key pair to be created.
        /// </para>
        ///  
        /// <para>
        /// After creating an ECC key pair, you cannot change the intended cryptographic usage
        /// of keys derived from it using ECDH.
        /// </para>
        /// </summary>
        public DeriveKeyUsage DeriveKeyUsage
        {
            get { return this._deriveKeyUsage; }
            set { this._deriveKeyUsage = value; }
        }

        // Check to see if DeriveKeyUsage property is set
        internal bool IsSetDeriveKeyUsage()
        {
            return this._deriveKeyUsage != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to enable the key. If the key is enabled, it is activated for use
        /// within the service. If the key is not enabled, then it is created but not activated.
        /// The default value is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Exportable. 
        /// <para>
        /// Specifies whether the key is exportable from the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Exportable
        {
            get { return this._exportable; }
            set { this._exportable = value; }
        }

        // Check to see if Exportable property is set
        internal bool IsSetExportable()
        {
            return this._exportable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// The role of the key, the algorithm it supports, and the cryptographic operations allowed
        /// with the key. This data is immutable after the key is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyAttributes KeyAttributes
        {
            get { return this._keyAttributes; }
            set { this._keyAttributes = value; }
        }

        // Check to see if KeyAttributes property is set
        internal bool IsSetKeyAttributes()
        {
            return this._keyAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property KeyCheckValueAlgorithm. 
        /// <para>
        /// The algorithm that Amazon Web Services Payment Cryptography uses to calculate the
        /// key check value (KCV). It is used to validate the key integrity.
        /// </para>
        ///  
        /// <para>
        /// For TDES keys, the KCV is computed by encrypting 8 bytes, each with value of zero,
        /// with the key to be checked and retaining the 3 highest order bytes of the encrypted
        /// result. For AES keys, the KCV is computed using a CMAC algorithm where the input data
        /// is 16 bytes of zero and retaining the 3 highest order bytes of the encrypted result.
        /// </para>
        /// </summary>
        public KeyCheckValueAlgorithm KeyCheckValueAlgorithm
        {
            get { return this._keyCheckValueAlgorithm; }
            set { this._keyCheckValueAlgorithm = value; }
        }

        // Check to see if KeyCheckValueAlgorithm property is set
        internal bool IsSetKeyCheckValueAlgorithm()
        {
            return this._keyCheckValueAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationRegions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicationRegions
        {
            get { return this._replicationRegions; }
            set { this._replicationRegions = value; }
        }

        // Check to see if ReplicationRegions property is set
        internal bool IsSetReplicationRegions()
        {
            return this._replicationRegions != null && (this._replicationRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Assigns one or more tags to the Amazon Web Services Payment Cryptography key. Use
        /// this parameter to tag a key when it is created. To tag an existing Amazon Web Services
        /// Payment Cryptography key, use the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_TagResource.html">TagResource</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a tag key and a tag value. Both the tag key and the tag value
        /// are required, but the tag value can be an empty (null) string. You can't have more
        /// than one tag on an Amazon Web Services Payment Cryptography key with the same tag
        /// key. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't include personal, confidential or sensitive information in this field. This
        /// field may be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Tagging or untagging an Amazon Web Services Payment Cryptography key can allow or
        /// deny permission to the key.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}