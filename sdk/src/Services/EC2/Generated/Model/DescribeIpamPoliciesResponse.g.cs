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
    /// This is the response object from the DescribeIpamPolicies operation.
    /// </summary>
    public partial class DescribeIpamPoliciesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IpamPolicies. 
        /// <para>
        /// Information about the IPAM policies.
        /// </para>
        ///  
        /// <para>
        /// An IPAM policy is a set of rules that define how public IPv4 addresses from IPAM pools
        /// are allocated to Amazon Web Services resources. Each rule maps an Amazon Web Services
        /// service to IPAM pools that the service will use to get IP addresses. A single policy
        /// can have multiple rules and be applied to multiple Amazon Web Services Regions. If
        /// the IPAM pool run out of addresses then the services fallback to Amazon-provided IP
        /// addresses. A policy can be applied to an individual Amazon Web Services account or
        /// an entity within Amazon Web Services Organizations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamPolicy> IpamPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<IpamPolicy>() : null;

        /// <summary>
        /// Checks to see if the IpamPolicies property is set.
        /// </summary>
        internal bool IsSetIpamPolicies() => this.IpamPolicies != null && (this.IpamPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is <c>null</c> when
        /// there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
