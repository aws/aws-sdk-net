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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
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
namespace Amazon.IotData.Model
{
    /// <summary>
    /// This is the response object from the GetConnection operation.
    /// </summary>
    public partial class GetConnectionResponse : AmazonWebServiceResponse
    {
        private bool? _cleanSession;
        private string _clientId;
        private bool? _connected;
        private long? _connectedSince;
        private long? _disconnectedSince;
        private string _disconnectReason;
        private int? _keepAliveDuration;
        private long? _sessionExpiry;
        private string _sourceIp;
        private int? _sourcePort;
        private string _targetIp;
        private int? _targetPort;
        private string _thingName;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property CleanSession. 
        /// <para>
        /// Indicates whether the client is using a clean session. Returns <c>true</c> for clean
        /// sessions or <c>false</c> for persistent sessions.
        /// </para>
        /// </summary>
        public bool? CleanSession
        {
            get { return this._cleanSession; }
            set { this._cleanSession = value; }
        }

        // Check to see if CleanSession property is set
        internal bool IsSetCleanSession()
        {
            return this._cleanSession.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier of the MQTT client. This is the same client ID that was used
        /// when the client established the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property Connected. 
        /// <para>
        /// The connection state of the client. Returns <c>true</c> if the client is currently
        /// connected, or <c>false</c> if the client is not connected.
        /// </para>
        /// </summary>
        public bool? Connected
        {
            get { return this._connected; }
            set { this._connected = value; }
        }

        // Check to see if Connected property is set
        internal bool IsSetConnected()
        {
            return this._connected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectedSince. 
        /// <para>
        /// Unix timestamp (in milliseconds) indicating when the client connected. Present only
        /// when connected is true.
        /// </para>
        /// </summary>
        public long? ConnectedSince
        {
            get { return this._connectedSince; }
            set { this._connectedSince = value; }
        }

        // Check to see if ConnectedSince property is set
        internal bool IsSetConnectedSince()
        {
            return this._connectedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisconnectedSince. 
        /// <para>
        /// Unix timestamp (in milliseconds) indicating when the client disconnected. Present
        /// only when connected is false. This information is available for 30 minutes after the
        /// client disconnects.
        /// </para>
        /// </summary>
        public long? DisconnectedSince
        {
            get { return this._disconnectedSince; }
            set { this._disconnectedSince = value; }
        }

        // Check to see if DisconnectedSince property is set
        internal bool IsSetDisconnectedSince()
        {
            return this._disconnectedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisconnectReason. 
        /// <para>
        /// The reason for the last disconnection, if the client is currently disconnected. See
        /// the <a href="https://docs.aws.amazon.com/iot/latest/developerguide/life-cycle-events.html#connect-disconnect">developer
        /// guide</a> for valid disconnect reasons.
        /// </para>
        /// </summary>
        public string DisconnectReason
        {
            get { return this._disconnectReason; }
            set { this._disconnectReason = value; }
        }

        // Check to see if DisconnectReason property is set
        internal bool IsSetDisconnectReason()
        {
            return this._disconnectReason != null;
        }

        /// <summary>
        /// Gets and sets the property KeepAliveDuration. 
        /// <para>
        /// The keep-alive interval in seconds that the client specified when establishing the
        /// connection.
        /// </para>
        /// </summary>
        public int? KeepAliveDuration
        {
            get { return this._keepAliveDuration; }
            set { this._keepAliveDuration = value; }
        }

        // Check to see if KeepAliveDuration property is set
        internal bool IsSetKeepAliveDuration()
        {
            return this._keepAliveDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionExpiry. 
        /// <para>
        /// The session expiry interval in seconds for the MQTT client connection. This is configured
        /// by the user. This value indicates how long the session will remain active after the
        /// client disconnects.
        /// </para>
        /// </summary>
        public long? SessionExpiry
        {
            get { return this._sessionExpiry; }
            set { this._sessionExpiry = value; }
        }

        // Check to see if SessionExpiry property is set
        internal bool IsSetSessionExpiry()
        {
            return this._sessionExpiry.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceIp. 
        /// <para>
        /// The IP address of the client that initiated the connection.
        /// </para>
        /// </summary>
        public string SourceIp
        {
            get { return this._sourceIp; }
            set { this._sourceIp = value; }
        }

        // Check to see if SourceIp property is set
        internal bool IsSetSourceIp()
        {
            return this._sourceIp != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The client's source port.
        /// </para>
        /// </summary>
        public int? SourcePort
        {
            get { return this._sourcePort; }
            set { this._sourcePort = value; }
        }

        // Check to see if SourcePort property is set
        internal bool IsSetSourcePort()
        {
            return this._sourcePort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetIp. 
        /// <para>
        /// The IP address of the Amazon Web Services IoT Core endpoint that the client connected
        /// to. For clients connected to VPC endpoints, this is the private IP address of the
        /// network interface the client is connected to.
        /// </para>
        /// </summary>
        public string TargetIp
        {
            get { return this._targetIp; }
            set { this._targetIp = value; }
        }

        // Check to see if TargetIp property is set
        internal bool IsSetTargetIp()
        {
            return this._targetIp != null;
        }

        /// <summary>
        /// Gets and sets the property TargetPort. 
        /// <para>
        /// The port number of the Amazon Web Services IoT Core endpoint that the client connected
        /// to.
        /// </para>
        /// </summary>
        public int? TargetPort
        {
            get { return this._targetPort; }
            set { this._targetPort = value; }
        }

        // Check to see if TargetPort property is set
        internal bool IsSetTargetPort()
        {
            return this._targetPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing associated with the principal of the MQTT client, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint. Present for clients connected to IoT Core via a <a href="https://docs.aws.amazon.com/iot/latest/developerguide/IoTCore-VPC.html">VPC
        /// endpoint</a>. 
        /// </para>
        /// </summary>
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

    }
}