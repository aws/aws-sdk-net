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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a VPC endpoint connection to a service.
    /// </summary>
    public partial class VpcEndpointConnection
    {
        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The date and time that the VPC endpoint was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DnsEntries. 
        /// <para>
        /// The DNS entries for the VPC endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DnsEntry> DnsEntries { get; set; } = AWSConfigs.InitializeCollections ? new List<DnsEntry>() : null;

        /// <summary>
        /// Checks to see if the DnsEntries property is set.
        /// </summary>
        internal bool IsSetDnsEntries() => this.DnsEntries != null && (this.DnsEntries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GatewayLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Gateway Load Balancers for the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GatewayLoadBalancerArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GatewayLoadBalancerArns property is set.
        /// </summary>
        internal bool IsSetGatewayLoadBalancerArns() => this.GatewayLoadBalancerArns != null && (this.GatewayLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the endpoint.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property NetworkLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the network load balancers for the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkLoadBalancerArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NetworkLoadBalancerArns property is set.
        /// </summary>
        internal bool IsSetNetworkLoadBalancerArns() => this.NetworkLoadBalancerArns != null && (this.NetworkLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PayerResponsibilities. 
        /// <para>
        /// The payer responsibility settings for the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PayerResponsibilityEntry> PayerResponsibilities { get; set; } = AWSConfigs.InitializeCollections ? new List<PayerResponsibilityEntry>() : null;

        /// <summary>
        /// Checks to see if the PayerResponsibilities property is set.
        /// </summary>
        internal bool IsSetPayerResponsibilities() => this.PayerResponsibilities != null && (this.PayerResponsibilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the service to which the endpoint is connected.
        /// </para>
        /// </summary>
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcEndpointConnectionId. 
        /// <para>
        /// The ID of the VPC endpoint connection.
        /// </para>
        /// </summary>
        public string VpcEndpointConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointConnectionId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointConnectionId() => this.VpcEndpointConnectionId != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointOwner. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the VPC endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointOwner { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointOwner property is set.
        /// </summary>
        internal bool IsSetVpcEndpointOwner() => this.VpcEndpointOwner != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointRegion. 
        /// <para>
        /// The Region of the endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointRegion { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointRegion property is set.
        /// </summary>
        internal bool IsSetVpcEndpointRegion() => this.VpcEndpointRegion != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointState. 
        /// <para>
        /// The state of the VPC endpoint.
        /// </para>
        /// </summary>
        public State VpcEndpointState { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointState property is set.
        /// </summary>
        internal bool IsSetVpcEndpointState() => this.VpcEndpointState != null;
    }
}
