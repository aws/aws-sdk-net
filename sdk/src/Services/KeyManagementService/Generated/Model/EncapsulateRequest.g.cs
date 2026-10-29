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
    /// Container for the parameters to the Encapsulate operation. Generates a shared secret
    /// and its encapsulated (ciphertext) form using the public key of an ML-KEM KMS key pair.
    /// Module-Lattice-Based Key-Encapsulation Mechanism (ML-KEM), specified in <a href="https://csrc.nist.gov/pubs/fips/203/final">FIPS
    /// 203</a> on the NIST website, is a post-quantum algorithm for establishing a shared
    /// secret between two parties. <para> For an example of how two parties establish a shared
    /// secret over an insecure channel using ML-KEM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/pqkeys.html#mlkem">ML-KEM
    /// keys in KMS</a> in the <i>Key Management Service Developer Guide</i>. </para> <para>
    /// The Encapsulate operation is not available in China Regions. </para> <para> The KMS
    /// key that you use for this operation must be in a compatible key state. For details,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>. </para>
    /// <para> <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in
    /// a different Amazon Web Services account, specify the key ARN or alias ARN in the value
    /// of the <c>KeyId</c> parameter. </para> <para> <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Encapsulate</a>
    /// (key policy) </para> <para> <b>Related operations:</b> </para> <ul> <li> <para> <a>Decapsulate</a>
    /// </para> </li> <li> <para> <a>DeriveSharedSecret</a> </para> </li> <li> <para> <a>CreateKey</a>
    /// </para> </li> <li> <para> <a>GetPublicKey</a> </para> </li> <li> <para> <a>DescribeKey</a>
    /// </para> </li> </ul> <para> <b>Eventual consistency</b>: The KMS API follows an eventual
    /// consistency model. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>. </para>
    /// </summary>
    public partial class EncapsulateRequest : AmazonKeyManagementServiceRequest
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
        /// Gets and sets the property EncapsulationAlgorithm. 
        /// <para>
        /// Specifies the key encapsulation algorithm used to generate the shared secret and its
        /// encapsulated form. The only valid value is <c>ML_KEM</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncapsulationAlgorithmSpec EncapsulationAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the EncapsulationAlgorithm property is set.
        /// </summary>
        internal bool IsSetEncapsulationAlgorithm() => this.EncapsulationAlgorithm != null;

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
        /// Identifies an asymmetric ML-KEM KMS key. KMS uses the public key in the specified
        /// key pair to encapsulate the shared secret. ML-KEM KMS keys have a <c>KeySpec</c> value
        /// of <c>ML_KEM_512</c>, <c>ML_KEM_768</c>, or <c>ML_KEM_1024</c> and a <c>KeyUsage</c>
        /// value of <c>ENCAPSULATE_DECAPSULATE</c>. To find the <c>KeySpec</c> and <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
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
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;
    }
}
