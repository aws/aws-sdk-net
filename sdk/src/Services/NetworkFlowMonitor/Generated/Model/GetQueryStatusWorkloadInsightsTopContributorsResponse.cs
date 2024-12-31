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
    /// This is the response object from the GetQueryStatusWorkloadInsightsTopContributors operation.
    /// </summary>
    public partial class GetQueryStatusWorkloadInsightsTopContributorsResponse : AmazonWebServiceResponse
    {
        private QueryStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// When you run a query, use this call to check the status of the query to make sure
        /// that the query has <c>SUCCEEDED</c> before you review the results.
        /// </para>
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
        [AWSProperty(Required=true)]
        public QueryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}