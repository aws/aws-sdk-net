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
    /// Container for the parameters to the DetachLoadBalancerFromSubnets operation.
    /// <para> Removes subnets from the set of configured subnets in the Amazon Virtual Private Cloud (Amazon VPC) for the load balancer. </para>
    /// <para> After a subnet is removed all of the EC2 instances registered with the load balancer that are in the removed subnet will go into the
    /// <i>OutOfService</i> state. When a subnet is removed, the load balancer will balance the traffic among the remaining routable subnets for the
    /// load balancer. </para>
    /// </summary>
    public partial class DetachLoadBalancerFromSubnetsRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private List<string> subnets = new List<string>();


        /// <summary>
        /// The name associated with the load balancer to be detached.
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
        /// A list of subnet IDs to remove from the set of configured subnets for the load balancer.
        ///  
        /// </summary>
        public List<string> Subnets
        {
            get { return this.subnets; }
            set { this.subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this.subnets.Count > 0;
        }

    }
}
    
