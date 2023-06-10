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
    /// This is the response object from the GetParametersForImport operation.
    /// </summary>
    public partial class GetParametersForImportResponse : AmazonWebServiceResponse
    {
        private MemoryStream _importToken;
        private string _keyId;
        private DateTime? _parametersValidTo;
        private MemoryStream _publicKey;

        /// <summary>
        /// Gets and sets the property ImportToken. 
        /// <para>
        /// The import token to send in a subsequent <a>ImportKeyMaterial</a> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
        public MemoryStream ImportToken
        {
            get { return this._importToken; }
            set { this._importToken = value; }
        }

        // Check to see if ImportToken property is set
        internal bool IsSetImportToken()
        {
            return this._importToken != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">key
        /// ARN</a>) of the KMS key to use in a subsequent <a>ImportKeyMaterial</a> request. This
        /// is the same KMS key specified in the <code>GetParametersForImport</code> request.
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
        /// Gets and sets the property ParametersValidTo. 
        /// <para>
        /// The time at which the import token and public key are no longer valid. After this
        /// time, you cannot use them to make an <a>ImportKeyMaterial</a> request and you must
        /// send another <code>GetParametersForImport</code> request to get new ones.
        /// </para>
        /// </summary>
        public DateTime ParametersValidTo
        {
            get { return this._parametersValidTo.GetValueOrDefault(); }
            set { this._parametersValidTo = value; }
        }

        // Check to see if ParametersValidTo property is set
        internal bool IsSetParametersValidTo()
        {
            return this._parametersValidTo.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public key to use to encrypt the key material before importing it with <a>ImportKeyMaterial</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public MemoryStream PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
        }

    }
}