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
    /// Container for the parameters to the CreateLoadBalancer operation.
    /// <para> Creates a new load balancer. </para> <para> After the call has completed successfully, a new load balancer is created; however, it
    /// will not be usable until at least one instance has been registered. When the load balancer creation is completed, the client can check
    /// whether or not it is usable by using the DescribeInstanceHealth action. The load balancer is usable as soon as any registered instance is
    /// <i>InService</i> .
    /// </para> <para><b>NOTE:</b> Currently, the client's quota of load balancers is limited to ten per Region. </para> <para><b>NOTE:</b>
    /// Load balancer DNS names vary depending on the Region they're created in. For load balancers created in the United States, the DNS name ends
    /// with: us-east-1.elb.amazonaws.com (for the Northern Virginia Region) us-west-1.elb.amazonaws.com (for the Northern California Region) For
    /// load balancers created in the EU (Ireland) Region, the DNS name ends with: eu-west-1.elb.amazonaws.com </para> <para>For information on
    /// using CreateLoadBalancer to create a new load balancer in Amazon EC2, go to <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/creating_lb_QueryAPI.html" >Using Query API</a> section in the
    /// <i>Creating a Load Balancer With SSL Cipher Settings and Back-end Authentication</i> topic of the <i>Elastic Load Balancing Developer
    /// Guide</i> .</para> <para>For information on using CreateLoadBalancer to create a new load balancer in Amazon VPC, see <i>Using the Query
    /// API</i> in the <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/USVPC_creating_basic_lb.html" >Creating a
    /// Basic Load Balancer in Amazon VPC</a> section in the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// </summary>
    public partial class CreateLoadBalancerRequest : AmazonWebServiceRequest
    {
        private string loadBalancerName;
        private List<Listener> listeners = new List<Listener>();
        private List<string> availabilityZones = new List<string>();
        private List<string> subnets = new List<string>();
        private List<string> securityGroups = new List<string>();
        private string scheme;
        /// <summary>
        /// Default constructor for a new CreateLoadBalancerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public CreateLoadBalancerRequest() {}
    
        /// <summary>
        /// Constructs a new CreateLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. The name must be unique within your set of load balancers.
        /// </param>
        public CreateLoadBalancerRequest(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
        }
    
        /// <summary>
        /// Constructs a new CreateLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. The name must be unique within your set of load balancers.
        /// </param>
        /// <param name="listeners"> A list of the following tuples: LoadBalancerPort, InstancePort, and Protocol. </param>
        /// <param name="availabilityZones"> A list of Availability Zones. At least one Availability Zone must be specified. Specified Availability
        /// Zones must be in the same EC2 Region as the load balancer. Traffic will be equally distributed across all zones. This list can be modified
        /// after the creation of the load balancer by calling <a>EnableAvailabilityZonesForLoadBalancer</a>. </param>
        public CreateLoadBalancerRequest(string loadBalancerName, List<Listener> listeners, List<string> availabilityZones)
        {
            this.loadBalancerName = loadBalancerName;
            this.listeners = listeners;
            this.availabilityZones = availabilityZones;
        }
    

        /// <summary>
        /// The name associated with the load balancer. The name must be unique within your set of load balancers.
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
        /// A list of the following tuples: LoadBalancerPort, InstancePort, and Protocol.
        ///  
        /// </summary>
        public List<Listener> Listeners
        {
            get { return this.listeners; }
            set { this.listeners = value; }
        }

        // Check to see if Listeners property is set
        internal bool IsSetListeners()
        {
            return this.listeners.Count > 0;
        }

        /// <summary>
        /// A list of Availability Zones. At least one Availability Zone must be specified. Specified Availability Zones must be in the same EC2 Region
        /// as the load balancer. Traffic will be equally distributed across all zones. This list can be modified after the creation of the load
        /// balancer by calling <a>EnableAvailabilityZonesForLoadBalancer</a>.
        ///  
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this.availabilityZones; }
            set { this.availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this.availabilityZones.Count > 0;
        }

        /// <summary>
        /// A list of subnet IDs in your VPC to attach to your load balancer.
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

        /// <summary>
        /// The security groups assigned to your load balancer within your VPC.
        ///  
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this.securityGroups; }
            set { this.securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this.securityGroups.Count > 0;
        }

        /// <summary>
        /// The type of a load balancer. By default, Elastic Load Balancing creates an Internet-facing load balancer with a publicly resolvable DNS
        /// name, which resolves to public IP addresses. Specify the value <c>internal</c> for this option to create an internal load balancer with a
        /// DNS name that resolves to private IP addresses. This option is only available for load balancers attached to an Amazon VPC.
        ///  
        /// </summary>
        public string Scheme
        {
            get { return this.scheme; }
            set { this.scheme = value; }
        }

        // Check to see if Scheme property is set
        internal bool IsSetScheme()
        {
            return this.scheme != null;
        }

    }
}
    
