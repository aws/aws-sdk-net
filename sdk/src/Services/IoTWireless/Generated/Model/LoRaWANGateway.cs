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
    /// LoRaWANGateway object.
    /// </summary>
    public partial class LoRaWANGateway
    {
        private Beaconing _beaconing;
        private string _gatewayEui;
        private List<List<string>> _joinEuiFilters = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;
        private float? _maxEirp;
        private List<string> _netIdFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _rfRegion;
        private List<int> _subBands = AWSConfigs.InitializeCollections ? new List<int>() : null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._joinEuiFilters != null && (this._joinEuiFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxEirp. 
        /// <para>
        /// The MaxEIRP value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public float? MaxEirp
        {
            get { return this._maxEirp; }
            set { this._maxEirp = value; }
        }

        // Check to see if MaxEirp property is set
        internal bool IsSetMaxEirp()
        {
            return this._maxEirp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetIdFilters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._netIdFilters != null && (this._netIdFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._subBands != null && (this._subBands.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}