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
    /// Container for the parameters to the PutKeyPolicy operation.
    /// Attaches a key policy to the specified KMS key. 
    /// 
    ///  
    /// <para>
    /// For more information about key policies, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
    /// Policies</a> in the <i>Key Management Service Developer Guide</i>. For help writing
    /// and formatting a JSON policy document, see the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
    /// JSON Policy Reference</a> in the <i> <i>Identity and Access Management User Guide</i>
    /// </i>. For examples of adding a key policy in multiple programming languages, see <a
    /// href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_PutKeyPolicy_section.html">Use
    /// PutKeyPolicy with an Amazon Web Services SDK or CLI</a> in the <i>Key Management Service
    /// Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
    /// different Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:PutKeyPolicy</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b>: <a>GetKeyPolicy</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class PutKeyPolicyRequest : AmazonKeyManagementServiceRequest
    {
        private bool? _bypassPolicyLockoutSafetyCheck;
        private string _keyId;
        private string _policy;
        private string _policyName;

        /// <summary>
        /// Gets and sets the property BypassPolicyLockoutSafetyCheck. 
        /// <para>
        /// Skips ("bypasses") the key policy lockout safety check. The default value is false.
        /// </para>
        ///  <important> 
        /// <para>
        /// Setting this value to true increases the risk that the KMS key becomes unmanageable.
        /// Do not set this value to true indiscriminately.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policy-default.html#prevent-unmanageable-key">Default
        /// key policy</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use this parameter only when you intend to prevent the principal that is making the
        /// request from making a subsequent <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_PutKeyPolicy.html">PutKeyPolicy</a>
        /// request on the KMS key.
        /// </para>
        /// </summary>
        public bool? BypassPolicyLockoutSafetyCheck
        {
            get { return this._bypassPolicyLockoutSafetyCheck; }
            set { this._bypassPolicyLockoutSafetyCheck = value; }
        }

        // Check to see if BypassPolicyLockoutSafetyCheck property is set
        internal bool IsSetBypassPolicyLockoutSafetyCheck()
        {
            return this._bypassPolicyLockoutSafetyCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Sets the key policy on the specified KMS key.
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
        /// Gets and sets the property Policy. 
        /// <para>
        /// The key policy to attach to the KMS key.
        /// </para>
        ///  
        /// <para>
        /// The key policy must meet the following criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key policy must allow the calling principal to make a subsequent <c>PutKeyPolicy</c>
        /// request on the KMS key. This reduces the risk that the KMS key becomes unmanageable.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policy-default.html#prevent-unmanageable-key">Default
        /// key policy</a> in the <i>Key Management Service Developer Guide</i>. (To omit this
        /// condition, set <c>BypassPolicyLockoutSafetyCheck</c> to true.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each statement in the key policy must contain one or more principals. The principals
        /// in the key policy must exist and be visible to KMS. When you create a new Amazon Web
        /// Services principal, you might need to enforce a delay before including the new principal
        /// in a key policy because the new principal might not be immediately visible to KMS.
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes
        /// that I make are not always immediately visible</a> in the <i>Amazon Web Services Identity
        /// and Access Management User Guide</i>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If either of the required <c>Resource</c> or <c>Action</c> elements are missing from
        /// a key policy statement, the policy statement has no effect. When a key policy statement
        /// is missing one of these elements, the KMS console correctly reports an error, but
        /// the <c>PutKeyPolicy</c> API request succeeds, even though the policy statement is
        /// ineffective.
        /// </para>
        ///  
        /// <para>
        /// For more information on required key policy elements, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policy-overview.html#key-policy-elements">Elements
        /// in a key policy</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// A key policy document can include only the following characters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Printable ASCII characters from the space character (<c>\u0020</c>) through the end
        /// of the ASCII character range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <c>\u00FF</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The tab (<c>\u0009</c>), line feed (<c>\u000A</c>), and carriage return (<c>\u000D</c>)
        /// special characters
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If the key policy exceeds the length constraint, KMS returns a <c>LimitExceededException</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about key policies, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// policies in KMS</a> in the <i>Key Management Service Developer Guide</i>.For help
        /// writing and formatting a JSON policy document, see the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
        /// JSON Policy Reference</a> in the <i> <i>Identity and Access Management User Guide</i>
        /// </i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=131072)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the key policy. If no policy name is specified, the default value is <c>default</c>.
        /// The only valid value is <c>default</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

    }
}