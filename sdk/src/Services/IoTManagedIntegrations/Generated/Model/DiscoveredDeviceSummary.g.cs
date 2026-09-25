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
    /// Structure containing summary information about a device discovered during a device
    /// discovery job.
    /// </summary>
    public partial class DiscoveredDeviceSummary
    {
        /// <summary>
        /// Gets and sets the property AuthenticationMaterial. 
        /// <para>
        /// The authentication material required for connecting to the discovered device, such
        /// as credentials or tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 512)]
        public string AuthenticationMaterial { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMaterial property is set.
        /// </summary>
        internal bool IsSetAuthenticationMaterial() => this.AuthenticationMaterial != null;

        /// <summary>
        /// Gets and sets the property Brand. 
        /// <para>
        /// The brand of the discovered device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Brand { get; set; }

        /// <summary>
        /// Checks to see if the Brand property is set.
        /// </summary>
        internal bool IsSetBrand() => this.Brand != null;

        /// <summary>
        /// Gets and sets the property ConnectorDeviceId. 
        /// <para>
        /// The third-party device identifier as defined by the connector. This identifier must
        /// not contain personal identifiable information (PII).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string ConnectorDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDeviceId property is set.
        /// </summary>
        internal bool IsSetConnectorDeviceId() => this.ConnectorDeviceId != null;

        /// <summary>
        /// Gets and sets the property ConnectorDeviceName. 
        /// <para>
        /// The name of the device as defined by the connector or third-party system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ConnectorDeviceName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDeviceName property is set.
        /// </summary>
        internal bool IsSetConnectorDeviceName() => this.ConnectorDeviceName != null;

        /// <summary>
        /// Gets and sets the property DeviceTypes. 
        /// <para>
        /// The list of device types or categories that the discovered device belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeviceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DeviceTypes property is set.
        /// </summary>
        internal bool IsSetDeviceTypes() => this.DeviceTypes != null && (this.DeviceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DiscoveredAt. 
        /// <para>
        /// The timestamp indicating when the device was discovered.
        /// </para>
        /// </summary>
        public DateTime? DiscoveredAt { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveredAt property is set.
        /// </summary>
        internal bool IsSetDiscoveredAt() => this.DiscoveredAt.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedThingId. 
        /// <para>
        /// The identifier of the managed thing created for this discovered device, if one exists.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ManagedThingId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedThingId property is set.
        /// </summary>
        internal bool IsSetManagedThingId() => this.ManagedThingId != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model of the discovered device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property Modification. 
        /// <para>
        /// The status of the discovered device, indicating whether it has been added, removed,
        /// or modified since the last discovery.
        /// </para>
        /// </summary>
        public DiscoveryModification Modification { get; set; }

        /// <summary>
        /// Checks to see if the Modification property is set.
        /// </summary>
        internal bool IsSetModification() => this.Modification != null;
    }
}
