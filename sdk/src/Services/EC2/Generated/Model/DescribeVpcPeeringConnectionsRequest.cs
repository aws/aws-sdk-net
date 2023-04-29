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
    /// Container for the parameters to the DescribeVpcPeeringConnections operation.
    /// Describes one or more of your VPC peering connections.
    /// </summary>
    public partial class DescribeVpcPeeringConnectionsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _vpcPeeringConnectionIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>accepter-vpc-info.cidr-block</code> - The IPv4 CIDR block of the accepter VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>accepter-vpc-info.owner-id</code> - The ID of the Amazon Web Services account
        /// that owns the accepter VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>accepter-vpc-info.vpc-id</code> - The ID of the accepter VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>expiration-time</code> - The expiration date and time for the VPC peering connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>requester-vpc-info.cidr-block</code> - The IPv4 CIDR block of the requester's
        /// VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>requester-vpc-info.owner-id</code> - The ID of the Amazon Web Services account
        /// that owns the requester VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>requester-vpc-info.vpc-id</code> - The ID of the requester VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>status-code</code> - The status of the VPC peering connection (<code>pending-acceptance</code>
        /// | <code>failed</code> | <code>expired</code> | <code>provisioning</code> | <code>active</code>
        /// | <code>deleting</code> | <code>deleted</code> | <code>rejected</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>status-message</code> - A message that provides more information about the
        /// status of the VPC peering connection, if applicable.
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
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-peering-connection-id</code> - The ID of the VPC peering connection.
        /// </para>
        ///  </li> </ul>
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
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
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
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
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
        /// Gets and sets the property VpcPeeringConnectionIds. 
        /// <para>
        /// One or more VPC peering connection IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your VPC peering connections.
        /// </para>
        /// </summary>
        public List<string> VpcPeeringConnectionIds
        {
            get { return this._vpcPeeringConnectionIds; }
            set { this._vpcPeeringConnectionIds = value; }
        }

        // Check to see if VpcPeeringConnectionIds property is set
        internal bool IsSetVpcPeeringConnectionIds()
        {
            return this._vpcPeeringConnectionIds != null && this._vpcPeeringConnectionIds.Count > 0; 
        }

    }
}