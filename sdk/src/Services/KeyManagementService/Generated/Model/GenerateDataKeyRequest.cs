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
    /// Container for the parameters to the GenerateDataKey operation.
    /// Returns a unique symmetric data key for use outside of KMS. This operation returns
    /// a plaintext copy of the data key and a copy that is encrypted under a symmetric encryption
    /// KMS key that you specify. The bytes in the plaintext key are random; they are not
    /// related to the caller or the KMS key. You can use the plaintext key to encrypt your
    /// data outside of KMS and store the encrypted data key with the encrypted data.
    /// 
    ///  
    /// <para>
    /// To generate a data key, specify the symmetric encryption KMS key that will be used
    /// to encrypt the data key. You cannot use an asymmetric KMS key to encrypt data keys.
    /// To get the type of your KMS key, use the <a>DescribeKey</a> operation.
    /// </para>
    ///  
    /// <para>
    /// You must also specify the length of the data key. Use either the <code>KeySpec</code>
    /// or <code>NumberOfBytes</code> parameters (but not both). For 128-bit and 256-bit data
    /// keys, use the <code>KeySpec</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// To generate a 128-bit SM4 data key (China Regions only), specify a <code>KeySpec</code>
    /// value of <code>AES_128</code> or a <code>NumberOfBytes</code> value of <code>16</code>.
    /// The symmetric encryption key used in China Regions to encrypt your data key is an
    /// SM4 encryption key.
    /// </para>
    ///  
    /// <para>
    /// To get only an encrypted copy of the data key, use <a>GenerateDataKeyWithoutPlaintext</a>.
    /// To generate an asymmetric data key pair, use the <a>GenerateDataKeyPair</a> or <a>GenerateDataKeyPairWithoutPlaintext</a>
    /// operation. To get a cryptographically secure random byte string, use <a>GenerateRandom</a>.
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
    /// Applications in Amazon Web Services Nitro Enclaves can call this operation by using
    /// the <a href="https://github.com/aws/aws-nitro-enclaves-sdk-c">Amazon Web Services
    /// Nitro Enclaves Development Kit</a>. For information about the supporting parameters,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
    /// Amazon Web Services Nitro Enclaves use KMS</a> in the <i>Key Management Service Developer
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
    ///  <b>How to use your data key</b> 
    /// </para>
    ///  
    /// <para>
    /// We recommend that you use the following pattern to encrypt data locally in your application.
    /// You can write your own code or use a client-side encryption library, such as the <a
    /// href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon Web
    /// Services Encryption SDK</a>, the <a href="https://docs.aws.amazon.com/dynamodb-encryption-client/latest/devguide/">Amazon
    /// DynamoDB Encryption Client</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
    /// S3 client-side encryption</a> to do these tasks for you.
    /// </para>
    ///  
    /// <para>
    /// To encrypt data outside of KMS:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Use the <code>GenerateDataKey</code> operation to get a data key.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the plaintext data key (in the <code>Plaintext</code> field of the response) to
    /// encrypt your data outside of KMS. Then erase the plaintext data key from memory.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Store the encrypted data key (in the <code>CiphertextBlob</code> field of the response)
    /// with the encrypted data.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// To decrypt data outside of KMS:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Use the <a>Decrypt</a> operation to decrypt the encrypted data key. The operation
    /// returns a plaintext copy of the data key.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the plaintext data key to decrypt data outside of KMS, then erase the plaintext
    /// data key from memory.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
    /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
    /// <code>KeyId</code> parameter.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKey</a>
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
    ///  <a>GenerateDataKeyPair</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GenerateDataKeyRequest : AmazonKeyManagementServiceRequest
    {
        private Dictionary<string, string> _encryptionContext = new Dictionary<string, string>();
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private DataKeySpec _keySpec;
        private int? _numberOfBytes;

        /// <summary>
        /// Gets and sets the property EncryptionContext. 
        /// <para>
        /// Specifies the encryption context that will be used when encrypting the data key.
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
        /// Specifies the symmetric encryption KMS key that encrypts the data key. You cannot
        /// specify an asymmetric KMS key or a KMS key in a custom key store. To get the type
        /// and origin of your KMS key, use the <a>DescribeKey</a> operation.
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
        /// Gets and sets the property KeySpec. 
        /// <para>
        /// Specifies the length of the data key. Use <code>AES_128</code> to generate a 128-bit
        /// symmetric key, or <code>AES_256</code> to generate a 256-bit symmetric key.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the <code>KeySpec</code> or the <code>NumberOfBytes</code>
        /// parameter (but not both) in every <code>GenerateDataKey</code> request.
        /// </para>
        /// </summary>
        public DataKeySpec KeySpec
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
        /// Gets and sets the property NumberOfBytes. 
        /// <para>
        /// Specifies the length of the data key in bytes. For example, use the value 64 to generate
        /// a 512-bit data key (64 bytes is 512 bits). For 128-bit (16-byte) and 256-bit (32-byte)
        /// data keys, use the <code>KeySpec</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the <code>KeySpec</code> or the <code>NumberOfBytes</code>
        /// parameter (but not both) in every <code>GenerateDataKey</code> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public int NumberOfBytes
        {
            get { return this._numberOfBytes.GetValueOrDefault(); }
            set { this._numberOfBytes = value; }
        }

        // Check to see if NumberOfBytes property is set
        internal bool IsSetNumberOfBytes()
        {
            return this._numberOfBytes.HasValue; 
        }

    }
}