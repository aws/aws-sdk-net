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
    /// Container for the parameters to the Decrypt operation.
    /// Decrypts ciphertext that was encrypted by a AWS KMS customer master key (CMK) using
    /// any of the following operations:
    /// 
    ///  <ul> <li> 
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
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use this operation to decrypt ciphertext that was encrypted under a symmetric
    /// or asymmetric CMK. When the CMK is asymmetric, you must specify the CMK and the encryption
    /// algorithm that was used to encrypt the ciphertext. For information about symmetric
    /// and asymmetric CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
    /// Symmetric and Asymmetric CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The Decrypt operation also decrypts ciphertext that was encrypted outside of AWS KMS
    /// by the public key in an AWS KMS asymmetric CMK. However, it cannot decrypt ciphertext
    /// produced by other libraries, such as the <a href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">AWS
    /// Encryption SDK</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
    /// S3 client-side encryption</a>. These libraries return a ciphertext format that is
    /// incompatible with AWS KMS.
    /// </para>
    ///  
    /// <para>
    /// If the ciphertext was encrypted under a symmetric CMK, you do not need to specify
    /// the CMK or the encryption algorithm. AWS KMS can get this information from metadata
    /// that it adds to the symmetric ciphertext blob. However, if you prefer, you can specify
    /// the <code>KeyId</code> to ensure that a particular CMK is used to decrypt the ciphertext.
    /// If you specify a different CMK than the one used to encrypt the ciphertext, the <code>Decrypt</code>
    /// operation fails.
    /// </para>
    ///  
    /// <para>
    /// Whenever possible, use key policies to give users permission to call the Decrypt operation
    /// on a particular CMK, instead of using IAM policies. Otherwise, you might create an
    /// IAM user policy that gives the user Decrypt permission on all CMKs. This user could
    /// decrypt ciphertext that was encrypted by CMKs in other accounts if the key policy
    /// for the cross-account CMK permits it. If you must use an IAM policy for <code>Decrypt</code>
    /// permissions, limit the user to particular CMKs or particular trusted accounts.
    /// </para>
    ///  
    /// <para>
    /// The CMK that you use for this operation must be in a compatible key state. For details,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
    /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class DecryptRequest : AmazonKeyManagementServiceRequest
    {
        private MemoryStream _ciphertextBlob;
        private EncryptionAlgorithmSpec _encryptionAlgorithm;
        private Dictionary<string, string> _encryptionContext = new Dictionary<string, string>();
        private List<string> _grantTokens = new List<string>();
        private string _keyId;

        /// <summary>
        /// Gets and sets the property CiphertextBlob. 
        /// <para>
        /// Ciphertext to be decrypted. The blob includes metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6144)]
        public MemoryStream CiphertextBlob
        {
            get { return this._ciphertextBlob; }
            set { this._ciphertextBlob = value; }
        }

        // Check to see if CiphertextBlob property is set
        internal bool IsSetCiphertextBlob()
        {
            return this._ciphertextBlob != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionAlgorithm. 
        /// <para>
        /// Specifies the encryption algorithm that will be used to decrypt the ciphertext. Specify
        /// the same algorithm that was used to encrypt the data. If you specify a different algorithm,
        /// the <code>Decrypt</code> operation fails.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required only when the ciphertext was encrypted under an asymmetric
        /// CMK. The default value, <code>SYMMETRIC_DEFAULT</code>, represents the only supported
        /// algorithm that is valid for symmetric CMKs.
        /// </para>
        /// </summary>
        public EncryptionAlgorithmSpec EncryptionAlgorithm
        {
            get { return this._encryptionAlgorithm; }
            set { this._encryptionAlgorithm = value; }
        }

        // Check to see if EncryptionAlgorithm property is set
        internal bool IsSetEncryptionAlgorithm()
        {
            return this._encryptionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionContext. 
        /// <para>
        /// Specifies the encryption context to use when decrypting the data. An encryption context
        /// is valid only for cryptographic operations with a symmetric CMK. The standard asymmetric
        /// encryption algorithms that AWS KMS uses do not support an encryption context.
        /// </para>
        ///  
        /// <para>
        /// An <i>encryption context</i> is a collection of non-secret key-value pairs that represents
        /// additional authenticated data. When you use an encryption context to encrypt data,
        /// you must specify the same (an exact case-sensitive match) encryption context to decrypt
        /// the data. An encryption context is optional when encrypting with a symmetric CMK,
        /// but it is highly recommended.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
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
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token">Grant
        /// Tokens</a> in the <i>AWS Key Management Service Developer Guide</i>.
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
        /// Specifies the customer master key (CMK) that AWS KMS will use to decrypt the ciphertext.
        /// Enter a key ID of the CMK that was used to encrypt the ciphertext.
        /// </para>
        ///  
        /// <para>
        /// If you specify a <code>KeyId</code> value, the <code>Decrypt</code> operation succeeds
        /// only if the specified CMK was used to encrypt the ciphertext.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required only when the ciphertext was encrypted under an asymmetric
        /// CMK. Otherwise, AWS KMS uses the metadata that it adds to the ciphertext blob to determine
        /// which CMK was used to encrypt the ciphertext. However, you can use this parameter
        /// to ensure that a particular CMK (of any kind) is used to decrypt the ciphertext.
        /// </para>
        ///  
        /// <para>
        /// To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias
        /// ARN. When using an alias name, prefix it with <code>"alias/"</code>.
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
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// To get the alias name and alias ARN, use <a>ListAliases</a>.
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

    }
}