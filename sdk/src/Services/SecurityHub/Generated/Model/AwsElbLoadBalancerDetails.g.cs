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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The list of Availability Zones for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BackendServerDescriptions. 
        /// <para>
        /// Information about the configuration of the EC2 instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElbLoadBalancerBackendServerDescription> BackendServerDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsElbLoadBalancerBackendServerDescription>() : null;

        /// <summary>
        /// Checks to see if the BackendServerDescriptions property is set.
        /// </summary>
        internal bool IsSetBackendServerDescriptions() => this.BackendServerDescriptions != null && (this.BackendServerDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CanonicalHostedZoneName. 
        /// <para>
        /// The name of the Amazon Route 53 hosted zone for the load balancer.
        /// </para>
        /// </summary>
        public string CanonicalHostedZoneName { get; set; }

        /// <summary>
        /// Checks to see if the CanonicalHostedZoneName property is set.
        /// </summary>
        internal bool IsSetCanonicalHostedZoneName() => this.CanonicalHostedZoneName != null;

        /// <summary>
        /// Gets and sets the property CanonicalHostedZoneNameID. 
        /// <para>
        /// The ID of the Amazon Route 53 hosted zone for the load balancer.
        /// </para>
        /// </summary>
        public string CanonicalHostedZoneNameID { get; set; }

        /// <summary>
        /// Checks to see if the CanonicalHostedZoneNameID property is set.
        /// </summary>
        internal bool IsSetCanonicalHostedZoneNameID() => this.CanonicalHostedZoneNameID != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// Indicates when the load balancer was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime != null;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of the load balancer.
        /// </para>
        /// </summary>
        public string DnsName { get; set; }

        /// <summary>
        /// Checks to see if the DnsName property is set.
        /// </summary>
        internal bool IsSetDnsName() => this.DnsName != null;

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// Information about the health checks that are conducted on the load balancer.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerHealthCheck HealthCheck { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheck property is set.
        /// </summary>
        internal bool IsSetHealthCheck() => this.HealthCheck != null;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// List of EC2 instances for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElbLoadBalancerInstance> Instances { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsElbLoadBalancerInstance>() : null;

        /// <summary>
        /// Checks to see if the Instances property is set.
        /// </summary>
        internal bool IsSetInstances() => this.Instances != null && (this.Instances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListenerDescriptions. 
        /// <para>
        /// The policies that are enabled for the load balancer listeners.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElbLoadBalancerListenerDescription> ListenerDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsElbLoadBalancerListenerDescription>() : null;

        /// <summary>
        /// Checks to see if the ListenerDescriptions property is set.
        /// </summary>
        internal bool IsSetListenerDescriptions() => this.ListenerDescriptions != null && (this.ListenerDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LoadBalancerAttributes. 
        /// <para>
        /// The attributes for a load balancer.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerAttributes LoadBalancerAttributes { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerAttributes property is set.
        /// </summary>
        internal bool IsSetLoadBalancerAttributes() => this.LoadBalancerAttributes != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerName property is set.
        /// </summary>
        internal bool IsSetLoadBalancerName() => this.LoadBalancerName != null;

        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// The policies for a load balancer.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerPolicies Policies { get; set; }

        /// <summary>
        /// Checks to see if the Policies property is set.
        /// </summary>
        internal bool IsSetPolicies() => this.Policies != null;

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
        public string Scheme { get; set; }

        /// <summary>
        /// Checks to see if the Scheme property is set.
        /// </summary>
        internal bool IsSetScheme() => this.Scheme != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security groups for the load balancer. Only provided if the load balancer is in
        /// a VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceSecurityGroup. 
        /// <para>
        /// Information about the security group for the load balancer. This is the security group
        /// that is used for inbound rules.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerSourceSecurityGroup SourceSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the SourceSecurityGroup property is set.
        /// </summary>
        internal bool IsSetSourceSecurityGroup() => this.SourceSecurityGroup != null;

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The list of subnet identifiers for the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Subnets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Subnets property is set.
        /// </summary>
        internal bool IsSetSubnets() => this.Subnets != null && (this.Subnets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC for the load balancer.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
