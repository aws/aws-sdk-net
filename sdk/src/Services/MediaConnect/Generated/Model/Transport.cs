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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Attributes related to the transport stream that are used in a source or output.
    /// </summary>
    public partial class Transport
    {
        private List<string> _cidrAllowList = new List<string>();
        private int? _maxBitrate;
        private int? _maxLatency;
        private Protocol _protocol;
        private string _remoteId;
        private int? _smoothingLatency;
        private string _streamId;

        /// <summary>
        /// Gets and sets the property CidrAllowList. The range of IP addresses that should be
        /// allowed to initiate output requests to this flow. These IP addresses should be in
        /// the form of a Classless Inter-Domain Routing (CIDR) block; for example, 10.0.0.0/16.
        /// </summary>
        public List<string> CidrAllowList
        {
            get { return this._cidrAllowList; }
            set { this._cidrAllowList = value; }
        }

        // Check to see if CidrAllowList property is set
        internal bool IsSetCidrAllowList()
        {
            return this._cidrAllowList != null && this._cidrAllowList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxBitrate. The smoothing max bitrate for RIST, RTP, and
        /// RTP-FEC streams.
        /// </summary>
        public int MaxBitrate
        {
            get { return this._maxBitrate.GetValueOrDefault(); }
            set { this._maxBitrate = value; }
        }

        // Check to see if MaxBitrate property is set
        internal bool IsSetMaxBitrate()
        {
            return this._maxBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLatency. The maximum latency in milliseconds. This parameter
        /// applies only to RIST-based and Zixi-based streams.
        /// </summary>
        public int MaxLatency
        {
            get { return this._maxLatency.GetValueOrDefault(); }
            set { this._maxLatency = value; }
        }

        // Check to see if MaxLatency property is set
        internal bool IsSetMaxLatency()
        {
            return this._maxLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. The protocol that is used by the source or output.
        /// </summary>
        [AWSProperty(Required=true)]
        public Protocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteId. The remote ID for the Zixi-pull stream.
        /// </summary>
        public string RemoteId
        {
            get { return this._remoteId; }
            set { this._remoteId = value; }
        }

        // Check to see if RemoteId property is set
        internal bool IsSetRemoteId()
        {
            return this._remoteId != null;
        }

        /// <summary>
        /// Gets and sets the property SmoothingLatency. The smoothing latency in milliseconds
        /// for RIST, RTP, and RTP-FEC streams.
        /// </summary>
        public int SmoothingLatency
        {
            get { return this._smoothingLatency.GetValueOrDefault(); }
            set { this._smoothingLatency = value; }
        }

        // Check to see if SmoothingLatency property is set
        internal bool IsSetSmoothingLatency()
        {
            return this._smoothingLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamId. The stream ID that you want to use for this transport.
        /// This parameter applies only to Zixi-based streams.
        /// </summary>
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

    }
}