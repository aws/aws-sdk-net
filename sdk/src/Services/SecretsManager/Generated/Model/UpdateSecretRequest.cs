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
    /// Container for the parameters to the UpdateSecret operation.
    /// Modifies the details of a secret, including metadata and the secret value. To change
    /// the secret value, you can also use <a>PutSecretValue</a>.
    /// 
    ///  
    /// <para>
    /// To change the rotation configuration of a secret, use <a>RotateSecret</a> instead.
    /// </para>
    ///  
    /// <para>
    /// To change a secret so that it is managed by another service, you need to recreate
    /// the secret in that service. See <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
    /// Manager secrets managed by other Amazon Web Services services</a>.
    /// </para>
    ///  
    /// <para>
    /// We recommend you avoid calling <code>UpdateSecret</code> at a sustained rate of more
    /// than once every 10 minutes. When you call <code>UpdateSecret</code> to update the
    /// secret value, Secrets Manager creates a new version of the secret. Secrets Manager
    /// removes outdated versions when there are more than 100, but it does not remove versions
    /// created less than 24 hours ago. If you update the secret value more than once every
    /// 10 minutes, you create more versions than Secrets Manager removes, and you will reach
    /// the quota for secret versions.
    /// </para>
    ///  
    /// <para>
    /// If you include <code>SecretString</code> or <code>SecretBinary</code> to create a
    /// new secret version, Secrets Manager automatically moves the staging label <code>AWSCURRENT</code>
    /// to the new version. Then it attaches the label <code>AWSPREVIOUS</code> to the version
    /// that <code>AWSCURRENT</code> was removed from.
    /// </para>
    ///  
    /// <para>
    /// If you call this operation with a <code>ClientRequestToken</code> that matches an
    /// existing version's <code>VersionId</code>, the operation results in an error. You
    /// can't modify an existing version, you can only create a new version. To remove a version,
    /// remove all staging labels from it. See <a>UpdateSecretVersionStage</a>.
    /// </para>
    ///  
    /// <para>
    /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
    /// include sensitive information in request parameters except <code>SecretBinary</code>
    /// or <code>SecretString</code> because it might be logged. For more information, see
    /// <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <code>secretsmanager:UpdateSecret</code>. For more
    /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. If you use a customer managed key, you
    /// must also have <code>kms:GenerateDataKey</code> and <code>kms:Decrypt</code> permissions
    /// on the key. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/security-encryption.html">
    /// Secret encryption and decryption</a>.
    /// </para>
    /// </summary>
    public partial class UpdateSecretRequest : AmazonSecretsManagerRequest
    {
        private string _clientRequestToken;
        private string _description;
        private string _kmsKeyId;
        private MemoryStream _secretBinary;
        private string _secretId;
        private string _secretString;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// If you include <code>SecretString</code> or <code>SecretBinary</code>, then Secrets
        /// Manager creates a new version for the secret, and this parameter specifies the unique
        /// identifier for the new version.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you use the Amazon Web Services CLI or one of the Amazon Web Services SDKs to call
        /// this operation, then you can leave this parameter empty. The CLI or SDK generates
        /// a random UUID for you and includes it as the value for this parameter in the request.
        /// If you don't use the SDK and instead generate a raw HTTP request to the Secrets Manager
        /// service endpoint, then you must generate a <code>ClientRequestToken</code> yourself
        /// for the new version and include the value in the request.
        /// </para>
        ///  </note> 
        /// <para>
        /// This value becomes the <code>VersionId</code> of the new version.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN, key ID, or alias of the KMS key that Secrets Manager uses to encrypt new
        /// secret versions as well as any existing versions with the staging labels <code>AWSCURRENT</code>,
        /// <code>AWSPENDING</code>, or <code>AWSPREVIOUS</code>. For more information about versions
        /// and staging labels, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/getting-started.html#term_version">Concepts:
        /// Version</a>.
        /// </para>
        ///  
        /// <para>
        /// A key alias is always prefixed by <code>alias/</code>, for example <code>alias/aws/secretsmanager</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/alias-about.html">About
        /// aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// If you set this to an empty string, Secrets Manager uses the Amazon Web Services managed
        /// key <code>aws/secretsmanager</code>. If this key doesn't already exist in your account,
        /// then Secrets Manager creates it for you automatically. All users and roles in the
        /// Amazon Web Services account automatically have access to use <code>aws/secretsmanager</code>.
        /// Creating <code>aws/secretsmanager</code> can result in a one-time significant delay
        /// in returning the result. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can only use the Amazon Web Services managed key <code>aws/secretsmanager</code>
        /// if you call this operation using credentials from the same Amazon Web Services account
        /// that owns the secret. If the secret is in a different account, then you must use a
        /// customer managed key and provide the ARN of that KMS key in this field. The user making
        /// the call must have permissions to both the secret and the KMS key in their respective
        /// accounts.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property SecretBinary. 
        /// <para>
        /// The binary data to encrypt and store in the new version of the secret. We recommend
        /// that you store your binary data in a file and then pass the contents of the file as
        /// a parameter. 
        /// </para>
        ///  
        /// <para>
        /// Either <code>SecretBinary</code> or <code>SecretString</code> must have a value, but
        /// not both.
        /// </para>
        ///  
        /// <para>
        /// You can't access this parameter in the Secrets Manager console.
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
        /// The ARN or name of the secret.
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
        /// Gets and sets the property SecretString. 
        /// <para>
        /// The text data to encrypt and store in the new version of the secret. We recommend
        /// you use a JSON structure of key/value pairs for your secret value. 
        /// </para>
        ///  
        /// <para>
        /// Either <code>SecretBinary</code> or <code>SecretString</code> must have a value, but
        /// not both. 
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

    }
}