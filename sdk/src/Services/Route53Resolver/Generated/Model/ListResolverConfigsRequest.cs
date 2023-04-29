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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the ListResolverConfigs operation.
    /// Retrieves the Resolver configurations that you have defined. Route 53 Resolver uses
    /// the configurations to manage DNS resolution behavior for your VPCs.
    /// </summary>
    public partial class ListResolverConfigsRequest : AmazonRoute53ResolverRequest
    {
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of Resolver configurations that you want to return in the response
        /// to a <code>ListResolverConfigs</code> request. If you don't specify a value for <code>MaxResults</code>,
        /// up to 100 Resolver configurations are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=100)]
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
        /// (Optional) If the current Amazon Web Services account has more than <code>MaxResults</code>
        /// Resolver configurations, use <code>NextToken</code> to get the second and subsequent
        /// pages of results.
        /// </para>
        ///  
        /// <para>
        /// For the first <code>ListResolverConfigs</code> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// For the second and subsequent requests, get the value of <code>NextToken</code> from
        /// the previous response and specify that value for <code>NextToken</code> in the request.
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