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
    /// LoRaWANGateway object.
    /// </summary>
    public partial class LoRaWANGateway
    {
        private Beaconing _beaconing;
        private string _gatewayEui;
        private List<List<string>> _joinEuiFilters = new List<List<string>>();
        private List<string> _netIdFilters = new List<string>();
        private string _rfRegion;
        private List<int> _subBands = new List<int>();

        /// <summary>
        /// Gets and sets the property Beaconing. 
        /// <para>
        /// Beaconing object information, which consists of the data rate and frequency parameters.
        /// </para>
        /// </summary>
        public Beaconing Beaconing
        {
            get { return this._beaconing; }
            set { this._beaconing = value; }
        }

        // Check to see if Beaconing property is set
        internal bool IsSetBeaconing()
        {
            return this._beaconing != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayEui. 
        /// <para>
        /// The gateway's EUI value.
        /// </para>
        /// </summary>
        public string GatewayEui
        {
            get { return this._gatewayEui; }
            set { this._gatewayEui = value; }
        }

        // Check to see if GatewayEui property is set
        internal bool IsSetGatewayEui()
        {
            return this._gatewayEui != null;
        }

        /// <summary>
        /// Gets and sets the property JoinEuiFilters.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<List<string>> JoinEuiFilters
        {
            get { return this._joinEuiFilters; }
            set { this._joinEuiFilters = value; }
        }

        // Check to see if JoinEuiFilters property is set
        internal bool IsSetJoinEuiFilters()
        {
            return this._joinEuiFilters != null && this._joinEuiFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetIdFilters.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> NetIdFilters
        {
            get { return this._netIdFilters; }
            set { this._netIdFilters = value; }
        }

        // Check to see if NetIdFilters property is set
        internal bool IsSetNetIdFilters()
        {
            return this._netIdFilters != null && this._netIdFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RfRegion. 
        /// <para>
        /// The frequency band (RFRegion) value.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string RfRegion
        {
            get { return this._rfRegion; }
            set { this._rfRegion = value; }
        }

        // Check to see if RfRegion property is set
        internal bool IsSetRfRegion()
        {
            return this._rfRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SubBands.
        /// </summary>
        [AWSProperty(Min=0, Max=8)]
        public List<int> SubBands
        {
            get { return this._subBands; }
            set { this._subBands = value; }
        }

        // Check to see if SubBands property is set
        internal bool IsSetSubBands()
        {
            return this._subBands != null && this._subBands.Count > 0; 
        }

    }
}