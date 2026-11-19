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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver whose version entries you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamPrefixListResolverId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPrefixListResolverId property is set.
        /// </summary>
        internal bool IsSetIpamPrefixListResolverId() => this.IpamPrefixListResolverId != null;

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverVersion. 
        /// <para>
        /// The version number of the resolver for which to retrieve CIDR entries. If not specified,
        /// the latest version is used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? IpamPrefixListResolverVersion { get; set; }

        /// <summary>
        /// Checks to see if the IpamPrefixListResolverVersion property is set.
        /// </summary>
        internal bool IsSetIpamPrefixListResolverVersion() => this.IpamPrefixListResolverVersion.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
