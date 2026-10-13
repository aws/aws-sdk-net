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
    /// Container for the parameters to the ListResolverDnssecConfigs operation. Lists the
    /// configurations for DNSSEC validation that are associated with the current Amazon Web
    /// Services account.
    /// </summary>
    public partial class ListResolverDnssecConfigsRequest : AmazonRoute53ResolverRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An optional specification to return a subset of objects.
        /// </para>
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
        ///  <i>Optional</i>: An integer that specifies the maximum number of DNSSEC configuration
        /// results that you want Amazon Route 53 to return. If you don't specify a value for
        /// <c>MaxResults</c>, Route 53 returns up to 100 configuration per page.
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
        /// (Optional) If the current Amazon Web Services account has more than <c>MaxResults</c>
        /// DNSSEC configurations, use <c>NextToken</c> to get the second and subsequent pages
        /// of results.
        /// </para>
        ///  
        /// <para>
        /// For the first <c>ListResolverDnssecConfigs</c> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// For the second and subsequent requests, get the value of <c>NextToken</c> from the
        /// previous response and specify that value for <c>NextToken</c> in the request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
