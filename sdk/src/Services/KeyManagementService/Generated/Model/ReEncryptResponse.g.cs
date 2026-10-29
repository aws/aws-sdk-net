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
    /// This is the response object from the ReEncrypt operation.
    /// </summary>
    public partial class ReEncryptResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CiphertextBlob. 
        /// <para>
        /// The reencrypted data. When you use the HTTP API or the Amazon Web Services CLI, the
        /// value is Base64-encoded. Otherwise, it is not Base64-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6144)]
        public MemoryStream CiphertextBlob { get; set; }

        /// <summary>
        /// Checks to see if the CiphertextBlob property is set.
        /// </summary>
        internal bool IsSetCiphertextBlob() => this.CiphertextBlob != null;

        /// <summary>
        /// Gets and sets the property DestinationEncryptionAlgorithm. 
        /// <para>
        /// The encryption algorithm that was used to reencrypt the data.
        /// </para>
        /// </summary>
        public EncryptionAlgorithmSpec DestinationEncryptionAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the DestinationEncryptionAlgorithm property is set.
        /// </summary>
        internal bool IsSetDestinationEncryptionAlgorithm() => this.DestinationEncryptionAlgorithm != null;

        /// <summary>
        /// Gets and sets the property DestinationKeyMaterialId. 
        /// <para>
        /// The identifier of the key material used to reencrypt the data. This field is present
        /// only when data is reencrypted using a symmetric encryption KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 64)]
        public string DestinationKeyMaterialId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationKeyMaterialId property is set.
        /// </summary>
        internal bool IsSetDestinationKeyMaterialId() => this.DestinationKeyMaterialId != null;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">key
        /// ARN</a>) of the KMS key that was used to reencrypt the data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property SourceEncryptionAlgorithm. 
        /// <para>
        /// The encryption algorithm that was used to decrypt the ciphertext before it was reencrypted.
        /// </para>
        /// </summary>
        public EncryptionAlgorithmSpec SourceEncryptionAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SourceEncryptionAlgorithm property is set.
        /// </summary>
        internal bool IsSetSourceEncryptionAlgorithm() => this.SourceEncryptionAlgorithm != null;

        /// <summary>
        /// Gets and sets the property SourceKeyId. 
        /// <para>
        /// Unique identifier of the KMS key used to originally encrypt the data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SourceKeyId { get; set; }

        /// <summary>
        /// Checks to see if the SourceKeyId property is set.
        /// </summary>
        internal bool IsSetSourceKeyId() => this.SourceKeyId != null;

        /// <summary>
        /// Gets and sets the property SourceKeyMaterialId. 
        /// <para>
        /// The identifier of the key material used to originally encrypt the data. This field
        /// is present only when the original encryption used a symmetric encryption KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 64)]
        public string SourceKeyMaterialId { get; set; }

        /// <summary>
        /// Checks to see if the SourceKeyMaterialId property is set.
        /// </summary>
        internal bool IsSetSourceKeyMaterialId() => this.SourceKeyMaterialId != null;
    }
}
