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
    /// Container for the parameters to the GenerateDataKeyWithoutPlaintext operation.
    /// Returns a unique symmetric data key for use outside of KMS. This operation returns
    /// a data key that is encrypted under a symmetric encryption KMS key that you specify.
    /// The bytes in the key are random; they are not related to the caller or to the KMS
    /// key.
    /// 
    ///  
    /// <para>
    ///  <c>GenerateDataKeyWithoutPlaintext</c> is identical to the <a>GenerateDataKey</a>
    /// operation except that it does not return a plaintext copy of the data key. 
    /// </para>
    ///  
    /// <para>
    /// This operation is useful for systems that need to encrypt data at some point, but
    /// not immediately. When you need to encrypt the data, you call the <a>Decrypt</a> operation
    /// on the encrypted copy of the key.
    /// </para>
    ///  
    /// <para>
    /// It's also useful in distributed systems with different levels of trust. For example,
    /// you might store encrypted data in containers. One component of your system creates
    /// new containers and stores an encrypted data key with each container. Then, a different
    /// component puts the data into the containers. That component first decrypts the data
    /// key, uses the plaintext data key to encrypt data, puts the encrypted data into the
    /// container, and then destroys the plaintext data key. In this system, the component
    /// that creates the containers never sees the plaintext data key.
    /// </para>
    ///  
    /// <para>
    /// To request an asymmetric data key pair, use the <a>GenerateDataKeyPair</a> or <a>GenerateDataKeyPairWithoutPlaintext</a>
    /// operations.
    /// </para>
    ///  
    /// <para>
    /// To generate a data key, you must specify the symmetric encryption KMS key that is
    /// used to encrypt the data key. You cannot use an asymmetric KMS key or a key in a custom
    /// key store to generate a data key. To get the type of your KMS key, use the <a>DescribeKey</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// You must also specify the length of the data key. Use either the <c>KeySpec</c> or
    /// <c>NumberOfBytes</c> parameters (but not both). For 128-bit and 256-bit data keys,
    /// use the <c>KeySpec</c> parameter.
    /// </para>
    ///  
    /// <para>
    /// To generate an SM4 data key (China Regions only), specify a <c>KeySpec</c> value of
    /// <c>AES_128</c> or <c>NumberOfBytes</c> value of <c>16</c>. The symmetric encryption
    /// key used in China Regions to encrypt your data key is an SM4 encryption key.
    /// </para>
    ///  
    /// <para>
    /// If the operation succeeds, you will find the encrypted copy of the data key in the
    /// <c>CiphertextBlob</c> field.
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
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
    /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
    /// <c>KeyId</c> parameter.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyWithoutPlaintext</a>
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
    ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class GenerateDataKeyWithoutPlaintextRequest : AmazonKeyManagementServiceRequest
    {
        private bool? _dryRun;
        private Dictionary<string, string> _encryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _grantTokens = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _keyId;
        private DataKeySpec _keySpec;
        private int? _numberOfBytes;

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
        /// The length of the data key. Use <c>AES_128</c> to generate a 128-bit symmetric key,
        /// or <c>AES_256</c> to generate a 256-bit symmetric key.
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
        /// The length of the data key in bytes. For example, use the value 64 to generate a 512-bit
        /// data key (64 bytes is 512 bits). For common key lengths (128-bit and 256-bit symmetric
        /// keys), we recommend that you use the <c>KeySpec</c> field instead of this one.
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

    }
}