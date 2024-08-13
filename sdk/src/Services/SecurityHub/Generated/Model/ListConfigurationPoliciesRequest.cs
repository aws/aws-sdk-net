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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the ListConfigurationPolicies operation.
    /// Lists the configuration policies that the Security Hub delegated administrator has
    /// created for your organization. Only the delegated administrator can invoke this operation
    /// from the home Region.
    /// </summary>
    public partial class ListConfigurationPoliciesRequest : AmazonSecurityHubRequest
    {
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results that's returned by <c>ListConfigurationPolicies</c>
        /// in each page of the response. When this parameter is used, <c>ListConfigurationPolicies</c>
        /// returns the specified number of results in a single page and a <c>NextToken</c> response
        /// element. You can see the remaining results of the initial request by sending another
        /// <c>ListConfigurationPolicies</c> request with the returned <c>NextToken</c> value.
        /// A valid range for <c>MaxResults</c> is between 1 and 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        ///  The NextToken value that's returned from a previous paginated <c>ListConfigurationPolicies</c>
        /// request where <c>MaxResults</c> was used but the results exceeded the value of that
        /// parameter. Pagination continues from the <c>MaxResults</c> was used but the results
        /// exceeded the value of that parameter. Pagination continues from the end of the previous
        /// response that returned the <c>NextToken</c> value. This value is <c>null</c> when
        /// there are no more results to return. 
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