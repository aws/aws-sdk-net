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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> Contains the result of a successful invocation of DescribeLoadBalancers. </para>
    /// </summary>
    public class LoadBalancerDescription  
    {
        
        private string loadBalancerName;
        private string dNSName;
        private string canonicalHostedZoneName;
        private string canonicalHostedZoneNameID;
        private List<ListenerDescription> listenerDescriptions = new List<ListenerDescription>();
        private Policies policies;
        private List<BackendServerDescription> backendServerDescriptions = new List<BackendServerDescription>();
        private List<string> availabilityZones = new List<string>();
        private List<string> subnets = new List<string>();
        private string vPCId;
        private List<Instance> instances = new List<Instance>();
        private HealthCheck healthCheck;
        private SourceSecurityGroup sourceSecurityGroup;
        private List<string> securityGroups = new List<string>();
        private DateTime? createdTime;
        private string scheme;
        /// <summary>
        /// Default constructor for a new LoadBalancerDescription object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public LoadBalancerDescription() {}
    

        /// <summary>
        /// Specifies the name associated with the LoadBalancer.
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
        public LoadBalancerDescription WithLoadBalancerName(string loadBalancerName)
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
        /// Specifies the external DNS name associated with the LoadBalancer.
        ///  
        /// </summary>
        public string DNSName
        {
            get { return this.dNSName; }
            set { this.dNSName = value; }
        }

        /// <summary>
        /// Sets the DNSName property
        /// </summary>
        /// <param name="dNSName">The value to set for the DNSName property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithDNSName(string dNSName)
        {
            this.dNSName = dNSName;
            return this;
        }
            

        // Check to see if DNSName property is set
        internal bool IsSetDNSName()
        {
            return this.dNSName != null;       
        }

        /// <summary>
        /// Provides the name of the Amazon Route 53 hosted zone that is associated with the LoadBalancer. For information on how to associate your load
        /// balancer with a hosted zone, go to <a
        /// href="http://docs.amazonwebservices.com/ElasticLoadBalancing/latest/DeveloperGuide/using-domain-names-with-elb.html">Using Domain Names With
        /// Elastic Load Balancing</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        ///  
        /// </summary>
        public string CanonicalHostedZoneName
        {
            get { return this.canonicalHostedZoneName; }
            set { this.canonicalHostedZoneName = value; }
        }

        /// <summary>
        /// Sets the CanonicalHostedZoneName property
        /// </summary>
        /// <param name="canonicalHostedZoneName">The value to set for the CanonicalHostedZoneName property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithCanonicalHostedZoneName(string canonicalHostedZoneName)
        {
            this.canonicalHostedZoneName = canonicalHostedZoneName;
            return this;
        }
            

        // Check to see if CanonicalHostedZoneName property is set
        internal bool IsSetCanonicalHostedZoneName()
        {
            return this.canonicalHostedZoneName != null;       
        }

        /// <summary>
        /// Provides the ID of the Amazon Route 53 hosted zone name that is associated with the LoadBalancer. For information on how to associate or
        /// disassociate your load balancer with a hosted zone, go to <a
        /// href="http://docs.amazonwebservices.com/ElasticLoadBalancing/latest/DeveloperGuide/using-domain-names-with-elb.html">Using Domain Names With
        /// Elastic Load Balancing</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        ///  
        /// </summary>
        public string CanonicalHostedZoneNameID
        {
            get { return this.canonicalHostedZoneNameID; }
            set { this.canonicalHostedZoneNameID = value; }
        }

        /// <summary>
        /// Sets the CanonicalHostedZoneNameID property
        /// </summary>
        /// <param name="canonicalHostedZoneNameID">The value to set for the CanonicalHostedZoneNameID property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithCanonicalHostedZoneNameID(string canonicalHostedZoneNameID)
        {
            this.canonicalHostedZoneNameID = canonicalHostedZoneNameID;
            return this;
        }
            

        // Check to see if CanonicalHostedZoneNameID property is set
        internal bool IsSetCanonicalHostedZoneNameID()
        {
            return this.canonicalHostedZoneNameID != null;       
        }

        /// <summary>
        /// LoadBalancerPort, InstancePort, Protocol, InstanceProtocol, and PolicyNames are returned in a list of tuples in the ListenerDescriptions
        /// element.
        ///  
        /// </summary>
        public List<ListenerDescription> ListenerDescriptions
        {
            get { return this.listenerDescriptions; }
            set { this.listenerDescriptions = value; }
        }
        /// <summary>
        /// Adds elements to the ListenerDescriptions collection
        /// </summary>
        /// <param name="listenerDescriptions">The values to add to the ListenerDescriptions collection </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithListenerDescriptions(params ListenerDescription[] listenerDescriptions)
        {
            foreach (ListenerDescription element in listenerDescriptions)
            {
                this.listenerDescriptions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ListenerDescriptions collection
        /// </summary>
        /// <param name="listenerDescriptions">The values to add to the ListenerDescriptions collection </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithListenerDescriptions(IEnumerable<ListenerDescription> listenerDescriptions)
        {
            foreach (ListenerDescription element in listenerDescriptions)
            {
                this.listenerDescriptions.Add(element);
            }

            return this;
        }

        // Check to see if ListenerDescriptions property is set
        internal bool IsSetListenerDescriptions()
        {
            return this.listenerDescriptions.Count > 0;       
        }

        /// <summary>
        /// Provides a list of policies defined for the LoadBalancer.
        ///  
        /// </summary>
        public Policies Policies
        {
            get { return this.policies; }
            set { this.policies = value; }
        }

        /// <summary>
        /// Sets the Policies property
        /// </summary>
        /// <param name="policies">The value to set for the Policies property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithPolicies(Policies policies)
        {
            this.policies = policies;
            return this;
        }
            

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this.policies != null;       
        }

        /// <summary>
        /// Contains a list of back-end server descriptions.
        ///  
        /// </summary>
        public List<BackendServerDescription> BackendServerDescriptions
        {
            get { return this.backendServerDescriptions; }
            set { this.backendServerDescriptions = value; }
        }
        /// <summary>
        /// Adds elements to the BackendServerDescriptions collection
        /// </summary>
        /// <param name="backendServerDescriptions">The values to add to the BackendServerDescriptions collection </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithBackendServerDescriptions(params BackendServerDescription[] backendServerDescriptions)
        {
            foreach (BackendServerDescription element in backendServerDescriptions)
            {
                this.backendServerDescriptions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the BackendServerDescriptions collection
        /// </summary>
        /// <param name="backendServerDescriptions">The values to add to the BackendServerDescriptions collection </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithBackendServerDescriptions(IEnumerable<BackendServerDescription> backendServerDescriptions)
        {
            foreach (BackendServerDescription element in backendServerDescriptions)
            {
                this.backendServerDescriptions.Add(element);
            }

            return this;
        }

        // Check to see if BackendServerDescriptions property is set
        internal bool IsSetBackendServerDescriptions()
        {
            return this.backendServerDescriptions.Count > 0;       
        }

        /// <summary>
        /// Specifies a list of Availability Zones.
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
        public LoadBalancerDescription WithAvailabilityZones(params string[] availabilityZones)
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
        public LoadBalancerDescription WithAvailabilityZones(IEnumerable<string> availabilityZones)
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

        /// <summary>
        /// Provides a list of VPC subnet IDs for the LoadBalancer.
        ///  
        /// </summary>
        public List<string> Subnets
        {
            get { return this.subnets; }
            set { this.subnets = value; }
        }
        /// <summary>
        /// Adds elements to the Subnets collection
        /// </summary>
        /// <param name="subnets">The values to add to the Subnets collection </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithSubnets(params string[] subnets)
        {
            foreach (string element in subnets)
            {
                this.subnets.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Subnets collection
        /// </summary>
        /// <param name="subnets">The values to add to the Subnets collection </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithSubnets(IEnumerable<string> subnets)
        {
            foreach (string element in subnets)
            {
                this.subnets.Add(element);
            }

            return this;
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this.subnets.Count > 0;       
        }

        /// <summary>
        /// Provides the ID of the VPC attached to the LoadBalancer.
        ///  
        /// </summary>
        public string VPCId
        {
            get { return this.vPCId; }
            set { this.vPCId = value; }
        }

        /// <summary>
        /// Sets the VPCId property
        /// </summary>
        /// <param name="vPCId">The value to set for the VPCId property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithVPCId(string vPCId)
        {
            this.vPCId = vPCId;
            return this;
        }
            

        // Check to see if VPCId property is set
        internal bool IsSetVPCId()
        {
            return this.vPCId != null;       
        }

        /// <summary>
        /// Provides a list of EC2 instance IDs for the LoadBalancer.
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
        public LoadBalancerDescription WithInstances(params Instance[] instances)
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
        public LoadBalancerDescription WithInstances(IEnumerable<Instance> instances)
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

        /// <summary>
        /// Specifies information regarding the various health probes conducted on the LoadBalancer.
        ///  
        /// </summary>
        public HealthCheck HealthCheck
        {
            get { return this.healthCheck; }
            set { this.healthCheck = value; }
        }

        /// <summary>
        /// Sets the HealthCheck property
        /// </summary>
        /// <param name="healthCheck">The value to set for the HealthCheck property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithHealthCheck(HealthCheck healthCheck)
        {
            this.healthCheck = healthCheck;
            return this;
        }
            

        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this.healthCheck != null;       
        }

        /// <summary>
        /// The security group that you can use as part of your inbound rules for your LoadBalancer's back-end Amazon EC2 application instances. To only
        /// allow traffic from LoadBalancers, add a security group rule to your back end instance that specifies this source security group as the
        /// inbound source.
        ///  
        /// </summary>
        public SourceSecurityGroup SourceSecurityGroup
        {
            get { return this.sourceSecurityGroup; }
            set { this.sourceSecurityGroup = value; }
        }

        /// <summary>
        /// Sets the SourceSecurityGroup property
        /// </summary>
        /// <param name="sourceSecurityGroup">The value to set for the SourceSecurityGroup property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithSourceSecurityGroup(SourceSecurityGroup sourceSecurityGroup)
        {
            this.sourceSecurityGroup = sourceSecurityGroup;
            return this;
        }
            

        // Check to see if SourceSecurityGroup property is set
        internal bool IsSetSourceSecurityGroup()
        {
            return this.sourceSecurityGroup != null;       
        }

        /// <summary>
        /// The security groups the LoadBalancer is a member of (VPC only).
        ///  
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this.securityGroups; }
            set { this.securityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the SecurityGroups collection
        /// </summary>
        /// <param name="securityGroups">The values to add to the SecurityGroups collection </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithSecurityGroups(params string[] securityGroups)
        {
            foreach (string element in securityGroups)
            {
                this.securityGroups.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the SecurityGroups collection
        /// </summary>
        /// <param name="securityGroups">The values to add to the SecurityGroups collection </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithSecurityGroups(IEnumerable<string> securityGroups)
        {
            foreach (string element in securityGroups)
            {
                this.securityGroups.Add(element);
            }

            return this;
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this.securityGroups.Count > 0;       
        }

        /// <summary>
        /// Provides the date and time the LoadBalancer was created.
        ///  
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this.createdTime ?? default(DateTime); }
            set { this.createdTime = value; }
        }

        /// <summary>
        /// Sets the CreatedTime property
        /// </summary>
        /// <param name="createdTime">The value to set for the CreatedTime property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithCreatedTime(DateTime createdTime)
        {
            this.createdTime = createdTime;
            return this;
        }
            

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this.createdTime.HasValue;       
        }

        /// <summary>
        /// Specifies the type of LoadBalancer. If the <c>Scheme</c> is <c>internet-facing</c>, the LoadBalancer has a publicly resolvable DNS name that
        /// resolves to public IP addresses. If the <c>Scheme</c> is <c>internal</c>, the LoadBalancer has a publicly resolvable DNS name that resolves
        /// to private IP addresses. This option is only available for LoadBalancers attached to an Amazon VPC.
        ///  
        /// </summary>
        public string Scheme
        {
            get { return this.scheme; }
            set { this.scheme = value; }
        }

        /// <summary>
        /// Sets the Scheme property
        /// </summary>
        /// <param name="scheme">The value to set for the Scheme property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithScheme(string scheme)
        {
            this.scheme = scheme;
            return this;
        }
            

        // Check to see if Scheme property is set
        internal bool IsSetScheme()
        {
            return this.scheme != null;       
        }
    }
}
