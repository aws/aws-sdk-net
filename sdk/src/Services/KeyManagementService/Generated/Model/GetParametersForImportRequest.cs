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
    /// Container for the parameters to the GetParametersForImport operation.
    /// Returns the items you need in order to import key material into AWS KMS from your
    /// existing key management infrastructure. For more information about importing key material
    /// into AWS KMS, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
    /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// You must specify the key ID of the customer master key (CMK) into which you will import
    /// key material. This CMK's <code>Origin</code> must be <code>EXTERNAL</code>. You must
    /// also specify the wrapping algorithm and type of wrapping key (public key) that you
    /// will use to encrypt the key material.
    /// </para>
    ///  
    /// <para>
    /// This operation returns a public key and an import token. Use the public key to encrypt
    /// the key material. Store the import token to send with a subsequent <a>ImportKeyMaterial</a>
    /// request. The public key and import token from the same response must be used together.
    /// These items are valid for 24 hours, after which they cannot be used for a subsequent
    /// <a>ImportKeyMaterial</a> request. To retrieve new ones, send another <code>GetParametersForImport</code>
    /// request.
    /// </para>
    /// </summary>
    public partial class GetParametersForImportRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;
        private AlgorithmSpec _wrappingAlgorithm;
        private WrappingKeySpec _wrappingKeySpec;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The identifier of the CMK into which you will import key material. The CMK's <code>Origin</code>
        /// must be <code>EXTERNAL</code>.
        /// </para>
        ///  
        /// <para>
        /// A valid identifier is the unique key ID or the Amazon Resource Name (ARN) of the CMK.
        /// Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Unique key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property WrappingAlgorithm. 
        /// <para>
        /// The algorithm you will use to encrypt the key material before importing it with <a>ImportKeyMaterial</a>.
        /// For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-encrypt-key-material.html">Encrypt
        /// the Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public AlgorithmSpec WrappingAlgorithm
        {
            get { return this._wrappingAlgorithm; }
            set { this._wrappingAlgorithm = value; }
        }

        // Check to see if WrappingAlgorithm property is set
        internal bool IsSetWrappingAlgorithm()
        {
            return this._wrappingAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property WrappingKeySpec. 
        /// <para>
        /// The type of wrapping key (public key) to return in the response. Only 2048-bit RSA
        /// public keys are supported.
        /// </para>
        /// </summary>
        public WrappingKeySpec WrappingKeySpec
        {
            get { return this._wrappingKeySpec; }
            set { this._wrappingKeySpec = value; }
        }

        // Check to see if WrappingKeySpec property is set
        internal bool IsSetWrappingKeySpec()
        {
            return this._wrappingKeySpec != null;
        }

    }
}