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
    /// Container for the parameters to the SearchTransitGatewayMulticastGroups operation.
    /// Searches one or more transit gateway multicast groups and returns the group membership
    /// information.
    /// </summary>
    public partial class SearchTransitGatewayMulticastGroupsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _transitGatewayMulticastDomainId;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>group-ip-address</c> - The IP address of the transit gateway multicast group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>is-group-member</c> - The resource is a group member. Valid values are <c>true</c>
        /// | <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>is-group-source</c> - The resource is a group source. Valid values are <c>true</c>
        /// | <c>false</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>member-type</c> - The member type. Valid values are <c>igmp</c> | <c>static</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource-id</c> - The ID of the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource-type</c> - The type of resource. Valid values are <c>vpc</c> | <c>vpn</c>
        /// | <c>direct-connect-gateway</c> | <c>tgw-peering</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source-type</c> - The source type. Valid values are <c>igmp</c> | <c>static</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>subnet-id</c> - The ID of the subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-attachment-id</c> - The id of the transit gateway attachment.
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <c>nextToken</c> value.
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
        /// The token for the next page of results.
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
        /// Gets and sets the property TransitGatewayMulticastDomainId. 
        /// <para>
        /// The ID of the transit gateway multicast domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayMulticastDomainId
        {
            get { return this._transitGatewayMulticastDomainId; }
            set { this._transitGatewayMulticastDomainId = value; }
        }

        // Check to see if TransitGatewayMulticastDomainId property is set
        internal bool IsSetTransitGatewayMulticastDomainId()
        {
            return this._transitGatewayMulticastDomainId != null;
        }

    }
}