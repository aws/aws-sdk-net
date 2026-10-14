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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListSecretVersionIds operation. Lists the versions
    /// of a secret. Secrets Manager uses staging labels to indicate the different versions
    /// of a secret. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/getting-started.html#term_version">
    /// Secrets Manager concepts: Versions</a>. <para> To list the secrets in the account,
    /// use <a>ListSecrets</a>. </para> <para> Secrets Manager generates a CloudTrail log
    /// entry when you call this action. Do not include sensitive information in request parameters
    /// because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>. </para> <para> <b>Required permissions:
    /// </b> <c>secretsmanager:ListSecretVersionIds</c>. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. </para>
    /// </summary>
    public partial class ListSecretVersionIdsRequest : AmazonSecretsManagerRequest
    {
        /// <summary>
        /// Gets and sets the property IncludeDeprecated. 
        /// <para>
        /// Specifies whether to include versions of secrets that don't have any staging labels
        /// attached to them. Versions without staging labels are considered deprecated and are
        /// subject to deletion by Secrets Manager. By default, versions without staging labels
        /// aren't included.
        /// </para>
        /// </summary>
        public bool? IncludeDeprecated { get; set; }

        /// <summary>
        /// Checks to see if the IncludeDeprecated property is set.
        /// </summary>
        internal bool IsSetIncludeDeprecated() => this.IncludeDeprecated.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of results to include in the response.
        /// </para>
        ///  
        /// <para>
        /// If there are more results available, in the response, Secrets Manager includes <c>NextToken</c>.
        /// To get the next results, call <c>ListSecretVersionIds</c> again with the value from
        /// <c>NextToken</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates where the output should continue from, if a previous call did
        /// not show all results. To get the next results, call <c>ListSecretVersionIds</c> again
        /// with this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the secret whose versions you want to list.
        /// </para>
        ///  
        /// <para>
        /// For an ARN, we recommend that you specify a complete ARN rather than a partial ARN.
        /// See <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/troubleshoot.html#ARN_secretnamehyphen">Finding
        /// a secret from a partial ARN</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretId property is set.
        /// </summary>
        internal bool IsSetSecretId() => this.SecretId != null;
    }
}
