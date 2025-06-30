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
    /// Container for the parameters to the GetQueryStatusMonitorTopContributors operation.
    /// Returns the current status of a query for the Network Flow Monitor query interface,
    /// for a specified query ID and monitor. This call returns the query status for the top
    /// contributors for a monitor.
    /// 
    ///  
    /// <para>
    /// When you create a query, use this call to check the status of the query to make sure
    /// that it has has <c>SUCCEEDED</c> before you review the results. Use the same query
    /// ID that you used for the corresponding API call to start (create) the query, <c>StartQueryMonitorTopContributors</c>.
    /// </para>
    ///  
    /// <para>
    /// When you run a query, use this call to check the status of the query to make sure
    /// that the query has <c>SUCCEEDED</c> before you review the results.
    /// </para>
    /// </summary>
    public partial class GetQueryStatusMonitorTopContributorsRequest : AmazonNetworkFlowMonitorRequest
    {
        private string _monitorName;
        private string _queryId;

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MonitorName
        {
            get { return this._monitorName; }
            set { this._monitorName = value; }
        }

        // Check to see if MonitorName property is set
        internal bool IsSetMonitorName()
        {
            return this._monitorName != null;
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

    }
}