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
    /// Container for the parameters to the DescribeIpamPools operation.
    /// Get information about your IPAM pools.
    /// </summary>
    public partial class DescribeIpamPoolsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _ipamPoolIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters for the request. For more information about filtering, see <a
        /// href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-filter.html">Filtering
        /// CLI output</a>.
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpamPoolIds. 
        /// <para>
        /// The IDs of the IPAM pools you would like information on.
        /// </para>
        /// </summary>
        public List<string> IpamPoolIds
        {
            get { return this._ipamPoolIds; }
            set { this._ipamPoolIds = value; }
        }

        // Check to see if IpamPoolIds property is set
        internal bool IsSetIpamPoolIds()
        {
            return this._ipamPoolIds != null && (this._ipamPoolIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the request.
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

    }
}