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
    /// Container for the parameters to the GetIpamPolicyAllocationRules operation. Gets the
    /// allocation rules for an IPAM policy. <para> An IPAM policy is a set of rules that
    /// define how public IPv4 addresses from IPAM pools are allocated to Amazon Web Services
    /// resources. Each rule maps an Amazon Web Services service to IPAM pools that the service
    /// will use to get IP addresses. A single policy can have multiple rules and be applied
    /// to multiple Amazon Web Services Regions. If the IPAM pool run out of addresses then
    /// the services fallback to Amazon-provided IP addresses. A policy can be applied to
    /// an individual Amazon Web Services account or an entity within Amazon Web Services
    /// Organizations. </para> <para> Allocation rules are optional configurations within
    /// an IPAM policy that map Amazon Web Services resource types to specific IPAM pools.
    /// If no rules are defined, the resource types default to using Amazon-provided IP addresses.
    /// </para>
    /// </summary>
    public partial class GetIpamPolicyAllocationRulesRequest : AmazonEC2Request
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
        /// One or more filters for the allocation rules.
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
        /// Gets and sets the property IpamPolicyId. 
        /// <para>
        /// The ID of the IPAM policy for which to get allocation rules.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPolicyId property is set.
        /// </summary>
        internal bool IsSetIpamPolicyId() => this.IpamPolicyId != null;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale for which to get the allocation rules.
        /// </para>
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
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

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type for which to get the allocation rules.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services service or resource type that can use IP addresses through
        /// IPAM policies. Supported services and resource types include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Elastic IP addresses
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamPolicyResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
