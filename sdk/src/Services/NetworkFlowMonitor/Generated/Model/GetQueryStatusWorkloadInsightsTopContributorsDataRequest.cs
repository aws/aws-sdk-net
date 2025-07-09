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
    /// Container for the parameters to the GetQueryStatusWorkloadInsightsTopContributorsData operation.
    /// Returns the current status of a query for the Network Flow Monitor query interface,
    /// for a specified query ID and monitor. This call returns the query status for the top
    /// contributors data for workload insights.
    /// 
    ///  
    /// <para>
    /// When you start a query, use this call to check the status of the query to make sure
    /// that it has has <c>SUCCEEDED</c> before you review the results. Use the same query
    /// ID that you used for the corresponding API call to start the query, <c>StartQueryWorkloadInsightsTopContributorsData</c>.
    /// </para>
    ///  
    /// <para>
    /// Top contributors in Network Flow Monitor are network flows with the highest values
    /// for a specific metric type. Top contributors can be across all workload insights,
    /// for a given scope, or for a specific monitor. Use the applicable call for the top
    /// contributors that you want to be returned.
    /// </para>
    ///  
    /// <para>
    /// The top contributor network flows overall are for a specific metric type, for example,
    /// the number of retransmissions.
    /// </para>
    /// </summary>
    public partial class GetQueryStatusWorkloadInsightsTopContributorsDataRequest : AmazonNetworkFlowMonitorRequest
    {
        private string _queryId;
        private string _scopeId;

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
        /// for a specific root account. A scope ID is returned from a <c>CreateScope</c> API
        /// call.
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