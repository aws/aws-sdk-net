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
    /// Contains information about the party that receives the response from the API operation.
    /// 
    ///  
    /// <para>
    /// This data type is designed to support Amazon Web Services Nitro Enclaves and Amazon
    /// Web Services NitroTPM, which lets you create an attested environment in Amazon EC2.
    /// For information about the interaction between KMS and Amazon Web Services Nitro Enclaves
    /// or Amazon Web Services NitroTPM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/cryptographic-attestation.html">Cryptographic
    /// attestation support in KMS</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RecipientInfo
    {
        private MemoryStream _attestationDocument;
        private KeyEncryptionMechanism _keyEncryptionAlgorithm;

        /// <summary>
        /// Gets and sets the property AttestationDocument. 
        /// <para>
        /// The attestation document for an Amazon Web Services Nitro Enclave or a NitroTPM. This
        /// document includes the enclave's public key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=262144)]
        public MemoryStream AttestationDocument
        {
            get { return this._attestationDocument; }
            set { this._attestationDocument = value; }
        }

        // Check to see if AttestationDocument property is set
        internal bool IsSetAttestationDocument()
        {
            return this._attestationDocument != null;
        }

        /// <summary>
        /// Gets and sets the property KeyEncryptionAlgorithm. 
        /// <para>
        /// The encryption algorithm that KMS should use with the public key for an Amazon Web
        /// Services Nitro Enclave or NitroTPM to encrypt plaintext values for the response. The
        /// only valid value is <c>RSAES_OAEP_SHA_256</c>.
        /// </para>
        /// </summary>
        public KeyEncryptionMechanism KeyEncryptionAlgorithm
        {
            get { return this._keyEncryptionAlgorithm; }
            set { this._keyEncryptionAlgorithm = value; }
        }

        // Check to see if KeyEncryptionAlgorithm property is set
        internal bool IsSetKeyEncryptionAlgorithm()
        {
            return this._keyEncryptionAlgorithm != null;
        }

    }
}