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
    /// Container for the parameters to the RegisterInstancesWithLoadBalancer operation.
    /// <para> Adds new instances to the LoadBalancer. </para> <para> Once the instance is registered, it starts receiving traffic and requests from
    /// the LoadBalancer. Any instance that is not in any of the Availability Zones registered for the LoadBalancer will be moved to the
    /// <i>OutOfService</i> state. It will move to the <i>InService</i> state when the Availability Zone is added to the LoadBalancer. </para>
    /// <para><b>NOTE:</b> In order for this call to be successful, the client must have created the LoadBalancer. The client must provide the same
    /// account credentials as those that were used to create the LoadBalancer. </para> <para><b>NOTE:</b> Completion of this API does not guarantee
    /// that operation has completed. Rather, it means that the request has been registered and the changes will happen shortly. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.RegisterInstancesWithLoadBalancer"/>
    public class RegisterInstancesWithLoadBalancerRequest : AmazonWebServiceRequest
    {
        private string loadBalancerName;
        private List<Instance> instances = new List<Instance>();
        /// <summary>
        /// Default constructor for a new RegisterInstancesWithLoadBalancerRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public RegisterInstancesWithLoadBalancerRequest() {}
    
        /// <summary>
        /// Constructs a new RegisterInstancesWithLoadBalancerRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the LoadBalancer. The name must be unique within the client AWS account. </param>
        /// <param name="instances"> A list of instance IDs that should be registered with the LoadBalancer. <note>When the instance is stopped and then
        /// restarted, the IP addresses associated with your instance changes. Elastic Load Balancing cannot recognize the new IP address, which
        /// prevents it from routing traffic to your instances. We recommend that you de-register your Amazon EC2 instances from your load balancer
        /// after you stop your instance, and then register the load balancer with your instance after you've restarted. To de-register your instances
        /// from load balancer, use <a>DeregisterInstancesFromLoadBalancer</a> action.</note> </param>
        public RegisterInstancesWithLoadBalancerRequest(string loadBalancerName, List<Instance> instances) 
        {
            this.loadBalancerName = loadBalancerName;
            this.instances = instances;
        }
    

        /// <summary>
        /// The name associated with the LoadBalancer. The name must be unique within the client AWS account.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The value to set for the LoadBalancerName property </param>
        /// <returns>this instance</returns>
        public RegisterInstancesWithLoadBalancerRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
            return this;
        }
            

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;       
        }

        /// <summary>
        /// A list of instance IDs that should be registered with the LoadBalancer. <note>When the instance is stopped and then restarted, the IP
        /// addresses associated with your instance changes. Elastic Load Balancing cannot recognize the new IP address, which prevents it from routing
        /// traffic to your instances. We recommend that you de-register your Amazon EC2 instances from your load balancer after you stop your instance,
        /// and then register the load balancer with your instance after you've restarted. To de-register your instances from load balancer, use
        /// <a>DeregisterInstancesFromLoadBalancer</a> action.</note>
        ///  
        /// </summary>
        public List<Instance> Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }
        /// <summary>
        /// Adds elements to the Instances collection
        /// </summary>
        /// <param name="instances">The values to add to the Instances collection </param>
        /// <returns>this instance</returns>
        public RegisterInstancesWithLoadBalancerRequest WithInstances(params Instance[] instances)
        {
            foreach (Instance element in instances)
            {
                this.instances.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Instances collection
        /// </summary>
        /// <param name="instances">The values to add to the Instances collection </param>
        /// <returns>this instance</returns>
        public RegisterInstancesWithLoadBalancerRequest WithInstances(IEnumerable<Instance> instances)
        {
            foreach (Instance element in instances)
            {
                this.instances.Add(element);
            }

            return this;
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this.instances.Count > 0;       
        }
    }
}
    
