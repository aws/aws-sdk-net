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
    /// Container for the parameters to the RotateSecret operation.
    /// Configures and starts the asynchronous process of rotating this secret. If you include
    /// the configuration parameters, the operation sets those values for the secret and then
    /// immediately starts a rotation. If you do not include the configuration parameters,
    /// the operation starts a rotation with the values already stored in the secret. After
    /// the rotation completes, the protected service and its clients all use the new version
    /// of the secret. 
    /// 
    ///  
    /// <para>
    /// This required configuration information includes the ARN of an AWS Lambda function
    /// and the time between scheduled rotations. The Lambda rotation function creates a new
    /// version of the secret and creates or updates the credentials on the protected service
    /// to match. After testing the new credentials, the function marks the new secret with
    /// the staging label <code>AWSCURRENT</code> so that your clients all immediately begin
    /// to use the new version. For more information about rotating secrets and how to configure
    /// a Lambda function to rotate the secrets for your protected service, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotating-secrets.html">Rotating
    /// Secrets in AWS Secrets Manager</a> in the <i>AWS Secrets Manager User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Secrets Manager schedules the next rotation when the previous one completes. Secrets
    /// Manager schedules the date by adding the rotation interval (number of days) to the
    /// actual date of the last rotation. The service chooses the hour within that 24-hour
    /// date window randomly. The minute is also chosen somewhat randomly, but weighted towards
    /// the top of the hour and influenced by a variety of factors that help distribute load.
    /// </para>
    ///  
    /// <para>
    /// The rotation function must end with the versions of the secret in one of two states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <code>AWSPENDING</code> and <code>AWSCURRENT</code> staging labels are attached
    /// to the same version of the secret, or
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>AWSPENDING</code> staging label is not attached to any version of the secret.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the <code>AWSPENDING</code> staging label is present but not attached to the same
    /// version as <code>AWSCURRENT</code> then any later invocation of <code>RotateSecret</code>
    /// assumes that a previous rotation request is still in progress and returns an error.
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
    /// secretsmanager:RotateSecret
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// lambda:InvokeFunction (on the function specified in the secret's metadata)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To list the secrets in your account, use <a>ListSecrets</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To get the details for a version of a secret, use <a>DescribeSecret</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To create a new version of a secret, use <a>CreateSecret</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To attach staging labels to or remove staging labels from a version of a secret, use
    /// <a>UpdateSecretVersionStage</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RotateSecretRequest : AmazonSecretsManagerRequest
    {
        private string _clientRequestToken;
        private string _rotationLambdaARN;
        private RotationRulesType _rotationRules;
        private string _secretId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// (Optional) Specifies a unique identifier for the new version of the secret that helps
        /// ensure idempotency. 
        /// </para>
        ///  
        /// <para>
        /// If you use the AWS CLI or one of the AWS SDK to call this operation, then you can
        /// leave this parameter empty. The CLI or SDK generates a random UUID for you and includes
        /// that in the request for this parameter. If you don't use the SDK and instead generate
        /// a raw HTTP request to the Secrets Manager service endpoint, then you must generate
        /// a <code>ClientRequestToken</code> yourself for new versions and include that value
        /// in the request.
        /// </para>
        ///  
        /// <para>
        /// You only need to specify your own value if you implement your own retry logic and
        /// want to ensure that a given secret is not created twice. We recommend that you generate
        /// a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type</a>
        /// value to ensure uniqueness within the specified secret. 
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager uses this value to prevent the accidental creation of duplicate versions
        /// if there are failures and retries during the function's processing. This value becomes
        /// the <code>VersionId</code> of the new version.
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
        /// Gets and sets the property RotationLambdaARN. 
        /// <para>
        /// (Optional) Specifies the ARN of the Lambda function that can rotate the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string RotationLambdaARN
        {
            get { return this._rotationLambdaARN; }
            set { this._rotationLambdaARN = value; }
        }

        // Check to see if RotationLambdaARN property is set
        internal bool IsSetRotationLambdaARN()
        {
            return this._rotationLambdaARN != null;
        }

        /// <summary>
        /// Gets and sets the property RotationRules. 
        /// <para>
        /// A structure that defines the rotation configuration for this secret.
        /// </para>
        /// </summary>
        public RotationRulesType RotationRules
        {
            get { return this._rotationRules; }
            set { this._rotationRules = value; }
        }

        // Check to see if RotationRules property is set
        internal bool IsSetRotationRules()
        {
            return this._rotationRules != null;
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// Specifies the secret that you want to rotate. You can specify either the Amazon Resource
        /// Name (ARN) or the friendly name of the secret.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify an ARN, we generally recommend that you specify a complete ARN. You
        /// can specify a partial ARN too—for example, if you don’t include the final hyphen and
        /// six random characters that Secrets Manager adds at the end of the ARN when you created
        /// the secret. A partial ARN match can work as long as it uniquely matches only one secret.
        /// However, if your secret has a name that ends in a hyphen followed by six characters
        /// (before Secrets Manager adds the hyphen and six characters to the ARN) and you try
        /// to use that as a partial ARN, then those characters cause Secrets Manager to assume
        /// that you’re specifying a complete ARN. This confusion can cause unexpected results.
        /// To avoid this situation, we recommend that you don’t create secret names ending with
        /// a hyphen followed by six characters.
        /// </para>
        ///  
        /// <para>
        /// If you specify an incomplete ARN without the random suffix, and instead provide the
        /// 'friendly name', you <i>must</i> not include the random suffix. If you do include
        /// the random suffix added by Secrets Manager, you receive either a <i>ResourceNotFoundException</i>
        /// or an <i>AccessDeniedException</i> error, depending on your permissions.
        /// </para>
        ///  </note>
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