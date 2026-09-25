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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// CDMA object for network measurement reports.
    /// </summary>
    public partial class CdmaNmrObj
    {
        /// <summary>
        /// Gets and sets the property BaseStationId. 
        /// <para>
        /// CDMA base station ID (BSID).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? BaseStationId { get; set; }

        /// <summary>
        /// Checks to see if the BaseStationId property is set.
        /// </summary>
        internal bool IsSetBaseStationId() => this.BaseStationId.HasValue;

        /// <summary>
        /// Gets and sets the property CdmaChannel. 
        /// <para>
        /// CDMA channel information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 4095)]
        public int? CdmaChannel { get; set; }

        /// <summary>
        /// Checks to see if the CdmaChannel property is set.
        /// </summary>
        internal bool IsSetCdmaChannel() => this.CdmaChannel.HasValue;

        /// <summary>
        /// Gets and sets the property PilotPower. 
        /// <para>
        /// Transmit power level of the pilot signal, measured in dBm (decibel-milliwatts).
        /// </para>
        /// </summary>
        [AWSProperty(Min = -142, Max = -49)]
        public int? PilotPower { get; set; }

        /// <summary>
        /// Checks to see if the PilotPower property is set.
        /// </summary>
        internal bool IsSetPilotPower() => this.PilotPower.HasValue;

        /// <summary>
        /// Gets and sets the property PnOffset. 
        /// <para>
        /// Pseudo-noise offset, which is a characteristic of the signal from a cell on a radio
        /// tower.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 511)]
        public int? PnOffset { get; set; }

        /// <summary>
        /// Checks to see if the PnOffset property is set.
        /// </summary>
        internal bool IsSetPnOffset() => this.PnOffset.HasValue;
    }
}
