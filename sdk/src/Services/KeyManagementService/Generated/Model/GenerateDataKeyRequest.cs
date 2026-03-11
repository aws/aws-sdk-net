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
    /// You must also specify the length of the data key. Use either the <c>KeySpec</c> or
    /// <c>NumberOfBytes</c> parameters (but not both). For 128-bit and 256-bit data keys,
    /// use the <c>KeySpec</c> parameter.
    /// </para>
    ///  
    /// <para>
    /// To generate a 128-bit SM4 data key (China Regions only), specify a <c>KeySpec</c>
    /// value of <c>AES_128</c> or a <c>NumberOfBytes</c> value of <c>16</c>. The symmetric
    /// encryption key used in China Regions to encrypt your data key is an SM4 encryption
    /// key.
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
    /// operation. If you specify an <c>EncryptionContext</c>, you must specify the same encryption
    /// context (a case-sensitive exact match) when decrypting the encrypted data key. Otherwise,
    /// the request to decrypt fails with an <c>InvalidCiphertextException</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">Encryption
    /// Context</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <c>GenerateDataKey</c> also supports <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave.html">Amazon
    /// Web Services Nitro Enclaves</a>, which provide an isolated compute environment in
    /// Amazon EC2. To call <c>GenerateDataKey</c> for an Amazon Web Services Nitro enclave
    /// or NitroTPM, use the <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
    /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK. Use the <c>Recipient</c>
    /// parameter to provide the attestation document for the attested environment. <c>GenerateDataKey</c>
    /// returns a copy of the data key encrypted under the specified KMS key, as usual. But
    /// instead of a plaintext copy of the data key, the response includes a copy of the data
    /// key encrypted under the public key from the attestation document (<c>CiphertextForRecipient</c>).
    /// For information about the interaction between KMS and Amazon Web Services Nitro Enclaves
    /// or Amazon Web Services NitroTPM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/cryptographic-attestation.html">Cryptographic
    /// attestation support in KMS</a> in the <i>Key Management Service Developer Guide</i>.
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
    /// Use the <c>GenerateDataKey</c> operation to get a data key.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the plaintext data key (in the <c>Plaintext</c> field of the response) to encrypt
    /// your data outside of KMS. Then erase the plaintext data key from memory.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Store the encrypted data key (in the <c>CiphertextBlob</c> field of the response)
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
    /// <c>KeyId</c> parameter.
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
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class GenerateDataKeyRequest : AmazonKeyManagementServiceRequest
    {
        private bool? _dryRun;
        private Dictionary<string, string> _encryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _grantTokens = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _keyId;
        private DataKeySpec _keySpec;
        private int? _numberOfBytes;
        private RecipientInfo _recipient;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks if your request will succeed. <c>DryRun</c> is an optional parameter. 
        /// </para>
        ///  
        /// <para>
        /// To learn more about how to use this parameter, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/testing-permissions.html">Testing
        /// your permissions</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionContext. 
        /// <para>
        /// Specifies the encryption context that will be used when encrypting the data key.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include confidential or sensitive information in this field. This field may
        /// be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important> 
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
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">Encryption
        /// context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EncryptionContext
        {
            get { return this._encryptionContext; }
            set { this._encryptionContext = value; }
        }

        // Check to see if EncryptionContext property is set
        internal bool IsSetEncryptionContext()
        {
            return this._encryptionContext != null && (this._encryptionContext.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// token</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/using-grant-token.html">Using
        /// a grant token</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._grantTokens != null && (this._grantTokens.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// an alias name, prefix it with <c>"alias/"</c>. To specify a KMS key in a different
        /// Amazon Web Services account, you must use the key ARN or alias ARN.
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
        ///  </li> <li> 
        /// <para>
        /// Alias name: <c>alias/ExampleAlias</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN: <c>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</c> 
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
        /// Specifies the length of the data key. Use <c>AES_128</c> to generate a 128-bit symmetric
        /// key, or <c>AES_256</c> to generate a 256-bit symmetric key.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the <c>KeySpec</c> or the <c>NumberOfBytes</c> parameter (but
        /// not both) in every <c>GenerateDataKey</c> request.
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
        /// data keys, use the <c>KeySpec</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the <c>KeySpec</c> or the <c>NumberOfBytes</c> parameter (but
        /// not both) in every <c>GenerateDataKey</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public int? NumberOfBytes
        {
            get { return this._numberOfBytes; }
            set { this._numberOfBytes = value; }
        }

        // Check to see if NumberOfBytes property is set
        internal bool IsSetNumberOfBytes()
        {
            return this._numberOfBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recipient. 
        /// <para>
        /// A signed <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave-how.html#term-attestdoc">attestation
        /// document</a> from an Amazon Web Services Nitro enclave or NitroTPM, and the encryption
        /// algorithm to use with the public key in the attestation document. The only valid encryption
        /// algorithm is <c>RSAES_OAEP_SHA_256</c>. 
        /// </para>
        ///  
        /// <para>
        /// This parameter supports the <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
        /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK for Amazon Web
        /// Services Nitro Enclaves. It supports any Amazon Web Services SDK for Amazon Web Services
        /// NitroTPM. 
        /// </para>
        ///  
        /// <para>
        /// When you use this parameter, instead of returning the plaintext data key, KMS encrypts
        /// the plaintext data key under the public key in the attestation document, and returns
        /// the resulting ciphertext in the <c>CiphertextForRecipient</c> field in the response.
        /// This ciphertext can be decrypted only with the private key in the enclave. The <c>CiphertextBlob</c>
        /// field in the response contains a copy of the data key encrypted under the KMS key
        /// specified by the <c>KeyId</c> parameter. The <c>Plaintext</c> field in the response
        /// is null or empty.
        /// </para>
        ///  
        /// <para>
        /// For information about the interaction between KMS and Amazon Web Services Nitro Enclaves
        /// or Amazon Web Services NitroTPM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/cryptographic-attestation.html">Cryptographic
        /// attestation support in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public RecipientInfo Recipient
        {
            get { return this._recipient; }
            set { this._recipient = value; }
        }

        // Check to see if Recipient property is set
        internal bool IsSetRecipient()
        {
            return this._recipient != null;
        }

    }
}