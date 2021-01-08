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
    /// Creates a new secret. A secret in Secrets Manager consists of both the protected secret
    /// data and the important information needed to manage the secret.
    /// 
    ///  
    /// <para>
    /// Secrets Manager stores the encrypted secret data in one of a collection of "versions"
    /// associated with the secret. Each version contains a copy of the encrypted secret data.
    /// Each version is associated with one or more "staging labels" that identify where the
    /// version is in the rotation cycle. The <code>SecretVersionsToStages</code> field of
    /// the secret contains the mapping of staging labels to the active versions of the secret.
    /// Versions without a staging label are considered deprecated and not included in the
    /// list.
    /// </para>
    ///  
    /// <para>
    /// You provide the secret data to be encrypted by putting text in either the <code>SecretString</code>
    /// parameter or binary data in the <code>SecretBinary</code> parameter, but not both.
    /// If you include <code>SecretString</code> or <code>SecretBinary</code> then Secrets
    /// Manager also creates an initial secret version and automatically attaches the staging
    /// label <code>AWSCURRENT</code> to the new version.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// If you call an operation to encrypt or decrypt the <code>SecretString</code> or <code>SecretBinary</code>
    /// for a secret in the same account as the calling user and that secret doesn't specify
    /// a AWS KMS encryption key, Secrets Manager uses the account's default AWS managed customer
    /// master key (CMK) with the alias <code>aws/secretsmanager</code>. If this key doesn't
    /// already exist in your account then Secrets Manager creates it for you automatically.
    /// All users and roles in the same AWS account automatically have access to use the default
    /// CMK. Note that if an Secrets Manager API call results in AWS creating the account's
    /// AWS-managed CMK, it can result in a one-time significant delay in returning the result.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the secret resides in a different AWS account from the credentials calling an API
    /// that requires encryption or decryption of the secret value then you must create and
    /// use a custom AWS KMS CMK because you can't access the default CMK for the account
    /// using credentials from a different AWS account. Store the ARN of the CMK in the secret
    /// when you create the secret or when you update it by including it in the <code>KMSKeyId</code>.
    /// If you call an API that must encrypt or decrypt <code>SecretString</code> or <code>SecretBinary</code>
    /// using credentials from a different account then the AWS KMS key policy must grant
    /// cross-account access to that other account's user or role for both the kms:GenerateDataKey
    /// and kms:Decrypt operations.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    ///  
    /// </para>
    ///  
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// secretsmanager:CreateSecret
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// kms:GenerateDataKey - needed only if you use a customer-managed AWS KMS key to encrypt
    /// the secret. You do not need this permission to use the account default AWS managed
    /// CMK for Secrets Manager.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// kms:Decrypt - needed only if you use a customer-managed AWS KMS key to encrypt the
    /// secret. You do not need this permission to use the account default AWS managed CMK
    /// for Secrets Manager.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// secretsmanager:TagResource - needed only if you include the <code>Tags</code> parameter.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To delete a secret, use <a>DeleteSecret</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To modify an existing secret, use <a>UpdateSecret</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To create a new version of a secret, use <a>PutSecretValue</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To retrieve the encrypted secure string and secure binary values, use <a>GetSecretValue</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To retrieve all other details for a secret, use <a>DescribeSecret</a>. This does not
    /// include the encrypted secure string and secure binary values.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To retrieve the list of secret versions associated with the current secret, use <a>DescribeSecret</a>
    /// and examine the <code>SecretVersionsToStages</code> response value.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateSecretRequest : AmazonSecretsManagerRequest
    {
        private string _clientRequestToken;
        private string _description;
        private string _kmsKeyId;
        private string _name;
        private MemoryStream _secretBinary;
        private string _secretString;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// (Optional) If you include <code>SecretString</code> or <code>SecretBinary</code>,
        /// then an initial version is created as part of the secret, and this parameter specifies
        /// a unique identifier for the new version. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you use the AWS CLI or one of the AWS SDK to call this operation, then you can
        /// leave this parameter empty. The CLI or SDK generates a random UUID for you and includes
        /// it as the value for this parameter in the request. If you don't use the SDK and instead
        /// generate a raw HTTP request to the Secrets Manager service endpoint, then you must
        /// generate a <code>ClientRequestToken</code> yourself for the new version and include
        /// the value in the request.
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
        /// and <code>SecretBinary</code> values are different from those in the request then
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
        /// (Optional) Specifies a user-provided description of the secret.
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
        /// (Optional) Specifies the ARN, Key ID, or alias of the AWS KMS customer master key
        /// (CMK) to be used to encrypt the <code>SecretString</code> or <code>SecretBinary</code>
        /// values in the versions stored in this secret.
        /// </para>
        ///  
        /// <para>
        /// You can specify any of the supported ways to identify a AWS KMS key ID. If you need
        /// to reference a CMK in a different account, you can use only the key ARN or the alias
        /// ARN.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this value, then Secrets Manager defaults to using the AWS account's
        /// default CMK (the one named <code>aws/secretsmanager</code>). If a AWS KMS CMK with
        /// that name doesn't yet exist, then Secrets Manager creates it for you automatically
        /// the first time it needs to encrypt a version's <code>SecretString</code> or <code>SecretBinary</code>
        /// fields.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can use the account default CMK to encrypt and decrypt only if you call this operation
        /// using credentials from the same account that owns the secret. If the secret resides
        /// in a different account, then you must create a custom CMK and specify the ARN in this
        /// field. 
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the friendly name of the new secret.
        /// </para>
        ///  
        /// <para>
        /// The secret name must be ASCII letters, digits, or the following characters : /_+=.@-
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not end your secret name with a hyphen followed by six characters. If you do so,
        /// you risk confusion and unexpected results when searching for a secret by partial ARN.
        /// Secrets Manager automatically adds a hyphen and six random characters at the end of
        /// the ARN.
        /// </para>
        ///  </note>
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
        /// (Optional) Specifies binary data that you want to encrypt and store in the new version
        /// of the secret. To use this parameter in the command-line tools, we recommend that
        /// you store your binary data in a file and then use the appropriate technique for your
        /// tool to pass the contents of the file as a parameter.
        /// </para>
        ///  
        /// <para>
        /// Either <code>SecretString</code> or <code>SecretBinary</code> must have a value, but
        /// not both. They cannot both be empty.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not available using the Secrets Manager console. It can be accessed
        /// only by using the AWS CLI or one of the AWS SDKs.
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
        /// (Optional) Specifies text data that you want to encrypt and store in this new version
        /// of the secret.
        /// </para>
        ///  
        /// <para>
        /// Either <code>SecretString</code> or <code>SecretBinary</code> must have a value, but
        /// not both. They cannot both be empty.
        /// </para>
        ///  
        /// <para>
        /// If you create a secret by using the Secrets Manager console then Secrets Manager puts
        /// the protected secret text in only the <code>SecretString</code> parameter. The Secrets
        /// Manager console stores the information as a JSON structure of key/value pairs that
        /// the Lambda rotation function knows how to parse.
        /// </para>
        ///  
        /// <para>
        /// For storing multiple values, we recommend that you use a JSON text string argument
        /// and specify key/value pairs. For information on how to format a JSON parameter for
        /// the various command line tool environments, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#cli-using-param-json">Using
        /// JSON for Parameters</a> in the <i>AWS CLI User Guide</i>. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>{"username":"bob","password":"abc123xyz456"}</code> 
        /// </para>
        ///  
        /// <para>
        /// If your command-line tool or SDK requires quotation marks around the parameter, you
        /// should use single quotes to avoid confusion with the double quotes required in the
        /// JSON text. 
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
        /// (Optional) Specifies a list of user-defined tags that are attached to the secret.
        /// Each tag is a "Key" and "Value" pair of strings. This operation only appends tags
        /// to the existing list of tags. To remove tags, you must use <a>UntagResource</a>.
        /// </para>
        ///  <important> <ul> <li> 
        /// <para>
        /// Secrets Manager tag key names are case sensitive. A tag with the key "ABC" is a different
        /// tag from one with key "abc".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you check tags in IAM policy <code>Condition</code> elements as part of your security
        /// strategy, then adding or removing a tag can change permissions. If the successful
        /// completion of this operation would result in you losing your permissions for this
        /// secret, then this operation is blocked and returns an <code>Access Denied</code> error.
        /// </para>
        ///  </li> </ul> </important> 
        /// <para>
        /// This parameter requires a JSON text string argument. For information on how to format
        /// a JSON parameter for the various command line tool environments, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#cli-using-param-json">Using
        /// JSON for Parameters</a> in the <i>AWS CLI User Guide</i>. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>[{"Key":"CostCenter","Value":"12345"},{"Key":"environment","Value":"production"}]</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If your command-line tool or SDK requires quotation marks around the parameter, you
        /// should use single quotes to avoid confusion with the double quotes required in the
        /// JSON text. 
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per secret—50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length—127 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length—255 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use the <code>aws:</code> prefix in your tag names or values because AWS reserves
        /// it for AWS use. You can't edit or delete tag names or values with this prefix. Tags
        /// with this prefix do not count against your tags per secret limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use your tagging schema across multiple services and resources, remember other
        /// services might have restrictions on allowed characters. Generally allowed characters:
        /// letters, spaces, and numbers representable in UTF-8, plus the following special characters:
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