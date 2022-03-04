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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie.Model
{
    /// <summary>
    /// Container for the parameters to the ListMemberAccounts operation.
    /// (Discontinued) Lists all Amazon Macie Classic member accounts for the current Macie
    /// Classic administrator account.
    /// </summary>
    public partial class ListMemberAccountsRequest : AmazonMacieRequest
    {
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Discontinued) Use this parameter to indicate the maximum number of items that you
        /// want in the response. The default value is 250.
        /// </para>
        /// </summary>
        [AWSProperty(Max=250)]
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
        /// (Discontinued) Use this parameter when paginating results. Set the value of this parameter
        /// to null on your first call to the <code>ListMemberAccounts</code> action. Subsequent
        /// calls to the action fill <code>nextToken</code> in the request with the value of <code>nextToken</code>
        /// from the previous response to continue listing data.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
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