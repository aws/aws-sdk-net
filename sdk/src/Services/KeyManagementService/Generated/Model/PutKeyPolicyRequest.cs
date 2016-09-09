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
    /// Container for the parameters to the PutKeyPolicy operation.
    /// Attaches a key policy to the specified customer master key (CMK).
    /// 
    ///  
    /// <para>
    /// For more information about key policies, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
    /// Policies</a> in the <i>AWS Key Management Service Developer Guide</i>.
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
        /// A flag to indicate whether to bypass the key policy lockout safety check.
        /// </para>
        ///  <important> 
        /// <para>
        /// Setting this value to true increases the likelihood that the CMK becomes unmanageable.
        /// Do not set this value to true indiscriminately.
        /// </para>
        ///  
        /// <para>
        /// For more information, refer to the scenario in the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default
        /// Key Policy</a> section in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use this parameter only when you intend to prevent the principal making the request
        /// from making a subsequent <code>PutKeyPolicy</code> request on the CMK.
        /// </para>
        ///  
        /// <para>
        /// The default value is false.
        /// </para>
        /// </summary>
        public bool BypassPolicyLockoutSafetyCheck
        {
            get { return this._bypassPolicyLockoutSafetyCheck.GetValueOrDefault(); }
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
        /// A unique identifier for the CMK.
        /// </para>
        ///  
        /// <para>
        /// Use the CMK's unique identifier or its Amazon Resource Name (ARN). For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Unique ID: 1234abcd-12ab-34cd-56ef-1234567890ab
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN: arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// The key policy to attach to the CMK.
        /// </para>
        ///  
        /// <para>
        /// If you do not set <code>BypassPolicyLockoutSafetyCheck</code> to true, the policy
        /// must meet the following criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It must allow the principal making the <code>PutKeyPolicy</code> request to make a
        /// subsequent <code>PutKeyPolicy</code> request on the CMK. This reduces the likelihood
        /// that the CMK becomes unmanageable. For more information, refer to the scenario in
        /// the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default
        /// Key Policy</a> section in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The principal(s) specified in the key policy must exist and be visible to AWS KMS.
        /// When you create a new AWS principal (for example, an IAM user or role), you might
        /// need to enforce a delay before specifying the new principal in a key policy because
        /// the new principal might not immediately be visible to AWS KMS. For more information,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes
        /// that I make are not always immediately visible</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The policy size limit is 32 KiB (32768 bytes).
        /// </para>
        /// </summary>
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
        /// The name of the key policy.
        /// </para>
        ///  
        /// <para>
        /// This value must be <code>default</code>.
        /// </para>
        /// </summary>
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