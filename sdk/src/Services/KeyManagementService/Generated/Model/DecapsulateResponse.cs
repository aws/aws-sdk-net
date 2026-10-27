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
    /// This is the response object from the Decapsulate operation.
    /// </summary>
    public partial class DecapsulateResponse : AmazonWebServiceResponse
    {
        private EncapsulationAlgorithmSpec _encapsulationAlgorithm;
        private string _keyId;
        private MemoryStream _sharedSecret;

        /// <summary>
        /// Gets and sets the property EncapsulationAlgorithm. 
        /// <para>
        /// The key encapsulation algorithm used to recover the shared secret.
        /// </para>
        /// </summary>
        public EncapsulationAlgorithmSpec EncapsulationAlgorithm
        {
            get { return this._encapsulationAlgorithm; }
            set { this._encapsulationAlgorithm = value; }
        }

        // Check to see if EncapsulationAlgorithm property is set
        internal bool IsSetEncapsulationAlgorithm()
        {
            return this._encapsulationAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The identifier of the ML-KEM KMS key used to decapsulate the shared secret.
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
        /// Gets and sets the property SharedSecret. 
        /// <para>
        /// The plaintext shared secret recovered from the encapsulated form. It is a 32-byte
        /// value that matches the shared secret held by the encapsulating party. When you use
        /// the HTTP API or the Amazon Web Services CLI, the value is Base64-encoded. Otherwise,
        /// it is not Base64-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public MemoryStream SharedSecret
        {
            get { return this._sharedSecret; }
            set { this._sharedSecret = value; }
        }

        // Check to see if SharedSecret property is set
        internal bool IsSetSharedSecret()
        {
            return this._sharedSecret != null;
        }

    }
}