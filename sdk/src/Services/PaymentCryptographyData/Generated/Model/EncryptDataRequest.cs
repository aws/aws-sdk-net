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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
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
namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Container for the parameters to the EncryptData operation.
    /// Encrypts plaintext data to ciphertext using a symmetric (TDES, AES), asymmetric (RSA),
    /// or derived (DUKPT or EMV) encryption key scheme. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/encrypt-data.html">Encrypt
    /// data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can generate an encryption key within Amazon Web Services Payment Cryptography
    /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
    /// You can import your own encryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
    /// </para>
    ///  
    /// <para>
    /// For this operation, the key must have <c>KeyModesOfUse</c> set to <c>Encrypt</c>.
    /// In asymmetric encryption, plaintext is encrypted using public component. You can import
    /// the public component of an asymmetric key pair created outside Amazon Web Services
    /// Payment Cryptography by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// This operation also supports dynamic keys, allowing you to pass a dynamic encryption
    /// key as a TR-31 WrappedKeyBlock. This can be used when key material is frequently rotated,
    /// such as during every card transaction, and there is need to avoid importing short-lived
    /// keys into Amazon Web Services Payment Cryptography. To encrypt using dynamic keys,
    /// the <c>keyARN</c> is the Key Encryption Key (KEK) of the TR-31 wrapped encryption
    /// key material. The incoming wrapped key shall have a key purpose of D0 with a mode
    /// of use of B or D. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/use-cases-acquirers-dynamickeys.html">Using
    /// Dynamic Keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For symmetric and DUKPT encryption, Amazon Web Services Payment Cryptography supports
    /// <c>TDES</c> and <c>AES</c> algorithms. For EMV encryption, Amazon Web Services Payment
    /// Cryptography supports <c>TDES</c> algorithms.For asymmetric encryption, Amazon Web
    /// Services Payment Cryptography supports <c>RSA</c>. 
    /// </para>
    ///  
    /// <para>
    /// When you use TDES or TDES DUKPT, the plaintext data length must be a multiple of 8
    /// bytes. For AES or AES DUKPT, the plaintext data length must be a multiple of 16 bytes.
    /// For RSA, it sould be equal to the key size unless padding is enabled.
    /// </para>
    ///  
    /// <para>
    /// To encrypt using DUKPT, you must already have a BDK (Base Derivation Key) key in your
    /// account with <c>KeyModesOfUse</c> set to <c>DeriveKey</c>, or you can generate a new
    /// DUKPT key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
    /// To encrypt using EMV, you must already have an IMK (Issuer Master Key) key in your
    /// account with <c>KeyModesOfUse</c> set to <c>DeriveKey</c>.
    /// </para>
    ///  
    /// <para>
    /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
    /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
    /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
    /// User Guide</i>.
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
    ///  <a>DecryptData</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ReEncryptData</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class EncryptDataRequest : AmazonPaymentCryptographyDataRequest
    {
        private EncryptionDecryptionAttributes _encryptionAttributes;
        private string _keyIdentifier;
        private string _plainText;
        private WrappedKey _wrappedKey;

        /// <summary>
        /// Gets and sets the property EncryptionAttributes. 
        /// <para>
        /// The encryption key type and attributes for plaintext encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionDecryptionAttributes EncryptionAttributes
        {
            get { return this._encryptionAttributes; }
            set { this._encryptionAttributes = value; }
        }

        // Check to see if EncryptionAttributes property is set
        internal bool IsSetEncryptionAttributes()
        {
            return this._encryptionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the encryption key that Amazon Web Services Payment Cryptography
        /// uses for plaintext encryption.
        /// </para>
        ///  
        /// <para>
        /// When a WrappedKeyBlock is provided, this value will be the identifier to the key wrapping
        /// key. Otherwise, it is the key identifier used to perform the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string KeyIdentifier
        {
            get { return this._keyIdentifier; }
            set { this._keyIdentifier = value; }
        }

        // Check to see if KeyIdentifier property is set
        internal bool IsSetKeyIdentifier()
        {
            return this._keyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PlainText. 
        /// <para>
        /// The plaintext to be encrypted.
        /// </para>
        ///  <note> 
        /// <para>
        /// For encryption using asymmetric keys, plaintext data length is constrained by encryption
        /// key strength that you define in <c>KeyAlgorithm</c> and padding type that you define
        /// in <c>AsymmetricEncryptionAttributes</c>. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/encrypt-data.html">Encrypt
        /// data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=4096)]
        public string PlainText
        {
            get { return this._plainText; }
            set { this._plainText = value; }
        }

        // Check to see if PlainText property is set
        internal bool IsSetPlainText()
        {
            return this._plainText != null;
        }

        /// <summary>
        /// Gets and sets the property WrappedKey. 
        /// <para>
        /// The WrappedKeyBlock containing the encryption key for plaintext encryption.
        /// </para>
        /// </summary>
        public WrappedKey WrappedKey
        {
            get { return this._wrappedKey; }
            set { this._wrappedKey = value; }
        }

        // Check to see if WrappedKey property is set
        internal bool IsSetWrappedKey()
        {
            return this._wrappedKey != null;
        }

    }
}