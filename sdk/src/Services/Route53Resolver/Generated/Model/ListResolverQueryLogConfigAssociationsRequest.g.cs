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
    /// Container for the parameters to the ListResolverQueryLogConfigAssociations operation.
    /// Lists information about associations between Amazon VPCs and query logging configurations.
    /// </summary>
    public partial class ListResolverQueryLogConfigAssociationsRequest : AmazonRoute53ResolverRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An optional specification to return a subset of query logging associations.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you submit a second or subsequent <c>ListResolverQueryLogConfigAssociations</c>
        /// request and specify the <c>NextToken</c> parameter, you must use the same values for
        /// <c>Filters</c>, if any, as in the previous request.
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
        /// The maximum number of query logging associations that you want to return in the response
        /// to a <c>ListResolverQueryLogConfigAssociations</c> request. If you don't specify a
        /// value for <c>MaxResults</c>, Resolver returns up to 100 query logging associations.
        /// 
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
        /// For the first <c>ListResolverQueryLogConfigAssociations</c> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// If there are more than <c>MaxResults</c> query logging associations that match the
        /// values that you specify for <c>Filters</c>, you can submit another <c>ListResolverQueryLogConfigAssociations</c>
        /// request to get the next group of associations. In the next request, specify the value
        /// of <c>NextToken</c> from the previous response. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The element that you want Resolver to sort query logging associations by. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you submit a second or subsequent <c>ListResolverQueryLogConfigAssociations</c>
        /// request and specify the <c>NextToken</c> parameter, you must use the same value for
        /// <c>SortBy</c>, if any, as in the previous request.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid values include the following elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CreationTime</c>: The ID of the query logging association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Error</c>: If the value of <c>Status</c> is <c>FAILED</c>, the value of <c>Error</c>
        /// indicates the cause: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DESTINATION_NOT_FOUND</c>: The specified destination (for example, an Amazon S3
        /// bucket) was deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCESS_DENIED</c>: Permissions don't allow sending logs to the destination.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>Status</c> is a value other than <c>FAILED</c>, <c>ERROR</c> is null.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Id</c>: The ID of the query logging association
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResolverQueryLogConfigId</c>: The ID of the query logging configuration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceId</c>: The ID of the VPC that is associated with the query logging configuration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Status</c>: The current status of the configuration. Valid values include the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c>: Resolver is creating an association between an Amazon VPC and a
        /// query logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATED</c>: The association between an Amazon VPC and a query logging configuration
        /// was successfully created. Resolver is logging queries that originate in the specified
        /// VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: Resolver is deleting this query logging association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: Resolver either couldn't create or couldn't delete the query logging
        /// association. Here are two common causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The specified destination (for example, an Amazon S3 bucket) was deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Permissions don't allow sending logs to the destination.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// If you specified a value for <c>SortBy</c>, the order that you want query logging
        /// associations to be listed in, <c>ASCENDING</c> or <c>DESCENDING</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you submit a second or subsequent <c>ListResolverQueryLogConfigAssociations</c>
        /// request and specify the <c>NextToken</c> parameter, you must use the same value for
        /// <c>SortOrder</c>, if any, as in the previous request.
        /// </para>
        ///  </note>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
