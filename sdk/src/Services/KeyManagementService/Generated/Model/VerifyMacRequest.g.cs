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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the VerifyMac operation. Verifies the hash-based message
    /// authentication code (HMAC) for a specified message, HMAC KMS key, and MAC algorithm.
    /// To verify the HMAC, <c>VerifyMac</c> computes an HMAC using the message, HMAC KMS
    /// key, and MAC algorithm that you specify, and compares the computed HMAC to the HMAC
    /// that you specify. If the HMACs are identical, the verification succeeds; otherwise,
    /// it fails. Verification indicates that the message hasn't changed since the HMAC was
    /// calculated, and the specified key was used to generate and verify the HMAC. <para>
    /// HMAC KMS keys and the HMAC algorithms that KMS uses conform to industry standards
    /// defined in <a href="https://datatracker.ietf.org/doc/html/rfc2104">RFC 2104</a>. </para>
    /// <para> This operation is part of KMS support for HMAC KMS keys. For details, see <a
    /// href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC keys in
    /// KMS</a> in the <i>Key Management Service Developer Guide</i>. </para> <para> The KMS
    /// key that you use for this operation must be in a compatible key state. For details,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>. </para>
    /// <para> <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in
    /// a different Amazon Web Services account, specify the key ARN or alias ARN in the value
    /// of the <c>KeyId</c> parameter. </para> <para> <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:VerifyMac</a>
    /// (key policy) </para> <para> <b>Related operations</b>: <a>GenerateMac</a> </para>
    /// <para> <b>Eventual consistency</b>: The KMS API follows an eventual consistency model.
    /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>. </para>
    /// </summary>
    public partial class VerifyMacRequest : AmazonKeyManagementServiceRequest
    {
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
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> GrantTokens { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GrantTokens property is set.
        /// </summary>
        internal bool IsSetGrantTokens() => this.GrantTokens != null && (this.GrantTokens.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The KMS key that will be used in the verification.
        /// </para>
        ///  
        /// <para>
        /// Enter a key ID of the KMS key that was used to generate the HMAC. If you identify
        /// a different KMS key, the <c>VerifyMac</c> operation fails.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property Mac. 
        /// <para>
        /// The HMAC to verify. Enter the HMAC that was generated by the <a>GenerateMac</a> operation
        /// when you specified the same message, HMAC KMS key, and MAC algorithm as the values
        /// specified in this request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 6144)]
        public MemoryStream Mac { get; set; }

        /// <summary>
        /// Checks to see if the Mac property is set.
        /// </summary>
        internal bool IsSetMac() => this.Mac != null;

        /// <summary>
        /// Gets and sets the property MacAlgorithm. 
        /// <para>
        /// The MAC algorithm that will be used in the verification. Enter the same MAC algorithm
        /// that was used to compute the HMAC. This algorithm must be supported by the HMAC KMS
        /// key identified by the <c>KeyId</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MacAlgorithmSpec MacAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the MacAlgorithm property is set.
        /// </summary>
        internal bool IsSetMacAlgorithm() => this.MacAlgorithm != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message that will be used in the verification. Enter the same message that was
        /// used to generate the HMAC.
        /// </para>
        ///  
        /// <para>
        ///  <a>GenerateMac</a> and <c>VerifyMac</c> do not provide special handling for message
        /// digests. If you generated an HMAC for a hash digest of a message, you must verify
        /// the HMAC for the same hash digest.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4096)]
        public MemoryStream Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
