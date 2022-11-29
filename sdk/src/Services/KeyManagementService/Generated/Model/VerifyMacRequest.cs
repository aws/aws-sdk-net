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
    /// Container for the parameters to the VerifyMac operation.
    /// Verifies the hash-based message authentication code (HMAC) for a specified message,
    /// HMAC KMS key, and MAC algorithm. To verify the HMAC, <code>VerifyMac</code> computes
    /// an HMAC using the message, HMAC KMS key, and MAC algorithm that you specify, and compares
    /// the computed HMAC to the HMAC that you specify. If the HMACs are identical, the verification
    /// succeeds; otherwise, it fails. Verification indicates that the message hasn't changed
    /// since the HMAC was calculated, and the specified key was used to generate and verify
    /// the HMAC.
    /// 
    ///  
    /// <para>
    /// HMAC KMS keys and the HMAC algorithms that KMS uses conform to industry standards
    /// defined in <a href="https://datatracker.ietf.org/doc/html/rfc2104">RFC 2104</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation is part of KMS support for HMAC KMS keys. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
    /// keys in KMS</a> in the <i>Key Management Service Developer Guide</i>.
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
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:VerifyMac</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b>: <a>GenerateMac</a> 
    /// </para>
    /// </summary>
    public partial class VerifyMacRequest : AmazonKeyManagementServiceRequest
    {
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private MemoryStream _mac;
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
        /// The KMS key that will be used in the verification.
        /// </para>
        ///  
        /// <para>
        /// Enter a key ID of the KMS key that was used to generate the HMAC. If you identify
        /// a different KMS key, the <code>VerifyMac</code> operation fails.
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
        /// Gets and sets the property Mac. 
        /// <para>
        /// The HMAC to verify. Enter the HMAC that was generated by the <a>GenerateMac</a> operation
        /// when you specified the same message, HMAC KMS key, and MAC algorithm as the values
        /// specified in this request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6144)]
        public MemoryStream Mac
        {
            get { return this._mac; }
            set { this._mac = value; }
        }

        // Check to see if Mac property is set
        internal bool IsSetMac()
        {
            return this._mac != null;
        }

        /// <summary>
        /// Gets and sets the property MacAlgorithm. 
        /// <para>
        /// The MAC algorithm that will be used in the verification. Enter the same MAC algorithm
        /// that was used to compute the HMAC. This algorithm must be supported by the HMAC KMS
        /// key identified by the <code>KeyId</code> parameter.
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
        /// The message that will be used in the verification. Enter the same message that was
        /// used to generate the HMAC.
        /// </para>
        ///  
        /// <para>
        ///  <a>GenerateMac</a> and <code>VerifyMac</code> do not provide special handling for
        /// message digests. If you generated an HMAC for a hash digest of a message, you must
        /// verify the HMAC for the same hash digest.
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

    }
}