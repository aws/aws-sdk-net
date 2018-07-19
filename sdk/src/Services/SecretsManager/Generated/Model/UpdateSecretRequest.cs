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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSecret operation.
    /// Modifies many of the details of a secret. If you include a <code>ClientRequestToken</code>
    /// and either <code>SecretString</code> or <code>SecretBinary</code> then it also creates
    /// a new version attached to the secret.
    /// 
    ///  
    /// <para>
    /// To modify the rotation configuration of a secret, use <a>RotateSecret</a> instead.
    /// </para>
    ///  <note> 
    /// <para>
    /// The Secrets Manager console uses only the <code>SecretString</code> parameter and
    /// therefore limits you to encrypting and storing only a text string. To encrypt and
    /// store binary data as part of the version of a secret, you must use either the AWS
    /// CLI or one of the AWS SDKs.
    /// </para>
    ///  </note> <ul> <li> 
    /// <para>
    /// If a version with a <code>SecretVersionId</code> with the same value as the <code>ClientRequestToken</code>
    /// parameter already exists, the operation generates an error. You cannot modify an existing
    /// version, you can only create new ones.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you include <code>SecretString</code> or <code>SecretBinary</code> to create a
    /// new secret version, Secrets Manager automatically attaches the staging label <code>AWSCURRENT</code>
    /// to the new version. 
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    /// If you call an operation that needs to encrypt or decrypt the <code>SecretString</code>
    /// or <code>SecretBinary</code> for a secret in the same account as the calling user
    /// and that secret doesn't specify a AWS KMS encryption key, Secrets Manager uses the
    /// account's default AWS managed customer master key (CMK) with the alias <code>aws/secretsmanager</code>.
    /// If this key doesn't already exist in your account then Secrets Manager creates it
    /// for you automatically. All users in the same AWS account automatically have access
    /// to use the default CMK. Note that if an Secrets Manager API call results in AWS having
    /// to create the account's AWS-managed CMK, it can result in a one-time significant delay
    /// in returning the result.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the secret is in a different AWS account from the credentials calling an API that
    /// requires encryption or decryption of the secret value then you must create and use
    /// a custom AWS KMS CMK because you can't access the default CMK for the account using
    /// credentials from a different AWS account. Store the ARN of the CMK in the secret when
    /// you create the secret or when you update it by including it in the <code>KMSKeyId</code>.
    /// If you call an API that must encrypt or decrypt <code>SecretString</code> or <code>SecretBinary</code>
    /// using credentials from a different account then the AWS KMS key policy must grant
    /// cross-account access to that other account's user or role for both the kms:GenerateDataKey
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
    /// secretsmanager:UpdateSecret
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// kms:GenerateDataKey - needed only if you use a custom AWS KMS key to encrypt the secret.
    /// You do not need this permission to use the account's AWS managed CMK for Secrets Manager.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// kms:Decrypt - needed only if you use a custom AWS KMS key to encrypt the secret. You
    /// do not need this permission to use the account's AWS managed CMK for Secrets Manager.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To create a new secret, use <a>CreateSecret</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To add only a new version to an existing secret, use <a>PutSecretValue</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To get the details for a secret, use <a>DescribeSecret</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To list the versions contained in a secret, use <a>ListSecretVersionIds</a>.
    /// </para>
    ///  </li> </ul>
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
        /// (Optional) If you want to add a new version to the secret, this parameter specifies
        /// a unique identifier for the new version that helps ensure idempotency. 
        /// </para>
        ///  
        /// <para>
        /// If you use the AWS CLI or one of the AWS SDK to call this operation, then you can
        /// leave this parameter empty. The CLI or SDK generates a random UUID for you and includes
        /// that in the request. If you don't use the SDK and instead generate a raw HTTP request
        /// to the Secrets Manager service endpoint, then you must generate a <code>ClientRequestToken</code>
        /// yourself for new versions and include that value in the request.
        /// </para>
        ///  
        /// <para>
        /// You typically only need to interact with this value if you implement your own retry
        /// logic and want to ensure that a given secret is not created twice. We recommend that
        /// you generate a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type</a>
        /// value to ensure uniqueness within the specified secret. 
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager uses this value to prevent the accidental creation of duplicate versions
        /// if there are failures and retries during the Lambda rotation function's processing.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the <code>ClientRequestToken</code> value isn't already associated with a version
        /// of the secret then a new version of the secret is created. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a version with this value already exists and that version's <code>SecretString</code>
        /// and <code>SecretBinary</code> values are the same as those in the request then the
        /// request is ignored (the operation is idempotent). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a version with this value already exists and that version's <code>SecretString</code>
        /// and <code>SecretBinary</code> values are different from the request then an error
        /// occurs because you cannot modify an existing secret value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This value becomes the <code>SecretVersionId</code> of the new version.
        /// </para>
        /// </summary>
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
        /// (Optional) Specifies the ARN or alias of the AWS KMS customer master key (CMK) to
        /// be used to encrypt the protected text in the versions of this secret.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this value, then Secrets Manager defaults to using the default
        /// CMK in the account (the one named <code>aws/secretsmanager</code>). If a AWS KMS CMK
        /// with that name doesn't exist, then Secrets Manager creates it for you automatically
        /// the first time it needs to encrypt a version's <code>Plaintext</code> or <code>PlaintextString</code>
        /// fields.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can only use the account's default CMK to encrypt and decrypt if you call this
        /// operation using credentials from the same account that owns the secret. If the secret
        /// is in a different account, then you must create a custom CMK and provide the ARN in
        /// this field. 
        /// </para>
        ///  </important>
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
        /// This parameter is not accessible using the Secrets Manager console.
        /// </para>
        /// </summary>
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
        /// Specifies the secret that you want to update or to which you want to add a new version.
        /// You can specify either the Amazon Resource Name (ARN) or the friendly name of the
        /// secret.
        /// </para>
        /// </summary>
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
        /// of the secret. Either <code>SecretBinary</code> or <code>SecretString</code> must
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
        /// and specify key/value pairs. For information on how to format a JSON parameter for
        /// the various command line tool environments, see <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#cli-using-param-json">Using
        /// JSON for Parameters</a> in the <i>AWS CLI User Guide</i>. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>[{"username":"bob"},{"password":"abc123xyz456"}]</code> 
        /// </para>
        ///  
        /// <para>
        /// If your command-line tool or SDK requires quotation marks around the parameter, you
        /// should use single quotes to avoid confusion with the double quotes required in the
        /// JSON text.
        /// </para>
        /// </summary>
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