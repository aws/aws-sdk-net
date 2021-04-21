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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Object containing the parameters of a <code>Config</code>.
    /// 
    ///  
    /// <para>
    /// See the subtype definitions for what each type of <code>Config</code> contains.
    /// </para>
    /// </summary>
    public partial class ConfigTypeData
    {
        private AntennaDownlinkConfig _antennaDownlinkConfig;
        private AntennaDownlinkDemodDecodeConfig _antennaDownlinkDemodDecodeConfig;
        private AntennaUplinkConfig _antennaUplinkConfig;
        private DataflowEndpointConfig _dataflowEndpointConfig;
        private S3RecordingConfig _s3RecordingConfig;
        private TrackingConfig _trackingConfig;
        private UplinkEchoConfig _uplinkEchoConfig;

        /// <summary>
        /// Gets and sets the property AntennaDownlinkConfig. 
        /// <para>
        /// Information about how AWS Ground Station should configure an antenna for downlink
        /// during a contact.
        /// </para>
        /// </summary>
        public AntennaDownlinkConfig AntennaDownlinkConfig
        {
            get { return this._antennaDownlinkConfig; }
            set { this._antennaDownlinkConfig = value; }
        }

        // Check to see if AntennaDownlinkConfig property is set
        internal bool IsSetAntennaDownlinkConfig()
        {
            return this._antennaDownlinkConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AntennaDownlinkDemodDecodeConfig. 
        /// <para>
        /// Information about how AWS Ground Station should conﬁgure an antenna for downlink demod
        /// decode during a contact.
        /// </para>
        /// </summary>
        public AntennaDownlinkDemodDecodeConfig AntennaDownlinkDemodDecodeConfig
        {
            get { return this._antennaDownlinkDemodDecodeConfig; }
            set { this._antennaDownlinkDemodDecodeConfig = value; }
        }

        // Check to see if AntennaDownlinkDemodDecodeConfig property is set
        internal bool IsSetAntennaDownlinkDemodDecodeConfig()
        {
            return this._antennaDownlinkDemodDecodeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AntennaUplinkConfig. 
        /// <para>
        /// Information about how AWS Ground Station should conﬁgure an antenna for uplink during
        /// a contact.
        /// </para>
        /// </summary>
        public AntennaUplinkConfig AntennaUplinkConfig
        {
            get { return this._antennaUplinkConfig; }
            set { this._antennaUplinkConfig = value; }
        }

        // Check to see if AntennaUplinkConfig property is set
        internal bool IsSetAntennaUplinkConfig()
        {
            return this._antennaUplinkConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DataflowEndpointConfig. 
        /// <para>
        /// Information about the dataflow endpoint <code>Config</code>.
        /// </para>
        /// </summary>
        public DataflowEndpointConfig DataflowEndpointConfig
        {
            get { return this._dataflowEndpointConfig; }
            set { this._dataflowEndpointConfig = value; }
        }

        // Check to see if DataflowEndpointConfig property is set
        internal bool IsSetDataflowEndpointConfig()
        {
            return this._dataflowEndpointConfig != null;
        }

        /// <summary>
        /// Gets and sets the property S3RecordingConfig. 
        /// <para>
        /// Information about an S3 recording <code>Config</code>.
        /// </para>
        /// </summary>
        public S3RecordingConfig S3RecordingConfig
        {
            get { return this._s3RecordingConfig; }
            set { this._s3RecordingConfig = value; }
        }

        // Check to see if S3RecordingConfig property is set
        internal bool IsSetS3RecordingConfig()
        {
            return this._s3RecordingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingConfig. 
        /// <para>
        /// Object that determines whether tracking should be used during a contact executed with
        /// this <code>Config</code> in the mission profile. 
        /// </para>
        /// </summary>
        public TrackingConfig TrackingConfig
        {
            get { return this._trackingConfig; }
            set { this._trackingConfig = value; }
        }

        // Check to see if TrackingConfig property is set
        internal bool IsSetTrackingConfig()
        {
            return this._trackingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property UplinkEchoConfig. 
        /// <para>
        /// Information about an uplink echo <code>Config</code>.
        /// </para>
        ///  
        /// <para>
        /// Parameters from the <code>AntennaUplinkConfig</code>, corresponding to the specified
        /// <code>AntennaUplinkConfigArn</code>, are used when this <code>UplinkEchoConfig</code>
        /// is used in a contact.
        /// </para>
        /// </summary>
        public UplinkEchoConfig UplinkEchoConfig
        {
            get { return this._uplinkEchoConfig; }
            set { this._uplinkEchoConfig = value; }
        }

        // Check to see if UplinkEchoConfig property is set
        internal bool IsSetUplinkEchoConfig()
        {
            return this._uplinkEchoConfig != null;
        }

    }
}