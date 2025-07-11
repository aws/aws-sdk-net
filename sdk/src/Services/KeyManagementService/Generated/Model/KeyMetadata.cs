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
    /// Contains metadata about a KMS key.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element for the <a>CreateKey</a>, <a>DescribeKey</a>,
    /// and <a>ReplicateKey</a> operations.
    /// </para>
    /// </summary>
    public partial class KeyMetadata
    {
        private string _arn;
        private string _awsAccountId;
        private string _cloudHsmClusterId;
        private DateTime? _creationDate;
        private string _currentKeyMaterialId;
        private CustomerMasterKeySpec _customerMasterKeySpec;
        private string _customKeyStoreId;
        private DateTime? _deletionDate;
        private string _description;
        private bool? _enabled;
        private List<string> _encryptionAlgorithms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ExpirationModelType _expirationModel;
        private List<string> _keyAgreementAlgorithms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _keyId;
        private KeyManagerType _keyManager;
        private KeySpec _keySpec;
        private KeyState _keyState;
        private KeyUsageType _keyUsage;
        private List<string> _macAlgorithms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _multiRegion;
        private MultiRegionConfiguration _multiRegionConfiguration;
        private OriginType _origin;
        private int? _pendingDeletionWindowInDays;
        private List<string> _signingAlgorithms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _validTo;
        private XksKeyConfigurationType _xksKeyConfiguration;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key. For examples, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kms">Key
        /// Management Service (KMS)</a> in the Example ARNs section of the <i>Amazon Web Services
        /// General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AWSAccountId. 
        /// <para>
        /// The twelve-digit account ID of the Amazon Web Services account that owns the KMS key.
        /// </para>
        /// </summary>
        public string AWSAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AWSAccountId property is set
        internal bool IsSetAWSAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudHsmClusterId. 
        /// <para>
        /// The cluster ID of the CloudHSM cluster that contains the key material for the KMS
        /// key. When you create a KMS key in an CloudHSM <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, KMS creates the key material for the KMS key in the associated CloudHSM
        /// cluster. This field is present only when the KMS key is created in an CloudHSM key
        /// store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=24)]
        public string CloudHsmClusterId
        {
            get { return this._cloudHsmClusterId; }
            set { this._cloudHsmClusterId = value; }
        }

        // Check to see if CloudHsmClusterId property is set
        internal bool IsSetCloudHsmClusterId()
        {
            return this._cloudHsmClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the KMS key was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentKeyMaterialId. 
        /// <para>
        /// Identifies the current key material. This value is present for symmetric encryption
        /// keys with <c>AWS_KMS</c> origin and single-Region, symmetric encryption keys with
        /// <c>EXTERNAL</c> origin. These KMS keys support automatic or on-demand key rotation
        /// and can have multiple key materials associated with them. KMS uses the current key
        /// material for both encryption and decryption, and the non-current key material for
        /// decryption operations only.
        /// </para>
        /// </summary>
        [AWSProperty(Min=64, Max=64)]
        public string CurrentKeyMaterialId
        {
            get { return this._currentKeyMaterialId; }
            set { this._currentKeyMaterialId = value; }
        }

        // Check to see if CurrentKeyMaterialId property is set
        internal bool IsSetCurrentKeyMaterialId()
        {
            return this._currentKeyMaterialId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerMasterKeySpec. 
        /// <para>
        /// Instead, use the <c>KeySpec</c> field.
        /// </para>
        ///  
        /// <para>
        /// The <c>KeySpec</c> and <c>CustomerMasterKeySpec</c> fields have the same value. We
        /// recommend that you use the <c>KeySpec</c> field in your code. However, to avoid breaking
        /// changes, KMS supports both fields.
        /// </para>
        /// </summary>
        [Obsolete("This field has been deprecated. Instead, use the KeySpec field.")]
        public CustomerMasterKeySpec CustomerMasterKeySpec
        {
            get { return this._customerMasterKeySpec; }
            set { this._customerMasterKeySpec = value; }
        }

        // Check to see if CustomerMasterKeySpec property is set
        internal bool IsSetCustomerMasterKeySpec()
        {
            return this._customerMasterKeySpec != null;
        }

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// A unique identifier for the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a> that contains the KMS key. This field is present only when the KMS key
        /// is created in a custom key store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CustomKeyStoreId
        {
            get { return this._customKeyStoreId; }
            set { this._customKeyStoreId = value; }
        }

        // Check to see if CustomKeyStoreId property is set
        internal bool IsSetCustomKeyStoreId()
        {
            return this._customKeyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionDate. 
        /// <para>
        /// The date and time after which KMS deletes this KMS key. This value is present only
        /// when the KMS key is scheduled for deletion, that is, when its <c>KeyState</c> is <c>PendingDeletion</c>.
        /// </para>
        ///  
        /// <para>
        /// When the primary key in a multi-Region key is scheduled for deletion but still has
        /// replica keys, its key state is <c>PendingReplicaDeletion</c> and the length of its
        /// waiting period is displayed in the <c>PendingDeletionWindowInDays</c> field.
        /// </para>
        /// </summary>
        public DateTime? DeletionDate
        {
            get { return this._deletionDate; }
            set { this._deletionDate = value; }
        }

        // Check to see if DeletionDate property is set
        internal bool IsSetDeletionDate()
        {
            return this._deletionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the KMS key is enabled. When <c>KeyState</c> is <c>Enabled</c> this
        /// value is true, otherwise it is false.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionAlgorithms. 
        /// <para>
        /// The encryption algorithms that the KMS key supports. You cannot use the KMS key with
        /// other encryption algorithms within KMS.
        /// </para>
        ///  
        /// <para>
        /// This value is present only when the <c>KeyUsage</c> of the KMS key is <c>ENCRYPT_DECRYPT</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EncryptionAlgorithms
        {
            get { return this._encryptionAlgorithms; }
            set { this._encryptionAlgorithms = value; }
        }

        // Check to see if EncryptionAlgorithms property is set
        internal bool IsSetEncryptionAlgorithms()
        {
            return this._encryptionAlgorithms != null && (this._encryptionAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpirationModel. 
        /// <para>
        /// Specifies whether the KMS key's key material expires. This value is present only when
        /// <c>Origin</c> is <c>EXTERNAL</c>, otherwise this value is omitted.
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
        /// Gets and sets the property KeyAgreementAlgorithms. 
        /// <para>
        /// The key agreement algorithm used to derive a shared secret.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeyAgreementAlgorithms
        {
            get { return this._keyAgreementAlgorithms; }
            set { this._keyAgreementAlgorithms = value; }
        }

        // Check to see if KeyAgreementAlgorithms property is set
        internal bool IsSetKeyAgreementAlgorithms()
        {
            return this._keyAgreementAlgorithms != null && (this._keyAgreementAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The globally unique identifier for the KMS key.
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
        /// Gets and sets the property KeyManager. 
        /// <para>
        /// The manager of the KMS key. KMS keys in your Amazon Web Services account are either
        /// customer managed or Amazon Web Services managed. For more information about the difference,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#kms_keys">KMS
        /// keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public KeyManagerType KeyManager
        {
            get { return this._keyManager; }
            set { this._keyManager = value; }
        }

        // Check to see if KeyManager property is set
        internal bool IsSetKeyManager()
        {
            return this._keyManager != null;
        }

        /// <summary>
        /// Gets and sets the property KeySpec. 
        /// <para>
        /// Describes the type of key material in the KMS key.
        /// </para>
        /// </summary>
        public KeySpec KeySpec
        {
            get { return this._keySpec; }
            set { this._keySpec = value; }
        }

        // Check to see if KeySpec property is set
        internal bool IsSetKeySpec()
        {
            return this._keySpec != null;
        }

        /// <summary>
        /// Gets and sets the property KeyState. 
        /// <para>
        /// The current status of the KMS key.
        /// </para>
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public KeyState KeyState
        {
            get { return this._keyState; }
            set { this._keyState = value; }
        }

        // Check to see if KeyState property is set
        internal bool IsSetKeyState()
        {
            return this._keyState != null;
        }

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
        /// operations</a> for which you can use the KMS key.
        /// </para>
        /// </summary>
        public KeyUsageType KeyUsage
        {
            get { return this._keyUsage; }
            set { this._keyUsage = value; }
        }

        // Check to see if KeyUsage property is set
        internal bool IsSetKeyUsage()
        {
            return this._keyUsage != null;
        }

        /// <summary>
        /// Gets and sets the property MacAlgorithms. 
        /// <para>
        /// The message authentication code (MAC) algorithm that the HMAC KMS key supports.
        /// </para>
        ///  
        /// <para>
        /// This value is present only when the <c>KeyUsage</c> of the KMS key is <c>GENERATE_VERIFY_MAC</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MacAlgorithms
        {
            get { return this._macAlgorithms; }
            set { this._macAlgorithms = value; }
        }

        // Check to see if MacAlgorithms property is set
        internal bool IsSetMacAlgorithms()
        {
            return this._macAlgorithms != null && (this._macAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MultiRegion. 
        /// <para>
        /// Indicates whether the KMS key is a multi-Region (<c>True</c>) or regional (<c>False</c>)
        /// key. This value is <c>True</c> for multi-Region primary and replica keys and <c>False</c>
        /// for regional KMS keys.
        /// </para>
        ///  
        /// <para>
        /// For more information about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Multi-Region
        /// keys in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? MultiRegion
        {
            get { return this._multiRegion; }
            set { this._multiRegion = value; }
        }

        // Check to see if MultiRegion property is set
        internal bool IsSetMultiRegion()
        {
            return this._multiRegion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiRegionConfiguration. 
        /// <para>
        /// Lists the primary and replica keys in same multi-Region key. This field is present
        /// only when the value of the <c>MultiRegion</c> field is <c>True</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about any listed KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MultiRegionKeyType</c> indicates whether the KMS key is a <c>PRIMARY</c> or <c>REPLICA</c>
        /// key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PrimaryKey</c> displays the key ARN and Region of the primary key. This field
        /// displays the current KMS key if it is the primary key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReplicaKeys</c> displays the key ARNs and Regions of all replica keys. This field
        /// includes the current KMS key if it is a replica key.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MultiRegionConfiguration MultiRegionConfiguration
        {
            get { return this._multiRegionConfiguration; }
            set { this._multiRegionConfiguration = value; }
        }

        // Check to see if MultiRegionConfiguration property is set
        internal bool IsSetMultiRegionConfiguration()
        {
            return this._multiRegionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// The source of the key material for the KMS key. When this value is <c>AWS_KMS</c>,
        /// KMS created the key material. When this value is <c>EXTERNAL</c>, the key material
        /// was imported or the KMS key doesn't have any key material. When this value is <c>AWS_CLOUDHSM</c>,
        /// the key material was created in the CloudHSM cluster associated with a custom key
        /// store.
        /// </para>
        /// </summary>
        public OriginType Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property PendingDeletionWindowInDays. 
        /// <para>
        /// The waiting period before the primary key in a multi-Region key is deleted. This waiting
        /// period begins when the last of its replica keys is deleted. This value is present
        /// only when the <c>KeyState</c> of the KMS key is <c>PendingReplicaDeletion</c>. That
        /// indicates that the KMS key is the primary key in a multi-Region key, it is scheduled
        /// for deletion, and it still has existing replica keys.
        /// </para>
        ///  
        /// <para>
        /// When a single-Region KMS key or a multi-Region replica key is scheduled for deletion,
        /// its deletion date is displayed in the <c>DeletionDate</c> field. However, when the
        /// primary key in a multi-Region key is scheduled for deletion, its waiting period doesn't
        /// begin until all of its replica keys are deleted. This value displays that waiting
        /// period. When the last replica key in the multi-Region key is deleted, the <c>KeyState</c>
        /// of the scheduled primary key changes from <c>PendingReplicaDeletion</c> to <c>PendingDeletion</c>
        /// and the deletion date appears in the <c>DeletionDate</c> field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=365)]
        public int? PendingDeletionWindowInDays
        {
            get { return this._pendingDeletionWindowInDays; }
            set { this._pendingDeletionWindowInDays = value; }
        }

        // Check to see if PendingDeletionWindowInDays property is set
        internal bool IsSetPendingDeletionWindowInDays()
        {
            return this._pendingDeletionWindowInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SigningAlgorithms. 
        /// <para>
        /// The signing algorithms that the KMS key supports. You cannot use the KMS key with
        /// other signing algorithms within KMS.
        /// </para>
        ///  
        /// <para>
        /// This field appears only when the <c>KeyUsage</c> of the KMS key is <c>SIGN_VERIFY</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SigningAlgorithms
        {
            get { return this._signingAlgorithms; }
            set { this._signingAlgorithms = value; }
        }

        // Check to see if SigningAlgorithms property is set
        internal bool IsSetSigningAlgorithms()
        {
            return this._signingAlgorithms != null && (this._signingAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidTo. 
        /// <para>
        /// The earliest time at which any imported key material permanently associated with this
        /// KMS key expires. When a key material expires, KMS deletes the key material and the
        /// KMS key becomes unusable. This value is present only for KMS keys whose <c>Origin</c>
        /// is <c>EXTERNAL</c> and the <c>ExpirationModel</c> is <c>KEY_MATERIAL_EXPIRES</c>,
        /// otherwise this value is omitted.
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

        /// <summary>
        /// Gets and sets the property XksKeyConfiguration. 
        /// <para>
        /// Information about the external key that is associated with a KMS key in an external
        /// key store.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-external.html#concept-external-key">External
        /// key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public XksKeyConfigurationType XksKeyConfiguration
        {
            get { return this._xksKeyConfiguration; }
            set { this._xksKeyConfiguration = value; }
        }

        // Check to see if XksKeyConfiguration property is set
        internal bool IsSetXksKeyConfiguration()
        {
            return this._xksKeyConfiguration != null;
        }

    }
}