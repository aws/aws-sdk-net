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
    /// Container for the parameters to the CreateManagedThing operation.
    /// Creates a managed thing. A managed thing contains the device identifier, protocol
    /// supported, and capabilities of the device in a protocol-specific format.
    /// </summary>
    public partial class CreateManagedThingRequest : AmazonIoTManagedIntegrationsRequest
    {
        private string _authenticationMaterial;
        private AuthMaterialType _authenticationMaterialType;
        private string _brand;
        private string _capabilities;
        private CapabilityReport _capabilityReport;
        private List<CapabilitySchemaItem> _capabilitySchemas = AWSConfigs.InitializeCollections ? new List<CapabilitySchemaItem>() : null;
        private string _classification;
        private string _clientToken;
        private string _credentialLockerId;
        private Dictionary<string, string> _metaData = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _model;
        private string _name;
        private string _owner;
        private Role _role;
        private string _serialNumber;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AuthenticationMaterial. 
        /// <para>
        /// The authentication material defining the device connectivity setup requests. The authentication
        /// materials used are the device bar code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=512)]
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
        /// The type of authentication material used for device connectivity setup requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthMaterialType AuthenticationMaterialType
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
        /// The capability schemas that define the functionality and features supported by the
        /// managed thing, including device capabilities and their associated properties.
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
        /// Gets and sets the property MetaData. 
        /// <para>
        /// The metadata for the managed thing.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>managedThing</c> <c>metadata</c> parameter is used for associating attributes
        /// with a <c>managedThing</c> that can be used for grouping over-the-air (OTA) tasks.
        /// Name value pairs in <c>metadata</c> can be used in the <c>OtaTargetQueryString</c>
        /// parameter for the <c>CreateOtaTask</c> API operation.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Role. 
        /// <para>
        /// The type of device used. This will be the hub controller, cloud device, or AWS IoT
        /// device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Role Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key/value pairs that are used to manage the managed thing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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