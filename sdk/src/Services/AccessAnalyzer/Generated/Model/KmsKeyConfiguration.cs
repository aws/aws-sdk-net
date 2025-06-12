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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Proposed access control configuration for a KMS key. You can propose a configuration
    /// for a new KMS key or an existing KMS key that you own by specifying the key policy
    /// and KMS grant configuration. If the configuration is for an existing key and you do
    /// not specify the key policy, the access preview uses the existing policy for the key.
    /// If the access preview is for a new resource and you do not specify the key policy,
    /// then the access preview uses the default key policy. The proposed key policy cannot
    /// be an empty string. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default">Default
    /// key policy</a>. For more information about key policy limits, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/resource-limits.html">Resource
    /// quotas</a>.
    /// </summary>
    public partial class KmsKeyConfiguration
    {
        private List<KmsGrantConfiguration> _grants = AWSConfigs.InitializeCollections ? new List<KmsGrantConfiguration>() : null;
        private Dictionary<string, string> _keyPolicies = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Grants. 
        /// <para>
        /// A list of proposed grant configurations for the KMS key. If the proposed grant configuration
        /// is for an existing key, the access preview uses the proposed list of grant configurations
        /// in place of the existing grants. Otherwise, the access preview uses the existing grants
        /// for the key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KmsGrantConfiguration> Grants
        {
            get { return this._grants; }
            set { this._grants = value; }
        }

        // Check to see if Grants property is set
        internal bool IsSetGrants()
        {
            return this._grants != null && (this._grants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyPolicies. 
        /// <para>
        /// Resource policy configuration for the KMS key. The only valid value for the name of
        /// the key policy is <c>default</c>. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default">Default
        /// key policy</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> KeyPolicies
        {
            get { return this._keyPolicies; }
            set { this._keyPolicies = value; }
        }

        // Check to see if KeyPolicies property is set
        internal bool IsSetKeyPolicies()
        {
            return this._keyPolicies != null && (this._keyPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}