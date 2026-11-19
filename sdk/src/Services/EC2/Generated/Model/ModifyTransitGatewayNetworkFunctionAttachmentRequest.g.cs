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
    /// Container for the parameters to the ModifyTransitGatewayNetworkFunctionAttachment
    /// operation. Adds Availability Zones to or removes Availability Zones from the specified
    /// network function attachment. The attachment must be in the <c>available</c> state.
    /// You must specify at least one Availability Zone to add or remove, and the attachment
    /// must keep at least one Availability Zone. <para> Adding an Availability Zone provisions
    /// a new Gateway Load Balancer endpoint in that Availability Zone. If the endpoint service
    /// doesn't automatically accept connection requests, the endpoint service owner must
    /// accept the endpoint connection for each Availability Zone that you add. </para>
    /// </summary>
    public partial class ModifyTransitGatewayNetworkFunctionAttachmentRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AddAvailabilityZoneIds. 
        /// <para>
        /// The IDs of the Availability Zones to add to the attachment. You can't add and remove
        /// the same Availability Zone in a single request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddAvailabilityZoneIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddAvailabilityZoneIds property is set.
        /// </summary>
        internal bool IsSetAddAvailabilityZoneIds() => this.AddAvailabilityZoneIds != null && (this.AddAvailabilityZoneIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AddAvailabilityZones. 
        /// <para>
        /// The names of the Availability Zones to add to the attachment. You can't add and remove
        /// the same Availability Zone in a single request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddAvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddAvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAddAvailabilityZones() => this.AddAvailabilityZones != null && (this.AddAvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property RemoveAvailabilityZoneIds. 
        /// <para>
        /// The IDs of the Availability Zones to remove from the attachment. Each Availability
        /// Zone must be currently in the attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveAvailabilityZoneIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveAvailabilityZoneIds property is set.
        /// </summary>
        internal bool IsSetRemoveAvailabilityZoneIds() => this.RemoveAvailabilityZoneIds != null && (this.RemoveAvailabilityZoneIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemoveAvailabilityZones. 
        /// <para>
        /// The names of the Availability Zones to remove from the attachment. Each Availability
        /// Zone must be currently in the attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveAvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveAvailabilityZones property is set.
        /// </summary>
        internal bool IsSetRemoveAvailabilityZones() => this.RemoveAvailabilityZones != null && (this.RemoveAvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the network function attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAttachmentId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachmentId() => this.TransitGatewayAttachmentId != null;
    }
}
