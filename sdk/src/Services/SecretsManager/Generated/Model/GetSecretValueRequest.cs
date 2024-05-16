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
    /// Container for the parameters to the GetSecretValue operation.
    /// Retrieves the contents of the encrypted fields <c>SecretString</c> or <c>SecretBinary</c>
    /// from the specified version of a secret, whichever contains content.
    /// 
    ///  
    /// <para>
    /// To retrieve the values for a group of secrets, call <a>BatchGetSecretValue</a>.
    /// </para>
    ///  
    /// <para>
    /// We recommend that you cache your secret values by using client-side caching. Caching
    /// secrets improves speed and reduces your costs. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieving-secrets.html">Cache
    /// secrets for your applications</a>.
    /// </para>
    ///  
    /// <para>
    /// To retrieve the previous version of a secret, use <c>VersionStage</c> and specify
    /// AWSPREVIOUS. To revert to the previous version of a secret, call <a href="https://docs.aws.amazon.com/cli/latest/reference/secretsmanager/update-secret-version-stage.html">UpdateSecretVersionStage</a>.
    /// </para>
    ///  
    /// <para>
    /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
    /// include sensitive information in request parameters because it might be logged. For
    /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>secretsmanager:GetSecretValue</c>. If the secret
    /// is encrypted using a customer-managed key instead of the Amazon Web Services managed
    /// key <c>aws/secretsmanager</c>, then you also need <c>kms:Decrypt</c> permissions for
    /// that key. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
    /// </summary>
    public partial class GetSecretValueRequest : AmazonSecretsManagerRequest
    {
        private string _secretId;
        private string _versionId;
        private string _versionStage;

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the secret to retrieve. To retrieve a secret from another account,
        /// you must use an ARN.
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
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The unique identifier of the version of the secret to retrieve. If you include both
        /// this parameter and <c>VersionStage</c>, the two parameters must refer to the same
        /// secret version. If you don't specify either a <c>VersionStage</c> or <c>VersionId</c>,
        /// then Secrets Manager returns the <c>AWSCURRENT</c> version.
        /// </para>
        ///  
        /// <para>
        /// This value is typically a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type</a>
        /// value with 32 hexadecimal digits.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=64)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionStage. 
        /// <para>
        /// The staging label of the version of the secret to retrieve. 
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager uses staging labels to keep track of different versions during the
        /// rotation process. If you include both this parameter and <c>VersionId</c>, the two
        /// parameters must refer to the same secret version. If you don't specify either a <c>VersionStage</c>
        /// or <c>VersionId</c>, Secrets Manager returns the <c>AWSCURRENT</c> version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string VersionStage
        {
            get { return this._versionStage; }
            set { this._versionStage = value; }
        }

        // Check to see if VersionStage property is set
        internal bool IsSetVersionStage()
        {
            return this._versionStage != null;
        }

    }
}