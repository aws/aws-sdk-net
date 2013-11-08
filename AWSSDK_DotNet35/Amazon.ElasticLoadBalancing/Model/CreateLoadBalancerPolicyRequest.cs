/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLoadBalancerPolicy operation.
    /// <para> Creates a new policy that contains the necessary attributes depending on the policy type. Policies are settings that are saved for
    /// your load balancer and that can be applied to the front-end listener, or the back-end application server, depending on your policy type.
    /// </para>
    /// </summary>
    public partial class CreateLoadBalancerPolicyRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private string policyName;
        private string policyTypeName;
        private List<PolicyAttribute> policyAttributes = new List<PolicyAttribute>();


        /// <summary>
        /// The name associated with the LoadBalancer for which the policy is being created.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;
        }

        /// <summary>
        /// The name of the load balancer policy being created. The name must be unique within the set of policies for this load balancer.
        ///  
        /// </summary>
        public string PolicyName
        {
            get { return this.policyName; }
            set { this.policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this.policyName != null;
        }

        /// <summary>
        /// The name of the base policy type being used to create this policy. To get the list of policy types, use the
        /// <a>DescribeLoadBalancerPolicyTypes</a> action.
        ///  
        /// </summary>
        public string PolicyTypeName
        {
            get { return this.policyTypeName; }
            set { this.policyTypeName = value; }
        }

        // Check to see if PolicyTypeName property is set
        internal bool IsSetPolicyTypeName()
        {
            return this.policyTypeName != null;
        }

        /// <summary>
        /// A list of attributes associated with the policy being created.
        ///  
        /// </summary>
        public List<PolicyAttribute> PolicyAttributes
        {
            get { return this.policyAttributes; }
            set { this.policyAttributes = value; }
        }

        // Check to see if PolicyAttributes property is set
        internal bool IsSetPolicyAttributes()
        {
            return this.policyAttributes.Count > 0;
        }

    }
}
    
