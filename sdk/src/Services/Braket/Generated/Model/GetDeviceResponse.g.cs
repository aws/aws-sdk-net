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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// This is the response object from the GetDevice operation.
    /// </summary>
    public partial class GetDeviceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DeviceArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceArn property is set.
        /// </summary>
        internal bool IsSetDeviceArn() => this.DeviceArn != null;

        /// <summary>
        /// Gets and sets the property DeviceCapabilities. 
        /// <para>
        /// Details about the capabilities of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeviceCapabilities { get; set; }

        /// <summary>
        /// Checks to see if the DeviceCapabilities property is set.
        /// </summary>
        internal bool IsSetDeviceCapabilities() => this.DeviceCapabilities != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property DeviceQueueInfo. 
        /// <para>
        /// The number of quantum tasks and hybrid jobs currently queued on the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeviceQueueInfo> DeviceQueueInfo { get; set; } = AWSConfigs.InitializeCollections ? new List<DeviceQueueInfo>() : null;

        /// <summary>
        /// Checks to see if the DeviceQueueInfo property is set.
        /// </summary>
        internal bool IsSetDeviceQueueInfo() => this.DeviceQueueInfo != null && (this.DeviceQueueInfo.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeviceStatus. 
        /// <para>
        /// The status of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeviceStatus DeviceStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeviceStatus property is set.
        /// </summary>
        internal bool IsSetDeviceStatus() => this.DeviceStatus != null;

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The type of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Checks to see if the DeviceType property is set.
        /// </summary>
        internal bool IsSetDeviceType() => this.DeviceType != null;

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the partner company for the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;
    }
}
