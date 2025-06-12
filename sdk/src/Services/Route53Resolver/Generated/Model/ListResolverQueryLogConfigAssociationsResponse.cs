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
    /// This is the response object from the ListResolverQueryLogConfigAssociations operation.
    /// </summary>
    public partial class ListResolverQueryLogConfigAssociationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResolverQueryLogConfigAssociation> _resolverQueryLogConfigAssociations = AWSConfigs.InitializeCollections ? new List<ResolverQueryLogConfigAssociation>() : null;
        private int? _totalCount;
        private int? _totalFilteredCount;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more than <c>MaxResults</c> query logging associations, you can submit
        /// another <c>ListResolverQueryLogConfigAssociations</c> request to get the next group
        /// of associations. In the next request, specify the value of <c>NextToken</c> from the
        /// previous response. 
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
        /// A list that contains one <c>ResolverQueryLogConfigAssociations</c> element for each
        /// query logging association that matches the values that you specified for <c>Filter</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResolverQueryLogConfigAssociation> ResolverQueryLogConfigAssociations
        {
            get { return this._resolverQueryLogConfigAssociations; }
            set { this._resolverQueryLogConfigAssociations = value; }
        }

        // Check to see if ResolverQueryLogConfigAssociations property is set
        internal bool IsSetResolverQueryLogConfigAssociations()
        {
            return this._resolverQueryLogConfigAssociations != null && (this._resolverQueryLogConfigAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of query logging associations that were created by the current account
        /// in the specified Region. This count can differ from the number of associations that
        /// are returned in a <c>ListResolverQueryLogConfigAssociations</c> response, depending
        /// on the values that you specify in the request.
        /// </para>
        /// </summary>
        public int? TotalCount
        {
            get { return this._totalCount; }
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
        /// in the specified Region and that match the filters that were specified in the <c>ListResolverQueryLogConfigAssociations</c>
        /// request. For the total number of associations that were created by the current account
        /// in the specified Region, see <c>TotalCount</c>.
        /// </para>
        /// </summary>
        public int? TotalFilteredCount
        {
            get { return this._totalFilteredCount; }
            set { this._totalFilteredCount = value; }
        }

        // Check to see if TotalFilteredCount property is set
        internal bool IsSetTotalFilteredCount()
        {
            return this._totalFilteredCount.HasValue; 
        }

    }
}