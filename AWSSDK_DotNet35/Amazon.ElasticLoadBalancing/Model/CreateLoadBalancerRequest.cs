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
    /// <para> Creates a new load balancer. </para> <para> After the call has completed successfully, a new load balancer is created with a unique
    /// Domain Name Service (DNS) name. The DNS name includes the name of the AWS region in which the load balance was created. For example, if your
    /// load balancer was created in the United States, the DNS name might end with either of the following:</para>
    /// <ul>
    /// <li> <i>us-east-1.elb.amazonaws.com</i> (for the Northern Virginia Region) </li>
    /// <li> <i>us-west-1.elb.amazonaws.com</i> (for the Northern California Region) </li>
    /// 
    /// </ul>
    /// <para>For information about the AWS regions supported by Elastic Load Balancing, see <a
    /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elb_region" >Regions and Endpoints</a> .</para> <para>You can create up to 10
    /// load balancers per region per account.</para> <para>Elastic Load Balancing supports load balancing your Amazon EC2 instances launched within
    /// any one of the following platforms:</para>
    /// <ul>
    /// <li> <i>EC2-Classic</i> <para>For information on creating and managing your load balancers in EC2-Classic, see <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForEC2.html" >Deploy Elastic Load Balancing in
    /// Amazon EC2-Classic</a> .</para> </li>
    /// <li> <i>EC2-VPC</i> <para>For information on creating and managing your load balancers in EC2-VPC, see <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForVPC.html" >Deploy Elastic Load Balancing in
    /// Amazon VPC</a> .</para> </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class CreateLoadBalancerRequest : AmazonElasticLoadBalancingRequest
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
        /// Zones must be in the same EC2 Region as the load balancer. Traffic will be equally distributed across all zones. You can later add more
        /// Availability Zones after the creation of the load balancer by calling <a>EnableAvailabilityZonesForLoadBalancer</a> action. </param>
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
        /// as the load balancer. Traffic will be equally distributed across all zones. You can later add more Availability Zones after the creation of
        /// the load balancer by calling <a>EnableAvailabilityZonesForLoadBalancer</a> action.
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
        /// A list of subnet IDs in your VPC to attach to your load balancer. Specify one subnet per Availability Zone.
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
        /// The security groups to assign to your load balancer within your VPC.
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
        /// name, which resolves to public IP addresses. For more informationabout Internet-facing and Internal load balancers, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/vpc-loadbalancer-types.html">Internet-facing and Internal Load
        /// Balancers</a>. Specify the value <c>internal</c> for this option to create an internal load balancer with a DNS name that resolves to
        /// private IP addresses. <note> This option is only available for load balancers created within EC2-VPC. </note>
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
    
