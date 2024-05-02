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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the ListFirewallRuleGroups operation.
    /// Retrieves the minimal high-level information for the rule groups that you have defined.
    /// 
    /// 
    ///  
    /// <para>
    /// A single call might return only a partial list of the rule groups. For information,
    /// see <c>MaxResults</c>. 
    /// </para>
    /// </summary>
    public partial class ListFirewallRuleGroupsRequest : AmazonRoute53ResolverRequest
    {
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects that you want Resolver to return for this request. If
        /// more objects are available, in the response, Resolver provides a <c>NextToken</c>
        /// value that you can use in a subsequent call to get the next batch of objects.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for <c>MaxResults</c>, Resolver returns up to 100 objects.
        /// 
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
        /// For the first call to this list request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// When you request a list of objects, Resolver returns at most the number of objects
        /// specified in <c>MaxResults</c>. If more objects are available for retrieval, Resolver
        /// returns a <c>NextToken</c> value in the response. To retrieve the next batch of objects,
        /// use the token that was returned for the prior request in your next request.
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