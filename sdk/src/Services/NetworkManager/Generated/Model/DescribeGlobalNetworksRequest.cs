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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeGlobalNetworks operation.
    /// Describes one or more global networks. By default, all global networks are described.
    /// To describe the objects in your global network, you must use the appropriate <code>Get*</code>
    /// action. For example, to list the transit gateways in your global network, use <a>GetTransitGatewayRegistrations</a>.
    /// </summary>
    public partial class DescribeGlobalNetworksRequest : AmazonNetworkManagerRequest
    {
        private List<string> _globalNetworkIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property GlobalNetworkIds. 
        /// <para>
        /// The IDs of one or more global networks. The maximum is 10.
        /// </para>
        /// </summary>
        public List<string> GlobalNetworkIds
        {
            get { return this._globalNetworkIds; }
            set { this._globalNetworkIds = value; }
        }

        // Check to see if GlobalNetworkIds property is set
        internal bool IsSetGlobalNetworkIds()
        {
            return this._globalNetworkIds != null && this._globalNetworkIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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

    }
}