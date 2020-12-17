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
    /// for a message or message digest by using the private key in an asymmetric CMK. To
    /// verify the signature, use the <a>Verify</a> operation, or use the public key in the
    /// same asymmetric CMK outside of AWS KMS. For information about symmetric and asymmetric
    /// CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
    /// Symmetric and Asymmetric CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// Digital signatures are generated and verified by using asymmetric key pair, such as
    /// an RSA or ECC pair that is represented by an asymmetric customer master key (CMK).
    /// The key owner (or an authorized user) uses their private key to sign a message. Anyone
    /// with the public key can verify that the message was signed with that particular private
    /// key and that the message hasn't changed since it was signed. 
    /// </para>
    ///  
    /// <para>
    /// To use the <code>Sign</code> operation, provide the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the <code>KeyId</code> parameter to identify an asymmetric CMK with a <code>KeyUsage</code>
    /// value of <code>SIGN_VERIFY</code>. To get the <code>KeyUsage</code> value of a CMK,
    /// use the <a>DescribeKey</a> operation. The caller must have <code>kms:Sign</code> permission
    /// on the CMK.
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
    /// Choose a signing algorithm that is compatible with the CMK. 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// When signing a message, be sure to record the CMK and the signing algorithm. This
    /// information is required to verify the signature.
    /// </para>
    ///  </important> 
    /// <para>
    /// To verify the signature that this operation generates, use the <a>Verify</a> operation.
    /// Or use the <a>GetPublicKey</a> operation to download the public key and then use the
    /// public key to verify the signature outside of AWS KMS. 
    /// </para>
    ///  
    /// <para>
    /// The CMK that you use for this operation must be in a compatible key state. For details,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
    /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
    /// Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Yes. To perform this operation with a CMK in a different
    /// AWS account, specify the key ARN or alias ARN in the value of the <code>KeyId</code>
    /// parameter.
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
        /// Identifies an asymmetric CMK. AWS KMS uses the private key in the asymmetric CMK to
        /// sign the message. The <code>KeyUsage</code> type of the CMK must be <code>SIGN_VERIFY</code>.
        /// To find the <code>KeyUsage</code> of a CMK, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias
        /// ARN. When using an alias name, prefix it with <code>"alias/"</code>. To specify a
        /// CMK in a different AWS account, you must use the key ARN or alias ARN.
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
        /// sign a larger message, provide the message digest.
        /// </para>
        ///  
        /// <para>
        /// If you provide a message, AWS KMS generates a hash digest of the message and then
        /// signs it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
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
        /// Tells AWS KMS whether the value of the <code>Message</code> parameter is a message
        /// or message digest. The default value, RAW, indicates a message. To indicate a message
        /// digest, enter <code>DIGEST</code>.
        /// </para>
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
        /// CMK.
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