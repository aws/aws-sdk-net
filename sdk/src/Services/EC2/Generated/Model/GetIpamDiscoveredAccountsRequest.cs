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
    /// Container for the parameters to the GetIpamDiscoveredAccounts operation.
    /// Gets IPAM discovered accounts. A discovered account is an Amazon Web Services account
    /// that is monitored under a resource discovery. If you have integrated IPAM with Amazon
    /// Web Services Organizations, all accounts in the organization are discovered accounts.
    /// Only the IPAM account can get all discovered accounts in the organization.
    /// </summary>
    public partial class GetIpamDiscoveredAccountsRequest : AmazonEC2Request
    {
        private string _discoveryRegion;
        private List<Filter> _filters = new List<Filter>();
        private string _ipamResourceDiscoveryId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DiscoveryRegion. 
        /// <para>
        /// The Amazon Web Services Region that the account information is returned from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DiscoveryRegion
        {
            get { return this._discoveryRegion; }
            set { this._discoveryRegion = value; }
        }

        // Check to see if DiscoveryRegion property is set
        internal bool IsSetDiscoveryRegion()
        {
            return this._discoveryRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Discovered account filters.
        /// </para>
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
        /// Gets and sets the property IpamResourceDiscoveryId. 
        /// <para>
        /// A resource discovery ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamResourceDiscoveryId
        {
            get { return this._ipamResourceDiscoveryId; }
            set { this._ipamResourceDiscoveryId = value; }
        }

        // Check to see if IpamResourceDiscoveryId property is set
        internal bool IsSetIpamResourceDiscoveryId()
        {
            return this._ipamResourceDiscoveryId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of discovered accounts to return in one page of results.
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
        /// Specify the pagination token from a previous request to retrieve the next page of
        /// results.
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