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
    /// This is the response object from the GenerateDataKeyPairWithoutPlaintext operation.
    /// </summary>
    public partial class GenerateDataKeyPairWithoutPlaintextResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">key
        /// ARN</a>) of the KMS key that encrypted the private key.
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
        /// The identifier of the key material used to encrypt the private key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 64)]
        public string KeyMaterialId { get; set; }

        /// <summary>
        /// Checks to see if the KeyMaterialId property is set.
        /// </summary>
        internal bool IsSetKeyMaterialId() => this.KeyMaterialId != null;

        /// <summary>
        /// Gets and sets the property KeyPairSpec. 
        /// <para>
        /// The type of data key pair that was generated.
        /// </para>
        /// </summary>
        public DataKeyPairSpec KeyPairSpec { get; set; }

        /// <summary>
        /// Checks to see if the KeyPairSpec property is set.
        /// </summary>
        internal bool IsSetKeyPairSpec() => this.KeyPairSpec != null;

        /// <summary>
        /// Gets and sets the property PrivateKeyCiphertextBlob. 
        /// <para>
        /// The encrypted copy of the private key. When you use the HTTP API or the Amazon Web
        /// Services CLI, the value is Base64-encoded. Otherwise, it is not Base64-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6144)]
        public MemoryStream PrivateKeyCiphertextBlob { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKeyCiphertextBlob property is set.
        /// </summary>
        internal bool IsSetPrivateKeyCiphertextBlob() => this.PrivateKeyCiphertextBlob != null;

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public key (in plaintext). When you use the HTTP API or the Amazon Web Services
        /// CLI, the value is Base64-encoded. Otherwise, it is not Base64-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public MemoryStream PublicKey { get; set; }

        /// <summary>
        /// Checks to see if the PublicKey property is set.
        /// </summary>
        internal bool IsSetPublicKey() => this.PublicKey != null;
    }
}
