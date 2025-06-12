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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A request to add an output to a flow.
    /// </summary>
    public partial class AddOutputRequest
    {
        private List<string> _cidrAllowList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _destination;
        private Encryption _encryption;
        private int? _maxLatency;
        private List<MediaStreamOutputConfigurationRequest> _mediaStreamOutputConfigurations = AWSConfigs.InitializeCollections ? new List<MediaStreamOutputConfigurationRequest>() : null;
        private int? _minLatency;
        private string _name;
        private string _ndiProgramName;
        private int? _ndiSpeedHqQuality;
        private OutputStatus _outputStatus;
        private int? _port;
        private Protocol _protocol;
        private string _remoteId;
        private int? _senderControlPort;
        private int? _smoothingLatency;
        private string _streamId;
        private VpcInterfaceAttachment _vpcInterfaceAttachment;

        /// <summary>
        /// Gets and sets the property CidrAllowList. 
        /// <para>
        ///  The range of IP addresses that should be allowed to initiate output requests to this
        /// flow. These IP addresses should be in the form of a Classless Inter-Domain Routing
        /// (CIDR) block; for example, 10.0.0.0/16.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CidrAllowList
        {
            get { return this._cidrAllowList; }
            set { this._cidrAllowList = value; }
        }

        // Check to see if CidrAllowList property is set
        internal bool IsSetCidrAllowList()
        {
            return this._cidrAllowList != null && (this._cidrAllowList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the output. This description appears only on the Audit Manager console
        /// and will not be seen by the end user.
        /// </para>
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
        /// Gets and sets the property Destination. 
        /// <para>
        ///  The IP address from which video will be sent to output destinations.
        /// </para>
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
        /// Gets and sets the property Encryption. 
        /// <para>
        ///  The type of key used for the encryption. If no keyType is provided, the service will
        /// use the default setting (static-key). Allowable encryption types: static-key.
        /// </para>
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
        /// Gets and sets the property MaxLatency. 
        /// <para>
        ///  The maximum latency in milliseconds. This parameter applies only to RIST-based and
        /// Zixi-based streams.
        /// </para>
        /// </summary>
        public int? MaxLatency
        {
            get { return this._maxLatency; }
            set { this._maxLatency = value; }
        }

        // Check to see if MaxLatency property is set
        internal bool IsSetMaxLatency()
        {
            return this._maxLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediaStreamOutputConfigurations. 
        /// <para>
        ///  The media streams that are associated with the output, and the parameters for those
        /// associations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaStreamOutputConfigurationRequest> MediaStreamOutputConfigurations
        {
            get { return this._mediaStreamOutputConfigurations; }
            set { this._mediaStreamOutputConfigurations = value; }
        }

        // Check to see if MediaStreamOutputConfigurations property is set
        internal bool IsSetMediaStreamOutputConfigurations()
        {
            return this._mediaStreamOutputConfigurations != null && (this._mediaStreamOutputConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MinLatency. 
        /// <para>
        ///  The minimum latency in milliseconds for SRT-based streams. In streams that use the
        /// SRT protocol, this value that you set on your MediaConnect source or output represents
        /// the minimal potential latency of that connection. The latency of the stream is set
        /// to the highest number between the sender’s minimum latency and the receiver’s minimum
        /// latency.
        /// </para>
        /// </summary>
        public int? MinLatency
        {
            get { return this._minLatency; }
            set { this._minLatency = value; }
        }

        // Check to see if MinLatency property is set
        internal bool IsSetMinLatency()
        {
            return this._minLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the output. This value must be unique within the current flow.
        /// </para>
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
        /// Gets and sets the property NdiProgramName. 
        /// <para>
        ///  A suffix for the names of the NDI sources that the flow creates. If a custom name
        /// isn't specified, MediaConnect uses the output name. 
        /// </para>
        /// </summary>
        public string NdiProgramName
        {
            get { return this._ndiProgramName; }
            set { this._ndiProgramName = value; }
        }

        // Check to see if NdiProgramName property is set
        internal bool IsSetNdiProgramName()
        {
            return this._ndiProgramName != null;
        }

        /// <summary>
        /// Gets and sets the property NdiSpeedHqQuality. 
        /// <para>
        /// A quality setting for the NDI Speed HQ encoder. 
        /// </para>
        /// </summary>
        public int? NdiSpeedHqQuality
        {
            get { return this._ndiSpeedHqQuality; }
            set { this._ndiSpeedHqQuality = value; }
        }

        // Check to see if NdiSpeedHqQuality property is set
        internal bool IsSetNdiSpeedHqQuality()
        {
            return this._ndiSpeedHqQuality.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputStatus. 
        /// <para>
        ///  An indication of whether the new output should be enabled or disabled as soon as
        /// it is created. If you don't specify the outputStatus field in your request, MediaConnect
        /// sets it to ENABLED.
        /// </para>
        /// </summary>
        public OutputStatus OutputStatus
        {
            get { return this._outputStatus; }
            set { this._outputStatus = value; }
        }

        // Check to see if OutputStatus property is set
        internal bool IsSetOutputStatus()
        {
            return this._outputStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///  The port to use when content is distributed to this output.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        ///  The protocol to use for the output.
        /// </para>
        ///  <note> 
        /// <para>
        /// Elemental MediaConnect no longer supports the Fujitsu QoS protocol. This reference
        /// is maintained for legacy purposes only.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property RemoteId. 
        /// <para>
        ///  The remote ID for the Zixi-pull output stream.
        /// </para>
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
        /// Gets and sets the property SenderControlPort. 
        /// <para>
        ///  The port that the flow uses to send outbound requests to initiate connection with
        /// the sender.
        /// </para>
        /// </summary>
        public int? SenderControlPort
        {
            get { return this._senderControlPort; }
            set { this._senderControlPort = value; }
        }

        // Check to see if SenderControlPort property is set
        internal bool IsSetSenderControlPort()
        {
            return this._senderControlPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SmoothingLatency. 
        /// <para>
        ///  The smoothing latency in milliseconds for RIST, RTP, and RTP-FEC streams.
        /// </para>
        /// </summary>
        public int? SmoothingLatency
        {
            get { return this._smoothingLatency; }
            set { this._smoothingLatency = value; }
        }

        // Check to see if SmoothingLatency property is set
        internal bool IsSetSmoothingLatency()
        {
            return this._smoothingLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        ///  The stream ID that you want to use for this transport. This parameter applies only
        /// to Zixi and SRT caller-based streams.
        /// </para>
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
        /// Gets and sets the property VpcInterfaceAttachment. 
        /// <para>
        ///  The name of the VPC interface attachment to use for this output.
        /// </para>
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