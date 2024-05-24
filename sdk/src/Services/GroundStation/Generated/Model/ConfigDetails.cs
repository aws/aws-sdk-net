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
    /// Details for certain <c>Config</c> object types in a contact.
    /// </summary>
    public partial class ConfigDetails
    {
        private AntennaDemodDecodeDetails _antennaDemodDecodeDetails;
        private EndpointDetails _endpointDetails;
        private S3RecordingDetails _s3RecordingDetails;

        /// <summary>
        /// Gets and sets the property AntennaDemodDecodeDetails. 
        /// <para>
        /// Details for antenna demod decode <c>Config</c> in a contact.
        /// </para>
        /// </summary>
        public AntennaDemodDecodeDetails AntennaDemodDecodeDetails
        {
            get { return this._antennaDemodDecodeDetails; }
            set { this._antennaDemodDecodeDetails = value; }
        }

        // Check to see if AntennaDemodDecodeDetails property is set
        internal bool IsSetAntennaDemodDecodeDetails()
        {
            return this._antennaDemodDecodeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointDetails.
        /// </summary>
        public EndpointDetails EndpointDetails
        {
            get { return this._endpointDetails; }
            set { this._endpointDetails = value; }
        }

        // Check to see if EndpointDetails property is set
        internal bool IsSetEndpointDetails()
        {
            return this._endpointDetails != null;
        }

        /// <summary>
        /// Gets and sets the property S3RecordingDetails. 
        /// <para>
        /// Details for an S3 recording <c>Config</c> in a contact.
        /// </para>
        /// </summary>
        public S3RecordingDetails S3RecordingDetails
        {
            get { return this._s3RecordingDetails; }
            set { this._s3RecordingDetails = value; }
        }

        // Check to see if S3RecordingDetails property is set
        internal bool IsSetS3RecordingDetails()
        {
            return this._s3RecordingDetails != null;
        }

    }
}