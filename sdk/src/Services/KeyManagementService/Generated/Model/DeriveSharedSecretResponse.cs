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
    /// This is the response object from the DeriveSharedSecret operation.
    /// </summary>
    public partial class DeriveSharedSecretResponse : AmazonWebServiceResponse
    {
        private MemoryStream _ciphertextForRecipient;
        private KeyAgreementAlgorithmSpec _keyAgreementAlgorithm;
        private string _keyId;
        private OriginType _keyOrigin;
        private MemoryStream _sharedSecret;

        /// <summary>
        /// Gets and sets the property CiphertextForRecipient. 
        /// <para>
        /// The plaintext shared secret encrypted with the public key from the attestation document.
        /// This ciphertext can be decrypted only by using a private key from the attested environment.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This field is included in the response only when the <c>Recipient</c> parameter in
        /// the request includes a valid attestation document from an Amazon Web Services Nitro
        /// enclave or NitroTPM. For information about the interaction between KMS and Amazon
        /// Web Services Nitro Enclaves or Amazon Web Services NitroTPM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/cryptographic-attestation.html">Cryptographic
        /// attestation support in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
        public MemoryStream CiphertextForRecipient
        {
            get { return this._ciphertextForRecipient; }
            set { this._ciphertextForRecipient = value; }
        }

        // Check to see if CiphertextForRecipient property is set
        internal bool IsSetCiphertextForRecipient()
        {
            return this._ciphertextForRecipient != null;
        }

        /// <summary>
        /// Gets and sets the property KeyAgreementAlgorithm. 
        /// <para>
        /// Identifies the key agreement algorithm used to derive the shared secret.
        /// </para>
        /// </summary>
        public KeyAgreementAlgorithmSpec KeyAgreementAlgorithm
        {
            get { return this._keyAgreementAlgorithm; }
            set { this._keyAgreementAlgorithm = value; }
        }

        // Check to see if KeyAgreementAlgorithm property is set
        internal bool IsSetKeyAgreementAlgorithm()
        {
            return this._keyAgreementAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the KMS key used to derive the shared secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property KeyOrigin. 
        /// <para>
        /// The source of the key material for the specified KMS key.
        /// </para>
        ///  
        /// <para>
        /// When this value is <c>AWS_KMS</c>, KMS created the key material. When this value is
        /// <c>EXTERNAL</c>, the key material was imported or the KMS key doesn't have any key
        /// material.
        /// </para>
        ///  
        /// <para>
        /// The only valid values for DeriveSharedSecret are <c>AWS_KMS</c> and <c>EXTERNAL</c>.
        /// DeriveSharedSecret does not support KMS keys with a <c>KeyOrigin</c> value of <c>AWS_CLOUDHSM</c>
        /// or <c>EXTERNAL_KEY_STORE</c>.
        /// </para>
        /// </summary>
        public OriginType KeyOrigin
        {
            get { return this._keyOrigin; }
            set { this._keyOrigin = value; }
        }

        // Check to see if KeyOrigin property is set
        internal bool IsSetKeyOrigin()
        {
            return this._keyOrigin != null;
        }

        /// <summary>
        /// Gets and sets the property SharedSecret. 
        /// <para>
        /// The raw secret derived from the specified key agreement algorithm, private key in
        /// the asymmetric KMS key, and your peer's public key.
        /// </para>
        ///  
        /// <para>
        /// If the response includes the <c>CiphertextForRecipient</c> field, the <c>SharedSecret</c>
        /// field is null or empty.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public MemoryStream SharedSecret
        {
            get { return this._sharedSecret; }
            set { this._sharedSecret = value; }
        }

        // Check to see if SharedSecret property is set
        internal bool IsSetSharedSecret()
        {
            return this._sharedSecret != null;
        }

    }
}