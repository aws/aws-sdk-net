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
    /// Container for the parameters to the ImportKeyMaterial operation.
    /// Imports key material into an existing AWS KMS customer master key (CMK) that was created
    /// without key material. You cannot perform this operation on a CMK in a different AWS
    /// account. For more information about creating CMKs with no key material and then importing
    /// key material, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
    /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// 
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
    /// The key ID or key ARN of a CMK with no key material. Its <code>Origin</code> must
    /// be <code>EXTERNAL</code>.
    /// </para>
    ///  
    /// <para>
    /// To create a CMK with no key material, call <a>CreateKey</a> and set the value of its
    /// <code>Origin</code> parameter to <code>EXTERNAL</code>. To get the <code>Origin</code>
    /// of a CMK, call <a>DescribeKey</a>.)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The encrypted key material. To get the public key to encrypt the key material, call
    /// <a>GetParametersForImport</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The import token that <a>GetParametersForImport</a> returned. This token and the public
    /// key used to encrypt the key material must have come from the same response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Whether the key material expires and if so, when. If you set an expiration date, you
    /// can change it only by reimporting the same key material and specifying a new expiration
    /// date. If the key material expires, AWS KMS deletes the key material and the CMK becomes
    /// unusable. To use the CMK again, you must reimport the same key material.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When this operation is successful, the CMK's key state changes from <code>PendingImport</code>
    /// to <code>Enabled</code>, and you can use the CMK. After you successfully import key
    /// material into a CMK, you can reimport the same key material into that CMK, but you
    /// cannot import different key material.
    /// </para>
    ///  
    /// <para>
    /// The result of this operation varies with the key state of the CMK. For details, see
    /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
    /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
    /// Developer Guide</i>.
    /// </para>
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
        /// The encrypted key material to import. It must be encrypted with the public key that
        /// you received in the response to a previous <a>GetParametersForImport</a> request,
        /// using the wrapping algorithm that you specified in that request.
        /// </para>
        /// </summary>
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
        /// Specifies whether the key material expires. The default is <code>KEY_MATERIAL_EXPIRES</code>,
        /// in which case you must include the <code>ValidTo</code> parameter. When this parameter
        /// is set to <code>KEY_MATERIAL_DOES_NOT_EXPIRE</code>, you must omit the <code>ValidTo</code>
        /// parameter.
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
        /// The identifier of the CMK to import the key material into. The CMK's <code>Origin</code>
        /// must be <code>EXTERNAL</code>.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or the Amazon Resource Name (ARN) of the CMK.
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
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
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
        /// Gets and sets the property ValidTo. 
        /// <para>
        /// The time at which the imported key material expires. When the key material expires,
        /// AWS KMS deletes the key material and the CMK becomes unusable. You must omit this
        /// parameter when the <code>ExpirationModel</code> parameter is set to <code>KEY_MATERIAL_DOES_NOT_EXPIRE</code>.
        /// Otherwise it is required.
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