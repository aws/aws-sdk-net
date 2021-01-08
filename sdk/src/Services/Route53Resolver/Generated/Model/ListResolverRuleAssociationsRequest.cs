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
    /// Container for the parameters to the ListResolverRuleAssociations operation.
    /// Lists the associations that were created between Resolver rules and VPCs using the
    /// current AWS account.
    /// </summary>
    public partial class ListResolverRuleAssociationsRequest : AmazonRoute53ResolverRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An optional specification to return a subset of Resolver rules, such as Resolver rules
        /// that are associated with the same VPC ID.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you submit a second or subsequent <code>ListResolverRuleAssociations</code> request
        /// and specify the <code>NextToken</code> parameter, you must use the same values for
        /// <code>Filters</code>, if any, as in the previous request.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of rule associations that you want to return in the response to
        /// a <code>ListResolverRuleAssociations</code> request. If you don't specify a value
        /// for <code>MaxResults</code>, Resolver returns up to 100 rule associations. 
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
        /// For the first <code>ListResolverRuleAssociation</code> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// If you have more than <code>MaxResults</code> rule associations, you can submit another
        /// <code>ListResolverRuleAssociation</code> request to get the next group of rule associations.
        /// In the next request, specify the value of <code>NextToken</code> from the previous
        /// response. 
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