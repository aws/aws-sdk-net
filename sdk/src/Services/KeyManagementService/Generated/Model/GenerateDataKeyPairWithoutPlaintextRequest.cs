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
    /// Container for the parameters to the GenerateDataKeyPairWithoutPlaintext operation.
    /// Returns a unique asymmetric data key pair for use outside of KMS. This operation returns
    /// a plaintext public key and a copy of the private key that is encrypted under the symmetric
    /// encryption KMS key you specify. Unlike <a>GenerateDataKeyPair</a>, this operation
    /// does not return a plaintext private key. The bytes in the keys are random; they are
    /// not related to the caller or to the KMS key that is used to encrypt the private key.
    /// 
    /// 
    ///  
    /// <para>
    /// You can use the public key that <code>GenerateDataKeyPairWithoutPlaintext</code> returns
    /// to encrypt data or verify a signature outside of KMS. Then, store the encrypted private
    /// key with the data. When you are ready to decrypt data or sign a message, you can use
    /// the <a>Decrypt</a> operation to decrypt the encrypted private key.
    /// </para>
    ///  
    /// <para>
    /// To generate a data key pair, you must specify a symmetric encryption KMS key to encrypt
    /// the private key in a data key pair. You cannot use an asymmetric KMS key or a KMS
    /// key in a custom key store. To get the type and origin of your KMS key, use the <a>DescribeKey</a>
    /// operation. 
    /// </para>
    ///  
    /// <para>
    /// Use the <code>KeyPairSpec</code> parameter to choose an RSA or Elliptic Curve (ECC)
    /// data key pair. In China Regions, you can also choose an SM2 data key pair. KMS recommends
    /// that you use ECC key pairs for signing, and use RSA and SM2 key pairs for either encryption
    /// or signing, but not both. However, KMS cannot enforce any restrictions on the use
    /// of data key pairs outside of KMS.
    /// </para>
    ///  
    /// <para>
    ///  <code>GenerateDataKeyPairWithoutPlaintext</code> returns a unique data key pair for
    /// each request. The bytes in the key are not related to the caller or KMS key that is
    /// used to encrypt the private key. The public key is a DER-encoded X.509 SubjectPublicKeyInfo,
    /// as specified in <a href="https://tools.ietf.org/html/rfc5280">RFC 5280</a>.
    /// </para>
    ///  
    /// <para>
    /// You can use an optional encryption context to add additional security to the encryption
    /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
    /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
    /// data key. Otherwise, the request to decrypt fails with an <code>InvalidCiphertextException</code>.
    /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
    /// Context</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
    /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
    /// <code>KeyId</code> parameter.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyPairWithoutPlaintext</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>Decrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Encrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyPair</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GenerateDataKeyPairWithoutPlaintextRequest : AmazonKeyManagementServiceRequest
    {
        private Dictionary<string, string> _encryptionContext = new Dictionary<string, string>();
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private DataKeyPairSpec _keyPairSpec;

        /// <summary>
        /// Gets and sets the property EncryptionContext. 
        /// <para>
        /// Specifies the encryption context that will be used when encrypting the private key
        /// in the data key pair.
        /// </para>
        ///  
        /// <para>
        /// An <i>encryption context</i> is a collection of non-secret key-value pairs that represent
        /// additional authenticated data. When you use an encryption context to encrypt data,
        /// you must specify the same (an exact case-sensitive match) encryption context to decrypt
        /// the data. An encryption context is supported only on operations with symmetric encryption
        /// KMS keys. On operations with symmetric encryption KMS keys, an encryption context
        /// is optional, but it is strongly recommended.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> EncryptionContext
        {
            get { return this._encryptionContext; }
            set { this._encryptionContext = value; }
        }

        // Check to see if EncryptionContext property is set
        internal bool IsSetEncryptionContext()
        {
            return this._encryptionContext != null && this._encryptionContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GrantTokens. 
        /// <para>
        /// A list of grant tokens.
        /// </para>
        ///  
        /// <para>
        /// Use a grant token when your permission to call this operation comes from a new grant
        /// that has not yet achieved <i>eventual consistency</i>. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">Grant
        /// token</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#using-grant-token">Using
        /// a grant token</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> GrantTokens
        {
            get { return this._grantTokens; }
            set { this._grantTokens = value; }
        }

        // Check to see if GrantTokens property is set
        internal bool IsSetGrantTokens()
        {
            return this._grantTokens != null && this._grantTokens.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Specifies the symmetric encryption KMS key that encrypts the private key in the data
        /// key pair. You cannot specify an asymmetric KMS key or a KMS key in a custom key store.
        /// To get the type and origin of your KMS key, use the <a>DescribeKey</a> operation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To specify a KMS key, use its key ID, key ARN, alias name, or alias ARN. When using
        /// an alias name, prefix it with <code>"alias/"</code>. To specify a KMS key in a different
        /// Amazon Web Services account, you must use the key ARN or alias ARN.
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
        ///  </li> <li> 
        /// <para>
        /// Alias name: <code>alias/ExampleAlias</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// To get the alias name and alias ARN, use <a>ListAliases</a>.
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
        /// Gets and sets the property KeyPairSpec. 
        /// <para>
        /// Determines the type of data key pair that is generated.
        /// </para>
        ///  
        /// <para>
        /// The KMS rule that restricts the use of asymmetric RSA and SM2 KMS keys to encrypt
        /// and decrypt or to sign and verify (but not both), and the rule that permits you to
        /// use ECC KMS keys only to sign and verify, are not effective on data key pairs, which
        /// are used outside of KMS. The SM2 key spec is only available in China Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataKeyPairSpec KeyPairSpec
        {
            get { return this._keyPairSpec; }
            set { this._keyPairSpec = value; }
        }

        // Check to see if KeyPairSpec property is set
        internal bool IsSetKeyPairSpec()
        {
            return this._keyPairSpec != null;
        }

    }
}