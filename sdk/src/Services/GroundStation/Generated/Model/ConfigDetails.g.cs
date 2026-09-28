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
    /// Details for certain <c>Config</c> object types in a contact.
    /// </summary>
    public partial class ConfigDetails
    {
        /// <summary>
        /// Gets and sets the property AntennaDemodDecodeDetails. 
        /// <para>
        /// Details for antenna demod decode <c>Config</c> in a contact.
        /// </para>
        /// </summary>
        public AntennaDemodDecodeDetails AntennaDemodDecodeDetails { get; set; }

        /// <summary>
        /// Checks to see if the AntennaDemodDecodeDetails property is set.
        /// </summary>
        internal bool IsSetAntennaDemodDecodeDetails() => this.AntennaDemodDecodeDetails != null;

        /// <summary>
        /// Gets and sets the property EndpointDetails.
        /// </summary>
        public EndpointDetails EndpointDetails { get; set; }

        /// <summary>
        /// Checks to see if the EndpointDetails property is set.
        /// </summary>
        internal bool IsSetEndpointDetails() => this.EndpointDetails != null;

        /// <summary>
        /// Gets and sets the property S3RecordingDetails. 
        /// <para>
        /// Details for an S3 recording <c>Config</c> in a contact.
        /// </para>
        /// </summary>
        public S3RecordingDetails S3RecordingDetails { get; set; }

        /// <summary>
        /// Checks to see if the S3RecordingDetails property is set.
        /// </summary>
        internal bool IsSetS3RecordingDetails() => this.S3RecordingDetails != null;
    }
}
