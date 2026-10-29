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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the GetPublicKey operation.
    /// </summary>
    public partial class GetPublicKeyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CustomerMasterKeySpec. 
        /// <para>
        /// Instead, use the <c>KeySpec</c> field in the <c>GetPublicKey</c> response.
        /// </para>
        ///  
        /// <para>
        /// The <c>KeySpec</c> and <c>CustomerMasterKeySpec</c> fields have the same value. We
        /// recommend that you use the <c>KeySpec</c> field in your code. However, to avoid breaking
        /// changes, KMS supports both fields.
        /// </para>
        /// </summary>
        [Obsolete("This field has been deprecated. Instead, use the KeySpec field.")]
        public CustomerMasterKeySpec CustomerMasterKeySpec { get; set; }

        /// <summary>
        /// Checks to see if the CustomerMasterKeySpec property is set.
        /// </summary>
        internal bool IsSetCustomerMasterKeySpec() => this.CustomerMasterKeySpec != null;

        /// <summary>
        /// Gets and sets the property EncapsulationAlgorithms. 
        /// <para>
        /// The key encapsulation algorithm used to establish a shared secret. This field is present
        /// only when the KMS key has a <c>KeyUsage</c> value of <c>ENCAPSULATE_DECAPSULATE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EncapsulationAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EncapsulationAlgorithms property is set.
        /// </summary>
        internal bool IsSetEncapsulationAlgorithms() => this.EncapsulationAlgorithms != null && (this.EncapsulationAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EncryptionAlgorithms. 
        /// <para>
        /// The encryption algorithms that KMS supports for this key. 
        /// </para>
        ///  
        /// <para>
        /// This information is critical. If a public key encrypts data outside of KMS by using
        /// an unsupported encryption algorithm, the ciphertext cannot be decrypted. 
        /// </para>
        ///  
        /// <para>
        /// This field appears in the response only when the <c>KeyUsage</c> of the public key
        /// is <c>ENCRYPT_DECRYPT</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EncryptionAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EncryptionAlgorithms property is set.
        /// </summary>
        internal bool IsSetEncryptionAlgorithms() => this.EncryptionAlgorithms != null && (this.EncryptionAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyAgreementAlgorithms. 
        /// <para>
        /// The key agreement algorithm used to derive a shared secret. This field is present
        /// only when the KMS key has a <c>KeyUsage</c> value of <c>KEY_AGREEMENT</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeyAgreementAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the KeyAgreementAlgorithms property is set.
        /// </summary>
        internal bool IsSetKeyAgreementAlgorithms() => this.KeyAgreementAlgorithms != null && (this.KeyAgreementAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">key
        /// ARN</a>) of the asymmetric KMS key from which the public key was downloaded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property KeySpec. 
        /// <para>
        /// The type of the of the public key that was downloaded.
        /// </para>
        /// </summary>
        public KeySpec KeySpec { get; set; }

        /// <summary>
        /// Checks to see if the KeySpec property is set.
        /// </summary>
        internal bool IsSetKeySpec() => this.KeySpec != null;

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// The permitted use of the public key. Valid values for asymmetric key pairs are <c>ENCRYPT_DECRYPT</c>,
        /// <c>SIGN_VERIFY</c>, and <c>KEY_AGREEMENT</c>. 
        /// </para>
        ///  
        /// <para>
        /// This information is critical. For example, if a public key with <c>SIGN_VERIFY</c>
        /// key usage encrypts data outside of KMS, the ciphertext cannot be decrypted. 
        /// </para>
        /// </summary>
        public KeyUsageType KeyUsage { get; set; }

        /// <summary>
        /// Checks to see if the KeyUsage property is set.
        /// </summary>
        internal bool IsSetKeyUsage() => this.KeyUsage != null;

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The exported public key. 
        /// </para>
        ///  
        /// <para>
        /// The value is a DER-encoded X.509 public key, also known as <c>SubjectPublicKeyInfo</c>
        /// (SPKI), as defined in <a href="https://tools.ietf.org/html/rfc5280">RFC 5280</a>.
        /// When you use the HTTP API or the Amazon Web Services CLI, the value is Base64-encoded.
        /// Otherwise, it is not Base64-encoded.
        /// </para>
        ///  
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public MemoryStream PublicKey { get; set; }

        /// <summary>
        /// Checks to see if the PublicKey property is set.
        /// </summary>
        internal bool IsSetPublicKey() => this.PublicKey != null;

        /// <summary>
        /// Gets and sets the property SigningAlgorithms. 
        /// <para>
        /// The signing algorithms that KMS supports for this key.
        /// </para>
        ///  
        /// <para>
        /// This field appears in the response only when the <c>KeyUsage</c> of the public key
        /// is <c>SIGN_VERIFY</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SigningAlgorithms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SigningAlgorithms property is set.
        /// </summary>
        internal bool IsSetSigningAlgorithms() => this.SigningAlgorithms != null && (this.SigningAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
