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
    /// Container for the parameters to the DescribeTransitGateways operation.
    /// Describes one or more transit gateways. By default, all transit gateways are described.
    /// Alternatively, you can filter the results.
    /// </summary>
    public partial class DescribeTransitGatewaysRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _transitGatewayIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>options.propagation-default-route-table-id</code> - The ID of the default propagation
        /// route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>options.amazon-side-asn</code> - The private ASN for the Amazon side of a BGP
        /// session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>options.association-default-route-table-id</code> - The ID of the default association
        /// route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>options.auto-accept-shared-attachments</code> - Indicates whether there is
        /// automatic acceptance of attachment requests (<code>enable</code> | <code>disable</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>options.default-route-table-association</code> - Indicates whether resource
        /// attachments are automatically associated with the default association route table
        /// (<code>enable</code> | <code>disable</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>options.default-route-table-propagation</code> - Indicates whether resource
        /// attachments automatically propagate routes to the default propagation route table
        /// (<code>enable</code> | <code>disable</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>options.dns-support</code> - Indicates whether DNS support is enabled (<code>enable</code>
        /// | <code>disable</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>options.vpn-ecmp-support</code> - Indicates whether Equal Cost Multipath Protocol
        /// support is enabled (<code>enable</code> | <code>disable</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The ID of the AWS account that owns the transit gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the attachment (<code>available</code> | <code>deleted</code>
        /// | <code>deleting</code> | <code>failed</code> | <code>modifying</code> | <code>pendingAcceptance</code>
        /// | <code>pending</code> | <code>rollingBack</code> | <code>rejected</code> | <code>rejecting</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway-id</code> - The ID of the transit gateway.
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
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
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
            return this._transitGatewayIds != null && this._transitGatewayIds.Count > 0; 
        }

    }
}