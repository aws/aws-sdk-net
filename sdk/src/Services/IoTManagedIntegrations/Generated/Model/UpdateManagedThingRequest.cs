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
    /// Container for the parameters to the UpdateManagedThing operation.
    /// Update the attributes and capabilities associated with a managed thing.
    /// </summary>
    public partial class UpdateManagedThingRequest : AmazonIoTManagedIntegrationsRequest
    {
        private string _brand;
        private string _capabilities;
        private CapabilityReport _capabilityReport;
        private List<CapabilitySchemaItem> _capabilitySchemas = AWSConfigs.InitializeCollections ? new List<CapabilitySchemaItem>() : null;
        private string _classification;
        private string _credentialLockerId;
        private HubNetworkMode _hubNetworkMode;
        private string _identifier;
        private Dictionary<string, string> _metaData = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _model;
        private string _name;
        private string _owner;
        private string _serialNumber;

        /// <summary>
        /// Gets and sets the property Brand. 
        /// <para>
        /// The brand of the device.
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
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities of the device such as light bulb.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public string Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null;
        }

        /// <summary>
        /// Gets and sets the property CapabilityReport. 
        /// <para>
        /// A report of the capabilities for the managed thing.
        /// </para>
        /// </summary>
        public CapabilityReport CapabilityReport
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
        /// The updated capability schemas that define the functionality and features supported
        /// by the managed thing.
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
        /// Gets and sets the property Classification. 
        /// <para>
        /// The classification of the managed thing such as light bulb or thermostat.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string Classification
        {
            get { return this._classification; }
            set { this._classification = value; }
        }

        // Check to see if Classification property is set
        internal bool IsSetClassification()
        {
            return this._classification != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialLockerId. 
        /// <para>
        /// The identifier of the credential for the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CredentialLockerId
        {
            get { return this._credentialLockerId; }
            set { this._credentialLockerId = value; }
        }

        // Check to see if CredentialLockerId property is set
        internal bool IsSetCredentialLockerId()
        {
            return this._credentialLockerId != null;
        }

        /// <summary>
        /// Gets and sets the property HubNetworkMode. 
        /// <para>
        /// The network mode for the hub-connected device.
        /// </para>
        /// </summary>
        public HubNetworkMode HubNetworkMode
        {
            get { return this._hubNetworkMode; }
            set { this._hubNetworkMode = value; }
        }

        // Check to see if HubNetworkMode property is set
        internal bool IsSetHubNetworkMode()
        {
            return this._hubNetworkMode != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The id of the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property MetaData. 
        /// <para>
        /// The metadata for the managed thing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> MetaData
        {
            get { return this._metaData; }
            set { this._metaData = value; }
        }

        // Check to see if MetaData property is set
        internal bool IsSetMetaData()
        {
            return this._metaData != null && (this._metaData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model of the device.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed thing representing the physical device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// Owner of the device, usually an indication of whom the device belongs to. This value
        /// should not contain personal identifiable information.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

    }
}