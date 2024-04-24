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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the GetWirelessDeviceStatistics operation.
    /// Gets operating information about a wireless device.
    /// </summary>
    public partial class GetWirelessDeviceStatisticsRequest : AmazonIoTWirelessRequest
    {
        private string _wirelessDeviceId;

        /// <summary>
        /// Gets and sets the property WirelessDeviceId. 
        /// <para>
        /// The ID of the wireless device for which to get the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string WirelessDeviceId
        {
            get { return this._wirelessDeviceId; }
            set { this._wirelessDeviceId = value; }
        }

        // Check to see if WirelessDeviceId property is set
        internal bool IsSetWirelessDeviceId()
        {
            return this._wirelessDeviceId != null;
        }

    }
}