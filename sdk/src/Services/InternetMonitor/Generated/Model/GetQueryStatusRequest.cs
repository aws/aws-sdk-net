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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
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
namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the GetQueryStatus operation.
    /// Returns the current status of a query for the Amazon CloudWatch Internet Monitor query
    /// interface, for a specified query ID and monitor. When you run a query, check the status
    /// to make sure that the query has <c>SUCCEEDED</c> before you review the results.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>QUEUED</c>: The query is scheduled to run.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RUNNING</c>: The query is in progress but not complete.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SUCCEEDED</c>: The query completed sucessfully.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>FAILED</c>: The query failed due to an error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CANCELED</c>: The query was canceled.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetQueryStatusRequest : AmazonInternetMonitorRequest
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
        /// The ID of the query that you want to return the status for. A <c>QueryId</c> is an
        /// internally-generated dentifier for a specific query.
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