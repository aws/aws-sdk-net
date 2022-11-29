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
    /// Container for the parameters to the GetParametersForImport operation.
    /// Returns the items you need to import key material into a symmetric encryption KMS
    /// key. For more information about importing key material into KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
    /// key material</a> in the <i>Key Management Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// This operation returns a public key and an import token. Use the public key to encrypt
    /// the symmetric key material. Store the import token to send with a subsequent <a>ImportKeyMaterial</a>
    /// request.
    /// </para>
    ///  
    /// <para>
    /// You must specify the key ID of the symmetric encryption KMS key into which you will
    /// import key material. The KMS key <code>Origin</code> must be <code>EXTERNAL</code>.
    /// You must also specify the wrapping algorithm and type of wrapping key (public key)
    /// that you will use to encrypt the key material. You cannot perform this operation on
    /// an asymmetric KMS key, an HMAC KMS key, or on any KMS key in a different Amazon Web
    /// Services account.
    /// </para>
    ///  
    /// <para>
    /// To import key material, you must use the public key and import token from the same
    /// response. These items are valid for 24 hours. The expiration date and time appear
    /// in the <code>GetParametersForImport</code> response. You cannot use an expired token
    /// in an <a>ImportKeyMaterial</a> request. If your key and token expire, send another
    /// <code>GetParametersForImport</code> request.
    /// </para>
    ///  
    /// <para>
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
    /// different Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetParametersForImport</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ImportKeyMaterial</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteImportedKeyMaterial</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetParametersForImportRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;
        private AlgorithmSpec _wrappingAlgorithm;
        private WrappingKeySpec _wrappingKeySpec;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The identifier of the symmetric encryption KMS key into which you will import key
        /// material. The <code>Origin</code> of the KMS key must be <code>EXTERNAL</code>.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or key ARN of the KMS key.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-encrypt-key-material.html">Encrypt
        /// the Key Material</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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