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
    /// Container for the parameters to the ListResolverQueryLogConfigs operation.
    /// Lists information about the specified query logging configurations. Each configuration
    /// defines where you want Resolver to save DNS query logs and specifies the VPCs that
    /// you want to log queries for.
    /// </summary>
    public partial class ListResolverQueryLogConfigsRequest : AmazonRoute53ResolverRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private string _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An optional specification to return a subset of query logging configurations.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you submit a second or subsequent <code>ListResolverQueryLogConfigs</code> request
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
        /// The maximum number of query logging configurations that you want to return in the
        /// response to a <code>ListResolverQueryLogConfigs</code> request. If you don't specify
        /// a value for <code>MaxResults</code>, Resolver returns up to 100 query logging configurations.
        /// 
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
        /// For the first <code>ListResolverQueryLogConfigs</code> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// If there are more than <code>MaxResults</code> query logging configurations that match
        /// the values that you specify for <code>Filters</code>, you can submit another <code>ListResolverQueryLogConfigs</code>
        /// request to get the next group of configurations. In the next request, specify the
        /// value of <code>NextToken</code> from the previous response. 
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The element that you want Resolver to sort query logging configurations by. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you submit a second or subsequent <code>ListResolverQueryLogConfigs</code> request
        /// and specify the <code>NextToken</code> parameter, you must use the same value for
        /// <code>SortBy</code>, if any, as in the previous request.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid values include the following elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Arn</code>: The ARN of the query logging configuration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AssociationCount</code>: The number of VPCs that are associated with the specified
        /// configuration 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code>: The date and time that Resolver returned when the configuration
        /// was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreatorRequestId</code>: The value that was specified for <code>CreatorRequestId</code>
        /// when the configuration was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationArn</code>: The location that logs are sent to
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Id</code>: The ID of the configuration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Name</code>: The name of the configuration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OwnerId</code>: The AWS account number of the account that created the configuration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ShareStatus</code>: Whether the configuration is shared with other AWS accounts
        /// or shared with the current account by another AWS account. Sharing is configured through
        /// AWS Resource Access Manager (AWS RAM).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code>: The current status of the configuration. Valid values include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATING</code>: Resolver is creating the query logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATED</code>: The query logging configuration was successfully created. Resolver
        /// is logging queries that originate in the specified VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code>: Resolver is deleting this query logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code>: Resolver either couldn't create or couldn't delete the query
        /// logging configuration. Here are two common causes:
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
        [AWSProperty(Min=1, Max=64)]
        public string SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// If you specified a value for <code>SortBy</code>, the order that you want query logging
        /// configurations to be listed in, <code>ASCENDING</code> or <code>DESCENDING</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you submit a second or subsequent <code>ListResolverQueryLogConfigs</code> request
        /// and specify the <code>NextToken</code> parameter, you must use the same value for
        /// <code>SortOrder</code>, if any, as in the previous request.
        /// </para>
        ///  </note>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}