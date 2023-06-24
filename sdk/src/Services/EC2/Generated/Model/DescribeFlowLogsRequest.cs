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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFlowLogs operation.
    /// Describes one or more flow logs.
    /// 
    ///  
    /// <para>
    /// To view the published flow log records, you must view the log destination. For example,
    /// the CloudWatch Logs log group, the Amazon S3 bucket, or the Kinesis Data Firehose
    /// delivery stream.
    /// </para>
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
        ///  <code>log-destination-type</code> - The type of destination for the flow log data
        /// (<code>cloud-watch-logs</code> | <code>s3</code> | <code>kinesis-data-firehose</code>).
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
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
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
        ///  
        /// <para>
        /// Constraint: Maximum of 1000 flow log IDs.
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
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
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
        /// The token to request the next page of items. Pagination continues from the end of
        /// the items returned by the previous request.
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