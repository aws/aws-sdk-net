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
    /// The configuration for a Secrets Manager secret. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_CreateSecret.html">CreateSecret</a>.
    /// 
    ///  
    /// <para>
    /// You can propose a configuration for a new secret or an existing secret that you own
    /// by specifying the secret policy and optional KMS encryption key. If the configuration
    /// is for an existing secret and you do not specify the secret policy, the access preview
    /// uses the existing policy for the secret. If the access preview is for a new resource
    /// and you do not specify the policy, the access preview assumes a secret without a policy.
    /// To propose deletion of an existing policy, you can specify an empty string. If the
    /// proposed configuration is for a new secret and you do not specify the KMS key ID,
    /// the access preview uses the Amazon Web Services managed key <c>aws/secretsmanager</c>.
    /// If you specify an empty string for the KMS key ID, the access preview uses the Amazon
    /// Web Services managed key of the Amazon Web Services account. For more information
    /// about secret policy limits, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_limits.html">Quotas
    /// for Secrets Manager.</a>.
    /// </para>
    /// </summary>
    public partial class SecretsManagerSecretConfiguration
    {
        private string _kmsKeyId;
        private string _secretPolicy;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The proposed ARN, key ID, or alias of the KMS key.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SecretPolicy. 
        /// <para>
        /// The proposed resource policy defining who can access or manage the secret.
        /// </para>
        /// </summary>
        public string SecretPolicy
        {
            get { return this._secretPolicy; }
            set { this._secretPolicy = value; }
        }

        // Check to see if SecretPolicy property is set
        internal bool IsSetSecretPolicy()
        {
            return this._secretPolicy != null;
        }

    }
}