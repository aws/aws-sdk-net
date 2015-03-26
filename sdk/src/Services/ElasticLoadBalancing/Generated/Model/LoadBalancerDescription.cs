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
    /// Contains the result of a successful invocation of <a>DescribeLoadBalancers</a>.
    /// </summary>
    public partial class LoadBalancerDescription
    {
        private List<string> _availabilityZones = new List<string>();
        private List<BackendServerDescription> _backendServerDescriptions = new List<BackendServerDescription>();
        private string _canonicalHostedZoneName;
        private string _canonicalHostedZoneNameID;
        private DateTime? _createdTime;
        private string _dnsName;
        private HealthCheck _healthCheck;
        private List<Instance> _instances = new List<Instance>();
        private List<ListenerDescription> _listenerDescriptions = new List<ListenerDescription>();
        private string _loadBalancerName;
        private Policies _policies;
        private string _scheme;
        private List<string> _securityGroups = new List<string>();
        private SourceSecurityGroup _sourceSecurityGroup;
        private List<string> _subnets = new List<string>();
        private string _vpcId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public LoadBalancerDescription() { }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        ///  Specifies a list of Availability Zones. 
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
        /// Gets and sets the property BackendServerDescriptions. 
        /// <para>
        ///  Contains a list of back-end server descriptions. 
        /// </para>
        /// </summary>
        public List<BackendServerDescription> BackendServerDescriptions
        {
            get { return this._backendServerDescriptions; }
            set { this._backendServerDescriptions = value; }
        }

        // Check to see if BackendServerDescriptions property is set
        internal bool IsSetBackendServerDescriptions()
        {
            return this._backendServerDescriptions != null && this._backendServerDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CanonicalHostedZoneName. 
        /// <para>
        ///  Provides the name of the Amazon Route 53 hosted zone that is associated with the
        /// load balancer. For information on how to associate your load balancer with a hosted
        /// zone, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/using-domain-names-with-elb.html">Using
        /// Domain Names With Elastic Load Balancing</a> in the <i>Elastic Load Balancing Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        public string CanonicalHostedZoneName
        {
            get { return this._canonicalHostedZoneName; }
            set { this._canonicalHostedZoneName = value; }
        }

        // Check to see if CanonicalHostedZoneName property is set
        internal bool IsSetCanonicalHostedZoneName()
        {
            return this._canonicalHostedZoneName != null;
        }

        /// <summary>
        /// Gets and sets the property CanonicalHostedZoneNameID. 
        /// <para>
        ///  Provides the ID of the Amazon Route 53 hosted zone name that is associated with the
        /// load balancer. For information on how to associate or disassociate your load balancer
        /// with a hosted zone, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/using-domain-names-with-elb.html">Using
        /// Domain Names With Elastic Load Balancing</a> in the <i>Elastic Load Balancing Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        public string CanonicalHostedZoneNameID
        {
            get { return this._canonicalHostedZoneNameID; }
            set { this._canonicalHostedZoneNameID = value; }
        }

        // Check to see if CanonicalHostedZoneNameID property is set
        internal bool IsSetCanonicalHostedZoneNameID()
        {
            return this._canonicalHostedZoneNameID != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        ///  Provides the date and time the load balancer was created. 
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DNSName. 
        /// <para>
        ///  Specifies the external DNS name associated with the load balancer. 
        /// </para>
        /// </summary>
        public string DNSName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DNSName property is set
        internal bool IsSetDNSName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        ///  Specifies information regarding the various health probes conducted on the load balancer.
        /// 
        /// </para>
        /// </summary>
        public HealthCheck HealthCheck
        {
            get { return this._healthCheck; }
            set { this._healthCheck = value; }
        }

        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this._healthCheck != null;
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        ///  Provides a list of EC2 instance IDs for the load balancer. 
        /// </para>
        /// </summary>
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ListenerDescriptions. 
        /// <para>
        ///  LoadBalancerPort, InstancePort, Protocol, InstanceProtocol, and PolicyNames are returned
        /// in a list of tuples in the ListenerDescriptions element. 
        /// </para>
        /// </summary>
        public List<ListenerDescription> ListenerDescriptions
        {
            get { return this._listenerDescriptions; }
            set { this._listenerDescriptions = value; }
        }

        // Check to see if ListenerDescriptions property is set
        internal bool IsSetListenerDescriptions()
        {
            return this._listenerDescriptions != null && this._listenerDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  Specifies the name associated with the load balancer. 
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
        /// Gets and sets the property Policies. 
        /// <para>
        ///  Provides a list of policies defined for the load balancer. 
        /// </para>
        /// </summary>
        public Policies Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null;
        }

        /// <summary>
        /// Gets and sets the property Scheme. 
        /// <para>
        /// Specifies the type of load balancer.
        /// </para>
        ///  
        /// <para>
        /// If the <code>Scheme</code> is <code>internet-facing</code>, the load balancer has
        /// a publicly resolvable DNS name that resolves to public IP addresses.
        /// </para>
        ///  
        /// <para>
        /// If the <code>Scheme</code> is <code>internal</code>, the load balancer has a publicly
        /// resolvable DNS name that resolves to private IP addresses.
        /// </para>
        ///  
        /// <para>
        ///  This option is only available for load balancers attached to an Amazon VPC. 
        /// </para>
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
        ///  The security groups the load balancer is a member of (VPC only). 
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
        /// Gets and sets the property SourceSecurityGroup. 
        /// <para>
        ///  The security group that you can use as part of your inbound rules for your load balancer's
        /// back-end Amazon EC2 application instances. To only allow traffic from load balancers,
        /// add a security group rule to your back end instance that specifies this source security
        /// group as the inbound source. 
        /// </para>
        /// </summary>
        public SourceSecurityGroup SourceSecurityGroup
        {
            get { return this._sourceSecurityGroup; }
            set { this._sourceSecurityGroup = value; }
        }

        // Check to see if SourceSecurityGroup property is set
        internal bool IsSetSourceSecurityGroup()
        {
            return this._sourceSecurityGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        ///  Provides a list of VPC subnet IDs for the load balancer. 
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
        /// Gets and sets the property VPCId. 
        /// <para>
        ///  Provides the ID of the VPC attached to the load balancer. 
        /// </para>
        /// </summary>
        public string VPCId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VPCId property is set
        internal bool IsSetVPCId()
        {
            return this._vpcId != null;
        }

    }
}