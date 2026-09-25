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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Container for the parameters to the StartDeviceDiscovery operation. This API is used
    /// to start device discovery for hub-connected and third-party-connected devices. The
    /// authentication material (install code) is delivered as a message to the controller
    /// instructing it to start the discovery.
    /// </summary>
    public partial class StartDeviceDiscoveryRequest : AmazonIoTManagedIntegrationsRequest
    {
        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The identifier of the cloud-to-cloud account association to use for discovery of third-party
        /// devices.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AccountAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AccountAssociationId property is set.
        /// </summary>
        internal bool IsSetAccountAssociationId() => this.AccountAssociationId != null;

        /// <summary>
        /// Gets and sets the property AuthenticationMaterial. 
        /// <para>
        /// The authentication material required to start the local device discovery job request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string AuthenticationMaterial { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMaterial property is set.
        /// </summary>
        internal bool IsSetAuthenticationMaterial() => this.AuthenticationMaterial != null;

        /// <summary>
        /// Gets and sets the property AuthenticationMaterialType. 
        /// <para>
        /// The type of authentication material used for device discovery jobs.
        /// </para>
        /// </summary>
        public DiscoveryAuthMaterialType AuthenticationMaterialType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMaterialType property is set.
        /// </summary>
        internal bool IsSetAuthenticationMaterialType() => this.AuthenticationMaterialType != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An idempotency token. If you retry a request that completed successfully initially
        /// using the same client token and parameters, then the retry attempt will succeed without
        /// performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConnectorAssociationIdentifier. 
        /// <para>
        /// The id of the connector association.
        /// </para>
        /// </summary>
        [Obsolete("ConnectorAssociationIdentifier is deprecated")]
        [AWSProperty(Min = 1, Max = 64)]
        public string ConnectorAssociationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorAssociationIdentifier property is set.
        /// </summary>
        internal bool IsSetConnectorAssociationIdentifier() => this.ConnectorAssociationIdentifier != null;

        /// <summary>
        /// Gets and sets the property ConnectorDeviceIdList. 
        /// <para>
        /// Used as a filter for PLA discoveries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> ConnectorDeviceIdList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConnectorDeviceIdList property is set.
        /// </summary>
        internal bool IsSetConnectorDeviceIdList() => this.ConnectorDeviceIdList != null && (this.ConnectorDeviceIdList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ControllerIdentifier. 
        /// <para>
        /// The id of the end-user's IoT hub.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ControllerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ControllerIdentifier property is set.
        /// </summary>
        internal bool IsSetControllerIdentifier() => this.ControllerIdentifier != null;

        /// <summary>
        /// Gets and sets the property CustomProtocolDetail. 
        /// <para>
        /// Additional protocol-specific details required for device discovery, which vary based
        /// on the discovery type.
        /// </para>
        ///  <note> 
        /// <para>
        /// For a <c>DiscoveryType</c> of <c>CUSTOM</c>, the string-to-string map must have a
        /// key value of <c>Name</c> set to a non-empty-string.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> CustomProtocolDetail { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the CustomProtocolDetail property is set.
        /// </summary>
        internal bool IsSetCustomProtocolDetail() => this.CustomProtocolDetail != null && (this.CustomProtocolDetail.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DiscoveryType. 
        /// <para>
        /// The discovery type supporting the type of device to be discovered in the device discovery
        /// task request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DiscoveryType DiscoveryType { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryType property is set.
        /// </summary>
        internal bool IsSetDiscoveryType() => this.DiscoveryType != null;

        /// <summary>
        /// Gets and sets the property EndDeviceIdentifier. 
        /// <para>
        /// The unique id of the end device for capability rediscovery.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only available when the discovery type is CONTROLLER_CAPABILITY_REDISCOVERY.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EndDeviceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EndDeviceIdentifier property is set.
        /// </summary>
        internal bool IsSetEndDeviceIdentifier() => this.EndDeviceIdentifier != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol type for capability rediscovery (ZWAVE, ZIGBEE, or CUSTOM).
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only available when the discovery type is CONTROLLER_CAPABILITY_REDISCOVERY.
        /// </para>
        ///  </note>
        /// </summary>
        public ProtocolType Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key/value pairs that are used to manage the device discovery request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Tags have been deprecated from this api")]
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
