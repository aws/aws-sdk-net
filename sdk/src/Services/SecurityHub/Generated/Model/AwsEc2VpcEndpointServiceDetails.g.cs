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
    /// Contains details about the service configuration for a VPC endpoint service.
    /// </summary>
    public partial class AwsEc2VpcEndpointServiceDetails
    {
        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// Whether requests from other Amazon Web Services accounts to create an endpoint to
        /// the service must first be accepted.
        /// </para>
        /// </summary>
        public bool? AcceptanceRequired { get; set; }

        /// <summary>
        /// Checks to see if the AcceptanceRequired property is set.
        /// </summary>
        internal bool IsSetAcceptanceRequired() => this.AcceptanceRequired.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones where the service is available.
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
        /// Gets and sets the property BaseEndpointDnsNames. 
        /// <para>
        /// The DNS names for the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BaseEndpointDnsNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BaseEndpointDnsNames property is set.
        /// </summary>
        internal bool IsSetBaseEndpointDnsNames() => this.BaseEndpointDnsNames != null && (this.BaseEndpointDnsNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GatewayLoadBalancerArns. 
        /// <para>
        /// The ARNs of the Gateway Load Balancers for the service.
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
        /// Gets and sets the property ManagesVpcEndpoints. 
        /// <para>
        /// Whether the service manages its VPC endpoints.
        /// </para>
        /// </summary>
        public bool? ManagesVpcEndpoints { get; set; }

        /// <summary>
        /// Checks to see if the ManagesVpcEndpoints property is set.
        /// </summary>
        internal bool IsSetManagesVpcEndpoints() => this.ManagesVpcEndpoints.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkLoadBalancerArns. 
        /// <para>
        /// The ARNs of the Network Load Balancers for the service.
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
        /// The private DNS name for the service.
        /// </para>
        /// </summary>
        public string PrivateDnsName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsName property is set.
        /// </summary>
        internal bool IsSetPrivateDnsName() => this.PrivateDnsName != null;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The identifier of the service.
        /// </para>
        /// </summary>
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceState. 
        /// <para>
        /// The current state of the service. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Available</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleted</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleting</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Pending</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ServiceState { get; set; }

        /// <summary>
        /// Checks to see if the ServiceState property is set.
        /// </summary>
        internal bool IsSetServiceState() => this.ServiceState != null;

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The types for the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2VpcEndpointServiceServiceTypeDetails> ServiceType { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2VpcEndpointServiceServiceTypeDetails>() : null;

        /// <summary>
        /// Checks to see if the ServiceType property is set.
        /// </summary>
        internal bool IsSetServiceType() => this.ServiceType != null && (this.ServiceType.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
