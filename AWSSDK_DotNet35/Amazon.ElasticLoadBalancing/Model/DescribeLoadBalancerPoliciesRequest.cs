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
    /// Container for the parameters to the DescribeLoadBalancerPolicies operation.
    /// <para>Returns detailed descriptions of the policies. If you specify a load balancer name, the action returns the descriptions of all the
    /// policies created for the load balancer. If you specify a policy name associated with your load balancer, the action returns the description
    /// of that policy. If you don't specify a load balancer name, the action returns descriptions of the specified sample policies, or descriptions
    /// of all the sample policies. The names of the sample policies have the <c>ELBSample-</c> prefix. </para>
    /// </summary>
    public partial class DescribeLoadBalancerPoliciesRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private List<string> policyNames = new List<string>();


        /// <summary>
        /// The mnemonic name associated with the load balancer. If no name is specified, the operation returns the attributes of either all the sample
        /// policies pre-defined by Elastic Load Balancing or the specified sample polices.
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
        /// The names of load balancer policies you've created or Elastic Load Balancing sample policy names.
        ///  
        /// </summary>
        public List<string> PolicyNames
        {
            get { return this.policyNames; }
            set { this.policyNames = value; }
        }

        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this.policyNames.Count > 0;
        }

    }
}
    
