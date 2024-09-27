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
    /// Srt Output Settings
    /// </summary>
    public partial class SrtOutputSettings
    {
        private int? _bufferMsec;
        private UdpContainerSettings _containerSettings;
        private OutputLocationRef _destination;
        private SrtEncryptionType _encryptionType;
        private int? _latency;

        /// <summary>
        /// Gets and sets the property BufferMsec. SRT output buffering in milliseconds. A higher
        /// value increases latency through the encoder. But the benefits are that it helps to
        /// maintain a constant, low-jitter SRT output, and it accommodates clock recovery, input
        /// switching, input disruptions, picture reordering, and so on. Range: 0-10000 milliseconds.
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
        /// Gets and sets the property Destination.
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
        /// Gets and sets the property EncryptionType. The encryption level for the content. Valid
        /// values are AES128, AES192, AES256. You and the downstream system should plan how to
        /// set this field because the values must not conflict with each other.
        /// </summary>
        public SrtEncryptionType EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property Latency. The latency value, in milliseconds, that is proposed
        /// during the SRT connection handshake. SRT will choose the maximum of the values proposed
        /// by the sender and receiver. On the sender side, latency is the amount of time a packet
        /// is held to give it a chance to be delivered successfully. On the receiver side, latency
        /// is the amount of time the packet is held before delivering to the application, aiding
        /// in packet recovery and matching as closely as possible the packet timing of the sender.
        /// Range: 40-16000 milliseconds.
        /// </summary>
        [AWSProperty(Min=40, Max=16000)]
        public int? Latency
        {
            get { return this._latency; }
            set { this._latency = value; }
        }

        // Check to see if Latency property is set
        internal bool IsSetLatency()
        {
            return this._latency.HasValue; 
        }

    }
}