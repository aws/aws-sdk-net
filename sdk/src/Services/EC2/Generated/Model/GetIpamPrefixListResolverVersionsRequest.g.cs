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
    /// Container for the parameters to the GetIpamPrefixListResolverVersions operation. Retrieves
    /// version information for an IPAM prefix list resolver. <para> Each version is a snapshot
    /// of what CIDRs matched your rules at that moment in time. The version number increments
    /// every time the CIDR list changes due to infrastructure changes. </para> <para> <b>Version
    /// example:</b> </para> <para> <b>Initial State (Version 1)</b> </para> <para> Production
    /// environment: </para> <ul> <li> <para> vpc-prod-web (10.1.0.0/16) - tagged env=prod
    /// </para> </li> <li> <para> vpc-prod-db (10.2.0.0/16) - tagged env=prod </para> </li>
    /// </ul> <para> Resolver rule: Include all VPCs tagged env=prod </para> <para> <b>Version
    /// 1 CIDRs:</b> 10.1.0.0/16, 10.2.0.0/16 </para> <para> <b>Infrastructure Change (Version
    /// 2)</b> </para> <para> New VPC added: </para> <ul> <li> <para> vpc-prod-api (10.3.0.0/16)
    /// - tagged env=prod </para> </li> </ul> <para> IPAM automatically detects the change
    /// and creates a new version. </para> <para> <b>Version 2 CIDRs:</b> 10.1.0.0/16, 10.2.0.0/16,
    /// 10.3.0.0/16 </para>
    /// </summary>
    public partial class GetIpamPrefixListResolverVersionsRequest : AmazonEC2Request
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters to limit the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver whose versions you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamPrefixListResolverId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPrefixListResolverId property is set.
        /// </summary>
        internal bool IsSetIpamPrefixListResolverId() => this.IpamPrefixListResolverId != null;

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverVersions. 
        /// <para>
        /// Specific version numbers to retrieve. If not specified, all versions are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<long> IpamPrefixListResolverVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<long>() : null;

        /// <summary>
        /// Checks to see if the IpamPrefixListResolverVersions property is set.
        /// </summary>
        internal bool IsSetIpamPrefixListResolverVersions() => this.IpamPrefixListResolverVersions != null && (this.IpamPrefixListResolverVersions.Count > 0 || !AWSConfigs.InitializeCollections);

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
