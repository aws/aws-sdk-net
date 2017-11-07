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
    /// Container for the parameters to the CreateKey operation.
    /// Creates a customer master key (CMK) in the caller's AWS account.
    /// 
    ///  
    /// <para>
    /// You can use a CMK to encrypt small amounts of data (4 KiB or less) directly, but CMKs
    /// are more commonly used to encrypt data encryption keys (DEKs), which are used to encrypt
    /// raw data. For more information about DEKs and the difference between CMKs and DEKs,
    /// see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <a>GenerateDataKey</a> operation
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html">AWS
    /// Key Management Service Concepts</a> in the <i>AWS Key Management Service Developer
    /// Guide</i> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You cannot use this operation to create a CMK in a different AWS account.
    /// </para>
    /// </summary>
    public partial class CreateKeyRequest : AmazonKeyManagementServiceRequest
    {
        private bool? _bypassPolicyLockoutSafetyCheck;
        private string _description;
        private KeyUsageType _keyUsage;
        private OriginType _origin;
        private string _policy;
        private List<Tag> _tags = new List<Tag>();

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
        /// Use this parameter only when you include a policy in the request and you intend to
        /// prevent the principal that is making the request from making a subsequent <a>PutKeyPolicy</a>
        /// request on the CMK.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the CMK.
        /// </para>
        ///  
        /// <para>
        /// Use a description that helps you decide whether the CMK is appropriate for a task.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// The intended use of the CMK.
        /// </para>
        ///  
        /// <para>
        /// You can use CMKs only for symmetric encryption and decryption.
        /// </para>
        /// </summary>
        public KeyUsageType KeyUsage
        {
            get { return this._keyUsage; }
            set { this._keyUsage = value; }
        }

        // Check to see if KeyUsage property is set
        internal bool IsSetKeyUsage()
        {
            return this._keyUsage != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// The source of the CMK's key material.
        /// </para>
        ///  
        /// <para>
        /// The default is <code>AWS_KMS</code>, which means AWS KMS creates the key material.
        /// When this parameter is set to <code>EXTERNAL</code>, the request creates a CMK without
        /// key material so that you can import key material from your existing key management
        /// infrastructure. For more information about importing key material into AWS KMS, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK's <code>Origin</code> is immutable and is set when the CMK is created.
        /// </para>
        /// </summary>
        public OriginType Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The key policy to attach to the CMK.
        /// </para>
        ///  
        /// <para>
        /// If you specify a policy and do not set <code>BypassPolicyLockoutSafetyCheck</code>
        /// to true, the policy must meet the following criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It must allow the principal that is making the <code>CreateKey</code> request to make
        /// a subsequent <a>PutKeyPolicy</a> request on the CMK. This reduces the likelihood that
        /// the CMK becomes unmanageable. For more information, refer to the scenario in the <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default
        /// Key Policy</a> section in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The principals that are specified in the key policy must exist and be visible to AWS
        /// KMS. When you create a new AWS principal (for example, an IAM user or role), you might
        /// need to enforce a delay before specifying the new principal in a key policy because
        /// the new principal might not immediately be visible to AWS KMS. For more information,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes
        /// that I make are not always immediately visible</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you do not specify a policy, AWS KMS attaches a default key policy to the CMK.
        /// For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default">Default
        /// Key Policy</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The policy size limit is 32 kilobytes (32768 bytes).
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags. Each tag consists of a tag key and a tag value. Tag keys and tag
        /// values are both required, but tag values can be empty (null) strings.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter to tag the CMK when it is created. Alternately, you can omit this
        /// parameter and instead tag the CMK after it is created using <a>TagResource</a>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}