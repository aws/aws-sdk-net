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
    /// Container for the parameters to the CreateManagedThing operation. Creates a managed
    /// thing. A managed thing contains the device identifier, protocol supported, and capabilities
    /// of the device in a data model format defined by Managed integrations.
    /// </summary>
    public partial class CreateManagedThingRequest : AmazonIoTManagedIntegrationsRequest
    {
        /// <summary>
        /// Gets and sets the property AuthenticationMaterial. 
        /// <para>
        /// The authentication material defining the device connectivity setup requests. The authorization
        /// materials used are the device bar code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 512)]
        public string AuthenticationMaterial { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMaterial property is set.
        /// </summary>
        internal bool IsSetAuthenticationMaterial() => this.AuthenticationMaterial != null;

        /// <summary>
        /// Gets and sets the property AuthenticationMaterialType. 
        /// <para>
        /// The type of authentication material used for device connectivity setup requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthMaterialType AuthenticationMaterialType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMaterialType property is set.
        /// </summary>
        internal bool IsSetAuthenticationMaterialType() => this.AuthenticationMaterialType != null;

        /// <summary>
        /// Gets and sets the property Brand. 
        /// <para>
        /// The brand of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Brand { get; set; }

        /// <summary>
        /// Checks to see if the Brand property is set.
        /// </summary>
        internal bool IsSetBrand() => this.Brand != null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities of the device such as light bulb.
        /// </para>
        /// </summary>
        [Obsolete("Capabilities has been deprecated, use CapabilityReport instead")]
        [AWSProperty(Min = 1, Max = 65535)]
        public string Capabilities { get; set; }

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null;

        /// <summary>
        /// Gets and sets the property CapabilityReport. 
        /// <para>
        /// A report of the capabilities for the managed thing.
        /// </para>
        /// </summary>
        public CapabilityReport CapabilityReport { get; set; }

        /// <summary>
        /// Checks to see if the CapabilityReport property is set.
        /// </summary>
        internal bool IsSetCapabilityReport() => this.CapabilityReport != null;

        /// <summary>
        /// Gets and sets the property CapabilitySchemas. 
        /// <para>
        /// The capability schemas that define the functionality and features supported by the
        /// managed thing, including device capabilities and their associated properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 40)]
        public List<CapabilitySchemaItem> CapabilitySchemas { get; set; } = AWSConfigs.InitializeCollections ? new List<CapabilitySchemaItem>() : null;

        /// <summary>
        /// Checks to see if the CapabilitySchemas property is set.
        /// </summary>
        internal bool IsSetCapabilitySchemas() => this.CapabilitySchemas != null && (this.CapabilitySchemas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// The classification of the managed thing such as light bulb or thermostat.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string Classification { get; set; }

        /// <summary>
        /// Checks to see if the Classification property is set.
        /// </summary>
        internal bool IsSetClassification() => this.Classification != null;

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
        /// Gets and sets the property CredentialLockerId. 
        /// <para>
        /// The identifier of the credential for the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CredentialLockerId { get; set; }

        /// <summary>
        /// Checks to see if the CredentialLockerId property is set.
        /// </summary>
        internal bool IsSetCredentialLockerId() => this.CredentialLockerId != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> MetaData { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the MetaData property is set.
        /// </summary>
        internal bool IsSetMetaData() => this.MetaData != null && (this.MetaData.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed thing representing the physical device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// Owner of the device, usually an indication of whom the device belongs to. This value
        /// should not contain personal identifiable information.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The type of device used. This will be the hub controller, cloud device, or AWS IoT
        /// device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Role Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key/value pairs that are used to manage the managed thing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WiFiSimpleSetupConfiguration. 
        /// <para>
        /// The Wi-Fi Simple Setup configuration for the managed thing, which defines provisioning
        /// capabilities and timeout settings.
        /// </para>
        /// </summary>
        public WiFiSimpleSetupConfiguration WiFiSimpleSetupConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WiFiSimpleSetupConfiguration property is set.
        /// </summary>
        internal bool IsSetWiFiSimpleSetupConfiguration() => this.WiFiSimpleSetupConfiguration != null;
    }
}
