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
    /// Container for the parameters to the GetIpamDiscoveredResourceCidrs operation.
    /// Returns the resource CIDRs that are monitored as part of a resource discovery. A discovered
    /// resource is a resource CIDR monitored under a resource discovery. The following resources
    /// can be discovered: VPCs, Public IPv4 pools, VPC subnets, and Elastic IP addresses.
    /// </summary>
    public partial class GetIpamDiscoveredResourceCidrsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private string _ipamResourceDiscoveryId;
        private int? _maxResults;
        private string _nextToken;
        private string _resourceRegion;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters.
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
        /// The maximum number of discovered resource CIDRs to return in one page of results.
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

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// A resource Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceRegion
        {
            get { return this._resourceRegion; }
            set { this._resourceRegion = value; }
        }

        // Check to see if ResourceRegion property is set
        internal bool IsSetResourceRegion()
        {
            return this._resourceRegion != null;
        }

    }
}