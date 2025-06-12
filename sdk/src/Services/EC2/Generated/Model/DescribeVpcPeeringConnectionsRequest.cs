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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVpcPeeringConnections operation.
    /// Describes your VPC peering connections. The default is to describe all your VPC peering
    /// connections. Alternatively, you can specify specific VPC peering connection IDs or
    /// filter the results to include only the VPC peering connections that match specific
    /// criteria.
    /// </summary>
    public partial class DescribeVpcPeeringConnectionsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _vpcPeeringConnectionIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>accepter-vpc-info.cidr-block</c> - The IPv4 CIDR block of the accepter VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>accepter-vpc-info.owner-id</c> - The ID of the Amazon Web Services account that
        /// owns the accepter VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>accepter-vpc-info.vpc-id</c> - The ID of the accepter VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>expiration-time</c> - The expiration date and time for the VPC peering connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requester-vpc-info.cidr-block</c> - The IPv4 CIDR block of the requester's VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requester-vpc-info.owner-id</c> - The ID of the Amazon Web Services account that
        /// owns the requester VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requester-vpc-info.vpc-id</c> - The ID of the requester VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status-code</c> - The status of the VPC peering connection (<c>pending-acceptance</c>
        /// | <c>failed</c> | <c>expired</c> | <c>provisioning</c> | <c>active</c> | <c>deleting</c>
        /// | <c>deleted</c> | <c>rejected</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status-message</c> - A message that provides more information about the status
        /// of the VPC peering connection, if applicable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag</c> - The key/value combination of a tag assigned to the resource. Use the
        /// tag key in the filter name and the tag value as the filter value. For example, to
        /// find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpc-peering-connection-id</c> - The ID of the VPC peering connection.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The IDs of the VPC peering connections.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your VPC peering connections.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcPeeringConnectionIds
        {
            get { return this._vpcPeeringConnectionIds; }
            set { this._vpcPeeringConnectionIds = value; }
        }

        // Check to see if VpcPeeringConnectionIds property is set
        internal bool IsSetVpcPeeringConnectionIds()
        {
            return this._vpcPeeringConnectionIds != null && (this._vpcPeeringConnectionIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}