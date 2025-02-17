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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the GetQueryResultsWorkloadInsightsTopContributorsData operation.
    /// Return the data for a query with the Network Flow Monitor query interface. Specify
    /// the query that you want to return results for by providing a query ID and a scope
    /// ID. This query returns data for the top contributors for workload insights. Workload
    /// insights provide a high level view of network flow performance data collected by agents
    /// for a scope.
    /// 
    ///  
    /// <para>
    /// Create a query ID for this call by calling the corresponding API call to start the
    /// query, <c>StartQueryWorkloadInsightsTopContributorsData</c>. Use the scope ID that
    /// was returned for your account by <c>CreateScope</c>.
    /// </para>
    ///  
    /// <para>
    /// Top contributors in Network Flow Monitor are network flows with the highest values
    /// for a specific metric type, related to a scope (for workload insights) or a monitor.
    /// </para>
    ///  
    /// <para>
    /// The top contributor network flows overall for a specific metric type, for example,
    /// the number of retransmissions.
    /// </para>
    /// </summary>
    public partial class GetQueryResultsWorkloadInsightsTopContributorsDataRequest : AmazonNetworkFlowMonitorRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _queryId;
        private string _scopeId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of query results that you want to return with this call.
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
        /// The token for the next set of results. You receive this token from a previous call.
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
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The identifier for the query. A query ID is an internally-generated identifier for
        /// a specific query returned from an API call to start a query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeId. 
        /// <para>
        /// The identifier for the scope that includes the resources you want to get data results
        /// for. A scope ID is an internally-generated identifier that includes all the resources
        /// for a specific root account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScopeId
        {
            get { return this._scopeId; }
            set { this._scopeId = value; }
        }

        // Check to see if ScopeId property is set
        internal bool IsSetScopeId()
        {
            return this._scopeId != null;
        }

    }
}