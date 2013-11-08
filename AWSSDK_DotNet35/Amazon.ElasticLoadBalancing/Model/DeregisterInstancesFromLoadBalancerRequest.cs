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
    /// Container for the parameters to the DeregisterInstancesFromLoadBalancer operation.
    /// <para> Deregisters instances from the load balancer. Once the instance is deregistered, it will stop receiving traffic from the load
    /// balancer. </para> <para> In order to successfully call this API, the same account credentials as those used to create the load balancer must
    /// be provided. </para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html" >De-register and Register Amazon
    /// EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para> <para>You can use DescribeLoadBalancers to verify if the
    /// instance is deregistered from the load balancer.</para>
    /// </summary>
    public partial class DeregisterInstancesFromLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private List<Instance> instances = new List<Instance>();

        /// <summary>
        /// Default constructor for a new DeregisterInstancesFromLoadBalancerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DeregisterInstancesFromLoadBalancerRequest() {}
    
        /// <summary>
        /// Constructs a new DeregisterInstancesFromLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        /// <param name="instances"> A list of EC2 instance IDs consisting of all instances to be deregistered. </param>
        public DeregisterInstancesFromLoadBalancerRequest(string loadBalancerName, List<Instance> instances)
        {
            this.loadBalancerName = loadBalancerName;
            this.instances = instances;
        }
    

        /// <summary>
        /// The name associated with the load balancer.
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
        /// A list of EC2 instance IDs consisting of all instances to be deregistered.
        ///  
        /// </summary>
        public List<Instance> Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this.instances.Count > 0;
        }

    }
}
    
