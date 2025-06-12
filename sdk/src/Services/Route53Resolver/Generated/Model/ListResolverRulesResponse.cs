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
    /// This is the response object from the ListResolverRules operation.
    /// </summary>
    public partial class ListResolverRulesResponse : AmazonWebServiceResponse
    {
        private int? _maxResults;
        private string _nextToken;
        private List<ResolverRule> _resolverRules = AWSConfigs.InitializeCollections ? new List<ResolverRule>() : null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The value that you specified for <c>MaxResults</c> in the request.
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
        /// If more than <c>MaxResults</c> Resolver rules match the specified criteria, you can
        /// submit another <c>ListResolverRules</c> request to get the next group of results.
        /// In the next request, specify the value of <c>NextToken</c> from the previous response.
        /// 
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
        /// The Resolver rules that were created using the current Amazon Web Services account
        /// and that match the specified filters, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResolverRule> ResolverRules
        {
            get { return this._resolverRules; }
            set { this._resolverRules = value; }
        }

        // Check to see if ResolverRules property is set
        internal bool IsSetResolverRules()
        {
            return this._resolverRules != null && (this._resolverRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}