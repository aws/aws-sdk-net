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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains details about a Classic Load Balancer.
    /// </summary>
    public partial class AwsElbLoadBalancerDetails
    {
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<AwsElbLoadBalancerBackendServerDescription> _backendServerDescriptions = AWSConfigs.InitializeCollections ? new List<AwsElbLoadBalancerBackendServerDescription>() : null;
        private string _canonicalHostedZoneName;
        private string _canonicalHostedZoneNameID;
        private string _createdTime;
        private string _dnsName;
        private AwsElbLoadBalancerHealthCheck _healthCheck;
        private List<AwsElbLoadBalancerInstance> _instances = AWSConfigs.InitializeCollections ? new List<AwsElbLoadBalancerInstance>() : null;
        private List<AwsElbLoadBalancerListenerDescription> _listenerDescriptions = AWSConfigs.InitializeCollections ? new List<AwsElbLoadBalancerListenerDescription>() : null;
        private AwsElbLoadBalancerAttributes _loadBalancerAttributes;
        private string _loadBalancerName;
        private AwsElbLoadBalancerPolicies _policies;
        private string _scheme;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AwsElbLoadBalancerSourceSecurityGroup _sourceSecurityGroup;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The list of Availability Zones for the load balancer.
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
        /// Information about the configuration of the EC2 instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElbLoadBalancerBackendServerDescription> BackendServerDescriptions
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
        /// The name of the Amazon Route 53 hosted zone for the load balancer.
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
        /// The ID of the Amazon Route 53 hosted zone for the load balancer.
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
        /// Indicates when the load balancer was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime != null;
        }

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of the load balancer.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// Information about the health checks that are conducted on the load balancer.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerHealthCheck HealthCheck
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
        /// List of EC2 instances for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElbLoadBalancerInstance> Instances
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
        /// The policies that are enabled for the load balancer listeners.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElbLoadBalancerListenerDescription> ListenerDescriptions
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
        /// Gets and sets the property LoadBalancerAttributes. 
        /// <para>
        /// The attributes for a load balancer.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerAttributes LoadBalancerAttributes
        {
            get { return this._loadBalancerAttributes; }
            set { this._loadBalancerAttributes = value; }
        }

        // Check to see if LoadBalancerAttributes property is set
        internal bool IsSetLoadBalancerAttributes()
        {
            return this._loadBalancerAttributes != null;
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
        /// The policies for a load balancer.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerPolicies Policies
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
        /// The type of load balancer. Only provided if the load balancer is in a VPC.
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
        /// The security groups for the load balancer. Only provided if the load balancer is in
        /// a VPC.
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
        /// Information about the security group for the load balancer. This is the security group
        /// that is used for inbound rules.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerSourceSecurityGroup SourceSecurityGroup
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
        /// The list of subnet identifiers for the load balancer.
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC for the load balancer.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}