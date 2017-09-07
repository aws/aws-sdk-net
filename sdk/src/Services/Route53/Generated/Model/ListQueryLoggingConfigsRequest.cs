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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListQueryLoggingConfigs operation.
    /// Lists the configurations for DNS query logging that are associated with the current
    /// AWS account or the configuration that is associated with a specified hosted zone.
    /// 
    ///  
    /// <para>
    /// For more information about DNS query logs, see <a>CreateQueryLoggingConfig</a>. Additional
    /// information, including the format of DNS query logs, appears in <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/query-logs.html">Logging
    /// DNS Queries</a> in the <i>Amazon Route 53 Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ListQueryLoggingConfigsRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private string _nextToken;
        private string _maxResults;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// (Optional) If you want to list the query logging configuration that is associated
        /// with a hosted zone, specify the ID in <code>HostedZoneId</code>. 
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a hosted zone ID, <code>ListQueryLoggingConfigs</code> returns
        /// all of the configurations that are associated with the current AWS account.
        /// </para>
        /// </summary>
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// (Optional) If the current AWS account has more than <code>MaxResults</code> query
        /// logging configurations, use <code>NextToken</code> to get the second and subsequent
        /// pages of results.
        /// </para>
        ///  
        /// <para>
        /// For the first <code>ListQueryLoggingConfigs</code> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// For the second and subsequent requests, get the value of <code>NextToken</code> from
        /// the previous response and specify that value for <code>NextToken</code> in the request.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Optional) The maximum number of query logging configurations that you want Amazon
        /// Route 53 to return in response to the current request. If the current AWS account
        /// has more than <code>MaxResults</code> configurations, use the value of <a>ListQueryLoggingConfigsResponse$NextToken</a>
        /// in the response to get the next page of results.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for <code>MaxResults</code>, Amazon Route 53 returns
        /// up to 100 configurations.
        /// </para>
        /// </summary>
        public string MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults != null;
        }

    }
}