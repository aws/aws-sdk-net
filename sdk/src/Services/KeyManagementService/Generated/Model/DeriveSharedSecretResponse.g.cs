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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        [AWSProperty(Min = 1, Max = 6144)]
        public MemoryStream CiphertextForRecipient { get; set; }

        /// <summary>
        /// Checks to see if the CiphertextForRecipient property is set.
        /// </summary>
        internal bool IsSetCiphertextForRecipient() => this.CiphertextForRecipient != null;

        /// <summary>
        /// Gets and sets the property KeyAgreementAlgorithm. 
        /// <para>
        /// Identifies the key agreement algorithm used to derive the shared secret.
        /// </para>
        /// </summary>
        public KeyAgreementAlgorithmSpec KeyAgreementAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyAgreementAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyAgreementAlgorithm() => this.KeyAgreementAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the KMS key used to derive the shared secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

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
        public OriginType KeyOrigin { get; set; }

        /// <summary>
        /// Checks to see if the KeyOrigin property is set.
        /// </summary>
        internal bool IsSetKeyOrigin() => this.KeyOrigin != null;

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
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public MemoryStream SharedSecret { get; set; }

        /// <summary>
        /// Checks to see if the SharedSecret property is set.
        /// </summary>
        internal bool IsSetSharedSecret() => this.SharedSecret != null;
    }
}
