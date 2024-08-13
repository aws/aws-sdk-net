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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Object that describes the frequency bandwidth.
    /// </summary>
    public partial class FrequencyBandwidth
    {
        private BandwidthUnits _units;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Units. 
        /// <para>
        /// Frequency bandwidth units.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BandwidthUnits Units
        {
            get { return this._units; }
            set { this._units = value; }
        }

        // Check to see if Units property is set
        internal bool IsSetUnits()
        {
            return this._units != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Frequency bandwidth value. AWS Ground Station currently has the following bandwidth
        /// limitations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>AntennaDownlinkDemodDecodeconfig</c>, valid values are between 125 kHz to 650
        /// MHz.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>AntennaDownlinkconfig</c>, valid values are between 10 kHz to 54 MHz.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>AntennaUplinkConfig</c>, valid values are between 10 kHz to 54 MHz.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}