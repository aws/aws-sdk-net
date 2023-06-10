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
    /// Container for the parameters to the GenerateRandom operation.
    /// Returns a random byte string that is cryptographically secure.
    /// 
    ///  
    /// <para>
    /// You must use the <code>NumberOfBytes</code> parameter to specify the length of the
    /// random byte string. There is no default value for string length.
    /// </para>
    ///  
    /// <para>
    /// By default, the random byte string is generated in KMS. To generate the byte string
    /// in the CloudHSM cluster associated with an CloudHSM key store, use the <code>CustomKeyStoreId</code>
    /// parameter.
    /// </para>
    ///  
    /// <para>
    ///  <code>GenerateRandom</code> also supports <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave.html">Amazon
    /// Web Services Nitro Enclaves</a>, which provide an isolated compute environment in
    /// Amazon EC2. To call <code>GenerateRandom</code> for a Nitro enclave, use the <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
    /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK. Use the <code>Recipient</code>
    /// parameter to provide the attestation document for the enclave. Instead of plaintext
    /// bytes, the response includes the plaintext bytes encrypted under the public key from
    /// the attestation document (<code>CiphertextForRecipient</code>).For information about
    /// the interaction between KMS and Amazon Web Services Nitro Enclaves, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
    /// Amazon Web Services Nitro Enclaves uses KMS</a> in the <i>Key Management Service Developer
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about entropy and random number generation, see <a href="https://docs.aws.amazon.com/kms/latest/cryptographic-details/">Key
    /// Management Service Cryptographic Details</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Not applicable. <code>GenerateRandom</code> does not use
    /// any account-specific resources, such as KMS keys.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateRandom</a>
    /// (IAM policy)
    /// </para>
    /// </summary>
    public partial class GenerateRandomRequest : AmazonKeyManagementServiceRequest
    {
        private string _customKeyStoreId;
        private int? _numberOfBytes;
        private RecipientInfo _recipient;

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// Generates the random byte string in the CloudHSM cluster that is associated with the
        /// specified CloudHSM key store. To find the ID of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// External key store IDs are not valid for this parameter. If you specify the ID of
        /// an external key store, <code>GenerateRandom</code> throws an <code>UnsupportedOperationException</code>.
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
        /// Gets and sets the property NumberOfBytes. 
        /// <para>
        /// The length of the random byte string. This parameter is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public int NumberOfBytes
        {
            get { return this._numberOfBytes.GetValueOrDefault(); }
            set { this._numberOfBytes = value; }
        }

        // Check to see if NumberOfBytes property is set
        internal bool IsSetNumberOfBytes()
        {
            return this._numberOfBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recipient. 
        /// <para>
        /// A signed <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave-how.html#term-attestdoc">attestation
        /// document</a> from an Amazon Web Services Nitro enclave and the encryption algorithm
        /// to use with the enclave's public key. The only valid encryption algorithm is <code>RSAES_OAEP_SHA_256</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This parameter only supports attestation documents for Amazon Web Services Nitro Enclaves.
        /// To include this parameter, use the <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
        /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK.
        /// </para>
        ///  
        /// <para>
        /// When you use this parameter, instead of returning plaintext bytes, KMS encrypts the
        /// plaintext bytes under the public key in the attestation document, and returns the
        /// resulting ciphertext in the <code>CiphertextForRecipient</code> field in the response.
        /// This ciphertext can be decrypted only with the private key in the enclave. The <code>Plaintext</code>
        /// field in the response is null or empty.
        /// </para>
        ///  
        /// <para>
        /// For information about the interaction between KMS and Amazon Web Services Nitro Enclaves,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
        /// Amazon Web Services Nitro Enclaves uses KMS</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public RecipientInfo Recipient
        {
            get { return this._recipient; }
            set { this._recipient = value; }
        }

        // Check to see if Recipient property is set
        internal bool IsSetRecipient()
        {
            return this._recipient != null;
        }

    }
}