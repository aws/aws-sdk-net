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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the ReplicateSecretToRegions operation.
    /// Replicates the secret to a new Regions. See <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/create-manage-multi-region-secrets.html">Multi-Region
    /// secrets</a>.
    /// 
    ///  
    /// <para>
    /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
    /// include sensitive information in request parameters because it might be logged. For
    /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <code>secretsmanager:ReplicateSecretToRegions</code>.
    /// For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
    /// </summary>
    public partial class ReplicateSecretToRegionsRequest : AmazonSecretsManagerRequest
    {
        private List<ReplicaRegionType> _addReplicaRegions = new List<ReplicaRegionType>();
        private bool? _forceOverwriteReplicaSecret;
        private string _secretId;

        /// <summary>
        /// Gets and sets the property AddReplicaRegions. 
        /// <para>
        /// A list of Regions in which to replicate the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<ReplicaRegionType> AddReplicaRegions
        {
            get { return this._addReplicaRegions; }
            set { this._addReplicaRegions = value; }
        }

        // Check to see if AddReplicaRegions property is set
        internal bool IsSetAddReplicaRegions()
        {
            return this._addReplicaRegions != null && this._addReplicaRegions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ForceOverwriteReplicaSecret. 
        /// <para>
        /// Specifies whether to overwrite a secret with the same name in the destination Region.
        /// </para>
        /// </summary>
        public bool ForceOverwriteReplicaSecret
        {
            get { return this._forceOverwriteReplicaSecret.GetValueOrDefault(); }
            set { this._forceOverwriteReplicaSecret = value; }
        }

        // Check to see if ForceOverwriteReplicaSecret property is set
        internal bool IsSetForceOverwriteReplicaSecret()
        {
            return this._forceOverwriteReplicaSecret.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the secret to replicate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string SecretId
        {
            get { return this._secretId; }
            set { this._secretId = value; }
        }

        // Check to see if SecretId property is set
        internal bool IsSetSecretId()
        {
            return this._secretId != null;
        }

    }
}