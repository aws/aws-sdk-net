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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the ListFirewalls operation.
    /// Retrieves the metadata for the firewalls that you have defined. If you provide VPC
    /// identifiers in your request, this returns only the firewalls for those VPCs.
    /// 
    ///  
    /// <para>
    /// Depending on your setting for max results and the number of firewalls, a single call
    /// might not return the full list. 
    /// </para>
    /// </summary>
    public partial class ListFirewallsRequest : AmazonNetworkFirewallRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _vpcIds = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects that you want Network Firewall to return for this request.
        /// If more objects are available, in the response, Network Firewall provides a <code>NextToken</code>
        /// value that you can use in a subsequent call to get the next batch of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// When you request a list of objects with a <code>MaxResults</code> setting, if the
        /// number of objects that are still available for retrieval exceeds the maximum you requested,
        /// Network Firewall returns a <code>NextToken</code> value in the response. To retrieve
        /// the next batch of objects, use the token returned from the prior request in your next
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property VpcIds. 
        /// <para>
        /// The unique identifiers of the VPCs that you want Network Firewall to retrieve the
        /// firewalls for. Leave this blank to retrieve all firewalls that you have defined.
        /// </para>
        /// </summary>
        public List<string> VpcIds
        {
            get { return this._vpcIds; }
            set { this._vpcIds = value; }
        }

        // Check to see if VpcIds property is set
        internal bool IsSetVpcIds()
        {
            return this._vpcIds != null && this._vpcIds.Count > 0; 
        }

    }
}