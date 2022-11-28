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
    /// CDMA object for network measurement reports.
    /// </summary>
    public partial class CdmaNmrObj
    {
        private int? _baseStationId;
        private int? _cdmaChannel;
        private int? _pilotPower;
        private int? _pnOffset;

        /// <summary>
        /// Gets and sets the property BaseStationId. 
        /// <para>
        /// CDMA base station ID (BSID).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int BaseStationId
        {
            get { return this._baseStationId.GetValueOrDefault(); }
            set { this._baseStationId = value; }
        }

        // Check to see if BaseStationId property is set
        internal bool IsSetBaseStationId()
        {
            return this._baseStationId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CdmaChannel. 
        /// <para>
        /// CDMA channel information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4095)]
        public int CdmaChannel
        {
            get { return this._cdmaChannel.GetValueOrDefault(); }
            set { this._cdmaChannel = value; }
        }

        // Check to see if CdmaChannel property is set
        internal bool IsSetCdmaChannel()
        {
            return this._cdmaChannel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PilotPower. 
        /// <para>
        /// Transmit power level of the pilot signal, measured in dBm (decibel-milliwatts).
        /// </para>
        /// </summary>
        [AWSProperty(Min=-142, Max=-49)]
        public int PilotPower
        {
            get { return this._pilotPower.GetValueOrDefault(); }
            set { this._pilotPower = value; }
        }

        // Check to see if PilotPower property is set
        internal bool IsSetPilotPower()
        {
            return this._pilotPower.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PnOffset. 
        /// <para>
        /// Pseudo-noise offset, which is a characteristic of the signal from a cell on a radio
        /// tower.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=511)]
        public int PnOffset
        {
            get { return this._pnOffset.GetValueOrDefault(); }
            set { this._pnOffset = value; }
        }

        // Check to see if PnOffset property is set
        internal bool IsSetPnOffset()
        {
            return this._pnOffset.HasValue; 
        }

    }
}