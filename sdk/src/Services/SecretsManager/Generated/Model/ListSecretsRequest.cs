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
    /// Container for the parameters to the ListSecrets operation.
    /// Lists all of the secrets that are stored by Secrets Manager in the AWS account. To
    /// list the versions currently stored for a specific secret, use <a>ListSecretVersionIds</a>.
    /// The encrypted fields <code>SecretString</code> and <code>SecretBinary</code> are not
    /// included in the output. To get that information, call the <a>GetSecretValue</a> operation.
    /// 
    ///  <note> 
    /// <para>
    /// Always check the <code>NextToken</code> response parameter when calling any of the
    /// <code>List*</code> operations. These operations can occasionally return an empty or
    /// shorter than expected list of results even when there are more results available.
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
    /// secretsmanager:ListSecrets
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To list the versions attached to a secret, use <a>ListSecretVersionIds</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListSecretsRequest : AmazonSecretsManagerRequest
    {
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Optional) Limits the number of results that you want to include in the response.
        /// If you don't include this parameter, it defaults to a value that's specific to the
        /// operation. If additional items exist beyond the maximum you specify, the <code>NextToken</code>
        /// response element is present and has a value (isn't null). Include that value as the
        /// <code>NextToken</code> request parameter in the next call to the operation to get
        /// the next part of the results. Note that Secrets Manager might return fewer results
        /// than the maximum even when there are more results available. You should check <code>NextToken</code>
        /// after every operation to ensure that you receive all of the results.
        /// </para>
        /// </summary>
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
        /// response in a previous request that indicates that there's more output available.
        /// In a subsequent call, set it to the value of the previous call's <code>NextToken</code>
        /// response to indicate where the output should continue from.
        /// </para>
        /// </summary>
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

    }
}