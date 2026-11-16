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
    /// Container for the parameters to the GetKeyPolicy operation. Gets a key policy attached
    /// to the specified KMS key. <para> A KMS key can have two key policies. You manage the
    /// <c>default</c> key policy. Resource Access Manager (RAM) manages the <c>AWS_RAM</c>
    /// key policy for KMS keys that you share through RAM. You can use <c>GetKeyPolicy</c>
    /// to view the <c>AWS_RAM</c> key policy, but you can't change it with <a>PutKeyPolicy</a>.
    /// To get the <c>AWS_RAM</c> key policy, set the <c>PolicyName</c> parameter to <c>AWS_RAM</c>.
    /// If the KMS key doesn't have an <c>AWS_RAM</c> key policy, <c>GetKeyPolicy</c> returns
    /// a <c>NotFoundException</c>. For information about sharing KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-sharing-ram.html">Sharing
    /// KMS keys with RAM</a> in the <i>Key Management Service Developer Guide</i>. For information
    /// about RAM managed permissions, see <a href="https://docs.aws.amazon.com/ram/latest/userguide/security-ram-permissions.html">Managing
    /// permissions in RAM</a> in the <i>RAM User Guide</i>. </para> <para> <b>Cross-account
    /// use</b>: No. You cannot perform this operation on a KMS key in a different Amazon
    /// Web Services account. </para> <para> <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyPolicy</a>
    /// (key policy) </para> <para> You can use the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/conditions-kms.html#conditions-kms-policy-name">kms:PolicyName</a>
    /// condition key to control access to this operation based on the value of the <c>PolicyName</c>
    /// parameter in the request. If the request doesn't include <c>PolicyName</c>, the value
    /// of <c>kms:PolicyName</c> is <c>default</c>. </para> <para> <b>Related operations</b>:
    /// <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_PutKeyPolicy.html">PutKeyPolicy</a>
    /// </para> <para> <b>Eventual consistency</b>: The KMS API follows an eventual consistency
    /// model. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>. </para>
    /// </summary>
    public partial class GetKeyPolicyRequest : AmazonKeyManagementServiceRequest
    {
        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the KMS key whose key policy you want to get.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or key ARN of the KMS key.
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
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// Specifies the name of the key policy. If no policy name is specified, the default
        /// value is <c>default</c>. Valid values are <c>default</c> and <c>AWS_RAM</c>. Use <c>AWS_RAM</c>
        /// to get the key policy that RAM manages for a KMS key that you share through RAM. If
        /// the KMS key doesn't have an <c>AWS_RAM</c> key policy, the request fails with a <c>NotFoundException</c>.
        /// To get the names of key policies, use <a>ListKeyPolicies</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;
    }
}
