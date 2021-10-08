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
    /// Container for the parameters to the PutSecretValue operation.
    /// Stores a new encrypted secret value in the specified secret. To do this, the operation
    /// creates a new version and attaches it to the secret. The version can contain a new
    /// <code>SecretString</code> value or a new <code>SecretBinary</code> value. You can
    /// also specify the staging labels that are initially attached to the new version.
    /// 
    ///  
    /// <para>
    /// We recommend you avoid calling <code>PutSecretValue</code> at a sustained rate of
    /// more than once every 10 minutes. When you update the secret value, Secrets Manager
    /// creates a new version of the secret. Secrets Manager removes outdated versions when
    /// there are more than 100, but it does not remove versions created less than 24 hours
    /// ago. If you call <code>PutSecretValue</code> more than once every 10 minutes, you
    /// create more versions than Secrets Manager removes, and you will reach the quota for
    /// secret versions.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If this operation creates the first version for the secret then Secrets Manager automatically
    /// attaches the staging label <code>AWSCURRENT</code> to the new version.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you do not specify a value for VersionStages then Secrets Manager automatically
    /// moves the staging label <code>AWSCURRENT</code> to this new version.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If this operation moves the staging label <code>AWSCURRENT</code> from another version
    /// to this version, then Secrets Manager also automatically moves the staging label <code>AWSPREVIOUS</code>
    /// to the version that <code>AWSCURRENT</code> was removed from.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This operation is idempotent. If a version with a <code>VersionId</code> with the
    /// same value as the <code>ClientRequestToken</code> parameter already exists and you
    /// specify the same secret data, the operation succeeds but does nothing. However, if
    /// the secret data is different, then the operation fails because you cannot modify an
    /// existing version; you can only create new ones.
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    /// If you call an operation to encrypt or decrypt the <code>SecretString</code> or <code>SecretBinary</code>
    /// for a secret in the same account as the calling user and that secret doesn't specify
    /// a Amazon Web Services KMS encryption key, Secrets Manager uses the account's default
    /// Amazon Web Services managed customer master key (CMK) with the alias <code>aws/secretsmanager</code>.
    /// If this key doesn't already exist in your account then Secrets Manager creates it
    /// for you automatically. All users and roles in the same Amazon Web Services account
    /// automatically have access to use the default CMK. Note that if an Secrets Manager
    /// API call results in Amazon Web Services creating the account's Amazon Web Services-managed
    /// CMK, it can result in a one-time significant delay in returning the result.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the secret resides in a different Amazon Web Services account from the credentials
    /// calling an API that requires encryption or decryption of the secret value then you
    /// must create and use a custom Amazon Web Services KMS CMK because you can't access
    /// the default CMK for the account using credentials from a different Amazon Web Services
    /// account. Store the ARN of the CMK in the secret when you create the secret or when
    /// you update it by including it in the <code>KMSKeyId</code>. If you call an API that
    /// must encrypt or decrypt <code>SecretString</code> or <code>SecretBinary</code> using
    /// credentials from a different account then the Amazon Web Services KMS key policy must
    /// grant cross-account access to that other account's user or role for both the kms:GenerateDataKey
    /// and kms:Decrypt operations.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// secretsmanager:PutSecretValue
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// kms:GenerateDataKey - needed only if you use a customer-managed Amazon Web Services
    /// KMS key to encrypt the secret. You do not need this permission to use the account's
    /// default Amazon Web Services managed CMK for Secrets Manager.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To retrieve the encrypted value you store in the version of a secret, use <a>GetSecretValue</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To create a secret, use <a>CreateSecret</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To get the details for a secret, use <a>DescribeSecret</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To list the versions attached to a secret, use <a>ListSecretVersionIds</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutSecretValueRequest : AmazonSecretsManagerRequest
    {
        private string _clientRequestToken;
        private MemoryStream _secretBinary;
        private string _secretId;
        private string _secretString;
        private List<string> _versionStages = new List<string>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// (Optional) Specifies a unique identifier for the new version of the secret. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you use the Amazon Web Services CLI or one of the Amazon Web Services SDK to call
        /// this operation, then you can leave this parameter empty. The CLI or SDK generates
        /// a random UUID for you and includes that in the request. If you don't use the SDK and
        /// instead generate a raw HTTP request to the Secrets Manager service endpoint, then
        /// you must generate a <code>ClientRequestToken</code> yourself for new versions and
        /// include that value in the request. 
        /// </para>
        ///  </note> 
        /// <para>
        /// This value helps ensure idempotency. Secrets Manager uses this value to prevent the
        /// accidental creation of duplicate versions if there are failures and retries during
        /// the Lambda rotation function's processing. We recommend that you generate a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type</a>
        /// value to ensure uniqueness within the specified secret. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the <code>ClientRequestToken</code> value isn't already associated with a version
        /// of the secret then a new version of the secret is created. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a version with this value already exists and that version's <code>SecretString</code>
        /// or <code>SecretBinary</code> values are the same as those in the request then the
        /// request is ignored (the operation is idempotent). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a version with this value already exists and the version of the <code>SecretString</code>
        /// and <code>SecretBinary</code> values are different from those in the request then
        /// the request fails because you cannot modify an existing secret version. You can only
        /// create new versions to store new secret values.
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
        /// Gets and sets the property SecretBinary. 
        /// <para>
        /// (Optional) Specifies binary data that you want to encrypt and store in the new version
        /// of the secret. To use this parameter in the command-line tools, we recommend that
        /// you store your binary data in a file and then use the appropriate technique for your
        /// tool to pass the contents of the file as a parameter. Either <code>SecretBinary</code>
        /// or <code>SecretString</code> must have a value, but not both. They cannot both be
        /// empty.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not accessible if the secret using the Secrets Manager console.
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
        /// Gets and sets the property SecretId. 
        /// <para>
        /// Specifies the secret to which you want to add a new version. You can specify either
        /// the Amazon Resource Name (ARN) or the friendly name of the secret. The secret must
        /// already exist.
        /// </para>
        ///  
        /// <para>
        /// For an ARN, we recommend that you specify a complete ARN rather than a partial ARN.
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
        /// (Optional) Specifies text data that you want to encrypt and store in this new version
        /// of the secret. Either <code>SecretString</code> or <code>SecretBinary</code> must
        /// have a value, but not both. They cannot both be empty.
        /// </para>
        ///  
        /// <para>
        /// If you create this secret by using the Secrets Manager console then Secrets Manager
        /// puts the protected secret text in only the <code>SecretString</code> parameter. The
        /// Secrets Manager console stores the information as a JSON structure of key/value pairs
        /// that the default Lambda rotation function knows how to parse.
        /// </para>
        ///  
        /// <para>
        /// For storing multiple values, we recommend that you use a JSON text string argument
        /// and specify key/value pairs. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters.html">Specifying
        /// parameter values for the Amazon Web Services CLI</a> in the Amazon Web Services CLI
        /// User Guide.
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
        /// Gets and sets the property VersionStages. 
        /// <para>
        /// (Optional) Specifies a list of staging labels that are attached to this version of
        /// the secret. These staging labels are used to track the versions through the rotation
        /// process by the Lambda rotation function.
        /// </para>
        ///  
        /// <para>
        /// A staging label must be unique to a single version of the secret. If you specify a
        /// staging label that's already associated with a different version of the same secret
        /// then that staging label is automatically removed from the other version and attached
        /// to this version.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for <code>VersionStages</code> then Secrets Manager
        /// automatically moves the staging label <code>AWSCURRENT</code> to this new version.
        /// </para>
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
            return this._versionStages != null && this._versionStages.Count > 0; 
        }

    }
}