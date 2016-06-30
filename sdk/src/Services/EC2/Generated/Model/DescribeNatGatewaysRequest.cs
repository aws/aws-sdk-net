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
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
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
    /// Container for the parameters to the DescribeNatGateways operation.
    /// Describes one or more of the your NAT gateways.
    /// </summary>
    public partial class DescribeNatGatewaysRequest : AmazonEC2Request
    {
        private List<Filter> _filter = new List<Filter>();
        private int? _maxResults;
        private List<string> _natGatewayIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>nat-gateway-id</code> - The ID of the NAT gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the NAT gateway (<code>pending</code> | <code>failed</code>
        /// | <code>available</code> | <code>deleting</code> | <code>deleted</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>subnet-id</code> - The ID of the subnet in which the NAT gateway resides.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-id</code> - The ID of the VPC in which the NAT gateway resides.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. The request returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        ///  
        /// <para>
        /// Constraint: If the value specified is greater than 1000, we return only 1000 items.
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
        /// Gets and sets the property NatGatewayIds. 
        /// <para>
        /// One or more NAT gateway IDs.
        /// </para>
        /// </summary>
        public List<string> NatGatewayIds
        {
            get { return this._natGatewayIds; }
            set { this._natGatewayIds = value; }
        }

        // Check to see if NatGatewayIds property is set
        internal bool IsSetNatGatewayIds()
        {
            return this._natGatewayIds != null && this._natGatewayIds.Count > 0; 
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