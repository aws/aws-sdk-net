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
    /// Container for the parameters to the CreateSecret operation.
    /// Creates a new secret. A <i>secret</i> can be a password, a set of credentials such
    /// as a user name and password, an OAuth token, or other secret information that you
    /// store in an encrypted form in Secrets Manager. The secret also includes the connection
    /// information to access a database or other service, which Secrets Manager doesn't encrypt.
    /// A secret in Secrets Manager consists of both the protected secret data and the important
    /// information needed to manage the secret.
    /// 
    ///  
    /// <para>
    /// For secrets that use <i>managed rotation</i>, you need to create the secret through
    /// the managing service. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
    /// Manager secrets managed by other Amazon Web Services services</a>. 
    /// </para>
    ///  
    /// <para>
    /// For information about creating a secret in the console, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/manage_create-basic-secret.html">Create
    /// a secret</a>.
    /// </para>
    ///  
    /// <para>
    /// To create a secret, you can provide the secret value to be encrypted in either the
    /// <code>SecretString</code> parameter or the <code>SecretBinary</code> parameter, but
    /// not both. If you include <code>SecretString</code> or <code>SecretBinary</code> then
    /// Secrets Manager creates an initial secret version and automatically attaches the staging
    /// label <code>AWSCURRENT</code> to it.
    /// </para>
    ///  
    /// <para>
    /// For database credentials you want to rotate, for Secrets Manager to be able to rotate
    /// the secret, you must make sure the JSON you store in the <code>SecretString</code>
    /// matches the <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_secret_json_structure.html">JSON
    /// structure of a database secret</a>.
    /// </para>
    ///  
    /// <para>
    /// If you don't specify an KMS encryption key, Secrets Manager uses the Amazon Web Services
    /// managed key <code>aws/secretsmanager</code>. If this key doesn't already exist in
    /// your account, then Secrets Manager creates it for you automatically. All users and
    /// roles in the Amazon Web Services account automatically have access to use <code>aws/secretsmanager</code>.
    /// Creating <code>aws/secretsmanager</code> can result in a one-time significant delay
    /// in returning the result.
    /// </para>
    ///  
    /// <para>
    /// If the secret is in a different Amazon Web Services account from the credentials calling
    /// the API, then you can't use <code>aws/secretsmanager</code> to encrypt the secret,
    /// and you must create and use a customer managed KMS key. 
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
    ///  <b>Required permissions: </b> <code>secretsmanager:CreateSecret</code>. If you include
    /// tags in the secret, you also need <code>secretsmanager:TagResource</code>. For more
    /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
    ///  
    /// <para>
    /// To encrypt the secret with a KMS key other than <code>aws/secretsmanager</code>, you
    /// need <code>kms:GenerateDataKey</code> and <code>kms:Decrypt</code> permission to the
    /// key. 
    /// </para>
    /// </summary>
    public partial class CreateSecretRequest : AmazonSecretsManagerRequest
    {
        private List<ReplicaRegionType> _addReplicaRegions = new List<ReplicaRegionType>();
        private string _clientRequestToken;
        private string _description;
        private bool? _forceOverwriteReplicaSecret;
        private string _kmsKeyId;
        private string _name;
        private MemoryStream _secretBinary;
        private string _secretString;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AddReplicaRegions. 
        /// <para>
        /// A list of Regions and KMS keys to replicate secrets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// If you include <code>SecretString</code> or <code>SecretBinary</code>, then Secrets
        /// Manager creates an initial version for the secret, and this parameter specifies the
        /// unique identifier for the new version. 
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
        /// This value helps ensure idempotency. Secrets Manager uses this value to prevent the
        /// accidental creation of duplicate versions if there are failures and retries during
        /// a rotation. We recommend that you generate a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type</a>
        /// value to ensure uniqueness of your versions within the specified secret. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the <code>ClientRequestToken</code> value isn't already associated with a version
        /// of the secret then a new version of the secret is created. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a version with this value already exists and the version <code>SecretString</code>
        /// and <code>SecretBinary</code> values are the same as those in the request, then the
        /// request is ignored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a version with this value already exists and that version's <code>SecretString</code>
        /// and <code>SecretBinary</code> values are different from those in the request, then
        /// the request fails because you cannot modify an existing version. Instead, use <a>PutSecretValue</a>
        /// to create a new version.
        /// </para>
        ///  </li> </ul> 
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN, key ID, or alias of the KMS key that Secrets Manager uses to encrypt the
        /// secret value in the secret. An alias is always prefixed by <code>alias/</code>, for
        /// example <code>alias/aws/secretsmanager</code>. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/alias-about.html">About
        /// aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// To use a KMS key in a different account, use the key ARN or the alias ARN.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this value, then Secrets Manager uses the key <code>aws/secretsmanager</code>.
        /// If that key doesn't yet exist, then Secrets Manager creates it for you automatically
        /// the first time it encrypts the secret value.
        /// </para>
        ///  
        /// <para>
        /// If the secret is in a different Amazon Web Services account from the credentials calling
        /// the API, then you can't use <code>aws/secretsmanager</code> to encrypt the secret,
        /// and you must create and use a customer managed KMS key. 
        /// </para>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new secret.
        /// </para>
        ///  
        /// <para>
        /// The secret name can contain ASCII letters, numbers, and the following characters:
        /// /_+=.@-
        /// </para>
        ///  
        /// <para>
        /// Do not end your secret name with a hyphen followed by six characters. If you do so,
        /// you risk confusion and unexpected results when searching for a secret by partial ARN.
        /// Secrets Manager automatically adds a hyphen and six random characters after the secret
        /// name at the end of the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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
        /// Either <code>SecretString</code> or <code>SecretBinary</code> must have a value, but
        /// not both.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not available in the Secrets Manager console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
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
        /// Gets and sets the property SecretString. 
        /// <para>
        /// The text data to encrypt and store in this new version of the secret. We recommend
        /// you use a JSON structure of key/value pairs for your secret value.
        /// </para>
        ///  
        /// <para>
        /// Either <code>SecretString</code> or <code>SecretBinary</code> must have a value, but
        /// not both.
        /// </para>
        ///  
        /// <para>
        /// If you create a secret by using the Secrets Manager console then Secrets Manager puts
        /// the protected secret text in only the <code>SecretString</code> parameter. The Secrets
        /// Manager console stores the information as a JSON structure of key/value pairs that
        /// a Lambda rotation function can parse.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to attach to the secret. Each tag is a key and value pair of strings
        /// in a JSON text string, for example:
        /// </para>
        ///  
        /// <para>
        ///  <code>[{"Key":"CostCenter","Value":"12345"},{"Key":"environment","Value":"production"}]</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager tag key names are case sensitive. A tag with the key "ABC" is a different
        /// tag from one with key "abc".
        /// </para>
        ///  
        /// <para>
        /// If you check tags in permissions policies as part of your security strategy, then
        /// adding or removing a tag can change permissions. If the completion of this operation
        /// would result in you losing your permissions for this secret, then Secrets Manager
        /// blocks the operation and returns an <code>Access Denied</code> error. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_examples.html#tag-secrets-abac">Control
        /// access to secrets using tags</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_examples.html#auth-and-access_tags2">Limit
        /// access to identities with tags that match secrets' tags</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about how to format a JSON parameter for the various command line
        /// tool environments, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#cli-using-param-json">Using
        /// JSON for Parameters</a>. If your command-line tool or SDK requires quotation marks
        /// around the parameter, you should use single quotes to avoid confusion with the double
        /// quotes required in the JSON text.
        /// </para>
        ///  
        /// <para>
        /// The following restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per secret: 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length: 127 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length: 255 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use the <code>aws:</code> prefix in your tag names or values because Amazon
        /// Web Services reserves it for Amazon Web Services use. You can't edit or delete tag
        /// names or values with this prefix. Tags with this prefix do not count against your
        /// tags per secret limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use your tagging schema across multiple services and resources, other services
        /// might have restrictions on allowed characters. Generally allowed characters: letters,
        /// spaces, and numbers representable in UTF-8, plus the following special characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> </ul>
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