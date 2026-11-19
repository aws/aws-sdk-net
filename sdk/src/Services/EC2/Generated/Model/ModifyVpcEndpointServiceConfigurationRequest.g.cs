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
    /// Container for the parameters to the ModifyVpcEndpointServiceConfiguration operation.
    /// Modifies the attributes of the specified VPC endpoint service configuration. <para>
    /// If you set or modify the private DNS name, you must prove that you own the private
    /// DNS domain name. </para>
    /// </summary>
    public partial class ModifyVpcEndpointServiceConfigurationRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// Indicates whether requests to create an endpoint to the service must be accepted.
        /// </para>
        /// </summary>
        public bool? AcceptanceRequired { get; set; }

        /// <summary>
        /// Checks to see if the AcceptanceRequired property is set.
        /// </summary>
        internal bool IsSetAcceptanceRequired() => this.AcceptanceRequired.HasValue;

        /// <summary>
        /// Gets and sets the property AddGatewayLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Gateway Load Balancers to add to the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddGatewayLoadBalancerArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddGatewayLoadBalancerArns property is set.
        /// </summary>
        internal bool IsSetAddGatewayLoadBalancerArns() => this.AddGatewayLoadBalancerArns != null && (this.AddGatewayLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AddNetworkLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Network Load Balancers to add to the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddNetworkLoadBalancerArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddNetworkLoadBalancerArns property is set.
        /// </summary>
        internal bool IsSetAddNetworkLoadBalancerArns() => this.AddNetworkLoadBalancerArns != null && (this.AddNetworkLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AddSupportedIpAddressTypes. 
        /// <para>
        /// The IP address types to add to the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddSupportedIpAddressTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddSupportedIpAddressTypes property is set.
        /// </summary>
        internal bool IsSetAddSupportedIpAddressTypes() => this.AddSupportedIpAddressTypes != null && (this.AddSupportedIpAddressTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AddSupportedRegions. 
        /// <para>
        /// The supported Regions to add to the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddSupportedRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddSupportedRegions property is set.
        /// </summary>
        internal bool IsSetAddSupportedRegions() => this.AddSupportedRegions != null && (this.AddSupportedRegions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// (Interface endpoint configuration) The private DNS name to assign to the endpoint
        /// service.
        /// </para>
        /// </summary>
        public string PrivateDnsName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsName property is set.
        /// </summary>
        internal bool IsSetPrivateDnsName() => this.PrivateDnsName != null;

        /// <summary>
        /// Gets and sets the property RemoveGatewayLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Gateway Load Balancers to remove from the service
        /// configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveGatewayLoadBalancerArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveGatewayLoadBalancerArns property is set.
        /// </summary>
        internal bool IsSetRemoveGatewayLoadBalancerArns() => this.RemoveGatewayLoadBalancerArns != null && (this.RemoveGatewayLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemoveNetworkLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Network Load Balancers to remove from the service
        /// configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveNetworkLoadBalancerArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveNetworkLoadBalancerArns property is set.
        /// </summary>
        internal bool IsSetRemoveNetworkLoadBalancerArns() => this.RemoveNetworkLoadBalancerArns != null && (this.RemoveNetworkLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemovePrivateDnsName. 
        /// <para>
        /// (Interface endpoint configuration) Removes the private DNS name of the endpoint service.
        /// </para>
        /// </summary>
        public bool? RemovePrivateDnsName { get; set; }

        /// <summary>
        /// Checks to see if the RemovePrivateDnsName property is set.
        /// </summary>
        internal bool IsSetRemovePrivateDnsName() => this.RemovePrivateDnsName.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveSupportedIpAddressTypes. 
        /// <para>
        /// The IP address types to remove from the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveSupportedIpAddressTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveSupportedIpAddressTypes property is set.
        /// </summary>
        internal bool IsSetRemoveSupportedIpAddressTypes() => this.RemoveSupportedIpAddressTypes != null && (this.RemoveSupportedIpAddressTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemoveSupportedRegions. 
        /// <para>
        /// The supported Regions to remove from the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveSupportedRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveSupportedRegions property is set.
        /// </summary>
        internal bool IsSetRemoveSupportedRegions() => this.RemoveSupportedRegions != null && (this.RemoveSupportedRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;
    }
}
