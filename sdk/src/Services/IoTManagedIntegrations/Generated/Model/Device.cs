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
    /// Describe the device using the relevant metadata and supported clusters for device
    /// discovery.
    /// </summary>
    public partial class Device
    {
        private MatterCapabilityReport _capabilityReport;
        private List<CapabilitySchemaItem> _capabilitySchemas = AWSConfigs.InitializeCollections ? new List<CapabilitySchemaItem>() : null;
        private string _connectorDeviceId;
        private string _connectorDeviceName;
        private Amazon.Runtime.Documents.Document _deviceMetadata;

        /// <summary>
        /// Gets and sets the property CapabilityReport. 
        /// <para>
        /// The capability report for the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MatterCapabilityReport CapabilityReport
        {
            get { return this._capabilityReport; }
            set { this._capabilityReport = value; }
        }

        // Check to see if CapabilityReport property is set
        internal bool IsSetCapabilityReport()
        {
            return this._capabilityReport != null;
        }

        /// <summary>
        /// Gets and sets the property CapabilitySchemas. 
        /// <para>
        /// Report of all capabilities supported by the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public List<CapabilitySchemaItem> CapabilitySchemas
        {
            get { return this._capabilitySchemas; }
            set { this._capabilitySchemas = value; }
        }

        // Check to see if CapabilitySchemas property is set
        internal bool IsSetCapabilitySchemas()
        {
            return this._capabilitySchemas != null && (this._capabilitySchemas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectorDeviceId. 
        /// <para>
        /// The device id as defined by the connector.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is used for cloud-to-cloud devices only.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
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
        /// The name of the device as defined by the connector.
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
        /// Gets and sets the property DeviceMetadata. 
        /// <para>
        /// The metadata attributes for a device.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document DeviceMetadata
        {
            get { return this._deviceMetadata; }
            set { this._deviceMetadata = value; }
        }

        // Check to see if DeviceMetadata property is set
        internal bool IsSetDeviceMetadata()
        {
            return !this._deviceMetadata.IsNull();
        }

    }
}