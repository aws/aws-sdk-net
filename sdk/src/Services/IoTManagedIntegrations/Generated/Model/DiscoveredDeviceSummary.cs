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
    /// Structure containing summary information about a device discovered during a device
    /// discovery job.
    /// </summary>
    public partial class DiscoveredDeviceSummary
    {
        private string _authenticationMaterial;
        private string _brand;
        private string _connectorDeviceId;
        private string _connectorDeviceName;
        private List<string> _deviceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _discoveredAt;
        private string _managedThingId;
        private string _model;
        private DiscoveryModification _modification;

        /// <summary>
        /// Gets and sets the property AuthenticationMaterial. 
        /// <para>
        /// The authentication material required for connecting to the discovered device, such
        /// as credentials or tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=512)]
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
        /// Gets and sets the property Brand. 
        /// <para>
        /// The brand of the discovered device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string Brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }

        // Check to see if Brand property is set
        internal bool IsSetBrand()
        {
            return this._brand != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorDeviceId. 
        /// <para>
        /// The third-party device identifier as defined by the connector. This identifier must
        /// not contain personal identifiable information (PII).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string ConnectorDeviceId
        {
            get { return this._connectorDeviceId; }
            set { this._connectorDeviceId = value; }
        }

        // Check to see if ConnectorDeviceId property is set
        internal bool IsSetConnectorDeviceId()
        {
            return this._connectorDeviceId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorDeviceName. 
        /// <para>
        /// The name of the device as defined by the connector or third-party system.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string ConnectorDeviceName
        {
            get { return this._connectorDeviceName; }
            set { this._connectorDeviceName = value; }
        }

        // Check to see if ConnectorDeviceName property is set
        internal bool IsSetConnectorDeviceName()
        {
            return this._connectorDeviceName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTypes. 
        /// <para>
        /// The list of device types or categories that the discovered device belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeviceTypes
        {
            get { return this._deviceTypes; }
            set { this._deviceTypes = value; }
        }

        // Check to see if DeviceTypes property is set
        internal bool IsSetDeviceTypes()
        {
            return this._deviceTypes != null && (this._deviceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DiscoveredAt. 
        /// <para>
        /// The timestamp indicating when the device was discovered.
        /// </para>
        /// </summary>
        public DateTime? DiscoveredAt
        {
            get { return this._discoveredAt; }
            set { this._discoveredAt = value; }
        }

        // Check to see if DiscoveredAt property is set
        internal bool IsSetDiscoveredAt()
        {
            return this._discoveredAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedThingId. 
        /// <para>
        /// The identifier of the managed thing created for this discovered device, if one exists.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ManagedThingId
        {
            get { return this._managedThingId; }
            set { this._managedThingId = value; }
        }

        // Check to see if ManagedThingId property is set
        internal bool IsSetManagedThingId()
        {
            return this._managedThingId != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model of the discovered device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property Modification. 
        /// <para>
        /// The status of the discovered device, indicating whether it has been added, removed,
        /// or modified since the last discovery.
        /// </para>
        /// </summary>
        public DiscoveryModification Modification
        {
            get { return this._modification; }
            set { this._modification = value; }
        }

        // Check to see if Modification property is set
        internal bool IsSetModification()
        {
            return this._modification != null;
        }

    }
}