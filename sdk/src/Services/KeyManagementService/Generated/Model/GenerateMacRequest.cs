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
    /// Container for the parameters to the GenerateMac operation.
    /// Generates a hash-based message authentication code (HMAC) for a message using an HMAC
    /// KMS key and a MAC algorithm that the key supports. HMAC KMS keys and the HMAC algorithms
    /// that KMS uses conform to industry standards defined in <a href="https://datatracker.ietf.org/doc/html/rfc2104">RFC
    /// 2104</a>.
    /// 
    ///  
    /// <para>
    /// You can use value that GenerateMac returns in the <a>VerifyMac</a> operation to demonstrate
    /// that the original message has not changed. Also, because a secret key is used to create
    /// the hash, you can verify that the party that generated the hash has the required secret
    /// key. You can also use the raw result to implement HMAC-based algorithms such as key
    /// derivation functions. This operation is part of KMS support for HMAC KMS keys. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
    /// keys in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Best practices recommend that you limit the time during which any signing mechanism,
    /// including an HMAC, is effective. This deters an attack where the actor uses a signed
    /// message to establish validity repeatedly or long after the message is superseded.
    /// HMAC tags do not include a timestamp, but you can include a timestamp in the token
    /// or message to help you detect when its time to refresh the HMAC. 
    /// </para>
    ///  </note> 
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
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateMac</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b>: <a>VerifyMac</a> 
    /// </para>
    /// </summary>
    public partial class GenerateMacRequest : AmazonKeyManagementServiceRequest
    {
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private MacAlgorithmSpec _macAlgorithm;
        private MemoryStream _message;

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
        /// The HMAC KMS key to use in the operation. The MAC algorithm computes the HMAC for
        /// the message and the key as described in <a href="https://datatracker.ietf.org/doc/html/rfc2104">RFC
        /// 2104</a>.
        /// </para>
        ///  
        /// <para>
        /// To identify an HMAC KMS key, use the <a>DescribeKey</a> operation and see the <code>KeySpec</code>
        /// field in the response.
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
        /// Gets and sets the property MacAlgorithm. 
        /// <para>
        /// The MAC algorithm used in the operation.
        /// </para>
        ///  
        /// <para>
        ///  The algorithm must be compatible with the HMAC KMS key that you specify. To find
        /// the MAC algorithms that your HMAC KMS key supports, use the <a>DescribeKey</a> operation
        /// and see the <code>MacAlgorithms</code> field in the <code>DescribeKey</code> response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MacAlgorithmSpec MacAlgorithm
        {
            get { return this._macAlgorithm; }
            set { this._macAlgorithm = value; }
        }

        // Check to see if MacAlgorithm property is set
        internal bool IsSetMacAlgorithm()
        {
            return this._macAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message to be hashed. Specify a message of up to 4,096 bytes. 
        /// </para>
        ///  
        /// <para>
        ///  <code>GenerateMac</code> and <a>VerifyMac</a> do not provide special handling for
        /// message digests. If you generate an HMAC for a hash digest of a message, you must
        /// verify the HMAC of the same hash digest.
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

    }
}