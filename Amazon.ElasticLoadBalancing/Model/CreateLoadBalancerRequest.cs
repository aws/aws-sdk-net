/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateLoadBalancer operation.
    /// <para> Creates a new LoadBalancer. </para> <para> Once the call has completed successfully, a new LoadBalancer is created; however, it will
    /// not be usable until at least one instance has been registered. When the LoadBalancer creation is completed, the client can check whether or
    /// not it is usable by using the DescribeInstanceHealth API. The LoadBalancer is usable as soon as any registered instance is <i>InService</i>
    /// .
    /// </para> <para><b>NOTE:</b> Currently, the client's quota of LoadBalancers is limited to five per Region. </para> <para><b>NOTE:</b>
    /// Load balancer DNS names vary depending on the Region they're created in. For load balancers created in the United States, the DNS name ends
    /// with: us-east-1.elb.amazonaws.com (for the US Standard Region) us-west-1.elb.amazonaws.com (for the Northern California Region) For load
    /// balancers created in the EU (Ireland) Region, the DNS name ends with: eu-west-1.elb.amazonaws.com </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancer"/>
    public class CreateLoadBalancerRequest : AmazonWebServiceRequest
    {
        private string loadBalancerName;
        private List<Listener> listeners = new List<Listener>();
        private List<string> availabilityZones = new List<string>();
        /// <summary>
        /// Default constructor for a new CreateLoadBalancerRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public CreateLoadBalancerRequest() {}
    
        /// <summary>
        /// Constructs a new CreateLoadBalancerRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the LoadBalancer. The name must be unique within your set of LoadBalancers.
        /// </param>
        public CreateLoadBalancerRequest(string loadBalancerName) 
        {
            this.loadBalancerName = loadBalancerName;
        }
    
        /// <summary>
        /// Constructs a new CreateLoadBalancerRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the LoadBalancer. The name must be unique within your set of LoadBalancers.
        /// </param>
        /// <param name="listeners"> A list of the following tuples: LoadBalancerPort, InstancePort, and Protocol. </param>
        /// <param name="availabilityZones"> A list of Availability Zones. At least one Availability Zone must be specified. Specified Availability
        /// Zones must be in the same EC2 Region as the LoadBalancer. Traffic will be equally distributed across all zones. This list can be modified
        /// after the creation of the LoadBalancer. </param>
        public CreateLoadBalancerRequest(string loadBalancerName, List<Listener> listeners, List<string> availabilityZones) 
        {
            this.loadBalancerName = loadBalancerName;
            this.listeners = listeners;
            this.availabilityZones = availabilityZones;
        }
    

        /// <summary>
        /// The name associated with the LoadBalancer. The name must be unique within your set of LoadBalancers.
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
        public CreateLoadBalancerRequest WithLoadBalancerName(string loadBalancerName)
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
        /// A list of the following tuples: LoadBalancerPort, InstancePort, and Protocol.
        ///  
        /// </summary>
        public List<Listener> Listeners
        {
            get { return this.listeners; }
            set { this.listeners = value; }
        }
        /// <summary>
        /// Adds elements to the Listeners collection
        /// </summary>
        /// <param name="listeners">The values to add to the Listeners collection </param>
        /// <returns>this instance</returns>
        public CreateLoadBalancerRequest WithListeners(params Listener[] listeners)
        {
            foreach (Listener element in listeners)
            {
                this.listeners.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Listeners collection
        /// </summary>
        /// <param name="listeners">The values to add to the Listeners collection </param>
        /// <returns>this instance</returns>
        public CreateLoadBalancerRequest WithListeners(IEnumerable<Listener> listeners)
        {
            foreach (Listener element in listeners)
            {
                this.listeners.Add(element);
            }

            return this;
        }

        // Check to see if Listeners property is set
        internal bool IsSetListeners()
        {
            return this.listeners.Count > 0;       
        }

        /// <summary>
        /// A list of Availability Zones. At least one Availability Zone must be specified. Specified Availability Zones must be in the same EC2 Region
        /// as the LoadBalancer. Traffic will be equally distributed across all zones. This list can be modified after the creation of the LoadBalancer.
        ///  
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this.availabilityZones; }
            set { this.availabilityZones = value; }
        }
        /// <summary>
        /// Adds elements to the AvailabilityZones collection
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        public CreateLoadBalancerRequest WithAvailabilityZones(params string[] availabilityZones)
        {
            foreach (string element in availabilityZones)
            {
                this.availabilityZones.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AvailabilityZones collection
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        public CreateLoadBalancerRequest WithAvailabilityZones(IEnumerable<string> availabilityZones)
        {
            foreach (string element in availabilityZones)
            {
                this.availabilityZones.Add(element);
            }

            return this;
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this.availabilityZones.Count > 0;       
        }
    }
}
    
