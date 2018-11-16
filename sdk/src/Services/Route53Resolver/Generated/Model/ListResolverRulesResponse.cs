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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// This is the response object from the ListResolverRules operation.
    /// </summary>
    public partial class ListResolverRulesResponse : AmazonWebServiceResponse
    {
        private int? _maxResults;
        private string _nextToken;
        private List<ResolverRule> _resolverRules = new List<ResolverRule>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The value that you specified for <code>MaxResults</code> in the request.
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
        /// If more than <code>MaxResults</code> resolver rules match the specified criteria,
        /// you can submit another <code>ListResolverRules</code> request to get the next group
        /// of results. In the next request, specify the value of <code>NextToken</code> from
        /// the previous response. 
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
        /// Gets and sets the property ResolverRules. 
        /// <para>
        /// The resolver rules that were created using the current AWS account and that match
        /// the specified filters, if any.
        /// </para>
        /// </summary>
        public List<ResolverRule> ResolverRules
        {
            get { return this._resolverRules; }
            set { this._resolverRules = value; }
        }

        // Check to see if ResolverRules property is set
        internal bool IsSetResolverRules()
        {
            return this._resolverRules != null && this._resolverRules.Count > 0; 
        }

    }
}