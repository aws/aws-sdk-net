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
    /// Container for the parameters to the CreateLoadBalancerPolicy operation. Creates a
    /// policy with the specified attributes for the specified load balancer. <para> Policies
    /// are settings that are saved for your load balancer and that can be applied to the
    /// listener or the application server, depending on the policy type. </para>
    /// </summary>
    public partial class CreateLoadBalancerPolicyRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerName property is set.
        /// </summary>
        internal bool IsSetLoadBalancerName() => this.LoadBalancerName != null;

        /// <summary>
        /// Gets and sets the property PolicyAttributes. 
        /// <para>
        /// The policy attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PolicyAttribute> PolicyAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<PolicyAttribute>() : null;

        /// <summary>
        /// Checks to see if the PolicyAttributes property is set.
        /// </summary>
        internal bool IsSetPolicyAttributes() => this.PolicyAttributes != null && (this.PolicyAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the load balancer policy to be created. This name must be unique within
        /// the set of policies for this load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property PolicyTypeName. 
        /// <para>
        /// The name of the base policy type. To get the list of policy types, use <a>DescribeLoadBalancerPolicyTypes</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PolicyTypeName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyTypeName property is set.
        /// </summary>
        internal bool IsSetPolicyTypeName() => this.PolicyTypeName != null;
    }
}
