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
    /// This is the response object from the GetPublicKey operation.
    /// </summary>
    public partial class GetPublicKeyResponse : AmazonWebServiceResponse
    {
        private CustomerMasterKeySpec _customerMasterKeySpec;
        private List<string> _encryptionAlgorithms = new List<string>();
        private string _keyId;
        private KeySpec _keySpec;
        private KeyUsageType _keyUsage;
        private MemoryStream _publicKey;
        private List<string> _signingAlgorithms = new List<string>();

        /// <summary>
        /// Gets and sets the property CustomerMasterKeySpec. 
        /// <para>
        /// Instead, use the <code>KeySpec</code> field in the <code>GetPublicKey</code> response.
        /// </para>
        ///  
        /// <para>
        /// The <code>KeySpec</code> and <code>CustomerMasterKeySpec</code> fields have the same
        /// value. We recommend that you use the <code>KeySpec</code> field in your code. However,
        /// to avoid breaking changes, KMS supports both fields.
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
        /// This field appears in the response only when the <code>KeyUsage</code> of the public
        /// key is <code>ENCRYPT_DECRYPT</code>.
        /// </para>
        /// </summary>
        public List<string> EncryptionAlgorithms
        {
            get { return this._encryptionAlgorithms; }
            set { this._encryptionAlgorithms = value; }
        }

        // Check to see if EncryptionAlgorithms property is set
        internal bool IsSetEncryptionAlgorithms()
        {
            return this._encryptionAlgorithms != null && this._encryptionAlgorithms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">key
        /// ARN</a>) of the asymmetric KMS key from which the public key was downloaded.
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
        /// Gets and sets the property KeySpec. 
        /// <para>
        /// The type of the of the public key that was downloaded.
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
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// The permitted use of the public key. Valid values are <code>ENCRYPT_DECRYPT</code>
        /// or <code>SIGN_VERIFY</code>. 
        /// </para>
        ///  
        /// <para>
        /// This information is critical. If a public key with <code>SIGN_VERIFY</code> key usage
        /// encrypts data outside of KMS, the ciphertext cannot be decrypted. 
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
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The exported public key. 
        /// </para>
        ///  
        /// <para>
        /// The value is a DER-encoded X.509 public key, also known as <code>SubjectPublicKeyInfo</code>
        /// (SPKI), as defined in <a href="https://tools.ietf.org/html/rfc5280">RFC 5280</a>.
        /// When you use the HTTP API or the Amazon Web Services CLI, the value is Base64-encoded.
        /// Otherwise, it is not Base64-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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

        /// <summary>
        /// Gets and sets the property SigningAlgorithms. 
        /// <para>
        /// The signing algorithms that KMS supports for this key.
        /// </para>
        ///  
        /// <para>
        /// This field appears in the response only when the <code>KeyUsage</code> of the public
        /// key is <code>SIGN_VERIFY</code>.
        /// </para>
        /// </summary>
        public List<string> SigningAlgorithms
        {
            get { return this._signingAlgorithms; }
            set { this._signingAlgorithms = value; }
        }

        // Check to see if SigningAlgorithms property is set
        internal bool IsSetSigningAlgorithms()
        {
            return this._signingAlgorithms != null && this._signingAlgorithms.Count > 0; 
        }

    }
}