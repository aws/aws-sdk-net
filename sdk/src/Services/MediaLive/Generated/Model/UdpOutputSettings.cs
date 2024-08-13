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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private int? _bufferMsec;
        private UdpContainerSettings _containerSettings;
        private OutputLocationRef _destination;
        private FecOutputSettings _fecOutputSettings;

        /// <summary>
        /// Gets and sets the property BufferMsec. UDP output buffering in milliseconds. Larger
        /// values increase latency through the transcoder but simultaneously assist the transcoder
        /// in maintaining a constant, low-jitter UDP/RTP output while accommodating clock recovery,
        /// input switching, input disruptions, picture reordering, etc.
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public int? BufferMsec
        {
            get { return this._bufferMsec; }
            set { this._bufferMsec = value; }
        }

        // Check to see if BufferMsec property is set
        internal bool IsSetBufferMsec()
        {
            return this._bufferMsec.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContainerSettings.
        /// </summary>
        [AWSProperty(Required=true)]
        public UdpContainerSettings ContainerSettings
        {
            get { return this._containerSettings; }
            set { this._containerSettings = value; }
        }

        // Check to see if ContainerSettings property is set
        internal bool IsSetContainerSettings()
        {
            return this._containerSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. Destination address and port number for RTP
        /// or UDP packets. Can be unicast or multicast RTP or UDP (eg. rtp://239.10.10.10:5001
        /// or udp://10.100.100.100:5002).
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputLocationRef Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property FecOutputSettings. Settings for enabling and adjusting
        /// Forward Error Correction on UDP outputs.
        /// </summary>
        public FecOutputSettings FecOutputSettings
        {
            get { return this._fecOutputSettings; }
            set { this._fecOutputSettings = value; }
        }

        // Check to see if FecOutputSettings property is set
        internal bool IsSetFecOutputSettings()
        {
            return this._fecOutputSettings != null;
        }

    }
}