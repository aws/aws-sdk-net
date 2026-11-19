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
    /// Container for the parameters to the CreateVpcEndpointServiceConfiguration operation.
    /// Creates a VPC endpoint service to which service consumers (Amazon Web Services accounts,
    /// users, and IAM roles) can connect. <para> Before you create an endpoint service, you
    /// must create one of the following for your service: </para> <ul> <li> <para> A <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/">Network
    /// Load Balancer</a>. Service consumers connect to your service using an interface endpoint.
    /// </para> </li> <li> <para> A <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/">Gateway
    /// Load Balancer</a>. Service consumers connect to your service using a Gateway Load
    /// Balancer endpoint. </para> </li> </ul> <para> If you set the private DNS name, you
    /// must prove that you own the private DNS domain name. </para> <para> For more information,
    /// see the <a href="https://docs.aws.amazon.com/vpc/latest/privatelink/">Amazon Web Services
    /// PrivateLink Guide</a>. </para>
    /// </summary>
    public partial class CreateVpcEndpointServiceConfigurationRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// Indicates whether requests from service consumers to create an endpoint to your service
        /// must be accepted manually.
        /// </para>
        /// </summary>
        public bool? AcceptanceRequired { get; set; }

        /// <summary>
        /// Checks to see if the AcceptanceRequired property is set.
        /// </summary>
        internal bool IsSetAcceptanceRequired() => this.AcceptanceRequired.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property GatewayLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Gateway Load Balancers.
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
        /// Gets and sets the property NetworkLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Network Load Balancers.
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
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// (Interface endpoint configuration) The private DNS name to assign to the VPC endpoint
        /// service.
        /// </para>
        /// </summary>
        public string PrivateDnsName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsName property is set.
        /// </summary>
        internal bool IsSetPrivateDnsName() => this.PrivateDnsName != null;

        /// <summary>
        /// Gets and sets the property SupportedIpAddressTypes. 
        /// <para>
        /// The supported IP address types. The possible values are <c>ipv4</c> and <c>ipv6</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedIpAddressTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedIpAddressTypes property is set.
        /// </summary>
        internal bool IsSetSupportedIpAddressTypes() => this.SupportedIpAddressTypes != null && (this.SupportedIpAddressTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedRegions. 
        /// <para>
        /// The Regions from which service consumers can access the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedRegions property is set.
        /// </summary>
        internal bool IsSetSupportedRegions() => this.SupportedRegions != null && (this.SupportedRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to associate with the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
