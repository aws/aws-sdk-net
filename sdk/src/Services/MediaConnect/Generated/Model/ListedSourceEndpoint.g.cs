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
    /// A summary of a source endpoint that the <c>ListSourceEndpoints</c> operation returns.
    /// </summary>
    public partial class ListedSourceEndpoint
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 64, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociatedResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that is associated with the source
        /// endpoint.
        /// </para>
        /// </summary>
        public string AssociatedResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedResourceArn property is set.
        /// </summary>
        internal bool IsSetAssociatedResourceArn() => this.AssociatedResourceArn != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the source endpoint is located.
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
        /// The ID of the Availability Zone in which the source endpoint is located.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property ConnectedDestinationCount. 
        /// <para>
        /// The number of destination endpoints that are connected to the source endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ConnectedDestinationCount { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedDestinationCount property is set.
        /// </summary>
        internal bool IsSetConnectedDestinationCount() => this.ConnectedDestinationCount.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectionState. 
        /// <para>
        /// The connection state of the source endpoint. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONNECTED</c> – The source endpoint is connected to a destination endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISCONNECTED</c> – The source endpoint isn't connected to a destination endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONNECTING</c> – The source endpoint is connecting to a destination endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISCONNECTING</c> – The source endpoint is disconnecting from a destination endpoint.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceEndpointConnectionState ConnectionState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionState property is set.
        /// </summary>
        internal bool IsSetConnectionState() => this.ConnectionState != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the source endpoint was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of encryption used for the source endpoint connection.
        /// </para>
        /// </summary>
        public EndpointEncryptionType EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the source endpoint.
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
        /// The entity that manages the lifecycle of the source endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointLifecycle LifecycleManagement { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleManagement property is set.
        /// </summary>
        internal bool IsSetLifecycleManagement() => this.LifecycleManagement != null;

        /// <summary>
        /// Gets and sets the property MessageCount. 
        /// <para>
        /// The number of status messages for the source endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MessageCount { get; set; }

        /// <summary>
        /// Checks to see if the MessageCount property is set.
        /// </summary>
        internal bool IsSetMessageCount() => this.MessageCount.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the source endpoint.
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
        /// The name of the Amazon Web Services Region in which the source endpoint is located.
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
        /// The registration state of the source endpoint. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REGISTERED</c> – The source endpoint is registered and ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGISTERING</c> – MediaConnect is registering the source endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEREGISTERING</c> – MediaConnect is deregistering the source endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGISTRATION_FAILED</c> – MediaConnect couldn't register the source endpoint.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceEndpointRegistrationState RegistrationState { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationState property is set.
        /// </summary>
        internal bool IsSetRegistrationState() => this.RegistrationState != null;

        /// <summary>
        /// Gets and sets the property ResourceShareOwnership. 
        /// <para>
        /// Indicates whether this account owns the source endpoint or consumes it from another
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
        /// Gets and sets the property ResourceShareState. 
        /// <para>
        /// The sharing state of the source endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceShareState ResourceShareState { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareState property is set.
        /// </summary>
        internal bool IsSetResourceShareState() => this.ResourceShareState != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of the source endpoint. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STANDARD</c> – A source endpoint that represents an external source over a standard
        /// protocol, such as RTP, RIST, or SRT.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROUTER_OUTPUT</c> – A source endpoint that represents a router output.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceEndpointType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the source endpoint was last updated.
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
