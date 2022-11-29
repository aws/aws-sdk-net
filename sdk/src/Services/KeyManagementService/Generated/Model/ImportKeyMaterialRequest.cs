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
    /// Container for the parameters to the ImportKeyMaterial operation.
    /// Imports key material into an existing symmetric encryption KMS key that was created
    /// without key material. After you successfully import key material into a KMS key, you
    /// can <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html#reimport-key-material">reimport
    /// the same key material</a> into that KMS key, but you cannot import different key material.
    /// 
    /// 
    ///  
    /// <para>
    /// You cannot perform this operation on an asymmetric KMS key, an HMAC KMS key, or on
    /// any KMS key in a different Amazon Web Services account. For more information about
    /// creating KMS keys with no key material and then importing key material, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
    /// Key Material</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Before using this operation, call <a>GetParametersForImport</a>. Its response includes
    /// a public key and an import token. Use the public key to encrypt the key material.
    /// Then, submit the import token from the same <code>GetParametersForImport</code> response.
    /// </para>
    ///  
    /// <para>
    /// When calling this operation, you must specify the following values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The key ID or key ARN of a KMS key with no key material. Its <code>Origin</code> must
    /// be <code>EXTERNAL</code>.
    /// </para>
    ///  
    /// <para>
    /// To create a KMS key with no key material, call <a>CreateKey</a> and set the value
    /// of its <code>Origin</code> parameter to <code>EXTERNAL</code>. To get the <code>Origin</code>
    /// of a KMS key, call <a>DescribeKey</a>.)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The encrypted key material. To get the public key to encrypt the key material, call
    /// <a>GetParametersForImport</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The import token that <a>GetParametersForImport</a> returned. You must use a public
    /// key and token from the same <code>GetParametersForImport</code> response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Whether the key material expires (<code>ExpirationModel</code>) and, if so, when (<code>ValidTo</code>).
    /// If you set an expiration date, on the specified date, KMS deletes the key material
    /// from the KMS key, making the KMS key unusable. To use the KMS key in cryptographic
    /// operations again, you must reimport the same key material. The only way to change
    /// the expiration model or expiration date is by reimporting the same key material and
    /// specifying a new expiration date. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When this operation is successful, the key state of the KMS key changes from <code>PendingImport</code>
    /// to <code>Enabled</code>, and you can use the KMS key.
    /// </para>
    ///  
    /// <para>
    /// If this operation fails, use the exception to help determine the problem. If the error
    /// is related to the key material, the import token, or wrapping key, use <a>GetParametersForImport</a>
    /// to get a new public key and import token for the KMS key and repeat the import procedure.
    /// For help, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html#importing-keys-overview">How
    /// To Import Key Material</a> in the <i>Key Management Service Developer Guide</i>.
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
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ImportKeyMaterial</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteImportedKeyMaterial</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetParametersForImport</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ImportKeyMaterialRequest : AmazonKeyManagementServiceRequest
    {
        private MemoryStream _encryptedKeyMaterial;
        private ExpirationModelType _expirationModel;
        private MemoryStream _importToken;
        private string _keyId;
        private DateTime? _validTo;

        /// <summary>
        /// Gets and sets the property EncryptedKeyMaterial. 
        /// <para>
        /// The encrypted key material to import. The key material must be encrypted with the
        /// public wrapping key that <a>GetParametersForImport</a> returned, using the wrapping
        /// algorithm that you specified in the same <code>GetParametersForImport</code> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6144)]
        public MemoryStream EncryptedKeyMaterial
        {
            get { return this._encryptedKeyMaterial; }
            set { this._encryptedKeyMaterial = value; }
        }

        // Check to see if EncryptedKeyMaterial property is set
        internal bool IsSetEncryptedKeyMaterial()
        {
            return this._encryptedKeyMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationModel. 
        /// <para>
        /// Specifies whether the key material expires. The default is <code>KEY_MATERIAL_EXPIRES</code>.
        /// </para>
        ///  
        /// <para>
        /// When the value of <code>ExpirationModel</code> is <code>KEY_MATERIAL_EXPIRES</code>,
        /// you must specify a value for the <code>ValidTo</code> parameter. When value is <code>KEY_MATERIAL_DOES_NOT_EXPIRE</code>,
        /// you must omit the <code>ValidTo</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// You cannot change the <code>ExpirationModel</code> or <code>ValidTo</code> values
        /// for the current import after the request completes. To change either value, you must
        /// delete (<a>DeleteImportedKeyMaterial</a>) and reimport the key material.
        /// </para>
        /// </summary>
        public ExpirationModelType ExpirationModel
        {
            get { return this._expirationModel; }
            set { this._expirationModel = value; }
        }

        // Check to see if ExpirationModel property is set
        internal bool IsSetExpirationModel()
        {
            return this._expirationModel != null;
        }

        /// <summary>
        /// Gets and sets the property ImportToken. 
        /// <para>
        /// The import token that you received in the response to a previous <a>GetParametersForImport</a>
        /// request. It must be from the same response that contained the public key that you
        /// used to encrypt the key material.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6144)]
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
        /// The identifier of the symmetric encryption KMS key that receives the imported key
        /// material. This must be the same KMS key specified in the <code>KeyID</code> parameter
        /// of the corresponding <a>GetParametersForImport</a> request. The <code>Origin</code>
        /// of the KMS key must be <code>EXTERNAL</code>. You cannot perform this operation on
        /// an asymmetric KMS key, an HMAC KMS key, a KMS key in a custom key store, or on a KMS
        /// key in a different Amazon Web Services account
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
        /// Gets and sets the property ValidTo. 
        /// <para>
        /// The date and time when the imported key material expires. This parameter is required
        /// when the value of the <code>ExpirationModel</code> parameter is <code>KEY_MATERIAL_EXPIRES</code>.
        /// Otherwise it is not valid.
        /// </para>
        ///  
        /// <para>
        /// The value of this parameter must be a future date and time. The maximum value is 365
        /// days from the request date.
        /// </para>
        ///  
        /// <para>
        /// When the key material expires, KMS deletes the key material from the KMS key. Without
        /// its key material, the KMS key is unusable. To use the KMS key in cryptographic operations,
        /// you must reimport the same key material.
        /// </para>
        ///  
        /// <para>
        /// You cannot change the <code>ExpirationModel</code> or <code>ValidTo</code> values
        /// for the current import after the request completes. To change either value, you must
        /// delete (<a>DeleteImportedKeyMaterial</a>) and reimport the key material.
        /// </para>
        /// </summary>
        public DateTime ValidTo
        {
            get { return this._validTo.GetValueOrDefault(); }
            set { this._validTo = value; }
        }

        // Check to see if ValidTo property is set
        internal bool IsSetValidTo()
        {
            return this._validTo.HasValue; 
        }

    }
}