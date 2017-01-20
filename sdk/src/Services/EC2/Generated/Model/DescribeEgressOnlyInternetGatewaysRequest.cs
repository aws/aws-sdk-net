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
    /// Container for the parameters to the DescribeEgressOnlyInternetGateways operation.
    /// Describes one or more of your egress-only Internet gateways.
    /// </summary>
    public partial class DescribeEgressOnlyInternetGatewaysRequest : AmazonEC2Request
    {
        private List<string> _egressOnlyInternetGatewayIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EgressOnlyInternetGatewayIds. 
        /// <para>
        /// One or more egress-only Internet gateway IDs.
        /// </para>
        /// </summary>
        public List<string> EgressOnlyInternetGatewayIds
        {
            get { return this._egressOnlyInternetGatewayIds; }
            set { this._egressOnlyInternetGatewayIds = value; }
        }

        // Check to see if EgressOnlyInternetGatewayIds property is set
        internal bool IsSetEgressOnlyInternetGatewayIds()
        {
            return this._egressOnlyInternetGatewayIds != null && this._egressOnlyInternetGatewayIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results can be seen by sending another request with the returned <code>NextToken</code>
        /// value. This value can be between 5 and 1000; if <code>MaxResults</code> is given a
        /// value larger than 1000, only 1000 results are returned.
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