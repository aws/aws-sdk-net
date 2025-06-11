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
    /// Container for the parameters to the GetParametersForImport operation.
    /// Returns the public key and an import token you need to import or reimport key material
    /// for a KMS key. 
    /// 
    ///  
    /// <para>
    /// By default, KMS keys are created with key material that KMS generates. This operation
    /// supports <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
    /// key material</a>, an advanced feature that lets you generate and import the cryptographic
    /// key material for a KMS key.
    /// </para>
    ///  
    /// <para>
    /// Before calling <c>GetParametersForImport</c>, use the <a>CreateKey</a> operation with
    /// an <c>Origin</c> value of <c>EXTERNAL</c> to create a KMS key with no key material.
    /// You can import key material for a symmetric encryption KMS key, HMAC KMS key, asymmetric
    /// encryption KMS key, or asymmetric signing KMS key. You can also import key material
    /// into a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">multi-Region
    /// key</a> of any supported type. However, you can't import key material into a KMS key
    /// in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
    /// key store</a>. You can also use <c>GetParametersForImport</c> to get a public key
    /// and import token to <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-import-key-material.html#reimport-key-material">reimport
    /// the original key material</a> into a KMS key whose key material expired or was deleted.
    /// </para>
    ///  
    /// <para>
    ///  <c>GetParametersForImport</c> returns the items that you need to import your key
    /// material.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The public key (or "wrapping key") of an RSA key pair that KMS generates.
    /// </para>
    ///  
    /// <para>
    /// You will use this public key to encrypt ("wrap") your key material while it's in transit
    /// to KMS. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A import token that ensures that KMS can decrypt your key material and associate it
    /// with the correct KMS key.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The public key and its import token are permanently linked and must be used together.
    /// Each public key and import token set is valid for 24 hours. The expiration date and
    /// time appear in the <c>ParametersValidTo</c> field in the <c>GetParametersForImport</c>
    /// response. You cannot use an expired public key or import token in an <a>ImportKeyMaterial</a>
    /// request. If your key and token expire, send another <c>GetParametersForImport</c>
    /// request.
    /// </para>
    ///  
    /// <para>
    ///  <c>GetParametersForImport</c> requires the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The key ID of the KMS key for which you are importing the key material.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The key spec of the public key ("wrapping key") that you will use to encrypt your
    /// key material during import.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The wrapping algorithm that you will use with the public key to encrypt your key material.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use the same or a different public key spec and wrapping algorithm each time
    /// you import or reimport the same key material. 
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
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
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
        /// The identifier of the KMS key that will be associated with the imported key material.
        /// The <c>Origin</c> of the KMS key must be <c>EXTERNAL</c>.
        /// </para>
        ///  
        /// <para>
        /// All KMS key types are supported, including multi-Region keys. However, you cannot
        /// import key material into a KMS key in a custom key store.
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
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
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
        /// The algorithm you will use with the RSA public key (<c>PublicKey</c>) in the response
        /// to protect your key material during import. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-get-public-key-and-token.html#select-wrapping-algorithm">Select
        /// a wrapping algorithm</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For RSA_AES wrapping algorithms, you encrypt your key material with an AES key that
        /// you generate, then encrypt your AES key with the RSA public key from KMS. For RSAES
        /// wrapping algorithms, you encrypt your key material directly with the RSA public key
        /// from KMS.
        /// </para>
        ///  
        /// <para>
        /// The wrapping algorithms that you can use depend on the type of key material that you
        /// are importing. To import an RSA private key, you must use an RSA_AES wrapping algorithm.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>RSA_AES_KEY_WRAP_SHA_256</b> — Supported for wrapping RSA and ECC key material.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>RSA_AES_KEY_WRAP_SHA_1</b> — Supported for wrapping RSA and ECC key material.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>RSAES_OAEP_SHA_256</b> — Supported for all types of key material, except RSA key
        /// material (private key).
        /// </para>
        ///  
        /// <para>
        /// You cannot use the RSAES_OAEP_SHA_256 wrapping algorithm with the RSA_2048 wrapping
        /// key spec to wrap ECC_NIST_P521 key material.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>RSAES_OAEP_SHA_1</b> — Supported for all types of key material, except RSA key
        /// material (private key).
        /// </para>
        ///  
        /// <para>
        /// You cannot use the RSAES_OAEP_SHA_1 wrapping algorithm with the RSA_2048 wrapping
        /// key spec to wrap ECC_NIST_P521 key material.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>RSAES_PKCS1_V1_5</b> (Deprecated) — As of October 10, 2023, KMS does not support
        /// the RSAES_PKCS1_V1_5 wrapping algorithm.
        /// </para>
        ///  </li> </ul>
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
        /// The type of RSA public key to return in the response. You will use this wrapping key
        /// with the specified wrapping algorithm to protect your key material during import.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Use the longest RSA wrapping key that is practical. 
        /// </para>
        ///  
        /// <para>
        /// You cannot use an RSA_2048 public key to directly wrap an ECC_NIST_P521 private key.
        /// Instead, use an RSA_AES wrapping algorithm or choose a longer RSA public key.
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