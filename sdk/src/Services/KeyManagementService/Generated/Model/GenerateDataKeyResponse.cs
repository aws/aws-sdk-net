/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the GenerateDataKey operation.
    /// </summary>
    public partial class GenerateDataKeyResponse : AmazonWebServiceResponse
    {
        private MemoryStream _ciphertextBlob;
        private string _keyId;
        private MemoryStream _plaintext;

        /// <summary>
        /// Gets and sets the property CiphertextBlob. 
        /// <para>
        /// Ciphertext that contains the encrypted data key. You must store the blob and enough
        /// information to reconstruct the encryption context so that the data encrypted by using
        /// the key can later be decrypted. You must provide both the ciphertext blob and the
        /// encryption context to the <a>Decrypt</a> API to recover the plaintext data key and
        /// decrypt the object. 
        /// </para>
        ///  
        /// <para>
        /// If you are using the CLI, the value is Base64 encoded. Otherwise, it is not encoded.
        /// </para>
        /// </summary>
        public MemoryStream CiphertextBlob
        {
            get { return this._ciphertextBlob; }
            set { this._ciphertextBlob = value; }
        }

        // Check to see if CiphertextBlob property is set
        internal bool IsSetCiphertextBlob()
        {
            return this._ciphertextBlob != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// System generated unique identifier of the key to be used to decrypt the encrypted
        /// copy of the data key.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Plaintext. 
        /// <para>
        /// Plaintext that contains the data key. Use this for encryption and decryption and then
        /// remove it from memory as soon as possible. 
        /// </para>
        /// </summary>
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