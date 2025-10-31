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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetIpamPrefixListResolverVersionEntries operation.
    /// Retrieves the CIDR entries for a specific version of an IPAM prefix list resolver.
    /// This shows the actual CIDRs that were selected and synchronized at a particular point
    /// in time.
    /// </summary>
    public partial class GetIpamPrefixListResolverVersionEntriesRequest : AmazonEC2Request
    {
        private string _ipamPrefixListResolverId;
        private long? _ipamPrefixListResolverVersion;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver whose version entries you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamPrefixListResolverId
        {
            get { return this._ipamPrefixListResolverId; }
            set { this._ipamPrefixListResolverId = value; }
        }

        // Check to see if IpamPrefixListResolverId property is set
        internal bool IsSetIpamPrefixListResolverId()
        {
            return this._ipamPrefixListResolverId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverVersion. 
        /// <para>
        /// The version number of the resolver for which to retrieve CIDR entries. If not specified,
        /// the latest version is used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long IpamPrefixListResolverVersion
        {
            get { return this._ipamPrefixListResolverVersion.GetValueOrDefault(); }
            set { this._ipamPrefixListResolverVersion = value; }
        }

        // Check to see if IpamPrefixListResolverVersion property is set
        internal bool IsSetIpamPrefixListResolverVersion()
        {
            return this._ipamPrefixListResolverVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
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