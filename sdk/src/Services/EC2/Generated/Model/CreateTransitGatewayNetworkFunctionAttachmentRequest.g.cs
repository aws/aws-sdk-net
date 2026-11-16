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
    /// Container for the parameters to the CreateTransitGatewayNetworkFunctionAttachment
    /// operation. Creates a network function attachment that connects the specified transit
    /// gateway to a Gateway Load Balancer endpoint service. Traffic that you route to the
    /// attachment is sent to the network function appliances behind the endpoint service.
    /// To use this operation, you must be the owner of the transit gateway. <para> You can
    /// create one network function attachment for each combination of transit gateway and
    /// endpoint service. The attachment remains in the <c>pendingAcceptance</c> state until
    /// the endpoint service owner accepts the endpoint connection. </para>
    /// </summary>
    public partial class CreateTransitGatewayNetworkFunctionAttachmentRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZoneIds. 
        /// <para>
        /// The IDs of the Availability Zones for the attachment. You must specify at least one
        /// Availability Zone, using this parameter, <c>AvailabilityZones</c>, or both. Each Availability
        /// Zone must be supported by both the transit gateway and the endpoint service.
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
        /// The names of the Availability Zones for the attachment. You must specify at least
        /// one Availability Zone, using this parameter, <c>AvailabilityZoneIds</c>, or both.
        /// Each Availability Zone must be supported by both the transit gateway and the endpoint
        /// service.
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Gateway Load Balancer endpoint service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the network function attachment.
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

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway. The transit gateway must be in the <c>available</c>
        /// state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayId() => this.TransitGatewayId != null;
    }
}
