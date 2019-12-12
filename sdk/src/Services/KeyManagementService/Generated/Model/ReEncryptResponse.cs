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
    /// This is the response object from the ReEncrypt operation.
    /// </summary>
    public partial class ReEncryptResponse : AmazonWebServiceResponse
    {
        private MemoryStream _ciphertextBlob;
        private EncryptionAlgorithmSpec _destinationEncryptionAlgorithm;
        private string _keyId;
        private EncryptionAlgorithmSpec _sourceEncryptionAlgorithm;
        private string _sourceKeyId;

        /// <summary>
        /// Gets and sets the property CiphertextBlob. 
        /// <para>
        /// The reencrypted data. When you use the HTTP API or the AWS CLI, the value is Base64-encoded.
        /// Otherwise, it is not Base64-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
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
        /// Gets and sets the property DestinationEncryptionAlgorithm. 
        /// <para>
        /// The encryption algorithm that was used to reencrypt the data.
        /// </para>
        /// </summary>
        public EncryptionAlgorithmSpec DestinationEncryptionAlgorithm
        {
            get { return this._destinationEncryptionAlgorithm; }
            set { this._destinationEncryptionAlgorithm = value; }
        }

        // Check to see if DestinationEncryptionAlgorithm property is set
        internal bool IsSetDestinationEncryptionAlgorithm()
        {
            return this._destinationEncryptionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Unique identifier of the CMK used to reencrypt the data.
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
        /// Gets and sets the property SourceEncryptionAlgorithm. 
        /// <para>
        /// The encryption algorithm that was used to decrypt the ciphertext before it was reencrypted.
        /// </para>
        /// </summary>
        public EncryptionAlgorithmSpec SourceEncryptionAlgorithm
        {
            get { return this._sourceEncryptionAlgorithm; }
            set { this._sourceEncryptionAlgorithm = value; }
        }

        // Check to see if SourceEncryptionAlgorithm property is set
        internal bool IsSetSourceEncryptionAlgorithm()
        {
            return this._sourceEncryptionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property SourceKeyId. 
        /// <para>
        /// Unique identifier of the CMK used to originally encrypt the data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SourceKeyId
        {
            get { return this._sourceKeyId; }
            set { this._sourceKeyId = value; }
        }

        // Check to see if SourceKeyId property is set
        internal bool IsSetSourceKeyId()
        {
            return this._sourceKeyId != null;
        }

    }
}