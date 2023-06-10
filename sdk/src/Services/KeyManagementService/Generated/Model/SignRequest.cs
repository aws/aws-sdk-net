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
    /// Container for the parameters to the Sign operation.
    /// Creates a <a href="https://en.wikipedia.org/wiki/Digital_signature">digital signature</a>
    /// for a message or message digest by using the private key in an asymmetric signing
    /// KMS key. To verify the signature, use the <a>Verify</a> operation, or use the public
    /// key in the same asymmetric KMS key outside of KMS. For information about asymmetric
    /// KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
    /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// Digital signatures are generated and verified by using asymmetric key pair, such as
    /// an RSA or ECC pair that is represented by an asymmetric KMS key. The key owner (or
    /// an authorized user) uses their private key to sign a message. Anyone with the public
    /// key can verify that the message was signed with that particular private key and that
    /// the message hasn't changed since it was signed. 
    /// </para>
    ///  
    /// <para>
    /// To use the <code>Sign</code> operation, provide the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the <code>KeyId</code> parameter to identify an asymmetric KMS key with a <code>KeyUsage</code>
    /// value of <code>SIGN_VERIFY</code>. To get the <code>KeyUsage</code> value of a KMS
    /// key, use the <a>DescribeKey</a> operation. The caller must have <code>kms:Sign</code>
    /// permission on the KMS key.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the <code>Message</code> parameter to specify the message or message digest to
    /// sign. You can submit messages of up to 4096 bytes. To sign a larger message, generate
    /// a hash digest of the message, and then provide the hash digest in the <code>Message</code>
    /// parameter. To indicate whether the message is a full message or a digest, use the
    /// <code>MessageType</code> parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Choose a signing algorithm that is compatible with the KMS key. 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// When signing a message, be sure to record the KMS key and the signing algorithm. This
    /// information is required to verify the signature.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// Best practices recommend that you limit the time during which any signature is effective.
    /// This deters an attack where the actor uses a signed message to establish validity
    /// repeatedly or long after the message is superseded. Signatures do not include a timestamp,
    /// but you can include a timestamp in the signed message to help you detect when its
    /// time to refresh the signature. 
    /// </para>
    ///  </note> 
    /// <para>
    /// To verify the signature that this operation generates, use the <a>Verify</a> operation.
    /// Or use the <a>GetPublicKey</a> operation to download the public key and then use the
    /// public key to verify the signature outside of KMS. 
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
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Sign</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b>: <a>Verify</a> 
    /// </para>
    /// </summary>
    public partial class SignRequest : AmazonKeyManagementServiceRequest
    {
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private MemoryStream _message;
        private MessageType _messageType;
        private SigningAlgorithmSpec _signingAlgorithm;

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
        /// Identifies an asymmetric KMS key. KMS uses the private key in the asymmetric KMS key
        /// to sign the message. The <code>KeyUsage</code> type of the KMS key must be <code>SIGN_VERIFY</code>.
        /// To find the <code>KeyUsage</code> of a KMS key, use the <a>DescribeKey</a> operation.
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
        /// Gets and sets the property Message. 
        /// <para>
        /// Specifies the message or message digest to sign. Messages can be 0-4096 bytes. To
        /// sign a larger message, provide a message digest.
        /// </para>
        ///  
        /// <para>
        /// If you provide a message digest, use the <code>DIGEST</code> value of <code>MessageType</code>
        /// to prevent the digest from being hashed again while signing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
        public MemoryStream Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// Tells KMS whether the value of the <code>Message</code> parameter should be hashed
        /// as part of the signing algorithm. Use <code>RAW</code> for unhashed messages; use
        /// <code>DIGEST</code> for message digests, which are already hashed.
        /// </para>
        ///  
        /// <para>
        /// When the value of <code>MessageType</code> is <code>RAW</code>, KMS uses the standard
        /// signing algorithm, which begins with a hash function. When the value is <code>DIGEST</code>,
        /// KMS skips the hashing step in the signing algorithm.
        /// </para>
        ///  <important> 
        /// <para>
        /// Use the <code>DIGEST</code> value only when the value of the <code>Message</code>
        /// parameter is a message digest. If you use the <code>DIGEST</code> value with an unhashed
        /// message, the security of the signing operation can be compromised.
        /// </para>
        ///  </important> 
        /// <para>
        /// When the value of <code>MessageType</code>is <code>DIGEST</code>, the length of the
        /// <code>Message</code> value must match the length of hashed messages for the specified
        /// signing algorithm.
        /// </para>
        ///  
        /// <para>
        /// You can submit a message digest and omit the <code>MessageType</code> or specify <code>RAW</code>
        /// so the digest is hashed again while signing. However, this can cause verification
        /// failures when verifying with a system that assumes a single hash.
        /// </para>
        ///  
        /// <para>
        /// The hashing algorithm in that <code>Sign</code> uses is based on the <code>SigningAlgorithm</code>
        /// value.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Signing algorithms that end in SHA_256 use the SHA_256 hashing algorithm.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Signing algorithms that end in SHA_384 use the SHA_384 hashing algorithm.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Signing algorithms that end in SHA_512 use the SHA_512 hashing algorithm.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SM2DSA uses the SM3 hashing algorithm. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/asymmetric-key-specs.html#key-spec-sm-offline-verification">Offline
        /// verification with SM2 key pairs</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MessageType MessageType
        {
            get { return this._messageType; }
            set { this._messageType = value; }
        }

        // Check to see if MessageType property is set
        internal bool IsSetMessageType()
        {
            return this._messageType != null;
        }

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// Specifies the signing algorithm to use when signing the message. 
        /// </para>
        ///  
        /// <para>
        /// Choose an algorithm that is compatible with the type and size of the specified asymmetric
        /// KMS key. When signing with RSA key pairs, RSASSA-PSS algorithms are preferred. We
        /// include RSASSA-PKCS1-v1_5 algorithms for compatibility with existing applications.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SigningAlgorithmSpec SigningAlgorithm
        {
            get { return this._signingAlgorithm; }
            set { this._signingAlgorithm = value; }
        }

        // Check to see if SigningAlgorithm property is set
        internal bool IsSetSigningAlgorithm()
        {
            return this._signingAlgorithm != null;
        }

    }
}