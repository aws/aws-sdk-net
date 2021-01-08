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
    /// This is the response object from the ListResolverQueryLogConfigAssociations operation.
    /// </summary>
    public partial class ListResolverQueryLogConfigAssociationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResolverQueryLogConfigAssociation> _resolverQueryLogConfigAssociations = new List<ResolverQueryLogConfigAssociation>();
        private int? _totalCount;
        private int? _totalFilteredCount;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more than <code>MaxResults</code> query logging associations, you can
        /// submit another <code>ListResolverQueryLogConfigAssociations</code> request to get
        /// the next group of associations. In the next request, specify the value of <code>NextToken</code>
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
        /// Gets and sets the property ResolverQueryLogConfigAssociations. 
        /// <para>
        /// A list that contains one <code>ResolverQueryLogConfigAssociations</code> element for
        /// each query logging association that matches the values that you specified for <code>Filter</code>.
        /// </para>
        /// </summary>
        public List<ResolverQueryLogConfigAssociation> ResolverQueryLogConfigAssociations
        {
            get { return this._resolverQueryLogConfigAssociations; }
            set { this._resolverQueryLogConfigAssociations = value; }
        }

        // Check to see if ResolverQueryLogConfigAssociations property is set
        internal bool IsSetResolverQueryLogConfigAssociations()
        {
            return this._resolverQueryLogConfigAssociations != null && this._resolverQueryLogConfigAssociations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of query logging associations that were created by the current account
        /// in the specified Region. This count can differ from the number of associations that
        /// are returned in a <code>ListResolverQueryLogConfigAssociations</code> response, depending
        /// on the values that you specify in the request.
        /// </para>
        /// </summary>
        public int TotalCount
        {
            get { return this._totalCount.GetValueOrDefault(); }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalFilteredCount. 
        /// <para>
        /// The total number of query logging associations that were created by the current account
        /// in the specified Region and that match the filters that were specified in the <code>ListResolverQueryLogConfigAssociations</code>
        /// request. For the total number of associations that were created by the current account
        /// in the specified Region, see <code>TotalCount</code>.
        /// </para>
        /// </summary>
        public int TotalFilteredCount
        {
            get { return this._totalFilteredCount.GetValueOrDefault(); }
            set { this._totalFilteredCount = value; }
        }

        // Check to see if TotalFilteredCount property is set
        internal bool IsSetTotalFilteredCount()
        {
            return this._totalFilteredCount.HasValue; 
        }

    }
}