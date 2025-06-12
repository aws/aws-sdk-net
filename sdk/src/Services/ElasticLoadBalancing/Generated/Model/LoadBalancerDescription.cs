/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Information about a load balancer.
    /// </summary>
    public partial class LoadBalancerDescription
    {
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<BackendServerDescription> _backendServerDescriptions = AWSConfigs.InitializeCollections ? new List<BackendServerDescription>() : null;
        private string _canonicalHostedZoneName;
        private string _canonicalHostedZoneNameID;
        private DateTime? _createdTime;
        private string _dnsName;
        private HealthCheck _healthCheck;
        private List<Instance> _instances = AWSConfigs.InitializeCollections ? new List<Instance>() : null;
        private List<ListenerDescription> _listenerDescriptions = AWSConfigs.InitializeCollections ? new List<ListenerDescription>() : null;
        private string _loadBalancerName;
        private Policies _policies;
        private string _scheme;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SourceSecurityGroup _sourceSecurityGroup;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public LoadBalancerDescription() { }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BackendServerDescriptions. 
        /// <para>
        /// Information about your EC2 instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BackendServerDescription> BackendServerDescriptions
        {
            get { return this._backendServerDescriptions; }
            set { this._backendServerDescriptions = value; }
        }

        // Check to see if BackendServerDescriptions property is set
        internal bool IsSetBackendServerDescriptions()
        {
            return this._backendServerDescriptions != null && (this._backendServerDescriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CanonicalHostedZoneName. 
        /// <para>
        /// The DNS name of the load balancer.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/using-domain-names-with-elb.html">Configure
        /// a Custom Domain Name</a> in the <i>Classic Load Balancers Guide</i>.
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
        /// The ID of the Amazon Route 53 hosted zone for the load balancer.
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
        /// The date and time the load balancer was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
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
        /// The DNS name of the load balancer.
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
        /// Information about the health checks conducted on the load balancer.
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
        /// The IDs of the instances for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && (this._instances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListenerDescriptions. 
        /// <para>
        /// The listeners for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListenerDescription> ListenerDescriptions
        {
            get { return this._listenerDescriptions; }
            set { this._listenerDescriptions = value; }
        }

        // Check to see if ListenerDescriptions property is set
        internal bool IsSetListenerDescriptions()
        {
            return this._listenerDescriptions != null && (this._listenerDescriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
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
        /// The policies defined for the load balancer.
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
        /// The type of load balancer. Valid only for load balancers in a VPC.
        /// </para>
        ///  
        /// <para>
        /// If <c>Scheme</c> is <c>internet-facing</c>, the load balancer has a public DNS name
        /// that resolves to a public IP address.
        /// </para>
        ///  
        /// <para>
        /// If <c>Scheme</c> is <c>internal</c>, the load balancer has a public DNS name that
        /// resolves to a private IP address.
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
        /// The security groups for the load balancer. Valid only for load balancers in a VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceSecurityGroup. 
        /// <para>
        /// The security group for the load balancer, which you can use as part of your inbound
        /// rules for your registered instances. To only allow traffic from load balancers, add
        /// a security group rule that specifies this source security group as the inbound source.
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
        /// The IDs of the subnets for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VPCId. 
        /// <para>
        /// The ID of the VPC for the load balancer.
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