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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFlowLogs operation.
    /// Describes one or more flow logs. To view the information in your flow logs (the log
    /// streams for the network interfaces), you must use the CloudWatch Logs console or the
    /// CloudWatch Logs API.
    /// </summary>
    public partial class DescribeFlowLogsRequest : AmazonEC2Request
    {
        private List<Filter> _filter = new List<Filter>();
        private List<string> _flowLogIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>deliver-log-status</code> - The status of the logs delivery (<code>SUCCESS</code>
        /// | <code>FAILED</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>log-destination-type</code> - The type of destination to which the flow log
        /// publishes data. Possible destination types include <code>cloud-watch-logs</code> and
        /// <code>S3</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>flow-log-id</code> - The ID of the flow log.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>log-group-name</code> - The name of the log group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resource-id</code> - The ID of the VPC, subnet, or network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>traffic-type</code> - The type of traffic (<code>ACCEPT</code> | <code>REJECT</code>
        /// | <code>ALL</code>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && this._filter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FlowLogIds. 
        /// <para>
        /// One or more flow log IDs.
        /// </para>
        /// </summary>
        public List<string> FlowLogIds
        {
            get { return this._flowLogIds; }
            set { this._flowLogIds = value; }
        }

        // Check to see if FlowLogIds property is set
        internal bool IsSetFlowLogIds()
        {
            return this._flowLogIds != null && this._flowLogIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results can be seen by sending another request with the returned <code>NextToken</code>
        /// value. This value can be between 5 and 1000. If <code>MaxResults</code> is given a
        /// value larger than 1000, only 1000 results are returned. You cannot specify this parameter
        /// and the flow log IDs parameter in the same request.
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
        /// The token to retrieve the next page of results.
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