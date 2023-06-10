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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Container for the parameters to the EncryptData operation.
    /// Encrypts plaintext data to ciphertext using symmetric, asymmetric, or DUKPT data encryption
    /// key. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/encrypt-data.html">Encrypt
    /// data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can generate an encryption key within Amazon Web Services Payment Cryptography
    /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
    /// You can import your own encryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
    /// For this operation, the key must have <code>KeyModesOfUse</code> set to <code>Encrypt</code>.
    /// In asymmetric encryption, plaintext is encrypted using public component. You can import
    /// the public component of an asymmetric key pair created outside Amazon Web Services
    /// Payment Cryptography by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>).
    /// 
    /// </para>
    ///  
    /// <para>
    /// for symmetric and DUKPT encryption, Amazon Web Services Payment Cryptography supports
    /// <code>TDES</code> and <code>AES</code> algorithms. For asymmetric encryption, Amazon
    /// Web Services Payment Cryptography supports <code>RSA</code>. To encrypt using DUKPT,
    /// you must already have a DUKPT key in your account with <code>KeyModesOfUse</code>
    /// set to <code>DeriveKey</code>, or you can generate a new DUKPT key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
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
        /// The <code>keyARN</code> of the encryption key that Amazon Web Services Payment Cryptography
        /// uses for plaintext encryption.
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
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=16, Max=4064)]
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

    }
}