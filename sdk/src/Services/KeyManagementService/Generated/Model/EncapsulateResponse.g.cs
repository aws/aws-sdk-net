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
    /// This is the response object from the Encapsulate operation.
    /// </summary>
    public partial class EncapsulateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EncapsulationAlgorithm. 
        /// <para>
        /// The key encapsulation algorithm used to generate the shared secret.
        /// </para>
        /// </summary>
        public EncapsulationAlgorithmSpec EncapsulationAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the EncapsulationAlgorithm property is set.
        /// </summary>
        internal bool IsSetEncapsulationAlgorithm() => this.EncapsulationAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The identifier of the ML-KEM KMS key used to encapsulate the shared secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property SharedSecret. 
        /// <para>
        /// The plaintext shared secret. It is a 32-byte cryptographically random value that both
        /// parties can use directly as key material or pass through a key derivation function
        /// to generate multiple keys and nonces. When you use the HTTP API or the Amazon Web
        /// Services CLI, the value is Base64-encoded. Otherwise, it is not Base64-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public MemoryStream SharedSecret { get; set; }

        /// <summary>
        /// Checks to see if the SharedSecret property is set.
        /// </summary>
        internal bool IsSetSharedSecret() => this.SharedSecret != null;

        /// <summary>
        /// Gets and sets the property SharedSecretCiphertextBlob. 
        /// <para>
        /// The encapsulated form of the shared secret. Pass this value to the <a>Decapsulate</a>
        /// operation to recover the shared secret. When you use the HTTP API or the Amazon Web
        /// Services CLI, the value is Base64-encoded. Otherwise, it is not Base64-encoded. The
        /// length of <c>SharedSecretCiphertextBlob</c> depends on the ML-KEM key spec. Before
        /// Base64 encoding, the encapsulated shared secret is 768 bytes for <c>ML_KEM_512</c>,
        /// 1088 bytes for <c>ML_KEM_768</c>, and 1568 bytes for <c>ML_KEM_1024</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6144)]
        public MemoryStream SharedSecretCiphertextBlob { get; set; }

        /// <summary>
        /// Checks to see if the SharedSecretCiphertextBlob property is set.
        /// </summary>
        internal bool IsSetSharedSecretCiphertextBlob() => this.SharedSecretCiphertextBlob != null;
    }
}
