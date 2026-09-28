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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Object containing the parameters of a <c>Config</c>.
    /// 
    ///  
    /// <para>
    /// See the subtype definitions for what each type of <c>Config</c> contains.
    /// </para>
    /// </summary>
    public partial class ConfigTypeData
    {
        /// <summary>
        /// Gets and sets the property AntennaDownlinkConfig. 
        /// <para>
        /// Information about how AWS Ground Station should configure an antenna for downlink
        /// during a contact.
        /// </para>
        /// </summary>
        public AntennaDownlinkConfig AntennaDownlinkConfig { get; set; }

        /// <summary>
        /// Checks to see if the AntennaDownlinkConfig property is set.
        /// </summary>
        internal bool IsSetAntennaDownlinkConfig() => this.AntennaDownlinkConfig != null;

        /// <summary>
        /// Gets and sets the property AntennaDownlinkDemodDecodeConfig. 
        /// <para>
        /// Information about how AWS Ground Station should conﬁgure an antenna for downlink demod
        /// decode during a contact.
        /// </para>
        /// </summary>
        public AntennaDownlinkDemodDecodeConfig AntennaDownlinkDemodDecodeConfig { get; set; }

        /// <summary>
        /// Checks to see if the AntennaDownlinkDemodDecodeConfig property is set.
        /// </summary>
        internal bool IsSetAntennaDownlinkDemodDecodeConfig() => this.AntennaDownlinkDemodDecodeConfig != null;

        /// <summary>
        /// Gets and sets the property AntennaUplinkConfig. 
        /// <para>
        /// Information about how AWS Ground Station should conﬁgure an antenna for uplink during
        /// a contact.
        /// </para>
        /// </summary>
        public AntennaUplinkConfig AntennaUplinkConfig { get; set; }

        /// <summary>
        /// Checks to see if the AntennaUplinkConfig property is set.
        /// </summary>
        internal bool IsSetAntennaUplinkConfig() => this.AntennaUplinkConfig != null;

        /// <summary>
        /// Gets and sets the property DataflowEndpointConfig. 
        /// <para>
        /// Information about the dataflow endpoint <c>Config</c>.
        /// </para>
        /// </summary>
        public DataflowEndpointConfig DataflowEndpointConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataflowEndpointConfig property is set.
        /// </summary>
        internal bool IsSetDataflowEndpointConfig() => this.DataflowEndpointConfig != null;

        /// <summary>
        /// Gets and sets the property S3RecordingConfig. 
        /// <para>
        /// Information about an S3 recording <c>Config</c>.
        /// </para>
        /// </summary>
        public S3RecordingConfig S3RecordingConfig { get; set; }

        /// <summary>
        /// Checks to see if the S3RecordingConfig property is set.
        /// </summary>
        internal bool IsSetS3RecordingConfig() => this.S3RecordingConfig != null;

        /// <summary>
        /// Gets and sets the property TelemetrySinkConfig. 
        /// <para>
        /// Information about a telemetry sink <c>Config</c>.
        /// </para>
        /// </summary>
        public TelemetrySinkConfig TelemetrySinkConfig { get; set; }

        /// <summary>
        /// Checks to see if the TelemetrySinkConfig property is set.
        /// </summary>
        internal bool IsSetTelemetrySinkConfig() => this.TelemetrySinkConfig != null;

        /// <summary>
        /// Gets and sets the property TrackingConfig. 
        /// <para>
        /// Object that determines whether tracking should be used during a contact executed with
        /// this <c>Config</c> in the mission profile. 
        /// </para>
        /// </summary>
        public TrackingConfig TrackingConfig { get; set; }

        /// <summary>
        /// Checks to see if the TrackingConfig property is set.
        /// </summary>
        internal bool IsSetTrackingConfig() => this.TrackingConfig != null;

        /// <summary>
        /// Gets and sets the property UplinkEchoConfig. 
        /// <para>
        /// Information about an uplink echo <c>Config</c>.
        /// </para>
        ///  
        /// <para>
        /// Parameters from the <c>AntennaUplinkConfig</c>, corresponding to the specified <c>
        /// AntennaUplinkConfigArn</c>, are used when this <c>UplinkEchoConfig</c> is used in
        /// a contact.
        /// </para>
        /// </summary>
        public UplinkEchoConfig UplinkEchoConfig { get; set; }

        /// <summary>
        /// Checks to see if the UplinkEchoConfig property is set.
        /// </summary>
        internal bool IsSetUplinkEchoConfig() => this.UplinkEchoConfig != null;
    }
}
