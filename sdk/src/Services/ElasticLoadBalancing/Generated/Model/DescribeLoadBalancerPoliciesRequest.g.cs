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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLoadBalancerPolicies operation. Describes
    /// the specified policies. <para> If you specify a load balancer name, the action returns
    /// the descriptions of all policies created for the load balancer. If you specify a policy
    /// name associated with your load balancer, the action returns the description of that
    /// policy. If you don't specify a load balancer name, the action returns descriptions
    /// of the specified sample policies, or descriptions of all sample policies. The names
    /// of the sample policies have the <c>ELBSample-</c> prefix. </para>
    /// </summary>
    public partial class DescribeLoadBalancerPoliciesRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerName property is set.
        /// </summary>
        internal bool IsSetLoadBalancerName() => this.LoadBalancerName != null;

        /// <summary>
        /// Gets and sets the property PolicyNames. 
        /// <para>
        /// The names of the policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PolicyNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PolicyNames property is set.
        /// </summary>
        internal bool IsSetPolicyNames() => this.PolicyNames != null && (this.PolicyNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
