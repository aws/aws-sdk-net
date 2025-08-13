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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
        private string _deviceArn;
        private string _deviceCapabilities;
        private string _deviceName;
        private List<DeviceQueueInfo> _deviceQueueInfo = AWSConfigs.InitializeCollections ? new List<DeviceQueueInfo>() : null;
        private DeviceStatus _deviceStatus;
        private DeviceType _deviceType;
        private string _providerName;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceCapabilities. 
        /// <para>
        /// Details about the capabilities of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeviceCapabilities
        {
            get { return this._deviceCapabilities; }
            set { this._deviceCapabilities = value; }
        }

        // Check to see if DeviceCapabilities property is set
        internal bool IsSetDeviceCapabilities()
        {
            return this._deviceCapabilities != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceQueueInfo. 
        /// <para>
        /// The number of quantum tasks and hybrid jobs currently queued on the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeviceQueueInfo> DeviceQueueInfo
        {
            get { return this._deviceQueueInfo; }
            set { this._deviceQueueInfo = value; }
        }

        // Check to see if DeviceQueueInfo property is set
        internal bool IsSetDeviceQueueInfo()
        {
            return this._deviceQueueInfo != null && (this._deviceQueueInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeviceStatus. 
        /// <para>
        /// The status of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeviceStatus DeviceStatus
        {
            get { return this._deviceStatus; }
            set { this._deviceStatus = value; }
        }

        // Check to see if DeviceStatus property is set
        internal bool IsSetDeviceStatus()
        {
            return this._deviceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The type of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeviceType DeviceType
        {
            get { return this._deviceType; }
            set { this._deviceType = value; }
        }

        // Check to see if DeviceType property is set
        internal bool IsSetDeviceType()
        {
            return this._deviceType != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the partner company for the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

    }
}