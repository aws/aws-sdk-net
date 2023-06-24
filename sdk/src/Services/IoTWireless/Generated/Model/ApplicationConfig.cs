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
    /// LoRaWAN application configuration, which can be used to perform geolocation.
    /// </summary>
    public partial class ApplicationConfig
    {
        private string _destinationName;
        private int? _fPort;
        private ApplicationConfigType _type;

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// The name of the position data destination that describes the AWS IoT rule that processes
        /// the device's position data for use by AWS IoT Core for LoRaWAN.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string DestinationName
        {
            get { return this._destinationName; }
            set { this._destinationName = value; }
        }

        // Check to see if DestinationName property is set
        internal bool IsSetDestinationName()
        {
            return this._destinationName != null;
        }

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
        /// Gets and sets the property Type. 
        /// <para>
        /// Application type, which can be specified to obtain real-time position information
        /// of your LoRaWAN device.
        /// </para>
        /// </summary>
        public ApplicationConfigType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}