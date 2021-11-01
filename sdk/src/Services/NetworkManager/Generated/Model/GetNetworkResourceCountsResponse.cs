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
    /// This is the response object from the GetNetworkResourceCounts operation.
    /// </summary>
    public partial class GetNetworkResourceCountsResponse : AmazonWebServiceResponse
    {
        private List<NetworkResourceCount> _networkResourceCounts = new List<NetworkResourceCount>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property NetworkResourceCounts. 
        /// <para>
        /// The count of resources.
        /// </para>
        /// </summary>
        public List<NetworkResourceCount> NetworkResourceCounts
        {
            get { return this._networkResourceCounts; }
            set { this._networkResourceCounts = value; }
        }

        // Check to see if NetworkResourceCounts property is set
        internal bool IsSetNetworkResourceCounts()
        {
            return this._networkResourceCounts != null && this._networkResourceCounts.Count > 0; 
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