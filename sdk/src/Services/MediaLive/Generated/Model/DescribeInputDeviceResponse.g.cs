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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// This is the response object from the DescribeInputDevice operation.
    /// </summary>
    public partial class DescribeInputDeviceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. The unique ARN of the input device.
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. The Availability Zone associated with
        /// this input device.
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property ConnectionState. The state of the connection between the
        /// input device and AWS.
        /// </summary>
        public InputDeviceConnectionState ConnectionState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionState property is set.
        /// </summary>
        internal bool IsSetConnectionState() => this.ConnectionState != null;

        /// <summary>
        /// Gets and sets the property DeviceSettingsSyncState. The status of the action to synchronize
        /// the device configuration. If you change the configuration of the input device (for
        /// example, the maximum bitrate), MediaLive sends the new data to the device. The device
        /// might not update itself immediately. SYNCED means the device has updated its configuration.
        /// SYNCING means that it has not updated its configuration.
        /// </summary>
        public DeviceSettingsSyncState DeviceSettingsSyncState { get; set; }

        /// <summary>
        /// Checks to see if the DeviceSettingsSyncState property is set.
        /// </summary>
        internal bool IsSetDeviceSettingsSyncState() => this.DeviceSettingsSyncState != null;

        /// <summary>
        /// Gets and sets the property DeviceUpdateStatus. The status of software on the input
        /// device.
        /// </summary>
        public DeviceUpdateStatus DeviceUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeviceUpdateStatus property is set.
        /// </summary>
        internal bool IsSetDeviceUpdateStatus() => this.DeviceUpdateStatus != null;

        /// <summary>
        /// Gets and sets the property HdDeviceSettings. Settings that describe an input device
        /// that is type HD.
        /// </summary>
        public InputDeviceHdSettings HdDeviceSettings { get; set; }

        /// <summary>
        /// Checks to see if the HdDeviceSettings property is set.
        /// </summary>
        internal bool IsSetHdDeviceSettings() => this.HdDeviceSettings != null;

        /// <summary>
        /// Gets and sets the property Id. The unique ID of the input device.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MacAddress. The network MAC address of the input device.
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// Checks to see if the MacAddress property is set.
        /// </summary>
        internal bool IsSetMacAddress() => this.MacAddress != null;

        /// <summary>
        /// Gets and sets the property MedialiveInputArns. An array of the ARNs for the MediaLive
        /// inputs attached to the device. Returned only if the outputType is MEDIALIVE_INPUT.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MedialiveInputArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MedialiveInputArns property is set.
        /// </summary>
        internal bool IsSetMedialiveInputArns() => this.MedialiveInputArns != null && (this.MedialiveInputArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. A name that you specify for the input device.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkSettings. The network settings for the input device.
        /// </summary>
        public InputDeviceNetworkSettings NetworkSettings { get; set; }

        /// <summary>
        /// Checks to see if the NetworkSettings property is set.
        /// </summary>
        internal bool IsSetNetworkSettings() => this.NetworkSettings != null;

        /// <summary>
        /// Gets and sets the property OutputType. The output attachment type of the input device.
        /// Specifies MEDIACONNECT_FLOW if this device is the source for a MediaConnect flow.
        /// Specifies MEDIALIVE_INPUT if this device is the source for a MediaLive input.
        /// </summary>
        public InputDeviceOutputType OutputType { get; set; }

        /// <summary>
        /// Checks to see if the OutputType property is set.
        /// </summary>
        internal bool IsSetOutputType() => this.OutputType != null;

        /// <summary>
        /// Gets and sets the property SerialNumber. The unique serial number of the input device.
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. The type of the input device.
        /// </summary>
        public InputDeviceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UhdDeviceSettings. Settings that describe an input device
        /// that is type UHD.
        /// </summary>
        public InputDeviceUhdSettings UhdDeviceSettings { get; set; }

        /// <summary>
        /// Checks to see if the UhdDeviceSettings property is set.
        /// </summary>
        internal bool IsSetUhdDeviceSettings() => this.UhdDeviceSettings != null;
    }
}
