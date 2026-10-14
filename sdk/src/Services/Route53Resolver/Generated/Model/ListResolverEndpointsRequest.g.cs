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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListResolverEndpoints operation. Lists all the
    /// Resolver endpoints that were created using the current Amazon Web Services account.
    /// </summary>
    public partial class ListResolverEndpointsRequest : AmazonRoute53ResolverRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An optional specification to return a subset of Resolver endpoints, such as all inbound
        /// Resolver endpoints.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you submit a second or subsequent <c>ListResolverEndpoints</c> request and specify
        /// the <c>NextToken</c> parameter, you must use the same values for <c>Filters</c>, if
        /// any, as in the previous request.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of Resolver endpoints that you want to return in the response to
        /// a <c>ListResolverEndpoints</c> request. If you don't specify a value for <c>MaxResults</c>,
        /// Resolver returns up to 100 Resolver endpoints. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// For the first <c>ListResolverEndpoints</c> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// If you have more than <c>MaxResults</c> Resolver endpoints, you can submit another
        /// <c>ListResolverEndpoints</c> request to get the next group of Resolver endpoints.
        /// In the next request, specify the value of <c>NextToken</c> from the previous response.
        /// 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
