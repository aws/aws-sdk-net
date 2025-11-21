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
    /// This is the response object from the GenerateRandom operation.
    /// </summary>
    public partial class GenerateRandomResponse : AmazonWebServiceResponse
    {
        private MemoryStream _ciphertextForRecipient;
        private MemoryStream _plaintext;

        /// <summary>
        /// Gets and sets the property CiphertextForRecipient. 
        /// <para>
        /// The plaintext random bytes encrypted with the public key from the attestation document.
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
        /// Gets and sets the property Plaintext. 
        /// <para>
        /// The random byte string. When you use the HTTP API or the Amazon Web Services CLI,
        /// the value is Base64-encoded. Otherwise, it is not Base64-encoded.
        /// </para>
        ///  
        /// <para>
        /// If the response includes the <c>CiphertextForRecipient</c> field, the <c>Plaintext</c>
        /// field is null or empty.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public MemoryStream Plaintext
        {
            get { return this._plaintext; }
            set { this._plaintext = value; }
        }

        // Check to see if Plaintext property is set
        internal bool IsSetPlaintext()
        {
            return this._plaintext != null;
        }

    }
}