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
    /// Container for the parameters to the DecryptData operation.
    /// Decrypts ciphertext data to plaintext using symmetric, asymmetric, or DUKPT data encryption
    /// key. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/decrypt-data.html">Decrypt
    /// data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can use an encryption key generated within Amazon Web Services Payment Cryptography,
    /// or you can import your own encryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
    /// For this operation, the key must have <code>KeyModesOfUse</code> set to <code>Decrypt</code>.
    /// In asymmetric decryption, Amazon Web Services Payment Cryptography decrypts the ciphertext
    /// using the private component of the asymmetric encryption key pair. For data encryption
    /// outside of Amazon Web Services Payment Cryptography, you can export the public component
    /// of the asymmetric key pair by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>.
    /// </para>
    ///  
    /// <para>
    /// For symmetric and DUKPT decryption, Amazon Web Services Payment Cryptography supports
    /// <code>TDES</code> and <code>AES</code> algorithms. For asymmetric decryption, Amazon
    /// Web Services Payment Cryptography supports <code>RSA</code>. When you use DUKPT, for
    /// <code>TDES</code> algorithm, the ciphertext data length must be a multiple of 16 bytes.
    /// For <code>AES</code> algorithm, the ciphertext data length must be a multiple of 32
    /// bytes.
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
    ///  <a>EncryptData</a> 
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
    ///  </li> </ul>
    /// </summary>
    public partial class DecryptDataRequest : AmazonPaymentCryptographyDataRequest
    {
        private string _cipherText;
        private EncryptionDecryptionAttributes _decryptionAttributes;
        private string _keyIdentifier;

        /// <summary>
        /// Gets and sets the property CipherText. 
        /// <para>
        /// The ciphertext to decrypt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=16, Max=4096)]
        public string CipherText
        {
            get { return this._cipherText; }
            set { this._cipherText = value; }
        }

        // Check to see if CipherText property is set
        internal bool IsSetCipherText()
        {
            return this._cipherText != null;
        }

        /// <summary>
        /// Gets and sets the property DecryptionAttributes. 
        /// <para>
        /// The encryption key type and attributes for ciphertext decryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionDecryptionAttributes DecryptionAttributes
        {
            get { return this._decryptionAttributes; }
            set { this._decryptionAttributes = value; }
        }

        // Check to see if DecryptionAttributes property is set
        internal bool IsSetDecryptionAttributes()
        {
            return this._decryptionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <code>keyARN</code> of the encryption key that Amazon Web Services Payment Cryptography
        /// uses for ciphertext decryption.
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

    }
}