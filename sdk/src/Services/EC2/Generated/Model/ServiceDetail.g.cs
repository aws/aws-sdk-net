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
    /// Describes a VPC endpoint service.
    /// </summary>
    public partial class ServiceDetail
    {
        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// Indicates whether VPC endpoint connection requests to the service must be accepted
        /// by the service owner.
        /// </para>
        /// </summary>
        public bool? AcceptanceRequired { get; set; }

        /// <summary>
        /// Checks to see if the AcceptanceRequired property is set.
        /// </summary>
        internal bool IsSetAcceptanceRequired() => this.AcceptanceRequired.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneIds. 
        /// <para>
        /// The IDs of the Availability Zones in which the service is available.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> can be specified, but
        /// not both
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZoneIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZoneIds property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneIds() => this.AvailabilityZoneIds != null && (this.AvailabilityZoneIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones in which the service is available.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> can be specified, but
        /// not both
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
        /// Gets and sets the property ManagesVpcEndpoints. 
        /// <para>
        /// Indicates whether the service manages its VPC endpoints. Management of the service
        /// VPC endpoints using the VPC endpoint API is restricted.
        /// </para>
        /// </summary>
        public bool? ManagesVpcEndpoints { get; set; }

        /// <summary>
        /// Checks to see if the ManagesVpcEndpoints property is set.
        /// </summary>
        internal bool IsSetManagesVpcEndpoints() => this.ManagesVpcEndpoints.HasValue;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account ID of the service owner.
        /// </para>
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property PayerResponsibility. 
        /// <para>
        /// The payer responsibility.
        /// </para>
        /// </summary>
        public PayerResponsibility PayerResponsibility { get; set; }

        /// <summary>
        /// Checks to see if the PayerResponsibility property is set.
        /// </summary>
        internal bool IsSetPayerResponsibility() => this.PayerResponsibility != null;

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
        /// Gets and sets the property PrivateDnsNameVerificationState. 
        /// <para>
        /// The verification state of the VPC endpoint service.
        /// </para>
        ///  
        /// <para>
        /// Consumers of the endpoint service cannot use the private name when the state is not
        /// <c>verified</c>.
        /// </para>
        /// </summary>
        public DnsNameState PrivateDnsNameVerificationState { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsNameVerificationState property is set.
        /// </summary>
        internal bool IsSetPrivateDnsNameVerificationState() => this.PrivateDnsNameVerificationState != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsNames. 
        /// <para>
        /// The private DNS names assigned to the VPC endpoint service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrivateDnsDetails> PrivateDnsNames { get; set; } = AWSConfigs.InitializeCollections ? new List<PrivateDnsDetails>() : null;

        /// <summary>
        /// Checks to see if the PrivateDnsNames property is set.
        /// </summary>
        internal bool IsSetPrivateDnsNames() => this.PrivateDnsNames != null && (this.PrivateDnsNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the endpoint service.
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
        /// Gets and sets the property ServiceRegion. 
        /// <para>
        /// The Region where the service is hosted.
        /// </para>
        /// </summary>
        public string ServiceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRegion property is set.
        /// </summary>
        internal bool IsSetServiceRegion() => this.ServiceRegion != null;

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The type of service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceTypeDetail> ServiceType { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceTypeDetail>() : null;

        /// <summary>
        /// Checks to see if the ServiceType property is set.
        /// </summary>
        internal bool IsSetServiceType() => this.ServiceType != null && (this.ServiceType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedIpAddressTypes. 
        /// <para>
        /// The supported IP address types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> SupportedIpAddressTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedIpAddressTypes property is set.
        /// </summary>
        internal bool IsSetSupportedIpAddressTypes() => this.SupportedIpAddressTypes != null && (this.SupportedIpAddressTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the service.
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
        /// Gets and sets the property VpcEndpointPolicySupported. 
        /// <para>
        /// Indicates whether the service supports endpoint policies.
        /// </para>
        /// </summary>
        public bool? VpcEndpointPolicySupported { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointPolicySupported property is set.
        /// </summary>
        internal bool IsSetVpcEndpointPolicySupported() => this.VpcEndpointPolicySupported.HasValue;
    }
}
