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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Udp Output Settings
    /// </summary>
    public partial class UdpOutputSettings
    {
        /// <summary>
        /// Gets and sets the property BufferMsec. UDP output buffering in milliseconds. Larger
        /// values increase latency through the transcoder but simultaneously assist the transcoder
        /// in maintaining a constant, low-jitter UDP/RTP output while accommodating clock recovery,
        /// input switching, input disruptions, picture reordering, etc.
        /// </summary>
        public int? BufferMsec { get; set; }

        /// <summary>
        /// Checks to see if the BufferMsec property is set.
        /// </summary>
        internal bool IsSetBufferMsec() => this.BufferMsec.HasValue;

        /// <summary>
        /// Gets and sets the property ContainerSettings.
        /// </summary>
        [AWSProperty(Required = true)]
        public UdpContainerSettings ContainerSettings { get; set; }

        /// <summary>
        /// Checks to see if the ContainerSettings property is set.
        /// </summary>
        internal bool IsSetContainerSettings() => this.ContainerSettings != null;

        /// <summary>
        /// Gets and sets the property Destination. Destination address and port number for RTP
        /// or UDP packets. Can be unicast or multicast RTP or UDP (eg. rtp://239.10.10.10:5001
        /// or udp://10.100.100.100:5002).
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputLocationRef Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property FecOutputSettings. Settings for enabling and adjusting
        /// Forward Error Correction on UDP outputs.
        /// </summary>
        public FecOutputSettings FecOutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the FecOutputSettings property is set.
        /// </summary>
        internal bool IsSetFecOutputSettings() => this.FecOutputSettings != null;
    }
}
