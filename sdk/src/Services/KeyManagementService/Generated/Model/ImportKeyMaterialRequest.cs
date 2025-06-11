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
    /// Container for the parameters to the ImportKeyMaterial operation.
    /// Imports or reimports key material into an existing KMS key that was created without
    /// key material. You can also use this operation to set or update the expiration model
    /// and expiration date of the imported key material.
    /// 
    ///  
    /// <para>
    /// By default, KMS creates KMS keys with key material that it generates. You can also
    /// generate and import your own key material. For more information about importing key
    /// material, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
    /// key material</a>.
    /// </para>
    ///  
    /// <para>
    /// For asymmetric, HMAC and multi-Region keys, you cannot change the key material after
    /// the initial import. You can import multiple key materials into single-Region, symmetric
    /// encryption keys and rotate the key material on demand using <c>RotateKeyOnDemand</c>.
    /// </para>
    ///  
    /// <para>
    /// After you import key material, you can <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-import-key-material.html#reimport-key-material">reimport
    /// the same key material</a> into that KMS key or, if the key supports on-demand rotation,
    /// import new key material. You can use the <c>ImportType</c> parameter to indicate whether
    /// you are importing new key material or re-importing previously imported key material.
    /// You might reimport key material to replace key material that expired or key material
    /// that you deleted. You might also reimport key material to change the expiration model
    /// or expiration date of the key material.
    /// </para>
    ///  
    /// <para>
    /// Each time you import key material into KMS, you can determine whether (<c>ExpirationModel</c>)
    /// and when (<c>ValidTo</c>) the key material expires. To change the expiration of your
    /// key material, you must import it again, either by calling <c>ImportKeyMaterial</c>
    /// or using the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-import-key-material.html#importing-keys-import-key-material-console">import
    /// features</a> of the KMS console.
    /// </para>
    ///  
    /// <para>
    /// Before you call <c>ImportKeyMaterial</c>, complete these steps:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Create or identify a KMS key with <c>EXTERNAL</c> origin, which indicates that the
    /// KMS key is designed for imported key material. 
    /// </para>
    ///  
    /// <para>
    /// To create a new KMS key for imported key material, call the <a>CreateKey</a> operation
    /// with an <c>Origin</c> value of <c>EXTERNAL</c>. You can create a symmetric encryption
    /// KMS key, HMAC KMS key, asymmetric encryption KMS key, asymmetric key agreement key,
    /// or asymmetric signing KMS key. You can also import key material into a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">multi-Region
    /// key</a> of any supported type. However, you can't import key material into a KMS key
    /// in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
    /// key store</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call the <a>GetParametersForImport</a> operation to get a public key and import token
    /// set for importing key material. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the public key in the <a>GetParametersForImport</a> response to encrypt your key
    /// material.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  Then, in an <c>ImportKeyMaterial</c> request, you submit your encrypted key material
    /// and import token. When calling this operation, you must specify the following values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The key ID or key ARN of the KMS key to associate with the imported key material.
    /// Its <c>Origin</c> must be <c>EXTERNAL</c> and its <c>KeyState</c> must be <c>PendingImport</c>.
    /// You cannot perform this operation on a KMS key in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
    /// key store</a>, or on a KMS key in a different Amazon Web Services account. To get
    /// the <c>Origin</c> and <c>KeyState</c> of a KMS key, call <a>DescribeKey</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The encrypted key material. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The import token that <a>GetParametersForImport</a> returned. You must use a public
    /// key and token from the same <c>GetParametersForImport</c> response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Whether the key material expires (<c>ExpirationModel</c>) and, if so, when (<c>ValidTo</c>).
    /// For help with this choice, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-import-key-material.html#importing-keys-expiration">Setting
    /// an expiration time</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you set an expiration date, KMS deletes the key material from the KMS key on the
    /// specified date, making the KMS key unusable. To use the KMS key in cryptographic operations
    /// again, you must reimport the same key material. However, you can delete and reimport
    /// the key material at any time, including before the key material expires. Each time
    /// you reimport, you can eliminate or reset the expiration time.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When this operation is successful, the key state of the KMS key changes from <c>PendingImport</c>
    /// to <c>Enabled</c>, and you can use the KMS key in cryptographic operations. For single-Region,
    /// symmetric encryption keys, you will need to import all of the key materials associated
    /// with the KMS key to change its state to <c>Enabled</c>. Use the <c>ListKeyRotations</c>
    /// operation to list the ID and import state of each key material associated with a KMS
    /// key.
    /// </para>
    ///  
    /// <para>
    /// If this operation fails, use the exception to help determine the problem. If the error
    /// is related to the key material, the import token, or wrapping key, use <a>GetParametersForImport</a>
    /// to get a new public key and import token for the KMS key and repeat the import procedure.
    /// For help, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-conceptual.html">Create
    /// a KMS key with imported key material</a> in the <i>Key Management Service Developer
    /// Guide</i>.
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
    ///  </li> <li> 
    /// <para>
    ///  <a>ListKeyRotations</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RotateKeyOnDemand</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class ImportKeyMaterialRequest : AmazonKeyManagementServiceRequest
    {
        private MemoryStream _encryptedKeyMaterial;
        private ExpirationModelType _expirationModel;
        private MemoryStream _importToken;
        private ImportType _importType;
        private string _keyId;
        private string _keyMaterialDescription;
        private string _keyMaterialId;
        private DateTime? _validTo;

        /// <summary>
        /// Gets and sets the property EncryptedKeyMaterial. 
        /// <para>
        /// The encrypted key material to import. The key material must be encrypted under the
        /// public wrapping key that <a>GetParametersForImport</a> returned, using the wrapping
        /// algorithm that you specified in the same <c>GetParametersForImport</c> request.
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
        /// Specifies whether the key material expires. The default is <c>KEY_MATERIAL_EXPIRES</c>.
        /// For help with this choice, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-import-key-material.html#importing-keys-expiration">Setting
        /// an expiration time</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When the value of <c>ExpirationModel</c> is <c>KEY_MATERIAL_EXPIRES</c>, you must
        /// specify a value for the <c>ValidTo</c> parameter. When value is <c>KEY_MATERIAL_DOES_NOT_EXPIRE</c>,
        /// you must omit the <c>ValidTo</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// You cannot change the <c>ExpirationModel</c> or <c>ValidTo</c> values for the current
        /// import after the request completes. To change either value, you must reimport the
        /// key material.
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
        /// Gets and sets the property ImportType. 
        /// <para>
        /// Indicates whether the key material being imported is previously associated with this
        /// KMS key or not. This parameter is optional and only usable with symmetric encryption
        /// keys. The default is <c>EXISTING_KEY_MATERIAL</c>. If no key material has ever been
        /// imported into the KMS key, and this parameter is omitted, the parameter defaults to
        /// <c>NEW_KEY_MATERIAL</c>.
        /// </para>
        /// </summary>
        public ImportType ImportType
        {
            get { return this._importType; }
            set { this._importType = value; }
        }

        // Check to see if ImportType property is set
        internal bool IsSetImportType()
        {
            return this._importType != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The identifier of the KMS key that will be associated with the imported key material.
        /// This must be the same KMS key specified in the <c>KeyID</c> parameter of the corresponding
        /// <a>GetParametersForImport</a> request. The <c>Origin</c> of the KMS key must be <c>EXTERNAL</c>
        /// and its <c>KeyState</c> must be <c>PendingImport</c>. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key can be a symmetric encryption KMS key, HMAC KMS key, asymmetric encryption
        /// KMS key, or asymmetric signing KMS key, including a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">multi-Region
        /// key</a> of any supported type. You cannot perform this operation on a KMS key in a
        /// custom key store, or on a KMS key in a different Amazon Web Services account.
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
        /// Gets and sets the property KeyMaterialDescription. 
        /// <para>
        /// Description for the key material being imported. This parameter is optional and only
        /// usable with symmetric encryption keys. If you do not specify a key material description,
        /// KMS retains the value you specified when you last imported the same key material into
        /// this KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string KeyMaterialDescription
        {
            get { return this._keyMaterialDescription; }
            set { this._keyMaterialDescription = value; }
        }

        // Check to see if KeyMaterialDescription property is set
        internal bool IsSetKeyMaterialDescription()
        {
            return this._keyMaterialDescription != null;
        }

        /// <summary>
        /// Gets and sets the property KeyMaterialId. 
        /// <para>
        /// Identifies the key material being imported. This parameter is optional and only usable
        /// with symmetric encryption keys. You cannot specify a key material ID with <c>ImportType</c>
        /// set to <c>NEW_KEY_MATERIAL</c>. Whenever you import key material into a symmetric
        /// encryption key, KMS assigns a unique identifier to the key material based on the KMS
        /// key ID and the imported key material. When you re-import key material with a specified
        /// key material ID, KMS:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Computes the identifier for the key material
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Matches the computed identifier against the specified key material ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Verifies that the key material ID is already associated with the KMS key
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the list of key material IDs associated with a KMS key, use <a>ListKeyRotations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=64, Max=64)]
        public string KeyMaterialId
        {
            get { return this._keyMaterialId; }
            set { this._keyMaterialId = value; }
        }

        // Check to see if KeyMaterialId property is set
        internal bool IsSetKeyMaterialId()
        {
            return this._keyMaterialId != null;
        }

        /// <summary>
        /// Gets and sets the property ValidTo. 
        /// <para>
        /// The date and time when the imported key material expires. This parameter is required
        /// when the value of the <c>ExpirationModel</c> parameter is <c>KEY_MATERIAL_EXPIRES</c>.
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
        /// You cannot change the <c>ExpirationModel</c> or <c>ValidTo</c> values for the current
        /// import after the request completes. To change either value, you must delete (<a>DeleteImportedKeyMaterial</a>)
        /// and reimport the key material.
        /// </para>
        /// </summary>
        public DateTime? ValidTo
        {
            get { return this._validTo; }
            set { this._validTo = value; }
        }

        // Check to see if ValidTo property is set
        internal bool IsSetValidTo()
        {
            return this._validTo.HasValue; 
        }

    }
}