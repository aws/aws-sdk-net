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
    /// The output that you want to add to this flow.
    /// </summary>
    public partial class AddOutputRequest
    {
        private List<string> _cidrAllowList = new List<string>();
        private string _description;
        private string _destination;
        private Encryption _encryption;
        private int? _maxLatency;
        private List<MediaStreamOutputConfigurationRequest> _mediaStreamOutputConfigurations = new List<MediaStreamOutputConfigurationRequest>();
        private int? _minLatency;
        private string _name;
        private int? _port;
        private Protocol _protocol;
        private string _remoteId;
        private int? _senderControlPort;
        private int? _smoothingLatency;
        private string _streamId;
        private VpcInterfaceAttachment _vpcInterfaceAttachment;

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
        /// Gets and sets the property Description. A description of the output. This description
        /// appears only on the AWS Elemental MediaConnect console and will not be seen by the
        /// end user.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. The IP address from which video will be sent
        /// to output destinations.
        /// </summary>
        public string Destination
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
        /// Gets and sets the property Encryption. The type of key used for the encryption. If
        /// no keyType is provided, the service will use the default setting (static-key). Allowable
        /// encryption types: static-key.
        /// </summary>
        public Encryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property MaxLatency. The maximum latency in milliseconds. This parameter
        /// applies only to RIST-based, Zixi-based, and Fujitsu-based streams.
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
        /// Gets and sets the property MediaStreamOutputConfigurations. The media streams that
        /// are associated with the output, and the parameters for those associations.
        /// </summary>
        public List<MediaStreamOutputConfigurationRequest> MediaStreamOutputConfigurations
        {
            get { return this._mediaStreamOutputConfigurations; }
            set { this._mediaStreamOutputConfigurations = value; }
        }

        // Check to see if MediaStreamOutputConfigurations property is set
        internal bool IsSetMediaStreamOutputConfigurations()
        {
            return this._mediaStreamOutputConfigurations != null && this._mediaStreamOutputConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MinLatency. The minimum latency in milliseconds for SRT-based
        /// streams. In streams that use the SRT protocol, this value that you set on your MediaConnect
        /// source or output represents the minimal potential latency of that connection. The
        /// latency of the stream is set to the highest number between the sender’s minimum latency
        /// and the receiver’s minimum latency.
        /// </summary>
        public int MinLatency
        {
            get { return this._minLatency.GetValueOrDefault(); }
            set { this._minLatency = value; }
        }

        // Check to see if MinLatency property is set
        internal bool IsSetMinLatency()
        {
            return this._minLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the output. This value must be unique
        /// within the current flow.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Port. The port to use when content is distributed to this
        /// output.
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. The protocol to use for the output.
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
        /// Gets and sets the property RemoteId. The remote ID for the Zixi-pull output stream.
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
        /// Gets and sets the property SenderControlPort. The port that the flow uses to send
        /// outbound requests to initiate connection with the sender.
        /// </summary>
        public int SenderControlPort
        {
            get { return this._senderControlPort.GetValueOrDefault(); }
            set { this._senderControlPort = value; }
        }

        // Check to see if SenderControlPort property is set
        internal bool IsSetSenderControlPort()
        {
            return this._senderControlPort.HasValue; 
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
        /// This parameter applies only to Zixi and SRT caller-based streams.
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

        /// <summary>
        /// Gets and sets the property VpcInterfaceAttachment. The name of the VPC interface attachment
        /// to use for this output.
        /// </summary>
        public VpcInterfaceAttachment VpcInterfaceAttachment
        {
            get { return this._vpcInterfaceAttachment; }
            set { this._vpcInterfaceAttachment = value; }
        }

        // Check to see if VpcInterfaceAttachment property is set
        internal bool IsSetVpcInterfaceAttachment()
        {
            return this._vpcInterfaceAttachment != null;
        }

    }
}