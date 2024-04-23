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
    /// Container for the parameters to the DescribeTransitGateways operation.
    /// Describes one or more transit gateways. By default, all transit gateways are described.
    /// Alternatively, you can filter the results.
    /// </summary>
    public partial class DescribeTransitGatewaysRequest : AmazonEC2Request
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _transitGatewayIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>options.propagation-default-route-table-id</c> - The ID of the default propagation
        /// route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.amazon-side-asn</c> - The private ASN for the Amazon side of a BGP session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.association-default-route-table-id</c> - The ID of the default association
        /// route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.auto-accept-shared-attachments</c> - Indicates whether there is automatic
        /// acceptance of attachment requests (<c>enable</c> | <c>disable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.default-route-table-association</c> - Indicates whether resource attachments
        /// are automatically associated with the default association route table (<c>enable</c>
        /// | <c>disable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.default-route-table-propagation</c> - Indicates whether resource attachments
        /// automatically propagate routes to the default propagation route table (<c>enable</c>
        /// | <c>disable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.dns-support</c> - Indicates whether DNS support is enabled (<c>enable</c>
        /// | <c>disable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.vpn-ecmp-support</c> - Indicates whether Equal Cost Multipath Protocol
        /// support is enabled (<c>enable</c> | <c>disable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The ID of the Amazon Web Services account that owns the transit
        /// gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the transit gateway (<c>available</c> | <c>deleted</c>
        /// | <c>deleting</c> | <c>modifying</c> | <c>pending</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-id</c> - The ID of the transit gateway.
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
        /// Gets and sets the property TransitGatewayIds. 
        /// <para>
        /// The IDs of the transit gateways.
        /// </para>
        /// </summary>
        public List<string> TransitGatewayIds
        {
            get { return this._transitGatewayIds; }
            set { this._transitGatewayIds = value; }
        }

        // Check to see if TransitGatewayIds property is set
        internal bool IsSetTransitGatewayIds()
        {
            return this._transitGatewayIds != null && (this._transitGatewayIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}