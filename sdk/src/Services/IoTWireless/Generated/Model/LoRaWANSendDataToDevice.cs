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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// LoRaWAN router info.
    /// </summary>
    public partial class LoRaWANSendDataToDevice
    {
        private int? _fPort;
        private ParticipatingGateways _participatingGateways;

        /// <summary>
        /// Gets and sets the property FPort.
        /// </summary>
        [AWSProperty(Min=1, Max=223)]
        public int FPort
        {
            get { return this._fPort.GetValueOrDefault(); }
            set { this._fPort = value; }
        }

        // Check to see if FPort property is set
        internal bool IsSetFPort()
        {
            return this._fPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParticipatingGateways. 
        /// <para>
        /// Choose the gateways that you want to use for the downlink data traffic when the wireless
        /// device is running in class B or class C mode.
        /// </para>
        /// </summary>
        public ParticipatingGateways ParticipatingGateways
        {
            get { return this._participatingGateways; }
            set { this._participatingGateways = value; }
        }

        // Check to see if ParticipatingGateways property is set
        internal bool IsSetParticipatingGateways()
        {
            return this._participatingGateways != null;
        }

    }
}