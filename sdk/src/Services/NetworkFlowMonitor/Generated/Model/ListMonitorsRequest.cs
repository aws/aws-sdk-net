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
    /// Container for the parameters to the ListMonitors operation.
    /// List all monitors in an account. Optionally, you can list only monitors that have
    /// a specific status, by using the <c>STATUS</c> parameter.
    /// </summary>
    public partial class ListMonitorsRequest : AmazonNetworkFlowMonitorRequest
    {
        private int? _maxResults;
        private MonitorStatus _monitorStatus;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of query results that you want to return with this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitorStatus. 
        /// <para>
        /// The status of a monitor. The status can be one of the following
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>: The monitor is in the process of being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The monitor is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c>: The monitor is inactive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c>: Monitor creation failed due to an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: The monitor is in the process of being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MonitorStatus MonitorStatus
        {
            get { return this._monitorStatus; }
            set { this._monitorStatus = value; }
        }

        // Check to see if MonitorStatus property is set
        internal bool IsSetMonitorStatus()
        {
            return this._monitorStatus != null;
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

    }
}