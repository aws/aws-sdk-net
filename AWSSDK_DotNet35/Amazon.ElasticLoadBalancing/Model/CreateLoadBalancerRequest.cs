/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
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
    /// Creates a new load balancer. 
    /// 
    ///  
    /// <para>
    ///  After the call has completed successfully, a new load balancer is created with a
    /// unique Domain Name Service (DNS) name. The DNS name includes the name of the AWS region
    /// in which the load balance was created. For example, if your load balancer was created
    /// in the United States, the DNS name might end with either of the following:
    /// </para>
    ///  <ul> <li> <i>us-east-1.elb.amazonaws.com</i> (for the Northern Virginia region) </li>
    /// <li> <i>us-west-1.elb.amazonaws.com</i> (for the Northern California region) </li>
    /// </ul> 
    /// <para>
    /// For information about the AWS regions supported by Elastic Load Balancing, see <a
    /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elb_region">Regions
    /// and Endpoints</a>.
    /// </para>
    ///  
    /// <para>
    /// You can create up to 20 load balancers per region per account.
    /// </para>
    ///  
    /// <para>
    /// Elastic Load Balancing supports load balancing your Amazon EC2 instances launched
    /// within any one of the following platforms:
    /// </para>
    ///  <ul> <li> <i>EC2-Classic</i> 
    /// <para>
    /// For information on creating and managing your load balancers in EC2-Classic, see <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForEC2.html">Deploy
    /// Elastic Load Balancing in Amazon EC2-Classic</a>.
    /// </para>
    ///  </li> <li> <i>EC2-VPC</i> 
    /// <para>
    /// For information on creating and managing your load balancers in EC2-VPC, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForVPC.html">Deploy
    /// Elastic Load Balancing in Amazon VPC</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private List<string> _availabilityZones = new List<string>();
        private List<Listener> _listeners = new List<Listener>();
        private string _loadBalancerName;
        private string _scheme;
        private List<string> _securityGroups = new List<string>();
        private List<string> _subnets = new List<string>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateLoadBalancerRequest() { }

        /// <summary>
        /// Instantiates CreateLoadBalancerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The name associated with the load balancer.   The name must be unique within your set of load balancers, must have a maximum of 32 characters, and must only contain alphanumeric characters or hyphens. </param>
        public CreateLoadBalancerRequest(string loadBalancerName)
        {
            _loadBalancerName = loadBalancerName;
        }

        /// <summary>
        /// Instantiates CreateLoadBalancerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The name associated with the load balancer.   The name must be unique within your set of load balancers, must have a maximum of 32 characters, and must only contain alphanumeric characters or hyphens. </param>
        /// <param name="listeners"> A list of the following tuples: Protocol, LoadBalancerPort, InstanceProtocol, InstancePort, and SSLCertificateId.  For information about the protocols and the ports supported by Elastic Load Balancing, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/elb-listener-config.html">Listener Configurations for Elastic Load Balancing</a>.</param>
        /// <param name="availabilityZones"> A list of Availability Zones.   At least one Availability Zone must be specified. Specified Availability Zones must be in the same EC2 Region as the load balancer. Traffic will be equally distributed across all zones.   You can later add more Availability Zones after the creation of the load balancer by calling <a>EnableAvailabilityZonesForLoadBalancer</a> action. </param>
        public CreateLoadBalancerRequest(string loadBalancerName, List<Listener> listeners, List<string> availabilityZones)
        {
            _loadBalancerName = loadBalancerName;
            _listeners = listeners;
            _availabilityZones = availabilityZones;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        ///  A list of Availability Zones. 
        /// </para>
        ///  
        /// <para>
        ///  At least one Availability Zone must be specified. Specified Availability Zones must
        /// be in the same EC2 Region as the load balancer. Traffic will be equally distributed
        /// across all zones. 
        /// </para>
        ///  
        /// <para>
        ///  You can later add more Availability Zones after the creation of the load balancer
        /// by calling <a>EnableAvailabilityZonesForLoadBalancer</a> action. 
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Listeners. 
        /// <para>
        ///  A list of the following tuples: Protocol, LoadBalancerPort, InstanceProtocol, InstancePort,
        /// and SSLCertificateId. 
        /// </para>
        ///  
        /// <para>
        /// For information about the protocols and the ports supported by Elastic Load Balancing,
        /// see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/elb-listener-config.html">Listener
        /// Configurations for Elastic Load Balancing</a>.
        /// </para>
        /// </summary>
        public List<Listener> Listeners
        {
            get { return this._listeners; }
            set { this._listeners = value; }
        }

        // Check to see if Listeners property is set
        internal bool IsSetListeners()
        {
            return this._listeners != null && this._listeners.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The name associated with the load balancer. 
        /// </para>
        ///  
        /// <para>
        ///  The name must be unique within your set of load balancers, must have a maximum of
        /// 32 characters, and must only contain alphanumeric characters or hyphens. 
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property Scheme. 
        /// <para>
        /// The type of a load balancer. 
        /// </para>
        ///  
        /// <para>
        /// By default, Elastic Load Balancing creates an Internet-facing load balancer with a
        /// publicly resolvable DNS name, which resolves to public IP addresses. For more information
        /// about Internet-facing and Internal load balancers, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/vpc-loadbalancer-types.html">Internet-facing
        /// and Internal Load Balancers</a>.
        /// </para>
        ///  
        /// <para>
        /// Specify the value <code>internal</code> for this option to create an internal load
        /// balancer with a DNS name that resolves to private IP addresses.
        /// </para>
        ///  <note> 
        /// <para>
        /// This option is only available for load balancers created within EC2-VPC.
        /// </para>
        ///  </note>
        /// </summary>
        public string Scheme
        {
            get { return this._scheme; }
            set { this._scheme = value; }
        }

        // Check to see if Scheme property is set
        internal bool IsSetScheme()
        {
            return this._scheme != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        ///  The security groups to assign to your load balancer within your VPC. 
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        ///  A list of subnet IDs in your VPC to attach to your load balancer. Specify one subnet
        /// per Availability Zone. 
        /// </para>
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to assign to the load balancer.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting tags for your load balancer, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#tagging-elb">Tagging</a>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}