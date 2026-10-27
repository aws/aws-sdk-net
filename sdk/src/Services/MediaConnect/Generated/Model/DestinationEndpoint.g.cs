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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The details of a destination endpoint in MediaConnect, including its configuration,
    /// state, and connection details.
    /// </summary>
    public partial class DestinationEndpoint
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 64, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociatedResourceDetails. 
        /// <para>
        /// The details of the resource that is associated with the destination endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DestinationEndpointAssociatedResourceDetails AssociatedResourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedResourceDetails property is set.
        /// </summary>
        internal bool IsSetAssociatedResourceDetails() => this.AssociatedResourceDetails != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the destination endpoint is located.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone in which the destination endpoint is located.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration settings for the destination endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DestinationEndpointConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ConnectedSource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source endpoint that is connected to the destination
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 128)]
        public string ConnectedSource { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedSource property is set.
        /// </summary>
        internal bool IsSetConnectedSource() => this.ConnectedSource != null;

        /// <summary>
        /// Gets and sets the property ConnectionDetails. 
        /// <para>
        /// The connection details for the destination endpoint.
        /// </para>
        /// </summary>
        public DestinationEndpointConnectionDetails ConnectionDetails { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionDetails property is set.
        /// </summary>
        internal bool IsSetConnectionDetails() => this.ConnectionDetails != null;

        /// <summary>
        /// Gets and sets the property ConnectionState. 
        /// <para>
        /// The connection state of the destination endpoint. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONNECTED</c> – The destination endpoint is connected to a source endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISCONNECTED</c> – The destination endpoint isn't connected to a source endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONNECTING</c> – The destination endpoint is connecting to a source endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISCONNECTING</c> – The destination endpoint is disconnecting from a source endpoint.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DestinationEndpointConnectionState ConnectionState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionState property is set.
        /// </summary>
        internal bool IsSetConnectionState() => this.ConnectionState != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the destination endpoint was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DecryptionConfiguration.
        /// </summary>
        public EndpointEncryptionConfiguration DecryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DecryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetDecryptionConfiguration() => this.DecryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property DecryptionType. 
        /// <para>
        /// The type of decryption used for the destination endpoint connection.
        /// </para>
        /// </summary>
        public EndpointEncryptionType DecryptionType { get; set; }

        /// <summary>
        /// Checks to see if the DecryptionType property is set.
        /// </summary>
        internal bool IsSetDecryptionType() => this.DecryptionType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the destination endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// The type of the destination endpoint. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STANDARD</c> – A destination endpoint that represents an external destination
        /// over a standard protocol, such as RTP, RIST, or SRT.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROUTER_INPUT</c> – A destination endpoint that represents a router input.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DestinationEndpointType DestinationType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationType property is set.
        /// </summary>
        internal bool IsSetDestinationType() => this.DestinationType != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the destination endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LifecycleManagement. 
        /// <para>
        /// The entity that manages the lifecycle of the destination endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointLifecycle LifecycleManagement { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleManagement property is set.
        /// </summary>
        internal bool IsSetLifecycleManagement() => this.LifecycleManagement != null;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The status messages for the destination endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<DestinationEndpointMessage> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<DestinationEndpointMessage>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the destination endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The name of the Amazon Web Services Region in which the destination endpoint is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property RegistrationState. 
        /// <para>
        /// The registration state of the destination endpoint. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REGISTERED</c> – The destination endpoint is registered and ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGISTERING</c> – MediaConnect is registering the destination endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEREGISTERING</c> – MediaConnect is deregistering the destination endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGISTRATION_FAILED</c> – MediaConnect couldn't register the destination endpoint.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DestinationEndpointRegistrationState RegistrationState { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationState property is set.
        /// </summary>
        internal bool IsSetRegistrationState() => this.RegistrationState != null;

        /// <summary>
        /// Gets and sets the property ResourceShareDetails.
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceShareDetails ResourceShareDetails { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareDetails property is set.
        /// </summary>
        internal bool IsSetResourceShareDetails() => this.ResourceShareDetails != null;

        /// <summary>
        /// Gets and sets the property ResourceShareOwnership. 
        /// <para>
        /// Indicates whether this account owns the destination endpoint or consumes it from another
        /// account through RAM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceShareOwnership ResourceShareOwnership { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareOwnership property is set.
        /// </summary>
        internal bool IsSetResourceShareOwnership() => this.ResourceShareOwnership != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the destination endpoint. Each tag is a key-value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the destination endpoint was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
