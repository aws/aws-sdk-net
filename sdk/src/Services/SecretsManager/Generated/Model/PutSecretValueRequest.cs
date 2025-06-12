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
    /// Container for the parameters to the PutSecretValue operation.
    /// Creates a new version with a new encrypted secret value and attaches it to the secret.
    /// The version can contain a new <c>SecretString</c> value or a new <c>SecretBinary</c>
    /// value. 
    /// 
    ///  
    /// <para>
    /// We recommend you avoid calling <c>PutSecretValue</c> at a sustained rate of more than
    /// once every 10 minutes. When you update the secret value, Secrets Manager creates a
    /// new version of the secret. Secrets Manager removes outdated versions when there are
    /// more than 100, but it does not remove versions created less than 24 hours ago. If
    /// you call <c>PutSecretValue</c> more than once every 10 minutes, you create more versions
    /// than Secrets Manager removes, and you will reach the quota for secret versions.
    /// </para>
    ///  
    /// <para>
    /// You can specify the staging labels to attach to the new version in <c>VersionStages</c>.
    /// If you don't include <c>VersionStages</c>, then Secrets Manager automatically moves
    /// the staging label <c>AWSCURRENT</c> to this version. If this operation creates the
    /// first version for the secret, then Secrets Manager automatically attaches the staging
    /// label <c>AWSCURRENT</c> to it. If this operation moves the staging label <c>AWSCURRENT</c>
    /// from another version to this version, then Secrets Manager also automatically moves
    /// the staging label <c>AWSPREVIOUS</c> to the version that <c>AWSCURRENT</c> was removed
    /// from.
    /// </para>
    ///  
    /// <para>
    /// This operation is idempotent. If you call this operation with a <c>ClientRequestToken</c>
    /// that matches an existing version's VersionId, and you specify the same secret data,
    /// the operation succeeds but does nothing. However, if the secret data is different,
    /// then the operation fails because you can't modify an existing version; you can only
    /// create new ones.
    /// </para>
    ///  
    /// <para>
    /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
    /// include sensitive information in request parameters except <c>SecretBinary</c>, <c>SecretString</c>,
    /// or <c>RotationToken</c> because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>secretsmanager:PutSecretValue</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
    ///  <important> 
    /// <para>
    /// When you enter commands in a command shell, there is a risk of the command history
    /// being accessed or utilities having access to your command parameters. This is a concern
    /// if the command includes the value of a secret. Learn how to <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/security_cli-exposure-risks.html">Mitigate
    /// the risks of using command-line tools to store Secrets Manager secrets</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutSecretValueRequest : AmazonSecretsManagerRequest
    {
        private string _clientRequestToken;
        private string _rotationToken;
        private MemoryStream _secretBinary;
        private string _secretId;
        private string _secretString;
        private List<string> _versionStages = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for the new version of the secret. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you use the Amazon Web Services CLI or one of the Amazon Web Services SDKs to call
        /// this operation, then you can leave this parameter empty. The CLI or SDK generates
        /// a random UUID for you and includes it as the value for this parameter in the request.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// If you generate a raw HTTP request to the Secrets Manager service endpoint, then you
        /// must generate a <c>ClientRequestToken</c> and include it in the request.
        /// </para>
        ///  
        /// <para>
        /// This value helps ensure idempotency. Secrets Manager uses this value to prevent the
        /// accidental creation of duplicate versions if there are failures and retries during
        /// a rotation. We recommend that you generate a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type</a>
        /// value to ensure uniqueness of your versions within the specified secret. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the <c>ClientRequestToken</c> value isn't already associated with a version of
        /// the secret then a new version of the secret is created. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a version with this value already exists and that version's <c>SecretString</c>
        /// or <c>SecretBinary</c> values are the same as those in the request then the request
        /// is ignored. The operation is idempotent. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a version with this value already exists and the version of the <c>SecretString</c>
        /// and <c>SecretBinary</c> values are different from those in the request, then the request
        /// fails because you can't modify a secret version. You can only create new versions
        /// to store new secret values.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This value becomes the <c>VersionId</c> of the new version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property RotationToken. 
        /// <para>
        /// A unique identifier that indicates the source of the request. For cross-account rotation
        /// (when you rotate a secret in one account by using a Lambda rotation function in another
        /// account) and the Lambda rotation function assumes an IAM role to call Secrets Manager,
        /// Secrets Manager validates the identity with the rotation token. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotating-secrets.html">How
        /// rotation works</a>.
        /// </para>
        ///  
        /// <para>
        /// Sensitive: This field contains sensitive information, so the service does not include
        /// it in CloudTrail log entries. If you create your own log entries, you must also avoid
        /// logging the information in this field.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=36, Max=256)]
        public string RotationToken
        {
            get { return this._rotationToken; }
            set { this._rotationToken = value; }
        }

        // Check to see if RotationToken property is set
        internal bool IsSetRotationToken()
        {
            return this._rotationToken != null;
        }

        /// <summary>
        /// Gets and sets the property SecretBinary. 
        /// <para>
        /// The binary data to encrypt and store in the new version of the secret. To use this
        /// parameter in the command-line tools, we recommend that you store your binary data
        /// in a file and then pass the contents of the file as a parameter. 
        /// </para>
        ///  
        /// <para>
        /// You must include <c>SecretBinary</c> or <c>SecretString</c>, but not both.
        /// </para>
        ///  
        /// <para>
        /// You can't access this value from the Secrets Manager console.
        /// </para>
        ///  
        /// <para>
        /// Sensitive: This field contains sensitive information, so the service does not include
        /// it in CloudTrail log entries. If you create your own log entries, you must also avoid
        /// logging the information in this field.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=65536)]
        public MemoryStream SecretBinary
        {
            get { return this._secretBinary; }
            set { this._secretBinary = value; }
        }

        // Check to see if SecretBinary property is set
        internal bool IsSetSecretBinary()
        {
            return this._secretBinary != null;
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the secret to add a new version to.
        /// </para>
        ///  
        /// <para>
        /// For an ARN, we recommend that you specify a complete ARN rather than a partial ARN.
        /// See <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/troubleshoot.html#ARN_secretnamehyphen">Finding
        /// a secret from a partial ARN</a>.
        /// </para>
        ///  
        /// <para>
        /// If the secret doesn't already exist, use <c>CreateSecret</c> instead.
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
        /// Gets and sets the property SecretString. 
        /// <para>
        /// The text to encrypt and store in the new version of the secret. 
        /// </para>
        ///  
        /// <para>
        /// You must include <c>SecretBinary</c> or <c>SecretString</c>, but not both.
        /// </para>
        ///  
        /// <para>
        /// We recommend you create the secret string as JSON key/value pairs, as shown in the
        /// example.
        /// </para>
        ///  
        /// <para>
        /// Sensitive: This field contains sensitive information, so the service does not include
        /// it in CloudTrail log entries. If you create your own log entries, you must also avoid
        /// logging the information in this field.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=65536)]
        public string SecretString
        {
            get { return this._secretString; }
            set { this._secretString = value; }
        }

        // Check to see if SecretString property is set
        internal bool IsSetSecretString()
        {
            return this._secretString != null;
        }

        /// <summary>
        /// Gets and sets the property VersionStages. 
        /// <para>
        /// A list of staging labels to attach to this version of the secret. Secrets Manager
        /// uses staging labels to track versions of a secret through the rotation process.
        /// </para>
        ///  
        /// <para>
        /// If you specify a staging label that's already associated with a different version
        /// of the same secret, then Secrets Manager removes the label from the other version
        /// and attaches it to this version. If you specify <c>AWSCURRENT</c>, and it is already
        /// attached to another version, then Secrets Manager also moves the staging label <c>AWSPREVIOUS</c>
        /// to the version that <c>AWSCURRENT</c> was removed from.
        /// </para>
        ///  
        /// <para>
        /// If you don't include <c>VersionStages</c>, then Secrets Manager automatically moves
        /// the staging label <c>AWSCURRENT</c> to this version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> VersionStages
        {
            get { return this._versionStages; }
            set { this._versionStages = value; }
        }

        // Check to see if VersionStages property is set
        internal bool IsSetVersionStages()
        {
            return this._versionStages != null && (this._versionStages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}