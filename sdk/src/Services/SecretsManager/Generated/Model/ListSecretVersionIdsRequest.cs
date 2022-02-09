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
    /// Container for the parameters to the ListSecretVersionIds operation.
    /// Lists the versions for a secret. 
    /// 
    ///  
    /// <para>
    /// To list the secrets in the account, use <a>ListSecrets</a>.
    /// </para>
    ///  
    /// <para>
    /// To get the secret value from <code>SecretString</code> or <code>SecretBinary</code>,
    /// call <a>GetSecretValue</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <code>secretsmanager:ListSecretVersionIds</code>. For
    /// more information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awssecretsmanager.html#awssecretsmanager-actions-as-permissions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
    /// </summary>
    public partial class ListSecretVersionIdsRequest : AmazonSecretsManagerRequest
    {
        private bool? _includeDeprecated;
        private int? _maxResults;
        private string _nextToken;
        private string _secretId;

        /// <summary>
        /// Gets and sets the property IncludeDeprecated. 
        /// <para>
        /// Specifies whether to include versions of secrets that don't have any staging labels
        /// attached to them. Versions without staging labels are considered deprecated and are
        /// subject to deletion by Secrets Manager.
        /// </para>
        /// </summary>
        public bool IncludeDeprecated
        {
            get { return this._includeDeprecated.GetValueOrDefault(); }
            set { this._includeDeprecated = value; }
        }

        // Check to see if IncludeDeprecated property is set
        internal bool IsSetIncludeDeprecated()
        {
            return this._includeDeprecated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of results to include in the response.
        /// </para>
        ///  
        /// <para>
        /// If there are more results available, in the response, Secrets Manager includes <code>NextToken</code>.
        /// To get the next results, call <code>ListSecretVersionIds</code> again with the value
        /// from <code>NextToken</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates where the output should continue from, if a previous call did
        /// not show all results. To get the next results, call <code>ListSecretVersionIds</code>
        /// again with this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the secret whose versions you want to list.
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

    }
}