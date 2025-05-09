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
    /// Gateway list item object that specifies the frequency and list of gateways for which
    /// the downlink message should be sent.
    /// </summary>
    public partial class GatewayListItem
    {
        private int? _downlinkFrequency;
        private string _gatewayId;

        /// <summary>
        /// Gets and sets the property DownlinkFrequency. 
        /// <para>
        /// The frequency to use for the gateways when sending a downlink message to the wireless
        /// device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=100000000, Max=1000000000)]
        public int? DownlinkFrequency
        {
            get { return this._downlinkFrequency; }
            set { this._downlinkFrequency = value; }
        }

        // Check to see if DownlinkFrequency property is set
        internal bool IsSetDownlinkFrequency()
        {
            return this._downlinkFrequency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The ID of the wireless gateways that you want to add to the list of gateways when
        /// sending downlink messages.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

    }
}