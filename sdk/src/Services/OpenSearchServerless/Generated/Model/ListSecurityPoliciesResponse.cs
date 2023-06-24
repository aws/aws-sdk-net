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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// This is the response object from the ListSecurityPolicies operation.
    /// </summary>
    public partial class ListSecurityPoliciesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SecurityPolicySummary> _securityPolicySummaries = new List<SecurityPolicySummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page.
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

        /// <summary>
        /// Gets and sets the property SecurityPolicySummaries. 
        /// <para>
        /// Details about the security policies in your account.
        /// </para>
        /// </summary>
        public List<SecurityPolicySummary> SecurityPolicySummaries
        {
            get { return this._securityPolicySummaries; }
            set { this._securityPolicySummaries = value; }
        }

        // Check to see if SecurityPolicySummaries property is set
        internal bool IsSetSecurityPolicySummaries()
        {
            return this._securityPolicySummaries != null && this._securityPolicySummaries.Count > 0; 
        }

    }
}