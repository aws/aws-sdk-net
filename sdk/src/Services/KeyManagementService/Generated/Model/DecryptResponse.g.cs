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
    /// This is the response object from the Decrypt operation.
    /// </summary>
    public partial class DecryptResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CiphertextForRecipient. 
        /// <para>
        /// The plaintext data encrypted with the public key from the attestation document. This
        /// ciphertext can be decrypted only by using a private key from the attested environment.
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
        /// Gets and sets the property EncryptionAlgorithm. 
        /// <para>
        /// The encryption algorithm that was used to decrypt the ciphertext.
        /// </para>
        /// </summary>
        public EncryptionAlgorithmSpec EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionAlgorithm property is set.
        /// </summary>
        internal bool IsSetEncryptionAlgorithm() => this.EncryptionAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">key
        /// ARN</a>) of the KMS key that was used to decrypt the ciphertext.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property KeyMaterialId. 
        /// <para>
        /// The identifier of the key material used to decrypt the ciphertext. This field is present
        /// only when the operation uses a symmetric encryption KMS key. This field is omitted
        /// if the request includes the <c>Recipient</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 64)]
        public string KeyMaterialId { get; set; }

        /// <summary>
        /// Checks to see if the KeyMaterialId property is set.
        /// </summary>
        internal bool IsSetKeyMaterialId() => this.KeyMaterialId != null;

        /// <summary>
        /// Gets and sets the property Plaintext. 
        /// <para>
        /// Decrypted plaintext data. When you use the HTTP API or the Amazon Web Services CLI,
        /// the value is Base64-encoded. Otherwise, it is not Base64-encoded.
        /// </para>
        ///  
        /// <para>
        /// If the response includes the <c>CiphertextForRecipient</c> field, the <c>Plaintext</c>
        /// field is null or empty.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public MemoryStream Plaintext { get; set; }

        /// <summary>
        /// Checks to see if the Plaintext property is set.
        /// </summary>
        internal bool IsSetPlaintext() => this.Plaintext != null;
    }
}
