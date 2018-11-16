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
    /// Container for the parameters to the ListResolverEndpointIpAddresses operation.
    /// Gets the IP addresses for a specified resolver endpoint.
    /// </summary>
    public partial class ListResolverEndpointIpAddressesRequest : AmazonRoute53ResolverRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _resolverEndpointId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of IP addresses that you want to return in the response to a <code>ListResolverEndpointIpAddresses</code>
        /// request. If you don't specify a value for <code>MaxResults</code>, Resolver returns
        /// up to 100 IP addresses. 
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
        /// For the first <code>ListResolverEndpointIpAddresses</code> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// If the specified resolver endpoint has more than <code>MaxResults</code> IP addresses,
        /// you can submit another <code>ListResolverEndpointIpAddresses</code> request to get
        /// the next group of IP addresses. In the next request, specify the value of <code>NextToken</code>
        /// from the previous response. 
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
        /// Gets and sets the property ResolverEndpointId. 
        /// <para>
        /// The ID of the resolver endpoint that you want to get IP addresses for.
        /// </para>
        /// </summary>
        public string ResolverEndpointId
        {
            get { return this._resolverEndpointId; }
            set { this._resolverEndpointId = value; }
        }

        // Check to see if ResolverEndpointId property is set
        internal bool IsSetResolverEndpointId()
        {
            return this._resolverEndpointId != null;
        }

    }
}