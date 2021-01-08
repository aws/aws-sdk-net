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
    /// Lists all of the versions attached to the specified secret. The output does not include
    /// the <code>SecretString</code> or <code>SecretBinary</code> fields. By default, the
    /// list includes only versions that have at least one staging label in <code>VersionStage</code>
    /// attached.
    /// 
    ///  <note> 
    /// <para>
    /// Always check the <code>NextToken</code> response parameter when calling any of the
    /// <code>List*</code> operations. These operations can occasionally return an empty or
    /// shorter than expected list of results even when there more results become available.
    /// When this happens, the <code>NextToken</code> response parameter contains a value
    /// to pass to the next call to the same API to request the next part of the list.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// secretsmanager:ListSecretVersionIds
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To list the secrets in an account, use <a>ListSecrets</a>.
    /// </para>
    ///  </li> </ul>
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
        /// (Optional) Specifies that you want the results to include versions that do not have
        /// any staging labels attached to them. Such versions are considered deprecated and are
        /// subject to deletion by Secrets Manager as needed.
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
        /// (Optional) Limits the number of results you want to include in the response. If you
        /// don't include this parameter, it defaults to a value that's specific to the operation.
        /// If additional items exist beyond the maximum you specify, the <code>NextToken</code>
        /// response element is present and has a value (isn't null). Include that value as the
        /// <code>NextToken</code> request parameter in the next call to the operation to get
        /// the next part of the results. Note that Secrets Manager might return fewer results
        /// than the maximum even when there are more results available. You should check <code>NextToken</code>
        /// after every operation to ensure that you receive all of the results.
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
        /// (Optional) Use this parameter in a request if you receive a <code>NextToken</code>
        /// response in a previous request indicating there's more output available. In a subsequent
        /// call, set it to the value of the previous call <code>NextToken</code> response to
        /// indicate where the output should continue from.
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
        /// The identifier for the secret containing the versions you want to list. You can specify
        /// either the Amazon Resource Name (ARN) or the friendly name of the secret.
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