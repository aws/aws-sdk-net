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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Attaches tags to a secret. Tags consist of a key name and a value. Tags are part of
    /// the secret's metadata. They are not associated with specific versions of the secret.
    /// This operation appends tags to the existing list of tags.
    /// 
    ///  
    /// <para>
    /// For tag quotas and naming restrictions, see <a href="https://docs.aws.amazon.com/general/latest/gr/arg.html#taged-reference-quotas">Service
    /// quotas for Tagging</a> in the <i>Amazon Web Services General Reference guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you use tags as part of your security strategy, then adding or removing a tag can
    /// change permissions. If successfully completing this operation would result in you
    /// losing your permissions for this secret, then the operation is blocked and returns
    /// an Access Denied error.
    /// </para>
    ///  </important> 
    /// <para>
    /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
    /// include sensitive information in request parameters because it might be logged. For
    /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>secretsmanager:TagResource</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonSecretsManagerRequest
    {
        private string _secretId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The identifier for the secret to attach tags to. You can specify either the Amazon
        /// Resource Name (ARN) or the friendly name of the secret.
        /// </para>
        ///  
        /// <para>
        /// For an ARN, we recommend that you specify a complete ARN rather than a partial ARN.
        /// See <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/troubleshoot.html#ARN_secretnamehyphen">Finding
        /// a secret from a partial ARN</a>.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to attach to the secret as a JSON text string argument. Each element in the
        /// list consists of a <c>Key</c> and a <c>Value</c>.
        /// </para>
        ///  
        /// <para>
        /// For storing multiple values, we recommend that you use a JSON text string argument
        /// and specify key/value pairs. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters.html">Specifying
        /// parameter values for the Amazon Web Services CLI</a> in the Amazon Web Services CLI
        /// User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}