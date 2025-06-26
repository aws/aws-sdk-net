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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
    /// Container for the parameters to the StartDeviceDiscovery operation.
    /// This API is used to start device discovery for hub-connected and third-party-connected
    /// devices. The authentication material (install code) is passed as a message to the
    /// controller telling it to start the discovery.
    /// </summary>
    public partial class StartDeviceDiscoveryRequest : AmazonIoTManagedIntegrationsRequest
    {
        private string _accountAssociationId;
        private string _authenticationMaterial;
        private DiscoveryAuthMaterialType _authenticationMaterialType;
        private string _clientToken;
        private string _connectorAssociationIdentifier;
        private string _controllerIdentifier;
        private Dictionary<string, string> _customProtocolDetail = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DiscoveryType _discoveryType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The identifier of the cloud-to-cloud account association to use for discovery of third-party
        /// devices.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AccountAssociationId
        {
            get { return this._accountAssociationId; }
            set { this._accountAssociationId = value; }
        }

        // Check to see if AccountAssociationId property is set
        internal bool IsSetAccountAssociationId()
        {
            return this._accountAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationMaterial. 
        /// <para>
        /// The authentication material required to start the local device discovery job request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string AuthenticationMaterial
        {
            get { return this._authenticationMaterial; }
            set { this._authenticationMaterial = value; }
        }

        // Check to see if AuthenticationMaterial property is set
        internal bool IsSetAuthenticationMaterial()
        {
            return this._authenticationMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationMaterialType. 
        /// <para>
        /// The type of authentication material used for device discovery jobs.
        /// </para>
        /// </summary>
        public DiscoveryAuthMaterialType AuthenticationMaterialType
        {
            get { return this._authenticationMaterialType; }
            set { this._authenticationMaterialType = value; }
        }

        // Check to see if AuthenticationMaterialType property is set
        internal bool IsSetAuthenticationMaterialType()
        {
            return this._authenticationMaterialType != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An idempotency token. If you retry a request that completed successfully initially
        /// using the same client token and parameters, then the retry attempt will succeed without
        /// performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorAssociationIdentifier. 
        /// <para>
        /// The id of the connector association.
        /// </para>
        /// </summary>
        [Obsolete("ConnectorAssociationIdentifier is deprecated")]
        [AWSProperty(Min=1, Max=64)]
        public string ConnectorAssociationIdentifier
        {
            get { return this._connectorAssociationIdentifier; }
            set { this._connectorAssociationIdentifier = value; }
        }

        // Check to see if ConnectorAssociationIdentifier property is set
        internal bool IsSetConnectorAssociationIdentifier()
        {
            return this._connectorAssociationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ControllerIdentifier. 
        /// <para>
        /// The id of the end-user's IoT hub.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ControllerIdentifier
        {
            get { return this._controllerIdentifier; }
            set { this._controllerIdentifier = value; }
        }

        // Check to see if ControllerIdentifier property is set
        internal bool IsSetControllerIdentifier()
        {
            return this._controllerIdentifier != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> CustomProtocolDetail
        {
            get { return this._customProtocolDetail; }
            set { this._customProtocolDetail = value; }
        }

        // Check to see if CustomProtocolDetail property is set
        internal bool IsSetCustomProtocolDetail()
        {
            return this._customProtocolDetail != null && (this._customProtocolDetail.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DiscoveryType. 
        /// <para>
        /// The discovery type supporting the type of device to be discovered in the device discovery
        /// task request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DiscoveryType DiscoveryType
        {
            get { return this._discoveryType; }
            set { this._discoveryType = value; }
        }

        // Check to see if DiscoveryType property is set
        internal bool IsSetDiscoveryType()
        {
            return this._discoveryType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key/value pairs that are used to manage the device discovery request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Tags have been deprecated from this api")]
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}