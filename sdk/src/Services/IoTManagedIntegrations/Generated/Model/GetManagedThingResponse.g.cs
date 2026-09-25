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
    /// This is the response object from the GetManagedThing operation.
    /// </summary>
    public partial class GetManagedThingResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActivatedAt. 
        /// <para>
        /// The timestampe value of when the device was activated.
        /// </para>
        /// </summary>
        public DateTime? ActivatedAt { get; set; }

        /// <summary>
        /// Checks to see if the ActivatedAt property is set.
        /// </summary>
        internal bool IsSetActivatedAt() => this.ActivatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property AdvertisedProductId. 
        /// <para>
        /// The id of the advertised product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
        public string AdvertisedProductId { get; set; }

        /// <summary>
        /// Checks to see if the AdvertisedProductId property is set.
        /// </summary>
        internal bool IsSetAdvertisedProductId() => this.AdvertisedProductId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        /// Gets and sets the property ConnectorDestinationId. 
        /// <para>
        /// The identifier of the connector destination associated with this managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ConnectorDestinationId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDestinationId property is set.
        /// </summary>
        internal bool IsSetConnectorDestinationId() => this.ConnectorDestinationId != null;

        /// <summary>
        /// Gets and sets the property ConnectorDeviceId. 
        /// <para>
        /// The third-party device id as defined by the connector. This device id must not contain
        /// personal identifiable information (PII).
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is used for cloud-to-cloud devices only.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string ConnectorDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDeviceId property is set.
        /// </summary>
        internal bool IsSetConnectorDeviceId() => this.ConnectorDeviceId != null;

        /// <summary>
        /// Gets and sets the property ConnectorPolicyId. 
        /// <para>
        /// The id of the connector policy.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is used for cloud-to-cloud devices only.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("ConnectorPolicyId is deprecated")]
        [AWSProperty(Min = 1, Max = 64)]
        public string ConnectorPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorPolicyId property is set.
        /// </summary>
        internal bool IsSetConnectorPolicyId() => this.ConnectorPolicyId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp value of when the device creation request occurred.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CredentialLockerId. 
        /// <para>
        /// The identifier of the credential locker for the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CredentialLockerId { get; set; }

        /// <summary>
        /// Checks to see if the CredentialLockerId property is set.
        /// </summary>
        internal bool IsSetCredentialLockerId() => this.CredentialLockerId != null;

        /// <summary>
        /// Gets and sets the property DeviceSpecificKey. 
        /// <para>
        /// A Zwave device-specific key used during device activation.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is used for Zwave devices only.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string DeviceSpecificKey { get; set; }

        /// <summary>
        /// Checks to see if the DeviceSpecificKey property is set.
        /// </summary>
        internal bool IsSetDeviceSpecificKey() => this.DeviceSpecificKey != null;

        /// <summary>
        /// Gets and sets the property HubNetworkMode. 
        /// <para>
        /// The network mode for the hub-connected device.
        /// </para>
        /// </summary>
        public HubNetworkMode HubNetworkMode { get; set; }

        /// <summary>
        /// Checks to see if the HubNetworkMode property is set.
        /// </summary>
        internal bool IsSetHubNetworkMode() => this.HubNetworkMode != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The id of the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InternationalArticleNumber. 
        /// <para>
        /// The unique 13 digit number that identifies the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 8, Max = 13)]
        public string InternationalArticleNumber { get; set; }

        /// <summary>
        /// Checks to see if the InternationalArticleNumber property is set.
        /// </summary>
        internal bool IsSetInternationalArticleNumber() => this.InternationalArticleNumber != null;

        /// <summary>
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// The media access control (MAC) address for the device represented by the managed thing.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is used for Zigbee devices only.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string MacAddress { get; set; }

        /// <summary>
        /// Checks to see if the MacAddress property is set.
        /// </summary>
        internal bool IsSetMacAddress() => this.MacAddress != null;

        /// <summary>
        /// Gets and sets the property MetaData. 
        /// <para>
        /// The metadata for the managed thing.
        /// </para>
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
        /// Gets and sets the property ParentControllerId. 
        /// <para>
        /// Id of the controller device used for the discovery job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ParentControllerId { get; set; }

        /// <summary>
        /// Checks to see if the ParentControllerId property is set.
        /// </summary>
        internal bool IsSetParentControllerId() => this.ParentControllerId != null;

        /// <summary>
        /// Gets and sets the property ProvisioningStatus. 
        /// <para>
        /// The provisioning status of the device in the provisioning workflow for onboarding
        /// to IoT managed integrations. For more information, see <a href="https://docs.aws.amazon.com/iot-mi/latest/devguide/device-provisioning.html">Device
        /// Provisioning</a>.
        /// </para>
        /// </summary>
        public ProvisioningStatus ProvisioningStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningStatus property is set.
        /// </summary>
        internal bool IsSetProvisioningStatus() => this.ProvisioningStatus != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The type of device used. This will be the Amazon Web Services hub controller, cloud
        /// device, or IoT device.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property UniversalProductCode. 
        /// <para>
        /// The universal product code (UPC) of the device model. The UPC is typically used in
        /// the United States of America and Canada.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 12, Max = 12)]
        public string UniversalProductCode { get; set; }

        /// <summary>
        /// Checks to see if the UniversalProductCode property is set.
        /// </summary>
        internal bool IsSetUniversalProductCode() => this.UniversalProductCode != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp value of when the managed thing was last updated at.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

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
